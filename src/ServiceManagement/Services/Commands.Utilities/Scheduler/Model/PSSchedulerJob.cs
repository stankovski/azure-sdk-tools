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

namespace Microsoft.WindowsAzure.Commands.Utilities.Scheduler.Model
{
    using System;

    public class PSSchedulerJob
    {
        public string JobCollectionName { get; internal set; }

        public string JobName { get; internal set; }

        public DateTime? Lastrun { get; internal set; }

        public DateTime? Nextrun { get; internal set; }

        public DateTime? StartTime { get; internal set; }

        public string Status { get; internal set; }

        public string Recurrence { get; internal set; }

        public int? Failures { get; internal set; }

        public int? Faults { get; internal set; }

        public int? Executions { get; internal set; }

        public string EndSchedule { get; internal set; }
        
    }
}