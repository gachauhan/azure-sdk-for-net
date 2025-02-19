// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppWorkloadProfileStateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MinimumCount))
            {
                writer.WritePropertyName("minimumCount"u8);
                writer.WriteNumberValue(MinimumCount.Value);
            }
            if (Optional.IsDefined(MaximumCount))
            {
                writer.WritePropertyName("maximumCount"u8);
                writer.WriteNumberValue(MaximumCount.Value);
            }
            if (Optional.IsDefined(CurrentCount))
            {
                writer.WritePropertyName("currentCount"u8);
                writer.WriteNumberValue(CurrentCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppWorkloadProfileStateProperties DeserializeContainerAppWorkloadProfileStateProperties(JsonElement element)
        {
            Optional<int> minimumCount = default;
            Optional<int> maximumCount = default;
            Optional<int> currentCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimumCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minimumCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maximumCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new ContainerAppWorkloadProfileStateProperties(Optional.ToNullable(minimumCount), Optional.ToNullable(maximumCount), Optional.ToNullable(currentCount));
        }
    }
}
