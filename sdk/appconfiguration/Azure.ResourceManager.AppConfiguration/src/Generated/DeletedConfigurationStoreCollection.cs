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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class representing collection of DeletedConfigurationStore and their operations over its parent. </summary>
    public partial class DeletedConfigurationStoreCollection : ArmCollection, IEnumerable<DeletedConfigurationStore>, IAsyncEnumerable<DeletedConfigurationStore>
    {
        private readonly ClientDiagnostics _deletedConfigurationStoreConfigurationStoresClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _deletedConfigurationStoreConfigurationStoresRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedConfigurationStoreCollection"/> class for mocking. </summary>
        protected DeletedConfigurationStoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedConfigurationStoreCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DeletedConfigurationStoreCollection(ArmResource parent) : base(parent)
        {
            _deletedConfigurationStoreConfigurationStoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", DeletedConfigurationStore.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(DeletedConfigurationStore.ResourceType, out string deletedConfigurationStoreConfigurationStoresApiVersion);
            _deletedConfigurationStoreConfigurationStoresRestClient = new ConfigurationStoresRestOperations(_deletedConfigurationStoreConfigurationStoresClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, deletedConfigurationStoreConfigurationStoresApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Gets a deleted Azure app configuration store. </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="configStoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<DeletedConfigurationStore> Get(string location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, location, configStoreName, cancellationToken);
                if (response.Value == null)
                    throw _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedConfigurationStore(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deleted Azure app configuration store. </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="configStoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="configStoreName"/> is null. </exception>
        public async virtual Task<Response<DeletedConfigurationStore>> GetAsync(string location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, location, configStoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeletedConfigurationStore(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="configStoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<DeletedConfigurationStore> GetIfExists(string location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, location, configStoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeletedConfigurationStore>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedConfigurationStore(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="configStoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="configStoreName"/> is null. </exception>
        public async virtual Task<Response<DeletedConfigurationStore>> GetIfExistsAsync(string location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deletedConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, location, configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeletedConfigurationStore>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedConfigurationStore(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="configStoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, configStoreName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="configStoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="configStoreName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the deleted configuration stores in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedConfigurationStore" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedConfigurationStore> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DeletedConfigurationStore> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deletedConfigurationStoreConfigurationStoresRestClient.ListDeleted(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedConfigurationStore(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedConfigurationStore> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deletedConfigurationStoreConfigurationStoresRestClient.ListDeletedNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedConfigurationStore(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about the deleted configuration stores in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedConfigurationStore" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedConfigurationStore> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedConfigurationStore>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deletedConfigurationStoreConfigurationStoresRestClient.ListDeletedAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedConfigurationStore(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedConfigurationStore>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deletedConfigurationStoreConfigurationStoresRestClient.ListDeletedNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedConfigurationStore(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DeletedConfigurationStore> IEnumerable<DeletedConfigurationStore>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeletedConfigurationStore> IAsyncEnumerable<DeletedConfigurationStore>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
