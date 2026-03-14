

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
public class PoliciesApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PoliciesApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal PoliciesApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Policies Returns a list of all policies
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;Policy&gt;</returns>
    public List<Policy> ApiPoliciesGet()
    {
        ApiResponse<List<Policy>> localVarResponse = ApiPoliciesGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Policies Returns a list of all policies
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;Policy&gt;</returns>
    public ApiResponse<List<Policy>> ApiPoliciesGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Policy>>("policies", localVarRequestOptions);
        this.CheckForException("ApiPoliciesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Policies Returns a list of all policies
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Policy&gt;</returns>
    public async System.Threading.Tasks.Task<List<Policy>> ApiPoliciesGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Policy>> localVarResponse = await ApiPoliciesGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Policies Returns a list of all policies
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Policy&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Policy>>> ApiPoliciesGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Policy>>("policies", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPoliciesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Policy Delete a policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <returns></returns>
    public void ApiPoliciesPolicyIdDelete(string policyId)
    {
        ApiPoliciesPolicyIdDeleteWithHttpInfo(policyId);
    }

    /// <summary>
    /// Delete a Policy Delete a policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiPoliciesPolicyIdDeleteWithHttpInfo(string policyId)
    {
        ValidateParameter(policyId, "policyId", "PoliciesApi->ApiPoliciesPolicyIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("policyId", ClientUtils.ParameterToString(policyId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("policies/{policyId}", localVarRequestOptions);
        this.CheckForException("ApiPoliciesPolicyIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Policy Delete a policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiPoliciesPolicyIdDeleteAsync(string policyId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiPoliciesPolicyIdDeleteWithHttpInfoAsync(policyId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Policy Delete a policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiPoliciesPolicyIdDeleteWithHttpInfoAsync(string policyId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(policyId, "policyId", "PoliciesApi->ApiPoliciesPolicyIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("policyId", ClientUtils.ParameterToString(policyId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("policies/{policyId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPoliciesPolicyIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Policy Get information about a Policies
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <returns>Policy</returns>
    public Policy ApiPoliciesPolicyIdGet(string policyId)
    {
        ApiResponse<Policy> localVarResponse = ApiPoliciesPolicyIdGetWithHttpInfo(policyId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Policy Get information about a Policies
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <returns>ApiResponse of Policy</returns>
    internal ApiResponse<Policy> ApiPoliciesPolicyIdGetWithHttpInfo(string policyId)
    {
        ValidateParameter(policyId, "policyId", "PoliciesApi->ApiPoliciesPolicyIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("policyId", ClientUtils.ParameterToString(policyId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<Policy>("policies/{policyId}", localVarRequestOptions);
        this.CheckForException("ApiPoliciesPolicyIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Policy Get information about a Policies
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Policy</returns>
    public async System.Threading.Tasks.Task<Policy> ApiPoliciesPolicyIdGetAsync(string policyId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Policy> localVarResponse = await ApiPoliciesPolicyIdGetWithHttpInfoAsync(policyId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Policy Get information about a Policies
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Policy)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Policy>> ApiPoliciesPolicyIdGetWithHttpInfoAsync(string policyId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(policyId, "policyId", "PoliciesApi->ApiPoliciesPolicyIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("policyId", ClientUtils.ParameterToString(policyId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Policy>("policies/{policyId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPoliciesPolicyIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Policy Update/Replace a Policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <param name="policyCreate">Update Policy request (optional)</param>
    /// <returns>Policy</returns>
    public Policy ApiPoliciesPolicyIdPut(string policyId, PolicyCreate? policyCreate = null)
    {
        ApiResponse<Policy> localVarResponse = ApiPoliciesPolicyIdPutWithHttpInfo(policyId, policyCreate);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Policy Update/Replace a Policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <param name="policyCreate">Update Policy request (optional)</param>
    /// <returns>ApiResponse of Policy</returns>
    internal ApiResponse<Policy> ApiPoliciesPolicyIdPutWithHttpInfo(string policyId, PolicyCreate? policyCreate = null)
    {
        ValidateParameter(policyId, "policyId", "PoliciesApi->ApiPoliciesPolicyIdPut");

        RequestOptions<PolicyCreate> localVarRequestOptions = new RequestOptions<PolicyCreate>();

        localVarRequestOptions.PathParameters.Add("policyId", ClientUtils.ParameterToString(policyId)); // path parameter
        localVarRequestOptions.Data = policyCreate;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Policy>("policies/{policyId}", localVarRequestOptions);
        this.CheckForException("ApiPoliciesPolicyIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Policy Update/Replace a Policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <param name="policyCreate">Update Policy request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Policy</returns>
    public async System.Threading.Tasks.Task<Policy> ApiPoliciesPolicyIdPutAsync(string policyId, PolicyCreate? policyCreate = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Policy> localVarResponse = await ApiPoliciesPolicyIdPutWithHttpInfoAsync(policyId, policyCreate, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Policy Update/Replace a Policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyId">The unique identifier of a policy</param>
    /// <param name="policyCreate">Update Policy request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Policy)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Policy>> ApiPoliciesPolicyIdPutWithHttpInfoAsync(string policyId, PolicyCreate? policyCreate = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(policyId, "policyId", "PoliciesApi->ApiPoliciesPolicyIdPut");

        RequestOptions<PolicyCreate> localVarRequestOptions = new RequestOptions<PolicyCreate>();

        localVarRequestOptions.PathParameters.Add("policyId", ClientUtils.ParameterToString(policyId)); // path parameter
        localVarRequestOptions.Data = policyCreate;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Policy>("policies/{policyId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPoliciesPolicyIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Policy Creates a policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyUpdate">New Policy request (optional)</param>
    /// <returns>Policy</returns>
    public Policy ApiPoliciesPost(PolicyUpdate? policyUpdate = null)
    {
        ApiResponse<Policy> localVarResponse = ApiPoliciesPostWithHttpInfo(policyUpdate);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Policy Creates a policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyUpdate">New Policy request (optional)</param>
    /// <returns>ApiResponse of Policy</returns>
    internal ApiResponse<Policy> ApiPoliciesPostWithHttpInfo(PolicyUpdate? policyUpdate = null)
    {
        RequestOptions<PolicyUpdate> localVarRequestOptions = new RequestOptions<PolicyUpdate>();

        localVarRequestOptions.Data = policyUpdate;

        // make the HTTP request
        var localVarResponse = this.Client.Post<Policy>("policies", localVarRequestOptions);
        this.CheckForException("ApiPoliciesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Policy Creates a policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyUpdate">New Policy request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Policy</returns>
    public async System.Threading.Tasks.Task<Policy> ApiPoliciesPostAsync(PolicyUpdate? policyUpdate = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Policy> localVarResponse = await ApiPoliciesPostWithHttpInfoAsync(policyUpdate, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Policy Creates a policy
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="policyUpdate">New Policy request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Policy)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Policy>> ApiPoliciesPostWithHttpInfoAsync(PolicyUpdate? policyUpdate = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<PolicyUpdate> localVarRequestOptions = new RequestOptions<PolicyUpdate>();

        localVarRequestOptions.Data = policyUpdate;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Policy>("policies", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiPoliciesPost", localVarResponse);

        return localVarResponse;
    }

}




