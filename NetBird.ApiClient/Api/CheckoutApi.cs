

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
public class CheckoutApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CheckoutApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal CheckoutApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Create checkout session 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingCheckoutPostRequest"></param>
    /// <returns>CheckoutResponse</returns>
    public CheckoutResponse ApiIntegrationsBillingCheckoutPost(ApiIntegrationsBillingCheckoutPostRequest apiIntegrationsBillingCheckoutPostRequest)
    {
        ApiResponse<CheckoutResponse> localVarResponse = ApiIntegrationsBillingCheckoutPostWithHttpInfo(apiIntegrationsBillingCheckoutPostRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create checkout session 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingCheckoutPostRequest"></param>
    /// <returns>ApiResponse of CheckoutResponse</returns>
    internal ApiResponse<CheckoutResponse> ApiIntegrationsBillingCheckoutPostWithHttpInfo(ApiIntegrationsBillingCheckoutPostRequest apiIntegrationsBillingCheckoutPostRequest)
    {
        ValidateParameter(apiIntegrationsBillingCheckoutPostRequest, "apiIntegrationsBillingCheckoutPostRequest", "CheckoutApi->ApiIntegrationsBillingCheckoutPost");

        RequestOptions<ApiIntegrationsBillingCheckoutPostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsBillingCheckoutPostRequest>();

        localVarRequestOptions.Data = apiIntegrationsBillingCheckoutPostRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<CheckoutResponse>("integrations/billing/checkout", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingCheckoutPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create checkout session 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingCheckoutPostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of CheckoutResponse</returns>
    public async System.Threading.Tasks.Task<CheckoutResponse> ApiIntegrationsBillingCheckoutPostAsync(ApiIntegrationsBillingCheckoutPostRequest apiIntegrationsBillingCheckoutPostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<CheckoutResponse> localVarResponse = await ApiIntegrationsBillingCheckoutPostWithHttpInfoAsync(apiIntegrationsBillingCheckoutPostRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create checkout session 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingCheckoutPostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CheckoutResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<CheckoutResponse>> ApiIntegrationsBillingCheckoutPostWithHttpInfoAsync(ApiIntegrationsBillingCheckoutPostRequest apiIntegrationsBillingCheckoutPostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(apiIntegrationsBillingCheckoutPostRequest, "apiIntegrationsBillingCheckoutPostRequest", "CheckoutApi->ApiIntegrationsBillingCheckoutPost");

        RequestOptions<ApiIntegrationsBillingCheckoutPostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsBillingCheckoutPostRequest>();

        localVarRequestOptions.Data = apiIntegrationsBillingCheckoutPostRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<CheckoutResponse>("integrations/billing/checkout", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingCheckoutPost", localVarResponse);

        return localVarResponse;
    }

}



