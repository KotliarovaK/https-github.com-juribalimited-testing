using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    internal class ItemDetails_TopBarPage : SeleniumBasePage
    {
        public const string ProjectOnSwitcherPanel = ".//mat-option[@class='mat-option ng-star-inserted']";

        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='topbar']")]
        public IWebElement TopBarOnItemDetailsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Evergreen']/ancestor::mat-select")]
        public IWebElement DefaultProjectStatusInProjectSwitcherDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='mat-select-trigger']")]
        public IWebElement ProjectSwitcherDropdownTopBar { get; set; }

        [FindsBy(How = How.XPath, Using = ProjectOnSwitcherPanel)]
        public IList<IWebElement> ProjectsOnSwitcherPanel { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public List<string> GetComplianceItemsOnTopBar()
        {
            var selector = By.XPath(".//div[@class='topbar-item-label']");
            return Driver.FindElements(selector).Select(x => x.Text).ToList();
        }

        public bool GetProjectSwitcherDisplayedState()
        {
            return Driver.IsElementDisplayed(By.XPath(".//div[contains(@class, 'transformPanel')]"));
        }

        public IWebElement GetComplianceValueOnTheDetailsPageByComplianceName(string title, string value)
        {
            var selector = By.XPath($".//div[text()='{title}']//ancestor::div//div[@class='topbar-item-value']//span[text()='{value}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetSelectedProjectOnTopBarByName(string projectName)
        {
            var selector = By.XPath($".//span[text()='{projectName}']/ancestor::div[@class='details-project-selector']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
