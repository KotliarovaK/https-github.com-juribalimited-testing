using System;
using System.Collections.Generic;
using System.Threading;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace DashworksTestAutomation.Extensions
{
    public static class WebElementExtensions
    {
        public static void ClearWithBackspaces(this IWebElement textbox, int charectersCount = 50)
        {
            for (int i = 0; i < charectersCount; i++) textbox.SendKeys(Keys.Backspace);
        }

        public static void ClearWithHomeButton(this IWebElement textbox, RemoteWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.Click(textbox).SendKeys(Keys.End).KeyDown(Keys.Shift).SendKeys(Keys.Home).KeyUp(Keys.Shift)
                .SendKeys(Keys.Backspace).Perform();
        }

        public static void SendkeysWithDelay(this IWebElement textbox, string input)
        {
            foreach (char letter in input) textbox.SendKeys(letter.ToString());
        }

        //This is specific method for 'ng-table-select-count' elements
        public static void SelectboxSelect(this IWebElement selectbox, string option, bool ignoreCase = false)
        {
            if (ignoreCase)
            {
                var selectElement = new SelectElement(selectbox);
                IList<IWebElement> options = selectElement.Options;
                for (int i = 0; i < options.Count; i++)
                    if (string.Equals(options[i].Text, option, StringComparison.InvariantCultureIgnoreCase))
                    {
                        selectElement.SelectByIndex(i);
                        break;
                    }
            }
            else
            {
                var selectElement = new SelectElement(selectbox);
                selectElement.SelectByText(option);
            }
        }

        //This is specific method for 'ng-table-select-count' elements
        public static string GetSelectedValue(this IWebElement selectbox)
        {
            try
            {
                return selectbox.FindElement(By.XPath(".//div[contains(@ng-bind,'select.selected.name')]")).Text;
            }
            catch (Exception e)
            {
                Logger.Write("Unable to get selected value from selectbox");
                throw e;
            }
        }

        public static IWebElement UntilElementHasChilds(this IWebElement element, RemoteWebDriver driver, By locator,
            TimeSpan timeOut, int childsCount = 4)
        {
            new WebDriverWait(driver, timeOut).Until(d => element.FindElements(locator).Count >= childsCount);

            return element;
        }

        public static bool Displayed(this IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch
            {
                return false;
            }
        }

        public static bool Disabled(this IWebElement element)
        {
            var isDisabled = element.GetAttribute("disabled");
            if (isDisabled != null)
                return bool.Parse(isDisabled);

            var classValue = element.GetAttribute("class");
            if (classValue == null)
                throw new Exception("Unable to get element Disabled state.");

            return classValue.Contains("disabled");
        }

        public static bool IsElementExists(this IWebElement element, By by)
        {
            try
            {
                element.FindElement(by);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsElementDisplayed(this IWebElement element, By by)
        {
            try
            {
                return element.FindElement(by).Displayed;
            }
            catch
            {
                return false;
            }
        }

        #region Checkboxes

        public static void CheckCheckBox(this IWebElement checkbox)
        {
            if (!checkbox.Selected)
                checkbox.Click();
        }

        public static void UncheckCheckBox(this IWebElement checkbox)
        {
            if (checkbox.Selected)
                checkbox.Click();
        }

        public static void SetCheckboxState(this IWebElement checkbox, bool desiredState)
        {
            if (desiredState)
            {
                if (!checkbox.Selected)
                    checkbox.Click();
            }
            else
            {
                if (checkbox.Selected)
                    checkbox.Click();
            }
        }

        /// <summary>
        ///     This method is used for checkboxes in Filters panel
        /// </summary>
        /// <param name="checkbox"></param>
        /// <returns></returns>
        public static bool GetFilterCheckboxSelectedState(this IWebElement checkbox)
        {
            return checkbox.GetAttribute("class").Contains("mat-checkbox-checked");
        }

        #endregion Checkboxes
    }
}