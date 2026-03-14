

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
public class TokensApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TokensApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal TokensApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Tokens Returns a list of all tokens for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns>List&lt;PersonalAccessToken&gt;</returns>
    public List<PersonalAccessToken> ApiUsersUserIdTokensGet(string userId)
    {
        ApiResponse<List<PersonalAccessToken>> localVarResponse = ApiUsersUserIdTokensGetWithHttpInfo(userId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Tokens Returns a list of all tokens for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns>ApiResponse of List&lt;PersonalAccessToken&gt;</returns>
    public ApiResponse<List<PersonalAccessToken>> ApiUsersUserIdTokensGetWithHttpInfo(string userId)
    {
        ValidateParameter(userId, "userId", "TokensApi->ApiUsersUserIdTokensGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<PersonalAccessToken>>("users/{userId}/tokens", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdTokensGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Tokens Returns a list of all tokens for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;PersonalAccessToken&gt;</returns>
    public async System.Threading.Tasks.Task<List<PersonalAccessToken>> ApiUsersUserIdTokensGetAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<PersonalAccessToken>> localVarResponse = await ApiUsersUserIdTokensGetWithHttpInfoAsync(userId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Tokens Returns a list of all tokens for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;PersonalAccessToken&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<PersonalAccessToken>>> ApiUsersUserIdTokensGetWithHttpInfoAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "TokensApi->ApiUsersUserIdTokensGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<PersonalAccessToken>>("users/{userId}/tokens", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdTokensGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Token Create a new token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="personalAccessTokenRequest">PersonalAccessToken create parameters (optional)</param>
    /// <returns>PersonalAccessTokenGenerated</returns>
    public PersonalAccessTokenGenerated ApiUsersUserIdTokensPost(string userId, PersonalAccessTokenRequest? personalAccessTokenRequest = null)
    {
        ApiResponse<PersonalAccessTokenGenerated> localVarResponse = ApiUsersUserIdTokensPostWithHttpInfo(userId, personalAccessTokenRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Token Create a new token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="personalAccessTokenRequest">PersonalAccessToken create parameters (optional)</param>
    /// <returns>ApiResponse of PersonalAccessTokenGenerated</returns>
    internal ApiResponse<PersonalAccessTokenGenerated> ApiUsersUserIdTokensPostWithHttpInfo(string userId, PersonalAccessTokenRequest? personalAccessTokenRequest = null)
    {
        ValidateParameter(userId, "userId", "TokensApi->ApiUsersUserIdTokensPost");

        RequestOptions<PersonalAccessTokenRequest> localVarRequestOptions = new RequestOptions<PersonalAccessTokenRequest>();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.Data = personalAccessTokenRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<PersonalAccessTokenGenerated>("users/{userId}/tokens", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdTokensPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Token Create a new token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="personalAccessTokenRequest">PersonalAccessToken create parameters (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PersonalAccessTokenGenerated</returns>
    public async System.Threading.Tasks.Task<PersonalAccessTokenGenerated> ApiUsersUserIdTokensPostAsync(string userId, PersonalAccessTokenRequest? personalAccessTokenRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<PersonalAccessTokenGenerated> localVarResponse = await ApiUsersUserIdTokensPostWithHttpInfoAsync(userId, personalAccessTokenRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Token Create a new token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="personalAccessTokenRequest">PersonalAccessToken create parameters (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PersonalAccessTokenGenerated)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<PersonalAccessTokenGenerated>> ApiUsersUserIdTokensPostWithHttpInfoAsync(string userId, PersonalAccessTokenRequest? personalAccessTokenRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "TokensApi->ApiUsersUserIdTokensPost");

        RequestOptions<PersonalAccessTokenRequest> localVarRequestOptions = new RequestOptions<PersonalAccessTokenRequest>();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.Data = personalAccessTokenRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<PersonalAccessTokenGenerated>("users/{userId}/tokens", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdTokensPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Token Delete a token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="tokenId">The unique identifier of a token</param>
    /// <returns></returns>
    public void ApiUsersUserIdTokensTokenIdDelete(string userId, string tokenId)
    {
        ApiUsersUserIdTokensTokenIdDeleteWithHttpInfo(userId, tokenId);
    }

    /// <summary>
    /// Delete a Token Delete a token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="tokenId">The unique identifier of a token</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiUsersUserIdTokensTokenIdDeleteWithHttpInfo(string userId, string tokenId)
    {
        ValidateParameter(userId, "userId", "TokensApi->ApiUsersUserIdTokensTokenIdDelete");

        ValidateParameter(tokenId, "tokenId", "TokensApi->ApiUsersUserIdTokensTokenIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.PathParameters.Add("tokenId", ClientUtils.ParameterToString(tokenId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("users/{userId}/tokens/{tokenId}", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdTokensTokenIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Token Delete a token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="tokenId">The unique identifier of a token</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiUsersUserIdTokensTokenIdDeleteAsync(string userId, string tokenId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiUsersUserIdTokensTokenIdDeleteWithHttpInfoAsync(userId, tokenId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Token Delete a token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="tokenId">The unique identifier of a token</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiUsersUserIdTokensTokenIdDeleteWithHttpInfoAsync(string userId, string tokenId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "TokensApi->ApiUsersUserIdTokensTokenIdDelete");

        ValidateParameter(tokenId, "tokenId", "TokensApi->ApiUsersUserIdTokensTokenIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.PathParameters.Add("tokenId", ClientUtils.ParameterToString(tokenId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("users/{userId}/tokens/{tokenId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdTokensTokenIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Token Returns a specific token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="tokenId">The unique identifier of a token</param>
    /// <returns>PersonalAccessToken</returns>
    public PersonalAccessToken ApiUsersUserIdTokensTokenIdGet(string userId, string tokenId)
    {
        ApiResponse<PersonalAccessToken> localVarResponse = ApiUsersUserIdTokensTokenIdGetWithHttpInfo(userId, tokenId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Token Returns a specific token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="tokenId">The unique identifier of a token</param>
    /// <returns>ApiResponse of PersonalAccessToken</returns>
    internal ApiResponse<PersonalAccessToken> ApiUsersUserIdTokensTokenIdGetWithHttpInfo(string userId, string tokenId)
    {
        ValidateParameter(userId, "userId", "TokensApi->ApiUsersUserIdTokensTokenIdGet");

        ValidateParameter(tokenId, "tokenId", "TokensApi->ApiUsersUserIdTokensTokenIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.PathParameters.Add("tokenId", ClientUtils.ParameterToString(tokenId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<PersonalAccessToken>("users/{userId}/tokens/{tokenId}", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdTokensTokenIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Token Returns a specific token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="tokenId">The unique identifier of a token</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PersonalAccessToken</returns>
    public async System.Threading.Tasks.Task<PersonalAccessToken> ApiUsersUserIdTokensTokenIdGetAsync(string userId, string tokenId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<PersonalAccessToken> localVarResponse = await ApiUsersUserIdTokensTokenIdGetWithHttpInfoAsync(userId, tokenId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Token Returns a specific token for a user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="tokenId">The unique identifier of a token</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PersonalAccessToken)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<PersonalAccessToken>> ApiUsersUserIdTokensTokenIdGetWithHttpInfoAsync(string userId, string tokenId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "TokensApi->ApiUsersUserIdTokensTokenIdGet");

        ValidateParameter(tokenId, "tokenId", "TokensApi->ApiUsersUserIdTokensTokenIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.PathParameters.Add("tokenId", ClientUtils.ParameterToString(tokenId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<PersonalAccessToken>("users/{userId}/tokens/{tokenId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdTokensTokenIdGet", localVarResponse);

        return localVarResponse;
    }

}




