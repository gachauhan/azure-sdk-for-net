// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SqlScriptConverter))]
    public partial class SqlScript : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WritePropertyName("content"u8);
            writer.WriteObjectValue(Content);
            if (Optional.IsDefined(Folder))
            {
                if (Folder != null)
                {
                    writer.WritePropertyName("folder"u8);
                    writer.WriteObjectValue(Folder);
                }
                else
                {
                    writer.WriteNull("folder");
                }
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SqlScript DeserializeSqlScript(JsonElement element)
        {
            Optional<string> description = default;
            Optional<SqlScriptType> type = default;
            SqlScriptContent content = default;
            Optional<SqlScriptFolder> folder = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new SqlScriptType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = SqlScriptContent.DeserializeSqlScriptContent(property.Value);
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        folder = null;
                        continue;
                    }
                    folder = SqlScriptFolder.DeserializeSqlScriptFolder(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SqlScript(description.Value, Optional.ToNullable(type), content, folder.Value, additionalProperties);
        }

        internal partial class SqlScriptConverter : JsonConverter<SqlScript>
        {
            public override void Write(Utf8JsonWriter writer, SqlScript model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SqlScript Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSqlScript(document.RootElement);
            }
        }
    }
}
