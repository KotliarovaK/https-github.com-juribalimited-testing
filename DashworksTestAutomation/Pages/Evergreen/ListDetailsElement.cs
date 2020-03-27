using System.Collections.Generic;
using AutomationUtils.Utils;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using HtmlAgilityPack;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class ListDetailsElement : SeleniumBasePage
    {
        public const string Owner = ".//mat-option[@role='option']";

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'context-container')]//div[contains(@class, 'header')]/span[contains(text(), 'Details')]")]
        public IWebElement ListDetailsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List Name']")]
        public IWebElement ListNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='device-context-panel']//button")]
        public IWebElement CloseListDetailsPanelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[contains(@class, 'delete')]/ancestor::button")]
        public IWebElement RemoveListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'list-notification ng-star-inserted')]//button[contains(@class,'btn mat-button')]")]
        public IWebElement DeleteButtonInTheWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions action-panel-ddl']")]
        public IWebElement PermissionsBlock { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions action-panel-ddl']//button[@title='Close']")]
        public IWebElement ClosePermissionBlockButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Owner'][contains(@class, 'ng-pristine ng-valid')]")]
        public IWebElement AvailableOwnerField { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons mat-item_add ng-star-inserted']")]
        public IWebElement DependantsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-item_add ng-star-inserted']")]
        public IWebElement OpenDependantsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-clear ng-star-inserted']")]
        public IWebElement ClosePermissionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='dependants action-panel-ddl ng-star-inserted']")]
        public IWebElement DependantsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-group ng-star-inserted']//table")]
        public IWebElement ExpandedDependantsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-tip ng-star-inserted']")]
        public IWebElement WarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[@class='userName']")]
        public IList<IWebElement> PermissionAddedUser { get; set; }

        [FindsBy(How = How.XPath, Using = ".//td[@class='permission']")]
        public IList<IWebElement> PermissionTypeOfAccess { get; set; }

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
            Driver.WaitForElementToBeDisplayed(By.XPath($".//a[@class='ng-star-inserted'][text()='{listName}']"));
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
            Verify.AreEqual(tooltipText, openPermissionsSectionTooltip, "Tooltip is incorrect for button");
        }

        public IWebElement GetDependentListByName(string listName)
        {
            var selector = By.XPath($"//a[text()='{listName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetListDetailsLabelByText(string text)
        {
            var selector = By.XPath($".//div[@class='listPanel']//*[contains(text(),'{text}')]");

            try
            {
                return Driver.FindElement(selector);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
    }
}