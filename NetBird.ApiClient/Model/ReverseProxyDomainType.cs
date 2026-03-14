


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
/// Type of Reverse Proxy Domain
/// </summary>
/// <value>Type of Reverse Proxy Domain</value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ReverseProxyDomainType
{
    /// <summary>
    /// Enum Free for value: free
    /// </summary>
    [EnumMember(Value = "free")]
    Free = 1,

    /// <summary>
    /// Enum Custom for value: custom
    /// </summary>
    [EnumMember(Value = "custom")]
    Custom = 2
}