﻿using System;
using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ProjectsPage : BaseGridPage
    {
        public const string ExpandedScopeDropdownSection = ".//div[@role='listbox']";

        [FindsBy(How = How.XPath, Using = ".//a[text()='Administration']")]
        public IWebElement AdminPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-checked='false']")]
        public IWebElement UncheckedCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'wrapper-disabled')]")]
        public IWebElement DisabledAllAssociations { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[contains(@class, 'mat-checkbox-disabled')]")]
        public IWebElement DisabledAssociation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ng-star-inserted']/div[@class='wrapper-outer']")]
        public IWebElement UserScopeCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='wrapper-disabled']")]
        public IWebElement ApplicationScopeCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-option-text']")]
        public IWebElement DeleteProjectInActions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[contains(@class, 'mat-form-field-empty')]")]
        public IWebElement EmptyScopeField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@title, 'Update')]")]
        public IWebElement UpdateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Update All Changes']")]
        public IWebElement UpdateAllChangesButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='mode']")]
        public IWebElement ModeProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[@id='buckets']")]
        public IWebElement BucketsProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@role='combobox']")]
        public IWebElement ScopeProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[contains(@aria-label, 'Scope')]")]
        public IWebElement ScopeListDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-select-value']//span/span")]
        public IWebElement ScopeListDropdownValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='mat-form-field-infix']/mat-select[@aria-disabled='true']")]
        public IWebElement DisabledScopeListDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='mat-form-field-infix']/mat-select[@aria-disabled='false']")]
        public IWebElement ActiveScopeListDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='buckets']")]
        public IWebElement BucketDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Project Name']")]
        public IWebElement ProjectName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Project Short Name']")]
        public IWebElement ProjectShortName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Project Description']")]
        public IWebElement ProjectDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Project Type']")]
        public IWebElement ProjectType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Default Language']")]
        public IWebElement DefaultLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Select Permission']")]
        public IWebElement PermissionsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Date']")]
        public IWebElement DateFilterValue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Application Scope']")]
        public IWebElement ApplicationScopeTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions']/admin-mailbox-permission/ul/li/button/span")]
        public IWebElement AddMailboxPermissionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-container']/div/button/span[text()='ADD PERMISSION']")]
        public IWebElement AddPermissionsButtonInTab { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//div[@class='permissions no-margin-bottom']/admin-mailbox-permission/ul/li/button/span")]
        public IWebElement AddMailboxFolderPermissionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Path']")]
        public IWebElement PathDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Category']")]
        public IWebElement CategoryDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='readinessForOnboardedApplications']")]
        public IWebElement DefaultReadinessDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'mat-tab-label-active')]")]
        public IWebElement ActiveTabOnScopeChangesSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='error-status-box']//span[contains(text(),'404')]")]
        public IWebElement DetailsPageWasNotFound { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container//h1[text()='Warning']")]
        public IWebElement WarningPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-optgroup/label")]
        public IList<IWebElement> ScopeDropdownSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-optgroup//span")]
        public IList<IWebElement> ScopeDropdownSectionList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='btn-group-sm pull-right ng-star-inserted']")]
        public IWebElement CloseSidePanelCross { get; set; }

        //TODO should be moved to generic page
        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'buttonToggleSubmenu')]")]
        public IWebElement ExpandSidePanelIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-tab-header/div[1]")]
        public IWebElement ScopeChangesTabsHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-tip ng-star-inserted']")]
        public IWebElement ScopeChangesNotificationsPane { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-error/span[contains(text(), 'archived devices')]")]
        public IWebElement ArchivedDevicesMessage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AdminPageTitle)
            };
        }

        public void SendKeysToTheNamedTextbox(string text, string fieldName)
        {
            if (!string.IsNullOrEmpty(text))
            {
                GetFieldByName(fieldName).ClearWithBackspaces();
                GetFieldByName(fieldName).SendKeys(text);
            }
        }

        public string GetDllPanelHeight()
        {
            return Driver.FindElement(By.XPath(".//div[@class='cdk-overlay-pane']")).GetCssValue("height");
        }

        public string GetDllPanelWidth()
        {
            return Driver.FindElement(By.XPath(".//div[@role='listbox']")).GetCssValue("width");
        }

        public void NavigateToProjectTabByName(string tabName)
        {
            var tab = Driver.FindElement(
                By.XPath($".//mat-tree//a[text()='{tabName}']"));
            tab.Click();
        }

        public IWebElement GetSubMenuByName(string menuName)
        {
            var button = By.XPath($".//button[contains(@class, 'subMenu-title')]//span[text()='{menuName}']");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }

        public IWebElement GetsSelectedTabByName(string tabName)
        {
            var button = By.XPath($".//div[contains(@class, 'item-selected')]//span[text()='{tabName}']");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }

        public IWebElement GetsSelectedTabInProjectByName(string tabName)
        {
            var button = By.XPath($".//li[contains(@class, 'node active')]//a[text()='{tabName}']");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }

        public IWebElement GetTabByNameOnCapacityUnits(string tabName)
        {
            var button = By.XPath($".//div[contains(@class, 'menuItems')]//span[text()='{tabName}']");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }

        public void NavigateToProjectTabInScopeSectionByName(string tabName)
        {
            var tab = Driver.FindElement(
                By.XPath($".//div[@class='detail-label ng-star-inserted']//span[text()='{tabName}']"));
            tab.Click();
        }

        public void ClickToTabByNameProjectScopeChanges(string tabName)
        {
            var selector =
                By.XPath($".//div[@class='detail-label ng-star-inserted']/span[contains(text(), '{tabName}')]");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
                throw new Exception($"'{tabName}' Project Scope tab was not displayed");
            var tab = Driver.FindElement(selector);
            tab.Click();
        }

        public void ClickAssociatedCheckbox(string checkboxName)
        {
            var tab = Driver.FindElement(
                By.XPath($".//span[@class='mat-checkbox-label'][contains(text(), '{checkboxName}')]"));
            tab.Click();
        }

        public IWebElement SelectRadioButtonByName(string radioButtonName)
        {
            var button = By.XPath($".//div[text()='{radioButtonName}']/../div[@class='mat-radio-container']");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }

        public IWebElement GetNavigationLinkByName(string linkName)
        {
            var link = By.XPath($".//div[@class='title-container']//a[text()='{linkName}']");
            Driver.WaitForElementToBeDisplayed(link);
            Driver.WaitForElementToBeEnabled(link);
            return Driver.FindElement(link);
        }

        public IWebElement GetButtonOnWarningContainerByName(string linkName)
        {
            var button = By.XPath($".//div[@class='mat-dialog-actions']//span[text()='{linkName}']/ancestor::button");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }

        public IWebElement GetAssociatedCheckboxByName(string associatedCheckbox)
        {
            var button = By.XPath($".//span[text()='{associatedCheckbox}']/../div/input[@type='checkbox']");
            Driver.WaitForElementToBeDisplayed(button);
            return Driver.FindElement(button);
        }

        public void RemovePermissionsByName(string permissions)
        {
            var element = Driver.FindElement(
                By.XPath($".//li//span[text()='{permissions}']//following-sibling::button"));
            Driver.WhatForElementToBeExists(element);
            element.Click();
            Driver.WaitForDataLoading();
        }

        //TODO should be moved to BasePage
        public void SelectCheckboxByName(string checkboxName)
        {
            var tab = Driver.FindElement(
                By.XPath($".//span[@class='mat-checkbox-label'][text()='{checkboxName}']"));
            tab.Click();
        }

        public void SelectPermissionsByName(string permissions)
        {
            var element = Driver.FindElement(
                By.XPath($".//mat-option/span[text()='{permissions}']"));
            Driver.WhatForElementToBeExists(element);
            Driver.MouseHover(element);
            element.Click();
        }

        public bool PermissionsDisplay(string permissions)
        {
            return Driver.IsElementDisplayed(By.XPath($".//li/span[text()='{permissions}']"));
        }

        public bool CheckboxesDisplay(string checkboxes)
        {
            return Driver.IsElementDisplayed(By.XPath(
                $".//mat-checkbox[contains(@class, 'checkbox-checked')]/label/span[contains(text(), '{checkboxes}')]"));
        }

        //TODO this method should be removed, replaced by generic web element
        public bool ActiveProjectByName(string projectName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//h1[text()='{projectName}']"));
        }

        public bool BucketDropdownDisplay(string textBucket)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[text()='{textBucket}']"));
        }

        public bool SelectedItemInProjectScopeChangesSection(string text)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[@class='title'][contains(text(), '{text}')]"));
        }

        public void SelectObjectForProjectCreation(string objectName)
        {
            var listNameSelector = $".//span[@class='mat-option-text'][contains(text(), '{objectName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public void SelectProjectsMode(string objectName)
        {
            var listNameSelector = $".//span[@class='mat-option-text'][text()='{objectName}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public void GetCheckboxStringFilterWithItemListByName(string filterName)
        {
            if (filterName.Equals("Select All"))
            {
                var selector = ".//span[text()='Select All']";
                Driver.WaitForElementToBeDisplayed(By.XPath(selector));
                Driver.FindElement(By.XPath(selector)).Click();
            }
            else
            {
                var filterSelector = $".//mat-option//div//span[text()='{filterName}']";
                Driver.WaitForElementToBeDisplayed(By.XPath(filterSelector));
                Driver.FindElement(By.XPath(filterSelector)).Click();
            }
        }

        public void GetCheckboxStringFilterByName(string filterName)
        {
            var filterSelector = $".//mat-option//span[text()='{filterName}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(filterSelector));
            Driver.FindElement(By.XPath(filterSelector)).Click();
        }

        public void SelectProjectLanguage(string language)
        {
            var listNameSelector = $".//span[@class='mat-option-text'][text()='{language}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public IWebElement SelectPathByName(string pathName)
        {
            var requestTypeSelector = $".//mat-option/span[contains(text(), '{pathName}')]";
            if (!Driver.IsElementDisplayed(By.XPath(requestTypeSelector), WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"'{pathName}' path is not present in the selectbox");
            return Driver.FindElement(By.XPath(requestTypeSelector));
        }

        public IWebElement GetPathOrCategory(string pathTypeName)
        {
            var pathSelector = $".//mat-select//div//span[contains(text(), '{pathTypeName}')]";
            return Driver.FindElement(By.XPath(pathSelector));
        }

        public IWebElement GetReadinessOptionByName(string colorName)
        {
            var option = $".//mat-option[@role='option']//span[text()='{colorName}']";
            return Driver.FindElement(By.XPath(option));
        }

        public IWebElement SelectCategoryByName(string categoryName)
        {
            var categorySelector = $".//mat-option/span[contains(text(), '{categoryName}')]";
            if (!Driver.IsElementDisplayed(By.XPath(categorySelector), WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"'{categoryName}' category was not displayed in the selectbox");
            return Driver.FindElement(By.XPath(categorySelector));
        }

        public bool GetDisabledAssociationName(string associationName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//mat-checkbox[contains(@class, 'disabled')]/label/span[text()='{associationName}']"));
        }

        public bool GetCheckboxByName(string checkboxName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[text()='{checkboxName}']"));
        }

        public bool SelectedTabInProjectScopeChangesSection(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div//span[contains(text(),'{tabName} ')]"));
        }

        public bool CheckContentDisplay(string text)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[text()='{text}']"));
        }

        //TODO this method should be removed. We already have GetNamedTextbox on BaseDashboardPage
        public IWebElement GetFieldByName(string name)
        {
            var selector = By.XPath($".//input[@placeholder='{name}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropDownByName(string name)
        {
            var selector = By.XPath($".//span[@class='mat-form-field-label-wrapper']//label[text()='{name}']/ancestor::div/mat-select");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownContentByName(string name)
        {
            var selector = By.XPath($".//span[@class='mat-form-field-label-wrapper']//label[text()='{name}']/ancestor::div/mat-select//span/span");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetLanguageMenuOptionByName(string option)
        {
            var selector = By.XPath($".//div[@class='menu']//li[text()='{option}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetButtonInWarningMessage(string name)
        {
            var selector = By.XPath($".//div[@class='inline-tip ng-star-inserted']//button/span[text()='{name}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement WarningMessageText(string text)
        {
            var selector = By.XPath($".//mat-dialog-container[@role='dialog']//p[text()='{text}']");
            return Driver.FindElement(selector);
        }

        public IWebElement GetdisabledCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//mat-checkbox[contains(@class, 'checkbox-disabled')]//span[text()='{checkboxName}']");
            return Driver.FindElement(selector);
        }

        public IWebElement GetListByNameInScopeDropdown(string listName)
        {
            var selector = By.XPath($".//mat-optgroup//*[text()='{listName}']");
            return Driver.FindElement(selector);
        }
    }

}