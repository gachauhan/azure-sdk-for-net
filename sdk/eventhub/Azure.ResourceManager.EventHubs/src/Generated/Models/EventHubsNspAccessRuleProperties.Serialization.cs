// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsNspAccessRuleProperties
    {
        internal static EventHubsNspAccessRuleProperties DeserializeEventHubsNspAccessRuleProperties(JsonElement element)
        {
            Optional<EventHubsNspAccessRuleDirection> direction = default;
            Optional<IReadOnlyList<string>> addressPrefixes = default;
            Optional<IReadOnlyList<SubResource>> subscriptions = default;
            Optional<IReadOnlyList<EventHubsNetworkSecurityPerimeter>> networkSecurityPerimeters = default;
            Optional<IReadOnlyList<string>> fullyQualifiedDomainNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("direction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    direction = new EventHubsNspAccessRuleDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("networkSecurityPerimeters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EventHubsNetworkSecurityPerimeter> array = new List<EventHubsNetworkSecurityPerimeter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsNetworkSecurityPerimeter.DeserializeEventHubsNetworkSecurityPerimeter(item));
                    }
                    networkSecurityPerimeters = array;
                    continue;
                }
                if (property.NameEquals("fullyQualifiedDomainNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fullyQualifiedDomainNames = array;
                    continue;
                }
            }
            return new EventHubsNspAccessRuleProperties(Optional.ToNullable(direction), Optional.ToList(addressPrefixes), Optional.ToList(subscriptions), Optional.ToList(networkSecurityPerimeters), Optional.ToList(fullyQualifiedDomainNames));
        }
    }
}
