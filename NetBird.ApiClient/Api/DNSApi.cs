

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
public class DNSApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DNSApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal DNSApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Nameserver Groups Returns a list of all Nameserver Groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;NameserverGroup&gt;</returns>
    public List<NameserverGroup> ApiDnsNameserversGet()
    {
        ApiResponse<List<NameserverGroup>> localVarResponse = ApiDnsNameserversGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Nameserver Groups Returns a list of all Nameserver Groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;NameserverGroup&gt;</returns>
    public ApiResponse<List<NameserverGroup>> ApiDnsNameserversGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<NameserverGroup>>("dns/nameservers", localVarRequestOptions);
        this.CheckForException("ApiDnsNameserversGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Nameserver Groups Returns a list of all Nameserver Groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;NameserverGroup&gt;</returns>
    public async System.Threading.Tasks.Task<List<NameserverGroup>> ApiDnsNameserversGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<NameserverGroup>> localVarResponse = await ApiDnsNameserversGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Nameserver Groups Returns a list of all Nameserver Groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;NameserverGroup&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<NameserverGroup>>> ApiDnsNameserversGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<NameserverGroup>>("dns/nameservers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsNameserversGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Nameserver Group Delete a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <returns></returns>
    public void ApiDnsNameserversNsgroupIdDelete(string nsgroupId)
    {
        ApiDnsNameserversNsgroupIdDeleteWithHttpInfo(nsgroupId);
    }

    /// <summary>
    /// Delete a Nameserver Group Delete a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiDnsNameserversNsgroupIdDeleteWithHttpInfo(string nsgroupId)
    {
        ValidateParameter(nsgroupId, "nsgroupId", "DNSApi->ApiDnsNameserversNsgroupIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("nsgroupId", ClientUtils.ParameterToString(nsgroupId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("dns/nameservers/{nsgroupId}", localVarRequestOptions);
        this.CheckForException("ApiDnsNameserversNsgroupIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Nameserver Group Delete a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiDnsNameserversNsgroupIdDeleteAsync(string nsgroupId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiDnsNameserversNsgroupIdDeleteWithHttpInfoAsync(nsgroupId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Nameserver Group Delete a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiDnsNameserversNsgroupIdDeleteWithHttpInfoAsync(string nsgroupId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(nsgroupId, "nsgroupId", "DNSApi->ApiDnsNameserversNsgroupIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("nsgroupId", ClientUtils.ParameterToString(nsgroupId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("dns/nameservers/{nsgroupId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsNameserversNsgroupIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Nameserver Group Get information about a Nameserver Groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <returns>NameserverGroup</returns>
    public NameserverGroup ApiDnsNameserversNsgroupIdGet(string nsgroupId)
    {
        ApiResponse<NameserverGroup> localVarResponse = ApiDnsNameserversNsgroupIdGetWithHttpInfo(nsgroupId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Nameserver Group Get information about a Nameserver Groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <returns>ApiResponse of NameserverGroup</returns>
    internal ApiResponse<NameserverGroup> ApiDnsNameserversNsgroupIdGetWithHttpInfo(string nsgroupId)
    {
        ValidateParameter(nsgroupId, "nsgroupId", "DNSApi->ApiDnsNameserversNsgroupIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("nsgroupId", ClientUtils.ParameterToString(nsgroupId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<NameserverGroup>("dns/nameservers/{nsgroupId}", localVarRequestOptions);
        this.CheckForException("ApiDnsNameserversNsgroupIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Nameserver Group Get information about a Nameserver Groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NameserverGroup</returns>
    public async System.Threading.Tasks.Task<NameserverGroup> ApiDnsNameserversNsgroupIdGetAsync(string nsgroupId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NameserverGroup> localVarResponse = await ApiDnsNameserversNsgroupIdGetWithHttpInfoAsync(nsgroupId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Nameserver Group Get information about a Nameserver Groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NameserverGroup)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NameserverGroup>> ApiDnsNameserversNsgroupIdGetWithHttpInfoAsync(string nsgroupId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(nsgroupId, "nsgroupId", "DNSApi->ApiDnsNameserversNsgroupIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("nsgroupId", ClientUtils.ParameterToString(nsgroupId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<NameserverGroup>("dns/nameservers/{nsgroupId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsNameserversNsgroupIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Nameserver Group Update/Replace a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <param name="nameserverGroupRequest">Update Nameserver Group request (optional)</param>
    /// <returns>NameserverGroup</returns>
    public NameserverGroup ApiDnsNameserversNsgroupIdPut(string nsgroupId, NameserverGroupRequest? nameserverGroupRequest = null)
    {
        ApiResponse<NameserverGroup> localVarResponse = ApiDnsNameserversNsgroupIdPutWithHttpInfo(nsgroupId, nameserverGroupRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Nameserver Group Update/Replace a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <param name="nameserverGroupRequest">Update Nameserver Group request (optional)</param>
    /// <returns>ApiResponse of NameserverGroup</returns>
    internal ApiResponse<NameserverGroup> ApiDnsNameserversNsgroupIdPutWithHttpInfo(string nsgroupId, NameserverGroupRequest? nameserverGroupRequest = null)
    {
        ValidateParameter(nsgroupId, "nsgroupId", "DNSApi->ApiDnsNameserversNsgroupIdPut");

        RequestOptions<NameserverGroupRequest> localVarRequestOptions = new RequestOptions<NameserverGroupRequest>();

        localVarRequestOptions.PathParameters.Add("nsgroupId", ClientUtils.ParameterToString(nsgroupId)); // path parameter
        localVarRequestOptions.Data = nameserverGroupRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<NameserverGroup>("dns/nameservers/{nsgroupId}", localVarRequestOptions);
        this.CheckForException("ApiDnsNameserversNsgroupIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Nameserver Group Update/Replace a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <param name="nameserverGroupRequest">Update Nameserver Group request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NameserverGroup</returns>
    public async System.Threading.Tasks.Task<NameserverGroup> ApiDnsNameserversNsgroupIdPutAsync(string nsgroupId, NameserverGroupRequest? nameserverGroupRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NameserverGroup> localVarResponse = await ApiDnsNameserversNsgroupIdPutWithHttpInfoAsync(nsgroupId, nameserverGroupRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Nameserver Group Update/Replace a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nsgroupId">The unique identifier of a Nameserver Group</param>
    /// <param name="nameserverGroupRequest">Update Nameserver Group request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NameserverGroup)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NameserverGroup>> ApiDnsNameserversNsgroupIdPutWithHttpInfoAsync(string nsgroupId, NameserverGroupRequest? nameserverGroupRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(nsgroupId, "nsgroupId", "DNSApi->ApiDnsNameserversNsgroupIdPut");

        RequestOptions<NameserverGroupRequest> localVarRequestOptions = new RequestOptions<NameserverGroupRequest>();

        localVarRequestOptions.PathParameters.Add("nsgroupId", ClientUtils.ParameterToString(nsgroupId)); // path parameter
        localVarRequestOptions.Data = nameserverGroupRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<NameserverGroup>("dns/nameservers/{nsgroupId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsNameserversNsgroupIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Nameserver Group Creates a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nameserverGroupRequest">New Nameserver Groups request (optional)</param>
    /// <returns>NameserverGroup</returns>
    public NameserverGroup ApiDnsNameserversPost(NameserverGroupRequest? nameserverGroupRequest = null)
    {
        ApiResponse<NameserverGroup> localVarResponse = ApiDnsNameserversPostWithHttpInfo(nameserverGroupRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Nameserver Group Creates a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nameserverGroupRequest">New Nameserver Groups request (optional)</param>
    /// <returns>ApiResponse of NameserverGroup</returns>
    internal ApiResponse<NameserverGroup> ApiDnsNameserversPostWithHttpInfo(NameserverGroupRequest? nameserverGroupRequest = null)
    {
        RequestOptions<NameserverGroupRequest> localVarRequestOptions = new RequestOptions<NameserverGroupRequest>();

        localVarRequestOptions.Data = nameserverGroupRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<NameserverGroup>("dns/nameservers", localVarRequestOptions);
        this.CheckForException("ApiDnsNameserversPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Nameserver Group Creates a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nameserverGroupRequest">New Nameserver Groups request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NameserverGroup</returns>
    public async System.Threading.Tasks.Task<NameserverGroup> ApiDnsNameserversPostAsync(NameserverGroupRequest? nameserverGroupRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NameserverGroup> localVarResponse = await ApiDnsNameserversPostWithHttpInfoAsync(nameserverGroupRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Nameserver Group Creates a Nameserver Group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="nameserverGroupRequest">New Nameserver Groups request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NameserverGroup)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NameserverGroup>> ApiDnsNameserversPostWithHttpInfoAsync(NameserverGroupRequest? nameserverGroupRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<NameserverGroupRequest> localVarRequestOptions = new RequestOptions<NameserverGroupRequest>();

        localVarRequestOptions.Data = nameserverGroupRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<NameserverGroup>("dns/nameservers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsNameserversPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve DNS settings Returns a DNS settings object
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>
    public Object ApiDnsSettingsGet()
    {
        ApiResponse<Object> localVarResponse = ApiDnsSettingsGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve DNS settings Returns a DNS settings object
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>
    internal ApiResponse<Object> ApiDnsSettingsGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<Object>("dns/settings", localVarRequestOptions);
        this.CheckForException("ApiDnsSettingsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve DNS settings Returns a DNS settings object
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async System.Threading.Tasks.Task<Object> ApiDnsSettingsGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Object> localVarResponse = await ApiDnsSettingsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve DNS settings Returns a DNS settings object
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Object)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiDnsSettingsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Object>("dns/settings", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsSettingsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update DNS Settings Updates a DNS settings object
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="dNSSettings">A DNS settings object (optional)</param>
    /// <returns>DNSSettings</returns>
    public DNSSettings ApiDnsSettingsPut(DNSSettings? dNSSettings = null)
    {
        ApiResponse<DNSSettings> localVarResponse = ApiDnsSettingsPutWithHttpInfo(dNSSettings);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update DNS Settings Updates a DNS settings object
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="dNSSettings">A DNS settings object (optional)</param>
    /// <returns>ApiResponse of DNSSettings</returns>
    internal ApiResponse<DNSSettings> ApiDnsSettingsPutWithHttpInfo(DNSSettings? dNSSettings = null)
    {
        RequestOptions<DNSSettings> localVarRequestOptions = new RequestOptions<DNSSettings>();

        localVarRequestOptions.Data = dNSSettings;

        // make the HTTP request
        var localVarResponse = this.Client.Put<DNSSettings>("dns/settings", localVarRequestOptions);
        this.CheckForException("ApiDnsSettingsPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update DNS Settings Updates a DNS settings object
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="dNSSettings">A DNS settings object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of DNSSettings</returns>
    public async System.Threading.Tasks.Task<DNSSettings> ApiDnsSettingsPutAsync(DNSSettings? dNSSettings = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<DNSSettings> localVarResponse = await ApiDnsSettingsPutWithHttpInfoAsync(dNSSettings, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update DNS Settings Updates a DNS settings object
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="dNSSettings">A DNS settings object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (DNSSettings)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<DNSSettings>> ApiDnsSettingsPutWithHttpInfoAsync(DNSSettings? dNSSettings = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<DNSSettings> localVarRequestOptions = new RequestOptions<DNSSettings>();

        localVarRequestOptions.Data = dNSSettings;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<DNSSettings>("dns/settings", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsSettingsPut", localVarResponse);

        return localVarResponse;
    }

}




