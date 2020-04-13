using System;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_AdminPage_Messages : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_Messages(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"User clicks ""(.*)"" button in warning container on the Admin page")]
        public void ThenUserClicksButtonInWarningContainerOnTheAdminPage(string buttonName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.GetButtonOnWarningContainerByName(buttonName).Click();
        }

        [Then(@"Warning Pop-up is not displayed")]
        public void ThenWarningPop_UpIsNotDisplayed()
        {
            var page = _driver.NowAt<ProjectsPage>();
            Verify.IsFalse(page.WarningPopUp.Displayed(), "Warning Pop-up is displayed");
        }

        [Then(@"Blue banner with ""(.*)"" text is displayed")]
        public void ThenBlueBannerWithTextIsDisplayed(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            //_driver.WaitForElementToBeDisplayed(page.BlueBanner);
            Verify.Contains(text, page.BlueBanner.Text, "Blue banner is not displayed");
        }

        [When(@"User close message on the Admin page")]
        public void WhenUserCloseMessageOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.CloseMessageButton.Click();
            _driver.WaitForElementToBeNotDisplayed(page.CloseMessageButton);
        }

        [Then(@"Info message is displayed and contains ""(.*)"" text")]
        public void ThenInfoMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.BlueBanner);
            Verify.AreEqual("rgba(49, 122, 193, 1)", page.BlueBanner.GetCssValue("background-color"), "Info message is not Blue"); //Blue color
            //Verify.AreEqual("1530px", page.GetMessageWidthOnAdminPage());
            Verify.Contains(text, page.BlueBanner.Text, "Success Message is not displayed");
        }

        [Then(@"""(.*)"" error in the Scope Changes displayed to the User")]
        public void ThenErrorInTheScopeChangesDisplayedToTheUser(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.ScopeChangesError);
            Verify.AreEqual(text, page.ScopeChangesError.Text, "Error Message is not displayed in the Scope Changes");
        }

        [Then(@"'(.*)' message is displayed on empty greed")]
        public void ThenMessageIsDisplayedOnEmptyGreed(string message)
        {
            var page = _driver.NowAt<BaseGridPage>();
            if (_driver.IsElementDisplayed(page.NoFoundMessage, WebDriverExtensions.WaitTime.Medium))
                Verify.AreEqual(message, page.NoFoundMessage.Text, $"'{message}' is not displayed on empty greed");
            else
                throw new Exception("Empty greed message is not displayed or greed not empty");
        }

        //TODO this method should be replaced by generic: ThenMessageIsDisplayedOnEmptyGreed
        [Then(@"""(.*)"" message is displayed on the Admin Page")]
        public void ThenMessageIsDisplayedOnTheAdminPage(string message)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.NoFoundMessage);
            Verify.AreEqual(message, page.NoFoundMessage.Text, $"{message} is not displayed");
        }

        [Then(@"User sees banner at the top of work area")]
        public void ThenUserSeesBannerAtTheTopOfWorkArea()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.Banner);
            Verify.That(page.Banner.Displayed, Is.True, "Banner is not displayed");
        }

        //TODO remove this and replace by something from BaseInlineBannerElement
        [When(@"User clicks newly created object link")]
        public void WhenUserClicksNewlyCreatedObjectLink()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(projectElement.NewProjectLink);
            projectElement.NewProjectLink.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Filling field error is not displayed")]
        public void ThenFillingFieldErrorIsNotDisplayed()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(page.FieldWarningMessage.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Verify.IsFalse(page.UnderFieldWarningIcon.Displayed(), "Filling field error is displayed");
        }
    }
}
