using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Helpers
{
    public class BaseFilter
    {
        public BaseFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox)
        {
            _driver = driver;
            _operatorValue = operatorValue;
            _acceptCheckbox = acceptCheckbox;
        }

        public BaseFilter(RemoteWebDriver driver, Table table)
        {
            _driver = driver;
            _table = table;
        }

        protected RemoteWebDriver _driver { get; set; }
        protected string _operatorValue { get; set; }
        protected bool _acceptCheckbox { get; set; }
        protected Table _table { get; set; }

        public void SelectOperator()
        {
            _driver.WaitWhileControlIsNotDisplayed(
                By.XPath(".//div[@class='filter-panel']//div[@class='mat-select-trigger']"));
            var selectbox =
                _driver.FindElement(By.XPath(".//div[@class='filter-panel']//div[@class='mat-select-trigger']"));
            _driver.SelectCustomSelectbox(selectbox, _operatorValue);
        }

        public virtual void Do()
        {
        }

        public virtual void CheckFilterDate(string filtersName)
        {
        }

        public void SaveFilter()
        {
            if (_acceptCheckbox)
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel ng-star-inserted']//div[contains(@class, 'add-column-checkbox')]//div[@class='mat-checkbox-inner-container']"))
                    .Click();
            _driver.MouseHover(By.XPath("//div[@class='form-container']//span[text()='SAVE']/ancestor::button"));
            _driver.FindElement(By.XPath("//div[@class='form-container']//span[text()='SAVE']/ancestor::button")).Click();
        }
    }

    public class DateFilter : BaseFilter
    {
        public DateFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, string dateValue) : base(
            driver, operatorValue, acceptCheckbox)
        {
            _dateValue = dateValue;
        }

        private string _dateValue { get; }

        public override void Do()
        {
            SelectOperator();
            if (_driver.IsElementDisplayed(By.XPath(".//input[@aria-label='Date']")))
                _driver.FindElement(By.XPath(".//input[@aria-label='Date']")).SendKeys(_dateValue);

            SaveFilter();
        }
    }

    public class LookupFilter : BaseFilter
    {
        public LookupFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, string value) : base(
            driver, operatorValue, acceptCheckbox)
        {
            _value = value;
        }

        private string _value { get; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            _driver.FindElement(
                    By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']"))
                .SendKeys(_value);
            _driver.FindElement(
                    By.XPath($".//div[@class='filterAddPanel ng-star-inserted']//span[contains(text(),'{_value}')]"))
                .Click();
            SaveFilter();
        }
    }

    public class TreeList : BaseFilter
    {
        public TreeList(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, string value) : base(
            driver, operatorValue, acceptCheckbox)
        {
            _value = value;
        }

        private string _value { get; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            _driver.FindElement(
                    By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']"))
                .SendKeys(_value);
            _driver.FindElement(By.XPath(".//ul[@class='tree-list ng-star-inserted']//mat-checkbox"))
                .Click();
            SaveFilter();
        }
    }

    public class LookupFilterTable : BaseFilter
    {
        public LookupFilterTable(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table table) : base(
            driver, operatorValue, acceptCheckbox)
        {
            Table = table;
        }

        protected Table Table { get; set; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(
                        By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']"))
                    .Click();
                _driver.FindElement(
                        By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']"))
                    .SendKeys(row["SelectedValues"]);
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']"))
                    .Clear();
                _driver.FindElement(By.XPath(
                        $".//div[@class='filterAddPanel ng-star-inserted']//span[contains(text(),'{row["SelectedValues"]}')]"))
                    .Click();
            }

            SaveFilter();
        }
    }

    public class CheckBoxesFilter : BaseFilter
    {
        protected string CheckboxSelector =
            ".//div[@class='filterAddPanel ng-star-inserted']//span[text()='{0}']/ancestor::mat-checkbox";

        protected string CheckboxSelectorName =
            ".//div[@class='filterAddPanel ng-star-inserted']//span[text()='{0}']";

        public CheckBoxesFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table optionsTable) :
            base(driver, operatorValue, acceptCheckbox)
        {
            _optionsTable = optionsTable;
        }

        protected Table _optionsTable { get; set; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in _optionsTable.Rows)
                _driver.FindElement(
                    By.XPath(string.Format(CheckboxSelectorName, row["SelectedCheckboxes"]))).Click();

            SaveFilter();
        }

        public override void CheckFilterDate(string filtersName)
        {
            var basePage = _driver.NowAt<BaseDashboardPage>();
            var columnContent = basePage.GetColumnContent(filtersName);
            var allValuesAreEmpty = columnContent.All(string.IsNullOrEmpty);
            if (allValuesAreEmpty)
                throw new Exception($"Column '{filtersName}' does not contain any date.");

            foreach (string value in columnContent)
            {
                if (string.IsNullOrEmpty(value))
                    continue;

                switch (_operatorValue)
                {
                    case "Does not equal":
                        Assert.True(_optionsTable.Rows.Select(x => x["SelectedCheckboxes"]).All(x => !value.Equals(x)));
                        break;

                    case "Equals":
                        Assert.True(_optionsTable.Rows.Select(x => x["SelectedCheckboxes"]).All(x => value.Equals(x)));
                        break;

                    default:
                        throw new Exception($"Unknown '{_operatorValue}' operator");
                }
            }
        }
    }

    public class ChangeCheckboxesFilter : CheckBoxesFilter
    {
        public ChangeCheckboxesFilter(RemoteWebDriver driver, Table table) :
            base(driver, "", false, table)
        {
            Table = table;
        }

        private Table Table { get; }

        public override void Do()
        {
            foreach (var row in Table.Rows)
            {
                var selector = string.Format(CheckboxSelector, row["Option"]);
                _driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
                var checkbox = _driver.FindElement(By.XPath(selector));
                if (bool.Parse(row["State"]) != checkbox.GetFilterCheckboxSelectedState()) checkbox.Click();
            }

            SaveFilter();
        }
    }

    public class ValueFilter : BaseFilter
    {
        public ValueFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table optionsTable) :
            base(driver, operatorValue, acceptCheckbox)
        {
            _optionsTable = optionsTable;
        }

        private Table _optionsTable { get; }

        public override void Do()
        {
            var addedOptionSelector =
                ".//span[@class='chips-item-text ng-star-inserted']";
            var allAddedOptionsSelector =
                ".//div[@class='filterAddPanel ng-star-inserted']/div[@class='form-container']//div[@class='form-group ng-star-inserted']//li/span";
            var filterValueSelector = By.XPath(
                ".//div[@class='filterAddPanel ng-star-inserted']//div[@class='mat-form-field-infix']//input");
            var addButtonSelector =
                By.XPath(
                    ".//div[contains(@class,'filterAddPanel')]//button[contains(@class,'button-small')]");

            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in _optionsTable.Rows)
            {
                if (!_driver.IsElementDisplayed(filterValueSelector)) continue;
                _driver.FindElement(filterValueSelector).SendkeysWithDelay(row["Values"]);
                _driver.WaitForDataLoading();
                if (_optionsTable.RowCount > 1)
                {
                    _driver.FindElement(addButtonSelector).Click();
                    //Show all added values
                    if (_driver.IsElementDisplayed(By.XPath(string.Format(addedOptionSelector, "more"))))
                        _driver.FindElement(By.XPath(string.Format(addedOptionSelector, "more"))).Click();
                    var addedOptions = _driver.FindElements(By.XPath(allAddedOptionsSelector))
                        .Select(value => value.Text).ToList();
                    _driver.WaitForDataLoading();
                    Assert.Contains(row["Values"], addedOptions);
                }
            }
            SaveFilter();
        }
    }

    public class ListFilter : BaseFilter
    {
        public ListFilter(RemoteWebDriver driver, string operatorValue, Table table) :
            base(driver, operatorValue, false)
        {
            Table = table;
        }

        private Table Table { get; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            var selectboxes = _driver.FindElements(By.XPath(".//div[@id='context']//input[@placeholder='Search']"));
            selectboxes.First().Click();
            foreach (var row in Table.Rows)
                _driver.FindElement(By.XPath(
                    $".//div[@id='perfectScrolBar']//span[text()='{row["SelectedList"]}']")).Click();

            selectboxes.Last().Click();
            foreach (var row in Table.Rows)
            {
                var selector = string.Empty;
                if (row["Association"].Contains("'"))
                {
                    var strings = row["Association"].Split('\'');
                    selector =
                        $".//li//span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
                }
                else
                {
                    selector = $".//li//span[text()='{row["Association"]}']";
                }
                selectboxes.Last().SendkeysWithDelay(row["Association"]);
                _driver.FindElement(By.XPath(selector)).Click();
                selectboxes.Last().Clear();
            }

            SaveFilter();
        }
    }

    public class LookupValueAssociationFilter : BaseFilter
    {
        public LookupValueAssociationFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(
            driver, operatorValue, false)
        {
            Table = table;
        }

        private Table Table { get; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Click();
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']"))
                    .SendKeys(row["SelectedValues"]);
                _driver.FindElement(By.XPath(
                        $".//div[@class='filterAddPanel ng-star-inserted']//span[contains(text(),'{row["SelectedValues"]}')]"))
                    .Click();
            }

            foreach (var row in Table.Rows)
            {
                _driver.FindElement(
                    By.XPath(".//div[@class='dropdown-select input-wrapper']//input[@id='mat-input-2']")).Click();
                _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
            }

            SaveFilter();
        }
    }

    public class LookupValueAdvancedFilter : BaseFilter
    {
        public LookupValueAdvancedFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(
            driver, operatorValue, false)
        {
            Table = table;
        }

        private Table Table { get; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            var selectboxes = _driver.FindElements(By.XPath(".//div[@id='context']//input[@placeholder='Search']"));
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Click();
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']"))
                    .SendKeys(row["SelectedValues"]);
                _driver.FindElement(By.XPath(
                        $".//div[@class='filterAddPanel ng-star-inserted']//span[contains(text(),'{row["SelectedValues"]}')]"))
                    .Click();
            }

            selectboxes.Last().Click();
            foreach (var row in Table.Rows)
            {
                var selector = string.Empty;
                if (row["Association"].Contains("'"))
                {
                    var strings = row["Association"].Split('\'');
                    selector =
                        $".//li//span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
                }
                else
                {
                    selector = $".//li//span[text()='{row["Association"]}']";
                }
                selectboxes.Last().SendkeysWithDelay(row["Association"]);
                _driver.FindElement(By.XPath(selector)).Click();
                selectboxes.Last().Clear();
            }
            SaveFilter();
        }
    }

    public class CheckboxesAssociationFilter : BaseFilter
    {
        protected string CheckboxSelector =
            ".//div[@class='filterAddPanel ng-star-inserted']//span[contains(text(), '{0} ']/../preceding-sibling::i";

        protected string CheckboxSelectorName =
            ".//div[@class='filterAddPanel ng-star-inserted']//span[contains(text(), '{0}')]";

        public CheckboxesAssociationFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table optionsTable) :
            base(driver, operatorValue, acceptCheckbox)
        {
            table = optionsTable;
        }

        protected Table table { get; set; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
                _driver.FindElement(
                    By.XPath(string.Format(CheckboxSelectorName, row["SelectedCheckboxes"]))).Click();
            SelectOperator();
            _driver.WaitForDataLoading();
            var selectboxes = _driver.FindElements(By.XPath(".//div[@id='context']//input[@placeholder='Search']"));
            selectboxes.First().Click();

            selectboxes.Last().Click();
            foreach (var row in table.Rows)
            {
                _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
            }
        }
    }

    public class ValueAssociationFilter : BaseFilter
    {
        public ValueAssociationFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(
            driver, operatorValue, false)
        {
            Table = table;
        }

        private Table Table { get; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel ng-star-inserted']//input[@id='chipInput']"))
                    .Click();
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel ng-star-inserted']//input[@id='chipInput']"))
                    .SendKeys(row["Values"]);
                _driver.FindElement(
                        By.XPath(
                            ".//button[@class='button-small mat-primary mat-raised-button _mat-animation-noopable ng-star-inserted']"))
                    .Click();
            }

            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Click();
                if (!_driver.IsElementDisplayed(By.XPath($".//li//span[text()='{row["Association"]}']"))) continue;
                _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
            }

            SaveFilter();
        }
    }

    public class NumberAssociationFilter : BaseFilter
    {
        public NumberAssociationFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(
            driver, operatorValue, false)
        {
            Table = table;
        }

        private Table Table { get; }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel ng-star-inserted']//input[@type='number']"))
                    .Click();
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel ng-star-inserted']//input[@type='number']"))
                    .SendKeys(row["Number"]);
            }

            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Click();
                if (!_driver.IsElementDisplayed(By.XPath($".//li//span[text()='{row["Association"]}']"))) continue;
                _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
            }

            SaveFilter();
        }
    }

    public class DataAssociationFilter : BaseFilter
    {
            public DataAssociationFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(
                driver, operatorValue, false)
            {
                Table = table;
            }

            private Table Table { get; }

            public override void Do()
            {
                SelectOperator();
                _driver.WaitForDataLoading();
                foreach (var row in Table.Rows)
                {
                    _driver.FindElement(By.XPath(
                            ".//div[@class='mat-form-field-wrapper']//input[@aria-label='Date']"))
                        .Click();
                    _driver.FindElement(By.XPath(
                            ".//div[@class='mat-form-field-wrapper']//input[@aria-label='Date']"))
                        .SendKeys(row["Values"]);
                }

                foreach (var row in Table.Rows)
                {
                    _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Click();
                    if (!_driver.IsElementDisplayed(By.XPath($".//li//span[text()='{row["Association"]}']"))) continue;
                    _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
                }

                SaveFilter();
            }
    }
}