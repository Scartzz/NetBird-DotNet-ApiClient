

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
public class JobsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="JobsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal JobsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List Jobs Retrieve all jobs for a given peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <returns>List&lt;JobResponse&gt;</returns>
    public List<JobResponse> ApiPeersPeerIdJobsGet(string peerId)
    {
        ApiResponse<List<JobResponse>> localVarResponse = ApiPeersPeerIdJobsGetWithHttpInfo(peerId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List Jobs Retrieve all jobs for a given peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <returns>ApiResponse of List&lt;JobResponse&gt;</returns>
    public ApiResponse<List<JobResponse>> ApiPeersPeerIdJobsGetWithHttpInfo(string peerId)
    {
        ValidateParameter(peerId, "peerId", "JobsApi.ApiPeersPeerIdJobsGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<JobResponse>>("peers/{peerId}/jobs", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdJobsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List Jobs Retrieve all jobs for a given peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;JobResponse&gt;</returns>
    public async System.Threading.Tasks.Task<List<JobResponse>> ApiPeersPeerIdJobsGetAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<JobResponse>> localVarResponse = await ApiPeersPeerIdJobsGetWithHttpInfoAsync(peerId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List Jobs Retrieve all jobs for a given peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;JobResponse&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<JobResponse>>> ApiPeersPeerIdJobsGetWithHttpInfoAsync(string peerId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "JobsApi.ApiPeersPeerIdJobsGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<JobResponse>>("peers/{peerId}/jobs", localVarRequestOptions, cancellationToken).ConfigureAwait(false);
        this.CheckForException("ApiPeersPeerIdJobsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get Job Retrieve details of a specific job
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="jobId">The unique identifier of a job</param>
    /// <returns>JobResponse</returns>
    public JobResponse ApiPeersPeerIdJobsJobIdGet(string peerId, string jobId)
    {
        ApiResponse<JobResponse> localVarResponse = ApiPeersPeerIdJobsJobIdGetWithHttpInfo(peerId, jobId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Job Retrieve details of a specific job
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="jobId">The unique identifier of a job</param>
    /// <returns>ApiResponse of JobResponse</returns>
    internal ApiResponse<JobResponse> ApiPeersPeerIdJobsJobIdGetWithHttpInfo(string peerId, string jobId)
    {
        ValidateParameter(peerId, "peerId", "JobsApi->ApiPeersPeerIdJobsJobIdGet");

        ValidateParameter(jobId, "jobId", "JobsApi->ApiPeersPeerIdJobsJobIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.PathParameters.Add("jobId", ClientUtils.ParameterToString(jobId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<JobResponse>("peers/{peerId}/jobs/{jobId}", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdJobsJobIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get Job Retrieve details of a specific job
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="jobId">The unique identifier of a job</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of JobResponse</returns>
    public async System.Threading.Tasks.Task<JobResponse> ApiPeersPeerIdJobsJobIdGetAsync(string peerId, string jobId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<JobResponse> localVarResponse = await ApiPeersPeerIdJobsJobIdGetWithHttpInfoAsync(peerId, jobId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Job Retrieve details of a specific job
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="jobId">The unique identifier of a job</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (JobResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<JobResponse>> ApiPeersPeerIdJobsJobIdGetWithHttpInfoAsync(string peerId, string jobId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "JobsApi->ApiPeersPeerIdJobsJobIdGet");

        ValidateParameter(jobId, "jobId", "JobsApi->ApiPeersPeerIdJobsJobIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.PathParameters.Add("jobId", ClientUtils.ParameterToString(jobId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<JobResponse>("peers/{peerId}/jobs/{jobId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdJobsJobIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create Job Create a new job for a given peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="jobRequest">Create job request</param>
    /// <returns>JobResponse</returns>
    public JobResponse ApiPeersPeerIdJobsPost(string peerId, JobRequest jobRequest)
    {
        ApiResponse<JobResponse> localVarResponse = ApiPeersPeerIdJobsPostWithHttpInfo(peerId, jobRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create Job Create a new job for a given peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="jobRequest">Create job request</param>
    /// <returns>ApiResponse of JobResponse</returns>
    internal ApiResponse<JobResponse> ApiPeersPeerIdJobsPostWithHttpInfo(string peerId, JobRequest jobRequest)
    {
        ValidateParameter(peerId, "peerId", "JobsApi->ApiPeersPeerIdJobsPost");

        ValidateParameter(jobRequest, "jobRequest", "JobsApi->ApiPeersPeerIdJobsPost");

        RequestOptions<JobRequest> localVarRequestOptions = new RequestOptions<JobRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.Data = jobRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<JobResponse>("peers/{peerId}/jobs", localVarRequestOptions);
        this.CheckForException("ApiPeersPeerIdJobsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create Job Create a new job for a given peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="jobRequest">Create job request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of JobResponse</returns>
    public async System.Threading.Tasks.Task<JobResponse> ApiPeersPeerIdJobsPostAsync(string peerId, JobRequest jobRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<JobResponse> localVarResponse = await ApiPeersPeerIdJobsPostWithHttpInfoAsync(peerId, jobRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create Job Create a new job for a given peer
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="peerId">The unique identifier of a peer</param>
    /// <param name="jobRequest">Create job request</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (JobResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<JobResponse>> ApiPeersPeerIdJobsPostWithHttpInfoAsync(string peerId, JobRequest jobRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(peerId, "peerId", "JobsApi->ApiPeersPeerIdJobsPost");

        ValidateParameter(jobRequest, "jobRequest", "JobsApi->ApiPeersPeerIdJobsPost");

        RequestOptions<JobRequest> localVarRequestOptions = new RequestOptions<JobRequest>();

        localVarRequestOptions.PathParameters.Add("peerId", ClientUtils.ParameterToString(peerId)); // path parameter
        localVarRequestOptions.Data = jobRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<JobResponse>("peers/{peerId}/jobs", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPeersPeerIdJobsPost", localVarResponse);

        return localVarResponse;
    }

}




