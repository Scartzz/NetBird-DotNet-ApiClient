


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
/// Type of identity provider
/// </summary>
/// <value>Type of identity provider</value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum IdentityProviderType
{
    /// <summary>
    /// Enum Oidc for value: oidc
    /// </summary>
    [EnumMember(Value = "oidc")]
    Oidc = 1,

    /// <summary>
    /// Enum Zitadel for value: zitadel
    /// </summary>
    [EnumMember(Value = "zitadel")]
    Zitadel = 2,

    /// <summary>
    /// Enum Entra for value: entra
    /// </summary>
    [EnumMember(Value = "entra")]
    Entra = 3,

    /// <summary>
    /// Enum Google for value: google
    /// </summary>
    [EnumMember(Value = "google")]
    Google = 4,

    /// <summary>
    /// Enum Okta for value: okta
    /// </summary>
    [EnumMember(Value = "okta")]
    Okta = 5,

    /// <summary>
    /// Enum Pocketid for value: pocketid
    /// </summary>
    [EnumMember(Value = "pocketid")]
    Pocketid = 6,

    /// <summary>
    /// Enum Microsoft for value: microsoft
    /// </summary>
    [EnumMember(Value = "microsoft")]
    Microsoft = 7
}