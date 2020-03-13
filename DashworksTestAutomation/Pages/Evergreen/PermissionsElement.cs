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
    internal class PermissionsElement : BaseRightSideActionsPanel
    {
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'action-panel-inner-wrapper')]")]
        public IWebElement SharingFormContainer { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@role='listbox']")]
        public IWebElement SharingUserList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='User']")]
        public IWebElement SelectUserDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[@class='userName']")]
        public IList<IWebElement> PermissionAddedUser { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[@class='permission']")]
        public IList<IWebElement> PermissionTypeOfAccess { get; set; }

        //TODO will be replaced COG MENU element
        public IWebElement GetMenuOfSharedUser(string username)
        {
            var sharedUserCogMenu =
                By.XPath($".//td[contains(text(),'{username}')]/following-sibling::td/div[starts-with(@class, 'cog-menu')]//i");
            Driver.MouseHover(sharedUserCogMenu);
            Driver.WaitForElementToBeDisplayed(sharedUserCogMenu);
            return Driver.FindElement(sharedUserCogMenu);
        }

        public IWebElement GetSharingUserOnDetailsPanelByName(string userName)
        {
            var selector = By.XPath($".//tr[contains(@class, 'menu-show-on-hover')]//td[text()='{userName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}