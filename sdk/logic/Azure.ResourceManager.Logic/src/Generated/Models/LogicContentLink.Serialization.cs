// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicContentLink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static LogicContentLink DeserializeLogicContentLink(JsonElement element)
        {
            Optional<Uri> uri = default;
            Optional<string> contentVersion = default;
            Optional<long> contentSize = default;
            Optional<LogicContentHash> contentHash = default;
            Optional<BinaryData> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentVersion"u8))
                {
                    contentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    contentSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("contentHash"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    contentHash = LogicContentHash.DeserializeLogicContentHash(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new LogicContentLink(uri.Value, contentVersion.Value, Optional.ToNullable(contentSize), contentHash.Value, metadata.Value);
        }
    }
}
