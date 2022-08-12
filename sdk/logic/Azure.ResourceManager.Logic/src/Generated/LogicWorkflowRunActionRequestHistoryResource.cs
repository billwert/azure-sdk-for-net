// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A Class representing a LogicWorkflowRunActionRequestHistory along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LogicWorkflowRunActionRequestHistoryResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLogicWorkflowRunActionRequestHistoryResource method.
    /// Otherwise you can get one from its parent resource <see cref="LogicWorkflowRunActionResource" /> using the GetLogicWorkflowRunActionRequestHistory method.
    /// </summary>
    public partial class LogicWorkflowRunActionRequestHistoryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogicWorkflowRunActionRequestHistoryResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string requestHistoryName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/requestHistories/{requestHistoryName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesClientDiagnostics;
        private readonly WorkflowRunActionRequestHistoriesRestOperations _logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesRestClient;
        private readonly LogicWorkflowRequestHistoryData _data;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionRequestHistoryResource"/> class for mocking. </summary>
        protected LogicWorkflowRunActionRequestHistoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicWorkflowRunActionRequestHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowRunActionRequestHistoryResource(ArmClient client, LogicWorkflowRequestHistoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionRequestHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowRunActionRequestHistoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesApiVersion);
            _logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesRestClient = new WorkflowRunActionRequestHistoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Logic/workflows/runs/actions/requestHistories";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogicWorkflowRequestHistoryData Data
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

        /// <summary>
        /// Gets a workflow run request history.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/requestHistories/{requestHistoryName}
        /// Operation Id: WorkflowRunActionRequestHistories_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogicWorkflowRunActionRequestHistoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesClientDiagnostics.CreateScope("LogicWorkflowRunActionRequestHistoryResource.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunActionRequestHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow run request history.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/requestHistories/{requestHistoryName}
        /// Operation Id: WorkflowRunActionRequestHistories_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogicWorkflowRunActionRequestHistoryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesClientDiagnostics.CreateScope("LogicWorkflowRunActionRequestHistoryResource.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunActionRequestHistoryWorkflowRunActionRequestHistoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunActionRequestHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
