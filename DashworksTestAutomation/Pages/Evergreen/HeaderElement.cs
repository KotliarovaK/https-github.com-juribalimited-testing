using System.Collections.Generic;
using AutomationUtils.Utils;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Logger = DashworksTestAutomation.Utils.Logger;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class HeaderElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//button[@class='dropdown-toggle user-name notifications notif-area']")]
        public IWebElement UserNotificationsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='message message-info']")]
        public IWebElement UserNotificationsMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='col-ds-visible user-area user-name-words']")]
        public IWebElement UserNameDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-profile']")]
        public IWebElement ProfileButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-logout']")]
        public IWebElement LogOutButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='user-actions']/li")]
        public IList<IWebElement> MenuItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='user-actions']")]
        public IWebElement UserItemsMenu { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.UserNameDropdown)
            };
        }

        public void LogOut()
        {
            UserNameDropdown.Click();
            Driver.WaitForElementToBeDisplayed(LogOutButton);

            //Verifies DAS-10827

            #region Check menu Items

            Logger.Write("Check User account menu items count");
            Verify.AreEqual(2, MenuItems.Count, "PLEASE ADD EXCEPTION MESSAGE");
            Verify.IsTrue(ProfileButton.Displayed(), "My Profile menu item is not displayed");

            #endregion Check menu Items

            LogOutButton.Click();
        }
    }
}