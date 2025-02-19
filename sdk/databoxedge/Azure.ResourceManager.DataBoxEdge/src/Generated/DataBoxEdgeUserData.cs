// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary> A class representing the DataBoxEdgeUser data model. </summary>
    public partial class DataBoxEdgeUserData : ResourceData
    {
        /// <summary> Initializes a new instance of DataBoxEdgeUserData. </summary>
        /// <param name="userType"> Type of the user. </param>
        public DataBoxEdgeUserData(DataBoxEdgeUserType userType)
        {
            ShareAccessRights = new ChangeTrackingList<ShareAccessRight>();
            UserType = userType;
        }

        /// <summary> Initializes a new instance of DataBoxEdgeUserData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="encryptedPassword"> The password details. </param>
        /// <param name="shareAccessRights"> List of shares that the user has rights on. This field should not be specified during user creation. </param>
        /// <param name="userType"> Type of the user. </param>
        internal DataBoxEdgeUserData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AsymmetricEncryptedSecret encryptedPassword, IReadOnlyList<ShareAccessRight> shareAccessRights, DataBoxEdgeUserType userType) : base(id, name, resourceType, systemData)
        {
            EncryptedPassword = encryptedPassword;
            ShareAccessRights = shareAccessRights;
            UserType = userType;
        }

        /// <summary> The password details. </summary>
        public AsymmetricEncryptedSecret EncryptedPassword { get; set; }
        /// <summary> List of shares that the user has rights on. This field should not be specified during user creation. </summary>
        public IReadOnlyList<ShareAccessRight> ShareAccessRights { get; }
        /// <summary> Type of the user. </summary>
        public DataBoxEdgeUserType UserType { get; set; }
    }
}
