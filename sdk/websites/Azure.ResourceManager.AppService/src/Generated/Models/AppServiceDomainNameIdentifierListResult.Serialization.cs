// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class AppServiceDomainNameIdentifierListResult
    {
        internal static AppServiceDomainNameIdentifierListResult DeserializeAppServiceDomainNameIdentifierListResult(JsonElement element)
        {
            IReadOnlyList<AppServiceDomainNameIdentifier> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<AppServiceDomainNameIdentifier> array = new List<AppServiceDomainNameIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceDomainNameIdentifier.DeserializeAppServiceDomainNameIdentifier(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AppServiceDomainNameIdentifierListResult(value, nextLink.Value);
        }
    }
}
