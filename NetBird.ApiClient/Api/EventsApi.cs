

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
public class EventsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal EventsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all Audit Events Returns a list of all audit events
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;Event&gt;</returns>
    public List<Event> ApiEventsAuditGet()
    {
        ApiResponse<List<Event>> localVarResponse = ApiEventsAuditGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Audit Events Returns a list of all audit events
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;Event&gt;</returns>
    public ApiResponse<List<Event>> ApiEventsAuditGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Event>>("events/audit", localVarRequestOptions);
        this.CheckForException("ApiEventsAuditGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Audit Events Returns a list of all audit events
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Event&gt;</returns>
    public async System.Threading.Tasks.Task<List<Event>> ApiEventsAuditGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Event>> localVarResponse = await ApiEventsAuditGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Audit Events Returns a list of all audit events
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Event&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Event>>> ApiEventsAuditGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Event>>("events/audit", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiEventsAuditGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Traffic Events Returns a list of all network traffic events
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Number of items per page (optional, default to 1000)</param>
    /// <param name="userId">Filter by user ID (optional)</param>
    /// <param name="reporterId">Filter by reporter ID (optional)</param>
    /// <param name="protocol">Filter by protocol (optional)</param>
    /// <param name="type">Filter by event type (optional)</param>
    /// <param name="connectionType">Filter by connection type (optional)</param>
    /// <param name="direction">Filter by direction (optional)</param>
    /// <param name="search">Case-insensitive partial match on user email, source/destination names, and source/destination addresses (optional)</param>
    /// <param name="startDate">Start date for filtering events (ISO 8601 format, e.g., 2024-01-01T00:00:00Z). (optional)</param>
    /// <param name="endDate">End date for filtering events (ISO 8601 format, e.g., 2024-01-31T23:59:59Z). (optional)</param>
    /// <returns>NetworkTrafficEventsResponse</returns>
    public NetworkTrafficEventsResponse ApiEventsNetworkTrafficGet(int? page = null, int? pageSize = null, string? userId = null, string? reporterId = null, int? protocol = null, string? type = null, string? connectionType = null, string? direction = null, string? search = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)
    {
        ApiResponse<NetworkTrafficEventsResponse> localVarResponse = ApiEventsNetworkTrafficGetWithHttpInfo(page, pageSize, userId, reporterId, protocol, type, connectionType, direction, search, startDate, endDate);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Traffic Events Returns a list of all network traffic events
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Number of items per page (optional, default to 1000)</param>
    /// <param name="userId">Filter by user ID (optional)</param>
    /// <param name="reporterId">Filter by reporter ID (optional)</param>
    /// <param name="protocol">Filter by protocol (optional)</param>
    /// <param name="type">Filter by event type (optional)</param>
    /// <param name="connectionType">Filter by connection type (optional)</param>
    /// <param name="direction">Filter by direction (optional)</param>
    /// <param name="search">Case-insensitive partial match on user email, source/destination names, and source/destination addresses (optional)</param>
    /// <param name="startDate">Start date for filtering events (ISO 8601 format, e.g., 2024-01-01T00:00:00Z). (optional)</param>
    /// <param name="endDate">End date for filtering events (ISO 8601 format, e.g., 2024-01-31T23:59:59Z). (optional)</param>
    /// <returns>ApiResponse of NetworkTrafficEventsResponse</returns>
    internal ApiResponse<NetworkTrafficEventsResponse> ApiEventsNetworkTrafficGetWithHttpInfo(int? page = null, int? pageSize = null, string? userId = null, string? reporterId = null, int? protocol = null, string? type = null, string? connectionType = null, string? direction = null, string? search = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        if (page is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page", page));
        }
        if (pageSize is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
        }
        if (userId is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_id", userId));
        }
        if (reporterId is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "reporter_id", reporterId));
        }
        if (protocol is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "protocol", protocol));
        }
        if (type is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "type", type));
        }
        if (connectionType is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "connection_type", connectionType));
        }
        if (direction is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "direction", direction));
        }
        if (search is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "search", search));
        }
        if (startDate is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start_date", startDate));
        }
        if (endDate is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "end_date", endDate));
        }

        // make the HTTP request
        var localVarResponse = this.Client.Get<NetworkTrafficEventsResponse>("events/network-traffic", localVarRequestOptions);
        this.CheckForException("ApiEventsNetworkTrafficGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Traffic Events Returns a list of all network traffic events
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Number of items per page (optional, default to 1000)</param>
    /// <param name="userId">Filter by user ID (optional)</param>
    /// <param name="reporterId">Filter by reporter ID (optional)</param>
    /// <param name="protocol">Filter by protocol (optional)</param>
    /// <param name="type">Filter by event type (optional)</param>
    /// <param name="connectionType">Filter by connection type (optional)</param>
    /// <param name="direction">Filter by direction (optional)</param>
    /// <param name="search">Case-insensitive partial match on user email, source/destination names, and source/destination addresses (optional)</param>
    /// <param name="startDate">Start date for filtering events (ISO 8601 format, e.g., 2024-01-01T00:00:00Z). (optional)</param>
    /// <param name="endDate">End date for filtering events (ISO 8601 format, e.g., 2024-01-31T23:59:59Z). (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of NetworkTrafficEventsResponse</returns>
    public async System.Threading.Tasks.Task<NetworkTrafficEventsResponse> ApiEventsNetworkTrafficGetAsync(int? page = null, int? pageSize = null, string? userId = null, string? reporterId = null, int? protocol = null, string? type = null, string? connectionType = null, string? direction = null, string? search = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<NetworkTrafficEventsResponse> localVarResponse = await ApiEventsNetworkTrafficGetWithHttpInfoAsync(page, pageSize, userId, reporterId, protocol, type, connectionType, direction, search, startDate, endDate, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Traffic Events Returns a list of all network traffic events
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Page number (optional, default to 1)</param>
    /// <param name="pageSize">Number of items per page (optional, default to 1000)</param>
    /// <param name="userId">Filter by user ID (optional)</param>
    /// <param name="reporterId">Filter by reporter ID (optional)</param>
    /// <param name="protocol">Filter by protocol (optional)</param>
    /// <param name="type">Filter by event type (optional)</param>
    /// <param name="connectionType">Filter by connection type (optional)</param>
    /// <param name="direction">Filter by direction (optional)</param>
    /// <param name="search">Case-insensitive partial match on user email, source/destination names, and source/destination addresses (optional)</param>
    /// <param name="startDate">Start date for filtering events (ISO 8601 format, e.g., 2024-01-01T00:00:00Z). (optional)</param>
    /// <param name="endDate">End date for filtering events (ISO 8601 format, e.g., 2024-01-31T23:59:59Z). (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (NetworkTrafficEventsResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<NetworkTrafficEventsResponse>> ApiEventsNetworkTrafficGetWithHttpInfoAsync(int? page = null, int? pageSize = null, string? userId = null, string? reporterId = null, int? protocol = null, string? type = null, string? connectionType = null, string? direction = null, string? search = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        if (page is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page", page));
        }
        if (pageSize is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
        }
        if (userId is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_id", userId));
        }
        if (reporterId is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "reporter_id", reporterId));
        }
        if (protocol is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "protocol", protocol));
        }
        if (type is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "type", type));
        }
        if (connectionType is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "connection_type", connectionType));
        }
        if (direction is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "direction", direction));
        }
        if (search is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "search", search));
        }
        if (startDate is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start_date", startDate));
        }
        if (endDate is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "end_date", endDate));
        }

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<NetworkTrafficEventsResponse>("events/network-traffic", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiEventsNetworkTrafficGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Reverse Proxy Access Logs Returns a paginated list of all reverse proxy access log entries
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Page number for pagination (1-indexed) (optional, default to 1)</param>
    /// <param name="pageSize">Number of items per page (max 100) (optional, default to 50)</param>
    /// <param name="sortBy">Field to sort by (url sorts by host then path) (optional, default to timestamp)</param>
    /// <param name="sortOrder">Sort order (ascending or descending) (optional, default to desc)</param>
    /// <param name="search">General search across request ID, host, path, source IP, user email, and user name (optional)</param>
    /// <param name="sourceIp">Filter by source IP address (optional)</param>
    /// <param name="host">Filter by host header (optional)</param>
    /// <param name="path">Filter by request path (supports partial matching) (optional)</param>
    /// <param name="userId">Filter by authenticated user ID (optional)</param>
    /// <param name="userEmail">Filter by user email (partial matching) (optional)</param>
    /// <param name="userName">Filter by user name (partial matching) (optional)</param>
    /// <param name="method">Filter by HTTP method (optional)</param>
    /// <param name="status">Filter by status (success &#x3D; 2xx/3xx, failed &#x3D; 1xx/4xx/5xx) (optional)</param>
    /// <param name="statusCode">Filter by HTTP status code (optional)</param>
    /// <param name="startDate">Filter by timestamp &gt;&#x3D; start_date (RFC3339 format) (optional)</param>
    /// <param name="endDate">Filter by timestamp &lt;&#x3D; end_date (RFC3339 format) (optional)</param>
    /// <returns>ProxyAccessLogsResponse</returns>
    public ProxyAccessLogsResponse ApiEventsProxyGet(int? page = null, int? pageSize = null, string? sortBy = null, string? sortOrder = null, string? search = null, string? sourceIp = null, string? host = null, string? path = null, string? userId = null, string? userEmail = null, string? userName = null, string? method = null, string? status = null, int? statusCode = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)
    {
        ApiResponse<ProxyAccessLogsResponse> localVarResponse = ApiEventsProxyGetWithHttpInfo(page, pageSize, sortBy, sortOrder, search, sourceIp, host, path, userId, userEmail, userName, method, status, statusCode, startDate, endDate);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Reverse Proxy Access Logs Returns a paginated list of all reverse proxy access log entries
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Page number for pagination (1-indexed) (optional, default to 1)</param>
    /// <param name="pageSize">Number of items per page (max 100) (optional, default to 50)</param>
    /// <param name="sortBy">Field to sort by (url sorts by host then path) (optional, default to timestamp)</param>
    /// <param name="sortOrder">Sort order (ascending or descending) (optional, default to desc)</param>
    /// <param name="search">General search across request ID, host, path, source IP, user email, and user name (optional)</param>
    /// <param name="sourceIp">Filter by source IP address (optional)</param>
    /// <param name="host">Filter by host header (optional)</param>
    /// <param name="path">Filter by request path (supports partial matching) (optional)</param>
    /// <param name="userId">Filter by authenticated user ID (optional)</param>
    /// <param name="userEmail">Filter by user email (partial matching) (optional)</param>
    /// <param name="userName">Filter by user name (partial matching) (optional)</param>
    /// <param name="method">Filter by HTTP method (optional)</param>
    /// <param name="status">Filter by status (success &#x3D; 2xx/3xx, failed &#x3D; 1xx/4xx/5xx) (optional)</param>
    /// <param name="statusCode">Filter by HTTP status code (optional)</param>
    /// <param name="startDate">Filter by timestamp &gt;&#x3D; start_date (RFC3339 format) (optional)</param>
    /// <param name="endDate">Filter by timestamp &lt;&#x3D; end_date (RFC3339 format) (optional)</param>
    /// <returns>ApiResponse of ProxyAccessLogsResponse</returns>
    internal ApiResponse<ProxyAccessLogsResponse> ApiEventsProxyGetWithHttpInfo(int? page = null, int? pageSize = null, string? sortBy = null, string? sortOrder = null, string? search = null, string? sourceIp = null, string? host = null, string? path = null, string? userId = null, string? userEmail = null, string? userName = null, string? method = null, string? status = null, int? statusCode = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        if (page is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page", page));
        }
        if (pageSize is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
        }
        if (sortBy is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sort_by", sortBy));
        }
        if (sortOrder is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sort_order", sortOrder));
        }
        if (search is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "search", search));
        }
        if (sourceIp is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "source_ip", sourceIp));
        }
        if (host is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "host", host));
        }
        if (path is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "path", path));
        }
        if (userId is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_id", userId));
        }
        if (userEmail is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_email", userEmail));
        }
        if (userName is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_name", userName));
        }
        if (method is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "method", method));
        }
        if (status is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "status", status));
        }
        if (statusCode is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "status_code", statusCode));
        }
        if (startDate is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start_date", startDate));
        }
        if (endDate is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "end_date", endDate));
        }

        // make the HTTP request
        var localVarResponse = this.Client.Get<ProxyAccessLogsResponse>("events/proxy", localVarRequestOptions);
        this.CheckForException("ApiEventsProxyGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Reverse Proxy Access Logs Returns a paginated list of all reverse proxy access log entries
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Page number for pagination (1-indexed) (optional, default to 1)</param>
    /// <param name="pageSize">Number of items per page (max 100) (optional, default to 50)</param>
    /// <param name="sortBy">Field to sort by (url sorts by host then path) (optional, default to timestamp)</param>
    /// <param name="sortOrder">Sort order (ascending or descending) (optional, default to desc)</param>
    /// <param name="search">General search across request ID, host, path, source IP, user email, and user name (optional)</param>
    /// <param name="sourceIp">Filter by source IP address (optional)</param>
    /// <param name="host">Filter by host header (optional)</param>
    /// <param name="path">Filter by request path (supports partial matching) (optional)</param>
    /// <param name="userId">Filter by authenticated user ID (optional)</param>
    /// <param name="userEmail">Filter by user email (partial matching) (optional)</param>
    /// <param name="userName">Filter by user name (partial matching) (optional)</param>
    /// <param name="method">Filter by HTTP method (optional)</param>
    /// <param name="status">Filter by status (success &#x3D; 2xx/3xx, failed &#x3D; 1xx/4xx/5xx) (optional)</param>
    /// <param name="statusCode">Filter by HTTP status code (optional)</param>
    /// <param name="startDate">Filter by timestamp &gt;&#x3D; start_date (RFC3339 format) (optional)</param>
    /// <param name="endDate">Filter by timestamp &lt;&#x3D; end_date (RFC3339 format) (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ProxyAccessLogsResponse</returns>
    public async System.Threading.Tasks.Task<ProxyAccessLogsResponse> ApiEventsProxyGetAsync(int? page = null, int? pageSize = null, string? sortBy = null, string? sortOrder = null, string? search = null, string? sourceIp = null, string? host = null, string? path = null, string? userId = null, string? userEmail = null, string? userName = null, string? method = null, string? status = null, int? statusCode = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<ProxyAccessLogsResponse> localVarResponse = await ApiEventsProxyGetWithHttpInfoAsync(page, pageSize, sortBy, sortOrder, search, sourceIp, host, path, userId, userEmail, userName, method, status, statusCode, startDate, endDate, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Reverse Proxy Access Logs Returns a paginated list of all reverse proxy access log entries
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Page number for pagination (1-indexed) (optional, default to 1)</param>
    /// <param name="pageSize">Number of items per page (max 100) (optional, default to 50)</param>
    /// <param name="sortBy">Field to sort by (url sorts by host then path) (optional, default to timestamp)</param>
    /// <param name="sortOrder">Sort order (ascending or descending) (optional, default to desc)</param>
    /// <param name="search">General search across request ID, host, path, source IP, user email, and user name (optional)</param>
    /// <param name="sourceIp">Filter by source IP address (optional)</param>
    /// <param name="host">Filter by host header (optional)</param>
    /// <param name="path">Filter by request path (supports partial matching) (optional)</param>
    /// <param name="userId">Filter by authenticated user ID (optional)</param>
    /// <param name="userEmail">Filter by user email (partial matching) (optional)</param>
    /// <param name="userName">Filter by user name (partial matching) (optional)</param>
    /// <param name="method">Filter by HTTP method (optional)</param>
    /// <param name="status">Filter by status (success &#x3D; 2xx/3xx, failed &#x3D; 1xx/4xx/5xx) (optional)</param>
    /// <param name="statusCode">Filter by HTTP status code (optional)</param>
    /// <param name="startDate">Filter by timestamp &gt;&#x3D; start_date (RFC3339 format) (optional)</param>
    /// <param name="endDate">Filter by timestamp &lt;&#x3D; end_date (RFC3339 format) (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ProxyAccessLogsResponse)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<ProxyAccessLogsResponse>> ApiEventsProxyGetWithHttpInfoAsync(int? page = null, int? pageSize = null, string? sortBy = null, string? sortOrder = null, string? search = null, string? sourceIp = null, string? host = null, string? path = null, string? userId = null, string? userEmail = null, string? userName = null, string? method = null, string? status = null, int? statusCode = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        if (page is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page", page));
        }
        if (pageSize is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
        }
        if (sortBy is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sort_by", sortBy));
        }
        if (sortOrder is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sort_order", sortOrder));
        }
        if (search is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "search", search));
        }
        if (sourceIp is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "source_ip", sourceIp));
        }
        if (host is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "host", host));
        }
        if (path is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "path", path));
        }
        if (userId is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_id", userId));
        }
        if (userEmail is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_email", userEmail));
        }
        if (userName is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_name", userName));
        }
        if (method is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "method", method));
        }
        if (status is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "status", status));
        }
        if (statusCode is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "status_code", statusCode));
        }
        if (startDate is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start_date", startDate));
        }
        if (endDate is not null)
        {
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "end_date", endDate));
        }

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<ProxyAccessLogsResponse>("events/proxy", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiEventsProxyGet", localVarResponse);

        return localVarResponse;
    }

}




