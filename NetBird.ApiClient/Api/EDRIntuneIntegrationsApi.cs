

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
public class EDRIntuneIntegrationsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EDRIntuneIntegrationsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal EDRIntuneIntegrationsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Create EDR Intune Integration Creates a new EDR Intune integration for the authenticated account. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRIntuneRequest"></param>
    /// <returns>EDRIntuneResponse</returns>
    public EDRIntuneResponse CreateEDRIntegration(EDRIntuneRequest eDRIntuneRequest)
    {
        ApiResponse<EDRIntuneResponse> localVarResponse = CreateEDRIntegrationWithHttpInfo(eDRIntuneRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create EDR Intune Integration Creates a new EDR Intune integration for the authenticated account. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRIntuneRequest"></param>
    /// <returns>ApiResponse of EDRIntuneResponse</returns>
    internal ApiResponse<EDRIntuneResponse> CreateEDRIntegrationWithHttpInfo(EDRIntuneRequest eDRIntuneRequest)
    {
        ValidateParameter(eDRIntuneRequest, "eDRIntuneRequest", "EDRIntuneIntegrationsApi->CreateEDRIntegration");

        RequestOptions<EDRIntuneRequest> localVarRequestOptions = new RequestOptions<EDRIntuneRequest>();

        localVarRequestOptions.Data = eDRIntuneRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRIntuneResponse>("integrations/edr/intune", localVarRequestOptions);
        this.CheckForException("CreateEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create EDR Intune Integration Creates a new EDR Intune integration for the authenticated account. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRIntuneRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRIntuneResponse</returns>
    public async System.Threading.Tasks.Task<EDRIntuneResponse> CreateEDRIntegrationAsync(EDRIntuneRequest eDRIntuneRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRIntuneResponse> localVarResponse = await CreateEDRIntegrationWithHttpInfoAsync(eDRIntuneRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create EDR Intune Integration Creates a new EDR Intune integration for the authenticated account. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRIntuneRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRIntuneResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRIntuneResponse>> CreateEDRIntegrationWithHttpInfoAsync(EDRIntuneRequest eDRIntuneRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(eDRIntuneRequest, "eDRIntuneRequest", "EDRIntuneIntegrationsApi->CreateEDRIntegration");

        RequestOptions<EDRIntuneRequest> localVarRequestOptions = new RequestOptions<EDRIntuneRequest>();

        localVarRequestOptions.Data = eDRIntuneRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRIntuneResponse>("integrations/edr/intune", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("CreateEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete EDR Intune Integration Deletes an EDR Intune Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>
    public Object DeleteIntegration()
    {
        ApiResponse<object> localVarResponse = DeleteIntegrationWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete EDR Intune Integration Deletes an EDR Intune Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>
    internal ApiResponse<object> DeleteIntegrationWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("integrations/edr/intune", localVarRequestOptions);
        this.CheckForException("DeleteIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete EDR Intune Integration Deletes an EDR Intune Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async System.Threading.Tasks.Task<object> DeleteIntegrationAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<object> localVarResponse = await DeleteIntegrationWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete EDR Intune Integration Deletes an EDR Intune Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Object)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> DeleteIntegrationWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("integrations/edr/intune", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("DeleteIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get EDR Intune Integration Retrieves a specific EDR Intune integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>EDRIntuneResponse</returns>
    public EDRIntuneResponse GetEDRIntegration()
    {
        ApiResponse<EDRIntuneResponse> localVarResponse = GetEDRIntegrationWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get EDR Intune Integration Retrieves a specific EDR Intune integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of EDRIntuneResponse</returns>
    internal ApiResponse<EDRIntuneResponse> GetEDRIntegrationWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRIntuneResponse>("integrations/edr/intune", localVarRequestOptions);
        this.CheckForException("GetEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get EDR Intune Integration Retrieves a specific EDR Intune integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRIntuneResponse</returns>
    public async System.Threading.Tasks.Task<EDRIntuneResponse> GetEDRIntegrationAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRIntuneResponse> localVarResponse = await GetEDRIntegrationWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get EDR Intune Integration Retrieves a specific EDR Intune integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRIntuneResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRIntuneResponse>> GetEDRIntegrationWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRIntuneResponse>("integrations/edr/intune", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("GetEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update EDR Intune Integration Updates an existing EDR Intune Integration. The request body structure is &#x60;EDRIntuneRequest&#x60;. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRIntuneRequest"></param>
    /// <returns>EDRIntuneResponse</returns>
    public EDRIntuneResponse UpdateEDRIntegration(EDRIntuneRequest eDRIntuneRequest)
    {
        ApiResponse<EDRIntuneResponse> localVarResponse = UpdateEDRIntegrationWithHttpInfo(eDRIntuneRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update EDR Intune Integration Updates an existing EDR Intune Integration. The request body structure is &#x60;EDRIntuneRequest&#x60;. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRIntuneRequest"></param>
    /// <returns>ApiResponse of EDRIntuneResponse</returns>
    internal ApiResponse<EDRIntuneResponse> UpdateEDRIntegrationWithHttpInfo(EDRIntuneRequest eDRIntuneRequest)
    {
        ValidateParameter(eDRIntuneRequest, "eDRIntuneRequest", "EDRIntuneIntegrationsApi->UpdateEDRIntegration");

        RequestOptions<EDRIntuneRequest> localVarRequestOptions = new RequestOptions<EDRIntuneRequest>();

        localVarRequestOptions.Data = eDRIntuneRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRIntuneResponse>("integrations/edr/intune", localVarRequestOptions);
        this.CheckForException("UpdateEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update EDR Intune Integration Updates an existing EDR Intune Integration. The request body structure is &#x60;EDRIntuneRequest&#x60;. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRIntuneRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRIntuneResponse</returns>
    public async System.Threading.Tasks.Task<EDRIntuneResponse> UpdateEDRIntegrationAsync(EDRIntuneRequest eDRIntuneRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRIntuneResponse> localVarResponse = await UpdateEDRIntegrationWithHttpInfoAsync(eDRIntuneRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update EDR Intune Integration Updates an existing EDR Intune Integration. The request body structure is &#x60;EDRIntuneRequest&#x60;. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRIntuneRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRIntuneResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRIntuneResponse>> UpdateEDRIntegrationWithHttpInfoAsync(EDRIntuneRequest eDRIntuneRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(eDRIntuneRequest, "eDRIntuneRequest", "EDRIntuneIntegrationsApi->UpdateEDRIntegration");

        RequestOptions<EDRIntuneRequest> localVarRequestOptions = new RequestOptions<EDRIntuneRequest>();

        localVarRequestOptions.Data = eDRIntuneRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRIntuneResponse>("integrations/edr/intune", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("UpdateEDRIntegration", localVarResponse);

        return localVarResponse;
    }

}




