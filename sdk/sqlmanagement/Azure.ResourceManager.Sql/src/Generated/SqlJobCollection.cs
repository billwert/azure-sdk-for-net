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
    /// A class representing a collection of <see cref="SqlJobResource" /> and their operations.
    /// Each <see cref="SqlJobResource" /> in the collection will belong to the same instance of <see cref="JobAgentResource" />.
    /// To get a <see cref="SqlJobCollection" /> instance call the GetSqlJobs method from an instance of <see cref="JobAgentResource" />.
    /// </summary>
    public partial class SqlJobCollection : ArmCollection, IEnumerable<SqlJobResource>, IAsyncEnumerable<SqlJobResource>
    {
        private readonly ClientDiagnostics _sqlJobJobsClientDiagnostics;
        private readonly JobsRestOperations _sqlJobJobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlJobCollection"/> class for mocking. </summary>
        protected SqlJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlJobJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlJobResource.ResourceType, out string sqlJobJobsApiVersion);
            _sqlJobJobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlJobJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobAgentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobAgentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="data"> The requested job state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlJobResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string jobName, SqlJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlJobJobsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlJobResource>(Response.FromValue(new SqlJobResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="data"> The requested job state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlJobResource> CreateOrUpdate(WaitUntil waitUntil, string jobName, SqlJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlJobJobsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlJobResource>(Response.FromValue(new SqlJobResource(Client, response), response.GetRawResponse()));
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
        /// Gets a job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<SqlJobResource>> GetAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<SqlJobResource> Get(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of jobs.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs
        /// Operation Id: Jobs_ListByAgent
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlJobResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlJobResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlJobJobsRestClient.ListByAgentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlJobResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlJobResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlJobJobsRestClient.ListByAgentNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlJobResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of jobs.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs
        /// Operation Id: Jobs_ListByAgent
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlJobResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlJobResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlJobJobsRestClient.ListByAgent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlJobResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlJobResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlJobJobsRestClient.ListByAgentNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlJobResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlJobResource> IEnumerable<SqlJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlJobResource> IAsyncEnumerable<SqlJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
