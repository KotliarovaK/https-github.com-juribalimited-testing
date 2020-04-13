using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.Components
{
    public class TextComponentPage : SeleniumBasePage

    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='ql-toolbar ql-snow']")]
        public IWebElement ToolbarWithFormattingOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='ql-bold']")]
        public IWebElement BoldStyleButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='ql-italic']")]
        public IWebElement ItalicStyleButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='ql-underline']")]
        public IWebElement UnderlineStyleButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ql-picker-label']")]
        public IWebElement HeadersPickerButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ql-picker-options']/span")]
        public IList<IWebElement> HeaderOptions { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ToolbarWithFormattingOptions)
            };
        }
    }
}