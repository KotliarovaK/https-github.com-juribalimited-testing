﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace DashworksTestAutomation.Extensions
{
    internal static class WebDriverExtensions
    {
        private const int NumberOfTimesToWait = 2;
        private const int WaitTimeoutSeconds = 30;
        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(WaitTimeoutSeconds);
        private static readonly TimeSpan PollingInterval = TimeSpan.FromSeconds(5);
        private static readonly By matOptionsSelector = By.XPath(".//mat-option//*[@class='mat-option-text']");

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
            var page = new T { Driver = driver, Actions = new Actions(driver) };
            driver.WaitForLoadingElements(page, null);
            page.InitElements();
            return page;
        }

        public static T NowAtWithoutWait<T>(this RemoteWebDriver driver) where T : SeleniumBasePage, new()
        {
            var page = new T { Driver = driver, Actions = new Actions(driver) };
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
            //Suggested workaround to solve issue with not closed browsers after tests
            //TODO Try to remove and test without it
            Thread.Sleep(3000);

            try
            {
                driver.Manage().Cookies.DeleteAllCookies();
            }
            catch (Exception e)
            {
                Logger.Write($"Error during cookie deleting: {e}");
            }

            try
            {
                driver.Close();
            }
            catch (Exception e)
            {
                Logger.Write($"Error during driver closing: {e}");
            }

            try
            {
                driver.Quit();
            }
            catch (Exception e)
            {
                Logger.Write($"Error on driver quite: {e}");
                try
                {
                    Thread.Sleep(3000);
                    Logger.Write("Retrying to quite chromedriver");
                    driver.Quit();
                }
                catch (Exception ex)
                {
                    Logger.Write($"Driver was not quite on retry: {ex}");
                }
            }

            try
            {
                driver.Dispose();
            }
            catch (Exception e)
            {
                Logger.Write($"Error disposing webdriver: {e}");
            }
        }

        public static void OpenInNewTab(this RemoteWebDriver driver, string url)
        {
            driver.ExecuteScript($"window.open('{url}','_blank');");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public static void WaitForLoadingElements(this RemoteWebDriver driver, SeleniumBasePage page, By bySelector)
        {
            var bys = bySelector != null ? new List<By> { bySelector } : page.GetPageIdentitySelectors();

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

        public static void WaitForDataLoading(this RemoteWebDriver driver)
        {
            WaitForDataToBeLoaded(driver, ".//div[contains(@class,'spinner') and not(contains(@class,'small'))]", WaitTimeout);
        }

        public static void WaitForDataLoadingInActionsPanel(this RemoteWebDriver driver)
        {
            WaitForDataToBeLoaded(driver, ".//div[contains(@class,'action-progress')]", WaitTimeout);
        }

        public static void WaitForDataLoadingOnProjects(this RemoteWebDriver driver)
        {
            WaitForDataToBeLoaded(driver, ".//div[@id='ajaxProgressMessage']/img", WaitTimeout);
        }

        private static void WaitForDataToBeLoaded(RemoteWebDriver driver, string loadingSpinnerSelector, TimeSpan timepout)
        {
            int attempts = 0;
            bool wasLoadingSpinnerDisplayed = false;

            //Small sleep for Spinner waiting
            Thread.Sleep(400);
            var by = By.XPath(loadingSpinnerSelector);

            do
            {
                attempts++;
                wasLoadingSpinnerDisplayed = driver.IsElementDisplayed(by);
                if (wasLoadingSpinnerDisplayed)
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, timepout);
                        wait.Until(InvisibilityOfAllElementsLocatedBy(by));
                    }
                    catch (Exception e)
                    {
                        Logger.Write(
                            $"WARNING: Loading spinner is displayed longer that {timepout.Seconds * attempts} seconds: {driver.Url}");
                        throw e;
                    }
                else
                    break;
            } while (wasLoadingSpinnerDisplayed && attempts < 3);
        }

        #region Web element extensions

        public static void SelectCustomSelectbox(this RemoteWebDriver driver, IWebElement selectbox, string option)
        {
            selectbox.Click();
            //Small wait for dropdown display
            Thread.Sleep(500);

            //TODO: [Yurii Timchenko] commented code below doesn't work on 6 Dec 2018. Temporary fixed below, will be rewritten when new filters functionality is ready (per K. Kim's answer)
            //var options = driver.FindElements(By.XPath(
            //".//div[contains(@class,'mat-autocomplete-panel mat-autocomplete-visible ng-star-inserted')]/mat-option"));
            var options = driver.FindElements(By.XPath(
                "//div[contains(@class,'mat-select-panel mat-primary')]/mat-option"));

            if (!options.Any())
            {
                options = driver.FindElements(By.XPath(
                    "//mat-option[@class='mat-option ng-star-inserted']"));
                if (!options.Any())
                    throw new Exception($"Filter options were not loaded, unable to select '{option}'");
            }

            driver.MouseHover(options.Last());
            //options = driver.FindElements(By.XPath(
            //".//div[contains(@class,'mat-select-content ng-trigger ng-trigger-fadeInContent')]"));
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
            var collection = (IList)netData;
            foreach (object o in collection)
            {
                var innerCollection = (Dictionary<string, object>)o;
                foreach (KeyValuePair<string, object> keyValuePair in innerCollection)
                    if (keyValuePair.Key.Equals("name") && !string.IsNullOrEmpty(keyValuePair.Value.ToString()) &&
                        keyValuePair.Value.ToString().Contains("http"))
                        allRequests.Add(keyValuePair.Value.ToString());
            }

            return allRequests;
        }

        public static string GetTooltipText(this RemoteWebDriver driver)
        {
            string selector = ".//mat-tooltip-component";
            driver.WhatForElementToBeExists(By.XPath(selector));
            var toolTips = driver.FindElements(By.XPath(selector));
            var t = driver.PageSource;
            if (!toolTips.Any())
                throw new Exception("Tool tip was not displayed");
            var toolTipText = toolTips.First().FindElement(By.XPath("./div")).Text;
            if (String.IsNullOrEmpty(toolTipText))
            {
                driver.WaitForElementToBeDisplayed(By.XPath(selector + "/div"));
                toolTipText = toolTips.First().FindElement(By.XPath("./div")).Text;
            }
            return toolTipText;
        }

        public static void WhatForElementToBeSelected(this RemoteWebDriver driver, IWebElement element, bool selectorState)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, WaitTimeout);
                wait.Until(ExpectedConditions.ElementToBeSelected(element, selectorState));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element '{element}' not switched to '{selectorState}' selected state in {WaitTimeout.TotalSeconds} seconds",
                    e);
            }
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

        public static void InsertFromClipboard(this RemoteWebDriver driver, IWebElement textbox)
        {
            new Actions(driver)
                .Click(textbox)
                .SendKeys(OpenQA.Selenium.Keys.Shift).SendKeys(OpenQA.Selenium.Keys.Insert)
                .KeyUp(OpenQA.Selenium.Keys.Shift).KeyUp(OpenQA.Selenium.Keys.Insert)
                .Perform();
        }

        #endregion Actions

        #region Actions with Javascript

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

        public static String GetNetworkLogByJavascript(this RemoteWebDriver driver)
        {
            String scriptToExecute = "var performance = window.performance  || window.mozPerformance  || window.msPerformance  || window.webkitPerformance || {}; var network = performance.getEntries() || {}; return JSON.stringify(network);";
            IJavaScriptExecutor ex = driver;
            var netData = ex.ExecuteScript(scriptToExecute);
            return netData.ToString();
        }

        #endregion Actions with Javascript

        #region JavaSctipt Alert

        public static void AcceptAlert(this RemoteWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }

        public static void DismissAlert(this RemoteWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public static bool IsAlertPresent(this RemoteWebDriver driver)
        {
            IAlert alert = ExpectedConditions.AlertIsPresent().Invoke(driver);
            return (alert != null);
        }

        #endregion

        public static void SelectMatSelectbox(this RemoteWebDriver driver, IWebElement selectbox, string option)
        {
            //In case selectbox is already opened
            try
            {
                selectbox.Click();
            }
            catch { }
            foreach (IWebElement optionElement in GetOptionsFromMatSelectbox(driver, selectbox))
            {
                if (optionElement.Text.Equals(option))
                {
                    optionElement.Click();
                    break;
                }
            }
        }

        public static List<IWebElement> GetOptionsFromMatSelectbox(this RemoteWebDriver driver, IWebElement selectbox)
        {
            if (!driver.IsElementDisplayed(matOptionsSelector))
                selectbox.Click();
            return driver.FindElements(matOptionsSelector).ToList();
        }

        #region Wait for Element to be (not) Exists

        public static void WhatForElementToBeNotExists(this RemoteWebDriver driver, By by, int waitTimeout = WaitTimeoutSeconds)
        {
            WhatForElementToBeInExistsCondition(driver, by, false, waitTimeout);
        }

        public static void WhatForElementToBeNotExists(this RemoteWebDriver driver, IWebElement element, int waitTimeout = WaitTimeoutSeconds)
        {
            WhatForElementToBeInExistsCondition(driver, element, false, waitTimeout);
        }

        public static void WhatForElementToBeExists(this RemoteWebDriver driver, By by, int waitTimeout = WaitTimeoutSeconds)
        {
            WhatForElementToBeInExistsCondition(driver, by, true, waitTimeout);
        }

        public static void WhatForElementToBeExists(this RemoteWebDriver driver, IWebElement element, int waitTimeout = WaitTimeoutSeconds)
        {
            WhatForElementToBeInExistsCondition(driver, element, true, waitTimeout);
        }

        private static void WhatForElementToBeInExistsCondition(this RemoteWebDriver driver, By by, bool expectedCondition, int waitTimeout)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeout));
                wait.Until(ElementExists(by, expectedCondition));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element located '{by}' by selector was not in '{expectedCondition}' Exists condition after {waitTimeout} seconds", e);
            }
        }

        private static void WhatForElementToBeInExistsCondition(this RemoteWebDriver driver, IWebElement element, bool expectedCondition, int waitTimeout)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeout));
                wait.Until(ElementExists(element, expectedCondition));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception(
                    $"Element was not in '{expectedCondition}' Exists condition after {waitTimeout} seconds", e);
            }
        }

        private static Func<IWebDriver, bool> ElementExists(IWebElement element, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    var existsState = IsElementExists(driver, element);
                    return existsState.Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    return false.Equals(condition);
                }
            };
        }

        private static Func<IWebDriver, bool> ElementExists(By selector, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    var existsState = IsElementExists(driver, driver.FindElement(selector));
                    return existsState.Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    return false.Equals(condition);
                }
            };
        }

        #endregion

        #region Wait for ElementS to be (not) Displayed

        public static void WaitForElementsToBeNotDisplayed(this RemoteWebDriver driver, By by, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementsDisplayCondition(driver, by, false, waitSeconds);
        }

        public static void WaitForElementsToBeNotDisplayed(this RemoteWebDriver driver, IList<IWebElement> elements, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementsDisplayCondition(driver, elements, false, waitSeconds);
        }

        public static void WaitForElementsToBeDisplayed(this RemoteWebDriver driver, By by, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementsDisplayCondition(driver, by, true, waitSeconds);
        }

        public static void WaitForElementsToBeDisplayed(this RemoteWebDriver driver, IList<IWebElement> elements, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementsDisplayCondition(driver, elements, true, waitSeconds);
        }

        private static void WaitForElementsDisplayCondition(this RemoteWebDriver driver, By by, bool condition, int waitSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSeconds));
                wait.Until(VisibleConditionOfAllElementsLocatedBy(by, condition));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Elements with '{by}' selector were not changed Display condition to '{condition}' after {waitSeconds} seconds", e);
            }
        }

        private static void WaitForElementsDisplayCondition(this RemoteWebDriver driver, IList<IWebElement> elements, bool condition, int waitSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSeconds));
                wait.Until(VisibleConditionOfAllElementsLocatedBy(elements, condition));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Not all from {elements.Count} elements were not changed Display condition to '{condition}' after {waitSeconds} seconds", e);
            }
        }

        private static Func<IWebDriver, bool> InvisibilityOfAllElementsLocatedBy(By locator)
        {
            return VisibleConditionOfAllElementsLocatedBy(locator, false);
        }

        private static Func<IWebDriver, bool> InvisibilityOfAllElementsLocatedBy(IList<IWebElement> elements)
        {
            return VisibleConditionOfAllElementsLocatedBy(elements, false);
        }

        private static Func<IWebDriver, bool> VisibilityOfAllElementsLocatedBy(By locator)
        {
            return VisibleConditionOfAllElementsLocatedBy(locator, true);
        }

        private static Func<IWebDriver, bool> VisibilityOfAllElements(IList<IWebElement> elements)
        {
            return VisibleConditionOfAllElementsLocatedBy(elements, true);
        }

        private static Func<IWebDriver, bool> VisibleConditionOfAllElementsLocatedBy(By locator, bool expectedCondition)
        {
            return (driver) =>
            {
                try
                {
                    var elements = driver.FindElements(locator);
                    return elements.All(element => element.Displayed().Equals(expectedCondition));
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false;
                }
            };
        }

        private static Func<IWebDriver, bool> VisibleConditionOfAllElementsLocatedBy(IList<IWebElement> elements, bool expectedCondition)
        {
            return (driver) =>
            {
                try
                {
                    return elements.All(element => element.Displayed().Equals(expectedCondition));
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false;
                }
            };
        }

        #endregion

        #region Wait for Element to be (not) Displayed

        public static void WaitForElementToBeNotDisplayed(this RemoteWebDriver driver, IWebElement element, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementDisplayCondition(driver, element, false, waitSeconds);
        }

        public static void WaitForElementToBeDisplayed(this RemoteWebDriver driver, IWebElement element, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementDisplayCondition(driver, element, true, waitSeconds);
        }

        public static void WaitForElementToBeDisplayed(this RemoteWebDriver driver, By locator, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementDisplayCondition(driver, locator, true, waitSeconds);
        }

        public static void WaitForElementToBeNotDisplayed(this RemoteWebDriver driver, By locator, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementDisplayCondition(driver, locator, false, waitSeconds);
        }

        private static void WaitForElementDisplayCondition(this RemoteWebDriver driver, By by, bool condition, int waitSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSeconds));
                wait.Until(ElementIsInDisplayedCondition(by, condition));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element with '{by}' selector was not changed Display condition to '{condition}' after {waitSeconds} seconds", e);
            }
        }

        private static void WaitForElementDisplayCondition(this RemoteWebDriver driver, IWebElement element, bool condition, int waitSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSeconds));
                wait.Until(ElementIsInDisplayedCondition(element, condition));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element was not changed Display condition to '{condition}' after {waitSeconds} seconds", e);
            }
        }

        //Return true if find at least one element by provided selector with Displayed condition true
        private static Func<IWebDriver, bool> ElementIsInDisplayedCondition(By locator, bool displayedCondition)
        {
            return (driver) =>
            {
                try
                {
                    var elements = driver.FindElements(locator);
                    //If no elements found
                    if (!elements.Any())
                        return false.Equals(displayedCondition);
                    return elements.Any(x => x.Displayed().Equals(displayedCondition));
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(displayedCondition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(displayedCondition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(displayedCondition);
                }
            };
        }

        private static Func<IWebDriver, bool> ElementIsInDisplayedCondition(IWebElement element, bool displayedCondition)
        {
            return (driver) =>
            {
                try
                {
                    return element.Displayed().Equals(displayedCondition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(displayedCondition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(displayedCondition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(displayedCondition);
                }
            };
        }

        #endregion

        #region Wait for Element to be (not) Displayed After Refresh

        public static void WaitForElementToBeNotDisplayedAfterRefresh(this RemoteWebDriver driver, IWebElement element, bool waitForDataLoading = false, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementDisplayConditionAfterRefresh(driver, element, false, waitSeconds, waitForDataLoading);
        }

        public static void WaitForElementToBeDisplayedAfterRefresh(this RemoteWebDriver driver, IWebElement element, bool waitForDataLoading = false, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementDisplayConditionAfterRefresh(driver, element, true, waitSeconds, waitForDataLoading);
        }

        public static void WaitForElementToBeDisplayedAfterRefresh(this RemoteWebDriver driver, By locator, bool waitForDataLoading = false, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementDisplayConditionAfterRefresh(driver, locator, true, waitSeconds, waitForDataLoading);
        }

        public static void WaitForElementToBeNotDisplayedAfterRefresh(this RemoteWebDriver driver, By locator, bool waitForDataLoading = false, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementDisplayConditionAfterRefresh(driver, locator, false, waitSeconds, waitForDataLoading);
        }

        private static void WaitForElementDisplayConditionAfterRefresh(this RemoteWebDriver driver, By by, bool condition, int waitSeconds, bool waitForDataLoading)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSeconds));
                wait.Until(ElementIsInDisplayedConditionAfterRefresh(by, condition, waitForDataLoading));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element with '{by}' selector was not changed Display condition to '{condition}' after {waitSeconds} seconds", e);
            }
        }

        private static void WaitForElementDisplayConditionAfterRefresh(this RemoteWebDriver driver, IWebElement element, bool condition, int waitSeconds, bool waitForDataLoading)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSeconds));
                wait.Until(ElementIsInDisplayedConditionAfterRefresh(element, condition, waitForDataLoading));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element was not changed Display condition to '{condition}' after {waitSeconds} seconds", e);
            }
        }

        //Return true if find at least one element by provided selector with Displayed condition true
        private static Func<IWebDriver, bool> ElementIsInDisplayedConditionAfterRefresh(By locator, bool displayedCondition, bool waitForDataLoading)
        {
            return (driver) =>
            {
                try
                {
                    driver.Navigate().Refresh();

                    if (waitForDataLoading)
                        WaitForDataLoading((RemoteWebDriver)driver);

                    var elements = driver.FindElements(locator);
                    //If no elements found
                    if (!elements.Any())
                        return false.Equals(displayedCondition);
                    return elements.Any(x => x.Displayed().Equals(displayedCondition));
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(displayedCondition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(displayedCondition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(displayedCondition);
                }
            };
        }

        private static Func<IWebDriver, bool> ElementIsInDisplayedConditionAfterRefresh(IWebElement element, bool displayedCondition, bool waitForDataLoading)
        {
            return (driver) =>
            {
                try
                {
                    driver.Navigate().Refresh();

                    if (waitForDataLoading)
                        WaitForDataLoading((RemoteWebDriver)driver);

                    return element.Displayed().Equals(displayedCondition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(displayedCondition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(displayedCondition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(displayedCondition);
                }
            };
        }

        #endregion

        #region Wait for Element to be (not) Enabled

        public static void WaitForElementToBeNotEnabled(this RemoteWebDriver driver, IWebElement element, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementEnabledCondition(driver, element, false, waitSeconds);
        }

        public static void WaitForElementToBeEnabled(this RemoteWebDriver driver, IWebElement element, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementEnabledCondition(driver, element, true, waitSeconds);
        }

        public static void WaitForElementToBeEnabled(this RemoteWebDriver driver, By locator, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementEnabledCondition(driver, locator, true, waitSeconds);
        }

        public static void WaitForElementToBeNotEnabled(this RemoteWebDriver driver, By locator, int waitSeconds = WaitTimeoutSeconds)
        {
            WaitForElementEnabledCondition(driver, locator, false, waitSeconds);
        }

        private static void WaitForElementEnabledCondition(this RemoteWebDriver driver, By by, bool condition, int waitSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSeconds));
                wait.Until(ElementIsInEnabledCondition(by, condition));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element with '{by}' selector was not changed Enabled condition to '{condition}' after {waitSeconds} seconds", e);
            }
        }

        private static void WaitForElementEnabledCondition(this RemoteWebDriver driver, IWebElement element, bool condition, int waitSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSeconds));
                wait.Until(ElementIsInEnabledCondition(element, condition));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new Exception($"Element was not changed Enabled condition to '{condition}' after {waitSeconds} seconds", e);
            }
        }

        //Return true if find at least one element by provided selector with Displayed condition true
        private static Func<IWebDriver, bool> ElementIsInEnabledCondition(By locator, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    var elements = driver.FindElements(locator);
                    //If no elements found
                    if (!elements.Any())
                        return false.Equals(condition);
                    return elements.Any(x => x.Enabled.Equals(condition));
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        private static Func<IWebDriver, bool> ElementIsInEnabledCondition(IWebElement element, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    return element.Enabled.Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        #endregion

        #region Wait for text in Element

        public static void WaitForElementToNotHaveText(this RemoteWebDriver driver, IWebElement element, string expectedText, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsText(driver, element, expectedText, false, waitSec);
        }

        public static void WaitForElementToNotHaveText(this RemoteWebDriver driver, By selector, string expectedText, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsText(driver, selector, expectedText, false, waitSec);
        }

        public static void WaitForElementToHaveText(this RemoteWebDriver driver, IWebElement element, string expectedText, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsText(driver, element, expectedText, true, waitSec);
        }

        public static void WaitForElementToHaveText(this RemoteWebDriver driver, By selector, string expectedText, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsText(driver, selector, expectedText, true, waitSec);
        }

        private static void WaitElementHaveText(this RemoteWebDriver driver, IWebElement element, string expectedText, bool condition, int waitSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(TextToBeContainsInElement(element, expectedText, condition));
            }
            catch (Exception)
            {
                throw new Exception($"Text '{expectedText}' is not appears/disappears in the element after {waitSec} seconds");
            }
        }

        private static void WaitElementHaveText(this RemoteWebDriver driver, By by, string expectedText, bool condition, int waitSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(TextToBeContainsInElement(by, expectedText, condition));
            }
            catch (Exception)
            {
                throw new Exception($"Text '{expectedText}' is not appears/disappears in the element located by '{by}' selector after {waitSec} seconds");
            }
        }

        private static Func<IWebDriver, bool> TextToBePresentInElement(IWebElement element, string text, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    return element.Text.Equals(text).Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        private static Func<IWebDriver, bool> TextToBePresentInElement(By by, string text, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    var element = driver.FindElement(by);
                    return element.Text.Equals(text).Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        #endregion

        #region Wait for Element contains text

        public static void WaitForElementToNotContainsText(this RemoteWebDriver driver, IWebElement element, string expectedText, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsText(driver, element, expectedText, false, waitSec);
        }

        public static void WaitForElementToNotContainsText(this RemoteWebDriver driver, By selector, string expectedText, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsText(driver, selector, expectedText, false, waitSec);
        }

        public static void WaitForElementToContainsText(this RemoteWebDriver driver, IWebElement element, string expectedText, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsText(driver, element, expectedText, true, waitSec);
        }

        public static void WaitForElementToContainsText(this RemoteWebDriver driver, By selector, string expectedText, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsText(driver, selector, expectedText, true, waitSec);
        }

        private static void WaitElementContainsText(this RemoteWebDriver driver, IWebElement element, string expectedText, bool condition, int waitSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(TextToBeContainsInElement(element, expectedText, condition));
            }
            catch (Exception)
            {
                throw new Exception($"Text '{expectedText}' is not appears/disappears in the element after {waitSec} seconds");
            }
        }

        private static void WaitElementContainsText(this RemoteWebDriver driver, By by, string expectedText, bool condition, int waitSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(TextToBeContainsInElement(by, expectedText, condition));
            }
            catch (Exception)
            {
                throw new Exception($"Text '{expectedText}' is not appears/disappears in the element located by '{by}' selector after {waitSec} seconds");
            }
        }

        private static Func<IWebDriver, bool> TextToBeContainsInElement(IWebElement element, string text, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    return element.Text.Contains(text).Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        private static Func<IWebDriver, bool> TextToBeContainsInElement(By by, string text, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    var element = driver.FindElement(by);
                    return element.Text.Contains(text).Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        #endregion

        #region Wait for text in Element after refresh

        public static void WaitForElementToNotContainsTextAfterRefresh(this RemoteWebDriver driver, IWebElement element, string expectedText, bool waitForDataLoading = false, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsTextAfterRefresh(driver, element, expectedText, false, waitSec, waitForDataLoading);
        }

        public static void WaitForElementToNotContainsTextAfterRefresh(this RemoteWebDriver driver, By selector, string expectedText, bool waitForDataLoading = false, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsTextAfterRefresh(driver, selector, expectedText, false, waitSec, waitForDataLoading);
        }

        public static void WaitForElementToContainsTextAfterRefresh(this RemoteWebDriver driver, IWebElement element, string expectedText, bool waitForDataLoading = false, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsTextAfterRefresh(driver, element, expectedText, true, waitSec, waitForDataLoading);
        }

        public static void WaitForElementToContainsTextAfterRefresh(this RemoteWebDriver driver, By selector, string expectedText, bool waitForDataLoading = false, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsTextAfterRefresh(driver, selector, expectedText, true, waitSec, waitForDataLoading);
        }

        private static void WaitElementContainsTextAfterRefresh(this RemoteWebDriver driver, IWebElement element, string expectedText, bool condition, int waitSec, bool waitForDataLoading)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(TextToBeContainsInElementAfterRefresh(element, expectedText, condition, waitForDataLoading));
            }
            catch (Exception)
            {
                throw new Exception($"Text '{expectedText}' is not appears/disappears in the element after {waitSec} seconds");
            }
        }

        private static void WaitElementContainsTextAfterRefresh(this RemoteWebDriver driver, By by, string expectedText, bool condition, int waitSec, bool waitForDataLoading)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(TextToBeContainsInElementAfterRefresh(by, expectedText, condition, waitForDataLoading));
            }
            catch (Exception)
            {
                throw new Exception($"Text '{expectedText}' is not appears/disappears in the element located by '{by}' selector after {waitSec} seconds");
            }
        }

        private static Func<IWebDriver, bool> TextToBeContainsInElementAfterRefresh(IWebElement element, string text, bool condition, bool waitForDataLoading)
        {
            return (driver) =>
            {
                try
                {
                    WaitForElementToBeDisplayedAfterRefresh((RemoteWebDriver)driver, element, waitForDataLoading, 5);

                    return element.Text.Contains(text).Equals(condition);
                }
                catch (TimeoutException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        private static Func<IWebDriver, bool> TextToBeContainsInElementAfterRefresh(By by, string text, bool condition, bool waitForDataLoading)
        {
            return (driver) =>
            {
                try
                {
                    WaitForElementToBeDisplayedAfterRefresh((RemoteWebDriver)driver, by, waitForDataLoading, 5);

                    var element = driver.FindElement(by);
                    return element.Text.Contains(text).Equals(condition);
                }
                catch (TimeoutException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        #endregion

        #region Wait for text in Element attribute

        public static void WaitForElementToNotContainsTextInAttribute(this RemoteWebDriver driver, IWebElement element, string expectedText, string attribute, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsTextInAttribute(driver, element, expectedText, attribute, false, waitSec);
        }

        public static void WaitForElementToNotContainsTextInAttribute(this RemoteWebDriver driver, By selector, string expectedText, string attribute, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsTextInAttribute(driver, selector, expectedText, attribute, false, waitSec);
        }

        public static void WaitForElementToContainsTextInAttribute(this RemoteWebDriver driver, IWebElement element, string expectedText, string attribute, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsTextInAttribute(driver, element, expectedText, attribute, true, waitSec);
        }

        public static void WaitForElementToContainsTextInAttribute(this RemoteWebDriver driver, By selector, string expectedText, string attribute, int waitSec = WaitTimeoutSeconds)
        {
            WaitElementContainsTextInAttribute(driver, selector, expectedText, attribute, true, waitSec);
        }

        private static void WaitElementContainsTextInAttribute(this RemoteWebDriver driver, IWebElement element, string expectedText, string attribute, bool condition, int waitSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(TextToBeContainsInElementAttribute(element, expectedText, attribute, condition));
            }
            catch (Exception)
            {
                throw new Exception($"Text '{expectedText}' is not appears/disappears in the '{attribute}' element attribute after {waitSec} seconds");
            }
        }

        private static void WaitElementContainsTextInAttribute(this RemoteWebDriver driver, By by, string expectedText, string attribute, bool condition, int waitSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(TextToBeContainsInElementAttribute(by, expectedText, attribute, condition));
            }
            catch (Exception)
            {
                throw new Exception($"Text '{expectedText}' is not appears/disappears in the '{attribute}' element attribute located by '{by}' selector after {waitSec} seconds");
            }
        }

        private static Func<IWebDriver, bool> TextToBeContainsInElementAttribute(IWebElement element, string text, string attribute, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    return element.GetAttribute(attribute).Contains(text).Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        private static Func<IWebDriver, bool> TextToBeContainsInElementAttribute(By by, string text, string attribute, bool condition)
        {
            return (driver) =>
            {
                try
                {
                    var element = driver.FindElement(by);
                    return element.GetAttribute(attribute).Contains(text).Equals(condition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false.Equals(condition);
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false.Equals(condition);
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false.Equals(condition);
                }
            };
        }

        #endregion

        #region Element has child

        /// <summary>
        /// Wait while element do not have specified number of child elements
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="childSelector"></param>
        /// <param name="expectedCount"></param>
        public static void WaitForElementChildElements(this RemoteWebDriver driver, IWebElement element,
            By childSelector, int expectedCount)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WaitTimeoutSeconds));
                wait.Until(ElementContainsChild(element, childSelector, expectedCount));
            }
            catch (Exception)
            {
                throw new Exception($"Required number of child elements are not appears in the element after {WaitTimeoutSeconds} seconds");
            }
        }

        private static Func<IWebDriver, bool> ElementContainsChild(IWebElement element, By selector, int childCount)
        {
            return (driver) =>
            {
                try
                {
                    return element.FindElements(selector).Count >= childCount;
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false;
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false;
                }
            };
        }

        #endregion

        #region Wait for attribute in Element

        public static void WaitForAttributePresentInElement(this RemoteWebDriver driver, IWebElement element,
            string attribute, int waitSec = WaitTimeoutSeconds)
        {
            WaitForAttributeInElement(driver, element, attribute, true, waitSec);
        }

        public static void WaitForAttributeNotPresentInElement(this RemoteWebDriver driver, IWebElement element,
            string attribute, int waitSec = WaitTimeoutSeconds)
        {
            WaitForAttributeInElement(driver, element, attribute, false, waitSec);
        }

        public static void WaitForAttributePresentInElement(this RemoteWebDriver driver, By by,
            string attribute, int waitSec = WaitTimeoutSeconds)
        {
            WaitForAttributeInElement(driver, by, attribute, true, waitSec);
        }

        public static void WaitForAttributeNotPresentInElement(this RemoteWebDriver driver, By by,
            string attribute, int waitSec = WaitTimeoutSeconds)
        {
            WaitForAttributeInElement(driver, by, attribute, false, waitSec);
        }

        private static void WaitForAttributeInElement(this RemoteWebDriver driver, IWebElement element, string attribute, bool expectedCondition, int waitSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(AttributeToBePresentInElement(element, attribute, expectedCondition));
            }
            catch (Exception)
            {
                throw new Exception($"Attribute '{attribute}' is not appears in the element after {waitSec} seconds");
            }
        }

        private static void WaitForAttributeInElement(this RemoteWebDriver driver, By by, string attribute, bool expectedCondition, int waitSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSec));
                wait.Until(AttributeToBePresentInElement(by, attribute, expectedCondition));
            }
            catch (Exception)
            {
                throw new Exception($"Attribute '{attribute}' is not appears in the element located by '{by}' selector after {waitSec} seconds");
            }
        }

        private static Func<IWebDriver, bool> AttributeToBePresentInElement(IWebElement element, string attribute, bool expectedCondition)
        {
            return (driver) =>
            {
                try
                {
                    return element.IsAttributePresent(attribute).Equals(expectedCondition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false;
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false;
                }
            };
        }

        private static Func<IWebDriver, bool> AttributeToBePresentInElement(By by, string attribute, bool expectedCondition)
        {
            return (driver) =>
            {
                try
                {
                    var element = driver.FindElement(by);
                    return element.IsAttributePresent(attribute).Equals(expectedCondition);
                }
                catch (NoSuchElementException)
                {
                    // Returns false because the element is not present in DOM.
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    // Returns false because stale element reference implies that element
                    // is no longer visible.
                    return false;
                }
                catch (InvalidOperationException)
                {
                    // Return false as no elements was located
                    return false;
                }
            };
        }

        #endregion

        #region Actions with Javascript

        public static void ClickByJavascript(this RemoteWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", element);
        }

        public static void ClearByJavascript(this RemoteWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].value = '';", element);
        }

        public static void SendKeyByJavascript(this RemoteWebDriver driver, IWebElement element, string str)
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript($"arguments[0].value = '{str}';", element);
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

        public static bool IsElementDisplayed(this RemoteWebDriver driver, IWebElement element, WaitTime waitTime)
        {
            try
            {
                var time = int.Parse(waitTime.GetValue());
                driver.WaitForElementToBeDisplayed(element, time);
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

        public static bool IsElementDisplayed(this RemoteWebDriver driver, By selector, WaitTime waitTime)
        {
            try
            {
                var time = int.Parse(waitTime.GetValue());
                driver.WaitForElementToBeDisplayed(selector, time);
                return driver.FindElement(selector).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public enum WaitTime
        {
            [Description("6")]
            Short,
            [Description("15")]
            Medium,
            [Description("30")]
            Long
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

        public static bool IsAttributePresent(this IWebElement element, string attribute)
        {
            try
            {
                var value = element.GetAttribute(attribute);
                return value != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}