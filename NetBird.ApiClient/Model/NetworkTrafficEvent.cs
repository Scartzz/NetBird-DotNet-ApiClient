


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;


using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = NetBird.ApiClient.Client.OpenAPIDateConverter;

namespace NetBird.ApiClient.Model;

/// <summary>
/// NetworkTrafficEvent
/// </summary>
[DataContract(Name = "NetworkTrafficEvent")]
public class NetworkTrafficEvent : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficEvent" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkTrafficEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficEvent" /> class.
    /// </summary>
    /// <param name="flowId">FlowID is the ID of the connection flow. Not unique because it can be the same for multiple events (e.g., start and end of the connection). (required).</param>
    /// <param name="reporterId">ID of the reporter of the event (e.g., the peer that reported the event). (required).</param>
    /// <param name="source">source (required).</param>
    /// <param name="destination">destination (required).</param>
    /// <param name="user">user (required).</param>
    /// <param name="policy">policy (required).</param>
    /// <param name="icmp">icmp (required).</param>
    /// <param name="protocol">Protocol is the protocol of the traffic (e.g. 1 &#x3D; ICMP, 6 &#x3D; TCP, 17 &#x3D; UDP, etc.). (required).</param>
    /// <param name="direction">Direction of the traffic (e.g. DIRECTION_UNKNOWN, INGRESS, EGRESS). (required).</param>
    /// <param name="rxBytes">Number of bytes received. (required).</param>
    /// <param name="rxPackets">Number of packets received. (required).</param>
    /// <param name="txBytes">Number of bytes transmitted. (required).</param>
    /// <param name="txPackets">Number of packets transmitted. (required).</param>
    /// <param name="events">List of events that are correlated to this flow (e.g., start, end). (required).</param>
    public NetworkTrafficEvent(string flowId = null, string reporterId = null, NetworkTrafficEndpoint source = null, NetworkTrafficEndpoint destination = null, NetworkTrafficUser user = null, NetworkTrafficPolicy policy = null, NetworkTrafficICMP icmp = null, int protocol = 0, string direction = null, int rxBytes = 0, int rxPackets = 0, int txBytes = 0, int txPackets = 0, List<NetworkTrafficSubEvent> events = null)
    {
        // to ensure "flowId" is required (not null)
        ArgumentNullException.ThrowIfNull(flowId);
        this.FlowId = flowId;
        // to ensure "reporterId" is required (not null)
        ArgumentNullException.ThrowIfNull(reporterId);
        this.ReporterId = reporterId;
        // to ensure "source" is required (not null)
        ArgumentNullException.ThrowIfNull(source);
        this.Source = source;
        // to ensure "destination" is required (not null)
        ArgumentNullException.ThrowIfNull(destination);
        this.Destination = destination;
        // to ensure "user" is required (not null)
        ArgumentNullException.ThrowIfNull(user);
        this.User = user;
        // to ensure "policy" is required (not null)
        ArgumentNullException.ThrowIfNull(policy);
        this.Policy = policy;
        // to ensure "icmp" is required (not null)
        ArgumentNullException.ThrowIfNull(icmp);
        this.Icmp = icmp;
        this.Protocol = protocol;
        // to ensure "direction" is required (not null)
        ArgumentNullException.ThrowIfNull(direction);
        this.Direction = direction;
        this.RxBytes = rxBytes;
        this.RxPackets = rxPackets;
        this.TxBytes = txBytes;
        this.TxPackets = txPackets;
        // to ensure "events" is required (not null)
        ArgumentNullException.ThrowIfNull(events);
        this.Events = events;
    }

    /// <summary>
    /// FlowID is the ID of the connection flow. Not unique because it can be the same for multiple events (e.g., start and end of the connection).
    /// </summary>
    /// <value>FlowID is the ID of the connection flow. Not unique because it can be the same for multiple events (e.g., start and end of the connection).</value>
    /*
    <example>61092452-b17c-4b14-b7cf-a2158c549826</example>
    */
    [JsonPropertyName("flow_id")]
    public string FlowId { get; set; }

    /// <summary>
    /// ID of the reporter of the event (e.g., the peer that reported the event).
    /// </summary>
    /// <value>ID of the reporter of the event (e.g., the peer that reported the event).</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("reporter_id")]
    public string ReporterId { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [JsonPropertyName("source")]
    public NetworkTrafficEndpoint Source { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [JsonPropertyName("destination")]
    public NetworkTrafficEndpoint Destination { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public NetworkTrafficUser User { get; set; }

    /// <summary>
    /// Gets or Sets Policy
    /// </summary>
    [JsonPropertyName("policy")]
    public NetworkTrafficPolicy Policy { get; set; }

    /// <summary>
    /// Gets or Sets Icmp
    /// </summary>
    [JsonPropertyName("icmp")]
    public NetworkTrafficICMP Icmp { get; set; }

    /// <summary>
    /// Protocol is the protocol of the traffic (e.g. 1 &#x3D; ICMP, 6 &#x3D; TCP, 17 &#x3D; UDP, etc.).
    /// </summary>
    /// <value>Protocol is the protocol of the traffic (e.g. 1 &#x3D; ICMP, 6 &#x3D; TCP, 17 &#x3D; UDP, etc.).</value>
    /*
    <example>6</example>
    */
    [JsonPropertyName("protocol")]
    public int Protocol { get; set; }

    /// <summary>
    /// Direction of the traffic (e.g. DIRECTION_UNKNOWN, INGRESS, EGRESS).
    /// </summary>
    /// <value>Direction of the traffic (e.g. DIRECTION_UNKNOWN, INGRESS, EGRESS).</value>
    /*
    <example>INGRESS</example>
    */
    [JsonPropertyName("direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Number of bytes received.
    /// </summary>
    /// <value>Number of bytes received.</value>
    /*
    <example>1234</example>
    */
    [JsonPropertyName("rx_bytes")]
    public int RxBytes { get; set; }

    /// <summary>
    /// Number of packets received.
    /// </summary>
    /// <value>Number of packets received.</value>
    /*
    <example>5</example>
    */
    [JsonPropertyName("rx_packets")]
    public int RxPackets { get; set; }

    /// <summary>
    /// Number of bytes transmitted.
    /// </summary>
    /// <value>Number of bytes transmitted.</value>
    /*
    <example>1234</example>
    */
    [JsonPropertyName("tx_bytes")]
    public int TxBytes { get; set; }

    /// <summary>
    /// Number of packets transmitted.
    /// </summary>
    /// <value>Number of packets transmitted.</value>
    /*
    <example>5</example>
    */
    [JsonPropertyName("tx_packets")]
    public int TxPackets { get; set; }

    /// <summary>
    /// List of events that are correlated to this flow (e.g., start, end).
    /// </summary>
    /// <value>List of events that are correlated to this flow (e.g., start, end).</value>
    [JsonPropertyName("events")]
    public List<NetworkTrafficSubEvent> Events { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkTrafficEvent {\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  ReporterId: ").Append(ReporterId).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  Destination: ").Append(Destination).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Policy: ").Append(Policy).Append("\n");
        sb.Append("  Icmp: ").Append(Icmp).Append("\n");
        sb.Append("  Protocol: ").Append(Protocol).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  RxBytes: ").Append(RxBytes).Append("\n");
        sb.Append("  RxPackets: ").Append(RxPackets).Append("\n");
        sb.Append("  TxBytes: ").Append(TxBytes).Append("\n");
        sb.Append("  TxPackets: ").Append(TxPackets).Append("\n");
        sb.Append("  Events: ").Append(Events).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        yield break;
    }
}