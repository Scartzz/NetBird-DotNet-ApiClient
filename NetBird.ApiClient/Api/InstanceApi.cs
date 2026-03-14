

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
public class InstanceApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal InstanceApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Get Instance Status Returns the instance status including whether initial setup is required. This endpoint does not require authentication.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>InstanceStatus</returns>
    public InstanceStatus ApiInstanceGet()
    {
        ApiResponse<InstanceStatus> localVarResponse = ApiInstanceGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Instance Status Returns the instance status including whether initial setup is required. This endpoint does not require authentication.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of InstanceStatus</returns>
    internal ApiResponse<InstanceStatus> ApiInstanceGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<InstanceStatus>("instance", localVarRequestOptions);
        this.CheckForException("ApiInstanceGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get Instance Status Returns the instance status including whether initial setup is required. This endpoint does not require authentication.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of InstanceStatus</returns>
    public async System.Threading.Tasks.Task<InstanceStatus> ApiInstanceGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<InstanceStatus> localVarResponse = await ApiInstanceGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Instance Status Returns the instance status including whether initial setup is required. This endpoint does not require authentication.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (InstanceStatus)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<InstanceStatus>> ApiInstanceGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<InstanceStatus>("instance", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiInstanceGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get Version Info Returns version information for NetBird components including the current management server version and latest available versions from GitHub.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>InstanceVersionInfo</returns>
    public InstanceVersionInfo ApiInstanceVersionGet()
    {
        ApiResponse<InstanceVersionInfo> localVarResponse = ApiInstanceVersionGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Version Info Returns version information for NetBird components including the current management server version and latest available versions from GitHub.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of InstanceVersionInfo</returns>
    internal ApiResponse<InstanceVersionInfo> ApiInstanceVersionGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<InstanceVersionInfo>("instance/version", localVarRequestOptions);
        this.CheckForException("ApiInstanceVersionGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Get Version Info Returns version information for NetBird components including the current management server version and latest available versions from GitHub.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of InstanceVersionInfo</returns>
    public async System.Threading.Tasks.Task<InstanceVersionInfo> ApiInstanceVersionGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<InstanceVersionInfo> localVarResponse = await ApiInstanceVersionGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get Version Info Returns version information for NetBird components including the current management server version and latest available versions from GitHub.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (InstanceVersionInfo)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<InstanceVersionInfo>> ApiInstanceVersionGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<InstanceVersionInfo>("instance/version", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiInstanceVersionGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Setup Instance Creates the initial admin user for the instance. This endpoint does not require authentication but only works when setup is required (no accounts exist and embedded IDP is enabled).
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="setupRequest">Initial admin user details</param>
    /// <returns>SetupResponse</returns>
    public SetupResponse ApiSetupPost(SetupRequest setupRequest)
    {
        ApiResponse<SetupResponse> localVarResponse = ApiSetupPostWithHttpInfo(setupRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Setup Instance Creates the initial admin user for the instance. This endpoint does not require authentication but only works when setup is required (no accounts exist and embedded IDP is enabled).
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="setupRequest">Initial admin user details</param>
    /// <returns>ApiResponse of SetupResponse</returns>
    internal ApiResponse<SetupResponse> ApiSetupPostWithHttpInfo(SetupRequest setupRequest)
    {
        ValidateParameter(setupRequest, "setupRequest", "InstanceApi->ApiSetupPost");

        RequestOptions<SetupRequest> localVarRequestOptions = new RequestOptions<SetupRequest>();

        localVarRequestOptions.Data = setupRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<SetupResponse>("setup", localVarRequestOptions);
        this.CheckForException("ApiSetupPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Setup Instance Creates the initial admin user for the instance. This endpoint does not require authentication but only works when setup is required (no accounts exist and embedded IDP is enabled).
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="setupRequest">Initial admin user details</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of SetupResponse</returns>
    public async System.Threading.Tasks.Task<SetupResponse> ApiSetupPostAsync(SetupRequest setupRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<SetupResponse> localVarResponse = await ApiSetupPostWithHttpInfoAsync(setupRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Setup Instance Creates the initial admin user for the instance. This endpoint does not require authentication but only works when setup is required (no accounts exist and embedded IDP is enabled).
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="setupRequest">Initial admin user details</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (SetupResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<SetupResponse>> ApiSetupPostWithHttpInfoAsync(SetupRequest setupRequest, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(setupRequest, "setupRequest", "InstanceApi->ApiSetupPost");

        RequestOptions<SetupRequest> localVarRequestOptions = new RequestOptions<SetupRequest>();

        localVarRequestOptions.Data = setupRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<SetupResponse>("setup", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiSetupPost", localVarResponse);

        return localVarResponse;
    }

}




