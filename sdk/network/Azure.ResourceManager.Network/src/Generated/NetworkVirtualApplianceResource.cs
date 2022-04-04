// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a NetworkVirtualAppliance along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NetworkVirtualApplianceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNetworkVirtualApplianceResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetNetworkVirtualAppliance method.
    /// </summary>
    public partial class NetworkVirtualApplianceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkVirtualApplianceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkVirtualApplianceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkVirtualApplianceClientDiagnostics;
        private readonly NetworkVirtualAppliancesRestOperations _networkVirtualApplianceRestClient;
        private readonly ClientDiagnostics _inboundSecurityRuleClientDiagnostics;
        private readonly InboundSecurityRuleRestOperations _inboundSecurityRuleRestClient;
        private readonly NetworkVirtualApplianceData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceResource"/> class for mocking. </summary>
        protected NetworkVirtualApplianceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkVirtualApplianceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkVirtualApplianceResource(ArmClient client, NetworkVirtualApplianceData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkVirtualApplianceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkVirtualApplianceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string networkVirtualApplianceApiVersion);
            _networkVirtualApplianceRestClient = new NetworkVirtualAppliancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkVirtualApplianceApiVersion);
            _inboundSecurityRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _inboundSecurityRuleRestClient = new InboundSecurityRuleRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkVirtualAppliances";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkVirtualApplianceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of VirtualApplianceSiteResources in the NetworkVirtualAppliance. </summary>
        /// <returns> An object representing collection of VirtualApplianceSiteResources and their operations over a VirtualApplianceSiteResource. </returns>
        public virtual VirtualApplianceSiteCollection GetVirtualApplianceSites()
        {
            return GetCachedClient(Client => new VirtualApplianceSiteCollection(Client, Id));
        }

        /// <summary>
        /// Gets the specified Virtual Appliance Site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_Get
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual async Task<Response<VirtualApplianceSiteResource>> GetVirtualApplianceSiteAsync(string siteName, CancellationToken cancellationToken = default)
        {
            return await GetVirtualApplianceSites().GetAsync(siteName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Virtual Appliance Site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/virtualApplianceSites/{siteName}
        /// Operation Id: VirtualApplianceSites_Get
        /// </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public virtual Response<VirtualApplianceSiteResource> GetVirtualApplianceSite(string siteName, CancellationToken cancellationToken = default)
        {
            return GetVirtualApplianceSites().Get(siteName, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Network Virtual Appliance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Get
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkVirtualApplianceResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.Get");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Network Virtual Appliance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Get
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkVirtualApplianceResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.Get");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified Network Virtual Appliance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.Delete");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_networkVirtualApplianceClientDiagnostics, Pipeline, _networkVirtualApplianceRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified Network Virtual Appliance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.Delete");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_networkVirtualApplianceClientDiagnostics, Pipeline, _networkVirtualApplianceRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the specified Network Virtual Appliance Inbound Security Rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/inboundSecurityRules/{ruleCollectionName}
        /// Operation Id: InboundSecurityRule_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleCollectionName"> The name of security rule collection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance Inbound Security Rules operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<InboundSecurityRule>> CreateOrUpdateInboundSecurityRuleAsync(WaitUntil waitUntil, string ruleCollectionName, InboundSecurityRule parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _inboundSecurityRuleClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.CreateOrUpdateInboundSecurityRule");
            scope.Start();
            try
            {
                var response = await _inboundSecurityRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<InboundSecurityRule>(new InboundSecurityRuleOperationSource(), _inboundSecurityRuleClientDiagnostics, Pipeline, _inboundSecurityRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the specified Network Virtual Appliance Inbound Security Rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/inboundSecurityRules/{ruleCollectionName}
        /// Operation Id: InboundSecurityRule_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleCollectionName"> The name of security rule collection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance Inbound Security Rules operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<InboundSecurityRule> CreateOrUpdateInboundSecurityRule(WaitUntil waitUntil, string ruleCollectionName, InboundSecurityRule parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _inboundSecurityRuleClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.CreateOrUpdateInboundSecurityRule");
            scope.Start();
            try
            {
                var response = _inboundSecurityRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<InboundSecurityRule>(new InboundSecurityRuleOperationSource(), _inboundSecurityRuleClientDiagnostics, Pipeline, _inboundSecurityRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleCollectionName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<NetworkVirtualApplianceResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkVirtualApplianceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkVirtualApplianceResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<NetworkVirtualApplianceResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkVirtualApplianceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkVirtualApplianceResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<NetworkVirtualApplianceResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkVirtualApplianceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkVirtualApplianceResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<NetworkVirtualApplianceResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkVirtualApplianceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkVirtualApplianceResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<NetworkVirtualApplianceResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkVirtualApplianceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkVirtualApplianceResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}
        /// Operation Id: NetworkVirtualAppliances_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<NetworkVirtualApplianceResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _networkVirtualApplianceClientDiagnostics.CreateScope("NetworkVirtualApplianceResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkVirtualApplianceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkVirtualApplianceResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
