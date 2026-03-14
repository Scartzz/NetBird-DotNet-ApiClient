


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
/// DNS record type
/// </summary>
/// <value>DNS record type</value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DNSRecordType
{
    /// <summary>
    /// Enum A for value: A
    /// </summary>
    [EnumMember(Value = "A")]
    A = 1,

    /// <summary>
    /// Enum AAAA for value: AAAA
    /// </summary>
    [EnumMember(Value = "AAAA")]
    AAAA = 2,

    /// <summary>
    /// Enum CNAME for value: CNAME
    /// </summary>
    [EnumMember(Value = "CNAME")]
    CNAME = 3
}