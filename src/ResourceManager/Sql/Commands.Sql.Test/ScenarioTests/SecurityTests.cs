// ----------------------------------------------------------------------------------
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

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;

namespace Microsoft.Azure.Commands.ScenarioTest.SqlTests
{
    public class SecurityTests : SqlTestsBase
    {
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseUpdatePolicyWithStorage()
        {
            RunPowerShellTest("Test-DatabaseUpdatePolicyWithStorage");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdatePolicyWithStorage()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-ServerUpdatePolicyWithStorage");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseUpdatePolicyWithEventTypes()
        {
            RunPowerShellTest("Test-DatabaseUpdatePolicyWithEventTypes");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdatePolicyWithEventTypes()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-ServerUpdatePolicyWithEventTypes");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDisableDatabaseAuditing()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-DisableDatabaseAuditing");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDisableServerAuditing()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-DisableServerAuditing");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseDisableEnableKeepProperties()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-DatabaseDisableEnableKeepProperties");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerDisableEnableKeepProperties()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-ServerDisableEnableKeepProperties");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUseServerDefault()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-UseServerDefault");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailedDatabaseUpdatePolicyWithNoStorage()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-FailedDatabaseUpdatePolicyWithNoStorage");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailedServerUpdatePolicyWithNoStorage()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-FailedServerUpdatePolicyWithNoStorage");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailedUseServerDefault()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-FailedUseServerDefault");
        }
        
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseUpdatePolicyWithEventTypeShortcuts()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-DatabaseUpdatePolicyWithEventTypeShortcuts");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdatePolicyWithEventTypeShortcuts()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-ServerUpdatePolicyWithEventTypeShortcuts");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseUpdatePolicyKeepPreviousStorage()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-DatabaseUpdatePolicyKeepPreviousStorage");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdatePolicyKeepPreviousStorage()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-ServerUpdatePolicyKeepPreviousStorage");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailWithBadDatabaseIndentity()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-FailWithBadDatabaseIndentity");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailWithBadServerIndentity()
        {
            if (XUnitHelper.IsCheckin()) return;

            RunPowerShellTest("Test-FailWithBadServerIndentity");
        }
    }
}
