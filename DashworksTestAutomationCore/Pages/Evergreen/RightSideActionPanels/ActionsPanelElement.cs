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
    public class ActionsPanelElement : BaseRightSideActionsPanel
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='actions-container']")]
        public IWebElement ActionsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'actions-container-row')]")]
        public IWebElement RowsCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'actions-container-row-select-empty')]")]
        public IWebElement ActionsPanelMessage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            Driver.WaitForDataLoadingInActionsPanel();
            return new List<By>
            {
                SelectorFor(this, p => p.ActionsPanel)
            };
        }
    }
}
