

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
public class InvoiceApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal InvoiceApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Get account&#39;s paid invoices 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;InvoiceResponse&gt;</returns>
    public List<InvoiceResponse> ApiIntegrationsBillingInvoicesGet()
    {
        ApiResponse<List<InvoiceResponse>> localVarResponse = ApiIntegrationsBillingInvoicesGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get account&#39;s paid invoices 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;InvoiceResponse&gt;</returns>
    public ApiResponse<List<InvoiceResponse>> ApiIntegrationsBillingInvoicesGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<InvoiceResponse>>("integrations/billing/invoices", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingInvoicesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get account&#39;s paid invoices 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;InvoiceResponse&gt;</returns>
    public async System.Threading.Tasks.Task<List<InvoiceResponse>> ApiIntegrationsBillingInvoicesGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<InvoiceResponse>> localVarResponse = await ApiIntegrationsBillingInvoicesGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get account&#39;s paid invoices 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;InvoiceResponse&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<InvoiceResponse>>> ApiIntegrationsBillingInvoicesGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<InvoiceResponse>>("integrations/billing/invoices", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingInvoicesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get account invoice CSV. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the invoice</param>
    /// <returns>string</returns>
    public string ApiIntegrationsBillingInvoicesIdCsvGet(string id)
    {
        ApiResponse<string> localVarResponse = ApiIntegrationsBillingInvoicesIdCsvGetWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get account invoice CSV. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the invoice</param>
    /// <returns>ApiResponse of string</returns>
    internal ApiResponse<string> ApiIntegrationsBillingInvoicesIdCsvGetWithHttpInfo(string id)
    {
        ValidateParameter(id, "id", "InvoiceApi->ApiIntegrationsBillingInvoicesIdCsvGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<string>("integrations/billing/invoices/{id}/csv", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingInvoicesIdCsvGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get account invoice CSV. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the invoice</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of string</returns>
    public async System.Threading.Tasks.Task<string> ApiIntegrationsBillingInvoicesIdCsvGetAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<string> localVarResponse = await ApiIntegrationsBillingInvoicesIdCsvGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get account invoice CSV. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the invoice</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (string)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<string>> ApiIntegrationsBillingInvoicesIdCsvGetWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "InvoiceApi->ApiIntegrationsBillingInvoicesIdCsvGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<string>("integrations/billing/invoices/{id}/csv", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingInvoicesIdCsvGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get account invoice URL to Stripe. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the invoice</param>
    /// <returns>InvoicePDFResponse</returns>
    public InvoicePDFResponse ApiIntegrationsBillingInvoicesIdPdfGet(string id)
    {
        ApiResponse<InvoicePDFResponse> localVarResponse = ApiIntegrationsBillingInvoicesIdPdfGetWithHttpInfo(id);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get account invoice URL to Stripe. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the invoice</param>
    /// <returns>ApiResponse of InvoicePDFResponse</returns>
    internal ApiResponse<InvoicePDFResponse> ApiIntegrationsBillingInvoicesIdPdfGetWithHttpInfo(string id)
    {
        ValidateParameter(id, "id", "InvoiceApi->ApiIntegrationsBillingInvoicesIdPdfGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<InvoicePDFResponse>("integrations/billing/invoices/{id}/pdf", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingInvoicesIdPdfGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get account invoice URL to Stripe. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the invoice</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of InvoicePDFResponse</returns>
    public async System.Threading.Tasks.Task<InvoicePDFResponse> ApiIntegrationsBillingInvoicesIdPdfGetAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<InvoicePDFResponse> localVarResponse = await ApiIntegrationsBillingInvoicesIdPdfGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get account invoice URL to Stripe. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">The unique identifier of the invoice</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (InvoicePDFResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<InvoicePDFResponse>> ApiIntegrationsBillingInvoicesIdPdfGetWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(id, "id", "InvoiceApi->ApiIntegrationsBillingInvoicesIdPdfGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<InvoicePDFResponse>("integrations/billing/invoices/{id}/pdf", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingInvoicesIdPdfGet", localVarResponse);

        return localVarResponse;
    }

}




