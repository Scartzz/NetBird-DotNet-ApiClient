

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
public class EDRFalconIntegrationsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EDRFalconIntegrationsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal EDRFalconIntegrationsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Delete EDR Falcon Integration Deletes an existing EDR Falcon Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns></returns>
    public void ApiIntegrationsEdrFalconDelete()
    {
        ApiIntegrationsEdrFalconDeleteWithHttpInfo();
    }

    /// <summary>
    /// Delete EDR Falcon Integration Deletes an existing EDR Falcon Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIntegrationsEdrFalconDeleteWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("integrations/edr/falcon", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsEdrFalconDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete EDR Falcon Integration Deletes an existing EDR Falcon Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIntegrationsEdrFalconDeleteAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIntegrationsEdrFalconDeleteWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete EDR Falcon Integration Deletes an existing EDR Falcon Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiIntegrationsEdrFalconDeleteWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("integrations/edr/falcon", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsEdrFalconDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get EDR Falcon Integration Retrieves a specific EDR Falcon integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>EDRFalconResponse</returns>
    public EDRFalconResponse ApiIntegrationsEdrFalconGet()
    {
        ApiResponse<EDRFalconResponse> localVarResponse = ApiIntegrationsEdrFalconGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get EDR Falcon Integration Retrieves a specific EDR Falcon integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of EDRFalconResponse</returns>
    internal ApiResponse<EDRFalconResponse> ApiIntegrationsEdrFalconGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRFalconResponse>("integrations/edr/falcon", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsEdrFalconGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get EDR Falcon Integration Retrieves a specific EDR Falcon integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRFalconResponse</returns>
    public async System.Threading.Tasks.Task<EDRFalconResponse> ApiIntegrationsEdrFalconGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRFalconResponse> localVarResponse = await ApiIntegrationsEdrFalconGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get EDR Falcon Integration Retrieves a specific EDR Falcon integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRFalconResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRFalconResponse>> ApiIntegrationsEdrFalconGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRFalconResponse>("integrations/edr/falcon", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsEdrFalconGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create EDR Falcon Integration Creates a new EDR Falcon integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRFalconRequest"></param>
    /// <returns>EDRFalconResponse</returns>
    public EDRFalconResponse CreateFalconEDRIntegration(EDRFalconRequest eDRFalconRequest)
    {
        ApiResponse<EDRFalconResponse> localVarResponse = CreateFalconEDRIntegrationWithHttpInfo(eDRFalconRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create EDR Falcon Integration Creates a new EDR Falcon integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRFalconRequest"></param>
    /// <returns>ApiResponse of EDRFalconResponse</returns>
    internal ApiResponse<EDRFalconResponse> CreateFalconEDRIntegrationWithHttpInfo(EDRFalconRequest eDRFalconRequest)
    {
        ValidateParameter(eDRFalconRequest, "eDRFalconRequest", "EDRFalconIntegrationsApi->CreateFalconEDRIntegration");

        RequestOptions<EDRFalconRequest> localVarRequestOptions = new RequestOptions<EDRFalconRequest>();

        localVarRequestOptions.Data = eDRFalconRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRFalconResponse>("integrations/edr/falcon", localVarRequestOptions);
        this.CheckForException("CreateFalconEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create EDR Falcon Integration Creates a new EDR Falcon integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRFalconRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRFalconResponse</returns>
    public async System.Threading.Tasks.Task<EDRFalconResponse> CreateFalconEDRIntegrationAsync(EDRFalconRequest eDRFalconRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRFalconResponse> localVarResponse = await CreateFalconEDRIntegrationWithHttpInfoAsync(eDRFalconRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create EDR Falcon Integration Creates a new EDR Falcon integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRFalconRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRFalconResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRFalconResponse>> CreateFalconEDRIntegrationWithHttpInfoAsync(EDRFalconRequest eDRFalconRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(eDRFalconRequest, "eDRFalconRequest", "EDRFalconIntegrationsApi->CreateFalconEDRIntegration");

        RequestOptions<EDRFalconRequest> localVarRequestOptions = new RequestOptions<EDRFalconRequest>();

        localVarRequestOptions.Data = eDRFalconRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRFalconResponse>("integrations/edr/falcon", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("CreateFalconEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update EDR Falcon Integration Updates an existing EDR Falcon Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRFalconRequest"></param>
    /// <returns>EDRFalconResponse</returns>
    public EDRFalconResponse UpdateFalconEDRIntegration(EDRFalconRequest eDRFalconRequest)
    {
        ApiResponse<EDRFalconResponse> localVarResponse = UpdateFalconEDRIntegrationWithHttpInfo(eDRFalconRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update EDR Falcon Integration Updates an existing EDR Falcon Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRFalconRequest"></param>
    /// <returns>ApiResponse of EDRFalconResponse</returns>
    internal ApiResponse<EDRFalconResponse> UpdateFalconEDRIntegrationWithHttpInfo(EDRFalconRequest eDRFalconRequest)
    {
        ValidateParameter(eDRFalconRequest, "eDRFalconRequest", "EDRFalconIntegrationsApi->UpdateFalconEDRIntegration");

        RequestOptions<EDRFalconRequest> localVarRequestOptions = new RequestOptions<EDRFalconRequest>();

        localVarRequestOptions.Data = eDRFalconRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRFalconResponse>("integrations/edr/falcon", localVarRequestOptions);
        this.CheckForException("UpdateFalconEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update EDR Falcon Integration Updates an existing EDR Falcon Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRFalconRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRFalconResponse</returns>
    public async System.Threading.Tasks.Task<EDRFalconResponse> UpdateFalconEDRIntegrationAsync(EDRFalconRequest eDRFalconRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRFalconResponse> localVarResponse = await UpdateFalconEDRIntegrationWithHttpInfoAsync(eDRFalconRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update EDR Falcon Integration Updates an existing EDR Falcon Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRFalconRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRFalconResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRFalconResponse>> UpdateFalconEDRIntegrationWithHttpInfoAsync(EDRFalconRequest eDRFalconRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(eDRFalconRequest, "eDRFalconRequest", "EDRFalconIntegrationsApi->UpdateFalconEDRIntegration");

        RequestOptions<EDRFalconRequest> localVarRequestOptions = new RequestOptions<EDRFalconRequest>();

        localVarRequestOptions.Data = eDRFalconRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRFalconResponse>("integrations/edr/falcon", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("UpdateFalconEDRIntegration", localVarResponse);

        return localVarResponse;
    }

}




