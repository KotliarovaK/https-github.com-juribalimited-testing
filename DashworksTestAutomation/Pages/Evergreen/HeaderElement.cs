using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class HeaderElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//span[@class='col-ds-visible user-area user-name-words']")]
        public IWebElement UserNameDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-profile']")]
        public IWebElement ProfileButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-logout']")]
        public IWebElement LogOutButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='user-actions']/li")]
        public IList<IWebElement> MenuItems { get; set; }

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
            Driver.WaitWhileControlIsNotDisplayed<HeaderElement>(() => LogOutButton);

            //Verifies DAS-10827

            #region Check menu Items

            Logger.Write("Check User account menu items count");
            Assert.AreEqual(2, MenuItems.Count);
            Assert.IsTrue(ProfileButton.Displayed(), "My Profile menu item is not displayed");

            #endregion Check menu Items

            LogOutButton.Click();
        }
    }
}