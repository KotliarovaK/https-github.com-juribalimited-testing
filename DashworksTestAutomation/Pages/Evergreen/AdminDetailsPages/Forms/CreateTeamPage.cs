using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms
{
    internal class CreateTeamPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'action-container')]/h2")]
        public IWebElement CreateTeamFormTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-primary mat-raised-button')]")]
        public IWebElement CreateTeamButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[contains(@placeholder,'Description')]")]
        public IWebElement TeamDescriptionField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateTeamFormTitle)
            };
        }

        public void SelectObjectForTeamCreation(string objectName)
        {
            var ListNameSelector = $".//span[@class='mat-option-text'][contains(text(), '{objectName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(ListNameSelector));
            Driver.FindElement(By.XPath(ListNameSelector)).Click();
        }
    }
}