using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    class SelfServiceEndUserTextComponentPage : SelfServiceEndClientBasePage
    {
        public bool CheckThatStyledTextFromEndUserTextComponentIsDisplayed(SelfServicePageDto page, string style, string text, string textComponentName)
        {
            var componentitem = GetComponentItemOnEndUserPage(page, textComponentName);
            switch (style)
            {
                case "Bold":
                    return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//strong[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                case "Italic":
                    return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//em[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                case "Underline":
                    return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//u[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                case "Heading 1":
                    return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//h1[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                case "Heading 2":
                    return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//h2[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                case "Heading 3":
                    return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//h3[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                case "Heading 4":
                    return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//h4[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                case "Heading 5":
                    return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//h5[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                case "Normal":
                   return Driver.IsElementInElementDisplayed(componentitem, By.XPath($".//p[text()='{text}']"), WebDriverExtensions.WaitTime.Short);
                default:
                    throw new Exception($"That kind of styling '{style}' does not exist (Do not forget to use capital letter, for ex. 'Bold')");
            }
        }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>{};
        }
    }
}
