﻿using System;
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
    public class BaseInlineBannerElement : BaseDashboardPage
    {
        private const string InlineTipSelector = ".//div[contains(@class,'inline-tip')]";
        private const string InlineErrorSelector = ".//div[contains(@class,'inline-error')]";
        private const string InlineSuccessSelector = ".//div[contains(@class,'inline-success')]";
        private const string InlineInfoSelector = ".//div[contains(@class,'inline-info')]";

        [FindsBy(How = How.XPath, Using = InlineTipSelector)]
        private IWebElement InlineTipElement { get; set; }

        [FindsBy(How = How.XPath, Using = InlineErrorSelector)]
        private IWebElement InlineErrorElement { get; set; }

        [FindsBy(How = How.XPath, Using = InlineSuccessSelector)]
        private IWebElement InlineSuccessElement { get; set; }

        [FindsBy(How = How.XPath, Using = InlineInfoSelector)]
        private IWebElement InlineInfoElement { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By> { };
        }

        public IWebElement GetInlineBanner(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Tip:
                    return InlineTipElement;
                case MessageType.Error:
                    return InlineErrorElement;
                case MessageType.Success:
                    return InlineSuccessElement;
                default:
                    throw new Exception($"Unknown message type: {messageType.ToString()}");
            }
        }

        public string GetInlineBannerSelector(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Tip:
                    return InlineTipSelector;
                case MessageType.Error:
                    return InlineErrorSelector;
                case MessageType.Success:
                    return InlineSuccessSelector;
                default:
                    throw new Exception($"Unknown message type: {messageType.ToString()}");
            }
        }

        public IWebElement SecondPartOfText(MessageType messageType)
        {
            return GetInlineBanner(messageType).FindElement(By.XPath(".//span[@class='ng-star-inserted']"));
        }

        #region Verify

        public void VerifyMessageTextAndColor(MessageType messageType, string expectedText)
        {
            VerifyText(messageType, expectedText);
            VerifyColor(messageType);
        }

        public void VerifyColor(MessageType messageType)
        {
            Verify.AreEqual(messageType.GetValueAndDescription().Value, GetColor(messageType),
                $"{messageType.GetValueAndDescription().Key} inline banner is not {messageType.GetValueAndDescription().Value}");
        }

        public void VerifyText(MessageType messageType, string expectedText)
        {
            Verify.IsTrue(IsTextPresent(messageType, expectedText),
                $"{messageType.ToString()} inline banner with '{expectedText}' text is not displayed");
        }

        public void VerifySecondPartOfText(MessageType messageType, string expectedText)
        {
            Verify.IsTrue(IsSecondPartOfTextPresent(messageType, expectedText),
                $"{messageType.ToString()} inline banner with '{expectedText}' text in the second part of banner is not displayed");
        }

        #endregion

        #region Text

        public bool IsTextPresent(MessageType messageType, string expectedText)
        {
            //Wait for banner with text
            Driver.WaitForElementToContainsText(GetInlineBanner(messageType), expectedText);
            //Check that exact text is displayed in the banner
            return Driver.IsElementExists(By.XPath($"{GetInlineBannerSelector(messageType)}[text()='{expectedText}']"));
        }

        public bool IsSecondPartOfTextPresent(MessageType messageType, string expectedText)
        {
            return SecondPartOfText(messageType).Text.Equals(expectedText);
        }

        #endregion

        #region Color

        public string GetColor(MessageType messageType)
        {
            return GetInlineBanner(messageType).GetCssValue("background-color");
        }

        #endregion

        #region Button

        public IWebElement GetButton(MessageType messageType, string button)
        {
            return GetButton(button, this.GetStringByFor(() => this.GetInlineBanner(messageType)));
        }

        public bool IsButtonDisplayed(MessageType messageType, string name)
        {
            try
            {
                return this.GetButton(messageType, name).Displayed();
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

    public enum MessageType
    {
        [Description("rgba(235, 175, 37, 1)")]//Amber
        Tip,
        [Description("rgba(242, 88, 49, 1)")]//Red
        Error,
        [Description("rgba(126, 189, 56, 1)")]//Green
        Success,
        Info
    }
}
