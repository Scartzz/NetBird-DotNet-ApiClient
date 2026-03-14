

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
public class GroupsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GroupsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal GroupsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Groups Returns a list of all groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="name">Filter groups by name (exact match) (optional)</param>
    /// <returns>List&lt;Group&gt;</returns>
    public List<Group> ApiGroupsGet(string? name = null)
    {
        ApiResponse<List<Group>> localVarResponse = ApiGroupsGetWithHttpInfo(name);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Groups Returns a list of all groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="name">Filter groups by name (exact match) (optional)</param>
    /// <returns>ApiResponse of List&lt;Group&gt;</returns>
    public ApiResponse<List<Group>> ApiGroupsGetWithHttpInfo(string? name = null)
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        if (name is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "name", name));
        }

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Group>>("groups", localVarRequestOptions);
        this.CheckForException("ApiGroupsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Groups Returns a list of all groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="name">Filter groups by name (exact match) (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Group&gt;</returns>
    public async System.Threading.Tasks.Task<List<Group>> ApiGroupsGetAsync(string? name = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Group>> localVarResponse = await ApiGroupsGetWithHttpInfoAsync(name, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Groups Returns a list of all groups
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="name">Filter groups by name (exact match) (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Group&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Group>>> ApiGroupsGetWithHttpInfoAsync(string? name = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        if (name is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "name", name));
        }

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Group>>("groups", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiGroupsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Group Delete a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <returns></returns>
    public void ApiGroupsGroupIdDelete(string groupId)
    {
        ApiGroupsGroupIdDeleteWithHttpInfo(groupId);
    }

    /// <summary>
    /// Delete a Group Delete a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiGroupsGroupIdDeleteWithHttpInfo(string groupId)
    {
        ValidateParameter(groupId, "groupId", "GroupsApi->ApiGroupsGroupIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("groups/{groupId}", localVarRequestOptions);
        this.CheckForException("ApiGroupsGroupIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Group Delete a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiGroupsGroupIdDeleteAsync(string groupId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiGroupsGroupIdDeleteWithHttpInfoAsync(groupId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Group Delete a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiGroupsGroupIdDeleteWithHttpInfoAsync(string groupId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(groupId, "groupId", "GroupsApi->ApiGroupsGroupIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("groups/{groupId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiGroupsGroupIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Group Get information about a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <returns>Group</returns>
    public Group ApiGroupsGroupIdGet(string groupId)
    {
        ApiResponse<Group> localVarResponse = ApiGroupsGroupIdGetWithHttpInfo(groupId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Group Get information about a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <returns>ApiResponse of Group</returns>
    internal ApiResponse<Group> ApiGroupsGroupIdGetWithHttpInfo(string groupId)
    {
        ValidateParameter(groupId, "groupId", "GroupsApi->ApiGroupsGroupIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<Group>("groups/{groupId}", localVarRequestOptions);
        this.CheckForException("ApiGroupsGroupIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Group Get information about a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Group</returns>
    public async System.Threading.Tasks.Task<Group> ApiGroupsGroupIdGetAsync(string groupId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Group> localVarResponse = await ApiGroupsGroupIdGetWithHttpInfoAsync(groupId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Group Get information about a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Group)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Group>> ApiGroupsGroupIdGetWithHttpInfoAsync(string groupId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(groupId, "groupId", "GroupsApi->ApiGroupsGroupIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Group>("groups/{groupId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiGroupsGroupIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Group Update/Replace a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <param name="groupRequest">Update Group request (optional)</param>
    /// <returns>Group</returns>
    public Group ApiGroupsGroupIdPut(string groupId, GroupRequest? groupRequest = null)
    {
        ApiResponse<Group> localVarResponse = ApiGroupsGroupIdPutWithHttpInfo(groupId, groupRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Group Update/Replace a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <param name="groupRequest">Update Group request (optional)</param>
    /// <returns>ApiResponse of Group</returns>
    internal ApiResponse<Group> ApiGroupsGroupIdPutWithHttpInfo(string groupId, GroupRequest? groupRequest = null)
    {
        ValidateParameter(groupId, "groupId", "GroupsApi->ApiGroupsGroupIdPut");

        RequestOptions<GroupRequest> localVarRequestOptions = new RequestOptions<GroupRequest>();

        localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter
        localVarRequestOptions.Data = groupRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Group>("groups/{groupId}", localVarRequestOptions);
        this.CheckForException("ApiGroupsGroupIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Group Update/Replace a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <param name="groupRequest">Update Group request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Group</returns>
    public async System.Threading.Tasks.Task<Group> ApiGroupsGroupIdPutAsync(string groupId, GroupRequest? groupRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Group> localVarResponse = await ApiGroupsGroupIdPutWithHttpInfoAsync(groupId, groupRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Group Update/Replace a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupId">The unique identifier of a group</param>
    /// <param name="groupRequest">Update Group request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Group)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Group>> ApiGroupsGroupIdPutWithHttpInfoAsync(string groupId, GroupRequest? groupRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(groupId, "groupId", "GroupsApi->ApiGroupsGroupIdPut");

        RequestOptions<GroupRequest> localVarRequestOptions = new RequestOptions<GroupRequest>();

        localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter
        localVarRequestOptions.Data = groupRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Group>("groups/{groupId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiGroupsGroupIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Group Creates a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupRequest">New Group request (optional)</param>
    /// <returns>Group</returns>
    public Group ApiGroupsPost(GroupRequest? groupRequest = null)
    {
        ApiResponse<Group> localVarResponse = ApiGroupsPostWithHttpInfo(groupRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Group Creates a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupRequest">New Group request (optional)</param>
    /// <returns>ApiResponse of Group</returns>
    internal ApiResponse<Group> ApiGroupsPostWithHttpInfo(GroupRequest? groupRequest = null)
    {
        RequestOptions<GroupRequest> localVarRequestOptions = new RequestOptions<GroupRequest>();

        localVarRequestOptions.Data = groupRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<Group>("groups", localVarRequestOptions);
        this.CheckForException("ApiGroupsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Group Creates a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupRequest">New Group request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Group</returns>
    public async System.Threading.Tasks.Task<Group> ApiGroupsPostAsync(GroupRequest? groupRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Group> localVarResponse = await ApiGroupsPostWithHttpInfoAsync(groupRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Group Creates a group
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="groupRequest">New Group request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Group)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Group>> ApiGroupsPostWithHttpInfoAsync(GroupRequest? groupRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<GroupRequest> localVarRequestOptions = new RequestOptions<GroupRequest>();

        localVarRequestOptions.Data = groupRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Group>("groups", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiGroupsPost", localVarResponse);

        return localVarResponse;
    }

}




