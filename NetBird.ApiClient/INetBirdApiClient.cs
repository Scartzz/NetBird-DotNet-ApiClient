namespace NetBird.ApiClient;

using NetBird.ApiClient.Models;

public interface INetBirdApiClient : IAsyncDisposable, IDisposable
{
    void SetAccessToken(string accessToken);
    
    Task<List<Peer>> GetPeers();
}