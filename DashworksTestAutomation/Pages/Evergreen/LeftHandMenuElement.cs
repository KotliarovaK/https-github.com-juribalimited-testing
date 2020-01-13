using System;
using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class LeftHandMenuElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//span[text()='Dashboards']")]
        public IWebElement Dashboards { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='wrapper']")]
        public IWebElement MenuToggleIndicator { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@href='#/devices']")]
        public IWebElement Devices { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@href='#/users']")]
        public IWebElement Users { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@href='#/applications']")]
        public IWebElement Applications { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@href='#/mailboxes']")]
        public IWebElement Mailboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Projects']")]
        public IWebElement Projects { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Admin']")]
        public IWebElement Admin { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Devices),
                SelectorFor(this, p => p.Users),
                SelectorFor(this, p => p.Applications),
                SelectorFor(this, p => p.Mailboxes),
            };
        }

        public IWebElement GetMenuElementByName(string name)
        {
            switch (name)
            {
                case "Devices":
                    return Devices;

                case "Users":
                    return Users;

                case "Applications":
                    return Applications;

                case "Mailboxes":
                    return Mailboxes;

                case "Admin":
                    return Admin;

                case "Projects":
                    return Projects;

                case "Dashboards":
                    return Dashboards;

                default:
                    throw new Exception($"'{name}' menu name is not valid menu item and can not be opened");
            }
        }

        public bool IsMenuExpanded()
        {
            return MenuToggleIndicator.GetAttribute("class").Equals(string.Empty);
        }

        public IWebElement GetApplicationVersionElement(string versionNumber)
        {
            var selector = By.XPath(
                $".//div[@class='topnav-footer']//span[contains(text(),'{versionNumber}')]");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"Unable to get application version element with '{versionNumber}' text");
            return Driver.FindElement(selector);
        }
    }
}