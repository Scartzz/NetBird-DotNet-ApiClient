

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
public class SubscriptionApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal SubscriptionApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Get current subscription 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Subscription</returns>
    public Subscription ApiIntegrationsBillingSubscriptionGet()
    {
        ApiResponse<Subscription> localVarResponse = ApiIntegrationsBillingSubscriptionGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get current subscription 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of Subscription</returns>
    internal ApiResponse<Subscription> ApiIntegrationsBillingSubscriptionGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<Subscription>("integrations/billing/subscription", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingSubscriptionGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get current subscription 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Subscription</returns>
    public async System.Threading.Tasks.Task<Subscription> ApiIntegrationsBillingSubscriptionGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Subscription> localVarResponse = await ApiIntegrationsBillingSubscriptionGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get current subscription 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Subscription)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Subscription>> ApiIntegrationsBillingSubscriptionGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Subscription>("integrations/billing/subscription", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingSubscriptionGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Change subscription 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingSubscriptionPutRequest"></param>
    /// <returns></returns>
    public void ApiIntegrationsBillingSubscriptionPut(ApiIntegrationsBillingSubscriptionPutRequest apiIntegrationsBillingSubscriptionPutRequest)
    {
        ApiIntegrationsBillingSubscriptionPutWithHttpInfo(apiIntegrationsBillingSubscriptionPutRequest);
    }

    /// <summary>
    /// Change subscription 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingSubscriptionPutRequest"></param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIntegrationsBillingSubscriptionPutWithHttpInfo(ApiIntegrationsBillingSubscriptionPutRequest apiIntegrationsBillingSubscriptionPutRequest)
    {
        ValidateParameter(apiIntegrationsBillingSubscriptionPutRequest, "apiIntegrationsBillingSubscriptionPutRequest", "SubscriptionApi->ApiIntegrationsBillingSubscriptionPut");

        RequestOptions<ApiIntegrationsBillingSubscriptionPutRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsBillingSubscriptionPutRequest>();

        localVarRequestOptions.Data = apiIntegrationsBillingSubscriptionPutRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<object>("integrations/billing/subscription", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingSubscriptionPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Change subscription 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingSubscriptionPutRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIntegrationsBillingSubscriptionPutAsync(ApiIntegrationsBillingSubscriptionPutRequest apiIntegrationsBillingSubscriptionPutRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIntegrationsBillingSubscriptionPutWithHttpInfoAsync(apiIntegrationsBillingSubscriptionPutRequest, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Change subscription 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingSubscriptionPutRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiIntegrationsBillingSubscriptionPutWithHttpInfoAsync(ApiIntegrationsBillingSubscriptionPutRequest apiIntegrationsBillingSubscriptionPutRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(apiIntegrationsBillingSubscriptionPutRequest, "apiIntegrationsBillingSubscriptionPutRequest", "SubscriptionApi->ApiIntegrationsBillingSubscriptionPut");

        RequestOptions<ApiIntegrationsBillingSubscriptionPutRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsBillingSubscriptionPutRequest>();

        localVarRequestOptions.Data = apiIntegrationsBillingSubscriptionPutRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Object>("integrations/billing/subscription", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingSubscriptionPut", localVarResponse);

        return localVarResponse;
    }

}




