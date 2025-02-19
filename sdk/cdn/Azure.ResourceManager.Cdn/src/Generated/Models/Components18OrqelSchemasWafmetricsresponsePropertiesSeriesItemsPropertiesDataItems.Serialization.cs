// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems
    {
        internal static Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(JsonElement element)
        {
            Optional<DateTimeOffset> dateTime = default;
            Optional<float> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
            }
            return new Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(Optional.ToNullable(dateTime), Optional.ToNullable(value));
        }
    }
}
