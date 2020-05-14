using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class FiltersElement : SeleniumBasePage
    {
        private const string SearchTextBoxSelector = ".//input[@name='search']";

        private const string ShowedResultsCount = ".//div[contains(@class,'pagination')]";

        public const string FilterValuesSelector = ".//span[contains(@class, 'filter-label-value')]";

        public const string FilterOptionsSelector = ".//span[@class='filter-label-op']";

        public const string FilterNameSelector = ".//span[@class='filter-label-name']";

        private const string GroupTitleSelector = ".//div[contains(@class,'filter-category-label blue-color')]";

        public const string FilterValue = "//span[@class='text-container ng-star-inserted']";

        [FindsBy(How = How.XPath, Using = ".//div[@class='filter-panel']")]
        public IWebElement FiltersPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='context-container']")]
        public IWebElement ContextPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'filter-add-group')]")]
        public IWebElement AddNewFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'filterAddPanel')]")]
        public IWebElement ExpandedFilterBlock { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'rowCount')]")]
        public IWebElement ResultsOnPageCount { get; set; }

        [FindsBy(How = How.XPath,Using = ".//button[contains(@class, 'addNewContainer')]//span[contains(text(), 'ADD AND')]")]
        public IWebElement AddAndFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = SearchTextBoxSelector)]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='context']//div[contains(@class,'searchPanel')]/button")]
        public IWebElement SearchTextBoxResetButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']")]
        public IWebElement LookupFilterSearchTextBox { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@id='context']//input[@id='chipInput']")]
        public IWebElement FilterSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='filter-panel']//i[contains(@class,'icon-search')]")]
        public IList<IWebElement> FilterSearchInputs { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//ul/li[@class='chips-item ng-star-inserted']")]
        public IWebElement FilterChipBox { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[contains(text(),'ASSOCIATION')]/../following-sibling::div//input")]
        public IWebElement AssociationSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-button-wrapper']/i[@class='material-icons mat-arrow_forward']")]
        public IWebElement AddFilterSearchTextBoxValueButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='dropdown-select input-wrapper']//button")]
        public IWebElement CloseAssociationSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'filter-category ng-star-inserted')]")]
        public IList<IWebElement> FilterCategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'filter-category-label blue-color')]")]
        public IList<IWebElement> FilterCategoryLabels { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[@class='btn-group-sm']//button//span//i[@class='material-icons mat-clear mat-18']")]
        public IList<IWebElement> MinimizeGroupButton { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[@class='btn-group-sm']//button//span//i[@class='material-icons mat-item_add mat-18']")]
        public IList<IWebElement> MaximizeGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-content']")]
        public IWebElement FilterContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='device-context-header']//button[@aria-label='filters']")]
        public IWebElement FilterExpressionIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'list-container')]/span")]
        public IList<IWebElement> Association { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='styleSelectDropdown']")]
        public IWebElement FilterTypeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-group actions']//span[text()='UPDATE']/ancestor::button")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-group actions']//button[contains(@class,'mat-primary')]")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[contains(@class, 'material-icons mat-filter-edit')]")]
        public IWebElement EditFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group actions']//span[text()='CANCEL']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='add-column-checkbox ng-star-inserted']//input")]
        public IWebElement AddCategoryColumnCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'addColumn')]//span[@class='mat-checkbox-label']")]
        public IList<IWebElement> AddCategoryColumnName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'addColumn')]//span[@class='mat-checkbox-label']")]
        public IWebElement AddFiltersColumnName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'filterAddPanel')]//i[contains(@class,'delete') or contains(@class,'clear')]/ancestor::button")]
        public IWebElement RemoveFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'reset')]")]
        public IWebElement ResetFiltersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul//mat-checkbox")]
        public IWebElement LookupFilterCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = FilterValuesSelector)]
        public IList<IWebElement> FilterValues { get; set; }

        [FindsBy(How = How.XPath, Using = FilterOptionsSelector)]
        public IList<IWebElement> FilterOperators { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'sub-categories-item')]")]
        public IList<IWebElement> FilterSubcategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@mat-container-class='my-container']")]
        public IWebElement OperatorDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/mat-option/span[@class='mat-option-text']")]
        public IList<IWebElement> OperatorOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'list-container')]")]
        public IList<IWebElement> FilterCheckboxOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'list-container')]//span/span/span")]
        public IList<IWebElement> FilterCheckboxOptionsLabels { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'filter-label')]")]
        public IList<IWebElement> AddedFilterLabels { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='filter-label']/ancestor::div[contains(@class, 'filter-error')]")]
        public IWebElement FilterInfoErrorBlock { get; set; }

        [FindsBy(How = How.XPath, Using = GroupTitleSelector)]
        public IList<IWebElement> GroupTitle { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='relativeSelect']")]
        public IWebElement AheadOrAgoInput { get; set; }
        
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ContextPanel)
            };
        }

        private IWebElement FilterCategory(string filterCategoryName)
        {
            return Driver.FindElement(By.XPath(
                $".//div[contains(@class,'filter-category-label blue-color bold-text')][text()=\"" + filterCategoryName + "\"]/ancestor::div[@class='filter-category ng-star-inserted']"));
        }

        public List<string> GetFilterValuesByFilterName(string filterName)
        {
            var filterValues = new List<string>();
            filterValues.AddRange(Driver.FindElements(By.XPath(
                    $".//span[@class='filter-label-name'][text()='{filterName}']/ancestor::div[contains(@class,'filter-label')]//span[contains(@class, 'filter-label-value')]"))
                .Select(x => x.Text.TrimStart(' ').TrimEnd(' ')).ToList());
            return filterValues;
        }

        public void GetAssociationCheckbox(string checkboxName)
        {
            var checkboxSettingsSelector = $".//li[@class='ng-star-inserted']//span[contains(text(), '{checkboxName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(checkboxSettingsSelector));
            Driver.FindElement(By.XPath(checkboxSettingsSelector)).Click();
        }

        public void GetCheckboxForAssociationLookupFilter(string checkboxName)
        {
            var checkboxSettingsSelector = $".//li[@class='ng-star-inserted']//span[text()='{checkboxName}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(checkboxSettingsSelector));
            Driver.FindElement(By.XPath(checkboxSettingsSelector)).Click();
        }

        public void AddFilter(string filterName, string categoryName = null)
        {
            if (Driver.IsElementExists(AddNewFilterButton))
            {
                Driver.MoveToElement(AddNewFilterButton);
                Driver.MouseHover(AddNewFilterButton);
                AddNewFilterButton.Click();
            }

            //TODO: 16Aug2019 Yurii T. don't know why we jump to the bottom and then to the top; it makes tests on CI fail
            //if (FilterCategories.Any())
            //Driver.MouseHover(FilterCategories.Last());
            Driver.MouseHover(By.XPath(SearchTextBoxSelector));
            Driver.WaitForElementToBeEnabled(By.XPath(SearchTextBoxSelector));
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

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            if (categoryName != null)
            {
                var category = Driver.FindElement(By.XPath(
                    $".//div[contains(text(), '{categoryName}')]//ancestor::div[@class='filter-category ng-star-inserted']"));
                category.FindElement(By.XPath(selector)).Click();
            }
            else
            {
                Driver.ExecuteAction(() => Driver.FindElement(By.XPath(selector)).Click());
            }

            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeNotDisplayed(AddNewFilterButton);
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
            Driver.WaitForElementToBeEnabled(By.XPath(SearchTextBoxSelector));
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

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();

            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeNotDisplayed(AddNewFilterButton);
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
            //TODO: 28aug2019 Yurii: removed logic that jumps to the end of the list
            //if (FilterCategories.Any())
            //Driver.MouseHover(FilterCategories.Last());
            Driver.MoveToElement(SearchTextBox);
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

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();

            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeNotDisplayed(AddAndFilterButton);
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
            var selectedFilterType = $".//mat-option//span[text()='{filterType}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selectedFilterType));
            Driver.FindElement(By.XPath(selectedFilterType)).Click();
        }

        public bool CategoryIsDisplayed(string sectionsName)
        {
            return Driver.IsElementDisplayed(
                By.XPath(
                    $".//div[@class='filter-category-label blue-color bold-text'][contains(text(),'{sectionsName}')]"));
        }

        public List<string> GetFiltersNames()
        {
            Driver.WhatForElementToBeExists(By.XPath(".//span[@class='filter-label-name']"));
            var namesListElements = Driver.FindElements(By.XPath(".//span[@class='filter-label-name']"));
            return namesListElements.Select(name => name.Text).ToList();
        }

        public bool CheckThatFilterIsRemoved(string filterName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[@class='filter-label-name'][text()='{filterName}]"));
        }

        public List<string> GetFiltersNamesFromFilterPanel(string filterName)
        {
            return Driver.FindElements(By.XPath($".//div[contains(@class,'filter-label')]//span[@class='filter-label-name']"))
                .Select(x => x.Text).ToList();
        }

        public IWebElement CloseFiltersLookupValue(string filterValue)
        {
            var lookupValuerButton = $".//button[contains(@aria-describedby, '{filterValue}')]";
            return Driver.FindElement(By.XPath(lookupValuerButton));
        }

        public IWebElement GetEditFilterButton(string filterName)
        {
            var editFilterSelector =
                $".//span[@class='filter-label-name'][text()='{filterName}']//ancestor::div[contains(@class,'filter-group') and not(contains(@class, 'relationContainer'))]//button";
            return Driver.FindElements(By.XPath(editFilterSelector)).Last();
        }

        public IWebElement GetFilterValue(string value)
        {
            var editFilterSelector = $".//li//span[text()='{value}']";
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
        public IList<IWebElement> GetCheckboxLabelsOfFilterOptions()
        {
            var checkboxSelector = $".//div[contains(@class, 'filterAddPanel')]//ul[contains(@class, 'dropdown-select-result')]//li";
            return Driver.FindElements(By.XPath(checkboxSelector));
        }
        public IWebElement GetFilterCheckboxByName(string checkboxName)
        {
            var checkboxSelector = $".//div[contains(@class, 'filterAddPanel')]//span[contains(text(), '{checkboxName}')]";
            return Driver.FindElement(By.XPath(checkboxSelector));
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
            Driver.WaitForElementToBeDisplayed(
                By.XPath(".//div[@class='filter-panel']//div[@class='mat-select-trigger']"));
            var selectBox =
                Driver.FindElement(By.XPath(".//div[@class='filter-panel']//div[@class='mat-select-trigger']"));
            Driver.SelectCustomSelectbox(selectBox, operatorValue);
        }

        public List<string> SelectOperatorOptions()
        {
            Driver.WaitForElementToBeDisplayed(
                By.XPath(".//div[@class='filter-panel']//div[@class='mat-select-trigger']"));
            var selectBox =
                Driver.FindElement(By.XPath(".//div[@class='filter-panel']//div[@class='mat-select-trigger']"));

            return Driver.GetOptionsFromMatSelectbox(selectBox).Select(iw => iw.Text).ToList();
        }

        public List<IWebElement> GetAddedFilters()
        {
            var by = By.XPath(".//div[@class='filter-item ng-star-inserted']");
            Driver.WaitForElementToBeDisplayed(by);
            return Driver.FindElements(by).ToList();
        }

        public string GetExpandedSection()
        {
            var selector =
                By.XPath(
                    $".//div[contains(@class, 'sub-categories') and not(contains(@class,'item'))]/../div/div[contains(@class,'bold-text')]");
            Driver.WaitForElementToBeDisplayed(selector);
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
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetFilterCategory(string filterName, string category)
        {
            var selector =
                By.XPath(
                    $".//div[contains(@class,'filter-category-title')]//div[text()='{filterName}']/parent::div//div//strong[text()='{category}']");
            Driver.MouseHover(selector);
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void SelectSavedListByName(string listName)
        {
            var checkbox = Driver.FindElement(By.XPath($".//div//span[text()='{listName}']"));
            if (!checkbox.Displayed)
            {
                FilterSearchInputs.FirstOrDefault().Click();
            }
            checkbox.Click();
        }

        public IWebElement GetValueForLookupFilter(string name)
        {
            var selector = By.XPath($".//span[text()='{name}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool IsLookupFilterHasOptionsExpanded()
        {
            var selector = By.XPath($".//input[@placeholder='Search']/preceding::div[@class='dropdown-select input-wrapper']//ul//mat-checkbox");
            return Driver.IsElementDisplayed(selector);
        }
       
        public IWebElement GetCloseChipButtonByName(string chipName)
        {
            var selector = By.XPath($".//li//span[text()='{chipName}']/ancestor::li/button");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetColorForReadinessFilterValue(string value)
        {
            var selector =
                By.XPath(
                    $"//ul[@class='chips chips-have-expand-button']//span[contains(@class, 'text-container')]//span[text()='{value}']/../div");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool IsComplianceOptionHasRingIcon(string color)
        {
            var selector = By.XPath($"//ul[contains(@class, 'dropdown-select-results-list')]/li//span[@class='mat-checkbox-label']//span[text()='{color}']/preceding-sibling::div[contains(@class, 'status')]");
            return Driver.FindElements(selector).Count == 1;
        }

        public int GetSubcategoriesCountByCategoryName(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            Driver.MouseHover(filterCategory);
            return Convert.ToInt32(filterCategory.FindElement(By.XPath(".//strong")).Text);
        }

        public void SelectAssociation(string placeholder, string option)
        {
            GetAssociationDropdownItemsByPlaceholder(placeholder).First(x=>x.Text.Equals(option)).Click();
        }

        public IList<IWebElement> GetAssociationDropdownItemsByPlaceholder(string placeholder)
        {
            var optionSelector =
                $".//input[@placeholder='{placeholder}']/ancestor::div[contains(@class, 'searchPanel input-wrapper')]/following-sibling::div[@class='sub-categories-associations']//div[contains(@class, 'sub-categories-item')]";

            return Driver.FindElementsByXPath(optionSelector);
        }

        public IWebElement RemoveIconForAssociation(string association) => Driver.FindElementByXPath($".//span[@class='filter-label-name' and text()=' {association.ToLower()}']/ancestor::div[@class='filter-group no-border-bottom']//i[contains(@class, 'mat-item_delete')]/ancestor::button");

        public List<string> GetCategoriesFromFilterPanelPageByPage()
        {
            List<string> categories = new List<string>();

            var allCats = FilterCategoryLabels.Count;
            var visibleCats = FilterCategoryLabels.Count(x => x.Displayed);
            int attempts = allCats / visibleCats + 1;

            for (int i = 0; i < attempts; i++)
            {
                IList<IWebElement> cats = FilterCategoryLabels.Where(z => !string.IsNullOrEmpty(z.Text)).ToList();

                if (categories.Count > 0 && cats.Last().Text.Equals(categories.Last()))
                {
                    break;
                }

                categories.AddRange(cats.Select(x => x.Text));
                Driver.MouseHoverByJavascript(cats.Last());
            }
            //remove duplicates which are possible when paging
            return categories.Distinct().ToList();
        }
    }
}