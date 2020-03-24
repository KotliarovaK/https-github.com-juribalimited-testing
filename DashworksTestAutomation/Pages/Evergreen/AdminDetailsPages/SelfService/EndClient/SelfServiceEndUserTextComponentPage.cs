using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    class SelfServiceEndUserTextComponentPage : SelfServiceEndClientBasePage
    {
        public bool CheckThatStyledTextFromEndUserTextComponentIsDisplayed(string pageName, string style, string text, int order)
        {
            switch (style)
            {
                case "Bold":
                    return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//strong[text()='{text}']"));
                case "Italic":
                    return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//em[text()='{text}']"));
                case "Underline":
                    return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//u[text()='{text}']"));
                case "Heading 1":
                    return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//h1[text()='{text}']"));
                case "Heading 2":
                    return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//h2[text()='{text}']"));
                case "Heading 3":
                    return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//h3[text()='{text}']"));
                case "Heading 4":
                    return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//h4[text()='{text}']"));
                case "Heading 5":
                    return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//h5[text()='{text}']"));
                case "Normal":
                   return GetComponentItemOnEndUserPage(pageName, order).IsElementDisplayed(By.XPath($".//p[text()='{text}']"));
                default:
                    throw new Exception($"That kind of styling '{style}' does not exist (Do not forget to use capital letter, for ex. 'Bold')"); ;
            }
        }

        public int GetTextComponentOrderByName(BaseSelfServiceComponent component)
        {
            return component.Order;
        }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {

            };
        }
    }
}
