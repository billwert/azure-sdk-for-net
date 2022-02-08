// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The domain JSON object required for domain creation or update. </summary>
    public partial class AfdCustomDomainUpdateOptions
    {
        /// <summary> Initializes a new instance of AfdCustomDomainUpdateOptions. </summary>
        public AfdCustomDomainUpdateOptions()
        {
        }

        /// <summary> The name of the profile which holds the domain. </summary>
        public string ProfileName { get; }
        /// <summary> The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user&apos;s own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default. </summary>
        public AfdCustomDomainHttpsParameters TlsSettings { get; set; }
        /// <summary> Resource reference to the Azure DNS zone. </summary>
        public WritableSubResource AzureDnsZone { get; set; }
        /// <summary> Resource reference to the Azure resource where custom domain ownership was prevalidated. </summary>
        public AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId PreValidatedCustomDomainResourceId { get; set; }
    }
}
