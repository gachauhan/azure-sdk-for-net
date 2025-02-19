// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Maintenance;

namespace Azure.ResourceManager.Maintenance.Models
{
    internal partial class MaintenanceApplyUpdateListResult
    {
        internal static MaintenanceApplyUpdateListResult DeserializeMaintenanceApplyUpdateListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MaintenanceApplyUpdateData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MaintenanceApplyUpdateData> array = new List<MaintenanceApplyUpdateData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceApplyUpdateData.DeserializeMaintenanceApplyUpdateData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MaintenanceApplyUpdateListResult(Optional.ToList(value));
        }
    }
}
