namespace NetBird.ApiClient.Models;

using System.Text.Json.Serialization;

public sealed record Group
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("peers_count")]
    public required int PeersCount { get; init; }

    [JsonPropertyName("resources_count")]
    public required int ResourcesCount { get; init; }

    [JsonPropertyName("issued")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Issued { get; init; }
}