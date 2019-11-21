using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Helpers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    public class RunAutomation : SpecFlowContext
    {
        private readonly TestInfo _testInfo;

        public RunAutomation(TestInfo testInfo)
        {
            _testInfo = testInfo;
        }

        [When(@"'(.*)' automation run has finished")]
        public void WhenAutomationRunHasFinished(string automation)
        {
            var attempts = 30;
            var waitTime = 1000;
            for (int i = 0; i < attempts; i++)
            {
                var isFinished = DatabaseHelper.IsAutomationRunFinished(automation, _testInfo.StartTime);
                if (isFinished)
                {
                    return;
                }
                else
                {
                    Thread.Sleep(waitTime);
                }
            }

            throw new Exception($"'{automation}' automation run was not finished in {(attempts * waitTime) / 1000} seconds");
        }

        [When(@"'(.*)' automation '(.*)' action run has finished")]
        public void WhenAutomationActionRunHasFinished(string automation, string action)
        {
            var attempts = 30;
            var waitTime = 1000;
            for (int i = 0; i < attempts; i++)
            {
                var isFinished = DatabaseHelper.IsAutomationActionRunFinished(automation, action, _testInfo.StartTime);
                if (isFinished)
                {
                    return;
                }
                else
                {
                    Thread.Sleep(waitTime);
                }
            }

            throw new Exception($"'{automation}' automation '{action}' action run was not finished in {(attempts * waitTime) / 1000} seconds");
        }
    }
}
