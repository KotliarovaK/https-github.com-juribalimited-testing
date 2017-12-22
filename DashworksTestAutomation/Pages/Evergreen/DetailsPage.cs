using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class DetailsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='tabContainer ng-star-inserted']")]
        public IWebElement TabContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoMailboxOwnerFoundMessage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TabContainer)
            };
        }

        public void NavigateToSectionByName(string sectionName)
        {
            var section = Driver.FindElement(
                By.XPath($".//button[@class='btn btn-default blue-color mat-icon-button ng-star-inserted'][@aria-label='{sectionName}']"));
            section.Click();
        }

        public void ExpandAllSections()
        {
            var expandButtons = Driver.FindElements(By.XPath(".//button[@title='Maximize Group']"));

            if (expandButtons.Any())
            {
                foreach (IWebElement button in expandButtons)
                {
                    Driver.MouseHover(button);
                    button.Click();
                    Driver.WaitForDataLoading();
                }
            }
        }

        public void CloseAllSections()
        {
            var closeButtons = Driver.FindElements(By.XPath(".//button[@title='Minimize Group']"));

            if (closeButtons.Any())
            {
                foreach (IWebElement button in closeButtons)
                {
                    Driver.MouseHover(button);
                    button.Click();
                    Driver.WaitForDataLoading();
                }
            }
        }

        public List<KeyValuePair<string, string>> GetFieldsWithContent(string categoryName)
        {
            //Hover on header to be able to see all table with all values
            //In other case elements outside the bounds of the screen will have empty text
            Driver.MouseHover(By.XPath($".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']"));
            List <string> allHeaders = Driver
                .FindElements(By.XPath(
                    $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/../..//tbody/tr/td[1]"))
                .Select(x => x.Text).ToList();
            List<string> allContent = Driver
                .FindElements(By.XPath(
                    $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/../..//tbody/tr/td[2]"))
                .Select(x => x.Text).ToList();

            return allHeaders.Select((t, i) => new KeyValuePair<string, string>(t, allContent[i])).ToList();
        }

        public void CheckThatAllContentIsNotEmpty()
        {
            var allFieldsContent = Driver.FindElements(By.XPath(".//tbody/tr/td[2]"));

            foreach (IWebElement element in allFieldsContent)
            {
                Assert.IsFalse(string.IsNullOrEmpty(element.Text));
            }
        }
    }
}