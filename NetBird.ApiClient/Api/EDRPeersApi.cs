

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
public class EDRPeersApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EDRPeersApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal EDRPeersApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Bypass compliance for a non-compliant peer Allows an admin to bypass EDR compliance checks for a specific peer. The peer will remain bypassed until the admin revokes it OR the device becomes naturally compliant in the EDR system. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of the peer</param>
    /// <returns>BypassResponse</returns>
    public BypassResponse BypassCompliance(string peerId)
    {
        ApiResponse<BypassResponse> localVarResponse = BypassComplianceWithHttpInfo(peerId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Bypass compliance for a non-compliant peer Allows an admin to bypass EDR compliance checks for a specific peer. The peer will remain bypassed until the admin revokes it OR the device becomes naturally compliant in the EDR system. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of the peer</param>
    /// <returns>ApiResponse of BypassResponse</returns>
    internal ApiResponse<BypassResponse> BypassComplianceWithHttpInfo(string peerId)
    {
        ValidateParameter(peerId, "peerId", "EDRPeersApi->BypassCompliance");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peer-id", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<BypassResponse>("peers/{peer-id}/edr/bypass", localVarRequestOptions);
        this.CheckForException("BypassCompliance", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Bypass compliance for a non-compliant peer Allows an admin to bypass EDR compliance checks for a specific peer. The peer will remain bypassed until the admin revokes it OR the device becomes naturally compliant in the EDR system. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of the peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of BypassResponse</returns>
    public async System.Threading.Tasks.Task<BypassResponse> BypassComplianceAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<BypassResponse> localVarResponse = await BypassComplianceWithHttpInfoAsync(peerId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Bypass compliance for a non-compliant peer Allows an admin to bypass EDR compliance checks for a specific peer. The peer will remain bypassed until the admin revokes it OR the device becomes naturally compliant in the EDR system. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of the peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (BypassResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<BypassResponse>> BypassComplianceWithHttpInfoAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "EDRPeersApi->BypassCompliance");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peer-id", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<BypassResponse>("peers/{peer-id}/edr/bypass", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("BypassCompliance", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all bypassed peers Returns all peers that have compliance bypassed by an admin.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;BypassResponse&gt;</returns>
    public List<BypassResponse> ListBypassedPeers()
    {
        ApiResponse<List<BypassResponse>> localVarResponse = ListBypassedPeersWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all bypassed peers Returns all peers that have compliance bypassed by an admin.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;BypassResponse&gt;</returns>
    public ApiResponse<List<BypassResponse>> ListBypassedPeersWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<BypassResponse>>("peers/edr/bypassed", localVarRequestOptions);
        this.CheckForException("ListBypassedPeers", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all bypassed peers Returns all peers that have compliance bypassed by an admin.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;BypassResponse&gt;</returns>
    public async System.Threading.Tasks.Task<List<BypassResponse>> ListBypassedPeersAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<BypassResponse>> localVarResponse = await ListBypassedPeersWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all bypassed peers Returns all peers that have compliance bypassed by an admin.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;BypassResponse&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<BypassResponse>>> ListBypassedPeersWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<BypassResponse>>("peers/edr/bypassed", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ListBypassedPeers", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Revoke compliance bypass for a peer Removes the compliance bypass, subjecting the peer to normal EDR validation.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of the peer</param>
    /// <returns></returns>
    public void RevokeBypass(string peerId)
    {
        RevokeBypassWithHttpInfo(peerId);
    }

    /// <summary>
    /// Revoke compliance bypass for a peer Removes the compliance bypass, subjecting the peer to normal EDR validation.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of the peer</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> RevokeBypassWithHttpInfo(string peerId)
    {
        ValidateParameter(peerId, "peerId", "EDRPeersApi->RevokeBypass");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peer-id", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<object>("peers/{peer-id}/edr/bypass", localVarRequestOptions);
        this.CheckForException("RevokeBypass", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Revoke compliance bypass for a peer Removes the compliance bypass, subjecting the peer to normal EDR validation.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of the peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task RevokeBypassAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        await RevokeBypassWithHttpInfoAsync(peerId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Revoke compliance bypass for a peer Removes the compliance bypass, subjecting the peer to normal EDR validation.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of the peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> RevokeBypassWithHttpInfoAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "EDRPeersApi->RevokeBypass");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peer-id", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Object>("peers/{peer-id}/edr/bypass", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("RevokeBypass", localVarResponse);

        return localVarResponse;
    }

}




