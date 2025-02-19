// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class RectangularWindow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Left))
            {
                writer.WritePropertyName("left"u8);
                writer.WriteStringValue(Left);
            }
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteStringValue(Top);
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width"u8);
                writer.WriteStringValue(Width);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height"u8);
                writer.WriteStringValue(Height);
            }
            writer.WriteEndObject();
        }

        internal static RectangularWindow DeserializeRectangularWindow(JsonElement element)
        {
            Optional<string> left = default;
            Optional<string> top = default;
            Optional<string> width = default;
            Optional<string> height = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("left"u8))
                {
                    left = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("top"u8))
                {
                    top = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    height = property.Value.GetString();
                    continue;
                }
            }
            return new RectangularWindow(left.Value, top.Value, width.Value, height.Value);
        }
    }
}
