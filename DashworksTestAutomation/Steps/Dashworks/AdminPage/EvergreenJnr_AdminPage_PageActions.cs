using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    class EvergreenJnr_AdminPage_PageActions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_PageActions (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"""(.*)"" page is displayed to the user on Admin page")]
        public void ThenPageIsDisplayedToTheUserOnAdminPage(string pageName)
        {
            var page = _driver.NowAtWithoutWait<BaseGridPage>();
            Utils.Verify.IsTrue(page.GetOpenedPageByName(pageName).Displayed(), $"{pageName} page is not loaded");
        }

        [Then(@"""(.*)"" sub-menu section is expanded")]
        public void ThenSub_MenuSectionIsExpanded(string section)
        {
            var page = _driver.NowAtWithoutWait<BaseGridPage>();
            Utils.Verify.IsTrue(page.GetExpandedSubMenuSection(section).Displayed(), $"{section} section is collapsed");
        }

        [Then(@"""(.*)"" field is empty on the Admin page")]
        public void ThenFieldIsEmptyOnTheAdminPage(string fieldName)
        {
            var page = _driver.NowAtWithoutWait<BaseGridPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.GetEmptyFieldByName(fieldName).Displayed(), $"{fieldName} field is populated");
        }

        [Then(@"""(.*)"" object name is displayed to the User")]
        public void ThenObjectNameIsDisplayedToTheUser(string objectName)
        {
            var page = _driver.NowAtWithoutWait<BaseGridPage>();
            Utils.Verify.IsTrue(page.GetObjectTitle(objectName).Displayed(), $"{objectName} is not displayed");
        }
    }
}
