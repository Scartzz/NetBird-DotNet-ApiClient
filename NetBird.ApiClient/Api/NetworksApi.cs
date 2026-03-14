

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
public class NetworksApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NetworksApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal NetworksApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Networks Returns a list of all networks
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;Network&gt;</returns>
    public List<Network> ApiNetworksGet()
    {
        ApiResponse<List<Network>> localVarResponse = ApiNetworksGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Networks Returns a list of all networks
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;Network&gt;</returns>
    public ApiResponse<List<Network>> ApiNetworksGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Network>>("networks", localVarRequestOptions);
        this.CheckForException("ApiNetworksGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Networks Returns a list of all networks
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Network&gt;</returns>
    public async System.Threading.Tasks.Task<List<Network>> ApiNetworksGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Network>> localVarResponse = await ApiNetworksGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Networks Returns a list of all networks
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Network&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Network>>> ApiNetworksGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Network>>("networks", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Network Delete a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <returns></returns>
    public void ApiNetworksNetworkIdDelete(string networkId)
    {
        ApiNetworksNetworkIdDeleteWithHttpInfo(networkId);
    }

    /// <summary>
    /// Delete a Network Delete a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiNetworksNetworkIdDeleteWithHttpInfo(string networkId)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("networks/{networkId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Network Delete a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiNetworksNetworkIdDeleteAsync(string networkId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiNetworksNetworkIdDeleteWithHttpInfoAsync(networkId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Network Delete a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiNetworksNetworkIdDeleteWithHttpInfoAsync(string networkId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("networks/{networkId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Network Get information about a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <returns>Network</returns>
    public Network ApiNetworksNetworkIdGet(string networkId)
    {
        ApiResponse<Network> localVarResponse = ApiNetworksNetworkIdGetWithHttpInfo(networkId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Network Get information about a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <returns>ApiResponse of Network</returns>
    internal ApiResponse<Network> ApiNetworksNetworkIdGetWithHttpInfo(string networkId)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<Network>("networks/{networkId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Network Get information about a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Network</returns>
    public async System.Threading.Tasks.Task<Network> ApiNetworksNetworkIdGetAsync(string networkId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Network> localVarResponse = await ApiNetworksNetworkIdGetWithHttpInfoAsync(networkId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Network Get information about a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Network)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Network>> ApiNetworksNetworkIdGetWithHttpInfoAsync(string networkId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Network>("networks/{networkId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Network Update/Replace a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkRequest">Update Network request (optional)</param>
    /// <returns>Network</returns>
    public Network ApiNetworksNetworkIdPut(string networkId, NetworkRequest? networkRequest = null)
    {
        ApiResponse<Network> localVarResponse = ApiNetworksNetworkIdPutWithHttpInfo(networkId, networkRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Network Update/Replace a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkRequest">Update Network request (optional)</param>
    /// <returns>ApiResponse of Network</returns>
    internal ApiResponse<Network> ApiNetworksNetworkIdPutWithHttpInfo(string networkId, NetworkRequest? networkRequest = null)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdPut");

        RequestOptions<NetworkRequest> localVarRequestOptions = new RequestOptions<NetworkRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.Data = networkRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Network>("networks/{networkId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Network Update/Replace a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkRequest">Update Network request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Network</returns>
    public async System.Threading.Tasks.Task<Network> ApiNetworksNetworkIdPutAsync(string networkId, NetworkRequest? networkRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Network> localVarResponse = await ApiNetworksNetworkIdPutWithHttpInfoAsync(networkId, networkRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Network Update/Replace a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkRequest">Update Network request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Network)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Network>> ApiNetworksNetworkIdPutWithHttpInfoAsync(string networkId, NetworkRequest? networkRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdPut");

        RequestOptions<NetworkRequest> localVarRequestOptions = new RequestOptions<NetworkRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.Data = networkRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Network>("networks/{networkId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Network Resources Returns a list of all resources in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <returns>List&lt;NetworkResource&gt;</returns>
    public List<NetworkResource> ApiNetworksNetworkIdResourcesGet(string networkId)
    {
        ApiResponse<List<NetworkResource>> localVarResponse = ApiNetworksNetworkIdResourcesGetWithHttpInfo(networkId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Network Resources Returns a list of all resources in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <returns>ApiResponse of List&lt;NetworkResource&gt;</returns>
    public ApiResponse<List<NetworkResource>> ApiNetworksNetworkIdResourcesGetWithHttpInfo(string networkId)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<NetworkResource>>("networks/{networkId}/resources", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdResourcesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Network Resources Returns a list of all resources in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;NetworkResource&gt;</returns>
    public async System.Threading.Tasks.Task<List<NetworkResource>> ApiNetworksNetworkIdResourcesGetAsync(string networkId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<NetworkResource>> localVarResponse = await ApiNetworksNetworkIdResourcesGetWithHttpInfoAsync(networkId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Network Resources Returns a list of all resources in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;NetworkResource&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<NetworkResource>>> ApiNetworksNetworkIdResourcesGetWithHttpInfoAsync(string networkId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<NetworkResource>>("networks/{networkId}/resources", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdResourcesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Network Resource Creates a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkResourceRequest">New Network Resource request (optional)</param>
    /// <returns>NetworkResource</returns>
    public NetworkResource ApiNetworksNetworkIdResourcesPost(string networkId, NetworkResourceRequest? networkResourceRequest = null)
    {
        ApiResponse<NetworkResource> localVarResponse = ApiNetworksNetworkIdResourcesPostWithHttpInfo(networkId, networkResourceRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Network Resource Creates a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkResourceRequest">New Network Resource request (optional)</param>
    /// <returns>ApiResponse of NetworkResource</returns>
    internal ApiResponse<NetworkResource> ApiNetworksNetworkIdResourcesPostWithHttpInfo(string networkId, NetworkResourceRequest? networkResourceRequest = null)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesPost");

        RequestOptions<NetworkResourceRequest> localVarRequestOptions = new RequestOptions<NetworkResourceRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.Data = networkResourceRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<NetworkResource>("networks/{networkId}/resources", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdResourcesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Network Resource Creates a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkResourceRequest">New Network Resource request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NetworkResource</returns>
    public async System.Threading.Tasks.Task<NetworkResource> ApiNetworksNetworkIdResourcesPostAsync(string networkId, NetworkResourceRequest? networkResourceRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NetworkResource> localVarResponse = await ApiNetworksNetworkIdResourcesPostWithHttpInfoAsync(networkId, networkResourceRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Network Resource Creates a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkResourceRequest">New Network Resource request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NetworkResource)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NetworkResource>> ApiNetworksNetworkIdResourcesPostWithHttpInfoAsync(string networkId, NetworkResourceRequest? networkResourceRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesPost");

        RequestOptions<NetworkResourceRequest> localVarRequestOptions = new RequestOptions<NetworkResourceRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.Data = networkResourceRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<NetworkResource>("networks/{networkId}/resources", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdResourcesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Network Resource Delete a network resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId"></param>
    /// <param name="resourceId"></param>
    /// <returns></returns>
    public void ApiNetworksNetworkIdResourcesResourceIdDelete(string networkId, string resourceId)
    {
        ApiNetworksNetworkIdResourcesResourceIdDeleteWithHttpInfo(networkId, resourceId);
    }

    /// <summary>
    /// Delete a Network Resource Delete a network resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId"></param>
    /// <param name="resourceId"></param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<Object> ApiNetworksNetworkIdResourcesResourceIdDeleteWithHttpInfo(string networkId, string resourceId)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdDelete");

        ValidateParameter(resourceId, "resourceId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("resourceId", ClientUtils.ParameterToString(resourceId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<Object>("networks/{networkId}/resources/{resourceId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdResourcesResourceIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Network Resource Delete a network resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId"></param>
    /// <param name="resourceId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiNetworksNetworkIdResourcesResourceIdDeleteAsync(string networkId, string resourceId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiNetworksNetworkIdResourcesResourceIdDeleteWithHttpInfoAsync(networkId, resourceId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Network Resource Delete a network resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId"></param>
    /// <param name="resourceId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiNetworksNetworkIdResourcesResourceIdDeleteWithHttpInfoAsync(string networkId, string resourceId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdDelete");

        ValidateParameter(resourceId, "resourceId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("resourceId", ClientUtils.ParameterToString(resourceId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("networks/{networkId}/resources/{resourceId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdResourcesResourceIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Network Resource Get information about a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="resourceId">The unique identifier of a network resource</param>
    /// <returns>NetworkResource</returns>
    public NetworkResource ApiNetworksNetworkIdResourcesResourceIdGet(string networkId, string resourceId)
    {
        ApiResponse<NetworkResource> localVarResponse = ApiNetworksNetworkIdResourcesResourceIdGetWithHttpInfo(networkId, resourceId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Network Resource Get information about a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="resourceId">The unique identifier of a network resource</param>
    /// <returns>ApiResponse of NetworkResource</returns>
    internal ApiResponse<NetworkResource> ApiNetworksNetworkIdResourcesResourceIdGetWithHttpInfo(string networkId, string resourceId)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdGet");

        ValidateParameter(resourceId, "resourceId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("resourceId", ClientUtils.ParameterToString(resourceId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<NetworkResource>("networks/{networkId}/resources/{resourceId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdResourcesResourceIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Network Resource Get information about a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="resourceId">The unique identifier of a network resource</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NetworkResource</returns>
    public async System.Threading.Tasks.Task<NetworkResource> ApiNetworksNetworkIdResourcesResourceIdGetAsync(string networkId, string resourceId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NetworkResource> localVarResponse = await ApiNetworksNetworkIdResourcesResourceIdGetWithHttpInfoAsync(networkId, resourceId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Network Resource Get information about a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="resourceId">The unique identifier of a network resource</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NetworkResource)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NetworkResource>> ApiNetworksNetworkIdResourcesResourceIdGetWithHttpInfoAsync(string networkId, string resourceId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdGet");

        ValidateParameter(resourceId, "resourceId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("resourceId", ClientUtils.ParameterToString(resourceId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<NetworkResource>("networks/{networkId}/resources/{resourceId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdResourcesResourceIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Network Resource Update a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="resourceId">The unique identifier of a resource</param>
    /// <param name="networkResourceRequest">Update Network Resource request (optional)</param>
    /// <returns>NetworkResource</returns>
    public NetworkResource ApiNetworksNetworkIdResourcesResourceIdPut(string networkId, string resourceId, NetworkResourceRequest? networkResourceRequest = null)
    {
        ApiResponse<NetworkResource> localVarResponse = ApiNetworksNetworkIdResourcesResourceIdPutWithHttpInfo(networkId, resourceId, networkResourceRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Network Resource Update a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="resourceId">The unique identifier of a resource</param>
    /// <param name="networkResourceRequest">Update Network Resource request (optional)</param>
    /// <returns>ApiResponse of NetworkResource</returns>
    internal ApiResponse<NetworkResource> ApiNetworksNetworkIdResourcesResourceIdPutWithHttpInfo(string networkId, string resourceId, NetworkResourceRequest? networkResourceRequest = null)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdPut");

        ValidateParameter(resourceId, "resourceId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdPut");

        RequestOptions<NetworkResourceRequest> localVarRequestOptions = new RequestOptions<NetworkResourceRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("resourceId", ClientUtils.ParameterToString(resourceId)); // path parameter
        localVarRequestOptions.Data = networkResourceRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<NetworkResource>("networks/{networkId}/resources/{resourceId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdResourcesResourceIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Network Resource Update a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="resourceId">The unique identifier of a resource</param>
    /// <param name="networkResourceRequest">Update Network Resource request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NetworkResource</returns>
    public async System.Threading.Tasks.Task<NetworkResource> ApiNetworksNetworkIdResourcesResourceIdPutAsync(string networkId, string resourceId, NetworkResourceRequest? networkResourceRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NetworkResource> localVarResponse = await ApiNetworksNetworkIdResourcesResourceIdPutWithHttpInfoAsync(networkId, resourceId, networkResourceRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Network Resource Update a Network Resource
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="resourceId">The unique identifier of a resource</param>
    /// <param name="networkResourceRequest">Update Network Resource request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NetworkResource)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NetworkResource>> ApiNetworksNetworkIdResourcesResourceIdPutWithHttpInfoAsync(string networkId, string resourceId, NetworkResourceRequest? networkResourceRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdPut");

        ValidateParameter(resourceId, "resourceId", "NetworksApi->ApiNetworksNetworkIdResourcesResourceIdPut");

        RequestOptions<NetworkResourceRequest> localVarRequestOptions = new RequestOptions<NetworkResourceRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("resourceId", ClientUtils.ParameterToString(resourceId)); // path parameter
        localVarRequestOptions.Data = networkResourceRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<NetworkResource>("networks/{networkId}/resources/{resourceId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdResourcesResourceIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Network Routers Returns a list of all routers in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <returns>List&lt;NetworkRouter&gt;</returns>
    public List<NetworkRouter> ApiNetworksNetworkIdRoutersGet(string networkId)
    {
        ApiResponse<List<NetworkRouter>> localVarResponse = ApiNetworksNetworkIdRoutersGetWithHttpInfo(networkId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Network Routers Returns a list of all routers in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <returns>ApiResponse of List&lt;NetworkRouter&gt;</returns>
    public ApiResponse<List<NetworkRouter>> ApiNetworksNetworkIdRoutersGetWithHttpInfo(string networkId)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<NetworkRouter>>("networks/{networkId}/routers", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdRoutersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Network Routers Returns a list of all routers in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;NetworkRouter&gt;</returns>
    public async System.Threading.Tasks.Task<List<NetworkRouter>> ApiNetworksNetworkIdRoutersGetAsync(string networkId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<NetworkRouter>> localVarResponse = await ApiNetworksNetworkIdRoutersGetWithHttpInfoAsync(networkId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Network Routers Returns a list of all routers in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;NetworkRouter&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<NetworkRouter>>> ApiNetworksNetworkIdRoutersGetWithHttpInfoAsync(string networkId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<NetworkRouter>>("networks/{networkId}/routers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdRoutersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Network Router Creates a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkRouterRequest">New Network Router request (optional)</param>
    /// <returns>NetworkRouter</returns>
    public NetworkRouter ApiNetworksNetworkIdRoutersPost(string networkId, NetworkRouterRequest? networkRouterRequest = null)
    {
        ApiResponse<NetworkRouter> localVarResponse = ApiNetworksNetworkIdRoutersPostWithHttpInfo(networkId, networkRouterRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Network Router Creates a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkRouterRequest">New Network Router request (optional)</param>
    /// <returns>ApiResponse of NetworkRouter</returns>
    internal ApiResponse<NetworkRouter> ApiNetworksNetworkIdRoutersPostWithHttpInfo(string networkId, NetworkRouterRequest? networkRouterRequest = null)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersPost");

        RequestOptions<NetworkRouterRequest> localVarRequestOptions = new RequestOptions<NetworkRouterRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.Data = networkRouterRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<NetworkRouter>("networks/{networkId}/routers", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdRoutersPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Network Router Creates a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkRouterRequest">New Network Router request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NetworkRouter</returns>
    public async System.Threading.Tasks.Task<NetworkRouter> ApiNetworksNetworkIdRoutersPostAsync(string networkId, NetworkRouterRequest? networkRouterRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NetworkRouter> localVarResponse = await ApiNetworksNetworkIdRoutersPostWithHttpInfoAsync(networkId, networkRouterRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Network Router Creates a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="networkRouterRequest">New Network Router request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NetworkRouter)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NetworkRouter>> ApiNetworksNetworkIdRoutersPostWithHttpInfoAsync(string networkId, NetworkRouterRequest? networkRouterRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersPost");

        RequestOptions<NetworkRouterRequest> localVarRequestOptions = new RequestOptions<NetworkRouterRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.Data = networkRouterRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<NetworkRouter>("networks/{networkId}/routers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdRoutersPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Network Router Delete a network router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId"></param>
    /// <param name="routerId"></param>
    /// <returns></returns>
    public void ApiNetworksNetworkIdRoutersRouterIdDelete(string networkId, string routerId)
    {
        ApiNetworksNetworkIdRoutersRouterIdDeleteWithHttpInfo(networkId, routerId);
    }

    /// <summary>
    /// Delete a Network Router Delete a network router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId"></param>
    /// <param name="routerId"></param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<Object> ApiNetworksNetworkIdRoutersRouterIdDeleteWithHttpInfo(string networkId, string routerId)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdDelete");

        ValidateParameter(routerId, "routerId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("routerId", ClientUtils.ParameterToString(routerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<Object>("networks/{networkId}/routers/{routerId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdRoutersRouterIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Network Router Delete a network router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId"></param>
    /// <param name="routerId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiNetworksNetworkIdRoutersRouterIdDeleteAsync(string networkId, string routerId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiNetworksNetworkIdRoutersRouterIdDeleteWithHttpInfoAsync(networkId, routerId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Network Router Delete a network router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId"></param>
    /// <param name="routerId"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiNetworksNetworkIdRoutersRouterIdDeleteWithHttpInfoAsync(string networkId, string routerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdDelete");

        ValidateParameter(routerId, "routerId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("routerId", ClientUtils.ParameterToString(routerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("networks/{networkId}/routers/{routerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdRoutersRouterIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Network Router Get information about a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="routerId">The unique identifier of a router</param>
    /// <returns>NetworkRouter</returns>
    public NetworkRouter ApiNetworksNetworkIdRoutersRouterIdGet(string networkId, string routerId)
    {
        ApiResponse<NetworkRouter> localVarResponse = ApiNetworksNetworkIdRoutersRouterIdGetWithHttpInfo(networkId, routerId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Network Router Get information about a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="routerId">The unique identifier of a router</param>
    /// <returns>ApiResponse of NetworkRouter</returns>
    internal ApiResponse<NetworkRouter> ApiNetworksNetworkIdRoutersRouterIdGetWithHttpInfo(string networkId, string routerId)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdGet");

        ValidateParameter(routerId, "routerId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("routerId", ClientUtils.ParameterToString(routerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<NetworkRouter>("networks/{networkId}/routers/{routerId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdRoutersRouterIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Network Router Get information about a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="routerId">The unique identifier of a router</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NetworkRouter</returns>
    public async System.Threading.Tasks.Task<NetworkRouter> ApiNetworksNetworkIdRoutersRouterIdGetAsync(string networkId, string routerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NetworkRouter> localVarResponse = await ApiNetworksNetworkIdRoutersRouterIdGetWithHttpInfoAsync(networkId, routerId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Network Router Get information about a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="routerId">The unique identifier of a router</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NetworkRouter)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NetworkRouter>> ApiNetworksNetworkIdRoutersRouterIdGetWithHttpInfoAsync(string networkId, string routerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdGet");

        ValidateParameter(routerId, "routerId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("routerId", ClientUtils.ParameterToString(routerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<NetworkRouter>("networks/{networkId}/routers/{routerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdRoutersRouterIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Network Router Update a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="routerId">The unique identifier of a router</param>
    /// <param name="networkRouterRequest">Update Network Router request (optional)</param>
    /// <returns>NetworkRouter</returns>
    public NetworkRouter ApiNetworksNetworkIdRoutersRouterIdPut(string networkId, string routerId, NetworkRouterRequest? networkRouterRequest = null)
    {
        ApiResponse<NetworkRouter> localVarResponse = ApiNetworksNetworkIdRoutersRouterIdPutWithHttpInfo(networkId, routerId, networkRouterRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Network Router Update a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="routerId">The unique identifier of a router</param>
    /// <param name="networkRouterRequest">Update Network Router request (optional)</param>
    /// <returns>ApiResponse of NetworkRouter</returns>
    internal ApiResponse<NetworkRouter> ApiNetworksNetworkIdRoutersRouterIdPutWithHttpInfo(string networkId, string routerId, NetworkRouterRequest? networkRouterRequest = null)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdPut");

        ValidateParameter(routerId, "routerId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdPut");

        RequestOptions<NetworkRouterRequest> localVarRequestOptions = new RequestOptions<NetworkRouterRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("routerId", ClientUtils.ParameterToString(routerId)); // path parameter
        localVarRequestOptions.Data = networkRouterRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<NetworkRouter>("networks/{networkId}/routers/{routerId}", localVarRequestOptions);
        this.CheckForException("ApiNetworksNetworkIdRoutersRouterIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Network Router Update a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="routerId">The unique identifier of a router</param>
    /// <param name="networkRouterRequest">Update Network Router request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NetworkRouter</returns>
    public async System.Threading.Tasks.Task<NetworkRouter> ApiNetworksNetworkIdRoutersRouterIdPutAsync(string networkId, string routerId, NetworkRouterRequest? networkRouterRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NetworkRouter> localVarResponse = await ApiNetworksNetworkIdRoutersRouterIdPutWithHttpInfoAsync(networkId, routerId, networkRouterRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Network Router Update a Network Router
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkId">The unique identifier of a network</param>
    /// <param name="routerId">The unique identifier of a router</param>
    /// <param name="networkRouterRequest">Update Network Router request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NetworkRouter)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NetworkRouter>> ApiNetworksNetworkIdRoutersRouterIdPutWithHttpInfoAsync(string networkId, string routerId, NetworkRouterRequest? networkRouterRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(networkId, "networkId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdPut");

        ValidateParameter(routerId, "routerId", "NetworksApi->ApiNetworksNetworkIdRoutersRouterIdPut");

        RequestOptions<NetworkRouterRequest> localVarRequestOptions = new RequestOptions<NetworkRouterRequest>();

        localVarRequestOptions.PathParameters.Add("networkId", ClientUtils.ParameterToString(networkId)); // path parameter
        localVarRequestOptions.PathParameters.Add("routerId", ClientUtils.ParameterToString(routerId)); // path parameter
        localVarRequestOptions.Data = networkRouterRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<NetworkRouter>("networks/{networkId}/routers/{routerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksNetworkIdRoutersRouterIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Network Creates a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkRequest">New Network request (optional)</param>
    /// <returns>Network</returns>
    public Network ApiNetworksPost(NetworkRequest? networkRequest = null)
    {
        ApiResponse<Network> localVarResponse = ApiNetworksPostWithHttpInfo(networkRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Network Creates a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkRequest">New Network request (optional)</param>
    /// <returns>ApiResponse of Network</returns>
    internal ApiResponse<Network> ApiNetworksPostWithHttpInfo(NetworkRequest? networkRequest = null)
    {
        RequestOptions<NetworkRequest> localVarRequestOptions = new RequestOptions<NetworkRequest>();

        localVarRequestOptions.Data = networkRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<Network>("networks", localVarRequestOptions);
        this.CheckForException("ApiNetworksPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Network Creates a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkRequest">New Network request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Network</returns>
    public async System.Threading.Tasks.Task<Network> ApiNetworksPostAsync(NetworkRequest? networkRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Network> localVarResponse = await ApiNetworksPostWithHttpInfoAsync(networkRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Network Creates a Network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="networkRequest">New Network request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Network)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Network>> ApiNetworksPostWithHttpInfoAsync(NetworkRequest? networkRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<NetworkRequest> localVarRequestOptions = new RequestOptions<NetworkRequest>();

        localVarRequestOptions.Data = networkRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Network>("networks", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Network Routers Returns a list of all routers in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;NetworkRouter&gt;</returns>
    public List<NetworkRouter> ApiNetworksRoutersGet()
    {
        ApiResponse<List<NetworkRouter>> localVarResponse = ApiNetworksRoutersGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Network Routers Returns a list of all routers in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;NetworkRouter&gt;</returns>
    public ApiResponse<List<NetworkRouter>> ApiNetworksRoutersGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<NetworkRouter>>("networks/routers", localVarRequestOptions);
        this.CheckForException("ApiNetworksRoutersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Network Routers Returns a list of all routers in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;NetworkRouter&gt;</returns>
    public async System.Threading.Tasks.Task<List<NetworkRouter>> ApiNetworksRoutersGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<NetworkRouter>> localVarResponse = await ApiNetworksRoutersGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Network Routers Returns a list of all routers in a network
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;NetworkRouter&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<NetworkRouter>>> ApiNetworksRoutersGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<NetworkRouter>>("networks/routers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiNetworksRoutersGet", localVarResponse);

        return localVarResponse;
    }

}




