using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    public class AddCustomFieldPopup : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@automation='add custom-field']")]
        public IWebElement AddCustomFieldButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@automation='cancel custom-field']")]
        public IWebElement CancelCustomFieldButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AddCustomFieldButton),
                SelectorFor(this, p => p.CancelCustomFieldButton)
            };
        }

        public enum TextBoxes
        {
            [Description("Custom Fields")]
            CustomFields,
            Value
        }
    }
}
