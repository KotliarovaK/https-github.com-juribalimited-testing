using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using HtmlAgilityPack;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class ListDetailsElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='listPanel']")]
        public IWebElement ListDetailsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List Name']")]
        public IWebElement ListNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='device-context-panel']//button")]
        public IWebElement CloseListDetailsPanelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[contains(@class,'material-icons pull-left list-star-icon')]")]
        public IWebElement FavoriteButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//i[contains(@class,'material-icons pull-left list-star-icon star-filled')]")]
        public IWebElement UnfavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='favourite']")]
        public IWebElement ActiveFavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='btn btn-default btn-remove mat-icon-button _mat-animation-noopable']")]
        public IWebElement RemoveListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='btn mat-button _mat-animation-noopable']")]
        public IWebElement DeleteButtonInTheWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions action-panel-ddl']")]
        public IWebElement PermissionsBlock { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions action-panel-ddl']//button[@title='Close']")]
        public IWebElement ClosePermissionBlockButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Owner']")]
        public IWebElement OwnerDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-labelledby='sharing-label']")]
        public IWebElement SharingDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ACCEPT']/ancestor::button")]
        public IWebElement AcceptButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CANCEL']/ancestor::button")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-item_add ng-star-inserted']")]
        public IWebElement OpenDependantsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-clear ng-star-inserted']")]
        public IWebElement ClosePermissionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='dependants action-panel-ddl ng-star-inserted']")]
        public IWebElement DependantsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-item']")]
        public IWebElement ExpandedDependantsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='User']")]
        public IWebElement SelectUserDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Select access']/ancestor::div[@class='mat-select-trigger']")]
        public IWebElement SelectAccessDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD USER']/ancestor::button")]
        public IWebElement AddUserButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-tip ng-star-inserted']")]
        public IWebElement WarningMessage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ListDetailsPanel)
            };
        }

        public IWebElement ListNameInDependantsSection(string listName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath($".//a[@class='ng-star-inserted'][text()='{listName}']"));
            return Driver.FindElement(By.XPath($".//a[@class='ng-star-inserted'][text()='{listName}']"));
        }

        public void OpenPermissionsSection(string tooltipText)
        {
            var openPermissionsSection = Driver.FindElement(By.XPath(
                ".//i[@class='material-icons mat-item_add ng-star-inserted']")).GetAttribute("aria-describedby");
            var pageSource = Driver.PageSource;
            var doc = new HtmlDocument();
            doc.LoadHtml(pageSource);
            var node = doc.DocumentNode.SelectNodes($".//div[@id='{openPermissionsSection}']")[0];
            var openPermissionsSectionTooltip = node.InnerHtml;
            Assert.AreEqual(tooltipText, openPermissionsSectionTooltip, "Tooltip is incorrect for button");
        }

        public string GetSelectedValue(IWebElement dropdown)
        {
            return dropdown.FindElement(By.XPath(".//span[contains(@class, 'mat-select-value-text')]/span")).Text;
        }
    }
}