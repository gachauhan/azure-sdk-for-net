// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ResourceItem
    {
        internal static ResourceItem DeserializeResourceItem(JsonElement element)
        {
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            Optional<string> resourceType = default;
            Optional<string> resourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceItem(subscriptionId.Value, resourceGroup.Value, resourceType.Value, resourceId.Value);
        }
    }
}
