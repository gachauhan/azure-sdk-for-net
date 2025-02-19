// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> An API Version Set contains the common configuration for a set of API Versions relating. </summary>
    public partial class ApiVersionSetContractDetails
    {
        /// <summary> Initializes a new instance of ApiVersionSetContractDetails. </summary>
        public ApiVersionSetContractDetails()
        {
        }

        /// <summary> Initializes a new instance of ApiVersionSetContractDetails. </summary>
        /// <param name="id"> Identifier for existing API Version Set. Omit this value to create a new Version Set. </param>
        /// <param name="name"> The display Name of the API Version Set. </param>
        /// <param name="description"> Description of API Version Set. </param>
        /// <param name="versioningScheme"> An value that determines where the API Version identifier will be located in a HTTP request. </param>
        /// <param name="versionQueryName"> Name of query parameter that indicates the API Version if versioningScheme is set to `query`. </param>
        /// <param name="versionHeaderName"> Name of HTTP header parameter that indicates the API Version if versioningScheme is set to `header`. </param>
        internal ApiVersionSetContractDetails(string id, string name, string description, VersioningScheme? versioningScheme, string versionQueryName, string versionHeaderName)
        {
            Id = id;
            Name = name;
            Description = description;
            VersioningScheme = versioningScheme;
            VersionQueryName = versionQueryName;
            VersionHeaderName = versionHeaderName;
        }

        /// <summary> Identifier for existing API Version Set. Omit this value to create a new Version Set. </summary>
        public string Id { get; set; }
        /// <summary> The display Name of the API Version Set. </summary>
        public string Name { get; set; }
        /// <summary> Description of API Version Set. </summary>
        public string Description { get; set; }
        /// <summary> An value that determines where the API Version identifier will be located in a HTTP request. </summary>
        public VersioningScheme? VersioningScheme { get; set; }
        /// <summary> Name of query parameter that indicates the API Version if versioningScheme is set to `query`. </summary>
        public string VersionQueryName { get; set; }
        /// <summary> Name of HTTP header parameter that indicates the API Version if versioningScheme is set to `header`. </summary>
        public string VersionHeaderName { get; set; }
    }
}
