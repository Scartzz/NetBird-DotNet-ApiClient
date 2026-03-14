

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
public class DNSZonesApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DNSZonesApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal DNSZonesApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all DNS Zones Returns a list of all custom DNS zones
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;Zone&gt;</returns>
    public List<Zone> ApiDnsZonesGet()
    {
        ApiResponse<List<Zone>> localVarResponse = ApiDnsZonesGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all DNS Zones Returns a list of all custom DNS zones
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;Zone&gt;</returns>
    public ApiResponse<List<Zone>> ApiDnsZonesGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Zone>>("dns/zones", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all DNS Zones Returns a list of all custom DNS zones
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Zone&gt;</returns>
    public async System.Threading.Tasks.Task<List<Zone>> ApiDnsZonesGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Zone>> localVarResponse = await ApiDnsZonesGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all DNS Zones Returns a list of all custom DNS zones
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Zone&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Zone>>> ApiDnsZonesGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Zone>>("dns/zones", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a DNS Zone Creates a new custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneRequest">A DNS zone object (optional)</param>
    /// <returns>Zone</returns>
    public Zone ApiDnsZonesPost(ZoneRequest? zoneRequest = null)
    {
        ApiResponse<Zone> localVarResponse = ApiDnsZonesPostWithHttpInfo(zoneRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a DNS Zone Creates a new custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneRequest">A DNS zone object (optional)</param>
    /// <returns>ApiResponse of Zone</returns>
    internal ApiResponse<Zone> ApiDnsZonesPostWithHttpInfo(ZoneRequest? zoneRequest = null)
    {
        RequestOptions<ZoneRequest> localVarRequestOptions = new RequestOptions<ZoneRequest>();

        localVarRequestOptions.Data = zoneRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<Zone>("dns/zones", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a DNS Zone Creates a new custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneRequest">A DNS zone object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Zone</returns>
    public async System.Threading.Tasks.Task<Zone> ApiDnsZonesPostAsync(ZoneRequest? zoneRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Zone> localVarResponse = await ApiDnsZonesPostWithHttpInfoAsync(zoneRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a DNS Zone Creates a new custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneRequest">A DNS zone object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Zone)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Zone>> ApiDnsZonesPostWithHttpInfoAsync(ZoneRequest? zoneRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions<ZoneRequest> localVarRequestOptions = new RequestOptions<ZoneRequest>();

        localVarRequestOptions.Data = zoneRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<Zone>("dns/zones", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a DNS Zone Deletes a custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <returns></returns>
    public void ApiDnsZonesZoneIdDelete(string zoneId)
    {
        ApiDnsZonesZoneIdDeleteWithHttpInfo(zoneId);
    }

    /// <summary>
    /// Delete a DNS Zone Deletes a custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiDnsZonesZoneIdDeleteWithHttpInfo(string zoneId)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("dns/zones/{zoneId}", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesZoneIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a DNS Zone Deletes a custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiDnsZonesZoneIdDeleteAsync(string zoneId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiDnsZonesZoneIdDeleteWithHttpInfoAsync(zoneId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a DNS Zone Deletes a custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiDnsZonesZoneIdDeleteWithHttpInfoAsync(string zoneId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("dns/zones/{zoneId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesZoneIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a DNS Zone Returns information about a specific DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <returns>Zone</returns>
    public Zone ApiDnsZonesZoneIdGet(string zoneId)
    {
        ApiResponse<Zone> localVarResponse = ApiDnsZonesZoneIdGetWithHttpInfo(zoneId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a DNS Zone Returns information about a specific DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <returns>ApiResponse of Zone</returns>
    internal ApiResponse<Zone> ApiDnsZonesZoneIdGetWithHttpInfo(string zoneId)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<Zone>("dns/zones/{zoneId}", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesZoneIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a DNS Zone Returns information about a specific DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Zone</returns>
    public async System.Threading.Tasks.Task<Zone> ApiDnsZonesZoneIdGetAsync(string zoneId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Zone> localVarResponse = await ApiDnsZonesZoneIdGetWithHttpInfoAsync(zoneId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a DNS Zone Returns information about a specific DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Zone)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Zone>> ApiDnsZonesZoneIdGetWithHttpInfoAsync(string zoneId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<Zone>("dns/zones/{zoneId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesZoneIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a DNS Zone Updates a custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="zoneRequest">A DNS zone object (optional)</param>
    /// <returns>Zone</returns>
    public Zone ApiDnsZonesZoneIdPut(string zoneId, ZoneRequest? zoneRequest = null)
    {
        ApiResponse<Zone> localVarResponse = ApiDnsZonesZoneIdPutWithHttpInfo(zoneId, zoneRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a DNS Zone Updates a custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="zoneRequest">A DNS zone object (optional)</param>
    /// <returns>ApiResponse of Zone</returns>
    internal ApiResponse<Zone> ApiDnsZonesZoneIdPutWithHttpInfo(string zoneId, ZoneRequest? zoneRequest = null)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdPut");

        RequestOptions<ZoneRequest> localVarRequestOptions = new RequestOptions<ZoneRequest>();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.Data = zoneRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Zone>("dns/zones/{zoneId}", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesZoneIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a DNS Zone Updates a custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="zoneRequest">A DNS zone object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Zone</returns>
    public async System.Threading.Tasks.Task<Zone> ApiDnsZonesZoneIdPutAsync(string zoneId, ZoneRequest? zoneRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Zone> localVarResponse = await ApiDnsZonesZoneIdPutWithHttpInfoAsync(zoneId, zoneRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a DNS Zone Updates a custom DNS zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="zoneRequest">A DNS zone object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Zone)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Zone>> ApiDnsZonesZoneIdPutWithHttpInfoAsync(string zoneId, ZoneRequest? zoneRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdPut");

        RequestOptions<ZoneRequest> localVarRequestOptions = new RequestOptions<ZoneRequest>();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.Data = zoneRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Zone>("dns/zones/{zoneId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesZoneIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all DNS Records Returns a list of all DNS records in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <returns>List&lt;DNSRecord&gt;</returns>
    public List<DNSRecord> ApiDnsZonesZoneIdRecordsGet(string zoneId)
    {
        ApiResponse<List<DNSRecord>> localVarResponse = ApiDnsZonesZoneIdRecordsGetWithHttpInfo(zoneId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all DNS Records Returns a list of all DNS records in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <returns>ApiResponse of List&lt;DNSRecord&gt;</returns>
    public ApiResponse<List<DNSRecord>> ApiDnsZonesZoneIdRecordsGetWithHttpInfo(string zoneId)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<DNSRecord>>("dns/zones/{zoneId}/records", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesZoneIdRecordsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all DNS Records Returns a list of all DNS records in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;DNSRecord&gt;</returns>
    public async System.Threading.Tasks.Task<List<DNSRecord>> ApiDnsZonesZoneIdRecordsGetAsync(string zoneId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<DNSRecord>> localVarResponse = await ApiDnsZonesZoneIdRecordsGetWithHttpInfoAsync(zoneId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all DNS Records Returns a list of all DNS records in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;DNSRecord&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<DNSRecord>>> ApiDnsZonesZoneIdRecordsGetWithHttpInfoAsync(string zoneId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<DNSRecord>>("dns/zones/{zoneId}/records", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesZoneIdRecordsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a DNS Record Creates a new DNS record in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="dNSRecordRequest">A DNS record object (optional)</param>
    /// <returns>DNSRecord</returns>
    public DNSRecord ApiDnsZonesZoneIdRecordsPost(string zoneId, DNSRecordRequest? dNSRecordRequest = null)
    {
        ApiResponse<DNSRecord> localVarResponse = ApiDnsZonesZoneIdRecordsPostWithHttpInfo(zoneId, dNSRecordRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a DNS Record Creates a new DNS record in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="dNSRecordRequest">A DNS record object (optional)</param>
    /// <returns>ApiResponse of DNSRecord</returns>
    internal ApiResponse<DNSRecord> ApiDnsZonesZoneIdRecordsPostWithHttpInfo(string zoneId, DNSRecordRequest? dNSRecordRequest = null)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsPost");

        RequestOptions<DNSRecordRequest> localVarRequestOptions = new RequestOptions<DNSRecordRequest>();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.Data = dNSRecordRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Post<DNSRecord>("dns/zones/{zoneId}/records", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesZoneIdRecordsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Create a DNS Record Creates a new DNS record in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="dNSRecordRequest">A DNS record object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of DNSRecord</returns>
    public async System.Threading.Tasks.Task<DNSRecord> ApiDnsZonesZoneIdRecordsPostAsync(string zoneId, DNSRecordRequest? dNSRecordRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<DNSRecord> localVarResponse = await ApiDnsZonesZoneIdRecordsPostWithHttpInfoAsync(zoneId, dNSRecordRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Create a DNS Record Creates a new DNS record in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="dNSRecordRequest">A DNS record object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (DNSRecord)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<DNSRecord>> ApiDnsZonesZoneIdRecordsPostWithHttpInfoAsync(string zoneId, DNSRecordRequest? dNSRecordRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsPost");

        RequestOptions<DNSRecordRequest> localVarRequestOptions = new RequestOptions<DNSRecordRequest>();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.Data = dNSRecordRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PostAsync<DNSRecord>("dns/zones/{zoneId}/records", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesZoneIdRecordsPost", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a DNS Record Deletes a DNS record from a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <returns></returns>
    public void ApiDnsZonesZoneIdRecordsRecordIdDelete(string zoneId, string recordId)
    {
        ApiDnsZonesZoneIdRecordsRecordIdDeleteWithHttpInfo(zoneId, recordId);
    }

    /// <summary>
    /// Delete a DNS Record Deletes a DNS record from a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<Object> ApiDnsZonesZoneIdRecordsRecordIdDeleteWithHttpInfo(string zoneId, string recordId)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdDelete");

        ValidateParameter(recordId, "recordId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.PathParameters.Add("recordId", ClientUtils.ParameterToString(recordId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<Object>("dns/zones/{zoneId}/records/{recordId}", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesZoneIdRecordsRecordIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete a DNS Record Deletes a DNS record from a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiDnsZonesZoneIdRecordsRecordIdDeleteAsync(string zoneId, string recordId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiDnsZonesZoneIdRecordsRecordIdDeleteWithHttpInfoAsync(zoneId, recordId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a DNS Record Deletes a DNS record from a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Object>> ApiDnsZonesZoneIdRecordsRecordIdDeleteWithHttpInfoAsync(string zoneId, string recordId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdDelete");

        ValidateParameter(recordId, "recordId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.PathParameters.Add("recordId", ClientUtils.ParameterToString(recordId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<Object>("dns/zones/{zoneId}/records/{recordId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesZoneIdRecordsRecordIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a DNS Record Returns information about a specific DNS record
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <returns>DNSRecord</returns>
    public DNSRecord ApiDnsZonesZoneIdRecordsRecordIdGet(string zoneId, string recordId)
    {
        ApiResponse<DNSRecord> localVarResponse = ApiDnsZonesZoneIdRecordsRecordIdGetWithHttpInfo(zoneId, recordId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a DNS Record Returns information about a specific DNS record
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <returns>ApiResponse of DNSRecord</returns>
    internal ApiResponse<DNSRecord> ApiDnsZonesZoneIdRecordsRecordIdGetWithHttpInfo(string zoneId, string recordId)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdGet");

        ValidateParameter(recordId, "recordId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.PathParameters.Add("recordId", ClientUtils.ParameterToString(recordId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<DNSRecord>("dns/zones/{zoneId}/records/{recordId}", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesZoneIdRecordsRecordIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Retrieve a DNS Record Returns information about a specific DNS record
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of DNSRecord</returns>
    public async System.Threading.Tasks.Task<DNSRecord> ApiDnsZonesZoneIdRecordsRecordIdGetAsync(string zoneId, string recordId, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<DNSRecord> localVarResponse = await ApiDnsZonesZoneIdRecordsRecordIdGetWithHttpInfoAsync(zoneId, recordId, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Retrieve a DNS Record Returns information about a specific DNS record
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (DNSRecord)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<DNSRecord>> ApiDnsZonesZoneIdRecordsRecordIdGetWithHttpInfoAsync(string zoneId, string recordId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdGet");

        ValidateParameter(recordId, "recordId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.PathParameters.Add("recordId", ClientUtils.ParameterToString(recordId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<DNSRecord>("dns/zones/{zoneId}/records/{recordId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesZoneIdRecordsRecordIdGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a DNS Record Updates a DNS record in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <param name="dNSRecordRequest">A DNS record object (optional)</param>
    /// <returns>DNSRecord</returns>
    public DNSRecord ApiDnsZonesZoneIdRecordsRecordIdPut(string zoneId, string recordId, DNSRecordRequest? dNSRecordRequest = null)
    {
        ApiResponse<DNSRecord> localVarResponse = ApiDnsZonesZoneIdRecordsRecordIdPutWithHttpInfo(zoneId, recordId, dNSRecordRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a DNS Record Updates a DNS record in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <param name="dNSRecordRequest">A DNS record object (optional)</param>
    /// <returns>ApiResponse of DNSRecord</returns>
    internal ApiResponse<DNSRecord> ApiDnsZonesZoneIdRecordsRecordIdPutWithHttpInfo(string zoneId, string recordId, DNSRecordRequest? dNSRecordRequest = null)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdPut");

        ValidateParameter(recordId, "recordId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdPut");

        RequestOptions<DNSRecordRequest> localVarRequestOptions = new RequestOptions<DNSRecordRequest>();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.PathParameters.Add("recordId", ClientUtils.ParameterToString(recordId)); // path parameter
        localVarRequestOptions.Data = dNSRecordRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<DNSRecord>("dns/zones/{zoneId}/records/{recordId}", localVarRequestOptions);
        this.CheckForException("ApiDnsZonesZoneIdRecordsRecordIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update a DNS Record Updates a DNS record in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <param name="dNSRecordRequest">A DNS record object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of DNSRecord</returns>
    public async System.Threading.Tasks.Task<DNSRecord> ApiDnsZonesZoneIdRecordsRecordIdPutAsync(string zoneId, string recordId, DNSRecordRequest? dNSRecordRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<DNSRecord> localVarResponse = await ApiDnsZonesZoneIdRecordsRecordIdPutWithHttpInfoAsync(zoneId, recordId, dNSRecordRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update a DNS Record Updates a DNS record in a zone
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="zoneId">The unique identifier of a zone</param>
    /// <param name="recordId">The unique identifier of a DNS record</param>
    /// <param name="dNSRecordRequest">A DNS record object (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (DNSRecord)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<DNSRecord>> ApiDnsZonesZoneIdRecordsRecordIdPutWithHttpInfoAsync(string zoneId, string recordId, DNSRecordRequest? dNSRecordRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(zoneId, "zoneId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdPut");

        ValidateParameter(recordId, "recordId", "DNSZonesApi->ApiDnsZonesZoneIdRecordsRecordIdPut");

        RequestOptions<DNSRecordRequest> localVarRequestOptions = new RequestOptions<DNSRecordRequest>();

        localVarRequestOptions.PathParameters.Add("zoneId", ClientUtils.ParameterToString(zoneId)); // path parameter
        localVarRequestOptions.PathParameters.Add("recordId", ClientUtils.ParameterToString(recordId)); // path parameter
        localVarRequestOptions.Data = dNSRecordRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<DNSRecord>("dns/zones/{zoneId}/records/{recordId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiDnsZonesZoneIdRecordsRecordIdPut", localVarResponse);

        return localVarResponse;
    }

}




