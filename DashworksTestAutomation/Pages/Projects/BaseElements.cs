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
            var selector = By.XPath($".//a[text()='{tabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTabElementByNameOnSelectedTab(string tabName)
        {
            var selector = By.XPath($".//a[@class='level1 static'][text()='{tabName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCreateButtonElementByName(string buttonName)
        {
            var selector = By.XPath($".//input[@value='Create {buttonName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}