// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisWorkspaceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static HealthcareApisWorkspaceProperties DeserializeHealthcareApisWorkspaceProperties(JsonElement element)
        {
            Optional<HealthcareApisProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<HealthcareApisPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<HealthcareApisPublicNetworkAccess> publicNetworkAccess = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new HealthcareApisProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HealthcareApisPrivateEndpointConnectionData> array = new List<HealthcareApisPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicNetworkAccess = new HealthcareApisPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
            }
            return new HealthcareApisWorkspaceProperties(Optional.ToNullable(provisioningState), Optional.ToList(privateEndpointConnections), Optional.ToNullable(publicNetworkAccess));
        }
    }
}
