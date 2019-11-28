using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels
{
    class SelfServiceBuilderContextPanel : BaseRightSideActionsPanel
    {
        [FindsBy(How = How.XPath, Using = ".//button[@class='btn-expand-collapse mat-raised-button mat-button-base ng-star-inserted']")]
        public IWebElement CollapseExpandAllButton { get; set; }


        public IWebElement ContextPanelPageArrow(String contextPanelPageName)
        {
            var selector = $".//div[text()='{contextPanelPageName}']/../../..//button[@class='btn-open-close ng-star-inserted']//i";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }
        
        public IWebElement ContextPanelPageAddItemButton(String contextPanelPageName)
        {
            var selector = $".//div[text()='{contextPanelPageName}']/../../..//i[@class='material-icons mat-item_add']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelPageCogMenuButton(String contextPanelPageName)
        {
            var selector = $".//div[text()='{contextPanelPageName}']/../../..//div[@class='menu-wrapper']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelPageSubCogMenuButton(String contextPanelPageName, String componentHeading, String componentName)
        {
            var selector = $"(.//div[@class='page-level-name' and text()='{contextPanelPageName}']/parent::div/parent::div/following::div//div[@class='page-level-label' and text()='{componentHeading}']/following-sibling::div[@class='page-level-name' and text()='{componentName}']/parent::div/following::div[@class='menu-wrapper'])[1]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public Boolean GetCollapseExpandSelfServiceBuilderPagesButtonState()
        {
            if (CollapseExpandAllButton.GetAttribute("aria-label").Contains("Collapse All"))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void CollapseExpandSelfServiceBuilderContextPanelElements(Boolean collapseExpand)
        {
            if (collapseExpand != GetCollapseExpandSelfServiceBuilderPagesButtonState())
            {
                CollapseExpandAllButton.Click();
            }
        }

        public Boolean GetCollapseExpandSelfServiceBuilderPageButtonState(String contextPanelPageName)
        {
            if (ContextPanelPageArrow(contextPanelPageName).GetAttribute("class").Contains("material-icons mat-arrow_down"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CollapseExpandSelfServiceBuilderPageOnContextPanel(String contextPanelPageName, Boolean collapseExpand)
        {
            if (collapseExpand != GetCollapseExpandSelfServiceBuilderPageButtonState(contextPanelPageName))
            {
                ContextPanelPageArrow(contextPanelPageName).Click();
            }
        }

        public void ClickOnContextPanelPageAddItemButton(String contextPanelPageName)
        {
            ContextPanelPageAddItemButton(contextPanelPageName).Click();
        }

        public void ClickOnContextPanelPageCogMenuButton(String contextPanelPageName)
        {
            ContextPanelPageCogMenuButton(contextPanelPageName).Click();
        }

        public void ClickOnContextPanelPageSubCogMenuButton(String contextPanelPageName, String componentHeading, String componentName)
        {
            ContextPanelPageSubCogMenuButton(contextPanelPageName, componentHeading, componentName).Click();
        }
    }
}
