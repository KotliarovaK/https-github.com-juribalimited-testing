using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace DashworksTestAutomation.Extensions
{
    static class WebDriverExtentions
    {
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(35);
        private static readonly TimeSpan PollingInterval = TimeSpan.FromSeconds(5);
        private const int WaitTimes = 2;

        public static void NagigateToURL(this RemoteWebDriver driver, string url)
        {
            Logger.Write($"Navigating to the {url}");
            driver.Navigate().GoToUrl(url);
        }

        public static By GetByFor<T>(string element)
        {
            var propertyName = element;
            var type = typeof(T);
            var property = type.GetProperty(propertyName);
            var findsByAttributes =
                property.GetCustomAttributes(typeof(FindsByAttribute), inherit: false).Single() as FindsByAttribute;
            return ByFactory.From(findsByAttributes);
        }

        public static T NowAt<T>(this RemoteWebDriver driver) where T : SeleniumBasePage, new()
        {
            var page = new T { Driver = driver, Actions = new Actions(driver) };
            driver.WaitForLoadingElements(page, null);
            page.InitElements();
            return page;
        }

        public static string CreateScreenshot(this RemoteWebDriver driver, string fileName)
        {
            try
            {
                FileSystemHelper.EnsureScreensotsFolderExists();
                var formatedFileName = fileName.Replace("\\", string.Empty).Replace("/", string.Empty).Replace("\"", "'");
                var filePath = FileSystemHelper.GetPathForScreenshot(formatedFileName);
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();

                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
                Logger.Write($"Check screenshot by folklowing path: {filePath}");
                return filePath;
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to get screenshot: {e.Message}");
                return string.Empty;
            }
        }

        public static void QuitDriver(this RemoteWebDriver driver)
        {
            try
            {
                Logger.Write("Trying to quit Browser...");
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Close();
                driver.Quit();
                Logger.Write("Browser closed successfully.");
            }
            catch (Exception e)
            {
                Logger.Write("Browser was not closed successfully:");
                Logger.Write(e);
            }
        }

        public static void WaitForLoadingElements(this RemoteWebDriver driver, SeleniumBasePage page, By bySelector)
        {
            var bys = bySelector != null ? new List<By> { bySelector } : page.GetPageIdentitySelectors();

            foreach (var by in bys)
            {
                //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.border='3px solid red'",
                //	driver.FindElement(@by));

                driver.WaitForElement(by);
            }
            page.InitElements();
        }

        public static void WaitForElement(this RemoteWebDriver driver, By by)
        {
            var attempts = WaitTimes;
            while (attempts > 0)
            {
                try
                {
                    attempts--;
                    ExecuteWithLogging(() => FluentWait.Create(driver)
                        .WithTimeout(WaitTimeout)
                        .WithPollingInterval(PollingInterval)
                        .Until(ExpectedConditions.ElementIsVisible(by)), by);

                    return;
                }
                // System.InvalidOperationException : Error determining if element is displayed (UnexpectedJavaScriptError)
                catch (InvalidOperationException e)
                {
                    Logger.Write("Following Exception is occured in the WaitForElement method: {0}", e.Message);
                    Thread.Sleep(200);
                }
                // System.InvalidOperationException :The xpath expression './/option[contains(text(),'xxx')]' cannot be evaluated or does notresult in a WebElement
                catch (InvalidSelectorException e)
                {
                    Logger.Write("Following Exception is occured in the WaitForElement method: {0}", e.Message);
                    Thread.Sleep(200);
                }
                catch (Exception e)
                {
                    throw new Exception($"Error waiting element by '{by}' : {e.Message}");
                }
            }
        }

        public static void WaitForElements(this RemoteWebDriver driver, ReadOnlyCollection<IWebElement> elements)
        {
            WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elements));
        }

        public static void WaitForElements(this RemoteWebDriver driver, By bys)
        {
            WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(bys));
        }

        private static void ExecuteWithLogging(Action actionToExecute, By by)
        {
            try
            {
                actionToExecute();
            }
            catch (Exception)
            {
                Logger.Write($"Error while wating for {by}");

                throw;
            }
        }

        // Sample usage
        //	Driver.WaitWhileControlIsNotDisplayed<ClaimListPage>(() => claimListPage.CreateClaimButton);
        //	OR JUST
        //	Driver.WaitWhileControlIsNotDisplayed<ClaimListPage>(() => NowHere<ClaimListPage>().CreateClaimButton);
        public static void WaitWhileControlIsNotClicable<T>(this RemoteWebDriver driver, Expression<Func<IWebElement>> elementGetter)
        {
            var propertyName = ((MemberExpression)elementGetter.Body).Member.Name;
            var by = GetByFor<T>(propertyName);
            WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        // Sample usage
        //	Driver.WaitWhileControlIsNotDisplayed<ClaimListPage>(() => claimListPage.CreateClaimButton);
        //	OR JUST
        //	Driver.WaitWhileControlIsNotDisplayed<ClaimListPage>(() => NowHere<ClaimListPage>().CreateClaimButton);
        public static void WaitWhileControlIsNotDisplayed<T>(this RemoteWebDriver driver, Expression<Func<IWebElement>> elementGetter)
        {
            var propertyName = ((MemberExpression)elementGetter.Body).Member.Name;
            var by = GetByFor<T>(propertyName);
            driver.WaitWhileControlIsNotDisplayed(by);
        }

        public static void WaitWhileControlIsNotDisplayedSafety<T>(this RemoteWebDriver driver, Expression<Func<IWebElement>> elementGetter)
        {
            try
            {
                var propertyName = ((MemberExpression)elementGetter.Body).Member.Name;
                var by = GetByFor<T>(propertyName);
                driver.WaitWhileControlIsNotDisplayed(by);
            }
            catch { }
        }

        public static void WaitWhileControlIsNotDisplayed(this RemoteWebDriver driver, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element with '{by}' selector is NOT displayed in {WaitTimeout.TotalSeconds} seconds", e);
            }
        }

        public static void WaitWhileControlIsDisplayed(this RemoteWebDriver driver, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element with '{by}' selector still displayed after {WaitTimeout.TotalSeconds} seconds", e);
            }
        }

        public static void WaitWhileControlIsDisplayed(this RemoteWebDriver driver, By by, TimeSpan waitSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitSeconds);
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element with '{by}' selector still displayed after {waitSeconds.TotalSeconds} seconds", e);
            }
        }

        // Sample usage
        //	Driver.WaitWhileControlIsNotDisplayed<ClaimListPage>(() => claimListPage.CreateClaimButton);
        //	OR JUST
        //	Driver.WaitWhileControlIsNotDisplayed<ClaimListPage>(() => NowHere<ClaimListPage>().CreateClaimButton);
        public static void WaitWhileControlIsDisplayed<T>(this RemoteWebDriver driver, Expression<Func<IWebElement>> elementGetter)
        {
            var propertyName = ((MemberExpression)elementGetter.Body).Member.Name;
            var by = GetByFor<T>(propertyName);
            WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        /// <summary>
        /// An expectation for checking that all elements present on the web page that
        /// match the locator are NOT visible. Visibility means that the elements are not
        /// only displayed but also have a height and width that is greater than 0.
        /// </summary>
        /// <param name="locator">The locator used to find the element.</param>
        /// <returns>The list of <see cref="IWebElement"/> once it is located and visible.</returns>
        public static Func<IWebDriver, bool> InvisibilityOfAllElementsLocatedBy(By locator)
        {
            return (driver) =>
            {
                try
                {
                    var elements = driver.FindElements(locator);
                    return !elements.Any(element => element.Displayed);
                }
                catch (NoSuchElementException)
                {
                    // Returns true because the element is not present in DOM. The
                    // try block checks if the element is present but is invisible.
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    // Returns true because stale element reference implies that element
                    // is no longer visible.
                    return true;
                }
            };
        }

        public static void WaitForTextToAppear(this RemoteWebDriver driver, IWebElement element, String textToAppear, int waitSec = 35)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
            wait.Until(ExpectedConditions.TextToBePresentInElement(element, textToAppear));
        }

        public static void WaitForTextToAppear(this RemoteWebDriver driver, By by, String textToAppear, int waitSec = 35)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(by, textToAppear));
        }

        public static void WaitForDataLoading(this RemoteWebDriver driver)
        {
            int attempts = 0;
            bool wasLoadingSpinnerDisplayed = false;

            //Small sleep for Spinner waiting
            Thread.Sleep(400);
            var by = By.XPath(".//div[contains(@class,'spinner')]");

            do
            {
                attempts++;
                wasLoadingSpinnerDisplayed = driver.IsElementDisplayed(by);
                if (wasLoadingSpinnerDisplayed)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
                        wait.Until(InvisibilityOfAllElementsLocatedBy(by));
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"WARNING: Loading spinner is displayed longer that {WaitTimeout.Seconds * attempts} seconds: {driver.Url}");
                        throw e;
                    }
                }
                else
                    break;
            } while (wasLoadingSpinnerDisplayed && attempts < 3);
        }

        #region Actions

        public static void MouseHover(this RemoteWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public static void MouseHover(this RemoteWebDriver driver, By by)
        {
            var element = driver.FindElement(by);
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public static void ClickByActions(this RemoteWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.Click(element).Perform();
        }

        public static void HoverAndClick(this RemoteWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click(element).Perform();
        }

        public static void MoveToElement(this RemoteWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        #endregion

        #region Actions with Javascript

        public static void ClickByJavascript(this RemoteWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", element);
        }

        #endregion

        #region Frames

        public static void SwitchToFrame(this RemoteWebDriver driver, int frameNumber)
        {
            WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
            driver.SwitchTo().DefaultContent();
            wait.Until(x => x.FindElements(By.TagName("iframe")).Count > frameNumber);
            var frames = driver.FindElements(By.TagName("iframe"));
            driver.SwitchTo().Frame(frames[frameNumber]);
        }

        public static void SwitchToFrame(this RemoteWebDriver driver, string frameIdName)
        {
            WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
            driver.SwitchTo().DefaultContent();
            wait.Until(x => x.FindElements(By.Id(frameIdName)));
            driver.SwitchTo().Frame(frameIdName);
        }

        #endregion

        #region Availability of element

        public static bool IsElementDisplayed(this RemoteWebDriver driver, IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsElementDisplayed(this RemoteWebDriver driver, By selector)
        {
            try
            {
                return driver.FindElement(selector).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsElementExists(this IWebDriver driver, By @by)
        {
            try
            {
                driver.FindElement(@by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool IsElementExists(this IWebDriver driver, IWebElement element)
        {
            try
            {
                if (element == null)
                    return false;

                if (element.TagName.Contains("Exception"))
                    return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
