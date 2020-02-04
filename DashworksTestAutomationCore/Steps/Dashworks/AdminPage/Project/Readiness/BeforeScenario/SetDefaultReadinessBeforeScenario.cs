using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.RuntimeVariables.Readiness;
using DashworksTestAutomation.Helpers;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.Readiness.BeforeScenario
{
    [Binding]
    class SetDefaultReadinessBeforeScenario : SpecFlowContext
    {
        private readonly DefaultReadinessId _defaultReadinessId;

        public SetDefaultReadinessBeforeScenario(DefaultReadinessId defaultReadinessId)
        {
            _defaultReadinessId = defaultReadinessId;
        }

        [Given(@"User remembers default Readiness for '(.*)' project")]
        [When(@"User remembers default Readiness for '(.*)' project")]
        public void WhenGivenUserRemembersDefaultReadinessForProject(string projectName)
        {
            var projId = int.Parse(DatabaseHelper.GetProjectId(projectName));
            var readinessId = int.Parse(DatabaseHelper.GetProjectDefaultReadinessId(projId));
            _defaultReadinessId.Value.Add(new KeyValuePair<int, int>(projId, readinessId));
        }
    }
}
