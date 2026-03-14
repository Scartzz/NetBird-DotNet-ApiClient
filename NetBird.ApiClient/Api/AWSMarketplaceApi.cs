

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
public class AWSMarketplaceApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AWSMarketplaceApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal AWSMarketplaceApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Activate AWS Marketplace subscription. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingAwsMarketplaceActivatePostRequest"></param>
    /// <returns></returns>
    public void ApiIntegrationsBillingAwsMarketplaceActivatePost(ApiIntegrationsBillingAwsMarketplaceActivatePostRequest apiIntegrationsBillingAwsMarketplaceActivatePostRequest)
    {
        ApiIntegrationsBillingAwsMarketplaceActivatePostWithHttpInfo(apiIntegrationsBillingAwsMarketplaceActivatePostRequest);
    }

    /// <summary>
    /// Activate AWS Marketplace subscription. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingAwsMarketplaceActivatePostRequest"></param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIntegrationsBillingAwsMarketplaceActivatePostWithHttpInfo(ApiIntegrationsBillingAwsMarketplaceActivatePostRequest apiIntegrationsBillingAwsMarketplaceActivatePostRequest)
    {
        ValidateParameter(apiIntegrationsBillingAwsMarketplaceActivatePostRequest, "apiIntegrationsBillingAwsMarketplaceActivatePostRequest", "AWSMarketplaceApi->ApiIntegrationsBillingAwsMarketplaceActivatePost");

        RequestOptions<ApiIntegrationsBillingAwsMarketplaceActivatePostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsBillingAwsMarketplaceActivatePostRequest>();

        localVarRequestOptions.Data = apiIntegrationsBillingAwsMarketplaceActivatePostRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<object>("integrations/billing/aws/marketplace/activate", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingAwsMarketplaceActivatePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Activate AWS Marketplace subscription. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingAwsMarketplaceActivatePostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIntegrationsBillingAwsMarketplaceActivatePostAsync(ApiIntegrationsBillingAwsMarketplaceActivatePostRequest apiIntegrationsBillingAwsMarketplaceActivatePostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIntegrationsBillingAwsMarketplaceActivatePostWithHttpInfoAsync(apiIntegrationsBillingAwsMarketplaceActivatePostRequest, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Activate AWS Marketplace subscription. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingAwsMarketplaceActivatePostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiIntegrationsBillingAwsMarketplaceActivatePostWithHttpInfoAsync(ApiIntegrationsBillingAwsMarketplaceActivatePostRequest apiIntegrationsBillingAwsMarketplaceActivatePostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(apiIntegrationsBillingAwsMarketplaceActivatePostRequest, "apiIntegrationsBillingAwsMarketplaceActivatePostRequest", "AWSMarketplaceApi->ApiIntegrationsBillingAwsMarketplaceActivatePost");

        RequestOptions<ApiIntegrationsBillingAwsMarketplaceActivatePostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsBillingAwsMarketplaceActivatePostRequest>();

        localVarRequestOptions.Data = apiIntegrationsBillingAwsMarketplaceActivatePostRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<object>("integrations/billing/aws/marketplace/activate", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingAwsMarketplaceActivatePost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Enrich AWS Marketplace subscription with Account ID. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingAwsMarketplaceEnrichPostRequest"></param>
    /// <returns></returns>
    public void ApiIntegrationsBillingAwsMarketplaceEnrichPost(ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest apiIntegrationsBillingAwsMarketplaceEnrichPostRequest)
    {
        ApiIntegrationsBillingAwsMarketplaceEnrichPostWithHttpInfo(apiIntegrationsBillingAwsMarketplaceEnrichPostRequest);
    }

    /// <summary>
    /// Enrich AWS Marketplace subscription with Account ID. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingAwsMarketplaceEnrichPostRequest"></param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiIntegrationsBillingAwsMarketplaceEnrichPostWithHttpInfo(ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest apiIntegrationsBillingAwsMarketplaceEnrichPostRequest)
    {
        ValidateParameter(apiIntegrationsBillingAwsMarketplaceEnrichPostRequest, "apiIntegrationsBillingAwsMarketplaceEnrichPostRequest", "AWSMarketplaceApi->ApiIntegrationsBillingAwsMarketplaceEnrichPost");

        RequestOptions<ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest>();

        localVarRequestOptions.Data = apiIntegrationsBillingAwsMarketplaceEnrichPostRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<object>("integrations/billing/aws/marketplace/enrich", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingAwsMarketplaceEnrichPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Enrich AWS Marketplace subscription with Account ID. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingAwsMarketplaceEnrichPostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiIntegrationsBillingAwsMarketplaceEnrichPostAsync(ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest apiIntegrationsBillingAwsMarketplaceEnrichPostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiIntegrationsBillingAwsMarketplaceEnrichPostWithHttpInfoAsync(apiIntegrationsBillingAwsMarketplaceEnrichPostRequest, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Enrich AWS Marketplace subscription with Account ID. 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="apiIntegrationsBillingAwsMarketplaceEnrichPostRequest"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiIntegrationsBillingAwsMarketplaceEnrichPostWithHttpInfoAsync(ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest apiIntegrationsBillingAwsMarketplaceEnrichPostRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(apiIntegrationsBillingAwsMarketplaceEnrichPostRequest, "apiIntegrationsBillingAwsMarketplaceEnrichPostRequest", "AWSMarketplaceApi->ApiIntegrationsBillingAwsMarketplaceEnrichPost");

        RequestOptions<ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest> localVarRequestOptions = new RequestOptions<ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest>();

        localVarRequestOptions.Data = apiIntegrationsBillingAwsMarketplaceEnrichPostRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<object>("integrations/billing/aws/marketplace/enrich", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingAwsMarketplaceEnrichPost", localVarResponse);

        return localVarResponse;
    }

}



