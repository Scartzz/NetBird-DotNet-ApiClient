

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
public class EventStreamingIntegrationsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EventStreamingIntegrationsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal EventStreamingIntegrationsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Create Event Streaming Integration Creates a new event streaming integration for the authenticated account. The request body should conform to &#x60;CreateIntegrationRequest&#x60;. Note: Based on the provided Go code, the &#x60;enabled&#x60; field from the request is part of the &#x60;CreateIntegrationRequest&#x60; struct, but the backend &#x60;manager.CreateIntegration&#x60; function signature shown does not directly use this &#x60;enabled&#x60; field. The actual behavior for &#x60;enabled&#x60; during creation should be confirmed (e.g., it might have a server-side default or be handled by other logic). 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createIntegrationRequest"></param>
    /// <returns>IntegrationResponse</returns>
    public IntegrationResponse CreateIntegration(CreateIntegrationRequest createIntegrationRequest)
    {
        ApiResponse<IntegrationResponse> localVarResponse = CreateIntegrationWithHttpInfo(createIntegrationRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create Event Streaming Integration Creates a new event streaming integration for the authenticated account. The request body should conform to &#x60;CreateIntegrationRequest&#x60;. Note: Based on the provided Go code, the &#x60;enabled&#x60; field from the request is part of the &#x60;CreateIntegrationRequest&#x60; struct, but the backend &#x60;manager.CreateIntegration&#x60; function signature shown does not directly use this &#x60;enabled&#x60; field. The actual behavior for &#x60;enabled&#x60; during creation should be confirmed (e.g., it might have a server-side default or be handled by other logic). 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createIntegrationRequest"></param>
    /// <returns>ApiResponse of IntegrationResponse</returns>
    internal ApiResponse<IntegrationResponse> CreateIntegrationWithHttpInfo(CreateIntegrationRequest createIntegrationRequest)
    {
        ValidateParameter(createIntegrationRequest, "createIntegrationRequest", "EventStreamingIntegrationsApi->CreateIntegration");

        RequestOptions<CreateIntegrationRequest> localVarRequestOptions = new RequestOptions<CreateIntegrationRequest>();

        localVarRequestOptions.Data = createIntegrationRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<IntegrationResponse>("event-streaming", localVarRequestOptions);
        this.CheckForException("CreateIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create Event Streaming Integration Creates a new event streaming integration for the authenticated account. The request body should conform to &#x60;CreateIntegrationRequest&#x60;. Note: Based on the provided Go code, the &#x60;enabled&#x60; field from the request is part of the &#x60;CreateIntegrationRequest&#x60; struct, but the backend &#x60;manager.CreateIntegration&#x60; function signature shown does not directly use this &#x60;enabled&#x60; field. The actual behavior for &#x60;enabled&#x60; during creation should be confirmed (e.g., it might have a server-side default or be handled by other logic). 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createIntegrationRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IntegrationResponse</returns>
    public async System.Threading.Tasks.Task<IntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest createIntegrationRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IntegrationResponse> localVarResponse = await CreateIntegrationWithHttpInfoAsync(createIntegrationRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create Event Streaming Integration Creates a new event streaming integration for the authenticated account. The request body should conform to &#x60;CreateIntegrationRequest&#x60;. Note: Based on the provided Go code, the &#x60;enabled&#x60; field from the request is part of the &#x60;CreateIntegrationRequest&#x60; struct, but the backend &#x60;manager.CreateIntegration&#x60; function signature shown does not directly use this &#x60;enabled&#x60; field. The actual behavior for &#x60;enabled&#x60; during creation should be confirmed (e.g., it might have a server-side default or be handled by other logic). 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createIntegrationRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IntegrationResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IntegrationResponse>> CreateIntegrationWithHttpInfoAsync(CreateIntegrationRequest createIntegrationRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(createIntegrationRequest, "createIntegrationRequest", "EventStreamingIntegrationsApi->CreateIntegration");

        RequestOptions<CreateIntegrationRequest> localVarRequestOptions = new RequestOptions<CreateIntegrationRequest>();

        localVarRequestOptions.Data = createIntegrationRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<IntegrationResponse>("event-streaming", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("CreateIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete Event Streaming Integration Deletes an event streaming integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <returns>Object</returns>
    public Object DeleteIntegration(int id)
    {
        ApiResponse<object> localVarResponse = DeleteIntegrationWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete Event Streaming Integration Deletes an event streaming integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <returns>ApiResponse of Object</returns>
    internal ApiResponse<object> DeleteIntegrationWithHttpInfo(int id)
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("event-streaming/{id}", localVarRequestOptions);
        this.CheckForException("DeleteIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete Event Streaming Integration Deletes an event streaming integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async System.Threading.Tasks.Task<object> DeleteIntegrationAsync(int id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<object> localVarResponse = await DeleteIntegrationWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete Event Streaming Integration Deletes an event streaming integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Object)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> DeleteIntegrationWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("event-streaming/{id}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("DeleteIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List Event Streaming Integrations Retrieves all event streaming integrations for the authenticated account.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;IntegrationResponse&gt;</returns>
    public List<IntegrationResponse> GetAllIntegrations()
    {
        ApiResponse<List<IntegrationResponse>> localVarResponse = GetAllIntegrationsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List Event Streaming Integrations Retrieves all event streaming integrations for the authenticated account.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;IntegrationResponse&gt;</returns>
    public ApiResponse<List<IntegrationResponse>> GetAllIntegrationsWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<IntegrationResponse>>("event-streaming", localVarRequestOptions);
        this.CheckForException("GetAllIntegrations", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List Event Streaming Integrations Retrieves all event streaming integrations for the authenticated account.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;IntegrationResponse&gt;</returns>
    public async System.Threading.Tasks.Task<List<IntegrationResponse>> GetAllIntegrationsAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<IntegrationResponse>> localVarResponse = await GetAllIntegrationsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List Event Streaming Integrations Retrieves all event streaming integrations for the authenticated account.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;IntegrationResponse&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<IntegrationResponse>>> GetAllIntegrationsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<IntegrationResponse>>("event-streaming", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("GetAllIntegrations", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get Event Streaming Integration Retrieves a specific event streaming integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <returns>IntegrationResponse</returns>
    public IntegrationResponse GetIntegration(int id)
    {
        ApiResponse<IntegrationResponse> localVarResponse = GetIntegrationWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Event Streaming Integration Retrieves a specific event streaming integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <returns>ApiResponse of IntegrationResponse</returns>
    internal ApiResponse<IntegrationResponse> GetIntegrationWithHttpInfo(int id)
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<IntegrationResponse>("event-streaming/{id}", localVarRequestOptions);
        this.CheckForException("GetIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get Event Streaming Integration Retrieves a specific event streaming integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IntegrationResponse</returns>
    public async System.Threading.Tasks.Task<IntegrationResponse> GetIntegrationAsync(int id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IntegrationResponse> localVarResponse = await GetIntegrationWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Event Streaming Integration Retrieves a specific event streaming integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IntegrationResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IntegrationResponse>> GetIntegrationWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<IntegrationResponse>("event-streaming/{id}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("GetIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update Event Streaming Integration Updates an existing event streaming integration. The request body structure is &#x60;CreateIntegrationRequest&#x60;. However, for updates: - The &#x60;platform&#x60; field, if provided in the body, is ignored by the backend manager function, as the platform of an existing integration is typically immutable. - The &#x60;enabled&#x60; and &#x60;config&#x60; fields from the request body are used to update the integration. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <param name="createIntegrationRequest"></param>
    /// <returns>IntegrationResponse</returns>
    public IntegrationResponse UpdateIntegration(int id, CreateIntegrationRequest createIntegrationRequest)
    {
        ApiResponse<IntegrationResponse> localVarResponse = UpdateIntegrationWithHttpInfo(id, createIntegrationRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Event Streaming Integration Updates an existing event streaming integration. The request body structure is &#x60;CreateIntegrationRequest&#x60;. However, for updates: - The &#x60;platform&#x60; field, if provided in the body, is ignored by the backend manager function, as the platform of an existing integration is typically immutable. - The &#x60;enabled&#x60; and &#x60;config&#x60; fields from the request body are used to update the integration. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <param name="createIntegrationRequest"></param>
    /// <returns>ApiResponse of IntegrationResponse</returns>
    internal ApiResponse<IntegrationResponse> UpdateIntegrationWithHttpInfo(int id, CreateIntegrationRequest createIntegrationRequest)
    {
        ValidateParameter(createIntegrationRequest, "createIntegrationRequest", "EventStreamingIntegrationsApi->UpdateIntegration");

        RequestOptions<CreateIntegrationRequest> localVarRequestOptions = new RequestOptions<CreateIntegrationRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = createIntegrationRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<IntegrationResponse>("event-streaming/{id}", localVarRequestOptions);
        this.CheckForException("UpdateIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update Event Streaming Integration Updates an existing event streaming integration. The request body structure is &#x60;CreateIntegrationRequest&#x60;. However, for updates: - The &#x60;platform&#x60; field, if provided in the body, is ignored by the backend manager function, as the platform of an existing integration is typically immutable. - The &#x60;enabled&#x60; and &#x60;config&#x60; fields from the request body are used to update the integration. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <param name="createIntegrationRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of IntegrationResponse</returns>
    public async System.Threading.Tasks.Task<IntegrationResponse> UpdateIntegrationAsync(int id, CreateIntegrationRequest createIntegrationRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<IntegrationResponse> localVarResponse = await UpdateIntegrationWithHttpInfoAsync(id, createIntegrationRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update Event Streaming Integration Updates an existing event streaming integration. The request body structure is &#x60;CreateIntegrationRequest&#x60;. However, for updates: - The &#x60;platform&#x60; field, if provided in the body, is ignored by the backend manager function, as the platform of an existing integration is typically immutable. - The &#x60;enabled&#x60; and &#x60;config&#x60; fields from the request body are used to update the integration. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique numeric identifier of the event streaming integration.</param>
    /// <param name="createIntegrationRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (IntegrationResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<IntegrationResponse>> UpdateIntegrationWithHttpInfoAsync(int id, CreateIntegrationRequest createIntegrationRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(createIntegrationRequest, "createIntegrationRequest", "EventStreamingIntegrationsApi->UpdateIntegration");

        RequestOptions<CreateIntegrationRequest> localVarRequestOptions = new RequestOptions<CreateIntegrationRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = createIntegrationRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<IntegrationResponse>("event-streaming/{id}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("UpdateIntegration", localVarResponse);

        return localVarResponse;
    }

}




