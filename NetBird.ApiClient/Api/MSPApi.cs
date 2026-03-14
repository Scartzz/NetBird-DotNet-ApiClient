

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
public class MSPApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MSPApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal MSPApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Get MSP tenants 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;TenantResponse&gt;</returns>
    public List<TenantResponse> ApiIntegrationsMspTenantsGet()
    {
        ApiResponse<List<TenantResponse>> localVarResponse = ApiIntegrationsMspTenantsGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get MSP tenants 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;TenantResponse&gt;</returns>
    public ApiResponse<List<TenantResponse>> ApiIntegrationsMspTenantsGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<TenantResponse>>("integrations/msp/tenants", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsMspTenantsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get MSP tenants 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;TenantResponse&gt;</returns>
    public async System.Threading.Tasks.Task<List<TenantResponse>> ApiIntegrationsMspTenantsGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<TenantResponse>> localVarResponse = await ApiIntegrationsMspTenantsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get MSP tenants 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;TenantResponse&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<TenantResponse>>> ApiIntegrationsMspTenantsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<TenantResponse>>("integrations/msp/tenants", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsMspTenantsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Verify a tenant domain DNS challenge 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <returns></returns>
    public void ApiIntegrationsMspTenantsIdDnsPost(string id)
    {
        ApiIntegrationsMspTenantsIdDnsPostWithHttpInfo(id);
    }

    /// <summary>
    /// Verify a tenant domain DNS challenge 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIntegrationsMspTenantsIdDnsPostWithHttpInfo(string id)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdDnsPost");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Post<object>("integrations/msp/tenants/{id}/dns", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsMspTenantsIdDnsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Verify a tenant domain DNS challenge 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIntegrationsMspTenantsIdDnsPostAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIntegrationsMspTenantsIdDnsPostWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Verify a tenant domain DNS challenge 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiIntegrationsMspTenantsIdDnsPostWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdDnsPost");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<object>("integrations/msp/tenants/{id}/dns", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsMspTenantsIdDnsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Invite existing account as a Tenant to the MSP account 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of an existing tenant account</param>
    /// <returns>TenantResponse</returns>
    public TenantResponse ApiIntegrationsMspTenantsIdInvitePost(string id)
    {
        ApiResponse<TenantResponse> localVarResponse = ApiIntegrationsMspTenantsIdInvitePostWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Invite existing account as a Tenant to the MSP account 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of an existing tenant account</param>
    /// <returns>ApiResponse of TenantResponse</returns>
    internal ApiResponse<TenantResponse> ApiIntegrationsMspTenantsIdInvitePostWithHttpInfo(string id)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdInvitePost");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Post<TenantResponse>("integrations/msp/tenants/{id}/invite", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsMspTenantsIdInvitePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Invite existing account as a Tenant to the MSP account 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of an existing tenant account</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of TenantResponse</returns>
    public async System.Threading.Tasks.Task<TenantResponse> ApiIntegrationsMspTenantsIdInvitePostAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<TenantResponse> localVarResponse = await ApiIntegrationsMspTenantsIdInvitePostWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Invite existing account as a Tenant to the MSP account 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of an existing tenant account</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TenantResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<TenantResponse>> ApiIntegrationsMspTenantsIdInvitePostWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdInvitePost");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<TenantResponse>("integrations/msp/tenants/{id}/invite", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsMspTenantsIdInvitePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Response by the invited Tenant account owner 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of an existing tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdInvitePutRequest"></param>
    /// <returns></returns>
    public void ApiIntegrationsMspTenantsIdInvitePut(string id, ApiIntegrationsMspTenantsIdInvitePutRequest apiIntegrationsMspTenantsIdInvitePutRequest)
    {
        ApiIntegrationsMspTenantsIdInvitePutWithHttpInfo(id, apiIntegrationsMspTenantsIdInvitePutRequest);
    }

    /// <summary>
    /// Response by the invited Tenant account owner 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of an existing tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdInvitePutRequest"></param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIntegrationsMspTenantsIdInvitePutWithHttpInfo(string id, ApiIntegrationsMspTenantsIdInvitePutRequest apiIntegrationsMspTenantsIdInvitePutRequest)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdInvitePut");

        ValidateParameter(apiIntegrationsMspTenantsIdInvitePutRequest, "apiIntegrationsMspTenantsIdInvitePutRequest", "MSPApi->ApiIntegrationsMspTenantsIdInvitePut");

        RequestOptions<ApiIntegrationsMspTenantsIdInvitePutRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsMspTenantsIdInvitePutRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = apiIntegrationsMspTenantsIdInvitePutRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<object>("integrations/msp/tenants/{id}/invite", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsMspTenantsIdInvitePut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Response by the invited Tenant account owner 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of an existing tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdInvitePutRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIntegrationsMspTenantsIdInvitePutAsync(string id, ApiIntegrationsMspTenantsIdInvitePutRequest apiIntegrationsMspTenantsIdInvitePutRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIntegrationsMspTenantsIdInvitePutWithHttpInfoAsync(id, apiIntegrationsMspTenantsIdInvitePutRequest, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Response by the invited Tenant account owner 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of an existing tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdInvitePutRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiIntegrationsMspTenantsIdInvitePutWithHttpInfoAsync(string id, ApiIntegrationsMspTenantsIdInvitePutRequest apiIntegrationsMspTenantsIdInvitePutRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdInvitePut");

        ValidateParameter(apiIntegrationsMspTenantsIdInvitePutRequest, "apiIntegrationsMspTenantsIdInvitePutRequest", "MSPApi->ApiIntegrationsMspTenantsIdInvitePut");

        RequestOptions<ApiIntegrationsMspTenantsIdInvitePutRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsMspTenantsIdInvitePutRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = apiIntegrationsMspTenantsIdInvitePutRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<object>("integrations/msp/tenants/{id}/invite", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsMspTenantsIdInvitePut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update MSP tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="updateTenantRequest"></param>
    /// <returns>TenantResponse</returns>
    public TenantResponse ApiIntegrationsMspTenantsIdPut(string id, UpdateTenantRequest updateTenantRequest)
    {
        ApiResponse<TenantResponse> localVarResponse = ApiIntegrationsMspTenantsIdPutWithHttpInfo(id, updateTenantRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update MSP tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="updateTenantRequest"></param>
    /// <returns>ApiResponse of TenantResponse</returns>
    internal ApiResponse<TenantResponse> ApiIntegrationsMspTenantsIdPutWithHttpInfo(string id, UpdateTenantRequest updateTenantRequest)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdPut");

        ValidateParameter(updateTenantRequest, "updateTenantRequest", "MSPApi->ApiIntegrationsMspTenantsIdPut");

        RequestOptions<UpdateTenantRequest> localVarRequestOptions = new RequestOptions<UpdateTenantRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = updateTenantRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<TenantResponse>("integrations/msp/tenants/{id}", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsMspTenantsIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update MSP tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="updateTenantRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of TenantResponse</returns>
    public async System.Threading.Tasks.Task<TenantResponse> ApiIntegrationsMspTenantsIdPutAsync(string id, UpdateTenantRequest updateTenantRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<TenantResponse> localVarResponse = await ApiIntegrationsMspTenantsIdPutWithHttpInfoAsync(id, updateTenantRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update MSP tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="updateTenantRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TenantResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<TenantResponse>> ApiIntegrationsMspTenantsIdPutWithHttpInfoAsync(string id, UpdateTenantRequest updateTenantRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdPut");

        ValidateParameter(updateTenantRequest, "updateTenantRequest", "MSPApi->ApiIntegrationsMspTenantsIdPut");

        RequestOptions<UpdateTenantRequest> localVarRequestOptions = new RequestOptions<UpdateTenantRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = updateTenantRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<TenantResponse>("integrations/msp/tenants/{id}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsMspTenantsIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create subscription for Tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdSubscriptionPostRequest"></param>
    /// <returns></returns>
    public void ApiIntegrationsMspTenantsIdSubscriptionPost(string id, ApiIntegrationsMspTenantsIdSubscriptionPostRequest apiIntegrationsMspTenantsIdSubscriptionPostRequest)
    {
        ApiIntegrationsMspTenantsIdSubscriptionPostWithHttpInfo(id, apiIntegrationsMspTenantsIdSubscriptionPostRequest);
    }

    /// <summary>
    /// Create subscription for Tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdSubscriptionPostRequest"></param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIntegrationsMspTenantsIdSubscriptionPostWithHttpInfo(string id, ApiIntegrationsMspTenantsIdSubscriptionPostRequest apiIntegrationsMspTenantsIdSubscriptionPostRequest)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdSubscriptionPost");

        ValidateParameter(apiIntegrationsMspTenantsIdSubscriptionPostRequest, "apiIntegrationsMspTenantsIdSubscriptionPostRequest", "MSPApi->ApiIntegrationsMspTenantsIdSubscriptionPost");

        RequestOptions<ApiIntegrationsMspTenantsIdSubscriptionPostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsMspTenantsIdSubscriptionPostRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = apiIntegrationsMspTenantsIdSubscriptionPostRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<object>("integrations/msp/tenants/{id}/subscription", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsMspTenantsIdSubscriptionPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create subscription for Tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdSubscriptionPostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIntegrationsMspTenantsIdSubscriptionPostAsync(string id, ApiIntegrationsMspTenantsIdSubscriptionPostRequest apiIntegrationsMspTenantsIdSubscriptionPostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIntegrationsMspTenantsIdSubscriptionPostWithHttpInfoAsync(id, apiIntegrationsMspTenantsIdSubscriptionPostRequest, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Create subscription for Tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdSubscriptionPostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiIntegrationsMspTenantsIdSubscriptionPostWithHttpInfoAsync(string id, ApiIntegrationsMspTenantsIdSubscriptionPostRequest apiIntegrationsMspTenantsIdSubscriptionPostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdSubscriptionPost");

        ValidateParameter(apiIntegrationsMspTenantsIdSubscriptionPostRequest, "apiIntegrationsMspTenantsIdSubscriptionPostRequest", "MSPApi->ApiIntegrationsMspTenantsIdSubscriptionPost");

        RequestOptions<ApiIntegrationsMspTenantsIdSubscriptionPostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsMspTenantsIdSubscriptionPostRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = apiIntegrationsMspTenantsIdSubscriptionPostRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Object>("integrations/msp/tenants/{id}/subscription", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsMspTenantsIdSubscriptionPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Unlink a tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdUnlinkPostRequest"></param>
    /// <returns></returns>
    public void ApiIntegrationsMspTenantsIdUnlinkPost(string id, ApiIntegrationsMspTenantsIdUnlinkPostRequest apiIntegrationsMspTenantsIdUnlinkPostRequest)
    {
        ApiIntegrationsMspTenantsIdUnlinkPostWithHttpInfo(id, apiIntegrationsMspTenantsIdUnlinkPostRequest);
    }

    /// <summary>
    /// Unlink a tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdUnlinkPostRequest"></param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<Object> ApiIntegrationsMspTenantsIdUnlinkPostWithHttpInfo(string id, ApiIntegrationsMspTenantsIdUnlinkPostRequest apiIntegrationsMspTenantsIdUnlinkPostRequest)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdUnlinkPost");

        ValidateParameter(apiIntegrationsMspTenantsIdUnlinkPostRequest, "apiIntegrationsMspTenantsIdUnlinkPostRequest", "MSPApi->ApiIntegrationsMspTenantsIdUnlinkPost");

        RequestOptions<ApiIntegrationsMspTenantsIdUnlinkPostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsMspTenantsIdUnlinkPostRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = apiIntegrationsMspTenantsIdUnlinkPostRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<Object>("integrations/msp/tenants/{id}/unlink", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsMspTenantsIdUnlinkPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Unlink a tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdUnlinkPostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIntegrationsMspTenantsIdUnlinkPostAsync(string id, ApiIntegrationsMspTenantsIdUnlinkPostRequest apiIntegrationsMspTenantsIdUnlinkPostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIntegrationsMspTenantsIdUnlinkPostWithHttpInfoAsync(id, apiIntegrationsMspTenantsIdUnlinkPostRequest, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Unlink a tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of a tenant account</param>
    /// <param name="apiIntegrationsMspTenantsIdUnlinkPostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiIntegrationsMspTenantsIdUnlinkPostWithHttpInfoAsync(string id, ApiIntegrationsMspTenantsIdUnlinkPostRequest apiIntegrationsMspTenantsIdUnlinkPostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "MSPApi->ApiIntegrationsMspTenantsIdUnlinkPost");

        ValidateParameter(apiIntegrationsMspTenantsIdUnlinkPostRequest, "apiIntegrationsMspTenantsIdUnlinkPostRequest", "MSPApi->ApiIntegrationsMspTenantsIdUnlinkPost");

        RequestOptions<ApiIntegrationsMspTenantsIdUnlinkPostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsMspTenantsIdUnlinkPostRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = apiIntegrationsMspTenantsIdUnlinkPostRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Object>("integrations/msp/tenants/{id}/unlink", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsMspTenantsIdUnlinkPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create MSP tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createTenantRequest"></param>
    /// <returns>TenantResponse</returns>
    public TenantResponse ApiIntegrationsMspTenantsPost(CreateTenantRequest createTenantRequest)
    {
        ApiResponse<TenantResponse> localVarResponse = ApiIntegrationsMspTenantsPostWithHttpInfo(createTenantRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create MSP tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createTenantRequest"></param>
    /// <returns>ApiResponse of TenantResponse</returns>
    internal ApiResponse<TenantResponse> ApiIntegrationsMspTenantsPostWithHttpInfo(CreateTenantRequest createTenantRequest)
    {
        ValidateParameter(createTenantRequest, "createTenantRequest", "MSPApi->ApiIntegrationsMspTenantsPost");

        RequestOptions<CreateTenantRequest> localVarRequestOptions = new RequestOptions<CreateTenantRequest>();

        localVarRequestOptions.Data = createTenantRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<TenantResponse>("integrations/msp/tenants", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsMspTenantsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create MSP tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createTenantRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of TenantResponse</returns>
    public async System.Threading.Tasks.Task<TenantResponse> ApiIntegrationsMspTenantsPostAsync(CreateTenantRequest createTenantRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<TenantResponse> localVarResponse = await ApiIntegrationsMspTenantsPostWithHttpInfoAsync(createTenantRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create MSP tenant 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createTenantRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TenantResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<TenantResponse>> ApiIntegrationsMspTenantsPostWithHttpInfoAsync(CreateTenantRequest createTenantRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(createTenantRequest, "createTenantRequest", "MSPApi->ApiIntegrationsMspTenantsPost");

        RequestOptions<CreateTenantRequest> localVarRequestOptions = new RequestOptions<CreateTenantRequest>();

        localVarRequestOptions.Data = createTenantRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<TenantResponse>("integrations/msp/tenants", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsMspTenantsPost", localVarResponse);

        return localVarResponse;
    }

}




