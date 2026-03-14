

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
public class PostureChecksApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PostureChecksApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal PostureChecksApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Posture Checks Returns a list of all posture checks
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;PostureCheck&gt;</returns>
    public List<PostureCheck> ApiPostureChecksGet()
    {
        ApiResponse<List<PostureCheck>> localVarResponse = ApiPostureChecksGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Posture Checks Returns a list of all posture checks
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;PostureCheck&gt;</returns>
    public ApiResponse<List<PostureCheck>> ApiPostureChecksGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Post<List<PostureCheck>>("posture-checks", localVarRequestOptions);
        this.CheckForException("ApiPostureChecksGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Posture Checks Returns a list of all posture checks
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;PostureCheck&gt;</returns>
    public async System.Threading.Tasks.Task<List<PostureCheck>> ApiPostureChecksGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<PostureCheck>> localVarResponse = await ApiPostureChecksGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Posture Checks Returns a list of all posture checks
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;PostureCheck&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<PostureCheck>>> ApiPostureChecksGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<List<PostureCheck>>("posture-checks", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPostureChecksGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Posture Check Creates a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckUpdate">New posture check request (optional)</param>
    /// <returns>PostureCheck</returns>
    public PostureCheck ApiPostureChecksPost(PostureCheckUpdate? postureCheckUpdate = null)
    {
        ApiResponse<PostureCheck> localVarResponse = ApiPostureChecksPostWithHttpInfo(postureCheckUpdate);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Posture Check Creates a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckUpdate">New posture check request (optional)</param>
    /// <returns>ApiResponse of PostureCheck</returns>
    internal ApiResponse<PostureCheck> ApiPostureChecksPostWithHttpInfo(PostureCheckUpdate? postureCheckUpdate = null)
    {
        RequestOptions<PostureCheckUpdate> localVarRequestOptions = new RequestOptions<PostureCheckUpdate>();

        localVarRequestOptions.Data = postureCheckUpdate;

        // make the HTTP request
        var localVarResponse = this.Client.Post<PostureCheck>("posture-checks", localVarRequestOptions);
        this.CheckForException("ApiPostureChecksPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Posture Check Creates a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckUpdate">New posture check request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PostureCheck</returns>
    public async System.Threading.Tasks.Task<PostureCheck> ApiPostureChecksPostAsync(PostureCheckUpdate? postureCheckUpdate = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<PostureCheck> localVarResponse = await ApiPostureChecksPostWithHttpInfoAsync(postureCheckUpdate, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Posture Check Creates a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckUpdate">New posture check request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PostureCheck)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<PostureCheck>> ApiPostureChecksPostWithHttpInfoAsync(PostureCheckUpdate? postureCheckUpdate = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<PostureCheckUpdate> localVarRequestOptions = new RequestOptions<PostureCheckUpdate>();

        localVarRequestOptions.Data = postureCheckUpdate;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<PostureCheck>("posture-checks", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPostureChecksPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Posture Check Delete a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <returns></returns>
    public void ApiPostureChecksPostureCheckIdDelete(string postureCheckId)
    {
        ApiPostureChecksPostureCheckIdDeleteWithHttpInfo(postureCheckId);
    }

    /// <summary>
    /// Delete a Posture Check Delete a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiPostureChecksPostureCheckIdDeleteWithHttpInfo(string postureCheckId)
    {
        ValidateParameter(postureCheckId, "postureCheckId", "PostureChecksApi->ApiPostureChecksPostureCheckIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("postureCheckId", ClientUtils.ParameterToString(postureCheckId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Post<object>("posture-checks/{postureCheckId}", localVarRequestOptions);
        this.CheckForException("ApiPostureChecksPostureCheckIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Posture Check Delete a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiPostureChecksPostureCheckIdDeleteAsync(string postureCheckId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiPostureChecksPostureCheckIdDeleteWithHttpInfoAsync(postureCheckId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Posture Check Delete a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiPostureChecksPostureCheckIdDeleteWithHttpInfoAsync(string postureCheckId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(postureCheckId, "postureCheckId", "PostureChecksApi->ApiPostureChecksPostureCheckIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("postureCheckId", ClientUtils.ParameterToString(postureCheckId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Object>("posture-checks/{postureCheckId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPostureChecksPostureCheckIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Posture Check Get information about a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <returns>PostureCheck</returns>
    public PostureCheck ApiPostureChecksPostureCheckIdGet(string postureCheckId)
    {
        ApiResponse<PostureCheck> localVarResponse = ApiPostureChecksPostureCheckIdGetWithHttpInfo(postureCheckId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Posture Check Get information about a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <returns>ApiResponse of PostureCheck</returns>
    internal ApiResponse<PostureCheck> ApiPostureChecksPostureCheckIdGetWithHttpInfo(string postureCheckId)
    {
        ValidateParameter(postureCheckId, "postureCheckId", "PostureChecksApi->ApiPostureChecksPostureCheckIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("postureCheckId", ClientUtils.ParameterToString(postureCheckId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Post<PostureCheck>("posture-checks/{postureCheckId}", localVarRequestOptions);
        this.CheckForException("ApiPostureChecksPostureCheckIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Posture Check Get information about a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PostureCheck</returns>
    public async System.Threading.Tasks.Task<PostureCheck> ApiPostureChecksPostureCheckIdGetAsync(string postureCheckId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<PostureCheck> localVarResponse = await ApiPostureChecksPostureCheckIdGetWithHttpInfoAsync(postureCheckId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Posture Check Get information about a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PostureCheck)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<PostureCheck>> ApiPostureChecksPostureCheckIdGetWithHttpInfoAsync(string postureCheckId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(postureCheckId, "postureCheckId", "PostureChecksApi->ApiPostureChecksPostureCheckIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("postureCheckId", ClientUtils.ParameterToString(postureCheckId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<PostureCheck>("posture-checks/{postureCheckId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPostureChecksPostureCheckIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Posture Check Update/Replace a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <param name="postureCheckUpdate">Update Rule request (optional)</param>
    /// <returns>PostureCheck</returns>
    public PostureCheck ApiPostureChecksPostureCheckIdPut(string postureCheckId, PostureCheckUpdate? postureCheckUpdate = null)
    {
        ApiResponse<PostureCheck> localVarResponse = ApiPostureChecksPostureCheckIdPutWithHttpInfo(postureCheckId, postureCheckUpdate);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Posture Check Update/Replace a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <param name="postureCheckUpdate">Update Rule request (optional)</param>
    /// <returns>ApiResponse of PostureCheck</returns>
    internal ApiResponse<PostureCheck> ApiPostureChecksPostureCheckIdPutWithHttpInfo(string postureCheckId, PostureCheckUpdate? postureCheckUpdate = null)
    {
        ValidateParameter(postureCheckId, "postureCheckId", "PostureChecksApi->ApiPostureChecksPostureCheckIdPut");

        RequestOptions<PostureCheckUpdate> localVarRequestOptions = new RequestOptions<PostureCheckUpdate>();

        localVarRequestOptions.PathParameters.Add("postureCheckId", ClientUtils.ParameterToString(postureCheckId)); // path parameter
        localVarRequestOptions.Data = postureCheckUpdate;

        // make the HTTP request
        var localVarResponse = this.Client.Post<PostureCheck>("posture-checks/{postureCheckId}", localVarRequestOptions);
        this.CheckForException("ApiPostureChecksPostureCheckIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Posture Check Update/Replace a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <param name="postureCheckUpdate">Update Rule request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PostureCheck</returns>
    public async System.Threading.Tasks.Task<PostureCheck> ApiPostureChecksPostureCheckIdPutAsync(string postureCheckId, PostureCheckUpdate? postureCheckUpdate = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<PostureCheck> localVarResponse = await ApiPostureChecksPostureCheckIdPutWithHttpInfoAsync(postureCheckId, postureCheckUpdate, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Posture Check Update/Replace a posture check
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="postureCheckId">The unique identifier of a posture check</param>
    /// <param name="postureCheckUpdate">Update Rule request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PostureCheck)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<PostureCheck>> ApiPostureChecksPostureCheckIdPutWithHttpInfoAsync(string postureCheckId, PostureCheckUpdate? postureCheckUpdate = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(postureCheckId, "postureCheckId", "PostureChecksApi->ApiPostureChecksPostureCheckIdPut");

        RequestOptions<PostureCheckUpdate> localVarRequestOptions = new RequestOptions<PostureCheckUpdate>();

        localVarRequestOptions.PathParameters.Add("postureCheckId", ClientUtils.ParameterToString(postureCheckId)); // path parameter
        localVarRequestOptions.Data = postureCheckUpdate;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<PostureCheck>("posture-checks/{postureCheckId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPostureChecksPostureCheckIdPut", localVarResponse);

        return localVarResponse;
    }

}




