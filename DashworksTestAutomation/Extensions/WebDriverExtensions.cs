using System;
using System.Collections;
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
    internal static class WebDriverExtensions
    {
        private const int NumberOfTimesToWait = 2;
        private static readonly TimeSpan waitTimeout = TimeSpan.FromSeconds(30);
        private static readonly TimeSpan pollingInterval = TimeSpan.FromSeconds(5);

        public static void NavigateToUrl(this RemoteWebDriver driver, string url)
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
                property.GetCustomAttributes(typeof(FindsByAttribute), false).Single() as FindsByAttribute;
            return ByFactory.From(findsByAttributes);
        }

        public static T NowAt<T>(this RemoteWebDriver driver) where T : SeleniumBasePage, new()
        {
            var page = new T {Driver = driver, Actions = new Actions(driver)};
            driver.WaitForLoadingElements(page, null);
            page.InitElements();
            return page;
        }

        public static T NowAtWithoutWait<T>(this RemoteWebDriver driver) where T : SeleniumBasePage, new()
        {
            var page = new T {Driver = driver, Actions = new Actions(driver)};
            page.InitElements();
            return page;
        }

        public static string CreateScreenshot(this RemoteWebDriver driver, string fileName)
        {
            try
            {
                FileSystemHelper.EnsureScreensotsFolderExists();
                var formatedFileName =
                    fileName.Replace("\\", string.Empty).Replace("/", string.Empty).Replace("\"", "'");
                var filePath = FileSystemHelper.GetPathForScreenshot(formatedFileName);
                var screenshot = ((ITakesScreenshot) driver).GetScreenshot();

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
            //Suggested workaround to solve issue with not closed browsers after tests
            //TODO Try to remove and test without it
            Thread.Sleep(3000);

            try
            {
                Logger.Write("Trying to delete cookie");
                driver.Manage().Cookies.DeleteAllCookies();
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }

            try
            {
                Logger.Write("Trying to close browser");
                driver.Close();
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }

            try
            {
                Logger.Write("Trying to quite chromedriver");
                driver.Quit();
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }

            try
            {
                Logger.Write("Trying to Dispose webdriver");
                driver.Dispose();
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
        }

        public static void WaitForLoadingElements(this RemoteWebDriver driver, SeleniumBasePage page, By bySelector)
        {
            var bys = bySelector != null ? new List<By> {bySelector} : page.GetPageIdentitySelectors();

            foreach (var by in bys)
                //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.border='3px solid red'",
                //	driver.FindElement(@by));

                driver.WaitForElement(by);

            page.InitElements();
        }

        public static void WaitForElement(this RemoteWebDriver driver, By by)
        {
            var attempts = NumberOfTimesToWait;
            while (attempts > 0)
                try
                {
                    attempts--;
                    ExecuteWithLogging(() => FluentWait.Create(driver)
                        .WithTimeout(waitTimeout)
                        .WithPollingInterval(pollingInterval)
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

        public static void WaitForElements(this RemoteWebDriver driver, ReadOnlyCollection<IWebElement> elements)
        {
            WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elements));
        }

        public static void WaitForElements(this RemoteWebDriver driver, By bys)
        {
            WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
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

        public static void WaitWhileControlIsNotClickable<T>(this RemoteWebDriver driver,
            Expression<Func<IWebElement>> elementGetter)
        {
            var propertyName = ((MemberExpression) elementGetter.Body).Member.Name;
            var by = GetByFor<T>(propertyName);
            driver.WaitWhileControlIsNotClickable(by);
        }

        public static void WaitWhileControlIsNotClickable(this RemoteWebDriver driver, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element with '{by}' selector is NOT clickable in {waitTimeout.TotalSeconds} seconds", e);
            }
        }

        public static void WaitWhileControlIsNotDisplayed<T>(this RemoteWebDriver driver,
            Expression<Func<IWebElement>> elementGetter)
        {
            var propertyName = ((MemberExpression) elementGetter.Body).Member.Name;
            var by = GetByFor<T>(propertyName);
            driver.WaitWhileControlIsNotDisplayed(by);
        }

        public static void WaitWhileControlIsNotDisplayed(this RemoteWebDriver driver, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element with '{by}' selector is NOT displayed in {waitTimeout.TotalSeconds} seconds", e);
            }
        }

        public static void WaitWhileControlIsNotExists(this RemoteWebDriver driver, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                wait.Until(ExpectedConditions.ElementExists(by));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element with '{by}' selector is NOT displayed in {waitTimeout.TotalSeconds} seconds", e);
            }
        }

        public static void WaitWhileControlContainingTextIsNotDisplayed(this RemoteWebDriver driver, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                wait.Until(d => d.FindElement(by).Text.Length > 0);
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element with '{by}' selector is NOT displayed AND populated with text in {waitTimeout.TotalSeconds} seconds",
                    e);
            }
        }

        public static void WaitWhileControlIsDisplayed<T>(this RemoteWebDriver driver,
            Expression<Func<IWebElement>> elementGetter)
        {
            var propertyName = ((MemberExpression) elementGetter.Body).Member.Name;
            var by = GetByFor<T>(propertyName);
            driver.WaitWhileControlIsDisplayed(by);
        }

        public static void WaitWhileControlIsDisplayed(this RemoteWebDriver driver, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element with '{by}' selector still displayed after {waitTimeout.TotalSeconds} seconds", e);
            }
        }

        public static void WaitForTextToAppear(this RemoteWebDriver driver, IWebElement element, string textToAppear)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                wait.Until(ExpectedConditions.TextToBePresentInElement(element, textToAppear));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element '{element}' and text '{textToAppear}' NOT displayed after {waitTimeout.TotalSeconds} seconds",
                    e);
            }
        }

        public static void WaitForTextToAppear(this RemoteWebDriver driver, By by, string textToAppear)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                wait.Until(ExpectedConditions.TextToBePresentInElementLocated(by, textToAppear));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element with '{by}' selector and text '{textToAppear}' NOT displayed after {waitTimeout.TotalSeconds} seconds",
                    e);
            }
        }

        public static void WaitToBeSelected(this RemoteWebDriver driver, IWebElement element, bool selectorState)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                wait.Until(ExpectedConditions.ElementToBeSelected(element, selectorState));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element '{element}' in selected state '{selectorState}' NOT displayed after {waitTimeout.TotalSeconds} seconds",
                    e);
            }
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
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
                        wait.Until(InvisibilityOfAllElementsLocatedBy(by));
                    }
                    catch (Exception e)
                    {
                        Logger.Write(
                            $"WARNING: Loading spinner is displayed longer that {waitTimeout.Seconds * attempts} seconds: {driver.Url}");
                        throw e;
                    }
                else
                    break;
            } while (wasLoadingSpinnerDisplayed && attempts < 3);
        }

        /// <summary>
        ///     An expectation for checking that all elements present on the web page that
        ///     match the locator are NOT visible. Visibility means that the elements are not
        ///     only displayed but also have a height and width that is greater than 0.
        /// </summary>
        /// <param name="locator">The locator used to find the element.</param>
        /// <returns>The list of <see cref="IWebElement" /> once it is located and visible.</returns>
        public static Func<IWebDriver, bool> InvisibilityOfAllElementsLocatedBy(By locator)
        {
            return driver =>
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

        #region Web element extensions

        public static void SelectCustomSelectbox(this RemoteWebDriver driver, IWebElement selectbox, string option)
        {
            selectbox.Click();

            //Small wait for dropdown display
            Thread.Sleep(300);
            var options = driver.FindElements(By.XPath(
                ".//div[contains(@class,'mat-select-content ng-trigger ng-trigger-fadeInContent')]/mat-option"));
            if (!options.Any())
                throw new Exception($"Filter options were not loaded, unable to select '{option}'");
            driver.MouseHover(options.Last());
            options = driver.FindElements(By.XPath(
                ".//div[contains(@class,'mat-select-content ng-trigger ng-trigger-fadeInContent')]/mat-option"));
            driver.ClickByJavascript(options.First(x => x.Text.ContainsText(option)));
        }

        #endregion Web element extensions

        /// <summary>
        ///     Execute this method after some actions on page to get sent requests
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static List<string> GetAllRequests(this RemoteWebDriver driver)
        {
            var allRequests = new List<string>();
            var scriptToExecute =
                "var performance = window.performance || window.mozPerformance || window.msPerformance || window.webkitPerformance || {}; var network = performance.getEntries() || {}; return network;";
            var netData = driver.ExecuteScript(scriptToExecute);
            var collection = (IList) netData;
            foreach (object o in collection)
            {
                var innerCollection = (Dictionary<string, object>) o;
                foreach (KeyValuePair<string, object> keyValuePair in innerCollection)
                    if (keyValuePair.Key.Equals("name") && !string.IsNullOrEmpty(keyValuePair.Value.ToString()) &&
                        keyValuePair.Value.ToString().Contains("http"))
                        allRequests.Add(keyValuePair.Value.ToString());
            }

            return allRequests;
        }

        public static string GetTooltipText(this RemoteWebDriver driver)
        {
            var toolTips = driver.FindElements(By.XPath(".//mat-tooltip-component"));
            if (!toolTips.Any())
                throw new Exception("Tool tip was not displayed");
            return toolTips.First().Text;
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

        public static void DragAndDrop(this RemoteWebDriver driver, IWebElement elementToBeMoved,
            IWebElement moveToElement)
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(elementToBeMoved, moveToElement).Perform();
        }

        #endregion Actions

        #region Actions with Javascript

        public static void ClickByJavascript(this RemoteWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor ex = driver;
            ex.ExecuteScript("arguments[0].click();", element);
        }

        public static void MouseHoverByJavascript(this RemoteWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor ex = driver;
            ex.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void SetAttributeByJavascript(this RemoteWebDriver driver, IWebElement element, string attribute,
            string text)
        {
            IJavaScriptExecutor ex = driver;
            ex.ExecuteScript($"arguments[0].setAttribute('{attribute}', '{text}')", element);
        }

        #endregion Actions with Javascript

        #region Frames

        public static void SwitchToFrame(this RemoteWebDriver driver, int frameNumber)
        {
            WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
            driver.SwitchTo().DefaultContent();
            wait.Until(x => x.FindElements(By.TagName("iframe")).Count > frameNumber);
            var frames = driver.FindElements(By.TagName("iframe"));
            driver.SwitchTo().Frame(frames[frameNumber]);
        }

        public static void SwitchToFrame(this RemoteWebDriver driver, string frameIdName)
        {
            WebDriverWait wait = new WebDriverWait(driver, waitTimeout);
            driver.SwitchTo().DefaultContent();
            wait.Until(x => x.FindElements(By.Id(frameIdName)));
            driver.SwitchTo().Frame(frameIdName);
        }

        #endregion Frames

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

        public static bool IsElementExists(this IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        #endregion Availability of element
    }
}