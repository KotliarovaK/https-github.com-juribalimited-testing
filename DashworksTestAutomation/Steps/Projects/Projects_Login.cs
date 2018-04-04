using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Pages.Projects
{
    [Binding]
    internal class Projects_Login : SeleniumBasePage
    {
        private readonly RemoteWebDriver _driver;

        public Projects_Login(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks the Switch to Projects link")]
        public void WhenUserClicksTheSwitchToProjectsLink()
        {
            var headerMenu = _driver.NowAt<DashworksHeaderMenuElement>();

            _driver.MouseHover(headerMenu.AnalysisLink);

            _driver.WaitWhileControlIsNotClickable<DashworksHeaderMenuElement>(() => headerMenu.ProjectsLink);
            headerMenu.ProjectsLink.Click();
        }

        [Then(@"Projects page is displayed to the user")]
        public void ThenProjectsPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseProjectsElements>();

            Assert.IsTrue(page.ProjectsHomePage.Displayed(), "Projects Home page is not displayed");
            Logger.Write("Projects Home page is displayed");
        }
    }
}