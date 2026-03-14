


using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace NetBird.ApiClient.Client;

using System.Linq;
using RestSharp;

internal interface IRequestOptions
{
    /// <summary>
    /// Parameters to be bound to path parts of the Request's URL
    /// </summary>
    public Dictionary<string, string> PathParameters { get; }
    
    /// <summary>
    /// Query parameters to be applied to the request.
    /// Keys may have 1 or more values associated.
    /// </summary>
    public Multimap<string, string> QueryParameters { get; }

    public void AddDataToRequest(RestRequest request);
}

/// <summary>
/// A container for generalized request inputs. This type allows consumers to extend the request functionality
/// by abstracting away from the default (built-in) request framework (e.g. RestSharp).
/// </summary>
internal class RequestOptions : IRequestOptions
{
    /// <summary>
    /// Parameters to be bound to path parts of the Request's URL
    /// </summary>
    public Dictionary<string, string> PathParameters { get; set; }

    /// <summary>
    /// Query parameters to be applied to the request.
    /// Keys may have 1 or more values associated.
    /// </summary>
    public Multimap<string, string> QueryParameters { get; set; }

    public void AddDataToRequest(RestRequest request)
    {
        // Content-Type Header for body
        if (this.Data is not null && !request.Parameters.Any(p => p.Name == "Content-Type" && p.Type == ParameterType.HttpHeader))
        {
            request.AddHeader("Content-Type", "application/json");
        }

        if (this.Data is not null)
        {
            if (Data is Stream stream)
            {
                var contentType = "application/octet-stream";

                var bytes = ClientUtils.ReadAsBytes(stream);
                request.AddParameter(contentType, bytes, ParameterType.RequestBody);
            }
            else
            {
                // Here, we'll assume JSON APIs are more common. XML can be forced by adding produces/consumes to openapi spec explicitly.
                request.RequestFormat = DataFormat.Json;

                request.AddJsonBody(this.Data);
            }
        }
    }

    /// <summary>
    /// Any data associated with a request body.
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    /// Constructs a new instance of <see cref="RequestOptions"/>
    /// </summary>
    public RequestOptions()
    {
        PathParameters = new Dictionary<string, string>();
        QueryParameters = new Multimap<string, string>();
    }
}

internal class RequestOptions<T> : IRequestOptions where T : class
{
    /// <summary>
    /// Parameters to be bound to path parts of the Request's URL
    /// </summary>
    public Dictionary<string, string> PathParameters { get; set; }

    /// <summary>
    /// Query parameters to be applied to the request.
    /// Keys may have 1 or more values associated.
    /// </summary>
    public Multimap<string, string> QueryParameters { get; set; }

    public void AddDataToRequest(RestRequest request)
    {
        // Content-Type Header for body
        if (this.Data is not null && !request.Parameters.Any(p => p.Name == "Content-Type" && p.Type == ParameterType.HttpHeader))
        {
            request.AddHeader("Content-Type", "application/json");
        }

        if (this.Data is not null)
        {
            if (Data is Stream stream)
            {
                var contentType = "application/octet-stream";

                var bytes = ClientUtils.ReadAsBytes(stream);
                request.AddParameter(contentType, bytes, ParameterType.RequestBody);
            }
            else
            {
                // Here, we'll assume JSON APIs are more common. XML can be forced by adding produces/consumes to openapi spec explicitly.
                request.RequestFormat = DataFormat.Json;

                request.AddJsonBody(this.Data);
            }
        }
    }
    
    /// <summary>
    /// Any data associated with a request body.
    /// </summary>
    public T Data { get; set; }

    /// <summary>
    /// Constructs a new instance of <see cref="RequestOptions"/>
    /// </summary>
    public RequestOptions()
    {
        PathParameters = new Dictionary<string, string>();
        QueryParameters = new Multimap<string, string>();
    }
}