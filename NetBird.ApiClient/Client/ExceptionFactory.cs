


using System;

namespace NetBird.ApiClient.Client;

/// <summary>
/// A delegate to ExceptionFactory method
/// </summary>
/// <param name="methodName">Method name</param>
/// <param name="response">Response</param>
/// <returns>Exceptions</returns>
internal delegate Exception ExceptionFactory(string methodName, IApiResponse response);