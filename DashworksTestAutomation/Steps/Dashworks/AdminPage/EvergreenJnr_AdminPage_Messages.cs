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

        public EvergreenJnr_AdminPage_Messages (RemoteWebDriver driver)
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
            Assert.IsFalse(page.WarningPopUp.Displayed(), "Warning Pop-up is displayed");
        }

        [Then(@"Blue banner with ""(.*)"" text is displayed")]
        public void ThenBlueBannerWithTextIsDisplayed(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            //_driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.BlueBanner);
            StringAssert.Contains(text, page.BlueBanner.Text, "Blue banner is not displayed");
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

            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => message.WarningMessage);
            Assert.AreEqual("rgba(235, 175, 37, 1)", message.GetMessageColor()); //Amber color
            //Waiting for message text change
            Thread.Sleep(1000);
            Assert.IsTrue(message.TextMessage(text),
                $"{text} is not displayed on the Project page");
        }

        [Then(@"""(.*)"" warning message is not displayed on the Buckets page")]
        public void ThenWarningMessageIsNotDisplayedOnTheBucketsPage(string warningText)
        {
            var message = _driver.NowAt<BucketsPage>();
            Assert.IsFalse(message.WarningDeleteBucketMessage(warningText),
                $"{warningText} warning message is displayed on the Buckets page");
        }

        [When(@"User clicks Cancel button in the warning message on the Admin page")]
        public void WhenUserClicksCancelButtonInTheWarningMessageOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.CancelButtonInWarning);
            page.CancelButtonInWarning.Click();
            Assert.IsFalse(page.WarningMessage.Displayed());
        }

        [When(@"User clicks Delete button in the warning message")]
        public void WhenUserClicksDeleteButtonInTheWarningMessage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.WarningMessage);
            button.DeleteButtonInWarningMessage.Click();
            Logger.Write("Delete button was clicked");
        }

        [When(@"User clicks ""(.*)"" button in the warning message on Admin page")]
        public void WhenUserClicksButtonInTheWarningMessageOnAdminPage(string buttonName)
        {
            var button = _driver.NowAt<ProjectsPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => button.WarningMessage);
            button.GetButtonInWarningMessage(buttonName).Click();
            Logger.Write($"{buttonName} button was clicked");
        }

        [When(@"User close message on the Admin page")]
        public void WhenUserCloseMessageOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.CloseMessageButton.Click();
        }

        [Then(@"Info message is displayed and contains ""(.*)"" text")]
        public void ThenInfoMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.BlueBanner);
            Assert.AreEqual("rgba(49, 122, 193, 1)", page.GetMessageColor()); //Blue color
            //Assert.AreEqual("1530px", page.GetMessageWidthOnAdminPage());
            StringAssert.Contains(text, page.BlueBanner.Text, "Success Message is not displayed");
        }

        [Then(@"Success message is displayed and contains ""(.*)"" text")]
        public void ThenSuccessMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.SuccessMessage);
            Assert.AreEqual("rgba(126, 189, 56, 1)", page.GetMessageColor()); //Green color
            StringAssert.Contains(text, page.SuccessMessage.Text, "Success Message is not displayed");
        }

        [Then(@"Green banner contains following text ""(.*)""")]
        public void ThenGreenBannerContainsFollowingText(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.SuccessMessage);
            StringAssert.Contains(text, page.SuccessMessageThirdPart.Text, "Success Message is not displayed");
        }

        [Then(@"Error message with ""(.*)"" text is displayed")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.ErrorMessage);
            Assert.AreEqual("rgba(242, 88, 49, 1)", page.GetMessageColor()); //Red color
            Assert.AreEqual(text, page.ErrorMessage.Text, "Error Message is not displayed");
        }

        [Then(@"""(.*)"" message is displayed on the Admin Page")]
        public void ThenMessageIsDisplayedOnTheAdminPage(string message)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.NoFoundMessage);
            Assert.AreEqual(message, page.NoFoundMessage.Text, $"{message} is not displayed");
        }

        [Then(@"User sees banner at the top of work area")]
        public void ThenUserSeesBannerAtTheTopOfWorkArea()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.Banner);
            Assert.That(page.Banner.Displayed, Is.True, "Banner is not displayed");
        }

        [Then(@"Success message is displayed correctly")]
        public void ThenSuccessMessageIsDisplayedCorrectly()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => page.SuccessMessage);
            Assert.AreEqual("rgba(126, 189, 56, 1)", page.GetMessageColor()); //Green color
            Assert.AreEqual("1658px", page.GetMessageWidthOnAdminPage());
            Assert.AreEqual("33.6px", page.GetMessageHeightOnAdminPage());
        }

        [Then(@"Success message The ""(.*)"" bucket has been updated is displayed on the Buckets page")]
        public void ThenSuccessMessageTheBucketHasBeenUpdatedIsDisplayedOnTheBucketsPage(string bucketName)
        {
            var pageBase = _driver.NowAt<BaseGridPage>();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => pageBase.SuccessMessage);
            var pageBuckets = _driver.NowAt<BucketsPage>();
            Assert.IsTrue(pageBuckets.SuccessUpdatedMessageBucketsPage(bucketName),
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

            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => projectElement.SuccessMessage);
            Thread.Sleep(10000);
            Assert.IsTrue(projectElement.TextMessage(textMessage),
                $"{textMessage} is not displayed on the Project page");
        }

        [When(@"User clicks newly created object link")]
        public void WhenUserClicksNewlyCreatedObjectLink()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitWhileControlIsNotDisplayed<BaseGridPage>(() => projectElement.NewProjectLink);
            projectElement.NewProjectLink.Click();
        }

        [Then(@"Success message is displayed and contains ""(.*)"" link")]
        public void ThenSuccessMessageIsDisplayedAndContainsLink(string text)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Assert.IsTrue(projectElement.GetLinkByText(text).Displayed(), $"Message with {text} link is not displayed");
        }

        [Then(@"Error message is not displayed on the Capacity Units page")]
        [Then(@"Error message is not displayed on the Capacity Slots page")]
        [Then(@"Error message is not displayed on the Projects page")]
        public void ThenErrorMessageIsNotDisplayedOnTheProjectsPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.ErrorMessage.Displayed(), "Error Message is displayed");
        }

        [Then(@"Warning message is not displayed on the Admin page")]
        public void ThenWarningMessageIsNotDisplayedOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.WarningMessage.Displayed());
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
            Assert.IsFalse(message.SuccessMessage.Displayed());
        }

        [Then(@"Filling field error with ""(.*)"" text is displayed")]
        public void ThenFillingFieldErrorWithTextIsDisplayed(string text)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.BodyContainer.Click();
            Assert.IsTrue(page.GetFillingFieldErrorByText(text).Displayed(), $"Filling field error with {text} is not displayed");
            Assert.AreEqual("rgba(242, 88, 49, 1)", page.GetFillingFieldErrorByText(text).GetCssValue("color"));
            Assert.AreEqual("rgba(242, 88, 49, 1)", page.UnderFieldWarningIcon.GetCssValue("color"));
        }

        [Then(@"Filling field error is not displayed")]
        public void ThenFillingFieldErrorIsNotDisplayed()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Assert.IsFalse(page.FieldWarningMessage.Displayed());
            Assert.IsFalse(page.UnderFieldWarningIcon.Displayed(), "Filling field error is displayed");
        }
    }
}
