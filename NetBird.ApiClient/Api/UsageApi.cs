

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
public class UsageApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UsageApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal UsageApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Get current usage 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>UsageStats</returns>
    public UsageStats ApiIntegrationsBillingUsageGet()
    {
        ApiResponse<UsageStats> localVarResponse = ApiIntegrationsBillingUsageGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get current usage 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of UsageStats</returns>
    internal ApiResponse<UsageStats> ApiIntegrationsBillingUsageGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<UsageStats>("integrations/billing/usage", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingUsageGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get current usage 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of UsageStats</returns>
    public async System.Threading.Tasks.Task<UsageStats> ApiIntegrationsBillingUsageGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<UsageStats> localVarResponse = await ApiIntegrationsBillingUsageGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get current usage 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (UsageStats)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<UsageStats>> ApiIntegrationsBillingUsageGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<UsageStats>("integrations/billing/usage", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingUsageGet", localVarResponse);

        return localVarResponse;
    }

}




