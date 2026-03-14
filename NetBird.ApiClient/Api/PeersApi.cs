

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
public class PeersApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PeersApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal PeersApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Peers Returns a list of all peers
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="name">Filter peers by name (optional)</param>
    /// <param name="ip">Filter peers by IP address (optional)</param>
    /// <returns>List&lt;PeerBatch&gt;</returns>
    public List<PeerBatch> ApiPeersGet(string? name = null, string? ip = null)
    {
        ApiResponse<List<PeerBatch>> localVarResponse = ApiPeersGetWithHttpInfo(name, ip);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Peers Returns a list of all peers
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="name">Filter peers by name (optional)</param>
    /// <param name="ip">Filter peers by IP address (optional)</param>
    /// <returns>ApiResponse of List&lt;PeerBatch&gt;</returns>
    public ApiResponse<List<PeerBatch>> ApiPeersGetWithHttpInfo(string? name = null, string? ip = null)
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        if (name is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "name", name));
        }
        if (ip is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "ip", ip));
        }

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<PeerBatch>>("peers", localVarRequestOptions);
        this.CheckForException("ApiPeersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Peers Returns a list of all peers
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="name">Filter peers by name (optional)</param>
    /// <param name="ip">Filter peers by IP address (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;PeerBatch&gt;</returns>
    public async System.Threading.Tasks.Task<List<PeerBatch>> ApiPeersGetAsync(string? name = null, string? ip = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<PeerBatch>> localVarResponse = await ApiPeersGetWithHttpInfoAsync(name, ip, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Peers Returns a list of all peers
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="name">Filter peers by name (optional)</param>
    /// <param name="ip">Filter peers by IP address (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;PeerBatch&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<PeerBatch>>> ApiPeersGetWithHttpInfoAsync(string? name = null, string? ip = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        if (name is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "name", name));
        }
        if (ip is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "ip", ip));
        }

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<PeerBatch>>("peers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List accessible Peers Returns a list of peers that the specified peer can connect to within the network.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <returns>List&lt;AccessiblePeer&gt;</returns>
    public List<AccessiblePeer> ApiPeersPeerIdAccessiblePeersGet(string peerId)
    {
        ApiResponse<List<AccessiblePeer>> localVarResponse = ApiPeersPeerIdAccessiblePeersGetWithHttpInfo(peerId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List accessible Peers Returns a list of peers that the specified peer can connect to within the network.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <returns>ApiResponse of List&lt;AccessiblePeer&gt;</returns>
    public ApiResponse<List<AccessiblePeer>> ApiPeersPeerIdAccessiblePeersGetWithHttpInfo(string peerId)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdAccessiblePeersGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<AccessiblePeer>>("peers/{peerId}/accessible-peers", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdAccessiblePeersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List accessible Peers Returns a list of peers that the specified peer can connect to within the network.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;AccessiblePeer&gt;</returns>
    public async System.Threading.Tasks.Task<List<AccessiblePeer>> ApiPeersPeerIdAccessiblePeersGetAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<AccessiblePeer>> localVarResponse = await ApiPeersPeerIdAccessiblePeersGetWithHttpInfoAsync(peerId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List accessible Peers Returns a list of peers that the specified peer can connect to within the network.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;AccessiblePeer&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<AccessiblePeer>>> ApiPeersPeerIdAccessiblePeersGetWithHttpInfoAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdAccessiblePeersGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<AccessiblePeer>>("peers/{peerId}/accessible-peers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdAccessiblePeersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Peer Delete a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <returns></returns>
    public void ApiPeersPeerIdDelete(string peerId)
    {
        ApiPeersPeerIdDeleteWithHttpInfo(peerId);
    }

    /// <summary>
    /// Delete a Peer Delete a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiPeersPeerIdDeleteWithHttpInfo(string peerId)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("peers/{peerId}", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Peer Delete a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiPeersPeerIdDeleteAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiPeersPeerIdDeleteWithHttpInfoAsync(peerId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Peer Delete a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiPeersPeerIdDeleteWithHttpInfoAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("peers/{peerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Peer Get information about a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <returns>Peer</returns>
    public Peer ApiPeersPeerIdGet(string peerId)
    {
        ApiResponse<Peer> localVarResponse = ApiPeersPeerIdGetWithHttpInfo(peerId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Peer Get information about a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <returns>ApiResponse of Peer</returns>
    internal ApiResponse<Peer> ApiPeersPeerIdGetWithHttpInfo(string peerId)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<Peer>("peers/{peerId}", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Peer Get information about a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Peer</returns>
    public async System.Threading.Tasks.Task<Peer> ApiPeersPeerIdGetAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Peer> localVarResponse = await ApiPeersPeerIdGetWithHttpInfoAsync(peerId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Peer Get information about a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Peer)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Peer>> ApiPeersPeerIdGetWithHttpInfoAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Peer>("peers/{peerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Peer Update information about a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="peerRequest">update a peer (optional)</param>
    /// <returns>Peer</returns>
    public Peer ApiPeersPeerIdPut(string peerId, PeerRequest? peerRequest = null)
    {
        ApiResponse<Peer> localVarResponse = ApiPeersPeerIdPutWithHttpInfo(peerId, peerRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Peer Update information about a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="peerRequest">update a peer (optional)</param>
    /// <returns>ApiResponse of Peer</returns>
    internal ApiResponse<Peer> ApiPeersPeerIdPutWithHttpInfo(string peerId, PeerRequest? peerRequest = null)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdPut");

        RequestOptions<PeerRequest> localVarRequestOptions = new RequestOptions<PeerRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.Data = peerRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Peer>("peers/{peerId}", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Peer Update information about a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="peerRequest">update a peer (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Peer</returns>
    public async System.Threading.Tasks.Task<Peer> ApiPeersPeerIdPutAsync(string peerId, PeerRequest? peerRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Peer> localVarResponse = await ApiPeersPeerIdPutWithHttpInfoAsync(peerId, peerRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Peer Update information about a peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="peerRequest">update a peer (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Peer)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Peer>> ApiPeersPeerIdPutWithHttpInfoAsync(string peerId, PeerRequest? peerRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdPut");

        RequestOptions<PeerRequest> localVarRequestOptions = new RequestOptions<PeerRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.Data = peerRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Peer>("peers/{peerId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Temporary Access Peer Creates a temporary access peer that can be used to access this peer and this peer only. The temporary access peer and its access policies will be automatically deleted after it disconnects.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="peerTemporaryAccessRequest">Temporary Access Peer create request (optional)</param>
    /// <returns>PeerTemporaryAccessResponse</returns>
    public PeerTemporaryAccessResponse ApiPeersPeerIdTemporaryAccessPost(string peerId, PeerTemporaryAccessRequest? peerTemporaryAccessRequest = null)
    {
        ApiResponse<PeerTemporaryAccessResponse> localVarResponse = ApiPeersPeerIdTemporaryAccessPostWithHttpInfo(peerId, peerTemporaryAccessRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Temporary Access Peer Creates a temporary access peer that can be used to access this peer and this peer only. The temporary access peer and its access policies will be automatically deleted after it disconnects.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="peerTemporaryAccessRequest">Temporary Access Peer create request (optional)</param>
    /// <returns>ApiResponse of PeerTemporaryAccessResponse</returns>
    internal ApiResponse<PeerTemporaryAccessResponse> ApiPeersPeerIdTemporaryAccessPostWithHttpInfo(string peerId, PeerTemporaryAccessRequest? peerTemporaryAccessRequest = null)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdTemporaryAccessPost");

        RequestOptions<PeerTemporaryAccessRequest> localVarRequestOptions = new RequestOptions<PeerTemporaryAccessRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.Data = peerTemporaryAccessRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<PeerTemporaryAccessResponse>("peers/{peerId}/temporary-access", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdTemporaryAccessPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Temporary Access Peer Creates a temporary access peer that can be used to access this peer and this peer only. The temporary access peer and its access policies will be automatically deleted after it disconnects.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="peerTemporaryAccessRequest">Temporary Access Peer create request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PeerTemporaryAccessResponse</returns>
    public async System.Threading.Tasks.Task<PeerTemporaryAccessResponse> ApiPeersPeerIdTemporaryAccessPostAsync(string peerId, PeerTemporaryAccessRequest? peerTemporaryAccessRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<PeerTemporaryAccessResponse> localVarResponse = await ApiPeersPeerIdTemporaryAccessPostWithHttpInfoAsync(peerId, peerTemporaryAccessRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Temporary Access Peer Creates a temporary access peer that can be used to access this peer and this peer only. The temporary access peer and its access policies will be automatically deleted after it disconnects.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="peerTemporaryAccessRequest">Temporary Access Peer create request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PeerTemporaryAccessResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<PeerTemporaryAccessResponse>> ApiPeersPeerIdTemporaryAccessPostWithHttpInfoAsync(string peerId, PeerTemporaryAccessRequest? peerTemporaryAccessRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "PeersApi->ApiPeersPeerIdTemporaryAccessPost");

        RequestOptions<PeerTemporaryAccessRequest> localVarRequestOptions = new RequestOptions<PeerTemporaryAccessRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.Data = peerTemporaryAccessRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<PeerTemporaryAccessResponse>("peers/{peerId}/temporary-access", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdTemporaryAccessPost", localVarResponse);

        return localVarResponse;
    }

}




