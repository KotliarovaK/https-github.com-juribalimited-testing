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

namespace DashworksTestAutomation.Pages.Evergreen
{
    public class BaseDialogPage : BaseDashboardPage
    {
        private const string PopupSelector = ".//mat-dialog-container[contains(@class, 'dialogContainer')]";

        [FindsBy(How = How.XPath, Using = PopupSelector)]
        public IWebElement PopupElement { get; set; }

        [FindsBy(How = How.XPath, Using = PopupSelector + "//div[@mat-dialog-title]")]
        public IWebElement PopupTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PopupElement)
            };
        }

        #region Button

        public IWebElement GetButton(string button)
        {
            return GetButton(button, this.GetStringByFor(() => this.PopupElement));
        }

        #endregion
    }
}