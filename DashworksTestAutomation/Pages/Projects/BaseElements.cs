using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class BaseElements : SeleniumBasePage
    {

        [FindsBy(How = How.XPath, Using = ".//input[@value='Update']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='btn_Create']")]
        public IWebElement ConfirmCreationButton { get; set; }

        #region 'Create' buttons

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Request Type']")]
        public IWebElement CreateRequestTypesButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Category']")]
        public IWebElement CreateCreateCategoryButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Stage']")]
        public IWebElement CreateCreateStageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Task']")]
        public IWebElement CreateCreateTaskButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Team']")]
        public IWebElement CreateCreateTeamButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Group']")]
        public IWebElement CreateCreateGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Mail Template']")]
        public IWebElement CreateCreateMailTemplateButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.CreateRequestTypesButton),
                SelectorFor(this, p => p.CreateCreateCategoryButton),
                SelectorFor(this, p => p.CreateCreateStageButton),
                SelectorFor(this, p => p.CreateCreateTaskButton),
                SelectorFor(this, p => p.CreateCreateTeamButton),
                SelectorFor(this, p => p.CreateCreateGroupButton),
                SelectorFor(this, p => p.CreateCreateMailTemplateButton)
            };
        }

        #endregion

        public IWebElement GetTabElementByName(string tabName)
        {
            var selector = By.XPath($".//a[@id='ctl00_MainContent_PMManageNav_LB_{tabName.Trim()}'][text()='{tabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetButtonElementByName(string buttonName)
        {
            var selector = By.XPath($".//input[@value='Create {buttonName.Trim()}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}