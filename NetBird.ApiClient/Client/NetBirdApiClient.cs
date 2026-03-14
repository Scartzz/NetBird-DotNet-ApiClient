


using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;
using RestSharp.Serializers;
using RestSharpMethod = RestSharp.Method;
using FileIO = System.IO.File;
using Polly;
using NetBird.ApiClient.Model;
using NetBird.ApiClient.Api;

namespace NetBird.ApiClient.Client;


/// <summary>
/// Provides a default implementation of an Api client (both synchronous and asynchronous implementations),
/// encapsulating general REST accessor use cases.
/// </summary>
public class NetBirdApiClient
{
    /// <summary>
    /// Gets or sets the default configuration.
    /// </summary>
    public NetBirdApiClientOptions NetBirdApiClientOptions { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NetBirdApiClient" />, defaulting to the default configurations' base url.
    /// </summary>
    public NetBirdApiClient(NetBirdApiClientOptions? configuration = null)
    {
        this.NetBirdApiClientOptions = configuration ?? new NetBirdApiClientOptions();
    }

    /// <summary>
    /// Constructs the RestSharp version of an http method
    /// </summary>
    /// <param name="method">System.Net.Http HttpMethod</param>
    /// <returns>RestSharp's HttpMethod instance.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private RestSharpMethod Method(HttpMethod method)
    {
        if (method == HttpMethod.Get)
            return RestSharpMethod.Get;
        if (method == HttpMethod.Post)
            return RestSharpMethod.Post;
        if (method == HttpMethod.Put)
            return RestSharpMethod.Put;
        if (method == HttpMethod.Delete)
            return RestSharpMethod.Delete;
        if (method == HttpMethod.Head)
            return RestSharpMethod.Head;
        if (method == HttpMethod.Options)
            return RestSharpMethod.Options;
        if (method == HttpMethod.Patch)
            return RestSharpMethod.Patch;

        throw new ArgumentOutOfRangeException(nameof(method), method, null);
    }

    /// <summary>
    /// Provides all logic for constructing a new RestSharp <see cref="RestRequest"/>.
    /// At this point, all information for querying the service is known. 
    /// Here, it is simply mapped into the RestSharp request.
    /// </summary>
    /// <param name="method">The http verb.</param>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object.
    /// It is assumed that any merge with GlobalConfiguration has been done before calling this method.</param>
    /// <returns>[private] A new RestRequest instance.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    private RestRequest NewRequest(
        HttpMethod method,
        string path,
        IRequestOptions options) 
    {
        ArgumentNullException.ThrowIfNull(path);
        ArgumentNullException.ThrowIfNull(options);

        RestRequest request = new RestRequest(path, Method(method));

        if (options.PathParameters is not null)
        {
            foreach (var pathParam in options.PathParameters)
            {
                request.AddParameter(pathParam.Key, pathParam.Value, ParameterType.UrlSegment);
            }
        }

        if (options.QueryParameters is not null)
        {
            foreach (var queryParam in options.QueryParameters)
            {
                foreach (var value in queryParam.Value)
                {
                    request.AddQueryParameter(queryParam.Key, value);
                }
            }
        }

        if (this.NetBirdApiClientOptions.DefaultHeaders is not null)
        {
            foreach (var headerParam in this.NetBirdApiClientOptions.DefaultHeaders)
            {
                request.AddHeader(headerParam.Key, headerParam.Value);
            }
        }

        // Authentication
        if (!string.IsNullOrEmpty(this.NetBirdApiClientOptions.AccessToken) && !request.Parameters.Any(p => p.Name == "Authorization" && p.Type == ParameterType.HttpHeader))
        {
            request.AddOrUpdateHeader("Authorization", "Bearer " + this.NetBirdApiClientOptions.AccessToken);
        }

        // Accept Header
        if (!request.Parameters.Any(p => p.Name == "Accept" && p.Type == ParameterType.HttpHeader))
        {
            request.AddHeader("Accept", "application/json");
        }

        options.AddDataToRequest(request);

        return request;
    }

