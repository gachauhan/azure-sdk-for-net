// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    internal partial class CapabilityTypePropertiesRuntimeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static CapabilityTypePropertiesRuntimeProperties DeserializeCapabilityTypePropertiesRuntimeProperties(JsonElement element)
        {
            Optional<string> kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new CapabilityTypePropertiesRuntimeProperties(kind.Value);
        }
    }
}
