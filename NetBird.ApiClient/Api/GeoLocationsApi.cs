

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
public class GeoLocationsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GeoLocationsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal GeoLocationsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// List all city names by country Get a list of all English city names for a given country code
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="country"></param>
    /// <returns>City</returns>
    public City ApiLocationsCountriesCountryCitiesGet(Country country)
    {
        ApiResponse<City> localVarResponse = ApiLocationsCountriesCountryCitiesGetWithHttpInfo(country);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all city names by country Get a list of all English city names for a given country code
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="country"></param>
    /// <returns>ApiResponse of City</returns>
    internal ApiResponse<City> ApiLocationsCountriesCountryCitiesGetWithHttpInfo(Country country)
    {
        ValidateParameter(country, "country", "GeoLocationsApi->ApiLocationsCountriesCountryCitiesGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("country", ClientUtils.ParameterToString(country)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Get<City>("locations/countries/{country}/cities", localVarRequestOptions);
        this.CheckForException("ApiLocationsCountriesCountryCitiesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all city names by country Get a list of all English city names for a given country code
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="country"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of City</returns>
    public async System.Threading.Tasks.Task<City> ApiLocationsCountriesCountryCitiesGetAsync(Country country, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<City> localVarResponse = await ApiLocationsCountriesCountryCitiesGetWithHttpInfoAsync(country, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all city names by country Get a list of all English city names for a given country code
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="country"></param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (City)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<City>> ApiLocationsCountriesCountryCitiesGetWithHttpInfoAsync(Country country, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(country, "country", "GeoLocationsApi->ApiLocationsCountriesCountryCitiesGet");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("country", ClientUtils.ParameterToString(country)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<City>("locations/countries/{country}/cities", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiLocationsCountriesCountryCitiesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all country codes Get list of all country in 2-letter ISO 3166-1 alpha-2 codes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>List&lt;string&gt;</returns>
    public List<string> ApiLocationsCountriesGet()
    {
        ApiResponse<List<string>> localVarResponse = ApiLocationsCountriesGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all country codes Get list of all country in 2-letter ISO 3166-1 alpha-2 codes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of List&lt;string&gt;</returns>
    public ApiResponse<List<string>> ApiLocationsCountriesGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<string>>("locations/countries", localVarRequestOptions);
        this.CheckForException("ApiLocationsCountriesGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all country codes Get list of all country in 2-letter ISO 3166-1 alpha-2 codes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;string&gt;</returns>
    public async System.Threading.Tasks.Task<List<string>> ApiLocationsCountriesGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<string>> localVarResponse = await ApiLocationsCountriesGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all country codes Get list of all country in 2-letter ISO 3166-1 alpha-2 codes
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<string>>> ApiLocationsCountriesGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<string>>("locations/countries", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiLocationsCountriesGet", localVarResponse);

        return localVarResponse;
    }

}




