// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ContinentsResponseContinentsItem
    {
        internal static ContinentsResponseContinentsItem DeserializeContinentsResponseContinentsItem(JsonElement element)
        {
            Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ContinentsResponseContinentsItem(id.Value);
        }
    }
}
