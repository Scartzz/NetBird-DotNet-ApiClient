


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
/// Identifies the type of workload the job will execute. Currently only &#x60;\&quot;bundle\&quot;&#x60; is supported. 
/// </summary>
/// <value>Identifies the type of workload the job will execute. Currently only &#x60;\&quot;bundle\&quot;&#x60; is supported. </value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WorkloadType
{
    /// <summary>
    /// Enum Bundle for value: bundle
    /// </summary>
    [EnumMember(Value = "bundle")]
    Bundle = 1
}