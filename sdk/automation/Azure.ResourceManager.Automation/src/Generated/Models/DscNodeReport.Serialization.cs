// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscNodeReport
    {
        internal static DscNodeReport DeserializeDscNodeReport(JsonElement element)
        {
            Optional<DateTimeOffset?> endTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<DateTimeOffset?> startTime = default;
            Optional<string> type = default;
            Optional<string> reportId = default;
            Optional<string> status = default;
            Optional<string> refreshMode = default;
            Optional<string> rebootRequested = default;
            Optional<string> reportFormatVersion = default;
            Optional<string> configurationVersion = default;
            Optional<string> id = default;
            Optional<IReadOnlyList<DscReportError>> errors = default;
            Optional<IReadOnlyList<DscReportResource>> resources = default;
            Optional<DscMetaConfiguration> metaConfiguration = default;
            Optional<string> hostName = default;
            Optional<IReadOnlyList<string>> ipV4Addresses = default;
            Optional<IReadOnlyList<string>> ipV6Addresses = default;
            Optional<int> numberOfResources = default;
            Optional<string> rawErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportId"u8))
                {
                    reportId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshMode"u8))
                {
                    refreshMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rebootRequested"u8))
                {
                    rebootRequested = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportFormatVersion"u8))
                {
                    reportFormatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationVersion"u8))
                {
                    configurationVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DscReportError> array = new List<DscReportError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportError.DeserializeDscReportError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DscReportResource> array = new List<DscReportResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportResource.DeserializeDscReportResource(item));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("metaConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metaConfiguration = DscMetaConfiguration.DeserializeDscMetaConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iPV4Addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipV4Addresses = array;
                    continue;
                }
                if (property.NameEquals("iPV6Addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipV6Addresses = array;
                    continue;
                }
                if (property.NameEquals("numberOfResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numberOfResources = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rawErrors"u8))
                {
                    rawErrors = property.Value.GetString();
                    continue;
                }
            }
            return new DscNodeReport(Optional.ToNullable(endTime), Optional.ToNullable(lastModifiedTime), Optional.ToNullable(startTime), type.Value, reportId.Value, status.Value, refreshMode.Value, rebootRequested.Value, reportFormatVersion.Value, configurationVersion.Value, id.Value, Optional.ToList(errors), Optional.ToList(resources), metaConfiguration.Value, hostName.Value, Optional.ToList(ipV4Addresses), Optional.ToList(ipV6Addresses), Optional.ToNullable(numberOfResources), rawErrors.Value);
        }
    }
}
