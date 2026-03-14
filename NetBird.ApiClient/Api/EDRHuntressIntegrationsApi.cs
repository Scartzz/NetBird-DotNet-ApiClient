

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
public class EDRHuntressIntegrationsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EDRHuntressIntegrationsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal EDRHuntressIntegrationsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Delete EDR Huntress Integration Deletes an EDR Huntress Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>
    public Object ApiIntegrationsEdrHuntressDelete()
    {
        ApiResponse<object> localVarResponse = ApiIntegrationsEdrHuntressDeleteWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete EDR Huntress Integration Deletes an EDR Huntress Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>
    internal ApiResponse<Object> ApiIntegrationsEdrHuntressDeleteWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Delete<Object>("integrations/edr/huntress", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsEdrHuntressDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete EDR Huntress Integration Deletes an EDR Huntress Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async System.Threading.Tasks.Task<Object> ApiIntegrationsEdrHuntressDeleteAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Object> localVarResponse = await ApiIntegrationsEdrHuntressDeleteWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete EDR Huntress Integration Deletes an EDR Huntress Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Object)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiIntegrationsEdrHuntressDeleteWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("integrations/edr/huntress", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsEdrHuntressDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get EDR Huntress Integration Retrieves a specific EDR Huntress integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>EDRHuntressResponse</returns>
    public EDRHuntressResponse ApiIntegrationsEdrHuntressGet()
    {
        ApiResponse<EDRHuntressResponse> localVarResponse = ApiIntegrationsEdrHuntressGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get EDR Huntress Integration Retrieves a specific EDR Huntress integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of EDRHuntressResponse</returns>
    internal ApiResponse<EDRHuntressResponse> ApiIntegrationsEdrHuntressGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRHuntressResponse>("integrations/edr/huntress", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsEdrHuntressGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get EDR Huntress Integration Retrieves a specific EDR Huntress integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRHuntressResponse</returns>
    public async System.Threading.Tasks.Task<EDRHuntressResponse> ApiIntegrationsEdrHuntressGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRHuntressResponse> localVarResponse = await ApiIntegrationsEdrHuntressGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get EDR Huntress Integration Retrieves a specific EDR Huntress integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRHuntressResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRHuntressResponse>> ApiIntegrationsEdrHuntressGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRHuntressResponse>("integrations/edr/huntress", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsEdrHuntressGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create EDR Huntress Integration Creates a new EDR Huntress integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRHuntressRequest"></param>
    /// <returns>EDRHuntressResponse</returns>
    public EDRHuntressResponse CreateHuntressEDRIntegration(EDRHuntressRequest eDRHuntressRequest)
    {
        ApiResponse<EDRHuntressResponse> localVarResponse = CreateHuntressEDRIntegrationWithHttpInfo(eDRHuntressRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create EDR Huntress Integration Creates a new EDR Huntress integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRHuntressRequest"></param>
    /// <returns>ApiResponse of EDRHuntressResponse</returns>
    internal ApiResponse<EDRHuntressResponse> CreateHuntressEDRIntegrationWithHttpInfo(EDRHuntressRequest eDRHuntressRequest)
    {
        ValidateParameter(eDRHuntressRequest, "eDRHuntressRequest", "EDRHuntressIntegrationsApi->CreateHuntressEDRIntegration");

        RequestOptions<EDRHuntressRequest> localVarRequestOptions = new RequestOptions<EDRHuntressRequest>();

        localVarRequestOptions.Data = eDRHuntressRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRHuntressResponse>("integrations/edr/huntress", localVarRequestOptions);
        this.CheckForException("CreateHuntressEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create EDR Huntress Integration Creates a new EDR Huntress integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRHuntressRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRHuntressResponse</returns>
    public async System.Threading.Tasks.Task<EDRHuntressResponse> CreateHuntressEDRIntegrationAsync(EDRHuntressRequest eDRHuntressRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRHuntressResponse> localVarResponse = await CreateHuntressEDRIntegrationWithHttpInfoAsync(eDRHuntressRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create EDR Huntress Integration Creates a new EDR Huntress integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRHuntressRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRHuntressResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRHuntressResponse>> CreateHuntressEDRIntegrationWithHttpInfoAsync(EDRHuntressRequest eDRHuntressRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(eDRHuntressRequest, "eDRHuntressRequest", "EDRHuntressIntegrationsApi->CreateHuntressEDRIntegration");

        RequestOptions<EDRHuntressRequest> localVarRequestOptions = new RequestOptions<EDRHuntressRequest>();

        localVarRequestOptions.Data = eDRHuntressRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRHuntressResponse>("integrations/edr/huntress", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("CreateHuntressEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update EDR Huntress Integration Updates an existing EDR Huntress Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRHuntressRequest"></param>
    /// <returns>EDRHuntressResponse</returns>
    public EDRHuntressResponse UpdateHuntressEDRIntegration(EDRHuntressRequest eDRHuntressRequest)
    {
        ApiResponse<EDRHuntressResponse> localVarResponse = UpdateHuntressEDRIntegrationWithHttpInfo(eDRHuntressRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update EDR Huntress Integration Updates an existing EDR Huntress Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRHuntressRequest"></param>
    /// <returns>ApiResponse of EDRHuntressResponse</returns>
    internal ApiResponse<EDRHuntressResponse> UpdateHuntressEDRIntegrationWithHttpInfo(EDRHuntressRequest eDRHuntressRequest)
    {
        ValidateParameter(eDRHuntressRequest, "eDRHuntressRequest", "EDRHuntressIntegrationsApi->UpdateHuntressEDRIntegration");

        RequestOptions<EDRHuntressRequest> localVarRequestOptions = new RequestOptions<EDRHuntressRequest>();

        localVarRequestOptions.Data = eDRHuntressRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRHuntressResponse>("integrations/edr/huntress", localVarRequestOptions);
        this.CheckForException("UpdateHuntressEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update EDR Huntress Integration Updates an existing EDR Huntress Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRHuntressRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRHuntressResponse</returns>
    public async System.Threading.Tasks.Task<EDRHuntressResponse> UpdateHuntressEDRIntegrationAsync(EDRHuntressRequest eDRHuntressRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRHuntressResponse> localVarResponse = await UpdateHuntressEDRIntegrationWithHttpInfoAsync(eDRHuntressRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update EDR Huntress Integration Updates an existing EDR Huntress Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRHuntressRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRHuntressResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRHuntressResponse>> UpdateHuntressEDRIntegrationWithHttpInfoAsync(EDRHuntressRequest eDRHuntressRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(eDRHuntressRequest, "eDRHuntressRequest", "EDRHuntressIntegrationsApi->UpdateHuntressEDRIntegration");

        RequestOptions<EDRHuntressRequest> localVarRequestOptions = new RequestOptions<EDRHuntressRequest>();

        localVarRequestOptions.Data = eDRHuntressRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRHuntressResponse>("integrations/edr/huntress", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("UpdateHuntressEDRIntegration", localVarResponse);

        return localVarResponse;
    }

}




