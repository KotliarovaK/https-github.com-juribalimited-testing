using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    public class BaseRightSideActionsPanel : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='device-context-header']")]
        public IWebElement PanelHeaderElement { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='device-label']")]
        public IWebElement PanelTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'context-header')]//button[contains(@class,'pull-left')][last()]//i[contains(@class,'mat-clear')]")]
        public IWebElement ClosePanelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'sub-categories-item')]")]
        public IList<IWebElement> ColumnSubcategories { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }

        public bool IsPanelOpened(string panelTitleText)
        {
            try
            {
                Driver.WaitForElementToContainsText(PanelTitle, panelTitleText, 10);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}