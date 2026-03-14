

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
public class SetupKeysApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SetupKeysApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal SetupKeysApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Setup Keys Returns a list of all Setup Keys
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;SetupKey&gt;</returns>
    public List<SetupKey> ApiSetupKeysGet()
    {
        ApiResponse<List<SetupKey>> localVarResponse = ApiSetupKeysGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Setup Keys Returns a list of all Setup Keys
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;SetupKey&gt;</returns>
    public ApiResponse<List<SetupKey>> ApiSetupKeysGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<SetupKey>>("setup-keys", localVarRequestOptions);
        this.CheckForException("ApiSetupKeysGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Setup Keys Returns a list of all Setup Keys
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;SetupKey&gt;</returns>
    public async System.Threading.Tasks.Task<List<SetupKey>> ApiSetupKeysGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<SetupKey>> localVarResponse = await ApiSetupKeysGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Setup Keys Returns a list of all Setup Keys
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;SetupKey&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<SetupKey>>> ApiSetupKeysGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<SetupKey>>("setup-keys", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiSetupKeysGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Setup Key Delete a Setup Key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <returns></returns>
    public void ApiSetupKeysKeyIdDelete(string keyId)
    {
        ApiSetupKeysKeyIdDeleteWithHttpInfo(keyId);
    }

    /// <summary>
    /// Delete a Setup Key Delete a Setup Key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiSetupKeysKeyIdDeleteWithHttpInfo(string keyId)
    {
        ValidateParameter(keyId, "keyId", "SetupKeysApi->ApiSetupKeysKeyIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("keyId", ClientUtils.ParameterToString(keyId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("setup-keys/{keyId}", localVarRequestOptions);
        this.CheckForException("ApiSetupKeysKeyIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Setup Key Delete a Setup Key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiSetupKeysKeyIdDeleteAsync(string keyId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiSetupKeysKeyIdDeleteWithHttpInfoAsync(keyId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Setup Key Delete a Setup Key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiSetupKeysKeyIdDeleteWithHttpInfoAsync(string keyId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(keyId, "keyId", "SetupKeysApi->ApiSetupKeysKeyIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("keyId", ClientUtils.ParameterToString(keyId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("setup-keys/{keyId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiSetupKeysKeyIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Setup Key Get information about a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <returns>SetupKey</returns>
    public SetupKey ApiSetupKeysKeyIdGet(string keyId)
    {
        ApiResponse<SetupKey> localVarResponse = ApiSetupKeysKeyIdGetWithHttpInfo(keyId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Setup Key Get information about a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <returns>ApiResponse of SetupKey</returns>
    internal ApiResponse<SetupKey> ApiSetupKeysKeyIdGetWithHttpInfo(string keyId)
    {
        ValidateParameter(keyId, "keyId", "SetupKeysApi->ApiSetupKeysKeyIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("keyId", ClientUtils.ParameterToString(keyId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<SetupKey>("setup-keys/{keyId}", localVarRequestOptions);
        this.CheckForException("ApiSetupKeysKeyIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Setup Key Get information about a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of SetupKey</returns>
    public async System.Threading.Tasks.Task<SetupKey> ApiSetupKeysKeyIdGetAsync(string keyId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<SetupKey> localVarResponse = await ApiSetupKeysKeyIdGetWithHttpInfoAsync(keyId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Setup Key Get information about a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (SetupKey)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<SetupKey>> ApiSetupKeysKeyIdGetWithHttpInfoAsync(string keyId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(keyId, "keyId", "SetupKeysApi->ApiSetupKeysKeyIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("keyId", ClientUtils.ParameterToString(keyId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<SetupKey>("setup-keys/{keyId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiSetupKeysKeyIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Setup Key Update information about a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <param name="setupKeyRequest">update to Setup Key (optional)</param>
    /// <returns>SetupKey</returns>
    public SetupKey ApiSetupKeysKeyIdPut(string keyId, SetupKeyRequest? setupKeyRequest = null)
    {
        ApiResponse<SetupKey> localVarResponse = ApiSetupKeysKeyIdPutWithHttpInfo(keyId, setupKeyRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Setup Key Update information about a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <param name="setupKeyRequest">update to Setup Key (optional)</param>
    /// <returns>ApiResponse of SetupKey</returns>
    internal ApiResponse<SetupKey> ApiSetupKeysKeyIdPutWithHttpInfo(string keyId, SetupKeyRequest? setupKeyRequest = null)
    {
        ValidateParameter(keyId, "keyId", "SetupKeysApi->ApiSetupKeysKeyIdPut");

        RequestOptions<SetupKeyRequest> localVarRequestOptions = new RequestOptions<SetupKeyRequest>();

        localVarRequestOptions.PathParameters.Add("keyId", ClientUtils.ParameterToString(keyId)); // path parameter
        localVarRequestOptions.Data = setupKeyRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<SetupKey>("setup-keys/{keyId}", localVarRequestOptions);
        this.CheckForException("ApiSetupKeysKeyIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Setup Key Update information about a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <param name="setupKeyRequest">update to Setup Key (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of SetupKey</returns>
    public async System.Threading.Tasks.Task<SetupKey> ApiSetupKeysKeyIdPutAsync(string keyId, SetupKeyRequest? setupKeyRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<SetupKey> localVarResponse = await ApiSetupKeysKeyIdPutWithHttpInfoAsync(keyId, setupKeyRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Setup Key Update information about a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyId">The unique identifier of a setup key</param>
    /// <param name="setupKeyRequest">update to Setup Key (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (SetupKey)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<SetupKey>> ApiSetupKeysKeyIdPutWithHttpInfoAsync(string keyId, SetupKeyRequest? setupKeyRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(keyId, "keyId", "SetupKeysApi->ApiSetupKeysKeyIdPut");

        RequestOptions<SetupKeyRequest> localVarRequestOptions = new RequestOptions<SetupKeyRequest>();

        localVarRequestOptions.PathParameters.Add("keyId", ClientUtils.ParameterToString(keyId)); // path parameter
        localVarRequestOptions.Data = setupKeyRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<SetupKey>("setup-keys/{keyId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiSetupKeysKeyIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Setup Key Creates a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createSetupKeyRequest">New Setup Key request (optional)</param>
    /// <returns>SetupKeyClear</returns>
    public SetupKeyClear ApiSetupKeysPost(CreateSetupKeyRequest? createSetupKeyRequest = null)
    {
        ApiResponse<SetupKeyClear> localVarResponse = ApiSetupKeysPostWithHttpInfo(createSetupKeyRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Setup Key Creates a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createSetupKeyRequest">New Setup Key request (optional)</param>
    /// <returns>ApiResponse of SetupKeyClear</returns>
    internal ApiResponse<SetupKeyClear> ApiSetupKeysPostWithHttpInfo(CreateSetupKeyRequest? createSetupKeyRequest = null)
    {
        RequestOptions<CreateSetupKeyRequest> localVarRequestOptions = new RequestOptions<CreateSetupKeyRequest>();

        localVarRequestOptions.Data = createSetupKeyRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<SetupKeyClear>("setup-keys", localVarRequestOptions);
        this.CheckForException("ApiSetupKeysPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Setup Key Creates a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createSetupKeyRequest">New Setup Key request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of SetupKeyClear</returns>
    public async System.Threading.Tasks.Task<SetupKeyClear> ApiSetupKeysPostAsync(CreateSetupKeyRequest? createSetupKeyRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<SetupKeyClear> localVarResponse = await ApiSetupKeysPostWithHttpInfoAsync(createSetupKeyRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Setup Key Creates a setup key
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createSetupKeyRequest">New Setup Key request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (SetupKeyClear)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<SetupKeyClear>> ApiSetupKeysPostWithHttpInfoAsync(CreateSetupKeyRequest? createSetupKeyRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<CreateSetupKeyRequest> localVarRequestOptions = new RequestOptions<CreateSetupKeyRequest>();

        localVarRequestOptions.Data = createSetupKeyRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<SetupKeyClear>("setup-keys", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiSetupKeysPost", localVarResponse);

        return localVarResponse;
    }

}




