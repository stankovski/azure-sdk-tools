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

using System.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.WindowsAzure.Commands.Common.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common.Authentication;

namespace Microsoft.WindowsAzure.Commands.Common.Test.Mocks
{
    public class MockAuthenticationFactory : IAuthenticationFactory
    {
        private const string CommonAdTenant = "Common";

        public IAccessToken Token { get; set; }

        public X509Certificate2 Certificate { get; set; }

        public MockAuthenticationFactory()
        {
            Token = new MockAccessToken
            {
                UserId = "Test",
                LoginType = LoginType.OrgId,
                AccessToken = "abc"
            };
        }

        public MockAuthenticationFactory(string userId, string accessToken)
        {
            Token = new MockAccessToken
            {
                UserId = userId,
                LoginType = LoginType.OrgId,
                AccessToken = accessToken
            };
        }

        public MockAuthenticationFactory(string userId, X509Certificate2 certificate)
        {
            Certificate = certificate;
        }

        public IAccessToken Authenticate(ref AzureAccount account, AzureEnvironment environment, string tenant, SecureString password,
            ShowDialog promptBehavior)
        {
            if (account.Id == null)
            {
                account.Id = "test";
            }

            Token = new MockAccessToken
            {
                UserId = account.Id,
                LoginType = LoginType.OrgId,
                AccessToken = Token.AccessToken
            };

            return Token;
        }

        public SubscriptionCloudCredentials GetSubscriptionCloudCredentials(AzureContext context)
        {
            if (Certificate != null)
            {
                return new CertificateCloudCredentials(context.Subscription.Id.ToString(), Certificate);
            }
            else
            {
                return new AccessTokenCredential(context.Subscription.Id, Token);
            }
        }
    }
}
