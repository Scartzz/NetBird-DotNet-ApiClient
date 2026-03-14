

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
public class PlansApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PlansApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal PlansApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Get available plans 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;Product&gt;</returns>
    public List<Product> ApiIntegrationsBillingPlansGet()
    {
        ApiResponse<List<Product>> localVarResponse = ApiIntegrationsBillingPlansGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get available plans 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;Product&gt;</returns>
    public ApiResponse<List<Product>> ApiIntegrationsBillingPlansGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Product>>("integrations/billing/plans", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingPlansGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get available plans 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Product&gt;</returns>
    public async System.Threading.Tasks.Task<List<Product>> ApiIntegrationsBillingPlansGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Product>> localVarResponse = await ApiIntegrationsBillingPlansGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get available plans 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Product&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Product>>> ApiIntegrationsBillingPlansGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Product>>("integrations/billing/plans", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingPlansGet", localVarResponse);

        return localVarResponse;
    }

}




