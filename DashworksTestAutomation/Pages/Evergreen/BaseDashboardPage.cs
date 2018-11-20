using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class BaseDashboardPage : SeleniumBasePage
    {
        public const string ColorItem = ".//div[@class='status']";

        public const string ImageItem = ".//div[contains(@class, 'ag-body-container')]//img[contains(@src,'png')]";

        public const string TableTextContent = ".//div[@role='row']/div/span";

        public const string FullTable = ".//div[contains(@class, 'ag-body-viewport')]/div";

        public const string OptionsDllOnActionsPanel = "//mat-option[@role='option']//span";

        public const string ColumnSubcategory = "//div[@class='selected-column-name']//span";

        public const string FilterSubcategory = "//div[contains(@class, 'sub-categories')]//div//div";

        public const string SelectedFiltersSubcategory = "//div[contains(@class, 'sub-categories')]//div";

        public const string SelectedColumnSubcategory = "//div[contains(@class, 'sub-categories')]//div//span";

        public const string OptionOnActionsPanel = "//mat-option[@role='option']";

        public const string GridCellByText = ".//div[@role='gridcell' and @title='{0}']";

        public const string ColumnWithEvergreenIconSelector = ".//div[@col-id='projectName'][@role='gridcell']";

        public const string ImageSelector = ".//i";

        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle-text']/descendant::h1")]
        public IWebElement Heading { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@id='_listDtlBtn'][@disabled]")]
        public IWebElement DisabledListDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='aggridHeaderCounter']//span[@class='ng-star-inserted' and count(*)=0]")]
        public IWebElement FoundRowsLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'active')]//i[contains(@class, 'static-list')]")]
        public IWebElement ActiveActionsButton { get; set; }

        #region Action Panel

        [FindsBy(How = How.XPath, Using = "//i[contains(@class, 'static-list')]/ancestor::button")]
        public IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'actions-container-row')]")]
        public IWebElement ActionsRowsCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Actions']")]
        public IWebElement ActionsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[@role='listbox']//span[text()='Bulk Update Type']")]
        public IWebElement RequestTypeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Project']")]
        public IWebElement ProjectField { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-option[@role='option']")]
        public IWebElement ProjectSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Stage']")]
        public IWebElement StageField { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Task']")]
        public IWebElement TaskField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-label='Value']")]
        public IWebElement ValueDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[contains(@class, 'mat-select')]//span[text()='Update Value']")]
        public IWebElement UpdateValueDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[contains(@class, 'mat-select')]//span[text()='Update Date']")]
        public IWebElement UpdateDateDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-select[contains(@class, 'mat-select')]//span[text()='Update Owner']")]
        public IWebElement UpdateOwnerDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Team']")]
        public IWebElement TeamField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Owner']")]
        public IWebElement OwnerField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Date']")]
        public IWebElement DateField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Request Type']")]
        public IWebElement RequestTypeField { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = "//button[contains(@id, 'listDtlBtn')]")]
        public IWebElement ListDetailsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'clmnBtn')]")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'fltrBtn')]")]
        public IWebElement FilterButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'pull-left context-toggle')]//i[@class='material-icons mat-clear']")]
        public IWebElement ClosePanelButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@role='presentation']//div[@class='ag-header-cell']//header-cell//input")]
        public IWebElement SelectAllRowsAction { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IList<IWebElement> SelectRowsCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'btn-close')]")]
        public IWebElement SearchTextBoxResetButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'resetButton mat-button')]")]
        public IWebElement SearchTextBoxResetButtonInPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='search']")]
        public IWebElement TableSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Search Table']")]
        public IWebElement TableSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'tools-item')]//button[@aria-label='close']")]
        public IWebElement CloseToolsPanelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'reload')]")]
        public IWebElement RefreshTableButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-descending-icon']")]
        public IWebElement DescendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-ascending-icon']")]
        public IWebElement AscendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'submenu-selected-list')]")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='inline-tip ng-star-inserted']")]
        public IWebElement AmberMessageOnActionPanel { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//div[contains(@class, 'notification')]//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButtonOnAmberMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'edit-action')]//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//div[contains(@class, 'notification')]//button[contains(@class, 'transparent')]//span[text()='CANCEL']/ancestor::button")]
        public IWebElement CancelButtonOnAmberMessage { get; set; }

        #region All Lists dropdown

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'DropdownActionsLists')]")]
        public IWebElement DropdownLists { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'mat-star')]/..//following-sibling::span[text()='Favourites']")]
        public IWebElement FavoritesIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'person')]/..//following-sibling::span[text()='My lists']")]
        public IWebElement MyListsIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'share')]/..//following-sibling::span[text()='Shared with me']")]
        public IWebElement SharedWithMeIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'mat-filter_list')]/..//following-sibling::span[text()='Dynamic lists']")]
        public IWebElement DynamicListsIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'done')]/..//following-sibling::span[text()='Static lists']")]
        public IWebElement StaticListsIcon { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'actions-lists')]//i[contains(@class, 'mat-list')]/..//following-sibling::span[text()='All lists']")]
        public IWebElement AllListsIcon { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'rowCount')]")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='checkbox-styled selectBox']/input")]
        public IWebElement SelectAllCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IWebElement Checkbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-container')]")]
        public IWebElement TableBody { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-viewport')]/div")]
        public IWebElement TableContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@role='row']")]
        public IList<IWebElement> TableRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='status-text'][text()='RED']")]
        public IList<IWebElement> ContentColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted'][text()='No devices found']")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'save')]//button")]
        public IWebElement SaveCustomListButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='filters']")]
        public IWebElement FilterContainerButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'sectionAddObjects wrapper-disabled')]")]
        public IWebElement DisabledObjectsToAddPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='sectionAddObjects']")]
        public IWebElement ActiveObjectsToAddPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-content']")]
        public IWebElement FilterContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']//span[@class='checkbox-unchecked']")]
        public IWebElement UncheckedCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-selection-checkbox']")]
        public IWebElement SelectOneRowsCheckboxes { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-error ng-star-inserted']")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-tip ng-star-inserted']")]
        public IWebElement WarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='context-container']//div//div[@class='ps__thumb-y']")]
        public IWebElement ActionsScrollBar { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'close')]")]
        public IWebElement CloseButtonInSuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='This list does not exist or you do not have access to it']")]
        public IWebElement DoesNotExistListMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-menu']")]
        public IWebElement AgMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@name='createActions']/div[@class='mat-select-trigger']")]
        public IWebElement CreateActionButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='active-list-wrapper ng-star-inserted']/ul/li/span")]
        public IWebElement ActiveCustomList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'ag-body-container')]/div[@role='row']")]
        public IList<IWebElement> GridRows { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[contains(@class, 'ag-body-container')]/div[@role='row']/div[@col-id='groupName']")]
        public IList<IWebElement> GridBucketsNames { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//div[contains(@class, 'list-selected-save')]//span[@class='list-selected-name']")]
        public IWebElement ActiveCustomListEdited { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'transformPanel')]//span[text()='Project']")]
        public IWebElement CreateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option[@aria-disabled='true']//span[text()='Project']")]
        public IWebElement DisabledCreateProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='top-tools-item top-tools-left-side']")]
        public IWebElement OutsideGridPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'sub-categories-item')]")]
        public IList<IWebElement> ColumnSubcategories { get; set; }

        [FindsBy(How = How.XPath, Using = OptionsDllOnActionsPanel)]
        public IList<IWebElement> OptionsDll { get; set; }

        [FindsBy(How = How.XPath, Using = ColumnSubcategory)]
        public IList<IWebElement> ColumnSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = FilterSubcategory)]
        public IList<IWebElement> FilterSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = SelectedFiltersSubcategory)]
        public IList<IWebElement> SelectedFiltersSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = SelectedColumnSubcategory)]
        public IList<IWebElement> SelectedColumnsSubcategoryList { get; set; }

        [FindsBy(How = How.XPath, Using = OptionOnActionsPanel)]
        public IList<IWebElement> OptionListOnActionsPanel { get; set; }

        #region TableColumns

        [FindsBy(How = How.XPath, Using = ".//div[@colid='lastLogonDate'][@role='gridcell']")]
        public IList<IWebElement> LastLogonColumnData { get; set; }

        #endregion TableColumns

        public bool SelectAllCheckboxState => SelectAllCheckbox.Selected;

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.Heading),
                //SelectorFor(this, p => p.List)
            };
        }

        public bool WarningMessageActionPanel(string text)
        {
            Driver.WaitForElement(By.XPath("//div[@class='inline-tip ng-star-inserted']"));
            return Driver.IsElementDisplayed(
                By.XPath($"//div[@class='inline-tip ng-star-inserted']/div[text()='{text}']"));
        }

        public bool SuccessMessageActionPanel(string text)
        {
            Driver.WaitForElement(By.XPath("//div[@class='inline-success ng-star-inserted']"));
            return Driver.IsElementDisplayed(
                By.XPath($"//div[@class='inline-success ng-star-inserted']/div[text()='{text}']"));
        }

        //Null value can be returned
        public IWebElement GetGridCell(int rowIndex, int columnNumber)
        {
            return (IWebElement)Driver.ExecuteScript(
                $"return document.querySelector(\"div[row-index = '{rowIndex}']>div:nth-of-type({columnNumber})\")");
        }

        public string GetHeaderFontWeight()
        {
            return Driver.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).GetCssValue("font-weight");
        }

        public bool IsColumnPresent(string columnName)
        {
            Driver.WaitForDataLoading();

            string selector;
            if (columnName.Contains("'"))
            {
                var strings = columnName.Split('\'');
                selector =
                    $".//div[@role='presentation']/span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[@role='presentation']/span[text()='{columnName}']";
            }

            return Driver.IsElementDisplayed(By.XPath(selector));
        }

        public IWebElement GetColumnHeaderByName(string columnName)
        {
            string selector;
            if (columnName.Contains("'"))
            {
                var strings = columnName.Split('\'');
                selector =
                    $".//div[@role='presentation']/span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]/..";
            }
            else
            {
                selector = $".//div[@role='presentation']/span[text()='{columnName}']/..";
            }

            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement GetGridCellByText(string cellText)
        {
            return Driver.FindElement(By.XPath(string.Format(GridCellByText, cellText)));
        }

        public void ContextClickOnCell(string cellText)
        {
            var builder = new Actions(Driver);
            Driver.WaitForDataLoading();
            builder.ContextClick(GetGridCellByText(cellText)).Build().Perform();
        }

        public int GetElementTopYCoordinate(IWebElement element)
        {
            return element.Location.Y;
        }

        public int GetElementBottomYCoordinate(IWebElement element)
        {
            return element.Location.Y + element.Size.Height;
        }

        public int GetElementLeftXCoordinate(IWebElement element)
        {
            return element.Location.X;
        }

        public int GetElementRightXCoordinate(IWebElement element)
        {
            return element.Location.X + element.Size.Width;
        }

        public IWebElement GetCorrectApplicationVersion(string versionNumber)
        {
            var selector = By.XPath(
                $".//div[@class='topnav-footer']//span[contains(text(),'{versionNumber}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetSubcategoryByCategoryName(string categoryName)
        {
            var selector = By.XPath(
                $"//div[text()='{categoryName}']/../following-sibling::div[contains(@class, 'sub-categories')]//div//span");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public List<string> GetColumnDataByScrolling(string columnName)
        {
            var columnData = new List<string>();
            var columnNumber = GetColumnNumberByName(columnName);
            var iter = 0;
            var element = GetGridCell(iter, columnNumber);
            columnData.Add(element.Text);
            do
            {
                iter++;
                try
                {
                    Driver.MouseHoverByJavascript(element);
                    element = GetGridCell(iter, columnNumber);
                }
                catch (StaleElementReferenceException)
                {
                    Thread.Sleep(4000);
                    element = GetGridCell(iter, columnNumber);
                    Driver.MouseHoverByJavascript(element);
                }

                //Data loading
                if (element == null)
                {
                    Thread.Sleep(3000);
                    element = GetGridCell(iter, columnNumber);
                }

                try
                {
                    columnData.Add(element.Text);
                }
                catch (StaleElementReferenceException)
                {
                    Thread.Sleep(3000);
                    element = GetGridCell(iter, columnNumber);
                    columnData.Add(element.Text);
                }
                catch (NullReferenceException)
                {
                    break;
                }

                if (iter > 2002)
                    break;
            } while (element != null);

            return columnData;
        }

        public IWebElement GetColorByName(string colorName)
        {
            var selector = By.XPath(
                $".//span[@class='status-text'][text()='{colorName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetActionsButtonByName(string button)
        {
            var selector = By.XPath(
                $"//span[text()='{button}']/ancestor::button");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetButtonOnMessageBoxByNameOnActionPanel(string button)
        {
            var selector = By.XPath($"//div[contains(@class, 'notification')]//span[text()='{button}']/ancestor::button");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public int GetColumnNumberByName(string columnName)
        {
            var allHeadersSelector = By.XPath(".//div[@class='ag-header-container']/div/div");
            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(allHeadersSelector);
            var allHeaders = Driver.FindElements(allHeadersSelector);
            if (!allHeaders.Any())
                throw new Exception("Table does not contains any columns");
            var columnNumber =
                allHeaders.IndexOf(allHeaders.First(x =>
                    x.FindElement(By.XPath(".//span[@class='ag-header-cell-text']")).Text.Equals(columnName))) + 1;

            return columnNumber;
        }

        public List<string> GetColumnContent(string columnName)
        {
            var by = By.XPath(
                $".//div[contains(@class, 'ag-body-viewport')]//div[contains(@class, 'ag-body-container')]/div/div[{GetColumnNumberByName(columnName)}]");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }

        public string GetRowContentByColumnName(string columnName)
        {
            var by = By.XPath(
                $"//div[@role='gridcell'][{GetColumnNumberByName(columnName)}]");
            return Driver.FindElement(by).Text;
        }

        public IWebElement GetItalicContentByColumnName(string text)
        {
            var selector = By.XPath($"//span[@class='agEmptyValue'][text()='{text}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public string ActiveCustomListName()
        {
            var by = By.XPath(
                ".//div[@class='active-list-wrapper ng-star-inserted']/ul/li/span");
            Driver.WaitForElement(by);
            return Driver.FindElement(by).Text;
        }

        public void ClickContentByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[contains(@class, 'ag-body-container')]/div[1]/div[{GetColumnNumberByName(columnName)}]//a");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }


        /// <summary>
        /// Get just data from first row
        /// </summary>
        /// <param name="columnName">Column name in the grid</param>
        /// <returns></returns>
        public IWebElement GetContentByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[contains(@class, 'ag-body-container')]/div[1]/div[{GetColumnNumberByName(columnName)}]");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl);
        }

        public string CheckColumnContent(string columnContent)
        {
            var byControl =
                By.XPath($".//div[contains(@class, 'ag-body-container')]/div/div[@title='{columnContent}']");
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            return Driver.FindElement(byControl).Text;
        }

        public IWebElement GetHrefByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[contains(@class, 'ag-body-container')]/div[1]/div[{GetColumnNumberByName(columnName)}]/child-cell/div/a");

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).GetAttribute("href");
            return Driver.FindElement(byControl);
        }

        public IWebElement GetListElementByName(string listName)
        {
            var selector = By.XPath($".//div[@id='submenuBlock']//*[text()='{listName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void OpenColumnSettingsByName(string columnName)
        {
            var columnSettingsSelector =
                $".//div[@role='presentation']/span[text()='{columnName}']//ancestor::div[@class='ag-cell-label-container ag-header-cell-sorted-none']//span[@class='ag-icon ag-icon-menu']";
            Driver.WaitForDataLoading();
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        public IWebElement GetSettingButtonByName(string settingName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath($".//span[@id='eName'][text()='{settingName}']"));
            return Driver.FindElement(By.XPath($".//span[@id='eName'][text()='{settingName}']"));
        }

        public IWebElement GetSettingOptionByName(string optionName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath($".//ul[@class='menu-settings']//span[contains(text(), '{optionName}')]"));
            return Driver.FindElement(
                By.XPath($".//ul[@class='menu-settings']//span[contains(text(), '{optionName}')]"));
        }
        
        public IWebElement GetSettingIconByRowName(string rowName)
        {
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(
                $".//div[contains(@class, 'ag-body-container')]/div[@role='row']//a[text()='{rowName}']//ancestor::div[@role='row']//div[@col-id='settings']"));
            return Driver.FindElement(By.XPath(
                $".//div[contains(@class, 'ag-body-container')]/div[@role='row']//a[text()='{rowName}']//ancestor::div[@role='row']//div[@col-id='settings']"));
        }
        
public IWebElement GetOptionByName(string optionName)
        {
            var selector = By.XPath($".//mat-option[@role='option']//span[text()='{optionName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public string GetPinnedColumnName(string pinStatus)
        {
            switch (pinStatus)
            {
                case "Left":
                    return Driver.FindElement(By.XPath(".//div[@class='ag-pinned-left-header']//span[@ref='eText']"))
                        .Text;

                case "Right":
                    return Driver.FindElement(By.XPath(".//div[@class='ag-pinned-right-header']//span[@ref='eText']"))
                        .Text;

                default: throw new Exception($"{pinStatus} is not valid Pin Value");
            }
        }

        public string GetColorContainer(string styleColorItem)
        {
            switch (styleColorItem)
            {
                case "background-color: rgba(245, 96, 86, 0.5); border: 2px solid rgb(245, 96, 86);":
                    return "RED";
                case "background-color: rgba(47, 133, 184, 0.5); border: 2px solid rgb(47, 133, 184);":
                    return "BLUE";
                case "background-color: rgba(55, 61, 69, 0.5); border: 2px solid rgb(55, 61, 69);":
                    return "OUT OF SCOPE";
                case "background-color: rgba(71, 209, 209, 0.5); border: 2px solid rgb(71, 209, 209);":
                    return "LIGHT BLUE";
                case "background-color: rgba(153, 118, 84, 0.5); border: 2px solid rgb(153, 118, 84);":
                    return "BROWN";
                case "background-color: rgba(235, 175, 37, 0.5); border: 2px solid rgb(235, 175, 37);":
                    return "AMBER";
                case "background-color: rgba(226, 123, 54, 0.5); border: 2px solid rgb(226, 123, 54);":
                    return "REALLY EXTREMELY ORANGE";
                case "background-color: rgba(186, 94, 186, 0.5); border: 2px solid rgb(186, 94, 186);":
                    return "PURPLE";
                case "background-color: rgba(126, 189, 56, 0.5); border: 2px solid rgb(126, 189, 56);":
                    return "GREEN";
                case "background-color: rgba(128, 139, 153, 0.5); border: 2px solid rgb(128, 139, 153);":
                    return "GREY";
                default: throw new Exception($"{styleColorItem} is not valid Color");
            }
        }

        public string GetImageContainer(string styleImageItem)
        {
            switch (styleImageItem)
            {
                case "forwardPath.png":
                    return "FORWARD PATH";
                case "tick.png":
                    return "KEEP";
                case "cross.png":
                    return "RETIRE";
                case "unknown.png":
                    return "UNCATEGORISED";
                default: throw new Exception($"{styleImageItem} is not valid Image path");
            }
        }

        public IList<IWebElement> GetAllColumnHeaders()
        {
            var selector = By.XPath(".//span[@role='columnheader']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }

        public void ExpandColumnsSectionByName(string sectionsName)
        {
            if (Driver.IsElementExists(By.XPath(
                $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'add')]"))
            )
                try
                {
                    Driver.FindElement(By.XPath(
                            $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'add')]"))
                        .Click();
                }
                catch
                {
                    Driver.MouseHover(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'add')]"));
                    Driver.FindElement(By.XPath(
                            $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'add')]"))
                        .Click();
                }

            if (ColumnSubcategories.Any())
                Driver.MouseHover(ColumnSubcategories.Last());
        }

        public void CloseColumnsSectionByName(string sectionsName)
        {
            try
            {
                Driver.FindElement(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'clear')]"))
                    .Click();
            }
            catch
            {
                Driver.MouseHover(By.XPath(
                    $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'clear')]"));
                Driver.FindElement(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[contains(@class, 'clear')]"))
                    .Click();
            }
        }

        public IWebElement GetCreateButtonByName(string button)
        {
            var selector = By.XPath($"//span[text()='{button}']/ancestor::mat-option");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownWithSearchByFieldName(string name)
        {
            var selector = By.XPath($"//input[@aria-label='{name}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDropdownByFieldName(string name)
        {
            var selector = By.XPath($"//textarea[@placeholder='{name}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}