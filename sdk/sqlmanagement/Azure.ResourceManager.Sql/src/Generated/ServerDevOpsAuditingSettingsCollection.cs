// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ServerDevOpsAuditingSettingsResource" /> and their operations.
    /// Each <see cref="ServerDevOpsAuditingSettingsResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="ServerDevOpsAuditingSettingsCollection" /> instance call the GetServerDevOpsAuditingSettings method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class ServerDevOpsAuditingSettingsCollection : ArmCollection, IEnumerable<ServerDevOpsAuditingSettingsResource>, IAsyncEnumerable<ServerDevOpsAuditingSettingsResource>
    {
        private readonly ClientDiagnostics _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics;
        private readonly ServerDevOpsAuditSettingsRestOperations _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDevOpsAuditingSettingsCollection"/> class for mocking. </summary>
        protected ServerDevOpsAuditingSettingsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDevOpsAuditingSettingsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerDevOpsAuditingSettingsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerDevOpsAuditingSettingsResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerDevOpsAuditingSettingsResource.ResourceType, out string serverDevOpsAuditingSettingsServerDevOpsAuditSettingsApiVersion);
            _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient = new ServerDevOpsAuditSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverDevOpsAuditingSettingsServerDevOpsAuditSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a server&apos;s DevOps audit settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="data"> Properties of DevOps audit settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerDevOpsAuditingSettingsResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string devOpsAuditingSettingsName, ServerDevOpsAuditingSettingsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerDevOpsAuditingSettingsResource>(new ServerDevOpsAuditingSettingsOperationSource(Client), _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics, Pipeline, _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a server&apos;s DevOps audit settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="data"> Properties of DevOps audit settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServerDevOpsAuditingSettingsResource> CreateOrUpdate(WaitUntil waitUntil, string devOpsAuditingSettingsName, ServerDevOpsAuditingSettingsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, data, cancellationToken);
                var operation = new SqlArmOperation<ServerDevOpsAuditingSettingsResource>(new ServerDevOpsAuditingSettingsOperationSource(Client), _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics, Pipeline, _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a server&apos;s DevOps audit settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual async Task<Response<ServerDevOpsAuditingSettingsResource>> GetAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettingsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server&apos;s DevOps audit settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<ServerDevOpsAuditingSettingsResource> Get(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettingsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists DevOps audit settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings
        /// Operation Id: ServerDevOpsAuditSettings_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDevOpsAuditingSettingsResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDevOpsAuditingSettingsResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDevOpsAuditingSettingsResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettingsResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerDevOpsAuditingSettingsResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettingsResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists DevOps audit settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings
        /// Operation Id: ServerDevOpsAuditSettings_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDevOpsAuditingSettingsResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDevOpsAuditingSettingsResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerDevOpsAuditingSettingsResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettingsResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerDevOpsAuditingSettingsResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettingsResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// Operation Id: ServerDevOpsAuditSettings_Get
        /// </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<bool> Exists(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerDevOpsAuditingSettingsResource> IEnumerable<ServerDevOpsAuditingSettingsResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDevOpsAuditingSettingsResource> IAsyncEnumerable<ServerDevOpsAuditingSettingsResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
