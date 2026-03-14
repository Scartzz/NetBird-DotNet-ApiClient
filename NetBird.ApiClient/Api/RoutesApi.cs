

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
public class RoutesApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RoutesApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal RoutesApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Routes Returns a list of all routes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;Route&gt;</returns>
    public List<Route> ApiRoutesGet()
    {
        ApiResponse<List<Route>> localVarResponse = ApiRoutesGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Routes Returns a list of all routes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;Route&gt;</returns>
    public ApiResponse<List<Route>> ApiRoutesGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Route>>("routes", localVarRequestOptions);
        this.CheckForException("ApiRoutesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Routes Returns a list of all routes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Route&gt;</returns>
    public async System.Threading.Tasks.Task<List<Route>> ApiRoutesGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Route>> localVarResponse = await ApiRoutesGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Routes Returns a list of all routes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Route&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Route>>> ApiRoutesGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Route>>("routes", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiRoutesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Route Creates a Route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeRequest">New Routes request (optional)</param>
    /// <returns>Route</returns>
    public Route ApiRoutesPost(RouteRequest? routeRequest = null)
    {
        ApiResponse<Route> localVarResponse = ApiRoutesPostWithHttpInfo(routeRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Route Creates a Route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeRequest">New Routes request (optional)</param>
    /// <returns>ApiResponse of Route</returns>
    internal ApiResponse<Route> ApiRoutesPostWithHttpInfo(RouteRequest? routeRequest = null)
    {
        RequestOptions<RouteRequest> localVarRequestOptions = new RequestOptions<RouteRequest>();

        localVarRequestOptions.Data = routeRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<Route>("routes", localVarRequestOptions);
        this.CheckForException("ApiRoutesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a Route Creates a Route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeRequest">New Routes request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Route</returns>
    public async System.Threading.Tasks.Task<Route> ApiRoutesPostAsync(RouteRequest? routeRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Route> localVarResponse = await ApiRoutesPostWithHttpInfoAsync(routeRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a Route Creates a Route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeRequest">New Routes request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Route)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Route>> ApiRoutesPostWithHttpInfoAsync(RouteRequest? routeRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<RouteRequest> localVarRequestOptions = new RequestOptions<RouteRequest>();

        localVarRequestOptions.Data = routeRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Route>("routes", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiRoutesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Route Delete a route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <returns></returns>
    public void ApiRoutesRouteIdDelete(string routeId)
    {
        ApiRoutesRouteIdDeleteWithHttpInfo(routeId);
    }

    /// <summary>
    /// Delete a Route Delete a route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiRoutesRouteIdDeleteWithHttpInfo(string routeId)
    {
        ValidateParameter(routeId, "routeId", "RoutesApi->ApiRoutesRouteIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("routeId", ClientUtils.ParameterToString(routeId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("routes/{routeId}", localVarRequestOptions);
        this.CheckForException("ApiRoutesRouteIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a Route Delete a route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiRoutesRouteIdDeleteAsync(string routeId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiRoutesRouteIdDeleteWithHttpInfoAsync(routeId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a Route Delete a route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiRoutesRouteIdDeleteWithHttpInfoAsync(string routeId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(routeId, "routeId", "RoutesApi->ApiRoutesRouteIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("routeId", ClientUtils.ParameterToString(routeId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("routes/{routeId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiRoutesRouteIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Route Get information about a Routes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <returns>Route</returns>
    public Route ApiRoutesRouteIdGet(string routeId)
    {
        ApiResponse<Route> localVarResponse = ApiRoutesRouteIdGetWithHttpInfo(routeId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Route Get information about a Routes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <returns>ApiResponse of Route</returns>
    internal ApiResponse<Route> ApiRoutesRouteIdGetWithHttpInfo(string routeId)
    {
        ValidateParameter(routeId, "routeId", "RoutesApi->ApiRoutesRouteIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("routeId", ClientUtils.ParameterToString(routeId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<Route>("routes/{routeId}", localVarRequestOptions);
        this.CheckForException("ApiRoutesRouteIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a Route Get information about a Routes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Route</returns>
    public async System.Threading.Tasks.Task<Route> ApiRoutesRouteIdGetAsync(string routeId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Route> localVarResponse = await ApiRoutesRouteIdGetWithHttpInfoAsync(routeId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a Route Get information about a Routes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Route)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Route>> ApiRoutesRouteIdGetWithHttpInfoAsync(string routeId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(routeId, "routeId", "RoutesApi->ApiRoutesRouteIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("routeId", ClientUtils.ParameterToString(routeId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Route>("routes/{routeId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiRoutesRouteIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Route Update/Replace a Route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <param name="routeRequest">Update Route request (optional)</param>
    /// <returns>Route</returns>
    public Route ApiRoutesRouteIdPut(string routeId, RouteRequest? routeRequest = null)
    {
        ApiResponse<Route> localVarResponse = ApiRoutesRouteIdPutWithHttpInfo(routeId, routeRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Route Update/Replace a Route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <param name="routeRequest">Update Route request (optional)</param>
    /// <returns>ApiResponse of Route</returns>
    internal ApiResponse<Route> ApiRoutesRouteIdPutWithHttpInfo(string routeId, RouteRequest? routeRequest = null)
    {
        ValidateParameter(routeId, "routeId", "RoutesApi->ApiRoutesRouteIdPut");

        RequestOptions<RouteRequest> localVarRequestOptions = new RequestOptions<RouteRequest>();

        localVarRequestOptions.PathParameters.Add("routeId", ClientUtils.ParameterToString(routeId)); // path parameter
        localVarRequestOptions.Data = routeRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Route>("routes/{routeId}", localVarRequestOptions);
        this.CheckForException("ApiRoutesRouteIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a Route Update/Replace a Route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <param name="routeRequest">Update Route request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Route</returns>
    public async System.Threading.Tasks.Task<Route> ApiRoutesRouteIdPutAsync(string routeId, RouteRequest? routeRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Route> localVarResponse = await ApiRoutesRouteIdPutWithHttpInfoAsync(routeId, routeRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a Route Update/Replace a Route
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="routeId">The unique identifier of a route</param>
    /// <param name="routeRequest">Update Route request (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Route)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Route>> ApiRoutesRouteIdPutWithHttpInfoAsync(string routeId, RouteRequest? routeRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(routeId, "routeId", "RoutesApi->ApiRoutesRouteIdPut");

        RequestOptions<RouteRequest> localVarRequestOptions = new RequestOptions<RouteRequest>();

        localVarRequestOptions.PathParameters.Add("routeId", ClientUtils.ParameterToString(routeId)); // path parameter
        localVarRequestOptions.Data = routeRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Route>("routes/{routeId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiRoutesRouteIdPut", localVarResponse);

        return localVarResponse;
    }

}




