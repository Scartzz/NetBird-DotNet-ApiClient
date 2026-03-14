

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
public class PortalApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PortalApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal PortalApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Get customer portal URL 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="baseURL">The base URL for the redirect after accessing the portal.</param>
    /// <returns>PortalResponse</returns>
    public PortalResponse ApiIntegrationsBillingPortalGet(string baseURL)
    {
        ApiResponse<PortalResponse> localVarResponse = ApiIntegrationsBillingPortalGetWithHttpInfo(baseURL);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get customer portal URL 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="baseURL">The base URL for the redirect after accessing the portal.</param>
    /// <returns>ApiResponse of PortalResponse</returns>
    internal ApiResponse<PortalResponse> ApiIntegrationsBillingPortalGetWithHttpInfo(string baseURL)
    {
        ValidateParameter(baseURL, "baseURL", "PortalApi->ApiIntegrationsBillingPortalGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "baseURL", baseURL));

        // make the HTTP request
        var localVarResponse = this.Client.Get<PortalResponse>("integrations/billing/portal", localVarRequestOptions);
        this.CheckForException("ApiIntegrationsBillingPortalGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get customer portal URL 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="baseURL">The base URL for the redirect after accessing the portal.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PortalResponse</returns>
    public async System.Threading.Tasks.Task<PortalResponse> ApiIntegrationsBillingPortalGetAsync(string baseURL, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<PortalResponse> localVarResponse = await ApiIntegrationsBillingPortalGetWithHttpInfoAsync(baseURL, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get customer portal URL 
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="baseURL">The base URL for the redirect after accessing the portal.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PortalResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<PortalResponse>> ApiIntegrationsBillingPortalGetWithHttpInfoAsync(string baseURL, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(baseURL, "baseURL", "PortalApi->ApiIntegrationsBillingPortalGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "baseURL", baseURL));

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<PortalResponse>("integrations/billing/portal", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiIntegrationsBillingPortalGet", localVarResponse);

        return localVarResponse;
    }

}




