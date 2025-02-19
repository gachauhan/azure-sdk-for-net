// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    public partial class EndpointBaseProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static EndpointBaseProperties DeserializeEndpointBaseProperties(JsonElement element)
        {
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureStorageBlobContainer": return AzureStorageBlobContainerEndpointProperties.DeserializeAzureStorageBlobContainerEndpointProperties(element);
                    case "NfsMount": return NfsMountEndpointProperties.DeserializeNfsMountEndpointProperties(element);
                }
            }
            return UnknownEndpointBaseProperties.DeserializeUnknownEndpointBaseProperties(element);
        }
    }
}
