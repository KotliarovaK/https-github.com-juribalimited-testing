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

        [FindsBy(How = How.XPath, Using = ".//input[@value='Add']")]
        public IWebElement AddButton { get; set; }

        #endregion

        #region Delete Buttons

        [FindsBy(How = How.XPath, Using = ".//input[@id='Btn_Delete']")]
        public IWebElement DeleteGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_GoToDeleteProjectView']")]
        public IWebElement DeleteProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_DeleteProject']")]
        public IWebElement ConfirmDeletedTheProjectButton { get; set; }

        //TODO selectors for Request Type
        public IWebElement GetDeleteRequestTypeButtonElementByName(string requestType)
        {
            var selector = By.XPath($".//td[@title='{requestType}']/..//td[8]//input[@alt='Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        //TODO selectors for all categories
        public IWebElement GetDeleteCategoryButtonElementByName(string categoryName)
        {
            var selector = By.XPath($".//td[@title='{categoryName}']/..//td[6]//input[@title='Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDeleteStageButtonElementByName(string stageName)
        {
            var selector = By.XPath($".//td[@title='{stageName}']/..//td[2]//input[@id='ctl00_MainContent_GV_Stages_ctl02_Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDeleteTaskButtonElementByName(string taskName)
        {
            var selector = By.XPath($".//td[@title='{taskName}']/..//td[14]//input[@id='ctl00_MainContent_GV_Tasks_ctl02_Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

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

        //TODO selectors for Mail Templates
        public IWebElement GetDeleteTemplateButtonElementByName(string templateName)
        {
            var selector = By.XPath($".//a[contains(text(), '{templateName}')]/..//td[4]//input[@id='ctl00_MainContent_GV_MailTemplates_ctl02_Delete']");
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