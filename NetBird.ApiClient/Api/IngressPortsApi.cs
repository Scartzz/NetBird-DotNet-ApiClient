

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
public class IngressPortsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal IngressPortsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Ingress Peers Returns a list of all ingress peers
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;IngressPeer&gt;</returns>
    public List<IngressPeer> ApiIngressPeersGet()
    {
        ApiResponse<List<IngressPeer>> localVarResponse = ApiIngressPeersGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Ingress Peers Returns a list of all ingress peers
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;IngressPeer&gt;</returns>
    public ApiResponse<List<IngressPeer>> ApiIngressPeersGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<IngressPeer>>("ingress/peers", localVarRequestOptions);
        this.CheckForException("ApiIngressPeersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Ingress Peers Returns a list of all ingress peers
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;IngressPeer&gt;</returns>
    public async System.Threading.Tasks.Task<List<IngressPeer>> ApiIngressPeersGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<IngressPeer>> localVarResponse = await ApiIngressPeersGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Ingress Peers Returns a list of all ingress peers
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;IngressPeer&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<IngressPeer>>> ApiIngressPeersGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<IngressPeer>>("ingress/peers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIngressPeersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Ingress Peer Delete an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <returns></returns>
    public void ApiIngressPeersIngressPeerIdDelete(string ingressPeerId)
    {
        ApiIngressPeersIngressPeerIdDeleteWithHttpInfo(ingressPeerId);
    }

    /// <summary>
    /// Delete a Ingress Peer Delete an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIngressPeersIngressPeerIdDeleteWithHttpInfo(string ingressPeerId)
    {
        ValidateParameter(ingressPeerId, "ingressPeerId", "IngressPortsApi->ApiIngressPeersIngressPeerIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("ingressPeerId", ClientUtils.ParameterToString(ingressPeerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("ingress/peers/{ingressPeerId}", localVarRequestOptions);
        this.CheckForException("ApiIngressPeersIngressPeerIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Ingress Peer Delete an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIngressPeersIngressPeerIdDeleteAsync(string ingressPeerId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIngressPeersIngressPeerIdDeleteWithHttpInfoAsync(ingressPeerId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Ingress Peer Delete an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiIngressPeersIngressPeerIdDeleteWithHttpInfoAsync(string ingressPeerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(ingressPeerId, "ingressPeerId", "IngressPortsApi->ApiIngressPeersIngressPeerIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("ingressPeerId", ClientUtils.ParameterToString(ingressPeerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("ingress/peers/{ingressPeerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIngressPeersIngressPeerIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Ingress Peer Get information about an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <returns>IngressPeer</returns>
    public IngressPeer ApiIngressPeersIngressPeerIdGet(string ingressPeerId)
    {
        ApiResponse<IngressPeer> localVarResponse = ApiIngressPeersIngressPeerIdGetWithHttpInfo(ingressPeerId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Ingress Peer Get information about an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <returns>ApiResponse of IngressPeer</returns>
    internal ApiResponse<IngressPeer> ApiIngressPeersIngressPeerIdGetWithHttpInfo(string ingressPeerId)
    {
        ValidateParameter(ingressPeerId, "ingressPeerId", "IngressPortsApi->ApiIngressPeersIngressPeerIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("ingressPeerId", ClientUtils.ParameterToString(ingressPeerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<IngressPeer>("ingress/peers/{ingressPeerId}", localVarRequestOptions);
        this.CheckForException("ApiIngressPeersIngressPeerIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Ingress Peer Get information about an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IngressPeer</returns>
    public async System.Threading.Tasks.Task<IngressPeer> ApiIngressPeersIngressPeerIdGetAsync(string ingressPeerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IngressPeer> localVarResponse = await ApiIngressPeersIngressPeerIdGetWithHttpInfoAsync(ingressPeerId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Ingress Peer Get information about an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IngressPeer)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IngressPeer>> ApiIngressPeersIngressPeerIdGetWithHttpInfoAsync(string ingressPeerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(ingressPeerId, "ingressPeerId", "IngressPortsApi->ApiIngressPeersIngressPeerIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("ingressPeerId", ClientUtils.ParameterToString(ingressPeerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<IngressPeer>("ingress/peers/{ingressPeerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIngressPeersIngressPeerIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Ingress Peer Update information about an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <param name="ingressPeerUpdateRequest">update an ingress peer (optional)</param>
    /// <returns>IngressPeer</returns>
    public IngressPeer ApiIngressPeersIngressPeerIdPut(string ingressPeerId, IngressPeerUpdateRequest? ingressPeerUpdateRequest = null)
    {
        ApiResponse<IngressPeer> localVarResponse = ApiIngressPeersIngressPeerIdPutWithHttpInfo(ingressPeerId, ingressPeerUpdateRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Ingress Peer Update information about an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <param name="ingressPeerUpdateRequest">update an ingress peer (optional)</param>
    /// <returns>ApiResponse of IngressPeer</returns>
    internal ApiResponse<IngressPeer> ApiIngressPeersIngressPeerIdPutWithHttpInfo(string ingressPeerId, IngressPeerUpdateRequest? ingressPeerUpdateRequest = null)
    {
        ValidateParameter(ingressPeerId, "ingressPeerId", "IngressPortsApi->ApiIngressPeersIngressPeerIdPut");

        RequestOptions<IngressPeerUpdateRequest> localVarRequestOptions = new RequestOptions<IngressPeerUpdateRequest>();

        localVarRequestOptions.PathParameters.Add("ingressPeerId", ClientUtils.ParameterToString(ingressPeerId)); // path parameter
        localVarRequestOptions.Data = ingressPeerUpdateRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<IngressPeer>("ingress/peers/{ingressPeerId}", localVarRequestOptions);
        this.CheckForException("ApiIngressPeersIngressPeerIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Ingress Peer Update information about an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <param name="ingressPeerUpdateRequest">update an ingress peer (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IngressPeer</returns>
    public async System.Threading.Tasks.Task<IngressPeer> ApiIngressPeersIngressPeerIdPutAsync(string ingressPeerId, IngressPeerUpdateRequest? ingressPeerUpdateRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IngressPeer> localVarResponse = await ApiIngressPeersIngressPeerIdPutWithHttpInfoAsync(ingressPeerId, ingressPeerUpdateRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Ingress Peer Update information about an ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerId">The unique identifier of an ingress peer</param>
    /// <param name="ingressPeerUpdateRequest">update an ingress peer (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IngressPeer)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IngressPeer>> ApiIngressPeersIngressPeerIdPutWithHttpInfoAsync(string ingressPeerId, IngressPeerUpdateRequest? ingressPeerUpdateRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(ingressPeerId, "ingressPeerId", "IngressPortsApi->ApiIngressPeersIngressPeerIdPut");

        RequestOptions<IngressPeerUpdateRequest> localVarRequestOptions = new RequestOptions<IngressPeerUpdateRequest>();

        localVarRequestOptions.PathParameters.Add("ingressPeerId", ClientUtils.ParameterToString(ingressPeerId)); // path parameter
        localVarRequestOptions.Data = ingressPeerUpdateRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<IngressPeer>("ingress/peers/{ingressPeerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIngressPeersIngressPeerIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Ingress Peer Creates a new ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerCreateRequest">New Ingress Peer request (optional)</param>
    /// <returns>IngressPeer</returns>
    public IngressPeer ApiIngressPeersPost(IngressPeerCreateRequest? ingressPeerCreateRequest = null)
    {
        ApiResponse<IngressPeer> localVarResponse = ApiIngressPeersPostWithHttpInfo(ingressPeerCreateRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Ingress Peer Creates a new ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerCreateRequest">New Ingress Peer request (optional)</param>
    /// <returns>ApiResponse of IngressPeer</returns>
    internal ApiResponse<IngressPeer> ApiIngressPeersPostWithHttpInfo(IngressPeerCreateRequest? ingressPeerCreateRequest = null)
    {
        RequestOptions<IngressPeerCreateRequest> localVarRequestOptions = new RequestOptions<IngressPeerCreateRequest>();

        localVarRequestOptions.Data = ingressPeerCreateRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<IngressPeer>("ingress/peers", localVarRequestOptions);
        this.CheckForException("ApiIngressPeersPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Ingress Peer Creates a new ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerCreateRequest">New Ingress Peer request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IngressPeer</returns>
    public async System.Threading.Tasks.Task<IngressPeer> ApiIngressPeersPostAsync(IngressPeerCreateRequest? ingressPeerCreateRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IngressPeer> localVarResponse = await ApiIngressPeersPostWithHttpInfoAsync(ingressPeerCreateRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Ingress Peer Creates a new ingress peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ingressPeerCreateRequest">New Ingress Peer request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IngressPeer)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IngressPeer>> ApiIngressPeersPostWithHttpInfoAsync(IngressPeerCreateRequest? ingressPeerCreateRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<IngressPeerCreateRequest> localVarRequestOptions = new RequestOptions<IngressPeerCreateRequest>();

        localVarRequestOptions.Data = ingressPeerCreateRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<IngressPeer>("ingress/peers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIngressPeersPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Port Allocation Delete an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <returns></returns>
    public void ApiPeersPeerIdIngressPortsAllocationIdDelete(string peerId, string allocationId)
    {
        ApiPeersPeerIdIngressPortsAllocationIdDeleteWithHttpInfo(peerId, allocationId);
    }

    /// <summary>
    /// Delete a Port Allocation Delete an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiPeersPeerIdIngressPortsAllocationIdDeleteWithHttpInfo(string peerId, string allocationId)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdDelete");

        ValidateParameter(allocationId, "allocationId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.PathParameters.Add("allocationId", ClientUtils.ParameterToString(allocationId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("peers/{peerId}/ingress/ports/{allocationId}", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdIngressPortsAllocationIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Port Allocation Delete an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiPeersPeerIdIngressPortsAllocationIdDeleteAsync(string peerId, string allocationId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiPeersPeerIdIngressPortsAllocationIdDeleteWithHttpInfoAsync(peerId, allocationId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Port Allocation Delete an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiPeersPeerIdIngressPortsAllocationIdDeleteWithHttpInfoAsync(string peerId, string allocationId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdDelete");

        ValidateParameter(allocationId, "allocationId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.PathParameters.Add("allocationId", ClientUtils.ParameterToString(allocationId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("peers/{peerId}/ingress/ports/{allocationId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdIngressPortsAllocationIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Port Allocation Get information about an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <returns>IngressPortAllocation</returns>
    public IngressPortAllocation ApiPeersPeerIdIngressPortsAllocationIdGet(string peerId, string allocationId)
    {
        ApiResponse<IngressPortAllocation> localVarResponse = ApiPeersPeerIdIngressPortsAllocationIdGetWithHttpInfo(peerId, allocationId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Port Allocation Get information about an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <returns>ApiResponse of IngressPortAllocation</returns>
    internal ApiResponse<IngressPortAllocation> ApiPeersPeerIdIngressPortsAllocationIdGetWithHttpInfo(string peerId, string allocationId)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdGet");

        ValidateParameter(allocationId, "allocationId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.PathParameters.Add("allocationId", ClientUtils.ParameterToString(allocationId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<IngressPortAllocation>("peers/{peerId}/ingress/ports/{allocationId}", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdIngressPortsAllocationIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Port Allocation Get information about an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IngressPortAllocation</returns>
    public async System.Threading.Tasks.Task<IngressPortAllocation> ApiPeersPeerIdIngressPortsAllocationIdGetAsync(string peerId, string allocationId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IngressPortAllocation> localVarResponse = await ApiPeersPeerIdIngressPortsAllocationIdGetWithHttpInfoAsync(peerId, allocationId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Port Allocation Get information about an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IngressPortAllocation)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IngressPortAllocation>> ApiPeersPeerIdIngressPortsAllocationIdGetWithHttpInfoAsync(string peerId, string allocationId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdGet");

        ValidateParameter(allocationId, "allocationId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.PathParameters.Add("allocationId", ClientUtils.ParameterToString(allocationId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<IngressPortAllocation>("peers/{peerId}/ingress/ports/{allocationId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdIngressPortsAllocationIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Port Allocation Update information about an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <param name="ingressPortAllocationRequest">update an ingress port allocation (optional)</param>
    /// <returns>IngressPortAllocation</returns>
    public IngressPortAllocation ApiPeersPeerIdIngressPortsAllocationIdPut(string peerId, string allocationId, IngressPortAllocationRequest? ingressPortAllocationRequest = null)
    {
        ApiResponse<IngressPortAllocation> localVarResponse = ApiPeersPeerIdIngressPortsAllocationIdPutWithHttpInfo(peerId, allocationId, ingressPortAllocationRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Port Allocation Update information about an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <param name="ingressPortAllocationRequest">update an ingress port allocation (optional)</param>
    /// <returns>ApiResponse of IngressPortAllocation</returns>
    internal ApiResponse<IngressPortAllocation> ApiPeersPeerIdIngressPortsAllocationIdPutWithHttpInfo(string peerId, string allocationId, IngressPortAllocationRequest? ingressPortAllocationRequest = null)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdPut");

        ValidateParameter(allocationId, "allocationId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdPut");

        RequestOptions<IngressPortAllocationRequest> localVarRequestOptions = new RequestOptions<IngressPortAllocationRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.PathParameters.Add("allocationId", ClientUtils.ParameterToString(allocationId)); // path parameter
        localVarRequestOptions.Data = ingressPortAllocationRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<IngressPortAllocation>("peers/{peerId}/ingress/ports/{allocationId}", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdIngressPortsAllocationIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Port Allocation Update information about an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <param name="ingressPortAllocationRequest">update an ingress port allocation (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IngressPortAllocation</returns>
    public async System.Threading.Tasks.Task<IngressPortAllocation> ApiPeersPeerIdIngressPortsAllocationIdPutAsync(string peerId, string allocationId, IngressPortAllocationRequest? ingressPortAllocationRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IngressPortAllocation> localVarResponse = await ApiPeersPeerIdIngressPortsAllocationIdPutWithHttpInfoAsync(peerId, allocationId, ingressPortAllocationRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Port Allocation Update information about an ingress port allocation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="allocationId">The unique identifier of an ingress port allocation</param>
    /// <param name="ingressPortAllocationRequest">update an ingress port allocation (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IngressPortAllocation)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IngressPortAllocation>> ApiPeersPeerIdIngressPortsAllocationIdPutWithHttpInfoAsync(string peerId, string allocationId, IngressPortAllocationRequest? ingressPortAllocationRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdPut");

        ValidateParameter(allocationId, "allocationId", "IngressPortsApi->ApiPeersPeerIdIngressPortsAllocationIdPut");

        RequestOptions<IngressPortAllocationRequest> localVarRequestOptions = new RequestOptions<IngressPortAllocationRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.PathParameters.Add("allocationId", ClientUtils.ParameterToString(allocationId)); // path parameter
        localVarRequestOptions.Data = ingressPortAllocationRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<IngressPortAllocation>("peers/{peerId}/ingress/ports/{allocationId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdIngressPortsAllocationIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Port Allocations Returns a list of all ingress port allocations for a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="name">Filters ingress port allocations by name (optional)</param>
    /// <returns>List&lt;IngressPortAllocation&gt;</returns>
    public List<IngressPortAllocation> ApiPeersPeerIdIngressPortsGet(string peerId, string? name = null)
    {
        ApiResponse<List<IngressPortAllocation>> localVarResponse = ApiPeersPeerIdIngressPortsGetWithHttpInfo(peerId, name);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Port Allocations Returns a list of all ingress port allocations for a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="name">Filters ingress port allocations by name (optional)</param>
    /// <returns>ApiResponse of List&lt;IngressPortAllocation&gt;</returns>
    public ApiResponse<List<IngressPortAllocation>> ApiPeersPeerIdIngressPortsGetWithHttpInfo(string peerId, string? name = null)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        if (name is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "name", name));
        }

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<IngressPortAllocation>>("peers/{peerId}/ingress/ports", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdIngressPortsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Port Allocations Returns a list of all ingress port allocations for a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="name">Filters ingress port allocations by name (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;IngressPortAllocation&gt;</returns>
    public async System.Threading.Tasks.Task<List<IngressPortAllocation>> ApiPeersPeerIdIngressPortsGetAsync(string peerId, string? name = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<IngressPortAllocation>> localVarResponse = await ApiPeersPeerIdIngressPortsGetWithHttpInfoAsync(peerId, name, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Port Allocations Returns a list of all ingress port allocations for a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="name">Filters ingress port allocations by name (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;IngressPortAllocation&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<IngressPortAllocation>>> ApiPeersPeerIdIngressPortsGetWithHttpInfoAsync(string peerId, string? name = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        if (name is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "name", name));
        }

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<IngressPortAllocation>>("peers/{peerId}/ingress/ports", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdIngressPortsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Port Allocation Creates a new ingress port allocation for a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="ingressPortAllocationRequest">New Ingress Port Allocation request (optional)</param>
    /// <returns>IngressPortAllocation</returns>
    public IngressPortAllocation ApiPeersPeerIdIngressPortsPost(string peerId, IngressPortAllocationRequest? ingressPortAllocationRequest = null)
    {
        ApiResponse<IngressPortAllocation> localVarResponse = ApiPeersPeerIdIngressPortsPostWithHttpInfo(peerId, ingressPortAllocationRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Port Allocation Creates a new ingress port allocation for a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="ingressPortAllocationRequest">New Ingress Port Allocation request (optional)</param>
    /// <returns>ApiResponse of IngressPortAllocation</returns>
    internal ApiResponse<IngressPortAllocation> ApiPeersPeerIdIngressPortsPostWithHttpInfo(string peerId, IngressPortAllocationRequest? ingressPortAllocationRequest = null)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsPost");

        RequestOptions<IngressPortAllocationRequest> localVarRequestOptions = new RequestOptions<IngressPortAllocationRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.Data = ingressPortAllocationRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<IngressPortAllocation>("peers/{peerId}/ingress/ports", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdIngressPortsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Port Allocation Creates a new ingress port allocation for a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="ingressPortAllocationRequest">New Ingress Port Allocation request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IngressPortAllocation</returns>
    public async System.Threading.Tasks.Task<IngressPortAllocation> ApiPeersPeerIdIngressPortsPostAsync(string peerId, IngressPortAllocationRequest? ingressPortAllocationRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IngressPortAllocation> localVarResponse = await ApiPeersPeerIdIngressPortsPostWithHttpInfoAsync(peerId, ingressPortAllocationRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Port Allocation Creates a new ingress port allocation for a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="ingressPortAllocationRequest">New Ingress Port Allocation request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IngressPortAllocation)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IngressPortAllocation>> ApiPeersPeerIdIngressPortsPostWithHttpInfoAsync(string peerId, IngressPortAllocationRequest? ingressPortAllocationRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "IngressPortsApi->ApiPeersPeerIdIngressPortsPost");

        RequestOptions<IngressPortAllocationRequest> localVarRequestOptions = new RequestOptions<IngressPortAllocationRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.Data = ingressPortAllocationRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<IngressPortAllocation>("peers/{peerId}/ingress/ports", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdIngressPortsPost", localVarResponse);

        return localVarResponse;
    }

}




