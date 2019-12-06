using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    public class BaseInlineTipBannerElement : BaseDashboardPage
    {
        private const string InlineTipSelector = ".//div[contains(@class,'inline')][@role='alert']";

        [FindsBy(How = How.XPath, Using = InlineTipSelector)]
        public IWebElement InlineTipElement { get; set; }

        [FindsBy(How = How.XPath, Using = InlineTipSelector + "//span[@class='ng-star-inserted']")]
        public IWebElement SecondPartOfText { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.InlineTipElement)
            };
        }

        #region Verify

        public void VerifyMessageTextAndColor(MessageColors messageColor, string expectedText)
        {
            VerifyColor(messageColor);

            VerifyText(messageColor, expectedText);
        }

        public void VerifyColor(MessageColors messageColor)
        {
            Verify.AreEqual(messageColor.GetValueAndDescription().Value, GetColor(),
                $"Inline tip banner is not {messageColor.ToString()}");
        }

        public void VerifyText(MessageColors messageColor, string expectedText)
        {
            Verify.IsTrue(IsTextPresent(expectedText),
                $"{messageColor.ToString()} inline tip banner with '{expectedText}' text is not displayed");
        }

        public void VerifySecondPartOfText(MessageColors messageColor, string expectedText)
        {
            Verify.IsTrue(IsSecondPartOfTextPresent(expectedText),
                $"{messageColor.ToString()} inline tip banner with '{expectedText}' text in the second part of banner is not displayed");
        }

        #endregion

        #region Text

        public bool IsTextPresent(string expectedText)
        {
            //Wait for banner with text
            Driver.WaitForElementToContainsText(InlineTipElement, expectedText);
            //Check that exact text is displayed in the banner
            return Driver.IsElementExists(By.XPath($"{InlineTipSelector}[text()='{expectedText}']"));
        }

        public bool IsSecondPartOfTextPresent(string expectedText)
        {
            return SecondPartOfText.Text.Equals(expectedText);
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

        public new void ClickButton(string buttonName)
        {
            throw new Exception("Not implemented in this page");
        }

        #endregion
    }

    public enum MessageColors
    {
        [Description("rgba(235, 175, 37, 1)")]
        Amber,
        [Description("rgba(242, 88, 49, 1)")]
        Red,
        [Description("rgba(126, 189, 56, 1)")]
        Green
    }
}
