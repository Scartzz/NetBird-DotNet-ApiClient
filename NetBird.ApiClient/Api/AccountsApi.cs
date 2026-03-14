

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
public class AccountsApi : ApiBase
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AccountsApi"/> class.
    /// </summary>
    /// <param name="netBirdApiClient">The api client.</param>
    internal AccountsApi(NetBird.ApiClient.Client.NetBirdApiClient netBirdApiClient) : base(netBirdApiClient)
    {
    }

    /// <summary>
    /// Delete an Account Deletes an account and all its resources. Only account owners can delete accounts.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">The unique identifier of an account</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    public void ApiAccountsAccountIdDelete(string accountId)
    {
        ApiAccountsAccountIdDeleteWithHttpInfo(accountId);
    }

    /// <summary>
    /// Delete an Account Deletes an account and all its resources. Only account owners can delete accounts.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">The unique identifier of an account</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    internal ApiResponse<object> ApiAccountsAccountIdDeleteWithHttpInfo(string accountId)
    {
        ValidateParameter(accountId, "accountId", "AccountsApi->ApiAccountsAccountIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("accountId", ClientUtils.ParameterToString(accountId)); // path parameter

        // make the HTTP request
        var localVarResponse = this.Client.Delete<object>("accounts/{accountId}", localVarRequestOptions);
        this.CheckForException("ApiAccountsAccountIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Delete an Account Deletes an account and all its resources. Only account owners can delete accounts.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">The unique identifier of an account</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async System.Threading.Tasks.Task ApiAccountsAccountIdDeleteAsync(string accountId, System.Threading.CancellationToken cancellationToken = default)
    {
        await ApiAccountsAccountIdDeleteWithHttpInfoAsync(accountId, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Delete an Account Deletes an account and all its resources. Only account owners can delete accounts.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">The unique identifier of an account</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<object>> ApiAccountsAccountIdDeleteWithHttpInfoAsync(string accountId, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(accountId, "accountId", "AccountsApi->ApiAccountsAccountIdDelete");

        RequestOptions localVarRequestOptions = new RequestOptions();

        localVarRequestOptions.PathParameters.Add("accountId", ClientUtils.ParameterToString(accountId)); // path parameter

        // make the HTTP request
        var localVarResponse = await this.Client.DeleteAsync<object>("accounts/{accountId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiAccountsAccountIdDelete", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update an Account Update information about an account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">The unique identifier of an account</param>
    /// <param name="accountRequest">update an account (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>Account</returns>
    public Account ApiAccountsAccountIdPut(string accountId, AccountRequest? accountRequest = null)
    {
        ApiResponse<Account> localVarResponse = ApiAccountsAccountIdPutWithHttpInfo(accountId, accountRequest);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update an Account Update information about an account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">The unique identifier of an account</param>
    /// <param name="accountRequest">update an account (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Account</returns>
    internal ApiResponse<Account> ApiAccountsAccountIdPutWithHttpInfo(string accountId, AccountRequest? accountRequest = null)
    {
        ValidateParameter(accountId, "accountId", "AccountsApi->ApiAccountsAccountIdPut");

        RequestOptions<AccountRequest> localVarRequestOptions = new RequestOptions<AccountRequest>();

        localVarRequestOptions.PathParameters.Add("accountId", ClientUtils.ParameterToString(accountId)); // path parameter
        localVarRequestOptions.Data = accountRequest;

        // make the HTTP request
        var localVarResponse = this.Client.Put<Account>("accounts/{accountId}", localVarRequestOptions);
        this.CheckForException("ApiAccountsAccountIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// Update an Account Update information about an account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">The unique identifier of an account</param>
    /// <param name="accountRequest">update an account (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of Account</returns>
    public async System.Threading.Tasks.Task<Account> ApiAccountsAccountIdPutAsync(string accountId, AccountRequest? accountRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<Account> localVarResponse = await ApiAccountsAccountIdPutWithHttpInfoAsync(accountId, accountRequest, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Update an Account Update information about an account
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">The unique identifier of an account</param>
    /// <param name="accountRequest">update an account (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (Account)</returns>
    internal async System.Threading.Tasks.Task<ApiResponse<Account>> ApiAccountsAccountIdPutWithHttpInfoAsync(string accountId, AccountRequest? accountRequest = null, System.Threading.CancellationToken cancellationToken = default)
    {
        ValidateParameter(accountId, "accountId", "AccountsApi->ApiAccountsAccountIdPut");

        RequestOptions<AccountRequest> localVarRequestOptions = new RequestOptions<AccountRequest>();

        localVarRequestOptions.PathParameters.Add("accountId", ClientUtils.ParameterToString(accountId)); // path parameter
        localVarRequestOptions.Data = accountRequest;

        // make the HTTP request
        var localVarResponse = await this.Client.PutAsync<Account>("accounts/{accountId}", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiAccountsAccountIdPut", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Accounts Returns a list of accounts of a user. Always returns a list of one account.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>List&lt;Account&gt;</returns>
    public List<Account> ApiAccountsGet()
    {
        ApiResponse<List<Account>> localVarResponse = ApiAccountsGetWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Accounts Returns a list of accounts of a user. Always returns a list of one account.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of List&lt;Account&gt;</returns>
    public ApiResponse<List<Account>> ApiAccountsGetWithHttpInfo()
    {
        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = this.Client.Get<List<Account>>("accounts", localVarRequestOptions);
        this.CheckForException("ApiAccountsGet", localVarResponse);

        return localVarResponse;
    }

    /// <summary>
    /// List all Accounts Returns a list of accounts of a user. Always returns a list of one account.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;Account&gt;</returns>
    public async System.Threading.Tasks.Task<List<Account>> ApiAccountsGetAsync(System.Threading.CancellationToken cancellationToken = default)
    {
        ApiResponse<List<Account>> localVarResponse = await ApiAccountsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// List all Accounts Returns a list of accounts of a user. Always returns a list of one account.
    /// </summary>
    /// <exception cref="NetBird.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;Account&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<Account>>> ApiAccountsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
    {

        RequestOptions localVarRequestOptions = new RequestOptions();

        // make the HTTP request
        var localVarResponse = await this.Client.GetAsync<List<Account>>("accounts", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

        this.CheckForException("ApiAccountsGet", localVarResponse);

        return localVarResponse;
    }

}



