

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

namespace NetBird.ApiClient.Client;

/// <summary>
/// Formatter for 'date' openapi formats as defined by full-date - RFC3339
/// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
/// </summary>
internal class OpenAPIDateConverter : JsonConverter<DateTime>
{
    private readonly string _format = "yyyy-MM-dd";

    /// <summary>
    /// Reads the JSON as a DateTime.
    /// </summary>
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTime.ParseExact(reader.GetString(), _format, CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Writes the DateTime as JSON.
    /// </summary>
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(_format, CultureInfo.InvariantCulture));
    }
}