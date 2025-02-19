// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceNetworking.Models;

namespace Azure.ResourceManager.ServiceNetworking
{
    /// <summary> A class representing the TrafficController data model. </summary>
    public partial class TrafficControllerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of TrafficControllerData. </summary>
        /// <param name="location"> The location. </param>
        public TrafficControllerData(AzureLocation location) : base(location)
        {
            ConfigurationEndpoints = new ChangeTrackingList<string>();
            Frontends = new ChangeTrackingList<SubResource>();
            Associations = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of TrafficControllerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="configurationEndpoints"> Configuration Endpoints. </param>
        /// <param name="frontends"> Frontends References List. </param>
        /// <param name="associations"> Associations References List. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        internal TrafficControllerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IReadOnlyList<string> configurationEndpoints, IReadOnlyList<SubResource> frontends, IReadOnlyList<SubResource> associations, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ConfigurationEndpoints = configurationEndpoints;
            Frontends = frontends;
            Associations = associations;
            ProvisioningState = provisioningState;
        }

        /// <summary> Configuration Endpoints. </summary>
        public IReadOnlyList<string> ConfigurationEndpoints { get; }
        /// <summary> Frontends References List. </summary>
        public IReadOnlyList<SubResource> Frontends { get; }
        /// <summary> Associations References List. </summary>
        public IReadOnlyList<SubResource> Associations { get; }
        /// <summary> The status of the last operation. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
