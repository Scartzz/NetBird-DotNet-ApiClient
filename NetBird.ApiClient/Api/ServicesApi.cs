

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace NetBird.ApiClient.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public class ServicesApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ServicesApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal ServicesApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List available proxy clusters Returns a list of available proxy clusters with their connection status
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;ProxyCluster&gt;</returns>
    public List<ProxyCluster> ApiReverseProxiesClustersGet()
    {
        ApiResponse<List<ProxyCluster>> localVarResponse = ApiReverseProxiesClustersGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List available proxy clusters Returns a list of available proxy clusters with their connection status
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;ProxyCluster&gt;</returns>
    public ApiResponse<List<ProxyCluster>> ApiReverseProxiesClustersGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<ProxyCluster>>("reverse-proxies/clusters", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesClustersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List available proxy clusters Returns a list of available proxy clusters with their connection status
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;ProxyCluster&gt;</returns>
    public async System.Threading.Tasks.Task<List<ProxyCluster>> ApiReverseProxiesClustersGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<ProxyCluster>> localVarResponse = await ApiReverseProxiesClustersGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List available proxy clusters Returns a list of available proxy clusters with their connection status
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;ProxyCluster&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<ProxyCluster>>> ApiReverseProxiesClustersGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<ProxyCluster>>("reverse-proxies/clusters", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesClustersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Custom domain Delete an existing service custom domain
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="domainId">The custom domain ID</param>
    /// <returns></returns>
    public void ApiReverseProxiesDomainsDomainIdDelete(string domainId)
    {
        ApiReverseProxiesDomainsDomainIdDeleteWithHttpInfo(domainId);
    }

    /// <summary>
    /// Delete a Custom domain Delete an existing service custom domain
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="domainId">The custom domain ID</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiReverseProxiesDomainsDomainIdDeleteWithHttpInfo(string domainId)
    {
        ValidateParameter(domainId, "domainId", "ServicesApi->ApiReverseProxiesDomainsDomainIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("domainId", ClientUtils.ParameterToString(domainId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("reverse-proxies/domains/{domainId}", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesDomainsDomainIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Custom domain Delete an existing service custom domain
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="domainId">The custom domain ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiReverseProxiesDomainsDomainIdDeleteAsync(string domainId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiReverseProxiesDomainsDomainIdDeleteWithHttpInfoAsync(domainId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Custom domain Delete an existing service custom domain
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="domainId">The custom domain ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiReverseProxiesDomainsDomainIdDeleteWithHttpInfoAsync(string domainId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(domainId, "domainId", "ServicesApi->ApiReverseProxiesDomainsDomainIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("domainId", ClientUtils.ParameterToString(domainId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("reverse-proxies/domains/{domainId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesDomainsDomainIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Validate a custom domain Trigger domain ownership validation for a custom domain
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="domainId">The custom domain ID</param>
    /// <returns></returns>
    public void ApiReverseProxiesDomainsDomainIdValidateGet(string domainId)
    {
        ApiReverseProxiesDomainsDomainIdValidateGetWithHttpInfo(domainId);
    }

    /// <summary>
    /// Validate a custom domain Trigger domain ownership validation for a custom domain
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="domainId">The custom domain ID</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<Object> ApiReverseProxiesDomainsDomainIdValidateGetWithHttpInfo(string domainId)
    {
        ValidateParameter(domainId, "domainId", "ServicesApi->ApiReverseProxiesDomainsDomainIdValidateGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("domainId", ClientUtils.ParameterToString(domainId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<Object>("reverse-proxies/domains/{domainId}/validate", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesDomainsDomainIdValidateGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Validate a custom domain Trigger domain ownership validation for a custom domain
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="domainId">The custom domain ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiReverseProxiesDomainsDomainIdValidateGetAsync(string domainId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiReverseProxiesDomainsDomainIdValidateGetWithHttpInfoAsync(domainId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Validate a custom domain Trigger domain ownership validation for a custom domain
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="domainId">The custom domain ID</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiReverseProxiesDomainsDomainIdValidateGetWithHttpInfoAsync(string domainId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(domainId, "domainId", "ServicesApi->ApiReverseProxiesDomainsDomainIdValidateGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("domainId", ClientUtils.ParameterToString(domainId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Object>("reverse-proxies/domains/{domainId}/validate", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesDomainsDomainIdValidateGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve Service Domains Get information about domains that can be used for service endpoints.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;ReverseProxyDomain&gt;</returns>
    public List<ReverseProxyDomain> ApiReverseProxiesDomainsGet()
    {
        ApiResponse<List<ReverseProxyDomain>> localVarResponse = ApiReverseProxiesDomainsGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve Service Domains Get information about domains that can be used for service endpoints.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;ReverseProxyDomain&gt;</returns>
    public ApiResponse<List<ReverseProxyDomain>> ApiReverseProxiesDomainsGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<ReverseProxyDomain>>("reverse-proxies/domains", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesDomainsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve Service Domains Get information about domains that can be used for service endpoints.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;ReverseProxyDomain&gt;</returns>
    public async System.Threading.Tasks.Task<List<ReverseProxyDomain>> ApiReverseProxiesDomainsGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<ReverseProxyDomain>> localVarResponse = await ApiReverseProxiesDomainsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve Service Domains Get information about domains that can be used for service endpoints.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;ReverseProxyDomain&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<ReverseProxyDomain>>> ApiReverseProxiesDomainsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<ReverseProxyDomain>>("reverse-proxies/domains", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesDomainsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Custom domain Create a new Custom domain for use with service endpoints, this will trigger an initial validation check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="reverseProxyDomainRequest">Custom domain creation request (optional)</param>
    /// <returns>Service</returns>
    public Service ApiReverseProxiesDomainsPost(ReverseProxyDomainRequest? reverseProxyDomainRequest = null)
    {
        ApiResponse<Service> localVarResponse = ApiReverseProxiesDomainsPostWithHttpInfo(reverseProxyDomainRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Custom domain Create a new Custom domain for use with service endpoints, this will trigger an initial validation check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="reverseProxyDomainRequest">Custom domain creation request (optional)</param>
    /// <returns>ApiResponse of Service</returns>
    internal ApiResponse<Service> ApiReverseProxiesDomainsPostWithHttpInfo(ReverseProxyDomainRequest? reverseProxyDomainRequest = null)
    {
        RequestOptions<ReverseProxyDomainRequest> localVarRequestOptions = new RequestOptions<ReverseProxyDomainRequest>();

        localVarRequestOptions.Data = reverseProxyDomainRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<Service>("reverse-proxies/domains", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesDomainsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Custom domain Create a new Custom domain for use with service endpoints, this will trigger an initial validation check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="reverseProxyDomainRequest">Custom domain creation request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Service</returns>
    public async System.Threading.Tasks.Task<Service> ApiReverseProxiesDomainsPostAsync(ReverseProxyDomainRequest? reverseProxyDomainRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Service> localVarResponse = await ApiReverseProxiesDomainsPostWithHttpInfoAsync(reverseProxyDomainRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Custom domain Create a new Custom domain for use with service endpoints, this will trigger an initial validation check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="reverseProxyDomainRequest">Custom domain creation request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Service)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Service>> ApiReverseProxiesDomainsPostWithHttpInfoAsync(ReverseProxyDomainRequest? reverseProxyDomainRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<ReverseProxyDomainRequest> localVarRequestOptions = new RequestOptions<ReverseProxyDomainRequest>();

        localVarRequestOptions.Data = reverseProxyDomainRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Service>("reverse-proxies/domains", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesDomainsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Services Returns a list of all reverse proxy services
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;Service&gt;</returns>
    public List<Service> ApiReverseProxiesServicesGet()
    {
        ApiResponse<List<Service>> localVarResponse = ApiReverseProxiesServicesGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Services Returns a list of all reverse proxy services
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;Service&gt;</returns>
    public ApiResponse<List<Service>> ApiReverseProxiesServicesGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Service>>("reverse-proxies/services", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesServicesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Services Returns a list of all reverse proxy services
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Service&gt;</returns>
    public async System.Threading.Tasks.Task<List<Service>> ApiReverseProxiesServicesGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Service>> localVarResponse = await ApiReverseProxiesServicesGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Services Returns a list of all reverse proxy services
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Service&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Service>>> ApiReverseProxiesServicesGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Service>>("reverse-proxies/services", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesServicesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Service Creates a new reverse proxy service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceRequest">New service request (optional)</param>
    /// <returns>Service</returns>
    public Service ApiReverseProxiesServicesPost(ServiceRequest? serviceRequest = null)
    {
        ApiResponse<Service> localVarResponse = ApiReverseProxiesServicesPostWithHttpInfo(serviceRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Service Creates a new reverse proxy service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceRequest">New service request (optional)</param>
    /// <returns>ApiResponse of Service</returns>
    internal ApiResponse<Service> ApiReverseProxiesServicesPostWithHttpInfo(ServiceRequest? serviceRequest = null)
    {
        RequestOptions<ServiceRequest> localVarRequestOptions = new RequestOptions<ServiceRequest>();

        localVarRequestOptions.Data = serviceRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<Service>("reverse-proxies/services", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesServicesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Service Creates a new reverse proxy service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceRequest">New service request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Service</returns>
    public async System.Threading.Tasks.Task<Service> ApiReverseProxiesServicesPostAsync(ServiceRequest? serviceRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Service> localVarResponse = await ApiReverseProxiesServicesPostWithHttpInfoAsync(serviceRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Service Creates a new reverse proxy service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceRequest">New service request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Service)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Service>> ApiReverseProxiesServicesPostWithHttpInfoAsync(ServiceRequest? serviceRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<ServiceRequest> localVarRequestOptions = new RequestOptions<ServiceRequest>();

        localVarRequestOptions.Data = serviceRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Service>("reverse-proxies/services", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesServicesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Service Delete an existing service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <returns></returns>
    public void ApiReverseProxiesServicesServiceIdDelete(string serviceId)
    {
        ApiReverseProxiesServicesServiceIdDeleteWithHttpInfo(serviceId);
    }

    /// <summary>
    /// Delete a Service Delete an existing service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<Object> ApiReverseProxiesServicesServiceIdDeleteWithHttpInfo(string serviceId)
    {
        ValidateParameter(serviceId, "serviceId", "ServicesApi->ApiReverseProxiesServicesServiceIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("serviceId", ClientUtils.ParameterToString(serviceId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<Object>("reverse-proxies/services/{serviceId}", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesServicesServiceIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Service Delete an existing service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiReverseProxiesServicesServiceIdDeleteAsync(string serviceId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiReverseProxiesServicesServiceIdDeleteWithHttpInfoAsync(serviceId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Service Delete an existing service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiReverseProxiesServicesServiceIdDeleteWithHttpInfoAsync(string serviceId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(serviceId, "serviceId", "ServicesApi->ApiReverseProxiesServicesServiceIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("serviceId", ClientUtils.ParameterToString(serviceId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("reverse-proxies/services/{serviceId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesServicesServiceIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Service Get information about a specific reverse proxy service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <returns>Service</returns>
    public Service ApiReverseProxiesServicesServiceIdGet(string serviceId)
    {
        ApiResponse<Service> localVarResponse = ApiReverseProxiesServicesServiceIdGetWithHttpInfo(serviceId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Service Get information about a specific reverse proxy service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <returns>ApiResponse of Service</returns>
    internal ApiResponse<Service> ApiReverseProxiesServicesServiceIdGetWithHttpInfo(string serviceId)
    {
        ValidateParameter(serviceId, "serviceId", "ServicesApi->ApiReverseProxiesServicesServiceIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("serviceId", ClientUtils.ParameterToString(serviceId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<Service>("reverse-proxies/services/{serviceId}", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesServicesServiceIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Service Get information about a specific reverse proxy service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Service</returns>
    public async System.Threading.Tasks.Task<Service> ApiReverseProxiesServicesServiceIdGetAsync(string serviceId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Service> localVarResponse = await ApiReverseProxiesServicesServiceIdGetWithHttpInfoAsync(serviceId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Service Get information about a specific reverse proxy service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Service)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Service>> ApiReverseProxiesServicesServiceIdGetWithHttpInfoAsync(string serviceId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(serviceId, "serviceId", "ServicesApi->ApiReverseProxiesServicesServiceIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("serviceId", ClientUtils.ParameterToString(serviceId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Service>("reverse-proxies/services/{serviceId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesServicesServiceIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Service Update an existing service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <param name="serviceRequest">Service update request (optional)</param>
    /// <returns>Service</returns>
    public Service ApiReverseProxiesServicesServiceIdPut(string serviceId, ServiceRequest? serviceRequest = null)
    {
        ApiResponse<Service> localVarResponse = ApiReverseProxiesServicesServiceIdPutWithHttpInfo(serviceId, serviceRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Service Update an existing service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <param name="serviceRequest">Service update request (optional)</param>
    /// <returns>ApiResponse of Service</returns>
    internal ApiResponse<Service> ApiReverseProxiesServicesServiceIdPutWithHttpInfo(string serviceId, ServiceRequest? serviceRequest = null)
    {
        ValidateParameter(serviceId, "serviceId", "ServicesApi->ApiReverseProxiesServicesServiceIdPut");

        RequestOptions<ServiceRequest> localVarRequestOptions = new RequestOptions<ServiceRequest>();

        localVarRequestOptions.PathParameters.Add("serviceId", ClientUtils.ParameterToString(serviceId)); // path parameter
        localVarRequestOptions.Data = serviceRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Service>("reverse-proxies/services/{serviceId}", localVarRequestOptions);
        this.CheckForException("ApiReverseProxiesServicesServiceIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Service Update an existing service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <param name="serviceRequest">Service update request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Service</returns>
    public async System.Threading.Tasks.Task<Service> ApiReverseProxiesServicesServiceIdPutAsync(string serviceId, ServiceRequest? serviceRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Service> localVarResponse = await ApiReverseProxiesServicesServiceIdPutWithHttpInfoAsync(serviceId, serviceRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Service Update an existing service
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceId">The unique identifier of a service</param>
    /// <param name="serviceRequest">Service update request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Service)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Service>> ApiReverseProxiesServicesServiceIdPutWithHttpInfoAsync(string serviceId, ServiceRequest? serviceRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(serviceId, "serviceId", "ServicesApi->ApiReverseProxiesServicesServiceIdPut");

        RequestOptions<ServiceRequest> localVarRequestOptions = new RequestOptions<ServiceRequest>();

        localVarRequestOptions.PathParameters.Add("serviceId", ClientUtils.ParameterToString(serviceId)); // path parameter
        localVarRequestOptions.Data = serviceRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Service>("reverse-proxies/services/{serviceId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiReverseProxiesServicesServiceIdPut", localVarResponse);

        return localVarResponse;
    }

}




