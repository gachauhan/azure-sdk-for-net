// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppCustomPersistentDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomPersistentDiskProperties))
            {
                writer.WritePropertyName("customPersistentDiskProperties"u8);
                writer.WriteObjectValue(CustomPersistentDiskProperties);
            }
            writer.WritePropertyName("storageId"u8);
            writer.WriteStringValue(StorageId);
            writer.WriteEndObject();
        }

        internal static AppCustomPersistentDisk DeserializeAppCustomPersistentDisk(JsonElement element)
        {
            Optional<AppCustomPersistentDiskProperties> customPersistentDiskProperties = default;
            string storageId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customPersistentDiskProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customPersistentDiskProperties = AppCustomPersistentDiskProperties.DeserializeAppCustomPersistentDiskProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("storageId"u8))
                {
                    storageId = property.Value.GetString();
                    continue;
                }
            }
            return new AppCustomPersistentDisk(customPersistentDiskProperties.Value, storageId);
        }
    }
}
