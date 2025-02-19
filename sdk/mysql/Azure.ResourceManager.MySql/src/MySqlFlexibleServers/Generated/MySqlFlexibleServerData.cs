// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary> A class representing the MySqlFlexibleServer data model. </summary>
    public partial class MySqlFlexibleServerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerData. </summary>
        /// <param name="location"> The location. </param>
        public MySqlFlexibleServerData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The cmk identity for the server. Current supported identity types: UserAssigned. </param>
        /// <param name="sku"> The SKU (pricing tier) of the server. </param>
        /// <param name="administratorLogin"> The administrator&apos;s login name of a server. Can only be specified when the server is being created (and is required for creation). </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login (required for server creation). </param>
        /// <param name="version"> Server version. </param>
        /// <param name="availabilityZone"> availability Zone information of the server. </param>
        /// <param name="createMode"> The mode to create a new MySQL server. </param>
        /// <param name="sourceServerResourceId"> The source MySQL server id. </param>
        /// <param name="restorePointInTime"> Restore point creation time (ISO8601 format), specifying the time to restore from. </param>
        /// <param name="replicationRole"> The replication role. </param>
        /// <param name="replicaCapacity"> The maximum number of replicas that a primary server can have. </param>
        /// <param name="dataEncryption"> The Data Encryption for CMK. </param>
        /// <param name="state"> The state of a server. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        /// <param name="storage"> Storage related properties of a server. </param>
        /// <param name="backup"> Backup related properties of a server. </param>
        /// <param name="highAvailability"> High availability related properties of a server. </param>
        /// <param name="network"> Network related properties of a server. </param>
        /// <param name="maintenanceWindow"> Maintenance window of a server. </param>
        internal MySqlFlexibleServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, MySqlFlexibleServerSku sku, string administratorLogin, string administratorLoginPassword, MySqlFlexibleServerVersion? version, string availabilityZone, MySqlFlexibleServerCreateMode? createMode, ResourceIdentifier sourceServerResourceId, DateTimeOffset? restorePointInTime, MySqlFlexibleServerReplicationRole? replicationRole, int? replicaCapacity, MySqlFlexibleServerDataEncryption dataEncryption, MySqlFlexibleServerState? state, string fullyQualifiedDomainName, MySqlFlexibleServerStorage storage, MySqlFlexibleServerBackupProperties backup, MySqlFlexibleServerHighAvailability highAvailability, MySqlFlexibleServerNetwork network, MySqlFlexibleServerMaintenanceWindow maintenanceWindow) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            AvailabilityZone = availabilityZone;
            CreateMode = createMode;
            SourceServerResourceId = sourceServerResourceId;
            RestorePointInTime = restorePointInTime;
            ReplicationRole = replicationRole;
            ReplicaCapacity = replicaCapacity;
            DataEncryption = dataEncryption;
            State = state;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            Storage = storage;
            Backup = backup;
            HighAvailability = highAvailability;
            Network = network;
            MaintenanceWindow = maintenanceWindow;
        }

        /// <summary> The cmk identity for the server. Current supported identity types: UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The SKU (pricing tier) of the server. </summary>
        public MySqlFlexibleServerSku Sku { get; set; }
        /// <summary> The administrator&apos;s login name of a server. Can only be specified when the server is being created (and is required for creation). </summary>
        public string AdministratorLogin { get; set; }
        /// <summary> The password of the administrator login (required for server creation). </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> Server version. </summary>
        public MySqlFlexibleServerVersion? Version { get; set; }
        /// <summary> availability Zone information of the server. </summary>
        public string AvailabilityZone { get; set; }
        /// <summary> The mode to create a new MySQL server. </summary>
        public MySqlFlexibleServerCreateMode? CreateMode { get; set; }
        /// <summary> The source MySQL server id. </summary>
        public ResourceIdentifier SourceServerResourceId { get; set; }
        /// <summary> Restore point creation time (ISO8601 format), specifying the time to restore from. </summary>
        public DateTimeOffset? RestorePointInTime { get; set; }
        /// <summary> The replication role. </summary>
        public MySqlFlexibleServerReplicationRole? ReplicationRole { get; set; }
        /// <summary> The maximum number of replicas that a primary server can have. </summary>
        public int? ReplicaCapacity { get; }
        /// <summary> The Data Encryption for CMK. </summary>
        public MySqlFlexibleServerDataEncryption DataEncryption { get; set; }
        /// <summary> The state of a server. </summary>
        public MySqlFlexibleServerState? State { get; }
        /// <summary> The fully qualified domain name of a server. </summary>
        public string FullyQualifiedDomainName { get; }
        /// <summary> Storage related properties of a server. </summary>
        public MySqlFlexibleServerStorage Storage { get; set; }
        /// <summary> Backup related properties of a server. </summary>
        public MySqlFlexibleServerBackupProperties Backup { get; set; }
        /// <summary> High availability related properties of a server. </summary>
        public MySqlFlexibleServerHighAvailability HighAvailability { get; set; }
        /// <summary> Network related properties of a server. </summary>
        public MySqlFlexibleServerNetwork Network { get; set; }
        /// <summary> Maintenance window of a server. </summary>
        public MySqlFlexibleServerMaintenanceWindow MaintenanceWindow { get; set; }
    }
}
