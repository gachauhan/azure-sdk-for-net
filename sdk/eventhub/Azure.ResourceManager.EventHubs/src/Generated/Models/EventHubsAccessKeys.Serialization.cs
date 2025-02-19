// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsAccessKeys
    {
        internal static EventHubsAccessKeys DeserializeEventHubsAccessKeys(JsonElement element)
        {
            Optional<string> primaryConnectionString = default;
            Optional<string> secondaryConnectionString = default;
            Optional<string> aliasPrimaryConnectionString = default;
            Optional<string> aliasSecondaryConnectionString = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> keyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryConnectionString"u8))
                {
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"u8))
                {
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliasPrimaryConnectionString"u8))
                {
                    aliasPrimaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliasSecondaryConnectionString"u8))
                {
                    aliasSecondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
            }
            return new EventHubsAccessKeys(primaryConnectionString.Value, secondaryConnectionString.Value, aliasPrimaryConnectionString.Value, aliasSecondaryConnectionString.Value, primaryKey.Value, secondaryKey.Value, keyName.Value);
        }
    }
}
