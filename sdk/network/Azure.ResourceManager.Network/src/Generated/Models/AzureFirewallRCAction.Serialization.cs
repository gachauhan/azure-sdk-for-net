// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class AzureFirewallRCAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ActionType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AzureFirewallRCAction DeserializeAzureFirewallRCAction(JsonElement element)
        {
            Optional<AzureFirewallRCActionType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new AzureFirewallRCActionType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureFirewallRCAction(Optional.ToNullable(type));
        }
    }
}
