using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    public class BaseInlineTipBannerElement : BaseDashboardPage
    {
        private const string InlineTipSelector = ".//div[contains(@class, 'inline-tip')]";

        [FindsBy(How = How.XPath, Using = InlineTipSelector)]
        public IWebElement InlineTipElement { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.InlineTipElement)
            };
        }

        #region Text

        public bool IsTextPresent(string expectedText)
        {
            //Wait for banner with text
            Driver.WaitForElementToContainsText(InlineTipElement, expectedText);
            //Check that exact text is displayed in the banner
            return Driver.IsElementExists(By.XPath($"{InlineTipSelector}[text()='{expectedText}']"));
        }

        #endregion

        #region Color

        public string GetColor()
        {
            return InlineTipElement.GetCssValue("background-color");
        }

        #endregion

        #region Button

        public IWebElement GetButton(string button)
        {
            return GetButton(button, this.GetStringByFor(() => this.InlineTipElement));
        }

        public new bool IsButtonDisplayed(string name)
        {
            try
            {
                return this.GetButton(name).Displayed();
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
