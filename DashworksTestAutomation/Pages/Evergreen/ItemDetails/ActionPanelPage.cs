using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    class ActionPanelPage : SeleniumBasePage
    {
        //Button for deleting confirmation
        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'button-small mat-raised-button')]/span[text()='DELETE']")]
        public IWebElement DeleteButtonOnPage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                //SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }
    }
}