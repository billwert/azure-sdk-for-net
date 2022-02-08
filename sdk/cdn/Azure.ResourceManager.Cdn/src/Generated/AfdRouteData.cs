// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the AfdRoute data model. </summary>
    public partial class AfdRouteData : Resource
    {
        /// <summary> Initializes a new instance of AfdRouteData. </summary>
        public AfdRouteData()
        {
            CustomDomains = new ChangeTrackingList<ActivatedResourceReference>();
            RuleSets = new ChangeTrackingList<WritableSubResource>();
            SupportedProtocols = new ChangeTrackingList<AfdEndpointProtocols>();
            PatternsToMatch = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AfdRouteData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="endpointName"> The name of the endpoint which holds the route. </param>
        /// <param name="customDomains"> Domains referenced by this endpoint. </param>
        /// <param name="originGroup"> A reference to the origin group. </param>
        /// <param name="originPath"> A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </param>
        /// <param name="ruleSets"> rule sets referenced by this endpoint. </param>
        /// <param name="supportedProtocols"> List of supported protocols for this route. </param>
        /// <param name="patternsToMatch"> The route patterns of the rule. </param>
        /// <param name="cacheConfiguration"> The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object. </param>
        /// <param name="forwardingProtocol"> Protocol this rule will use when forwarding traffic to backends. </param>
        /// <param name="linkToDefaultDomain"> whether this route will be linked to the default endpoint domain. </param>
        /// <param name="httpsRedirect"> Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed. </param>
        /// <param name="enabledState"> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        internal AfdRouteData(ResourceIdentifier id, string name, Azure.Core.ResourceType type, SystemData systemData, string endpointName, IList<ActivatedResourceReference> customDomains, WritableSubResource originGroup, string originPath, IList<WritableSubResource> ruleSets, IList<AfdEndpointProtocols> supportedProtocols, IList<string> patternsToMatch, AfdRouteCacheConfiguration cacheConfiguration, ForwardingProtocol? forwardingProtocol, LinkToDefaultDomain? linkToDefaultDomain, HttpsRedirect? httpsRedirect, EnabledState? enabledState, AfdProvisioningState? provisioningState, DeploymentStatus? deploymentStatus) : base(id, name, type, systemData)
        {
            EndpointName = endpointName;
            CustomDomains = customDomains;
            OriginGroup = originGroup;
            OriginPath = originPath;
            RuleSets = ruleSets;
            SupportedProtocols = supportedProtocols;
            PatternsToMatch = patternsToMatch;
            CacheConfiguration = cacheConfiguration;
            ForwardingProtocol = forwardingProtocol;
            LinkToDefaultDomain = linkToDefaultDomain;
            HttpsRedirect = httpsRedirect;
            EnabledState = enabledState;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
        }

        /// <summary> The name of the endpoint which holds the route. </summary>
        public string EndpointName { get; }
        /// <summary> Domains referenced by this endpoint. </summary>
        public IList<ActivatedResourceReference> CustomDomains { get; }
        /// <summary> A reference to the origin group. </summary>
        public WritableSubResource OriginGroup { get; set; }
        /// <summary> A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </summary>
        public string OriginPath { get; set; }
        /// <summary> rule sets referenced by this endpoint. </summary>
        public IList<WritableSubResource> RuleSets { get; }
        /// <summary> List of supported protocols for this route. </summary>
        public IList<AfdEndpointProtocols> SupportedProtocols { get; }
        /// <summary> The route patterns of the rule. </summary>
        public IList<string> PatternsToMatch { get; }
        /// <summary> The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object. </summary>
        public AfdRouteCacheConfiguration CacheConfiguration { get; set; }
        /// <summary> Protocol this rule will use when forwarding traffic to backends. </summary>
        public ForwardingProtocol? ForwardingProtocol { get; set; }
        /// <summary> whether this route will be linked to the default endpoint domain. </summary>
        public LinkToDefaultDomain? LinkToDefaultDomain { get; set; }
        /// <summary> Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed. </summary>
        public HttpsRedirect? HttpsRedirect { get; set; }
        /// <summary> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public EnabledState? EnabledState { get; set; }
        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public DeploymentStatus? DeploymentStatus { get; }
    }
}
