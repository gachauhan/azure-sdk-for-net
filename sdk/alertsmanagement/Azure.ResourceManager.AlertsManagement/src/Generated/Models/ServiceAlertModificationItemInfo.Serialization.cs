// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertModificationItemInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ModificationEvent))
            {
                writer.WritePropertyName("modificationEvent"u8);
                writer.WriteStringValue(ModificationEvent.Value.ToSerialString());
            }
            if (Optional.IsDefined(OldValue))
            {
                writer.WritePropertyName("oldValue"u8);
                writer.WriteStringValue(OldValue);
            }
            if (Optional.IsDefined(NewValue))
            {
                writer.WritePropertyName("newValue"u8);
                writer.WriteStringValue(NewValue);
            }
            if (Optional.IsDefined(ModifiedAt))
            {
                writer.WritePropertyName("modifiedAt"u8);
                writer.WriteStringValue(ModifiedAt);
            }
            if (Optional.IsDefined(ModifiedBy))
            {
                writer.WritePropertyName("modifiedBy"u8);
                writer.WriteStringValue(ModifiedBy);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static ServiceAlertModificationItemInfo DeserializeServiceAlertModificationItemInfo(JsonElement element)
        {
            Optional<ServiceAlertModificationEvent> modificationEvent = default;
            Optional<string> oldValue = default;
            Optional<string> newValue = default;
            Optional<string> modifiedAt = default;
            Optional<string> modifiedBy = default;
            Optional<string> comments = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modificationEvent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modificationEvent = property.Value.GetString().ToServiceAlertModificationEvent();
                    continue;
                }
                if (property.NameEquals("oldValue"u8))
                {
                    oldValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newValue"u8))
                {
                    newValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedAt"u8))
                {
                    modifiedAt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedBy"u8))
                {
                    modifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("comments"u8))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceAlertModificationItemInfo(Optional.ToNullable(modificationEvent), oldValue.Value, newValue.Value, modifiedAt.Value, modifiedBy.Value, comments.Value, description.Value);
        }
    }
}
