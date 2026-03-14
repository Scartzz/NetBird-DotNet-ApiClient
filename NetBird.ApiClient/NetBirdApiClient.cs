namespace NetBird.ApiClient;

using NetBird.ApiClient.Models;
using RestSharp;
using RestSharp.Authenticators;

public class NetBirdApiClientOptions
{
    public required string AccessToken { get; init; }
    
    public string BaseUrl { get; init; } = "https://api.netbird.io/api";
}

public sealed class NetBirdApiClient : INetBirdApiClient
{
    private readonly RestClient _client;
    private readonly JwtAuthenticator _authenticator;

    public NetBirdApiClient(NetBirdApiClientOptions netbirdOptions)
    {
        this._authenticator = new JwtAuthenticator(netbirdOptions.AccessToken);

        RestClientOptions options = new RestClientOptions(netbirdOptions.BaseUrl);
        options.Authenticator = this._authenticator;
        
        this._client = new RestClient(options, useClientFactory: true);
    }


    public void SetAccessToken(string accessToken)
    {
        this._authenticator.SetBearerToken(accessToken);
    }

    public async Task<List<Peer>> GetPeers()
    {
        var request = new RestRequest("peers", Method.Get);
        var response = await this._client.ExecuteAsync<List<Peer>>(request);
        response.ThrowIfError();
        if (response.Data is null)
            throw new NetBirdApiException(response);
        return response.Data;
    }

    #region Dispose
    
    ~NetBirdApiClient()
    {
        this.Dispose(false);
    }
    
    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            this._client?.Dispose();
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (this._client is IAsyncDisposable clientAsyncDisposable)
            await clientAsyncDisposable.DisposeAsync();
        else
            this._client.Dispose();
        GC.SuppressFinalize(this);
    }
    
    #endregion
}