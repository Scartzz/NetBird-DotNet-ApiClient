

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
public class IdentityProvidersApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProvidersApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal IdentityProvidersApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Identity Providers Returns a list of all identity providers configured for the account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;IdentityProvider&gt;</returns>
    public List<IdentityProvider> ApiIdentityProvidersGet()
    {
        ApiResponse<List<IdentityProvider>> localVarResponse = ApiIdentityProvidersGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Identity Providers Returns a list of all identity providers configured for the account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;IdentityProvider&gt;</returns>
    public ApiResponse<List<IdentityProvider>> ApiIdentityProvidersGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<IdentityProvider>>("identity-providers", localVarRequestOptions);
        this.CheckForException("ApiIdentityProvidersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Identity Providers Returns a list of all identity providers configured for the account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;IdentityProvider&gt;</returns>
    public async System.Threading.Tasks.Task<List<IdentityProvider>> ApiIdentityProvidersGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<IdentityProvider>> localVarResponse = await ApiIdentityProvidersGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Identity Providers Returns a list of all identity providers configured for the account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;IdentityProvider&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<IdentityProvider>>> ApiIdentityProvidersGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<IdentityProvider>>("identity-providers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIdentityProvidersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete an Identity Provider Delete an identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <returns></returns>
    public void ApiIdentityProvidersIdpIdDelete(string idpId)
    {
        ApiIdentityProvidersIdpIdDeleteWithHttpInfo(idpId);
    }

    /// <summary>
    /// Delete an Identity Provider Delete an identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIdentityProvidersIdpIdDeleteWithHttpInfo(string idpId)
    {
        ValidateParameter(idpId, "idpId", "IdentityProvidersApi->ApiIdentityProvidersIdpIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("idpId", ClientUtils.ParameterToString(idpId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("identity-providers/{idpId}", localVarRequestOptions);
        this.CheckForException("ApiIdentityProvidersIdpIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete an Identity Provider Delete an identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIdentityProvidersIdpIdDeleteAsync(string idpId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIdentityProvidersIdpIdDeleteWithHttpInfoAsync(idpId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete an Identity Provider Delete an identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiIdentityProvidersIdpIdDeleteWithHttpInfoAsync(string idpId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(idpId, "idpId", "IdentityProvidersApi->ApiIdentityProvidersIdpIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("idpId", ClientUtils.ParameterToString(idpId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("identity-providers/{idpId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIdentityProvidersIdpIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve an Identity Provider Get information about a specific identity provider
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <returns>IdentityProvider</returns>
    public IdentityProvider ApiIdentityProvidersIdpIdGet(string idpId)
    {
        ApiResponse<IdentityProvider> localVarResponse = ApiIdentityProvidersIdpIdGetWithHttpInfo(idpId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve an Identity Provider Get information about a specific identity provider
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <returns>ApiResponse of IdentityProvider</returns>
    internal ApiResponse<IdentityProvider> ApiIdentityProvidersIdpIdGetWithHttpInfo(string idpId)
    {
        ValidateParameter(idpId, "idpId", "IdentityProvidersApi->ApiIdentityProvidersIdpIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("idpId", ClientUtils.ParameterToString(idpId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<IdentityProvider>("identity-providers/{idpId}", localVarRequestOptions);
        this.CheckForException("ApiIdentityProvidersIdpIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve an Identity Provider Get information about a specific identity provider
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IdentityProvider</returns>
    public async System.Threading.Tasks.Task<IdentityProvider> ApiIdentityProvidersIdpIdGetAsync(string idpId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IdentityProvider> localVarResponse = await ApiIdentityProvidersIdpIdGetWithHttpInfoAsync(idpId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve an Identity Provider Get information about a specific identity provider
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IdentityProvider>> ApiIdentityProvidersIdpIdGetWithHttpInfoAsync(string idpId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(idpId, "idpId", "IdentityProvidersApi->ApiIdentityProvidersIdpIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("idpId", ClientUtils.ParameterToString(idpId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<IdentityProvider>("identity-providers/{idpId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIdentityProvidersIdpIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update an Identity Provider Update an existing identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <param name="identityProviderRequest">Identity provider update (optional)</param>
    /// <returns>IdentityProvider</returns>
    public IdentityProvider ApiIdentityProvidersIdpIdPut(string idpId, IdentityProviderRequest? identityProviderRequest = null)
    {
        ApiResponse<IdentityProvider> localVarResponse = ApiIdentityProvidersIdpIdPutWithHttpInfo(idpId, identityProviderRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update an Identity Provider Update an existing identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <param name="identityProviderRequest">Identity provider update (optional)</param>
    /// <returns>ApiResponse of IdentityProvider</returns>
    internal ApiResponse<IdentityProvider> ApiIdentityProvidersIdpIdPutWithHttpInfo(string idpId, IdentityProviderRequest? identityProviderRequest = null)
    {
        ValidateParameter(idpId, "idpId", "IdentityProvidersApi->ApiIdentityProvidersIdpIdPut");

        RequestOptions<IdentityProviderRequest> localVarRequestOptions = new RequestOptions<IdentityProviderRequest>();

        localVarRequestOptions.PathParameters.Add("idpId", ClientUtils.ParameterToString(idpId)); // path parameter
        localVarRequestOptions.Data = identityProviderRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<IdentityProvider>("identity-providers/{idpId}", localVarRequestOptions);
        this.CheckForException("ApiIdentityProvidersIdpIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update an Identity Provider Update an existing identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <param name="identityProviderRequest">Identity provider update (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IdentityProvider</returns>
    public async System.Threading.Tasks.Task<IdentityProvider> ApiIdentityProvidersIdpIdPutAsync(string idpId, IdentityProviderRequest? identityProviderRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IdentityProvider> localVarResponse = await ApiIdentityProvidersIdpIdPutWithHttpInfoAsync(idpId, identityProviderRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update an Identity Provider Update an existing identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="idpId">The unique identifier of an identity provider</param>
    /// <param name="identityProviderRequest">Identity provider update (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IdentityProvider>> ApiIdentityProvidersIdpIdPutWithHttpInfoAsync(string idpId, IdentityProviderRequest? identityProviderRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(idpId, "idpId", "IdentityProvidersApi->ApiIdentityProvidersIdpIdPut");

        RequestOptions<IdentityProviderRequest> localVarRequestOptions = new RequestOptions<IdentityProviderRequest>();

        localVarRequestOptions.PathParameters.Add("idpId", ClientUtils.ParameterToString(idpId)); // path parameter
        localVarRequestOptions.Data = identityProviderRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<IdentityProvider>("identity-providers/{idpId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIdentityProvidersIdpIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create an Identity Provider Creates a new identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="identityProviderRequest">Identity provider configuration (optional)</param>
    /// <returns>IdentityProvider</returns>
    public IdentityProvider ApiIdentityProvidersPost(IdentityProviderRequest? identityProviderRequest = null)
    {
        ApiResponse<IdentityProvider> localVarResponse = ApiIdentityProvidersPostWithHttpInfo(identityProviderRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create an Identity Provider Creates a new identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="identityProviderRequest">Identity provider configuration (optional)</param>
    /// <returns>ApiResponse of IdentityProvider</returns>
    internal ApiResponse<IdentityProvider> ApiIdentityProvidersPostWithHttpInfo(IdentityProviderRequest? identityProviderRequest = null)
    {
        RequestOptions<IdentityProviderRequest> localVarRequestOptions = new RequestOptions<IdentityProviderRequest>();

        localVarRequestOptions.Data = identityProviderRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<IdentityProvider>("identity-providers", localVarRequestOptions);
        this.CheckForException("ApiIdentityProvidersPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create an Identity Provider Creates a new identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="identityProviderRequest">Identity provider configuration (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IdentityProvider</returns>
    public async System.Threading.Tasks.Task<IdentityProvider> ApiIdentityProvidersPostAsync(IdentityProviderRequest? identityProviderRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IdentityProvider> localVarResponse = await ApiIdentityProvidersPostWithHttpInfoAsync(identityProviderRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create an Identity Provider Creates a new identity provider configuration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="identityProviderRequest">Identity provider configuration (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IdentityProvider)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IdentityProvider>> ApiIdentityProvidersPostWithHttpInfoAsync(IdentityProviderRequest? identityProviderRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<IdentityProviderRequest> localVarRequestOptions = new RequestOptions<IdentityProviderRequest>();

        localVarRequestOptions.Data = identityProviderRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<IdentityProvider>("identity-providers", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIdentityProvidersPost", localVarResponse);

        return localVarResponse;
    }

}




