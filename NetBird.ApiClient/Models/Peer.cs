namespace NetBird.ApiClient.Models;

using System.Text.Json.Serialization;

public sealed record Peer
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonPropertyName("ip")]
    public required string Ip { get; init; }

    [JsonPropertyName("connection_ip")]
    public required string ConnectionIp { get; init; }

    [JsonPropertyName("connected")]
    public required bool Connected { get; init; }

    [JsonPropertyName("last_seen")]
    public required string LastSeen { get; init; }

    [JsonPropertyName("os")]
    public required string Os { get; init; }

    [JsonPropertyName("kernel_version")]
    public required string KernelVersion { get; init; }

    [JsonPropertyName("geoname_id")]
    public required int GeonameId { get; init; }

    [JsonPropertyName("version")]
    public required string Version { get; init; }

    [JsonPropertyName("groups")]
    public required List<Group> Groups { get; init; }

    [JsonPropertyName("ssh_enabled")]
    public required bool SshEnabled { get; init; }

    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    [JsonPropertyName("hostname")]
    public required string Hostname { get; init; }

    [JsonPropertyName("ui_version")]
    public required string UiVersion { get; init; }

    [JsonPropertyName("dns_label")]
    public required string DnsLabel { get; init; }

    [JsonPropertyName("login_expiration_enabled")]
    public required bool LoginExpirationEnabled { get; init; }

    [JsonPropertyName("login_expired")]
    public required bool LoginExpired { get; init; }

    [JsonPropertyName("last_login")]
    public required string LastLogin { get; init; }

    [JsonPropertyName("inactivity_expiration_enabled")]
    public required bool InactivityExpirationEnabled { get; init; }

    [JsonPropertyName("approval_required")]
    public required bool ApprovalRequired { get; init; }

    [JsonPropertyName("disapproval_reason")]
    public string? DisapprovalReason { get; init; }

    [JsonPropertyName("country_code")]
    public required string CountryCode { get; init; }

    [JsonPropertyName("city_name")]
    public required string CityName { get; init; }

    [JsonPropertyName("serial_number")]
    public required string SerialNumber { get; init; }

    [JsonPropertyName("extra_dns_labels")]
    public required List<string> ExtraDnsLabels { get; init; }

    [JsonPropertyName("ephemeral")]
    public required bool Ephemeral { get; init; }

    [JsonPropertyName("local_flags")]
    public required LocalFlags LocalFlags { get; init; }

    [JsonPropertyName("accessible_peers_count")]
    public required int AccessiblePeersCount { get; init; }
}