// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class DenyAssignmentData
    {
        internal static DenyAssignmentData DeserializeDenyAssignmentData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> denyAssignmentName = default;
            Optional<string> description = default;
            Optional<IReadOnlyList<DenyAssignmentPermission>> permissions = default;
            Optional<string> scope = default;
            Optional<bool> doNotApplyToChildScopes = default;
            Optional<IReadOnlyList<RoleManagementPrincipal>> principals = default;
            Optional<IReadOnlyList<RoleManagementPrincipal>> excludePrincipals = default;
            Optional<bool> isSystemProtected = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("denyAssignmentName"u8))
                        {
                            denyAssignmentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("permissions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DenyAssignmentPermission> array = new List<DenyAssignmentPermission>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DenyAssignmentPermission.DeserializeDenyAssignmentPermission(item));
                            }
                            permissions = array;
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("doNotApplyToChildScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            doNotApplyToChildScopes = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("principals"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RoleManagementPrincipal> array = new List<RoleManagementPrincipal>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoleManagementPrincipal.DeserializeRoleManagementPrincipal(item));
                            }
                            principals = array;
                            continue;
                        }
                        if (property0.NameEquals("excludePrincipals"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RoleManagementPrincipal> array = new List<RoleManagementPrincipal>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoleManagementPrincipal.DeserializeRoleManagementPrincipal(item));
                            }
                            excludePrincipals = array;
                            continue;
                        }
                        if (property0.NameEquals("isSystemProtected"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isSystemProtected = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DenyAssignmentData(id, name, type, systemData.Value, denyAssignmentName.Value, description.Value, Optional.ToList(permissions), scope.Value, Optional.ToNullable(doNotApplyToChildScopes), Optional.ToList(principals), Optional.ToList(excludePrincipals), Optional.ToNullable(isSystemProtected));
        }
    }
}
