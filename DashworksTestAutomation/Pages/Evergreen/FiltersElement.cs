﻿using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using HtmlAgilityPack;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class FiltersElement : SeleniumBasePage
    {
        private const string SearchTextBoxSelector = ".//input[@name='search']";

        private const string ShowedResultsCount = ".//div[@class='pagination-info ng-star-inserted']";

        public const string FilterValuesSelector = ".//span[contains(@class, 'filter-label-value')]";

        public const string FilterOptionsSelector = ".//span[@class='filter-label-op']";

        public const string FilterNameSelector = ".//span[@class='filter-label-name']";

        private const string GroupTitleSelector = ".//div[contains(@class,'filter-category-label blue-color')]";

        public const string FilterValue = "//span[@class='text-container ng-star-inserted']";

        [FindsBy(How = How.XPath, Using = ".//div[@class='filter-panel']")]
        public IWebElement FiltersPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='mat-input-2']")]
        public IWebElement FilterSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-label-name']")]
        public IWebElement FilterNameInTheFilterPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'filter-add-group')]")]
        public IWebElement AddNewFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'rowCount')]")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//button[contains(@class, 'filter-select addNewContainer ng-star-inserted')]")]
        public IWebElement AddAndFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = SearchTextBoxSelector)]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//button[@class='btn btn-default input-toggle mat-icon-button _mat-animation-noopable ng-star-inserted']")]
        public IWebElement SearchTextBoxResetButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']")]
        public IWebElement LookupFilterSearchTextBox { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@id='context']//input[@id='chipInput']")]
        public IWebElement FilterSearchTextBox { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[contains(text(),'ASSOCIATION')]/../following-sibling::div//input")]
        public IWebElement AssociationSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='dropdown-select input-wrapper']//button")]
        public IWebElement CloseAssociationSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'filter-category ng-star-inserted')]")]
        public IList<IWebElement> FilterCategories { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[@class='btn-group-sm']//button//span//i[@class='material-icons mat-clear mat-18']")]
        public IList<IWebElement> MinimizeGroupButton { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[@class='btn-group-sm']//button//span//i[@class='material-icons mat-item_add mat-18']")]
        public IList<IWebElement> MaximizeGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'list-container')]/span")]
        public IList<IWebElement> Association { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='styleSelectDropdown']")]
        public IWebElement FilterTypeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='None']")]
        public IWebElement NoneCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='A Star Packages']")]
        public IWebElement AStarPackagesCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='B Star Packages']")]
        public IWebElement BStarPackagesCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-group actions']//span[text()='SAVE']/ancestor::button")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class='material-icons mat-filter-edit mat-18']")]
        public IWebElement EditFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group actions']//span[text()='CANCEL']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='add-column-checkbox ng-star-inserted']//input")]
        public IWebElement AddCategoryColumnCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'addColumn')]//span[@class='mat-checkbox-label']")]
        public IList<IWebElement> AddCategoryColumnName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'addColumn')]//span[@class='mat-checkbox-label']")]
        public IWebElement AddFiltersColumnName { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//div[@class='filterAddPanel ng-star-inserted']//i[@class='material-icons mat-item_delete']/ancestor::button")]
        public IWebElement RemoveFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='RESET']/ancestor::button")]
        public IWebElement ResetFiltersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul//mat-checkbox")]
        public IWebElement LookupFilterCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = FilterValuesSelector)]
        public IList<IWebElement> FilterValues { get; set; }

        [FindsBy(How = How.XPath, Using = FilterOptionsSelector)]
        public IList<IWebElement> FilterOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'sub-categories-item')]")]
        public IList<IWebElement> FilterSubcategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@mat-container-class='my-container']")]
        public IWebElement OperatorDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'mat-select-content')]/mat-option")]
        public IList<IWebElement> OperatorOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'list-container')]")]
        public IList<IWebElement> FilterCheckboxOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'list-container')]//span/span/span")]
        public IList<IWebElement> FilterCheckboxOptionsLabels { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='filter-label']")]
        public IList<IWebElement> AddedFilterLabels { get; set; }

        [FindsBy(How = How.XPath, Using = GroupTitleSelector)]
        public IList<IWebElement> GroupTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'list-container')]")]
        public IWebElement AssociationCheckbox1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'list-container')]")]
        public IList<IWebElement> AssociationCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Date']")]
        public IWebElement InputDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='content']//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoResultsFoundMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='User Description']")]
        public IWebElement UserDescriptionField { get; set; }

        [FindsBy(How = How.XPath, Using = FilterValue)]
        public IList<IWebElement> FilterValueList { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.FiltersPanel)
            };
        }

        public List<string> GetFilterValuesByFilterName(string filterName)
        {
            var filterValues = new List<string>();
            filterValues.AddRange(Driver.FindElements(By.XPath(
                    $".//span[@class='filter-label-name'][text()='{filterName}']/ancestor::div[@class='filter-label']//span[contains(@class, 'filter-label-value')]"))
                .Select(x => x.Text.TrimStart(' ').TrimEnd(' ')).ToList());
            return filterValues;
        }

        public void GetAssociationCheckbox(string checkboxName)
        {
            var checkboxSettingsSelector = $".//li[@class='ng-star-inserted']//span[contains(text(), '{checkboxName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(checkboxSettingsSelector));
            Driver.FindElement(By.XPath(checkboxSettingsSelector)).Click();
        }

        public void GetCheckboxForAssociationLookupFilter(string checkboxName)
        {
            var checkboxSettingsSelector = $".//li[@class='ng-star-inserted']//span[text()='{checkboxName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(checkboxSettingsSelector));
            Driver.FindElement(By.XPath(checkboxSettingsSelector)).Click();
        }

        public void AddFilter(string filterName, string categoryName = null)
        {
            if (Driver.IsElementExists(AddNewFilterButton))
            {
                Driver.MouseHover(AddNewFilterButton);
                AddNewFilterButton.Click();
            }

            if (FilterCategories.Any())
                Driver.MouseHover(FilterCategories.Last());
            Driver.MouseHover(By.XPath(SearchTextBoxSelector));
            Driver.WaitWhileControlIsNotClickable(By.XPath(SearchTextBoxSelector));
            Driver.FindElement(By.XPath(SearchTextBoxSelector)).Click();
            Driver.FindElement(By.XPath(SearchTextBoxSelector)).SendKeys(filterName);
            string selector;
            if (filterName.Contains("'"))
            {
                var strings = filterName.Split('\'');
                selector =
                    $".//div[contains(@class, 'filter-add')][contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[contains(@class, 'filter-add')][text()='{filterName}']";
            }

            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            if (categoryName != null)
            {
                var category = Driver.FindElement(By.XPath(
                    $".//div[contains(text(), '{categoryName}')]//ancestor::div[@class='filter-category ng-star-inserted']"));
                category.FindElement(By.XPath(selector)).Click();
            }
            else
            {
                Driver.FindElement(By.XPath(selector)).Click();
            }

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsDisplayed<FiltersElement>(() => AddNewFilterButton);
        }

        public void AddFilterForCategory(string filterName, string categoryName)
        {
            if (Driver.IsElementExists(AddNewFilterButton))
            {
                Driver.MouseHover(AddNewFilterButton);
                AddNewFilterButton.Click();
            }

            if (FilterCategories.Any())
                Driver.MouseHover(FilterCategories.Last());
            Driver.MouseHover(By.XPath(SearchTextBoxSelector));
            Driver.WaitWhileControlIsNotClickable(By.XPath(SearchTextBoxSelector));
            Driver.FindElement(By.XPath(SearchTextBoxSelector)).Click();
            Driver.FindElement(By.XPath(SearchTextBoxSelector)).SendKeys(filterName);
            string selector;
            if (filterName.Contains("'"))
            {
                var strings = filterName.Split('\'');
                selector =
                    $".//div[contains(@class, 'filter-add')][contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[contains(@class, 'filter-add')][text()='{filterName}']";
            }


            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsDisplayed<FiltersElement>(() => AddNewFilterButton);
        }

        public string GetShowedResultsCount()
        {
            LookupFilterSearchTextBox.Click();
            return Driver.FindElement(By.XPath(ShowedResultsCount)).Text;
        }

        public void AddAndFilter(string filterName)
        {
            if (Driver.IsElementExists(AddAndFilterButton))
            {
                Driver.MouseHover(AddAndFilterButton);
                AddAndFilterButton.Click();
            }

            if (FilterCategories.Any())
                Driver.MouseHover(FilterCategories.Last());
            Driver.MouseHover(SearchTextBox);
            SearchTextBox.SendKeys(filterName);
            string selector;
            if (filterName.Contains("'"))
            {
                var strings = filterName.Split('\'');
                selector =
                    $".//div[contains(@class, 'filter-add')][contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[contains(@class, 'filter-add')][text()='{filterName}']";
            }

            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsDisplayed<FiltersElement>(() => AddAndFilterButton);
        }

        public bool CheckFilterAvailability(string filterName)
        {
            if (AddNewFilterButton.Displayed())
                AddNewFilterButton.Click();

            SearchTextBox.Clear();
            SearchTextBox.SendKeys(filterName);
            Driver.WaitForDataLoading();
            var selector = By.XPath($".//div[contains(@class, 'filter-add')][text()='{filterName}']");
            Driver.WaitForDataLoading();
            return Driver.IsElementDisplayed(selector);
        }

        public bool FilterNameInThePanel(string filterName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='name-container']/div/span[text()='{filterName}']"));
        }

        public void SelectFilterType(string filterType)
        {
            var selectedFilterType = $".//div[@style='opacity: 1;']//span[text()='{filterType}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selectedFilterType));
            Driver.FindElement(By.XPath(selectedFilterType)).Click();
        }

        public bool CategoryIsDisplayed(string sectionsName)
        {
            return Driver.IsElementDisplayed(
                By.XPath(
                    $".//div[@class='filter-category-label blue-color bold-text'][contains(text(),'{sectionsName}"));
        }

        public List<string> GetFiltersNames()
        {
            Driver.WaitWhileControlIsNotExists(By.XPath(".//span[@class='filter-label-name']"));
            var namesListElements = Driver.FindElements(By.XPath(".//span[@class='filter-label-name']"));
            return namesListElements.Select(name => name.Text).ToList();
        }

        public bool CheckThatFilterIsRemoved(string filterName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[@class='filter-label-name'][text()='{filterName}]"));
        }

        public bool GetFiltersNamesFromFilterPanel(string filterName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[@class='filter-label']//span[text()='{filterName}']"));
        }

        public IWebElement CloseFiltersLookupValue(string filterValue)
        {
            var lookupValuerButton = $".//button[contains(@aria-describedby, '{filterValue}')]";
            return Driver.FindElement(By.XPath(lookupValuerButton));
        }

        public IWebElement GetEditFilterButton(string filterName)
        {
            var editFilterSelector =
                $".//span[@class='filter-label-name'][text()='{filterName}']//ancestor::div[@class='filter-group no-border-bottom ng-star-inserted']//button";
            return Driver.FindElement(By.XPath(editFilterSelector));
        }

        public IWebElement GetFilterValue(string value)
        {
            var editFilterSelector =
                $".//li//span[text()='{value}']";
            return Driver.FindElement(By.XPath(editFilterSelector));
        }

        public bool ListNameForSavedListFilter(string filterName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[@class='list-container']//span[text()='{filterName}']"));
        }

        public bool CheckboxNameForFilter(string checkboxName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[contains(text(), '{checkboxName}')]"));
        }

        public IWebElement GetBooleanCheckboxImg(string booleanValue)
        {
            var imgSelector =
                $".//li//span[text()='{booleanValue}']/ancestor::span[@class='boolean-icon text-container ng-star-inserted']/img";
            return Driver.FindElement(By.XPath(imgSelector));
        }

        public IList<IWebElement> GetAssociationsList()
        {
            AssociationSearchTextBox.Click();
            return Driver.FindElements(By.XPath(
                ".//div[@id='context']//input[@placeholder='Search']//ancestor::div[@class='associationmultiselect-parent btn-group dropdown-associationmultiselect']//li//span"));
        }

        public IList<IWebElement> GetSelectBoxes()
        {
            return Driver.FindElements(By.XPath(".//span[@class='text-container ng-star-inserted']"));
        }

        public void SelectOperator(string operatorValue)
        {
            Driver.WaitWhileControlIsNotDisplayed(
                By.XPath(".//div[@class='filter-panel']//div[@class='mat-select-trigger']"));
            var selectBox =
                Driver.FindElement(By.XPath(".//div[@class='filter-panel']//div[@class='mat-select-trigger']"));
            Driver.SelectCustomSelectbox(selectBox, operatorValue);
        }

        public void EditFilterButtonToolTip(string tooltipText)
        {
            var editFilterButton = Driver.FindElement(By.XPath(
                    ".//div[@class='btn-group-sm pull-right ng-star-inserted']//i[@class='material-icons mat-filter-edit mat-18']/ancestor::button"))
                .GetAttribute("aria-describedby");
            var pageSource = Driver.PageSource;
            var doc = new HtmlDocument();
            doc.LoadHtml(pageSource);
            var node = doc.DocumentNode.SelectNodes($".//div[@id='{editFilterButton}']")[0];
            var editFilterButtonTooltip = node.InnerHtml;
            Assert.AreEqual(tooltipText, editFilterButtonTooltip, "Tooltip is incorrect for button");
        }

        public List<IWebElement> GetAddedFilters()
        {
            var by = By.XPath(".//div[@class='filter-item ng-star-inserted']");
            Driver.WaitWhileControlIsNotDisplayed(by);
            return Driver.FindElements(by).ToList();
        }

        public string GetExpandedSection()
        {
            var selector =
                By.XPath(
                    $".//div[contains(@class, 'sub-categories') and not(contains(@class,'item'))]/../div/div[contains(@class,'bold-text')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector).Text;
        }

        public string GetFilterFontWeight()
        {
            return Driver.FindElement(By.XPath(".//span[contains(@class, 'filter-label-value')]"))
                .GetCssValue("font-weight");
        }

        public string GetFilterFontColor()
        {
            return Driver.FindElement(By.XPath(".//span[@class='filter-label-name']")).GetCssValue("color");
        }

        public void CloseFilterSectionByName(string sectionsName)
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

        public void ExpandFilterSectionByName(string sectionsName)
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

            if (FilterSubcategories.Any())
                Driver.MouseHover(FilterSubcategories.Last());
        }

        public IWebElement GetOpenedFilter(string filterName)
        {
            var selector = By.XPath($"//div[contains(@class, 'filterAddPanel')]/..//span[text()='{filterName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetFilterCategory(string filterName, string category)
        {
            var selector =
                By.XPath(
                    $".//div[contains(@class,'filter-category-title')]//div[text()='{filterName}']/parent::div//div//strong[text()='{category}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void SelectSavedListByName(string listName)
        {
            var checkboxSelector = $".//div//span[text()='{listName}']";
            Driver.FindElement(By.XPath(checkboxSelector)).Click();
        }

        public IWebElement GetValueForLookupFilter(string name)
        {
            var selector = By.XPath($"//span[text()='{name}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetColorForReadinessFilterValue(string value)
        {
            var selector =
                By.XPath(
                    $"//ul[@class='chips chips-have-expand-button']//span[contains(@class, 'text-container')]//span[text()='{value}']/../div");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}