


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
/// Network resource type based of the address
/// </summary>
/// <value>Network resource type based of the address</value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NetworkResourceType
{
    /// <summary>
    /// Enum Host for value: host
    /// </summary>
    [EnumMember(Value = "host")]
    Host = 1,

    /// <summary>
    /// Enum Subnet for value: subnet
    /// </summary>
    [EnumMember(Value = "subnet")]
    Subnet = 2,

    /// <summary>
    /// Enum Domain for value: domain
    /// </summary>
    [EnumMember(Value = "domain")]
    Domain = 3
}