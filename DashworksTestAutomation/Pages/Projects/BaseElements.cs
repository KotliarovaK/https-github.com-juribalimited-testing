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

        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement Administration { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Create Project']")]
        public IWebElement CreateProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Manage Project']")]
        public IWebElement ManageProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'tooltipbar-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[contains(text(), 'This task is published')]")]
        public IWebElement SuccessPublishedTaskFlag { get; set; }

        #region Navigation Tab

        [FindsBy(How = How.XPath, Using = ".//input[@value='Update']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Add']")]
        public IWebElement AddButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageHeder)
            };
        }

        public IWebElement GetOpenedProjectName(string projectName)
        {
            var selector = By.XPath($".//div[text()='Project: {projectName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetProjectByName(string projectName)
        {
            var selector = By.XPath($".//a[text()='{projectName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTabElementByName(string tabName)
        {
            var selector = By.XPath($".//div[@class='toolbar toolbar-row']//a[contains(text(), '{tabName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTabElementByNameOnSelfServiceTab(string tabName)
        {
            var selector = By.XPath($".//div[@class='dwmenu navigation-menu alignList manageSelfServiceMenu']//a[contains(text(), '{tabName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTabElementByNameOnSelectedTab(string tabName)
        {
            var selector = By.XPath($".//div[@class='dwmenu navigation-menu']//a[contains(text(), '{tabName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #endregion

        #region Delete Buttons

        [FindsBy(How = How.XPath, Using = ".//input[@id='Btn_Delete']")]
        public IWebElement DeleteGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_GoToDeleteProjectView']")]
        public IWebElement DeleteProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_DeleteProject']")]
        public IWebElement ConfirmDeletedTheProjectButton { get; set; }

        public IWebElement GetDeleteButtonElementByName(string name)
        {
            var selector = By.XPath($".//a[text()='{name}']/../following-sibling::td/input[@title='Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDeleteStageButtonElementByName(string stageName)
        {
            var selector = By.XPath($".//td[@title='{stageName}']/..//td[2]//input[@title='Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #endregion

        public IWebElement GetButtonElementByName(string buttonName)
        {
            var selector = By.XPath($".//input[@value='{buttonName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #region Check creating elements

        public IWebElement GetTheCreatedElementInTableByName(string name)
        {
            var selector = By.XPath($".//td[@title='{name}']/..//td[1]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTheCreatedRequestTypeInTableByName(string requestTypeName)
        {
            var selector = By.XPath($".//a[contains(@id, 'RequestType')]/..//a[contains(text(), '{requestTypeName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTheCreatedTaskInTableByName(string taskName)
        {
            var selector = By.XPath($".//a[contains(@id, 'TaskName')]/..//a[contains(text(), '{taskName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTheCreatedCategoryInTableByName(string categoryName)
        {
            var selector = By.XPath($".//a[contains(@id, 'CategoryName')]/..//a[contains(text(), '{categoryName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #endregion

        public int GetGroupsCountByTeamName(string teamName)
        {
            var groupsCount = Driver.FindElement(By.XPath($".//td[@title='{teamName}']/..//td[4]")).Text;
            return int.Parse(groupsCount);
        }

        public IWebElement GetDefaultRequestTypeCountByName(string requestName)
        {
            var selector = By.XPath($".//a[contains(text(), '{requestName}')]/../following-sibling::td//input[@src='/images/tick2.png']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}