using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    public class SelfServiceEndClientBasePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ssw-header')]")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = ".//das-self-service-footer/div")]
        public IWebElement Footer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ssw-tools']")]
        public IWebElement SelfServiceToolsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='component-error']")]
        public IWebElement componentError { get; set; }

        public string GetComponenErrorMessageOnEndUserPage(string componentName)
        {
            try
            {
                return componentError.FindElement(By.XPath($".//span[contains(text(), '{componentName}')]")).Text;
            }
            catch
            {
                throw new Exception($"Component with '{componentName}' name was not found");
            }      
        }

        public IWebElement GetComponentItemOnEndUserPage(SelfServicePageDto page, string textComponentName)
        {
            var order = page.Components.First(x => x.ComponentName.Equals(textComponentName)).Order;
            var selector = By.XPath($".//h2[text()='{page.Name}']//..//div[contains(@class, 'component-item')][{order}]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool IsComponentDisplayedOnEndUserPage(SelfServicePageDto page, string textComponentName)
        {
            try
            {
                return Driver.IsElementDisplayed(GetComponentItemOnEndUserPage(page, textComponentName));
            } 
            catch
            {
                return false;
            }
            
        }

        public void SetExpectedComponentOrderInDto(SelfServicePageDto page, int order, string textComponentName)
        {
            page.Components.First(x => x.ComponentName.Equals(textComponentName)).Order = order;
        }

        public IWebElement GetButtonOnEndUserPage(string buttonName, WebDriverExtensions.WaitTime waitTime = WebDriverExtensions.WaitTime.Long)
        {
            var time = int.Parse(waitTime.GetValue());
            var selector = By.XPath($".//button//*[text()='{buttonName}']/.. | .//button[text()='{buttonName}']");
            Driver.WaitForDataLoading();
            Driver.WaitForElementsToBeDisplayed(selector, time, false);
            return Driver.FindElement(selector);
        }

        public bool IsButtonDisplayed(string name)
        {
            try
            {
                return GetButtonOnEndUserPage(name, WebDriverExtensions.WaitTime.Short).Displayed();
            }
            catch
            {
                return false;
            }
        }

        public IWebElement SubjectTitleOnEndUserPage(string title)
        {
            var selector = By.XPath($".//div[@class='ssw-title' and text()='{title}']");

            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Medium))
            {
                throw new Exception($"'{title}' subject title was not displayed");
            }
          
            return Driver.FindElement(selector);
        }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p=> p.Header),
            };
        }
    }
}
