using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.ManagementConsole;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.ManagementConsole
{
    [Binding]
    internal class ManagementConsole : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public ManagementConsole(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User select ""(.*)"" option in Management Console")]
        public void WhenUserSelectOptionInManagementConsole(string optionName)
        {
            var page = _driver.NowAt<ManagementConsolePage>();

            _driver.MouseHover(page.GetLinkInManagementConsoleByName(optionName));
            page.GetLinkInManagementConsoleByName(optionName).Click();
        }
    }
}