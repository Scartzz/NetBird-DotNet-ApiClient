using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace NetBird.ApiClient.Client;

/// <summary>
/// Represents a set of configuration settings
/// </summary>
public class NetBirdApiClientOptions
{
    #region Constants

    /// <summary>
    /// Identifier for ISO 8601 DateTime Format
    /// </summary>
    /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
    // ReSharper disable once InconsistentNaming
    public const string ISO8601_DATETIME_FORMAT = "o";

    #endregion Constants

    #region Static Members

    /// <summary>
    /// Default creation of exceptions for a given method name and response object
    /// </summary>
    internal static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
    {
        var status = (int)response.StatusCode;
        if (status >= 400)
        {
            return new ApiException(status,
                string.Format("Error calling {0}: {1}", methodName, response.RawContent),
                response.RawContent, response.Headers);
        }
        if (status == 0)
        {
            return new ApiException(status,
                string.Format("Error calling {0}: {1}", methodName, response.ErrorText), response.ErrorText);
        }
        return null;
    };

    #endregion Static Members

    #region Private Members

    /// <summary>
    /// Defines the base path of the target API server.
    /// Example: http://localhost:3000/v1/
    /// </summary>
    private string _baseUrl;

    #endregion Private Members

    #region Constructors
        
    /// <summary>
    /// Initializes a new instance of the <see cref="NetBirdApiClientOptions" /> class
    /// </summary>
    public NetBirdApiClientOptions(
        string? accessToken = null,
        string baseUrl = "https://api.netbird.io")
    {
        if (string.IsNullOrWhiteSpace(baseUrl))
            throw new ArgumentException("The provided basePath is invalid.", "baseUrl");

        AccessToken = accessToken ?? string.Empty;
        this.BaseUrl = baseUrl;
        UserAgent = WebUtility.UrlEncode("OpenAPI-Generator/1.0.0/csharp");
        DefaultHeaders = new ConcurrentDictionary<string, string>();
        Timeout = TimeSpan.FromSeconds(100);
    }

    #endregion Constructors

    #region Properties

    /// <summary>
    /// Gets or sets the base path for API access.
    /// </summary>
    public string BaseUrl 
    {
        get { return this._baseUrl; }
        set { this._baseUrl = value; }
    }

    /// <summary>
    /// Gets or sets the default headers.
    /// </summary>
    public IDictionary<string, string> DefaultHeaders { get; set; }

    /// <summary>
    /// Gets or sets the HTTP timeout of ApiClient. Defaults to 100 seconds.
    /// </summary>
    public TimeSpan Timeout { get; set; }

    /// <summary>
    /// Gets or sets the proxy
    /// </summary>
    /// <value>Proxy.</value>
    public WebProxy Proxy { get; set; }

    /// <summary>
    /// Gets or sets the HTTP user agent.
    /// </summary>
    /// <value>Http user agent.</value>
    public string UserAgent { get; set; }

    /// <summary>
    /// Gets or sets certificate collection to be sent with requests.
    /// </summary>
    /// <value>X509 Certificate collection.</value>
    public X509CertificateCollection ClientCertificates { get; set; }

    /// <summary>
    /// Gets or sets the access token for OAuth2 authentication.
    ///
    /// This helper property simplifies code generation.
    /// </summary>
    /// <value>The access token.</value>
    public string AccessToken { get; set; }
        
    /// <summary>
    /// Gets and Sets the RemoteCertificateValidationCallback
    /// </summary>
    public RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }

    #endregion Properties
}