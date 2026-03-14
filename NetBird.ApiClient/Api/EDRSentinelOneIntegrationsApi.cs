

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
public class EDRSentinelOneIntegrationsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EDRSentinelOneIntegrationsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal EDRSentinelOneIntegrationsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Delete EDR SentinelOne Integration Deletes an EDR SentinelOne Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Object</returns>
    public Object ApiIntegrationsEdrSentineloneDelete()
    {
        ApiResponse<object> localVarResponse = ApiIntegrationsEdrSentineloneDeleteWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete EDR SentinelOne Integration Deletes an EDR SentinelOne Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Object</returns>
    internal ApiResponse<object> ApiIntegrationsEdrSentineloneDeleteWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("integrations/edr/sentinelone", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsEdrSentineloneDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete EDR SentinelOne Integration Deletes an EDR SentinelOne Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Object</returns>
    public async System.Threading.Tasks.Task<object> ApiIntegrationsEdrSentineloneDeleteAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<object> localVarResponse = await ApiIntegrationsEdrSentineloneDeleteWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Delete EDR SentinelOne Integration Deletes an EDR SentinelOne Integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Object)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiIntegrationsEdrSentineloneDeleteWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("integrations/edr/sentinelone", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsEdrSentineloneDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get EDR SentinelOne Integration Retrieves a specific EDR SentinelOne integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>EDRSentinelOneResponse</returns>
    public EDRSentinelOneResponse ApiIntegrationsEdrSentineloneGet()
    {
        ApiResponse<EDRSentinelOneResponse> localVarResponse = ApiIntegrationsEdrSentineloneGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get EDR SentinelOne Integration Retrieves a specific EDR SentinelOne integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of EDRSentinelOneResponse</returns>
    internal ApiResponse<EDRSentinelOneResponse> ApiIntegrationsEdrSentineloneGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRSentinelOneResponse>("integrations/edr/sentinelone", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsEdrSentineloneGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get EDR SentinelOne Integration Retrieves a specific EDR SentinelOne integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRSentinelOneResponse</returns>
    public async System.Threading.Tasks.Task<EDRSentinelOneResponse> ApiIntegrationsEdrSentineloneGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRSentinelOneResponse> localVarResponse = await ApiIntegrationsEdrSentineloneGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get EDR SentinelOne Integration Retrieves a specific EDR SentinelOne integration by its ID.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRSentinelOneResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRSentinelOneResponse>> ApiIntegrationsEdrSentineloneGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRSentinelOneResponse>("integrations/edr/sentinelone", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsEdrSentineloneGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create EDR SentinelOne Integration Creates a new EDR SentinelOne integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRSentinelOneRequest"></param>
    /// <returns>EDRSentinelOneResponse</returns>
    public EDRSentinelOneResponse CreateSentinelOneEDRIntegration(EDRSentinelOneRequest eDRSentinelOneRequest)
    {
        ApiResponse<EDRSentinelOneResponse> localVarResponse = CreateSentinelOneEDRIntegrationWithHttpInfo(eDRSentinelOneRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create EDR SentinelOne Integration Creates a new EDR SentinelOne integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRSentinelOneRequest"></param>
    /// <returns>ApiResponse of EDRSentinelOneResponse</returns>
    internal ApiResponse<EDRSentinelOneResponse> CreateSentinelOneEDRIntegrationWithHttpInfo(EDRSentinelOneRequest eDRSentinelOneRequest)
    {
        ValidateParameter(eDRSentinelOneRequest, "eDRSentinelOneRequest", "EDRSentinelOneIntegrationsApi->CreateSentinelOneEDRIntegration");

        RequestOptions<EDRSentinelOneRequest> localVarRequestOptions = new RequestOptions<EDRSentinelOneRequest>();

        localVarRequestOptions.Data = eDRSentinelOneRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRSentinelOneResponse>("integrations/edr/sentinelone", localVarRequestOptions);
        this.CheckForException("CreateSentinelOneEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create EDR SentinelOne Integration Creates a new EDR SentinelOne integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRSentinelOneRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRSentinelOneResponse</returns>
    public async System.Threading.Tasks.Task<EDRSentinelOneResponse> CreateSentinelOneEDRIntegrationAsync(EDRSentinelOneRequest eDRSentinelOneRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRSentinelOneResponse> localVarResponse = await CreateSentinelOneEDRIntegrationWithHttpInfoAsync(eDRSentinelOneRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create EDR SentinelOne Integration Creates a new EDR SentinelOne integration
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRSentinelOneRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRSentinelOneResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRSentinelOneResponse>> CreateSentinelOneEDRIntegrationWithHttpInfoAsync(EDRSentinelOneRequest eDRSentinelOneRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(eDRSentinelOneRequest, "eDRSentinelOneRequest", "EDRSentinelOneIntegrationsApi->CreateSentinelOneEDRIntegration");

        RequestOptions<EDRSentinelOneRequest> localVarRequestOptions = new RequestOptions<EDRSentinelOneRequest>();

        localVarRequestOptions.Data = eDRSentinelOneRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRSentinelOneResponse>("integrations/edr/sentinelone", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("CreateSentinelOneEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update EDR SentinelOne Integration Updates an existing EDR SentinelOne Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRSentinelOneRequest"></param>
    /// <returns>EDRSentinelOneResponse</returns>
    public EDRSentinelOneResponse UpdateSentinelOneEDRIntegration(EDRSentinelOneRequest eDRSentinelOneRequest)
    {
        ApiResponse<EDRSentinelOneResponse> localVarResponse = UpdateSentinelOneEDRIntegrationWithHttpInfo(eDRSentinelOneRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update EDR SentinelOne Integration Updates an existing EDR SentinelOne Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRSentinelOneRequest"></param>
    /// <returns>ApiResponse of EDRSentinelOneResponse</returns>
    internal ApiResponse<EDRSentinelOneResponse> UpdateSentinelOneEDRIntegrationWithHttpInfo(EDRSentinelOneRequest eDRSentinelOneRequest)
    {
        ValidateParameter(eDRSentinelOneRequest, "eDRSentinelOneRequest", "EDRSentinelOneIntegrationsApi->UpdateSentinelOneEDRIntegration");

        RequestOptions<EDRSentinelOneRequest> localVarRequestOptions = new RequestOptions<EDRSentinelOneRequest>();

        localVarRequestOptions.Data = eDRSentinelOneRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Get<EDRSentinelOneResponse>("integrations/edr/sentinelone", localVarRequestOptions);
        this.CheckForException("UpdateSentinelOneEDRIntegration", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update EDR SentinelOne Integration Updates an existing EDR SentinelOne Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRSentinelOneRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of EDRSentinelOneResponse</returns>
    public async System.Threading.Tasks.Task<EDRSentinelOneResponse> UpdateSentinelOneEDRIntegrationAsync(EDRSentinelOneRequest eDRSentinelOneRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<EDRSentinelOneResponse> localVarResponse = await UpdateSentinelOneEDRIntegrationWithHttpInfoAsync(eDRSentinelOneRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update EDR SentinelOne Integration Updates an existing EDR SentinelOne Integration.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="eDRSentinelOneRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (EDRSentinelOneResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<EDRSentinelOneResponse>> UpdateSentinelOneEDRIntegrationWithHttpInfoAsync(EDRSentinelOneRequest eDRSentinelOneRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(eDRSentinelOneRequest, "eDRSentinelOneRequest", "EDRSentinelOneIntegrationsApi->UpdateSentinelOneEDRIntegration");

        RequestOptions<EDRSentinelOneRequest> localVarRequestOptions = new RequestOptions<EDRSentinelOneRequest>();

        localVarRequestOptions.Data = eDRSentinelOneRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<EDRSentinelOneResponse>("integrations/edr/sentinelone", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("UpdateSentinelOneEDRIntegration", localVarResponse);

        return localVarResponse;
    }

}




