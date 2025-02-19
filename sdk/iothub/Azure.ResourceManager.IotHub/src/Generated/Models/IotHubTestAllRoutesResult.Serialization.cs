// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubTestAllRoutesResult
    {
        internal static IotHubTestAllRoutesResult DeserializeIotHubTestAllRoutesResult(JsonElement element)
        {
            Optional<IReadOnlyList<IotHubMatchedRoute>> routes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IotHubMatchedRoute> array = new List<IotHubMatchedRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubMatchedRoute.DeserializeIotHubMatchedRoute(item));
                    }
                    routes = array;
                    continue;
                }
            }
            return new IotHubTestAllRoutesResult(Optional.ToList(routes));
        }
    }
}
