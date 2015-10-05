﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Common.Authentication;
using Microsoft.Azure.Common.Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Microsoft.WindowsAzure.Commands.Common.Test.Mocks
{
    public class MockClientFactory : IClientFactory
    {
        public List<object> ManagementClients { get; private set; }

        public MockClientFactory(IEnumerable<object> clients)
        {
            ManagementClients = clients.ToList();
        }

        public TClient CreateClient<TClient>(AzureSMProfile profile, AzureSubscription subscription, AzureEnvironment.Endpoint endpoint) 
            where TClient : ServiceClient<TClient>
        {
            SubscriptionCloudCredentials creds = new TokenCloudCredentials(subscription.Id.ToString(), "fake_token");
            Uri endpointUri = profile.Environments[subscription.Environment].GetEndpointAsUri(endpoint);
            return CreateCustomClient<TClient>(creds, endpointUri);
        }

        public TClient CreateClient<TClient>(AzureContext context, AzureEnvironment.Endpoint endpoint) 
            where TClient : ServiceClient<TClient>
        {
            SubscriptionCloudCredentials creds = AzureSession.AuthenticationFactory.GetSubscriptionCloudCredentials(context);
            return CreateCustomClient<TClient>(creds, context.Environment.GetEndpointAsUri(endpoint));
        }

        public TClient CreateClient<TClient>(AzureSMProfile profile, AzureEnvironment.Endpoint endpoint) 
            where TClient : ServiceClient<TClient>
        {
            return CreateClient<TClient>(profile.Context, endpoint);
        }

        public TClient CreateCustomClient<TClient>(params object[] parameters) 
            where TClient : ServiceClient<TClient>
        {
            return ManagementClients.FirstOrDefault(o => o is TClient) as TClient;
        }

        public HttpClient CreateHttpClient(string serviceUrl, HttpMessageHandler effectiveHandler)
        {
            throw new NotImplementedException();
        }

        public HttpClient CreateHttpClient(string endpoint, System.Net.ICredentials credentials)
        {
            throw new NotImplementedException();
        }

        public void AddAction(IClientAction action)
        {
            throw new NotImplementedException();
        }

        public void RemoveAction(Type actionType)
        {
            throw new NotImplementedException();
        }

        public void AddHandler<T>(T handler) where T : DelegatingHandler, ICloneable
        {
            throw new NotImplementedException();
        }

        public void RemoveHandler(Type handlerType)
        {
            throw new NotImplementedException();
        }

        public List<System.Net.Http.Headers.ProductInfoHeaderValue> UserAgents
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public TClient CreateArmClient<TClient>(AzureContext context, AzureEnvironment.Endpoint endpoint) where TClient : Rest.ServiceClient<TClient>
        {
            var creds = AzureSession.AuthenticationFactory.GetServiceClientCredentials(context);
            return CreateCustomArmClient<TClient>(creds, context.Environment.GetEndpointAsUri(endpoint));
        }

        public TClient CreateCustomArmClient<TClient>(params object[] parameters) where TClient : Rest.ServiceClient<TClient>
        {
            return ManagementClients.FirstOrDefault(o => o is TClient) as TClient;
        }
    }
}
