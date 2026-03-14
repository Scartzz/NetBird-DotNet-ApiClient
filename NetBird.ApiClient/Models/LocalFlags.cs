namespace NetBird.ApiClient.Models;

using System.Text.Json.Serialization;

public sealed record LocalFlags
{
    [JsonPropertyName("rosenpass_enabled")]
    public required bool RosenpassEnabled { get; init; }

    [JsonPropertyName("rosenpass_permissive")]
    public required bool RosenpassPermissive { get; init; }

    [JsonPropertyName("server_ssh_allowed")]
    public required bool ServerSshAllowed { get; init; }

    [JsonPropertyName("disable_client_routes")]
    public required bool DisableClientRoutes { get; init; }

    [JsonPropertyName("disable_server_routes")]
    public required bool DisableServerRoutes { get; init; }

    [JsonPropertyName("disable_dns")]
    public required bool DisableDns { get; init; }

    [JsonPropertyName("disable_firewall")]
    public required bool DisableFirewall { get; init; }

    [JsonPropertyName("block_lan_access")]
    public required bool BlockLanAccess { get; init; }

    [JsonPropertyName("block_inbound")]
    public required bool BlockInbound { get; init; }

    [JsonPropertyName("lazy_connection_enabled")]
    public required bool LazyConnectionEnabled { get; init; }
}