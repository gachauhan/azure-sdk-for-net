// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    internal partial class RedisEnterprisePrivateLinkResourceListResult
    {
        internal static RedisEnterprisePrivateLinkResourceListResult DeserializeRedisEnterprisePrivateLinkResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RedisEnterprisePrivateLinkResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RedisEnterprisePrivateLinkResource> array = new List<RedisEnterprisePrivateLinkResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RedisEnterprisePrivateLinkResource.DeserializeRedisEnterprisePrivateLinkResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RedisEnterprisePrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}
