// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterPodIdentityProvisioningInfo
    {
        internal static ManagedClusterPodIdentityProvisioningInfo DeserializeManagedClusterPodIdentityProvisioningInfo(JsonElement element)
        {
            Optional<ManagedClusterPodIdentityProvisioningError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ManagedClusterPodIdentityProvisioningError.DeserializeManagedClusterPodIdentityProvisioningError(property.Value);
                    continue;
                }
            }
            return new ManagedClusterPodIdentityProvisioningInfo(error.Value);
        }
    }
}
