namespace NetBird.ApiClient;

using RestSharp;

public class NetBirdApiException : Exception
{
    public NetBirdApiException(RestResponse response)
    {
        this.Response = response;
    }
    
    public RestResponse Response { get; }
}