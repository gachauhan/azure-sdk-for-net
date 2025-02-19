// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LabServices;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Paged list of labs. </summary>
    internal partial class PagedLabs
    {
        /// <summary> Initializes a new instance of PagedLabs. </summary>
        internal PagedLabs()
        {
            Value = new ChangeTrackingList<LabData>();
        }

        /// <summary> Initializes a new instance of PagedLabs. </summary>
        /// <param name="value"> The array page of lab results. </param>
        /// <param name="nextLink"> The link to get the next page of image results. </param>
        internal PagedLabs(IReadOnlyList<LabData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The array page of lab results. </summary>
        public IReadOnlyList<LabData> Value { get; }
        /// <summary> The link to get the next page of image results. </summary>
        public string NextLink { get; }
    }
}
