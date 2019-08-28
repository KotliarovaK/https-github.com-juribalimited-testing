﻿using System;
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
    class ItemDetails_OffboardElementsPage : SeleniumBasePage
    {
        private string NamedButtonSelector = ".//mat-dialog-container//span[text()='{0}']/ancestor::button";

        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container[contains(@class, 'dialogContainer')]")]
        public IWebElement OffboardPopUp { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.OffboardPopUp)
            };
        }

        public IWebElement GetButtonInOffboardPopUpByName(string buttonName)
        {
            var selector = By.XPath(string.Format(NamedButtonSelector, buttonName));
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}