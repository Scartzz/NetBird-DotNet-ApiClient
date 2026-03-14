

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
public class UsersApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UsersApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal UsersApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Retrieve current user Get information about the current user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>User</returns>
    public User ApiUsersCurrentGet()
    {
        ApiResponse<User> localVarResponse = ApiUsersCurrentGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve current user Get information about the current user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of User</returns>
    internal ApiResponse<User> ApiUsersCurrentGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<User>("users/current", localVarRequestOptions);
        this.CheckForException("ApiUsersCurrentGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve current user Get information about the current user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of User</returns>
    public async System.Threading.Tasks.Task<User> ApiUsersCurrentGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<User> localVarResponse = await ApiUsersCurrentGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve current user Get information about the current user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (User)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<User>> ApiUsersCurrentGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<User>("users/current", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersCurrentGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Users Returns a list of all users
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceUser">Filters users and returns either regular users or service users (optional)</param>
    /// <returns>List&lt;User&gt;</returns>
    public List<User> ApiUsersGet(bool? serviceUser = null)
    {
        ApiResponse<List<User>> localVarResponse = ApiUsersGetWithHttpInfo(serviceUser);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Users Returns a list of all users
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceUser">Filters users and returns either regular users or service users (optional)</param>
    /// <returns>ApiResponse of List&lt;User&gt;</returns>
    public ApiResponse<List<User>> ApiUsersGetWithHttpInfo(bool? serviceUser = null)
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        if (serviceUser is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "service_user", serviceUser));
        }

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<User>>("users", localVarRequestOptions);
        this.CheckForException("ApiUsersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Users Returns a list of all users
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceUser">Filters users and returns either regular users or service users (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;User&gt;</returns>
    public async System.Threading.Tasks.Task<List<User>> ApiUsersGetAsync(bool? serviceUser = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<User>> localVarResponse = await ApiUsersGetWithHttpInfoAsync(serviceUser, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Users Returns a list of all users
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="serviceUser">Filters users and returns either regular users or service users (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;User&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<User>>> ApiUsersGetWithHttpInfoAsync(bool? serviceUser = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        if (serviceUser is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "service_user", serviceUser));
        }

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<User>>("users", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List user invites Lists all pending invites for the account. Only available when embedded IdP is enabled.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;UserInvite&gt;</returns>
    public List<UserInvite> ApiUsersInvitesGet()
    {
        ApiResponse<List<UserInvite>> localVarResponse = ApiUsersInvitesGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List user invites Lists all pending invites for the account. Only available when embedded IdP is enabled.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;UserInvite&gt;</returns>
    public ApiResponse<List<UserInvite>> ApiUsersInvitesGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<UserInvite>>("users/invites", localVarRequestOptions);
        this.CheckForException("ApiUsersInvitesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List user invites Lists all pending invites for the account. Only available when embedded IdP is enabled.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;UserInvite&gt;</returns>
    public async System.Threading.Tasks.Task<List<UserInvite>> ApiUsersInvitesGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<UserInvite>> localVarResponse = await ApiUsersInvitesGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List user invites Lists all pending invites for the account. Only available when embedded IdP is enabled.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;UserInvite&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<UserInvite>>> ApiUsersInvitesGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<UserInvite>>("users/invites", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersInvitesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a user invite Deletes a pending invite. Only available when embedded IdP is enabled.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="inviteId">The ID of the invite to delete</param>
    /// <returns></returns>
    public void ApiUsersInvitesInviteIdDelete(string inviteId)
    {
        ApiUsersInvitesInviteIdDeleteWithHttpInfo(inviteId);
    }

    /// <summary>
    /// Delete a user invite Deletes a pending invite. Only available when embedded IdP is enabled.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="inviteId">The ID of the invite to delete</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiUsersInvitesInviteIdDeleteWithHttpInfo(string inviteId)
    {
        ValidateParameter(inviteId, "inviteId", "UsersApi->ApiUsersInvitesInviteIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("inviteId", ClientUtils.ParameterToString(inviteId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("users/invites/{inviteId}", localVarRequestOptions);
        this.CheckForException("ApiUsersInvitesInviteIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a user invite Deletes a pending invite. Only available when embedded IdP is enabled.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="inviteId">The ID of the invite to delete</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiUsersInvitesInviteIdDeleteAsync(string inviteId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiUsersInvitesInviteIdDeleteWithHttpInfoAsync(inviteId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a user invite Deletes a pending invite. Only available when embedded IdP is enabled.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="inviteId">The ID of the invite to delete</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiUsersInvitesInviteIdDeleteWithHttpInfoAsync(string inviteId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(inviteId, "inviteId", "UsersApi->ApiUsersInvitesInviteIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("inviteId", ClientUtils.ParameterToString(inviteId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("users/invites/{inviteId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersInvitesInviteIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Regenerate a user invite Regenerates an invite link for an existing invite. Invalidates the previous token and creates a new one.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="inviteId">The ID of the invite to regenerate</param>
    /// <param name="userInviteRegenerateRequest">Regenerate options (optional)</param>
    /// <returns>UserInviteRegenerateResponse</returns>
    public UserInviteRegenerateResponse ApiUsersInvitesInviteIdRegeneratePost(string inviteId, UserInviteRegenerateRequest? userInviteRegenerateRequest = null)
    {
        ApiResponse<UserInviteRegenerateResponse> localVarResponse = ApiUsersInvitesInviteIdRegeneratePostWithHttpInfo(inviteId, userInviteRegenerateRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Regenerate a user invite Regenerates an invite link for an existing invite. Invalidates the previous token and creates a new one.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="inviteId">The ID of the invite to regenerate</param>
    /// <param name="userInviteRegenerateRequest">Regenerate options (optional)</param>
    /// <returns>ApiResponse of UserInviteRegenerateResponse</returns>
    internal ApiResponse<UserInviteRegenerateResponse> ApiUsersInvitesInviteIdRegeneratePostWithHttpInfo(string inviteId, UserInviteRegenerateRequest? userInviteRegenerateRequest = null)
    {
        ValidateParameter(inviteId, "inviteId", "UsersApi->ApiUsersInvitesInviteIdRegeneratePost");

        RequestOptions<UserInviteRegenerateRequest> localVarRequestOptions = new RequestOptions<UserInviteRegenerateRequest>();

        localVarRequestOptions.PathParameters.Add("inviteId", ClientUtils.ParameterToString(inviteId)); // path parameter
        localVarRequestOptions.Data = userInviteRegenerateRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<UserInviteRegenerateResponse>("users/invites/{inviteId}/regenerate", localVarRequestOptions);
        this.CheckForException("ApiUsersInvitesInviteIdRegeneratePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Regenerate a user invite Regenerates an invite link for an existing invite. Invalidates the previous token and creates a new one.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="inviteId">The ID of the invite to regenerate</param>
    /// <param name="userInviteRegenerateRequest">Regenerate options (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of UserInviteRegenerateResponse</returns>
    public async System.Threading.Tasks.Task<UserInviteRegenerateResponse> ApiUsersInvitesInviteIdRegeneratePostAsync(string inviteId, UserInviteRegenerateRequest? userInviteRegenerateRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<UserInviteRegenerateResponse> localVarResponse = await ApiUsersInvitesInviteIdRegeneratePostWithHttpInfoAsync(inviteId, userInviteRegenerateRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Regenerate a user invite Regenerates an invite link for an existing invite. Invalidates the previous token and creates a new one.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="inviteId">The ID of the invite to regenerate</param>
    /// <param name="userInviteRegenerateRequest">Regenerate options (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (UserInviteRegenerateResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<UserInviteRegenerateResponse>> ApiUsersInvitesInviteIdRegeneratePostWithHttpInfoAsync(string inviteId, UserInviteRegenerateRequest? userInviteRegenerateRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(inviteId, "inviteId", "UsersApi->ApiUsersInvitesInviteIdRegeneratePost");

        RequestOptions<UserInviteRegenerateRequest> localVarRequestOptions = new RequestOptions<UserInviteRegenerateRequest>();

        localVarRequestOptions.PathParameters.Add("inviteId", ClientUtils.ParameterToString(inviteId)); // path parameter
        localVarRequestOptions.Data = userInviteRegenerateRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<UserInviteRegenerateResponse>("users/invites/{inviteId}/regenerate", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersInvitesInviteIdRegeneratePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a user invite Creates an invite link for a new user. Only available when embedded IdP is enabled. The user is not created until they accept the invite.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userInviteCreateRequest">User invite information</param>
    /// <returns>UserInvite</returns>
    public UserInvite ApiUsersInvitesPost(UserInviteCreateRequest userInviteCreateRequest)
    {
        ApiResponse<UserInvite> localVarResponse = ApiUsersInvitesPostWithHttpInfo(userInviteCreateRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a user invite Creates an invite link for a new user. Only available when embedded IdP is enabled. The user is not created until they accept the invite.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userInviteCreateRequest">User invite information</param>
    /// <returns>ApiResponse of UserInvite</returns>
    internal ApiResponse<UserInvite> ApiUsersInvitesPostWithHttpInfo(UserInviteCreateRequest userInviteCreateRequest)
    {
        ValidateParameter(userInviteCreateRequest, "userInviteCreateRequest", "UsersApi->ApiUsersInvitesPost");

        RequestOptions<UserInviteCreateRequest> localVarRequestOptions = new RequestOptions<UserInviteCreateRequest>();

        localVarRequestOptions.Data = userInviteCreateRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<UserInvite>("users/invites", localVarRequestOptions);
        this.CheckForException("ApiUsersInvitesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a user invite Creates an invite link for a new user. Only available when embedded IdP is enabled. The user is not created until they accept the invite.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userInviteCreateRequest">User invite information</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of UserInvite</returns>
    public async System.Threading.Tasks.Task<UserInvite> ApiUsersInvitesPostAsync(UserInviteCreateRequest userInviteCreateRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<UserInvite> localVarResponse = await ApiUsersInvitesPostWithHttpInfoAsync(userInviteCreateRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a user invite Creates an invite link for a new user. Only available when embedded IdP is enabled. The user is not created until they accept the invite.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userInviteCreateRequest">User invite information</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (UserInvite)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<UserInvite>> ApiUsersInvitesPostWithHttpInfoAsync(UserInviteCreateRequest userInviteCreateRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userInviteCreateRequest, "userInviteCreateRequest", "UsersApi->ApiUsersInvitesPost");

        RequestOptions<UserInviteCreateRequest> localVarRequestOptions = new RequestOptions<UserInviteCreateRequest>();

        localVarRequestOptions.Data = userInviteCreateRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<UserInvite>("users/invites", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersInvitesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Accept an invite Accepts an invite and creates the user with the provided password. This endpoint is unauthenticated and protected by the token itself.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="token">The invite token</param>
    /// <param name="userInviteAcceptRequest">Password to set for the new user</param>
    /// <returns>UserInviteAcceptResponse</returns>
    public UserInviteAcceptResponse ApiUsersInvitesTokenAcceptPost(string token, UserInviteAcceptRequest userInviteAcceptRequest)
    {
        ApiResponse<UserInviteAcceptResponse> localVarResponse = ApiUsersInvitesTokenAcceptPostWithHttpInfo(token, userInviteAcceptRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Accept an invite Accepts an invite and creates the user with the provided password. This endpoint is unauthenticated and protected by the token itself.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="token">The invite token</param>
    /// <param name="userInviteAcceptRequest">Password to set for the new user</param>
    /// <returns>ApiResponse of UserInviteAcceptResponse</returns>
    internal ApiResponse<UserInviteAcceptResponse> ApiUsersInvitesTokenAcceptPostWithHttpInfo(string token, UserInviteAcceptRequest userInviteAcceptRequest)
    {
        ValidateParameter(token, "token", "UsersApi->ApiUsersInvitesTokenAcceptPost");

        ValidateParameter(userInviteAcceptRequest, "userInviteAcceptRequest", "UsersApi->ApiUsersInvitesTokenAcceptPost");

        RequestOptions<UserInviteAcceptRequest> localVarRequestOptions = new RequestOptions<UserInviteAcceptRequest>();

        localVarRequestOptions.PathParameters.Add("token", ClientUtils.ParameterToString(token)); // path parameter
        localVarRequestOptions.Data = userInviteAcceptRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<UserInviteAcceptResponse>("users/invites/{token}/accept", localVarRequestOptions);
        this.CheckForException("ApiUsersInvitesTokenAcceptPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Accept an invite Accepts an invite and creates the user with the provided password. This endpoint is unauthenticated and protected by the token itself.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="token">The invite token</param>
    /// <param name="userInviteAcceptRequest">Password to set for the new user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of UserInviteAcceptResponse</returns>
    public async System.Threading.Tasks.Task<UserInviteAcceptResponse> ApiUsersInvitesTokenAcceptPostAsync(string token, UserInviteAcceptRequest userInviteAcceptRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<UserInviteAcceptResponse> localVarResponse = await ApiUsersInvitesTokenAcceptPostWithHttpInfoAsync(token, userInviteAcceptRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Accept an invite Accepts an invite and creates the user with the provided password. This endpoint is unauthenticated and protected by the token itself.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="token">The invite token</param>
    /// <param name="userInviteAcceptRequest">Password to set for the new user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (UserInviteAcceptResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<UserInviteAcceptResponse>> ApiUsersInvitesTokenAcceptPostWithHttpInfoAsync(string token, UserInviteAcceptRequest userInviteAcceptRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(token, "token", "UsersApi->ApiUsersInvitesTokenAcceptPost");

        ValidateParameter(userInviteAcceptRequest, "userInviteAcceptRequest", "UsersApi->ApiUsersInvitesTokenAcceptPost");

        RequestOptions<UserInviteAcceptRequest> localVarRequestOptions = new RequestOptions<UserInviteAcceptRequest>();

        localVarRequestOptions.PathParameters.Add("token", ClientUtils.ParameterToString(token)); // path parameter
        localVarRequestOptions.Data = userInviteAcceptRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<UserInviteAcceptResponse>("users/invites/{token}/accept", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersInvitesTokenAcceptPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get invite information Retrieves public information about an invite. This endpoint is unauthenticated and protected by the token itself.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="token">The invite token</param>
    /// <returns>UserInviteInfo</returns>
    public UserInviteInfo ApiUsersInvitesTokenGet(string token)
    {
        ApiResponse<UserInviteInfo> localVarResponse = ApiUsersInvitesTokenGetWithHttpInfo(token);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get invite information Retrieves public information about an invite. This endpoint is unauthenticated and protected by the token itself.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="token">The invite token</param>
    /// <returns>ApiResponse of UserInviteInfo</returns>
    internal ApiResponse<UserInviteInfo> ApiUsersInvitesTokenGetWithHttpInfo(string token)
    {
        ValidateParameter(token, "token", "UsersApi->ApiUsersInvitesTokenGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("token", ClientUtils.ParameterToString(token)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<UserInviteInfo>("users/invites/{token}", localVarRequestOptions);
        this.CheckForException("ApiUsersInvitesTokenGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get invite information Retrieves public information about an invite. This endpoint is unauthenticated and protected by the token itself.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="token">The invite token</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of UserInviteInfo</returns>
    public async System.Threading.Tasks.Task<UserInviteInfo> ApiUsersInvitesTokenGetAsync(string token, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<UserInviteInfo> localVarResponse = await ApiUsersInvitesTokenGetWithHttpInfoAsync(token, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get invite information Retrieves public information about an invite. This endpoint is unauthenticated and protected by the token itself.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="token">The invite token</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (UserInviteInfo)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<UserInviteInfo>> ApiUsersInvitesTokenGetWithHttpInfoAsync(string token, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(token, "token", "UsersApi->ApiUsersInvitesTokenGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("token", ClientUtils.ParameterToString(token)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<UserInviteInfo>("users/invites/{token}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersInvitesTokenGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a User Creates a new service user or sends an invite to a regular user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userCreateRequest">User invite information (optional)</param>
    /// <returns>User</returns>
    public User ApiUsersPost(UserCreateRequest? userCreateRequest = null)
    {
        ApiResponse<User> localVarResponse = ApiUsersPostWithHttpInfo(userCreateRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a User Creates a new service user or sends an invite to a regular user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userCreateRequest">User invite information (optional)</param>
    /// <returns>ApiResponse of User</returns>
    internal ApiResponse<User> ApiUsersPostWithHttpInfo(UserCreateRequest? userCreateRequest = null)
    {
        RequestOptions<UserCreateRequest> localVarRequestOptions = new RequestOptions<UserCreateRequest>();

        localVarRequestOptions.Data = userCreateRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<User>("users", localVarRequestOptions);
        this.CheckForException("ApiUsersPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a User Creates a new service user or sends an invite to a regular user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userCreateRequest">User invite information (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of User</returns>
    public async System.Threading.Tasks.Task<User> ApiUsersPostAsync(UserCreateRequest? userCreateRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<User> localVarResponse = await ApiUsersPostWithHttpInfoAsync(userCreateRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a User Creates a new service user or sends an invite to a regular user
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userCreateRequest">User invite information (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (User)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<User>> ApiUsersPostWithHttpInfoAsync(UserCreateRequest? userCreateRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<UserCreateRequest> localVarRequestOptions = new RequestOptions<UserCreateRequest>();

        localVarRequestOptions.Data = userCreateRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<User>("users", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Approve user Approve a user that is pending approval
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns>User</returns>
    public User ApiUsersUserIdApprovePost(string userId)
    {
        ApiResponse<User> localVarResponse = ApiUsersUserIdApprovePostWithHttpInfo(userId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Approve user Approve a user that is pending approval
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns>ApiResponse of User</returns>
    internal ApiResponse<User> ApiUsersUserIdApprovePostWithHttpInfo(string userId)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdApprovePost");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Post<User>("users/{userId}/approve", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdApprovePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Approve user Approve a user that is pending approval
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of User</returns>
    public async System.Threading.Tasks.Task<User> ApiUsersUserIdApprovePostAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<User> localVarResponse = await ApiUsersUserIdApprovePostWithHttpInfoAsync(userId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Approve user Approve a user that is pending approval
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (User)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<User>> ApiUsersUserIdApprovePostWithHttpInfoAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdApprovePost");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<User>("users/{userId}/approve", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdApprovePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a User This method removes a user from accessing the system. For this leaves the IDP user intact unless the &#x60;- -user-delete-from-idp&#x60; is passed to management startup.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns></returns>
    public void ApiUsersUserIdDelete(string userId)
    {
        ApiUsersUserIdDeleteWithHttpInfo(userId);
    }

    /// <summary>
    /// Delete a User This method removes a user from accessing the system. For this leaves the IDP user intact unless the &#x60;- -user-delete-from-idp&#x60; is passed to management startup.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiUsersUserIdDeleteWithHttpInfo(string userId)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("users/{userId}", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a User This method removes a user from accessing the system. For this leaves the IDP user intact unless the &#x60;- -user-delete-from-idp&#x60; is passed to management startup.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiUsersUserIdDeleteAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiUsersUserIdDeleteWithHttpInfoAsync(userId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a User This method removes a user from accessing the system. For this leaves the IDP user intact unless the &#x60;- -user-delete-from-idp&#x60; is passed to management startup.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiUsersUserIdDeleteWithHttpInfoAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("users/{userId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Resend user invitation Resend user invitation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns></returns>
    public void ApiUsersUserIdInvitePost(string userId)
    {
        ApiUsersUserIdInvitePostWithHttpInfo(userId);
    }

    /// <summary>
    /// Resend user invitation Resend user invitation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiUsersUserIdInvitePostWithHttpInfo(string userId)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdInvitePost");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Post<object>("users/{userId}/invite", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdInvitePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Resend user invitation Resend user invitation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiUsersUserIdInvitePostAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiUsersUserIdInvitePostWithHttpInfoAsync(userId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Resend user invitation Resend user invitation
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiUsersUserIdInvitePostWithHttpInfoAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdInvitePost");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Object>("users/{userId}/invite", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdInvitePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Change user password Change the password for a user. Only available when embedded IdP is enabled. Users can only change their own password.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="passwordChangeRequest">Password change request</param>
    /// <returns></returns>
    public void ApiUsersUserIdPasswordPut(string userId, PasswordChangeRequest passwordChangeRequest)
    {
        ApiUsersUserIdPasswordPutWithHttpInfo(userId, passwordChangeRequest);
    }

    /// <summary>
    /// Change user password Change the password for a user. Only available when embedded IdP is enabled. Users can only change their own password.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="passwordChangeRequest">Password change request</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<Object> ApiUsersUserIdPasswordPutWithHttpInfo(string userId, PasswordChangeRequest passwordChangeRequest)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdPasswordPut");

        ValidateParameter(passwordChangeRequest, "passwordChangeRequest", "UsersApi->ApiUsersUserIdPasswordPut");

        RequestOptions<PasswordChangeRequest> localVarRequestOptions = new RequestOptions<PasswordChangeRequest>();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.Data = passwordChangeRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Object>("users/{userId}/password", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdPasswordPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Change user password Change the password for a user. Only available when embedded IdP is enabled. Users can only change their own password.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="passwordChangeRequest">Password change request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiUsersUserIdPasswordPutAsync(string userId, PasswordChangeRequest passwordChangeRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiUsersUserIdPasswordPutWithHttpInfoAsync(userId, passwordChangeRequest, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Change user password Change the password for a user. Only available when embedded IdP is enabled. Users can only change their own password.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="passwordChangeRequest">Password change request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiUsersUserIdPasswordPutWithHttpInfoAsync(string userId, PasswordChangeRequest passwordChangeRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdPasswordPut");

        ValidateParameter(passwordChangeRequest, "passwordChangeRequest", "UsersApi->ApiUsersUserIdPasswordPut");

        RequestOptions<PasswordChangeRequest> localVarRequestOptions = new RequestOptions<PasswordChangeRequest>();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.Data = passwordChangeRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Object>("users/{userId}/password", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdPasswordPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a User Update information about a User
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="userRequest">User update (optional)</param>
    /// <returns>User</returns>
    public User ApiUsersUserIdPut(string userId, UserRequest? userRequest = null)
    {
        ApiResponse<User> localVarResponse = ApiUsersUserIdPutWithHttpInfo(userId, userRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a User Update information about a User
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="userRequest">User update (optional)</param>
    /// <returns>ApiResponse of User</returns>
    internal ApiResponse<User> ApiUsersUserIdPutWithHttpInfo(string userId, UserRequest? userRequest = null)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdPut");

        RequestOptions<UserRequest> localVarRequestOptions = new RequestOptions<UserRequest>();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.Data = userRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<User>("users/{userId}", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a User Update information about a User
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="userRequest">User update (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of User</returns>
    public async System.Threading.Tasks.Task<User> ApiUsersUserIdPutAsync(string userId, UserRequest? userRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<User> localVarResponse = await ApiUsersUserIdPutWithHttpInfoAsync(userId, userRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a User Update information about a User
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="userRequest">User update (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (User)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<User>> ApiUsersUserIdPutWithHttpInfoAsync(string userId, UserRequest? userRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdPut");

        RequestOptions<UserRequest> localVarRequestOptions = new RequestOptions<UserRequest>();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter
        localVarRequestOptions.Data = userRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<User>("users/{userId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Reject user Reject a user that is pending approval by removing them from the account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns></returns>
    public void ApiUsersUserIdRejectDelete(string userId)
    {
        ApiUsersUserIdRejectDeleteWithHttpInfo(userId);
    }

    /// <summary>
    /// Reject user Reject a user that is pending approval by removing them from the account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<Object> ApiUsersUserIdRejectDeleteWithHttpInfo(string userId)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdRejectDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<Object>("users/{userId}/reject", localVarRequestOptions);
        this.CheckForException("ApiUsersUserIdRejectDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Reject user Reject a user that is pending approval by removing them from the account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiUsersUserIdRejectDeleteAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiUsersUserIdRejectDeleteWithHttpInfoAsync(userId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Reject user Reject a user that is pending approval by removing them from the account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="userId">The unique identifier of a user</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiUsersUserIdRejectDeleteWithHttpInfoAsync(string userId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(userId, "userId", "UsersApi->ApiUsersUserIdRejectDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("userId", ClientUtils.ParameterToString(userId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("users/{userId}/reject", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiUsersUserIdRejectDelete", localVarResponse);

        return localVarResponse;
    }

}




