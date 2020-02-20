﻿using System;
using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels
{
    class SelfServiceBuilderContextPanel : BaseRightSideActionsPanel
    {
        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn-expand-collapse')]")]
        public IWebElement CollapseExpandAllButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.CollapseExpandAllButton)
            };
        }

        public String ContextPanelPage(string contextPanelType, string contextPanelName)
        {
            return $".//div[text()='{contextPanelName}']/preceding-sibling::div[text()='{contextPanelType}']/ancestor::div[contains(@class,'level-info')]";
        }

        public IWebElement ContextPanelArrow(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPage(contextPanelType, contextPanelName)}/ancestor::div[contains(@class,'page-level')]//i[contains(@class,'arrow')";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelPageAddItemButton(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPage(contextPanelType, contextPanelName)}/ancestor::div[contains(@class,'page-level')]//i[contains(@class, 'mat-item_add')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelPageCogMenuButton(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPage(contextPanelType, contextPanelName)}/ancestor::div[contains(@class,'level')]//div[contains(@class, 'menu-wrapper')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public Boolean GetCollapseExpandButtonState()
        {
            return CollapseExpandAllButton.GetAttribute("aria-label").Contains("Collapse All");
        }

        public void CollapseExpandAllElementsOnSelfServiceBuilderContextPanel(Boolean collapseExpand)
        {
            if (!collapseExpand.Equals(GetCollapseExpandButtonState()))
            {
                CollapseExpandAllButton.Click();
            }
        }

        public Boolean GetCollapseExpandSelfServiceBuilderPageButtonState(string contextPanelType, string contextPanelName)
        {
            if (ContextPanelArrow(contextPanelType, contextPanelName).GetAttribute("class").Contains("mat-arrow_down"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CollapseExpandSelfServiceBuilderPageOnContextPanel(Boolean collapseExpand, string contextPanelType, string contextPanelName)
        {
            if (!collapseExpand.Equals(GetCollapseExpandSelfServiceBuilderPageButtonState(contextPanelType, contextPanelName)))
            {
                ContextPanelArrow(contextPanelType, contextPanelName).Click();
            }
        }

        public void CheckBuilderContextPanelItemDisplayState(string contextPanelType, string contextPanelName, bool expectedDisplayState)
        {
            var selector = $"{ContextPanelPage(contextPanelType, contextPanelName)}";
            Verify.AreEqual(expectedDisplayState, Driver.IsElementDisplayed(Driver.FindElement(By.XPath(selector)),
                WebDriverExtensions.WaitTime.Short), $"Builder Context Panel Item Display State isn't: {expectedDisplayState}");
        }

        public bool IsContentPanelHighlighted(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPage(contextPanelType, contextPanelName)}/..";
            var bgColor = Driver.FindElement(By.XPath(selector)).GetCssValue("border-color");
            var result = bgColor.Equals("rgb(242, 88, 49)");
            return result;
        }
    }
}

