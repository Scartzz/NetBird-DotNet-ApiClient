using System;

namespace NetBird.ApiClient.Client;

/// <summary>
/// Base class for API clients.
/// </summary>
public abstract class ApiBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiBase"/> class.
    /// </summary>
    protected ApiBase(NetBirdApiClient netBirdApiClient)
    {
        ArgumentNullException.ThrowIfNull(netBirdApiClient);

        this.Client = netBirdApiClient;
        this.ExceptionFactory = NetBird.ApiClient.Client.NetBirdApiClientOptions.DefaultExceptionFactory;
    }

    /// <summary>
    /// The client for accessing this underlying API synchronously.
    /// </summary>
    internal NetBirdApiClient Client { get; set; }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    internal string GetBasePath() => this.NetBirdApiClientOptions.BaseUrl;

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    internal NetBirdApiClientOptions NetBirdApiClientOptions => this.Client.NetBirdApiClientOptions;

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    internal ExceptionFactory ExceptionFactory
    {
        get
        {
            if (field is not null && field.GetInvocationList().Length > 1)
            {
                throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
            }

            return field;
        }
        set;
    }

    /// <summary>
    /// Validates required parameter and throws ApiException if null.
    /// </summary>
    protected void ValidateParameter(object parameter, string parameterName, string methodName)
    {
        if (parameter is null)
        {
            throw new ApiException(400, $"Missing required parameter '{parameterName}' when calling {methodName}");
        }
    }

    /// <summary>
    /// Handles the response and throws exception if factory returns one.
    /// </summary>
    protected void CheckForException(string methodName, IApiResponse response)
    {
        Exception exception = this.ExceptionFactory(methodName, response);
        if (exception is not null)
        {
            throw exception;
        }
    }
}