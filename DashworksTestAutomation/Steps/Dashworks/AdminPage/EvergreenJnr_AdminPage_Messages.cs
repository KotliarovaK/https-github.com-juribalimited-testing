using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_AdminPage_Messages : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly RunNowAutomationStartTime _automationStartTime;

        public EvergreenJnr_AdminPage_Messages(RemoteWebDriver driver, RunNowAutomationStartTime automationStartTime)
        {
            _driver = driver;
            _automationStartTime = automationStartTime;
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
            Utils.Verify.IsFalse(page.WarningPopUp.Displayed(), "Warning Pop-up is displayed");
        }

        [Then(@"Blue banner with ""(.*)"" text is displayed")]
        public void ThenBlueBannerWithTextIsDisplayed(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            //_driver.WaitForElementToBeDisplayed(page.BlueBanner);
            Utils.Verify.Contains(text, page.BlueBanner.Text, "Blue banner is not displayed");
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

        [Then(@"Success message is displayed and contains ""(.*)"" text")]
        public void ThenSuccessMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToContainsText(page.SuccessMessage, text);
            Verify.AreEqual("rgba(126, 189, 56, 1)", page.SuccessMessage.GetCssValue("background-color"), "Success message is not Green"); //Green color
            Verify.Contains(text, page.SuccessMessage.Text, "Success Message is not displayed");
        }

        [Then(@"Green banner contains following text ""(.*)""")]
        public void ThenGreenBannerContainsFollowingText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.SuccessMessage);
            Verify.Contains(text, page.SuccessMessageThirdPart.Text, "Success Message is not displayed");
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
            Utils.Verify.That(page.Banner.Displayed, Is.True, "Banner is not displayed");
        }

        [Then(@"Success message is displayed correctly")]
        public void ThenSuccessMessageIsDisplayedCorrectly()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.SuccessMessage);
            Utils.Verify.AreEqual("rgba(126, 189, 56, 1)", page.GetMessageColor(), "PLEASE ADD EXCEPTION MESSAGE"); //Green color
            //TODO update web element or move this assertion to separate step after Olga replay in https://juriba.atlassian.net/browse/DAS-14037
            //Utils.Verify.False(_driver.IsElementHaveHorizontalScrollbar(
            //        _driver.FindElement(By.XPath(".//admin-project-units-list/.."))), "Table has scrollbar");
        }

        [Then(@"Success message The ""(.*)"" bucket has been updated is displayed on the Buckets page")]
        public void ThenSuccessMessageTheBucketHasBeenUpdatedIsDisplayedOnTheBucketsPage(string bucketName)
        {
            var pageBase = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(pageBase.SuccessMessage);
            var pageBuckets = _driver.NowAt<BucketsPage>();
            Verify.IsTrue(pageBuckets.SuccessUpdatedMessageBucketsPage(bucketName),
                $"Success Message is not displayed for {bucketName}");
        }

        [Then(@"Success message with ""(.*)"" text is displayed on the Projects page")]
        public void ThenSuccessMessageWithTextIsDisplayedOnTheProjectsPage(string textMessage)
        {
            BaseGridPage projectElement;
            try
            {
                projectElement = _driver.NowAt<BaseGridPage>();
            }
            catch (WebDriverTimeoutException)
            {
                try
                {
                    projectElement = _driver.NowAt<BaseGridPage>();
                }
                catch (WebDriverTimeoutException)
                {
                    projectElement = _driver.NowAt<BaseGridPage>();
                }
            }

            _driver.WaitForElementToBeDisplayed(projectElement.SuccessMessage);
            Thread.Sleep(10000);
            Verify.IsTrue(projectElement.TextMessage(textMessage),
                $"{textMessage} is not displayed on the Project page");
        }

        [When(@"User clicks newly created object link")]
        public void WhenUserClicksNewlyCreatedObjectLink()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(projectElement.NewProjectLink);
            projectElement.NewProjectLink.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Error message is not displayed on the Capacity Units page")]
        [Then(@"Error message is not displayed on the Capacity Slots page")]
        [Then(@"Error message is not displayed on the Projects page")]
        public void ThenErrorMessageIsNotDisplayedOnTheProjectsPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsFalse(page.ErrorMessage.Displayed(), "Error Message is displayed");
        }

        [Then(@"Warning message is not displayed on the Admin page")]
        public void ThenWarningMessageIsNotDisplayedOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsFalse(page.WarningMessage.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Success message is not displayed on the Admin page")]
        public void ThenSuccessMessageIsNotDisplayedOnTheAdminPage()
        {
            var message = _driver.NowAt<BaseGridPage>();
            //TODO Remove wait for message after fixing for Automation (5.07.19)
            if (message.SuccessMessage.Displayed())
            {
                Thread.Sleep(3000);
            }
            Utils.Verify.IsFalse(message.SuccessMessage.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Success message is not displayed")]
        public void ThenSuccessMessageIsNotDisplayed()
        {
            var message = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(message.SuccessMessage.Displayed(), "Success message is displayed!");
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
