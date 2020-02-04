using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.Builder
{
    public class BuilderMainViewPage : SeleniumBasePage
    {
        public IWebElement BuilderPagePreviewTitle(string pageTitle)
        {
            var pagePreviewTitle = By.XPath($".//div[contains(@class, 'pageView')]//h2[contains(text(), {pageTitle})]");
            Driver.WaitForElementToBeDisplayed(pagePreviewTitle);
            return Driver.FindElement(pagePreviewTitle);
        }
    }
}