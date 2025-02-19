// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsMailClusterEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SecurityInsightsMailClusterEntity DeserializeSecurityInsightsMailClusterEntity(JsonElement element)
        {
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<IReadOnlyList<string>> networkMessageIds = default;
            Optional<BinaryData> countByDeliveryStatus = default;
            Optional<BinaryData> countByThreatType = default;
            Optional<BinaryData> countByProtectionStatus = default;
            Optional<IReadOnlyList<string>> threats = default;
            Optional<string> query = default;
            Optional<DateTimeOffset> queryTime = default;
            Optional<int> mailCount = default;
            Optional<bool> isVolumeAnomaly = default;
            Optional<string> source = default;
            Optional<string> clusterSourceIdentifier = default;
            Optional<string> clusterSourceType = default;
            Optional<DateTimeOffset> clusterQueryStartTime = default;
            Optional<DateTimeOffset> clusterQueryEndTime = default;
            Optional<string> clusterGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkMessageIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            networkMessageIds = array;
                            continue;
                        }
                        if (property0.NameEquals("countByDeliveryStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            countByDeliveryStatus = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("countByThreatType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            countByThreatType = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("countByProtectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            countByProtectionStatus = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("threats"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            threats = array;
                            continue;
                        }
                        if (property0.NameEquals("query"u8))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("mailCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mailCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isVolumeAnomaly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isVolumeAnomaly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterSourceIdentifier"u8))
                        {
                            clusterSourceIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterSourceType"u8))
                        {
                            clusterSourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterQueryStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterQueryStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("clusterQueryEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterQueryEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("clusterGroup"u8))
                        {
                            clusterGroup = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SecurityInsightsMailClusterEntity(id, name, type, systemData.Value, kind, Optional.ToDictionary(additionalData), friendlyName.Value, Optional.ToList(networkMessageIds), countByDeliveryStatus.Value, countByThreatType.Value, countByProtectionStatus.Value, Optional.ToList(threats), query.Value, Optional.ToNullable(queryTime), Optional.ToNullable(mailCount), Optional.ToNullable(isVolumeAnomaly), source.Value, clusterSourceIdentifier.Value, clusterSourceType.Value, Optional.ToNullable(clusterQueryStartTime), Optional.ToNullable(clusterQueryEndTime), clusterGroup.Value);
        }
    }
}
