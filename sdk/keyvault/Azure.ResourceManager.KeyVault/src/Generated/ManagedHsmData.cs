// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing the ManagedHsm data model. </summary>
    public partial class ManagedHsmData : Models.ManagedHsmResource
    {
        /// <summary> Initializes a new instance of ManagedHsmData. </summary>
        /// <param name="location"> The location. </param>
        public ManagedHsmData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ManagedHsmData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="properties"> Properties of the managed HSM. </param>
        internal ManagedHsmData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedHsmSku sku, ManagedHsmProperties properties) : base(id, name, resourceType, systemData, tags, location, sku)
        {
            Properties = properties;
        }

        /// <summary> Properties of the managed HSM. </summary>
        public ManagedHsmProperties Properties { get; set; }
    }
}
