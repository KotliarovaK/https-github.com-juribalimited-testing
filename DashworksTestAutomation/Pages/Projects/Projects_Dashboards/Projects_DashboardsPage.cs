﻿using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.Projects_Dashboards
{
    internal class Projects_DashboardsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//select[contains(@name, 'ProjectId')]")]
        public IWebElement ProjectDropDown { get; set; }

        public void GetGroupInTableByName(string groupName)
        {
            string selector;

            if (groupName.Contains("'"))
            {
                var strings = groupName.Split('\'');
                selector =
                    $"//td[contains(@aria-describedby, 'GroupName')]//a[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $"//td[contains(@aria-describedby, 'GroupName')]//a[text()='{groupName}']";
            }

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public void GetProjectByNameOnToolbar(string projectName)
        {
            string selector;

            if (projectName.Contains("'"))
            {
                var strings = projectName.Split('\'');
                selector =
                    $".//select[contains(@name, 'ProjectId')]//option[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//select[contains(@name, 'ProjectId')]//option[text()='{projectName}']";
            }

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }
    }
}