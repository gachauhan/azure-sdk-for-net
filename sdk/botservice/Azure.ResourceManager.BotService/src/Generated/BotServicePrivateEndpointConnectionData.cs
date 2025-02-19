// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.BotService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.BotService
{
    /// <summary> A class representing the BotServicePrivateEndpointConnection data model. </summary>
    public partial class BotServicePrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of BotServicePrivateEndpointConnectionData. </summary>
        public BotServicePrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of BotServicePrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        internal BotServicePrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubResource privateEndpoint, BotServicePrivateLinkServiceConnectionState connectionState, BotServicePrivateEndpointConnectionProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The resource of private end point. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public BotServicePrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public BotServicePrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
