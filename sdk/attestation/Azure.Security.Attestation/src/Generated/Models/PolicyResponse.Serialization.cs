// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.Attestation
{
    internal partial class PolicyResponse
    {
        internal static PolicyResponse DeserializePolicyResponse(JsonElement element)
        {
            Optional<string> token = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyResponse(token.Value);
        }
    }
}
