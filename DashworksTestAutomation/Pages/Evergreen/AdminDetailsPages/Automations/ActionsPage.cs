﻿using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations
{
    internal class ActionsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1[contains(text(), 'Actions')]")]
        public IWebElement ActionssTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ActionssTitle)
            };
        }

        public IWebElement GetMoveButtonByActionName(string action)
        {
            var indexRow = GetActionContent().IndexOf(action);
            var selector = By.XPath($".//div[@row-index='{indexRow}']/div[@col-id='dragColumn']");
            return Driver.FindElement(selector);
        }

        public IList<string> GetActionContent()
        {
            var by = By.XPath(".//div[@col-id='actionName' and @role='gridcell']");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }
    }
}