// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubTestRouteResultDetails
    {
        internal static IotHubTestRouteResultDetails DeserializeIotHubTestRouteResultDetails(JsonElement element)
        {
            Optional<IReadOnlyList<RouteCompilationError>> compilationErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compilationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RouteCompilationError> array = new List<RouteCompilationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteCompilationError.DeserializeRouteCompilationError(item));
                    }
                    compilationErrors = array;
                    continue;
                }
            }
            return new IotHubTestRouteResultDetails(Optional.ToList(compilationErrors));
        }
    }
}
