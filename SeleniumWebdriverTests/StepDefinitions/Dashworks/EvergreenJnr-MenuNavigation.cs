using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumWebdriverTests.StepDefinitions.Dashworks
{
    [Binding]
    public sealed class EvergreenJnr_MenuNavigation
    {
        #region When

        [When(@"User clicks ""(.*)"" on the left-hand menu")]
        public void WhenUserClicksOnTheLeft_HandMenu(string listPage)
        {
            switch (listPage)
            {
                case "Devices":
                    ButtonHelper.ClickButton(By.XPath("//a[@title='Devices']"));
                    Console.WriteLine("Devices left-hand menu was clicked");
                    break;

                case "Users":
                    ButtonHelper.ClickButton(By.XPath("//a[@title='Users']"));
                    Console.WriteLine("Users left-hand menu was clicked");
                    break;
                    
                case "Applications":
                    ButtonHelper.ClickButton(By.XPath("//a[@title='Applications']"));
                    Console.WriteLine("Applications left-hand menu was clicked");
                    break;

                case "Mailboxes":
                    ButtonHelper.ClickButton(By.XPath("//a[@title='Mailboxes']"));
                    Console.WriteLine("Mailboxes left-hand menu was clicked");
                    break;

                default:
                    break;
            }
            Thread.Sleep(5000);
        }

        [When(@"User clicks the Switch to Evergreen link")]
        public void WhenUserClicksTheSwitchToEvergreenLink()
        {
            //Moves the mouse to the 'Analysis' link and then moves the mouse and clicks the 'Evergreen' link
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement analysisLink = ObjectRepository.Driver.FindElement(By.XPath("//a[@title='Switch Sites']"));
            IWebElement evergreenLink = ObjectRepository.Driver.FindElement(By.XPath("//a[@title='Evergreen']"));

            act.MoveToElement(analysisLink)
                .MoveToElement(evergreenLink)
                .Click()
                .Build()
                .Perform();
            Thread.Sleep(5000);
        }

        #endregion When

        #region Then

        [Then(@"""(.*)"" list should be displayed to the user")]
        public void ThenTheListShouldBeDisplayedToTheUser(string listPage)
        {
            switch (listPage)
            {
                case "Devices":
                    //Check Devices heading is visible
                    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@id='pagetitle-text']/descendant::h1[text()='Devices']")));
                    //Check All Devices list is visible
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[text()='All Devices']")));
                    Console.WriteLine("Device list is visible");
                    break;

                case "Users":
                    //Check Users heading is visible
                    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@id='pagetitle-text']/descendant::h1[text()='Users']")));
                    //Check All Users list is visible
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[text()='All Users']")));
                    Console.WriteLine("Users list is visible");
                    break;

                case "Applications":
                    //Check Applications heading is visible
                    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@id='pagetitle-text']/descendant::h1[text()='Applications']")));
                    //Check All Applications list is visible
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[text()='All Applications']")));
                    Console.WriteLine("Applications list is visible");
                    break;

                case "Mailboxes":
                    //Check Mailboxes heading is visible
                    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@id='pagetitle-text']/descendant::h1[text()='Mailboxes']")));
                    //Check All Mailboxes list is visible
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[text()='All mailboxes']")));
                    Console.WriteLine("Mailboxes list is visible");
                    break;

                default:
                    break;
            }
            GenericHelper.TakeScreenShot();
        }

        [Then(@"Evergreen Dashboards page should be displayed to the user")]
        public void ThenEvergreenDashboardsPageShouldBeDisplayedToTheUser()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            if (GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")))
            {
                GenericHelper.TakeScreenShot();
                Console.WriteLine("500 error was displayed");
                Assert.IsFalse(GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")));
            }
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//input[@class='form-control search-input ng-untouched ng-pristine ng-valid']")));
            Console.WriteLine("Evergreen Dashboards page is displayed");
        }

        #endregion Then
    }
}
