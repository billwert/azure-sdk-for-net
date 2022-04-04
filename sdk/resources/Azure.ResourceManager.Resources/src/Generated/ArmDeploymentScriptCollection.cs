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

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="ArmDeploymentScriptResource" /> and their operations.
    /// Each <see cref="ArmDeploymentScriptResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="ArmDeploymentScriptCollection" /> instance call the GetArmDeploymentScripts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ArmDeploymentScriptCollection : ArmCollection, IEnumerable<ArmDeploymentScriptResource>, IAsyncEnumerable<ArmDeploymentScriptResource>
    {
        private readonly ClientDiagnostics _armDeploymentScriptDeploymentScriptsClientDiagnostics;
        private readonly DeploymentScriptsRestOperations _armDeploymentScriptDeploymentScriptsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArmDeploymentScriptCollection"/> class for mocking. </summary>
        protected ArmDeploymentScriptCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArmDeploymentScriptCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ArmDeploymentScriptCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _armDeploymentScriptDeploymentScriptsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ArmDeploymentScriptResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ArmDeploymentScriptResource.ResourceType, out string armDeploymentScriptDeploymentScriptsApiVersion);
            _armDeploymentScriptDeploymentScriptsRestClient = new DeploymentScriptsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, armDeploymentScriptDeploymentScriptsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a deployment script.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}
        /// Operation Id: DeploymentScripts_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="data"> Deployment script supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ArmDeploymentScriptResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scriptName, ArmDeploymentScriptData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _armDeploymentScriptDeploymentScriptsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<ArmDeploymentScriptResource>(new ArmDeploymentScriptOperationSource(Client), _armDeploymentScriptDeploymentScriptsClientDiagnostics, Pipeline, _armDeploymentScriptDeploymentScriptsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, scriptName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a deployment script.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}
        /// Operation Id: DeploymentScripts_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="data"> Deployment script supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ArmDeploymentScriptResource> CreateOrUpdate(WaitUntil waitUntil, string scriptName, ArmDeploymentScriptData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _armDeploymentScriptDeploymentScriptsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, scriptName, data, cancellationToken);
                var operation = new ResourcesArmOperation<ArmDeploymentScriptResource>(new ArmDeploymentScriptOperationSource(Client), _armDeploymentScriptDeploymentScriptsClientDiagnostics, Pipeline, _armDeploymentScriptDeploymentScriptsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, scriptName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a deployment script with a given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}
        /// Operation Id: DeploymentScripts_Get
        /// </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual async Task<Response<ArmDeploymentScriptResource>> GetAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.Get");
            scope.Start();
            try
            {
                var response = await _armDeploymentScriptDeploymentScriptsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArmDeploymentScriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deployment script with a given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}
        /// Operation Id: DeploymentScripts_Get
        /// </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<ArmDeploymentScriptResource> Get(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.Get");
            scope.Start();
            try
            {
                var response = _armDeploymentScriptDeploymentScriptsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArmDeploymentScriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists deployments scripts.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts
        /// Operation Id: DeploymentScripts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArmDeploymentScriptResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArmDeploymentScriptResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ArmDeploymentScriptResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _armDeploymentScriptDeploymentScriptsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ArmDeploymentScriptResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ArmDeploymentScriptResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _armDeploymentScriptDeploymentScriptsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ArmDeploymentScriptResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists deployments scripts.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts
        /// Operation Id: DeploymentScripts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArmDeploymentScriptResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArmDeploymentScriptResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ArmDeploymentScriptResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _armDeploymentScriptDeploymentScriptsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ArmDeploymentScriptResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ArmDeploymentScriptResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _armDeploymentScriptDeploymentScriptsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ArmDeploymentScriptResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}
        /// Operation Id: DeploymentScripts_Get
        /// </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = await _armDeploymentScriptDeploymentScriptsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}
        /// Operation Id: DeploymentScripts_Get
        /// </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<bool> Exists(string scriptName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptName, nameof(scriptName));

            using var scope = _armDeploymentScriptDeploymentScriptsClientDiagnostics.CreateScope("ArmDeploymentScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = _armDeploymentScriptDeploymentScriptsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ArmDeploymentScriptResource> IEnumerable<ArmDeploymentScriptResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ArmDeploymentScriptResource> IAsyncEnumerable<ArmDeploymentScriptResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
