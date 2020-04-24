using System;
using System.Collections.Generic;
using AutomationUtils.Utils;
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

        public string ContextPanelPagePath(string contextPanelType, string contextPanelName)
        {
            return $".//div[text()='{contextPanelName}']/preceding-sibling::div[text()='{contextPanelType}']/ancestor::div[contains(@class,'level-info')]";
        }

        public string PageComponentByOrderPath(string componentName, string componentType, string expectedComponentOrder, string contextPanelName, string contextPanelType = "Page")
        {
            var selector = $"{ContextPanelPagePath(contextPanelType, contextPanelName)}//ancestor::div[contains(@class, 'pages-list-inner')]//div[contains(@class, 'page-sublevels')]/div[contains(@class, 'page-sublevels')][{expectedComponentOrder}]//div[text()='{componentName}']/preceding-sibling::div[text()='{componentType}']";
            return selector;
        }

        public IWebElement ContextPanelArrow(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPagePath(contextPanelType, contextPanelName)}/ancestor::div[contains(@class,'page-level')]//i[contains(@class,'arrow')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelPageAddItemButton(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPagePath(contextPanelType, contextPanelName)}/ancestor::div[contains(@class,'page-level')]//i[contains(@class, 'mat-item_add')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelPageCogMenuButton(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPagePath(contextPanelType, contextPanelName)}/following-sibling::div[@class='page-level-icon']/div[contains(@class, 'menu-wrapper')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));

            if (!Driver.IsElementDisplayed(By.XPath(selector), WebDriverExtensions.WaitTime.Short))
            {
                throw new Exception($"Page cog menu button is not displayed");
            }

            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelItem(string contextPanelType, string contextPanelName)
        {
            var selector = ContextPanelPagePath(contextPanelType, contextPanelName);
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
            Driver.WaitForDataLoading();
            Verify.AreEqual(expectedDisplayState, IsContextPanelDisplayed(contextPanelType, contextPanelName),
                $"Builder Context Panel Item Display State is not equal to: {expectedDisplayState}");
        }

        public bool IsContextPanelDisplayed(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPagePath(contextPanelType, contextPanelName)}";
            try
            {
                return Driver.IsElementDisplayed(By.XPath(selector));
            } 
            catch
            {
                return false;
            }
        }

        public bool IsContentPanelHighlighted(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPagePath(contextPanelType, contextPanelName)}/..";
            var bgColor = Driver.FindElement(By.XPath(selector)).GetCssValue("border-color");
            var result = bgColor.Equals("rgb(242, 88, 49)");
            return result;
        }

        public bool IsContentPanelNameTextHighlighted(string contextPanelType, string contextPanelName)
        {
            var selector = $"{ContextPanelPagePath(contextPanelType, contextPanelName)}//div[@class='page-level-name']";
            var bgColor = Driver.FindElement(By.XPath(selector)).GetCssValue("color");
            var result = bgColor.Equals("rgba(0,0,0,.87)");
            return result;
        }

        public bool IsTheComponentOrderInSSBuilderAsExpected(string componentName, string componentType, string expectedComponentOrder, string contextPanelName)
        {
            var selector = PageComponentByOrderPath(componentName, componentType, expectedComponentOrder, contextPanelName);          
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.IsElementExists(By.XPath(selector));
        }
    }
}

