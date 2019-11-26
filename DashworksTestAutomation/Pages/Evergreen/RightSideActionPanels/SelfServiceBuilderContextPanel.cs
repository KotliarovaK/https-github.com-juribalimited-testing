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
        [FindsBy(How = How.XPath, Using = ".//button[@aria-label='Collapse All']")]
        public IWebElement CollapseAllButton { get; set; }


        public IWebElement ContextPanelPageArrow(String contextPanelPageName)
        {
            var selector = $".//div[text()='{contextPanelPageName}']/../../..//button[@class='btn-open-close ng-star-inserted']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }
        
        public IWebElement ContextPanelPageAddItem(String contextPanelPageName)
        {
            var selector = $".//div[text()='{contextPanelPageName}']/../../..//i[@class='material-icons mat-item_add']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelPageCogMenu(String contextPanelPageName)
        {
            var selector = $".//div[text()='{contextPanelPageName}']/../../..//div[@class='menu-wrapper']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement ContextPanelPageSubCogMenu(String contextPanelPageName, String componentHeading, String componentName)
        {
            var selector = $"(.//div[@class='page-level-name' and text()='{contextPanelPageName}']/parent::div/parent::div/following::div//div[@class='page-level-label' and text()='{componentHeading}']/following-sibling::div[@class='page-level-name' and text()='{componentName}']/parent::div/following::div[@class='menu-wrapper'])[1]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public void ClickOnExpandOrCollapseAllButtonSelfServiceBuilderContextPanel(Boolean collapsExpand)
        {
            
            if (collapsExpand && )
            {

            }
        }
    }
}
