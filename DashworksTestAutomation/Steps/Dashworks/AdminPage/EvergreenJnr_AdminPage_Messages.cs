using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
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
            Utils.Verify.IsFalse(page.WarningPopUp.Displayed(), "Warning Pop-up is displayed");
        }

        [Then(@"Blue banner with ""(.*)"" text is displayed")]
        public void ThenBlueBannerWithTextIsDisplayed(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            //_driver.WaitForElementToBeDisplayed(page.BlueBanner);
            Utils.Verify.Contains(text, page.BlueBanner.Text, "Blue banner is not displayed");
        }

        [Then(@"Warning message with ""(.*)"" text is displayed on the Admin page")]
        public void ThenWarningMessageWithTextIsDisplayedOnTheAdminPage(string text)
        {
            BaseGridPage message;
            try
            {
                message = _driver.NowAt<BaseGridPage>();
            }
            catch (WebDriverTimeoutException)
            {
                try
                {
                    message = _driver.NowAt<BaseGridPage>();
                }
                catch (WebDriverTimeoutException)
                {
                    message = _driver.NowAt<BaseGridPage>();
                }
            }

            _driver.WaitForElementToContainsText(message.WarningMessage, text);
            Utils.Verify.AreEqual("rgba(235, 175, 37, 1)", message.GetMessageColor(), "PLEASE ADD EXCEPTION MESSAGE"); //Amber color
            //Waiting for message text change
            Thread.Sleep(1000);
            Utils.Verify.IsTrue(message.TextMessage(text),
                $"{text} is NOT displayed on the Project page");
        }

        [Then(@"Warning message with ""(.*)"" text is not displayed on the Admin page")]
        public void ThenWarningMessageWithTextIsNotDisplayedOnTheAdminPage(string text)
        {
            BaseGridPage message;
            try
            {
                message = _driver.NowAt<BaseGridPage>();
            }
            catch (WebDriverTimeoutException)
            {
                message = _driver.NowAt<BaseGridPage>();
            }

            //If there is no banner on page then there are no message at all. All good
            if (!_driver.IsElementDisplayed(message.Banner, WebDriverExtensions.WaitTime.Short))
                return;

            _driver.WaitForElementToNotContainsText(message.WarningMessage, text);
        }

        [When(@"User clicks Cancel button in the warning message on the Admin page")]
        public void WhenUserClicksCancelButtonInTheWarningMessageOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.CancelButtonInWarningMessage);
            page.CancelButtonInWarningMessage.Click();
            Verify.IsFalse(page.WarningMessage.Displayed(), "Warning message was not disappears after Cancel button click.");
        }

        //TODO move to the Generic class
        [When(@"User clicks Delete button in the warning message")]
        public void WhenUserClicksDeleteButtonInTheWarningMessage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(button.WarningMessage);
            button.DeleteButtonInWarningMessage.Click();
            Logger.Write("Delete button was clicked");
        }

        [When(@"User clicks ""(.*)"" button in the warning message on Admin page")]
        public void WhenUserClicksButtonInTheWarningMessageOnAdminPage(string buttonName)
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitForElementToBeDisplayed(button.WarningMessage);
            button.GetButtonInWarningMessage(buttonName).Click();
            Logger.Write($"{buttonName} button was clicked");
        }

        [When(@"User clicks '(.*)' button in the warning message")]
        public void WhenUserClicksButtonInTheWarningMessage(string buttonName)
        {
            var button = _driver.NowAt<BaseGridPage>();
            button.GetMessageButtonByName(buttonName).Click();
            Logger.Write($"{buttonName} button was clicked");
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
            Utils.Verify.AreEqual("rgba(49, 122, 193, 1)", page.BlueBanner.GetCssValue("background-color"), "Info message is not Blue"); //Blue color
            //Utils.Verify.AreEqual("1530px", page.GetMessageWidthOnAdminPage());
            Utils.Verify.Contains(text, page.BlueBanner.Text, "Success Message is not displayed");
        }

        [Then(@"Success message is displayed and contains ""(.*)"" text")]
        public void ThenSuccessMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToContainsText(page.SuccessMessage, text);
            Utils.Verify.AreEqual("rgba(126, 189, 56, 1)", page.SuccessMessage.GetCssValue("background-color"), "Success message is not Green"); //Green color
            Utils.Verify.Contains(text, page.SuccessMessage.Text, "Success Message is not displayed");
        }

        [Then(@"Green banner contains following text ""(.*)""")]
        public void ThenGreenBannerContainsFollowingText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(page.SuccessMessage);
            Utils.Verify.Contains(text, page.SuccessMessageThirdPart.Text, "Success Message is not displayed");
        }

        [Then(@"Error message with ""(.*)"" text is displayed")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToContainsText(page.ErrorMessage, text);
            Utils.Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetErrorMessageColor(), "Colors do not match!"); //Red color
            Utils.Verify.AreEqual(text, page.ErrorMessage.Text, "Error Message is not displayed");
        }

        [Then(@"""(.*)"" error in the Scope Changes displayed to the User")]
        public void ThenErrorInTheScopeChangesDisplayedToTheUser(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.ScopeChangesError);
            Utils.Verify.AreEqual(text, page.ScopeChangesError.Text, "Error Message is not displayed in the Scope Changes");
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
            Utils.Verify.AreEqual(message, page.NoFoundMessage.Text, $"{message} is not displayed");
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
            Utils.Verify.IsTrue(pageBuckets.SuccessUpdatedMessageBucketsPage(bucketName),
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
            Utils.Verify.IsTrue(projectElement.TextMessage(textMessage),
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

        [Then(@"Success message is displayed and contains ""(.*)"" link")]
        public void ThenSuccessMessageIsDisplayedAndContainsLink(string text)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsTrue(projectElement.GetLinkByText(text).Displayed(), $"Message with {text} link is not displayed");
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

        [Then(@"Filling field error with ""(.*)"" text is displayed")]
        public void ThenFillingFieldErrorWithTextIsDisplayed(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.BodyContainer.Click();
            Utils.Verify.IsTrue(page.GetFillingFieldErrorByText(text).Displayed(), $"Filling field error with {text} is not displayed");
            Utils.Verify.AreEqual("rgba(242, 88, 49, 1)",
                page.GetFillingFieldErrorByText(text).GetCssValue("color"), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.AreEqual("rgba(242, 88, 49, 1)", page.UnderFieldWarningIcon.GetCssValue("color"), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Filling field error is not displayed")]
        public void ThenFillingFieldErrorIsNotDisplayed()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsFalse(page.FieldWarningMessage.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.IsFalse(page.UnderFieldWarningIcon.Displayed(), "Filling field error is displayed");
        }
    }
}
