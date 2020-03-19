using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    class SelfServiceEndUserTextComponentPage : SelfServiceEndClientBasePage
    {


        public IWebElement GetStyledTextFromEndUserTextComponent(string style, string text, int order)
        {
            IWebElement element = GetComponentItemOnEndUserPage(order);

            switch (style)
            {
                case "Bold":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//strong[text()='{text}']"));
                    break;
                case "Italic":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//em[text()='{text}']"));
                    break;
                case "Underline":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//u[text()='{text}']"));
                    break;
                case "Heading 1":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//h1[text()='{text}']"));
                    break;
                case "Heading 2":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//h2[text()='{text}']"));
                    break;
                case "Heading 3":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//h3[text()='{text}']"));
                    break;
                case "Heading 4":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//h4[text()='{text}']"));
                    break;
                case "Heading 5":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//h5[text()='{text}']"));
                    break;
                case "Normal":
                    element = GetComponentItemOnEndUserPage(order).FindElement(By.XPath($".//p[text()='{text}']"));
                    break;
                default:
                    throw new Exception($"That kind of styling does not exist (Do not forget to use capital letter, for ex. 'Bold')"); ;
            }

            return element;
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