    /// <summary>
    /// Transforms a RestResponse instance into a new ApiResponse instance.
    /// At this point, we have a concrete http response from the service.
    /// Here, it is simply mapped into the [public] ApiResponse object.
    /// </summary>
    /// <param name="response">The RestSharp response object</param>
    /// <returns>A new ApiResponse instance.</returns>
    private ApiResponse<T> ToApiResponse<T>(RestResponse<T> response)
    {
        T result = response.Data;
        string rawContent = response.Content;

        var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result, rawContent)
        {
            ErrorText = response.ErrorMessage,
            Cookies = new List<Cookie>()
        };

        if (response.Headers is not null)
        {
            foreach (var responseHeader in response.Headers)
            {
                transformed.Headers.Add(responseHeader.Name, ClientUtils.ParameterToString(responseHeader.Value));
            }
        }

        if (response.ContentHeaders is not null)
        {
            foreach (var responseHeader in response.ContentHeaders)
            {
                transformed.Headers.Add(responseHeader.Name, ClientUtils.ParameterToString(responseHeader.Value));
            }
        }

        if (response.Cookies is not null)
        {
            foreach (var responseCookies in response.Cookies.Cast<Cookie>())
            {
                transformed.Cookies.Add(
                    new Cookie(
                        responseCookies.Name,
                        responseCookies.Value,
                        responseCookies.Path,
                        responseCookies.Domain)
                );
            }
        }

