// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsCommitment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Grain))
            {
                writer.WritePropertyName("grain"u8);
                writer.WriteStringValue(Grain.Value.ToString());
            }
            if (Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
            }
            writer.WriteEndObject();
        }

        internal static BillingBenefitsCommitment DeserializeBillingBenefitsCommitment(JsonElement element)
        {
            Optional<BillingBenefitsCommitmentGrain> grain = default;
            Optional<string> currencyCode = default;
            Optional<double> amount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("grain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    grain = new BillingBenefitsCommitmentGrain(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    amount = property.Value.GetDouble();
                    continue;
                }
            }
            return new BillingBenefitsCommitment(currencyCode.Value, Optional.ToNullable(amount), Optional.ToNullable(grain));
        }
    }
}
