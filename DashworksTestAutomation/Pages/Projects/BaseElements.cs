using System;
using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class BaseElements : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement PageHeder { get; set; }

        #region Navigation Tab

        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement Administration { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Create Project']")]
        public IWebElement CreateProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Update']")]
        public IWebElement UpdateButton { get; set; }

        #endregion

        #region Delete Buttons

        [FindsBy(How = How.XPath, Using = ".//input[@id='Btn_Delete']")]
        public IWebElement DeleteGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_GoToDeleteProjectView']")]
        public IWebElement DeleteProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_DeleteProject']")]
        public IWebElement ConfirmDeletedTheProjectButton { get; set; }

        public IWebElement GetDeleteGroupButtonElementByName(string groupName)
        {
            var selector = By.XPath($".//td[@title='{groupName}']/..//td[3]//input[@id='ctl00_MainContent_GV_Groups_ctl02_Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDeleteTeamButtonElementByName(string teamName)
        {
            var selector = By.XPath($".//td[@title='{teamName}']/..//td[5]//input[@id='ctl00_MainContent_GV_Teams_ctl02_Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #endregion

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageHeder)
            };
        }

        public IWebElement GetTabElementByName(string tabName)
        {
            var selector = By.XPath($".//div[@class='toolbar toolbar-row']//div//a[text()='{tabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTabElementByNameOnSelectedTab(string tabName)
        {
            var selector = By.XPath($".//li[@role='menuitem']//a[text()='{tabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCreateButtonElementByName(string buttonName)
        {
            var selector = By.XPath($".//input[@value='Create {buttonName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public int GetGroupsCountByTeamName(string teamName)
        {
            var groupsCount = Driver.FindElement(By.XPath($".//td[@title='{teamName}']/..//td[4]")).Text;
            return int.Parse(groupsCount);
        }
    }
}