        return transformed;
    }

    /// <summary>
    /// Executes the HTTP request for the current service.
    /// Based on functions received it can be async or sync.
    /// </summary>
    /// <param name="getResponse">Local function that executes http request and returns http response.</param>
    /// <param name="setOptions">Local function to specify options for the service.</param>        
    /// <param name="request">The RestSharp request object</param>
    /// <param name="options">The RestSharp options object</param>
    /// <param name="configuration">A per-request configuration object.
    /// It is assumed that any merge with GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A new ApiResponse instance.</returns>
    private async Task<ApiResponse<T>> ExecClientAsync<T>(Func<RestClient, Task<RestResponse<T>>> getResponse, Action<RestClientOptions> setOptions, RestRequest request, IRequestOptions options) 
    {
        var baseUrl = this.NetBirdApiClientOptions.BaseUrl;
        var clientOptions = new RestClientOptions(baseUrl)
        {
            ClientCertificates = this.NetBirdApiClientOptions.ClientCertificates,
            Timeout = this.NetBirdApiClientOptions.Timeout,
            Proxy = this.NetBirdApiClientOptions.Proxy,
            UserAgent = this.NetBirdApiClientOptions.UserAgent,
            RemoteCertificateValidationCallback = this.NetBirdApiClientOptions.RemoteCertificateValidationCallback
        };
        setOptions(clientOptions);
            
        using (RestClient client = new RestClient(clientOptions))
        {
            RestResponse<T> response = await getResponse(client).ConfigureAwait(false);

            var result = ToApiResponse(response);
            if (response.ErrorMessage is not null)
            {
                result.ErrorText = response.ErrorMessage;
            }

            if (response.Cookies is not null && response.Cookies.Count > 0)
            {
                if (result.Cookies is null) result.Cookies = new List<Cookie>();
                foreach (var restResponseCookie in response.Cookies.Cast<Cookie>())
                {
                    var cookie = new Cookie(
                        restResponseCookie.Name,
                        restResponseCookie.Value,
                        restResponseCookie.Path,
                        restResponseCookie.Domain
                    )
                    {
                        Comment = restResponseCookie.Comment,
                        CommentUri = restResponseCookie.CommentUri,
                        Discard = restResponseCookie.Discard,
                        Expired = restResponseCookie.Expired,
                        Expires = restResponseCookie.Expires,
                        HttpOnly = restResponseCookie.HttpOnly,
                        Port = restResponseCookie.Port,
                        Secure = restResponseCookie.Secure,
                        Version = restResponseCookie.Version
                    };

                    result.Cookies.Add(cookie);
                }
            }
            return result;
        }
    }

    private async Task<RestResponse<T>> DeserializeRestResponseFromPolicyAsync<T>(RestClient client, RestRequest request, PolicyResult<RestResponse> policyResult, CancellationToken cancellationToken = default)
    {
        if (policyResult.Outcome == OutcomeType.Successful) 
        {
            return await client.Deserialize<T>(policyResult.Result, cancellationToken).ConfigureAwait(false);
        }
        else
        {
            return new RestResponse<T>(request)
            {
                ErrorException = policyResult.FinalException
            };
        }
    }
    
    private ApiResponse<T> Exec<T>(RestRequest request, IRequestOptions options)
    {
        Action<RestClientOptions> setOptions = (clientOptions) =>
        {
        };

        Func<RestClient, Task<RestResponse<T>>> getResponse = (client) =>
        {
            if (RetryConfiguration.RetryPolicy is not null)
            {
                var policy = RetryConfiguration.RetryPolicy;
                var policyResult = policy.ExecuteAndCapture(() => client.Execute(request));
                return DeserializeRestResponseFromPolicyAsync<T>(client, request, policyResult);
            }
            else
            {
                return Task.FromResult(client.Execute<T>(request));
            }
        };

        return ExecClientAsync<T>(getResponse, setOptions, request, options).GetAwaiter().GetResult();
    }

    private Task<ApiResponse<T>> ExecAsync<T>(RestRequest request, IRequestOptions options, CancellationToken cancellationToken = default) 
    {
        Action<RestClientOptions> setOptions = (clientOptions) =>
        {
            //no extra options
        };

        Func<RestClient, Task<RestResponse<T>>> getResponse = async (client) =>
        {
            if (RetryConfiguration.AsyncRetryPolicy is not null)
            {
                var policy = RetryConfiguration.AsyncRetryPolicy;
                var policyResult = await policy.ExecuteAndCaptureAsync((ct) => client.ExecuteAsync(request, ct), cancellationToken).ConfigureAwait(false);
                return await DeserializeRestResponseFromPolicyAsync<T>(client, request, policyResult, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await client.ExecuteAsync<T>(request, cancellationToken).ConfigureAwait(false);
            }
        };

        return ExecClientAsync<T>(getResponse, setOptions, request, options);
    }

    #region IAsynchronousClient
    /// <summary>
    /// Make a HTTP GET request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal Task<ApiResponse<T>> GetAsync<T>(string path, IRequestOptions options, CancellationToken cancellationToken = default)
    {
        return ExecAsync<T>(NewRequest(HttpMethod.Get, path, options), options, cancellationToken);
    }

    /// <summary>
    /// Make a HTTP POST request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal Task<ApiResponse<T>> PostAsync<T>(string path, IRequestOptions options, CancellationToken cancellationToken = default)
    {
        return ExecAsync<T>(NewRequest(HttpMethod.Post, path, options), options, cancellationToken);
    }

    /// <summary>
    /// Make a HTTP PUT request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal Task<ApiResponse<T>> PutAsync<T>(string path, IRequestOptions options, CancellationToken cancellationToken = default) 
    {
        return ExecAsync<T>(NewRequest(HttpMethod.Put, path, options), options, cancellationToken);
    }

    /// <summary>
    /// Make a HTTP DELETE request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal Task<ApiResponse<T>> DeleteAsync<T>(string path, IRequestOptions options, CancellationToken cancellationToken = default)
    {
        return ExecAsync<T>(NewRequest(HttpMethod.Delete, path, options), options, cancellationToken);
    }

    /// <summary>
    /// Make a HTTP HEAD request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal Task<ApiResponse<T>> HeadAsync<T>(string path, IRequestOptions options, CancellationToken cancellationToken = default)
    {
        return ExecAsync<T>(NewRequest(HttpMethod.Head, path, options), options, cancellationToken);
    }

    /// <summary>
    /// Make a HTTP OPTION request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal Task<ApiResponse<T>> OptionsAsync<T>(string path, IRequestOptions options, CancellationToken cancellationToken = default)
    {
        return ExecAsync<T>(NewRequest(HttpMethod.Options, path, options), options, cancellationToken);
    }

    /// <summary>
    /// Make a HTTP PATCH request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal Task<ApiResponse<T>> PatchAsync<T>(string path, IRequestOptions options, CancellationToken cancellationToken = default) 
    {
        return ExecAsync<T>(NewRequest(HttpMethod.Patch, path, options), options, cancellationToken);
    }
    #endregion IAsynchronousClient

    #region ISynchronousClient
    /// <summary>
    /// Make a HTTP GET request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal ApiResponse<T> Get<T>(string path, IRequestOptions options)
    {
        return Exec<T>(NewRequest(HttpMethod.Get, path, options), options);
    }

    /// <summary>
    /// Make a HTTP POST request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal ApiResponse<T> Post<T>(string path, IRequestOptions options)
    {
        return Exec<T>(NewRequest(HttpMethod.Post, path, options), options);
    }

    /// <summary>
    /// Make a HTTP PUT request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal ApiResponse<T> Put<T>(string path, IRequestOptions options) 
    {
        return Exec<T>(NewRequest(HttpMethod.Put, path, options), options);
    }

    /// <summary>
    /// Make a HTTP DELETE request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal ApiResponse<T> Delete<T>(string path, IRequestOptions options) 
    {
        return Exec<T>(NewRequest(HttpMethod.Delete, path, options), options);
    }

    /// <summary>
    /// Make a HTTP HEAD request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal ApiResponse<T> Head<T>(string path, IRequestOptions options) 
    {
        return Exec<T>(NewRequest(HttpMethod.Head, path, options), options);
    }

    /// <summary>
    /// Make a HTTP OPTION request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal ApiResponse<T> Options<T>(string path, IRequestOptions options)
    {
        return Exec<T>(NewRequest(HttpMethod.Options, path, options), options);
    }

    /// <summary>
    /// Make a HTTP PATCH request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// default configuration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    internal ApiResponse<T> Patch<T>(string path, IRequestOptions options)
    {
        return Exec<T>(NewRequest(HttpMethod.Patch, path, options), options);
    }
    #endregion ISynchronousClient
    
    #region APIs

    /// <summary>
    /// Gets the AccountsApi
    /// </summary>
    public AccountsApi AccountsApi => new AccountsApi(this);
    /// <summary>
    /// Gets the AWSMarketplaceApi
    /// </summary>
    public AWSMarketplaceApi AWSMarketplaceApi => new AWSMarketplaceApi(this);
    /// <summary>
    /// Gets the CheckoutApi
    /// </summary>
    public CheckoutApi CheckoutApi => new CheckoutApi(this);
    /// <summary>
    /// Gets the DNSApi
    /// </summary>
    public DNSApi DNSApi => new DNSApi(this);
    /// <summary>
    /// Gets the DNSZonesApi
    /// </summary>
    public DNSZonesApi DNSZonesApi => new DNSZonesApi(this);
    /// <summary>
    /// Gets the EDRFalconIntegrationsApi
    /// </summary>
    public EDRFalconIntegrationsApi EDRFalconIntegrationsApi => new EDRFalconIntegrationsApi(this);
    /// <summary>
    /// Gets the EDRHuntressIntegrationsApi
    /// </summary>
    public EDRHuntressIntegrationsApi EDRHuntressIntegrationsApi => new EDRHuntressIntegrationsApi(this);
    /// <summary>
    /// Gets the EDRIntuneIntegrationsApi
    /// </summary>
    public EDRIntuneIntegrationsApi EDRIntuneIntegrationsApi => new EDRIntuneIntegrationsApi(this);
    /// <summary>
    /// Gets the EDRPeersApi
    /// </summary>
    public EDRPeersApi EDRPeersApi => new EDRPeersApi(this);
    /// <summary>
    /// Gets the EDRSentinelOneIntegrationsApi
    /// </summary>
    public EDRSentinelOneIntegrationsApi EDRSentinelOneIntegrationsApi => new EDRSentinelOneIntegrationsApi(this);
    /// <summary>
    /// Gets the EventsApi
    /// </summary>
    public EventsApi EventsApi => new EventsApi(this);
    /// <summary>
    /// Gets the EventStreamingIntegrationsApi
    /// </summary>
    public EventStreamingIntegrationsApi EventStreamingIntegrationsApi => new EventStreamingIntegrationsApi(this);
    /// <summary>
    /// Gets the GeoLocationsApi
    /// </summary>
    public GeoLocationsApi GeoLocationsApi => new GeoLocationsApi(this);
    /// <summary>
    /// Gets the GroupsApi
    /// </summary>
    public GroupsApi GroupsApi => new GroupsApi(this);
    /// <summary>
    /// Gets the IdentityProvidersApi
    /// </summary>
    public IdentityProvidersApi IdentityProvidersApi => new IdentityProvidersApi(this);
    /// <summary>
    /// Gets the IDPApi
    /// </summary>
    public IDPApi IDPApi => new IDPApi(this);
    /// <summary>
    /// Gets the IngressPortsApi
    /// </summary>
    public IngressPortsApi IngressPortsApi => new IngressPortsApi(this);
    /// <summary>
    /// Gets the InstanceApi
    /// </summary>
    public InstanceApi InstanceApi => new InstanceApi(this);
    /// <summary>
    /// Gets the InvoiceApi
    /// </summary>
    public InvoiceApi InvoiceApi => new InvoiceApi(this);
    /// <summary>
    /// Gets the JobsApi
    /// </summary>
    public JobsApi JobsApi => new JobsApi(this);
    /// <summary>
    /// Gets the MSPApi
    /// </summary>
    public MSPApi MSPApi => new MSPApi(this);
    /// <summary>
    /// Gets the NetworksApi
    /// </summary>
    public NetworksApi NetworksApi => new NetworksApi(this);
    /// <summary>
    /// Gets the PeersApi
    /// </summary>
    public PeersApi PeersApi => new PeersApi(this);
    /// <summary>
    /// Gets the PlansApi
    /// </summary>
    public PlansApi PlansApi => new PlansApi(this);
    /// <summary>
    /// Gets the PoliciesApi
    /// </summary>
    public PoliciesApi PoliciesApi => new PoliciesApi(this);
    /// <summary>
    /// Gets the PortalApi
    /// </summary>
    public PortalApi PortalApi => new PortalApi(this);
    /// <summary>
    /// Gets the PostureChecksApi
    /// </summary>
    public PostureChecksApi PostureChecksApi => new PostureChecksApi(this);
    /// <summary>
    /// Gets the RoutesApi
    /// </summary>
    public RoutesApi RoutesApi => new RoutesApi(this);
    /// <summary>
    /// Gets the ServicesApi
    /// </summary>
    public ServicesApi ServicesApi => new ServicesApi(this);
    /// <summary>
    /// Gets the SetupKeysApi
    /// </summary>
    public SetupKeysApi SetupKeysApi => new SetupKeysApi(this);
    /// <summary>
    /// Gets the SubscriptionApi
    /// </summary>
    public SubscriptionApi SubscriptionApi => new SubscriptionApi(this);
    /// <summary>
    /// Gets the TokensApi
    /// </summary>
    public TokensApi TokensApi => new TokensApi(this);
    /// <summary>
    /// Gets the UsageApi
    /// </summary>
    public UsageApi UsageApi => new UsageApi(this);
    /// <summary>
    /// Gets the UsersApi
    /// </summary>
    public UsersApi UsersApi => new UsersApi(this);
    #endregion APIs
}
