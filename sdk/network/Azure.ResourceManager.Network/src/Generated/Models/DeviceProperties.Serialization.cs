// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class DeviceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceVendor))
            {
                writer.WritePropertyName("deviceVendor"u8);
                writer.WriteStringValue(DeviceVendor);
            }
            if (Optional.IsDefined(DeviceModel))
            {
                writer.WritePropertyName("deviceModel"u8);
                writer.WriteStringValue(DeviceModel);
            }
            if (Optional.IsDefined(LinkSpeedInMbps))
            {
                writer.WritePropertyName("linkSpeedInMbps"u8);
                writer.WriteNumberValue(LinkSpeedInMbps.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeviceProperties DeserializeDeviceProperties(JsonElement element)
        {
            Optional<string> deviceVendor = default;
            Optional<string> deviceModel = default;
            Optional<int> linkSpeedInMbps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceVendor"u8))
                {
                    deviceVendor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceModel"u8))
                {
                    deviceModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkSpeedInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linkSpeedInMbps = property.Value.GetInt32();
                    continue;
                }
            }
            return new DeviceProperties(deviceVendor.Value, deviceModel.Value, Optional.ToNullable(linkSpeedInMbps));
        }
    }
}
