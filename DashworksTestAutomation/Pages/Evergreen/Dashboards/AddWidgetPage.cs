﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class AddWidgetPage : SeleniumBasePage
    {
        public const string ColorSchemeDropdownContent = ".//div/mat-option[contains(@class, 'colour-scheme')]//div[contains(@class, 'inner-colour')]";

        public const string ColorSchemeDropdownContainer = ".//div[@class='cdk-overlay-pane']";

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='WidgetType']")]
        public IWebElement WidgetType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'mat-select-placeholder')]")]
        public IList<IWebElement> Dropdowns { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Title']")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List']")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='SplitBy']")]
        public IWebElement SplitBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='cdk-overlay-pane']")]
        public IWebElement DropdownMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Type']")]
        public IWebElement Type { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='AggregateBy']")]
        public IWebElement AggregateBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='AggregateFunction']")]
        public IWebElement AggregateFunction { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='OrderBy']")]
        public IWebElement OrderBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='TableOrientation']")]
        public IWebElement TableOrientation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Drilldown']")]
        public IWebElement Drilldown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Max Rows']")]
        public IWebElement MaxRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Max Columns']")]
        public IWebElement MaxColumns { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Max Values']")]
        public IWebElement MaxValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='ColorScheme']")]
        public IWebElement ColorScheme { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@formcontrolname='colourSchemeId']")]
        public IWebElement ColorSchemeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@formcontrolname='colourSchemeId']//span")]
        public IWebElement ColorSchemePlaceholder { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[@formcontrolname='showLegend']/label")]
        public IWebElement ShowLegend { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[@formcontrolname='showLegend']/label/span")]
        public IWebElement ShowLegendLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[@formcontrolname='displayDataLabels']/label/span")]
        public IWebElement ShowDataLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='actions']/button[contains(@class,'star')]")]
        public IWebElement CreateUpdateWidgetButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//deactivate-guard-dialog/parent::mat-dialog-container")]
        public IWebElement UnsavedChangesAlert { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-error//span")]
        public IWebElement WarningTextUnderField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='This list does not exist or you do not have access to it']")]
        public IWebElement ListDoesntExistMessage { get; set; }

        

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.WidgetType),
            };
        }

        public IWebElement GetDropdownForWidgetByName(string dropdownName)
        {
            var dropdownSelector = By.XPath($".//div[contains(@class, 'mat-form')]/span/label[text()='{dropdownName}']");
            return Driver.FindElement(dropdownSelector);
        }

        public void SelectObjectForWidgetCreation(string objectName)
        {
            var listNameSelector = $".//span[@class='mat-option-text'][contains(text(), '{objectName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public void SelectListForWidgetCreation(string listName)
        {
            var listNameSelector = $".//mat-option//span[contains(text(), '{listName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public void SelectSplitByItem(string item)
        {
            var splitBy = ".//*[@aria-label='SplitBy']";
            var expandedItems = $".//span[@class='mat-option-text']";
            var listNameSelector = $".//mat-option//span[contains(text(), '{item}')]";

            for (int i = 0; i < 3; i++)
            {
                if (Driver.FindElements(By.XPath(expandedItems)).Count > 0)
                {
                    Driver.FindElement(By.XPath(listNameSelector)).Click();
                    break;
                }
                else
                {
                    Driver.FindElement(By.XPath(splitBy)).Click();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        public IWebElement GetUnsavedChangesAlertText()
        {
            var selector = $".//deactivate-guard-dialog/parent::mat-dialog-container//p";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement UnsavedChangesAlertButton(string buttonTitle)
        {
            var selector = $".//deactivate-guard-dialog/parent::mat-dialog-container//span[text()='{buttonTitle}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement GetColorFromColorScheme(string colorTitle)
        {
            var selector = $".//div[@class='inner-colour'][text()='{colorTitle}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IList<IWebElement> GetDropdownOptions()
        {
            return Driver.FindElements(By.XPath(".//mat-option"));
        }

        public void ClickColorSchemeByIndex(int index)
        {
            Driver.FindElement(By.XPath($".//mat-option[{index}]")).Click();
        }

        public bool GetCheckboxByName(string checkboxName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//mat-checkbox//span[text()='{checkboxName}']//ancestor::mat-checkbox"));
        }

        public IWebElement GetDashboardCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//mat-checkbox//span[text()='{checkboxName}']//ancestor::mat-checkbox");
            return Driver.FindElement(selector);
        }
      
        public IWebElement GetPreviewFirstCellValue()
        {
            var byFirstVer =By.XPath(".//div[@class='widget-preview-inner ng-star-inserted']//span[@class='status-text']");
            var bySecondVer = By.XPath(".//div[@class='widget-preview-inner ng-star-inserted']//span[@class='text-value']");
            var byOtherVer = By.XPath(".//div[@class='card-widget-value ng-star-inserted']/div");

            if (Driver.FindElements(byFirstVer).Count > 0)
                return Driver.FindElement(byFirstVer);

            if (Driver.FindElements(bySecondVer).Count > 0)
                return Driver.FindElement(bySecondVer);

            else
            {
                return Driver.FindElement(byOtherVer);
            }
        }
        
        public IWebElement GetTableWidgetPreview()
        {
            return Driver.FindElement(By.XPath(".//div[@class='table-responsive']"));
        }

        public bool IsAggregateByDropdownDisabled()
        {
            return Convert.ToBoolean(AggregateBy.GetAttribute("aria-disabled"));
        }

        public bool IsColorSchemeDropdownDisabled()
        {
            return Convert.ToBoolean(ColorSchemeDropdown.GetAttribute("aria-disabled"));
        }


    }
}