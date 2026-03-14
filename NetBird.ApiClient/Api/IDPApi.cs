

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
public class IDPApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="IDPApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal IDPApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Create SCIM IDP Integration Creates a new SCIM integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createScimIntegrationRequest"></param>
    /// <returns>ScimIntegration</returns>
    public ScimIntegration CreateSCIMIntegration(CreateScimIntegrationRequest createScimIntegrationRequest)
    {
        ApiResponse<ScimIntegration> localVarResponse = CreateSCIMIntegrationWithHttpInfo(createScimIntegrationRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create SCIM IDP Integration Creates a new SCIM integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createScimIntegrationRequest"></param>
    /// <returns>ApiResponse of ScimIntegration</returns>
    internal ApiResponse<ScimIntegration> CreateSCIMIntegrationWithHttpInfo(CreateScimIntegrationRequest createScimIntegrationRequest)
    {
        ValidateParameter(createScimIntegrationRequest, "createScimIntegrationRequest", "IDPApi->CreateSCIMIntegration");

        RequestOptions<CreateScimIntegrationRequest> localVarRequestOptions = new RequestOptions<CreateScimIntegrationRequest>();

        localVarRequestOptions.Data = createScimIntegrationRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<ScimIntegration>("integrations/scim-idp", localVarRequestOptions);
        this.CheckForException("CreateSCIMIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create SCIM IDP Integration Creates a new SCIM integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createScimIntegrationRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ScimIntegration</returns>
    public async System.Threading.Tasks.Task<ScimIntegration> CreateSCIMIntegrationAsync(CreateScimIntegrationRequest createScimIntegrationRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<ScimIntegration> localVarResponse = await CreateSCIMIntegrationWithHttpInfoAsync(createScimIntegrationRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create SCIM IDP Integration Creates a new SCIM integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="createScimIntegrationRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ScimIntegration)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<ScimIntegration>> CreateSCIMIntegrationWithHttpInfoAsync(CreateScimIntegrationRequest createScimIntegrationRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(createScimIntegrationRequest, "createScimIntegrationRequest", "IDPApi->CreateSCIMIntegration");

        RequestOptions<CreateScimIntegrationRequest> localVarRequestOptions = new RequestOptions<CreateScimIntegrationRequest>();

        localVarRequestOptions.Data = createScimIntegrationRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<ScimIntegration>("integrations/scim-idp", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("CreateSCIMIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete SCIM IDP Integration Deletes an SCIM IDP integration by ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <returns>Object</returns>
    public Object DeleteSCIMIntegration(string id)
    {
        ApiResponse<object> localVarResponse = DeleteSCIMIntegrationWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete SCIM IDP Integration Deletes an SCIM IDP integration by ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <returns>ApiResponse of Object</returns>
    internal ApiResponse<Object> DeleteSCIMIntegrationWithHttpInfo(string id)
    {
        ValidateParameter(id, "id", "IDPApi->DeleteSCIMIntegration");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<Object>("integrations/scim-idp/{id}", localVarRequestOptions);
        this.CheckForException("DeleteSCIMIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete SCIM IDP Integration Deletes an SCIM IDP integration by ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async System.Threading.Tasks.Task<Object> DeleteSCIMIntegrationAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Object> localVarResponse = await DeleteSCIMIntegrationWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete SCIM IDP Integration Deletes an SCIM IDP integration by ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Object)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSCIMIntegrationWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "IDPApi->DeleteSCIMIntegration");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("integrations/scim-idp/{id}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("DeleteSCIMIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get All SCIM IDP Integrations Retrieves all SCIM IDP integrations for the authenticated account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;ScimIntegration&gt;</returns>
    public List<ScimIntegration> GetAllSCIMIntegrations()
    {
        ApiResponse<List<ScimIntegration>> localVarResponse = GetAllSCIMIntegrationsWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get All SCIM IDP Integrations Retrieves all SCIM IDP integrations for the authenticated account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;ScimIntegration&gt;</returns>
    public ApiResponse<List<ScimIntegration>> GetAllSCIMIntegrationsWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<ScimIntegration>>("integrations/scim-idp", localVarRequestOptions);
        this.CheckForException("GetAllSCIMIntegrations", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get All SCIM IDP Integrations Retrieves all SCIM IDP integrations for the authenticated account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;ScimIntegration&gt;</returns>
    public async System.Threading.Tasks.Task<List<ScimIntegration>> GetAllSCIMIntegrationsAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<ScimIntegration>> localVarResponse = await GetAllSCIMIntegrationsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get All SCIM IDP Integrations Retrieves all SCIM IDP integrations for the authenticated account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;ScimIntegration&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<ScimIntegration>>> GetAllSCIMIntegrationsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<ScimIntegration>>("integrations/scim-idp", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("GetAllSCIMIntegrations", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get SCIM IDP Integration Retrieves an SCIM IDP integration by ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <returns>ScimIntegration</returns>
    public ScimIntegration GetSCIMIntegration(string id)
    {
        ApiResponse<ScimIntegration> localVarResponse = GetSCIMIntegrationWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get SCIM IDP Integration Retrieves an SCIM IDP integration by ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <returns>ApiResponse of ScimIntegration</returns>
    internal ApiResponse<ScimIntegration> GetSCIMIntegrationWithHttpInfo(string id)
    {
        ValidateParameter(id, "id", "IDPApi->GetSCIMIntegration");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<ScimIntegration>("integrations/scim-idp/{id}", localVarRequestOptions);
        this.CheckForException("GetSCIMIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get SCIM IDP Integration Retrieves an SCIM IDP integration by ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ScimIntegration</returns>
    public async System.Threading.Tasks.Task<ScimIntegration> GetSCIMIntegrationAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<ScimIntegration> localVarResponse = await GetSCIMIntegrationWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get SCIM IDP Integration Retrieves an SCIM IDP integration by ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ScimIntegration)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<ScimIntegration>> GetSCIMIntegrationWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "IDPApi->GetSCIMIntegration");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<ScimIntegration>("integrations/scim-idp/{id}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("GetSCIMIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get SCIM Integration Sync Logs Retrieves synchronization logs for a SCIM IDP integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <returns>List&lt;IdpIntegrationSyncLog&gt;</returns>
    public List<IdpIntegrationSyncLog> GetSCIMIntegrationLogs(string id)
    {
        ApiResponse<List<IdpIntegrationSyncLog>> localVarResponse = GetSCIMIntegrationLogsWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get SCIM Integration Sync Logs Retrieves synchronization logs for a SCIM IDP integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <returns>ApiResponse of List&lt;IdpIntegrationSyncLog&gt;</returns>
    public ApiResponse<List<IdpIntegrationSyncLog>> GetSCIMIntegrationLogsWithHttpInfo(string id)
    {
        ValidateParameter(id, "id", "IDPApi->GetSCIMIntegrationLogs");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<IdpIntegrationSyncLog>>("integrations/scim-idp/{id}/logs", localVarRequestOptions);
        this.CheckForException("GetSCIMIntegrationLogs", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get SCIM Integration Sync Logs Retrieves synchronization logs for a SCIM IDP integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;IdpIntegrationSyncLog&gt;</returns>
    public async System.Threading.Tasks.Task<List<IdpIntegrationSyncLog>> GetSCIMIntegrationLogsAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<IdpIntegrationSyncLog>> localVarResponse = await GetSCIMIntegrationLogsWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get SCIM Integration Sync Logs Retrieves synchronization logs for a SCIM IDP integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;IdpIntegrationSyncLog&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<IdpIntegrationSyncLog>>> GetSCIMIntegrationLogsWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "IDPApi->GetSCIMIntegrationLogs");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<IdpIntegrationSyncLog>>("integrations/scim-idp/{id}/logs", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("GetSCIMIntegrationLogs", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Regenerate SCIM Token Regenerates the SCIM API token for an SCIM IDP integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <returns>ScimTokenResponse</returns>
    public ScimTokenResponse RegenerateSCIMToken(string id)
    {
        ApiResponse<ScimTokenResponse> localVarResponse = RegenerateSCIMTokenWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Regenerate SCIM Token Regenerates the SCIM API token for an SCIM IDP integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <returns>ApiResponse of ScimTokenResponse</returns>
    internal ApiResponse<ScimTokenResponse> RegenerateSCIMTokenWithHttpInfo(string id)
    {
        ValidateParameter(id, "id", "IDPApi->RegenerateSCIMToken");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<ScimTokenResponse>("integrations/scim-idp/{id}/token", localVarRequestOptions);
        this.CheckForException("RegenerateSCIMToken", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Regenerate SCIM Token Regenerates the SCIM API token for an SCIM IDP integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ScimTokenResponse</returns>
    public async System.Threading.Tasks.Task<ScimTokenResponse> RegenerateSCIMTokenAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<ScimTokenResponse> localVarResponse = await RegenerateSCIMTokenWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Regenerate SCIM Token Regenerates the SCIM API token for an SCIM IDP integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ScimTokenResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<ScimTokenResponse>> RegenerateSCIMTokenWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "IDPApi->RegenerateSCIMToken");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<ScimTokenResponse>("integrations/scim-idp/{id}/token", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("RegenerateSCIMToken", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update SCIM IDP Integration Updates an existing SCIM IDP Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="updateScimIntegrationRequest"></param>
    /// <returns>ScimIntegration</returns>
    public ScimIntegration UpdateSCIMIntegration(string id, UpdateScimIntegrationRequest updateScimIntegrationRequest)
    {
        ApiResponse<ScimIntegration> localVarResponse = UpdateSCIMIntegrationWithHttpInfo(id, updateScimIntegrationRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update SCIM IDP Integration Updates an existing SCIM IDP Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="updateScimIntegrationRequest"></param>
    /// <returns>ApiResponse of ScimIntegration</returns>
    internal ApiResponse<ScimIntegration> UpdateSCIMIntegrationWithHttpInfo(string id, UpdateScimIntegrationRequest updateScimIntegrationRequest)
    {
        ValidateParameter(id, "id", "IDPApi->UpdateSCIMIntegration");

        ValidateParameter(updateScimIntegrationRequest, "updateScimIntegrationRequest", "IDPApi->UpdateSCIMIntegration");

        RequestOptions<UpdateScimIntegrationRequest> localVarRequestOptions = new RequestOptions<UpdateScimIntegrationRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = updateScimIntegrationRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<ScimIntegration>("integrations/scim-idp/{id}", localVarRequestOptions);
        this.CheckForException("UpdateSCIMIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update SCIM IDP Integration Updates an existing SCIM IDP Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="updateScimIntegrationRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ScimIntegration</returns>
    public async System.Threading.Tasks.Task<ScimIntegration> UpdateSCIMIntegrationAsync(string id, UpdateScimIntegrationRequest updateScimIntegrationRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<ScimIntegration> localVarResponse = await UpdateSCIMIntegrationWithHttpInfoAsync(id, updateScimIntegrationRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update SCIM IDP Integration Updates an existing SCIM IDP Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the SCIM IDP integration.</param>
    /// <param name="updateScimIntegrationRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ScimIntegration)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<ScimIntegration>> UpdateSCIMIntegrationWithHttpInfoAsync(string id, UpdateScimIntegrationRequest updateScimIntegrationRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "IDPApi->UpdateSCIMIntegration");

        ValidateParameter(updateScimIntegrationRequest, "updateScimIntegrationRequest", "IDPApi->UpdateSCIMIntegration");

        RequestOptions<UpdateScimIntegrationRequest> localVarRequestOptions = new RequestOptions<UpdateScimIntegrationRequest>();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
        localVarRequestOptions.Data = updateScimIntegrationRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<ScimIntegration>("integrations/scim-idp/{id}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("UpdateSCIMIntegration", localVarResponse);

        return localVarResponse;
    }

}




