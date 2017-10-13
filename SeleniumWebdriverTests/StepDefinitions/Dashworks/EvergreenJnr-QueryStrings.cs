using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumWebdriverTests.StepDefinitions
{
    [Binding]
    public sealed class EvergreenJnr_QueryStrings
    {
        public string url;
        public string combinedURL;
        public string forcedLogin;

        #region Given

        [Given(@"User is on Dashworks Homepage with dashworksUrl ""(.*)""")]
        public void GivenUserIsOnDashworksHomepageWithDashworksUrl(string dashworksUrl)
        {
            url = "http://automation.corp.juriba.com/";
            NavigationHelper.NagigateToURL(dashworksUrl);

            //If automation.corp.juriba.com is not available, try automation2.corp.juriba.com instead
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            if (GenericHelper.IsElementPresent(By.XPath("//img[@src='iisstart.png']")))
            {
                NavigationHelper.NagigateToURL("http://automation2.corp.juriba.com/");
                url = "http://automation2.corp.juriba.com/";
                Console.WriteLine("Using automation2.corp.juriba.com instead");
            }
            //Check if the forced login page is displayed
            else if (GenericHelper.IsElementPresent(By.ClassName("loginsplash-panel")))
            {
                Console.WriteLine("Forced login splash page is visible instead of Dashworks homepage");
                forcedLogin = "Yes";
            }
        }

        #endregion Given

        #region When

        [When(@"User clicks on the Login link")]
        public void WhenUserClicksOnTheLoginLink()
        {
            //Only click the login link if the forced login splash page is NOT displayed
            if (forcedLogin != "Yes")
            {
                LinkHelper.ClickLink(By.Id("ctl00_DwTopBar1_DwLogin1_UserLink"));
                Console.WriteLine("Login link was clicked");
                Thread.Sleep(1);
            } 
        }

        [When(@"User provides the ""(.*)"" and ""(.*)"" and clicks on the login button")]
        public void WhenUserProvidesTheAndAndClicksOnTheLoginButton(string username, string password)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            if (GenericHelper.IsElementPresent(By.Id("ctl00_MainContent_P_Login")))
            {
                TextBoxHelper.TypeInTextBox(By.Id("ctl00_MainContent_TB_UserName"), username);
                TextBoxHelper.TypeInTextBox(By.Id("ctl00_MainContent_TB_Password"), password);
                ButtonHelper.ClickButton(By.Id("ctl00_MainContent_Btn_Login"));
            }
            //To manage the Login Splash page which is sometimes shown instead of the login page
            else
            {
                TextBoxHelper.TypeInTextBox(By.Id("TB_UserName"), username);
                TextBoxHelper.TypeInTextBox(By.Id("TB_Password"), password);
                ButtonHelper.ClickButton(By.Id("Btn_Login"));
            }
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

        [When(@"Evergreen QueryStringURL is entered for Simple QueryType")]
        public void WhenEvergreenQueryStringURLIsEnteredForSimpleQueryType(Table table)
        {
           
            foreach (var row in table.Rows)
            {
                combinedURL = url + row["QueryStringURL"];
                NavigationHelper.NagigateToURL(combinedURL);
                Thread.Sleep(4000);
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

                if (GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")))
                {
                    GenericHelper.TakeScreenShot();
                    Console.WriteLine("500 error was returned for: {0}", row["QueryType"] + " query");
                    Assert.IsFalse(GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")));
                    break;
                }

                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[@class='rowCount']")));
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-container']")));
                Console.WriteLine("Evergreen agGrid Main Object List is returned with data for: {0}", row["QueryType"] + " query");
                GenericHelper.TakeScreenShot();
            }
        }

        [When(@"Evergreen QueryStringURL is entered for Complex QueryType")]
        public void WhenEvergreenQueryStringURLIsEnteredForComplexQueryType(Table table)
        {
            foreach (var row in table.Rows)
            {
                combinedURL = url + row["QueryStringURL"];
                NavigationHelper.NagigateToURL(combinedURL);
                Thread.Sleep(6000);
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                if (GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")))
                {
                    GenericHelper.TakeScreenShot();
                    Console.WriteLine("500 error was returned for: {0}", row["QueryType"] + " query");
                    Assert.IsFalse(GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")));
                    break;
                }
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[@class='rowCount']")));
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-container']")));
                Console.WriteLine("Evergreen agGrid Main Object List is returned with data for: {0}", row["QueryType"] + " query");
                GenericHelper.TakeScreenShot();
            }
        }

        [When(@"User clicks the Logout button")]
        public void WhenUserClicksTheLogoutButton()
        {
            ButtonHelper.ClickButton(By.XPath("//span[@class='col-ds-visible user-area']"));
            Thread.Sleep(1000);
            ButtonHelper.ClickButton(By.XPath("//i[@class='material-icons md-logout']"));
            Thread.Sleep(2000);
        }

        #endregion When

        #region Then

        [Then(@"Login Page is displayed to the user")]
        public void ThenLoginPageIsDisplayedToTheUser()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            if (GenericHelper.IsElementPresent(By.Id("ctl00_MainContent_P_Login")))
            {
                Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("ctl00_MainContent_P_Login")));
                Console.WriteLine("Login page is visible");
            }
            //To manage the Login Splash page which is sometimes shown instead of the login page
            else
            {
                Assert.IsTrue(GenericHelper.IsElementPresent(By.ClassName("loginsplash-panel")));
                Console.WriteLine("Login Splash page is visible");
            }
        }

        [Then(@"Dashworks homepage is displayed to the user in a logged in state")]
        public void ThenDashworksHomepageIsDisplayedToTheUserInALoggedInState()
        {
            AssertHelper.AreEqual("Home - Dashworks", WindowHelper.GetTitle());
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@id='maincontent']/descendant::h1[position()=1]")));
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("ctl00_DwTopBar1_DwLogin1_LogoutLink")));
            Console.WriteLine("Dashworks homepage is displayed and is in a logged in state");
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

        [Then(@"agGrid Main Object List is returned with data")]
        public void ThenAgGridMainObjectListIsReturnedWithData()
        {
            //Checking that the number of rows element is visible
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[@class='rowCount']")));
            //Checking that the agGrid body element is visible
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-container']")));
            Console.WriteLine("Main agGrid dataset is displayed");
        }

        [Then(@"Signed Out page is displayed to the user")]
        public void ThenSignedOutPageIsDisplayedToTheUser()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            AssertHelper.AreEqual("Logout - Dashworks", WindowHelper.GetTitle());
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@id='maincontent']/descendant::h1[position()=1]")));
            Console.WriteLine("Dashworks Signed Out page is displayed");
        }

        #endregion Then

        #region And

        [Given(@"Login link is visible")]
        public void GivenLoginLinkIsVisible()
        {
            //Only check the login link is visible if the forced login splash page is not displayed
            if (forcedLogin != "Yes")
            {
                Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("ctl00_DwTopBar1_DwLogin1_UserLink")));
                Console.WriteLine("Login link is visible");
            }
        }

        [Then(@"User is logged out")]
        public void ThenUserIsLoggedOut()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("ctl00_DwTopBar1_DwLogin1_UserLink")));
            Console.WriteLine("User is successfully logged out");
        }

        #endregion And
    }
}