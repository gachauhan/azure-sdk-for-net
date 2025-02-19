// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class VirtualMachineRunCommandsListResult
    {
        internal static VirtualMachineRunCommandsListResult DeserializeVirtualMachineRunCommandsListResult(JsonElement element)
        {
            IReadOnlyList<VirtualMachineRunCommandData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<VirtualMachineRunCommandData> array = new List<VirtualMachineRunCommandData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineRunCommandData.DeserializeVirtualMachineRunCommandData(item));
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
            return new VirtualMachineRunCommandsListResult(value, nextLink.Value);
        }
    }
}
