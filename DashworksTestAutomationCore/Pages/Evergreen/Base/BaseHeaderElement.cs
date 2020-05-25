using System;
using System.Collections.Generic;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    //!!!Element with header and breadcrumbs under grid!!!
    public class BaseHeaderElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1 | .//div[contains(@class, 'ssw-header')]")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@id,'pagetitle')]//a[contains(@class,'subTitle')]")]
        public IList<IWebElement> Breadcrumbs { get; set; }

        #region Right side buttons

        [FindsBy(How = How.XPath, Using = ".//i[contains(@class, 'static-list')]/ancestor::button")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'listDtlBtn')]")]
        public IWebElement ListDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='showDashboardDetails']")]
        public IWebElement DashboardsDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'permissionsModeBtn')]")]
        public IWebElement PermissionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'showDashboardPermissions')]")]
        public IWebElement DashboardPermissionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'clmnBtn')]")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'associationsList')]")]
        public IWebElement AssociationButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'pivotModeBtn')]")]
        public IWebElement PivotButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'fltrBtn')]")]
        public IWebElement FilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[text()='insert_drive_file']/ancestor::button")]
        public IWebElement PagesButton { get; set; }

        #endregion

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Header)
            };
        }

        public void CheckPageHeader(string text)
        {
            Driver.WaitForElementToHaveText(Header, text, 10, false);
            Verify.AreEqual(text, Header.Text, "Incorrect page header");
        }

        public void CheckPageHeaderContainsText(string text)
        {
            Driver.WaitForElementToContainsText(Header, text, 10, false);
            Verify.IsTrue(Header.Text.ToLower().Contains(text.ToLower()), $"Page header do not contains '{text}' text");
        }

        public void ClickBreadcrumb(string breadcrumb)
        {
            Driver.WaitForElementToContainsText(Breadcrumbs, breadcrumb);

            Breadcrumbs.First(x => x.Text.Equals(breadcrumb)).Click();
        }
    }
}
