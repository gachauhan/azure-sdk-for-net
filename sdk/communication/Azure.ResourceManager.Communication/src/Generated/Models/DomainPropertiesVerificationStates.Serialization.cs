// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    public partial class DomainPropertiesVerificationStates
    {
        internal static DomainPropertiesVerificationStates DeserializeDomainPropertiesVerificationStates(JsonElement element)
        {
            Optional<DomainVerificationStatusRecord> domain = default;
            Optional<DomainVerificationStatusRecord> spf = default;
            Optional<DomainVerificationStatusRecord> dkim = default;
            Optional<DomainVerificationStatusRecord> dkiM2 = default;
            Optional<DomainVerificationStatusRecord> dmarc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Domain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    domain = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value);
                    continue;
                }
                if (property.NameEquals("SPF"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    spf = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value);
                    continue;
                }
                if (property.NameEquals("DKIM"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dkim = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value);
                    continue;
                }
                if (property.NameEquals("DKIM2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dkiM2 = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value);
                    continue;
                }
                if (property.NameEquals("DMARC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dmarc = DomainVerificationStatusRecord.DeserializeDomainVerificationStatusRecord(property.Value);
                    continue;
                }
            }
            return new DomainPropertiesVerificationStates(domain.Value, spf.Value, dkim.Value, dkiM2.Value, dmarc.Value);
        }
    }
}
