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

namespace Microsoft.WindowsAzure.Commands.ServiceManagement.HostedServices
{
    using System.Linq;
    using System.Management.Automation;
    using AutoMapper;
    using Commands.Utilities.Common;
    using Management;
    using Management.Models;
    using Model;

    /// <summary>
    /// Retrieve a Windows Azure Location.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureLocation"), OutputType(typeof(LocationsContext))]
    public class GetAzureLocationCommand : ServiceManagementBaseCmdlet
    {
        public void GetLocationsProcess()
        {
            ExecuteClientActionNewSM(null,
                CommandRuntime.ToString(),
                () => this.ManagementClient.Locations.List(),
                (op, locations) => locations.Locations.Select(location => ContextFactory<LocationsListResponse.Location, LocationsContext>(location, op)));
        }

        protected override void OnProcessRecord()
        {
            ServiceManagementProfile.Initialize();
            this.GetLocationsProcess();
        }
    }
}
