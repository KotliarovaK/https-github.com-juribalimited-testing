using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects
{
    internal class MainElementsOfProjectCreation : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement PageHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'SelectUsers_TB_Narrow')]")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'SelectUsers_Btn_Narrow')]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'SelectUsersToAdd_TB_Narrow')]")]
        public IWebElement SearchTextBoxForMembers { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'SelectUsersToAdd_Btn_Narrow')]")]
        public IWebElement SearchButtonForMembers { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'SelectUsersToAdd_Btn_Reset')]")]
        public IWebElement ResetButtonForMembers { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Next  >']")]
        public IWebElement NextTeamsListLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@title='Default Team']/input")]
        public IWebElement DefaultTeamCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Create Project']")]
        public IWebElement CreatedProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Project']")]
        public IWebElement CreatedProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//li//a[text()='Manage Project']")]
        public IWebElement ManageProject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'tooltipbar-success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[contains(@class, 'tooltip-information')]")]
        public IWebElement InformationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'tooltipbar-alert')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[contains(text(), 'This task is published')]")]
        public IWebElement SuccessPublishedTaskFlag { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Update']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Add']")]
        public IWebElement AddButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageHeader)
            };
        }

        #region Tabs for creating Projects page

        public IWebElement GetOpenedProjectName(string projectName)
        {
            var selector = By.XPath($".//div[text()='Project: {projectName}']");
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
            var selector =
                By.XPath(
                    $".//div[@class='dwmenu navigation-menu alignList manageSelfServiceMenu']//a[contains(text(), '{tabName}')]");
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

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Delete')]")]
        public IWebElement DeleteGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'GoToDeleteProjectView')]")]
        public IWebElement DeleteProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@value, 'Delete')]")]
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
            var selector = By.XPath($".//input[contains(@value, '{buttonName}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement SelectUserForMembersByName(string userName)
        {
            var selector = By.XPath($".//td[@title='{userName}']/..//input");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        #region Check creating elements

        public bool CheckThatCreatedElementIsRemoved(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($".//td[@title='{name}']/..//td[1]"));
        }

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

        public IWebElement GetTheCreatedEmailInTableByName(string name)
        {
            var selector = By.XPath($".//td[@title='{name}']/..//td[2]");
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

        public IWebElement GetTeamByName(string teamName)
        {
            var selector = By.XPath($"//td[contains(@title, '{teamName}')]/a");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public int GetGroupsCountByTeamName(string teamName)
        {
            var groupsCount = Driver.FindElement(By.XPath($".//td[@title='{teamName}']/..//td[5]")).Text;
            return int.Parse(groupsCount);
        }

        public int GetMembersCountByTeamName(string teamName)
        {
            var groupsCount = Driver.FindElement(By.XPath($".//td[@title='{teamName}']/..//td[4]")).Text;
            return int.Parse(groupsCount);
        }

        public IWebElement GetDefaultRequestTypeCountByName(string requestName)
        {
            var selector =
                By.XPath(
                    $".//a[contains(text(), '{requestName}')]/../following-sibling::td//input[@src='/images/tick2.png']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTaskByName(string taskName)
        {
            var selector = By.XPath($"//a[contains(@id, 'Tasks')][text()='{taskName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($"//label[text()='{checkboxName}']/ancestor::td/input");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}