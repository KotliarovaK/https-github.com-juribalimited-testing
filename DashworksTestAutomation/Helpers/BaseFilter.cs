using System.Linq;
using DashworksTestAutomation.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Helpers
{
    public class BaseFilter
    {
        protected RemoteWebDriver _driver { get; set; }
        protected string _operatorValue { get; set; }
        protected bool _acceptCheckbox { get; set; }
        protected Table _table { get; set; }

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

        public void SaveFilter()
        {
            if (_acceptCheckbox)
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel ng-star-inserted']//md-checkbox//div[@class='mat-checkbox-inner-container']"))
                    .Click();
            _driver.MouseHover(By.XPath(".//button[@title='Update Filter Set']"));
            _driver.FindElement(By.XPath(".//button[@title='Update Filter Set']")).Click();
        }
    }

    public class DateFilter : BaseFilter
    {
        private string _dateValue { get; set; }

        public DateFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, string dateValue) : base(
            driver, operatorValue, acceptCheckbox)
        {
            _dateValue = dateValue;
        }

        public override void Do()
        {
            SelectOperator();
            if (_driver.IsElementDisplayed(By.XPath(".//input[@aria-label='Date']")))
            {
                _driver.FindElement(By.XPath(".//input[@aria-label='Date']")).SendKeys(_dateValue);
            }
            SaveFilter();
        }
    }

    public class LookupFilter : BaseFilter
    {
        private string _value { get; set; }

        public LookupFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, string value) : base(
            driver, operatorValue, acceptCheckbox)
        {
            _value = value;
        }

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

    public class CheckBoxesFilter : BaseFilter
    {
        protected Table _optionsTable { get; set; }

        protected string CheckboxSelectorName =
            ".//div[@class='filterAddPanel ng-star-inserted']//span[text()='{0}']";

        protected string CheckboxSelector =
            ".//div[@class='filterAddPanel ng-star-inserted']//span[text()='{0}']/../preceding-sibling::i";

        public CheckBoxesFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table optionsTable) :
            base(driver, operatorValue, acceptCheckbox)
        {
            _optionsTable = optionsTable;
        }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in _optionsTable.Rows)
            {
                _driver.FindElement(
                    By.XPath(string.Format(CheckboxSelectorName, row["SelectedCheckboxes"]))).Click();
            }
            SaveFilter();
        }
    }

    public class ChangeCheckboxesFilter : CheckBoxesFilter
    {
        private Table Table { get; set; }

        public ChangeCheckboxesFilter(RemoteWebDriver driver, Table table) :
            base(driver, "", false, table)
        {
            Table = table;
        }

        public override void Do()
        {
            foreach (var row in Table.Rows)
            {
                var selector = string.Format(CheckboxSelector, row["Option"]);
                _driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
                var checkbox = _driver.FindElement(By.XPath(selector));
                if (bool.Parse(row["State"]) != checkbox.GetFilterCheckboxSelectedState())
                {
                    checkbox.Click();
                }
            }
            SaveFilter();
        }
    }

    public class ValueFilter : BaseFilter
    {
        private Table _optionsTable { get; set; }

        public ValueFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table optionsTable) :
            base(driver, operatorValue, acceptCheckbox)
        {
            _optionsTable = optionsTable;
        }

        public override void Do()
        {
            var addedOptionSelector =
                ".//div[@class='filterAddPanel ng-star-inserted']/div[@class='form-container']//div[@class='form-group ng-star-inserted']//li/span[contains(text(),'{0}')]";
            var allAddedOptionsSelector =
                ".//div[@class='filterAddPanel ng-star-inserted']/div[@class='form-container']//div[@class='form-group ng-star-inserted']//li/span";
            var filterValueSelector = By.XPath(
                ".//div[@class='filterAddPanel ng-star-inserted']//div[@class='mat-input-infix mat-form-field-infix']//input");
            var addButtonSelector = By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//button[@title='Add']");
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in _optionsTable.Rows)
            {
                if (!_driver.IsElementDisplayed(filterValueSelector)) continue;
                _driver.FindElement(filterValueSelector).SendKeys(row["Values"]);

                if (_driver.IsElementDisplayed(addButtonSelector))
                {
                    _driver.FindElement(addButtonSelector).Click();

                    //Show all added values
                    if (_driver.IsElementDisplayed(By.XPath(string.Format(addedOptionSelector, "more"))))
                        _driver.FindElement(By.XPath(string.Format(addedOptionSelector, "more"))).Click();
                    var addedOptions = _driver.FindElements(By.XPath(allAddedOptionsSelector))
                        .Select(value => value.Text).ToList();
                    Assert.Contains(row["Values"], addedOptions);
                }
            }
            SaveFilter();
        }
    }

    public class ListFilter : BaseFilter
    {
        private string _value { get; set; }

        public ListFilter(RemoteWebDriver driver, Table table) :
            base(driver, table)
        {
            _table = table;
        }

        public override void Do()
        {
            _driver.WaitForDataLoading();
            foreach (var row in _table.Rows)
            {
                _driver.FindElement(By.XPath(
                    $".//div[@id='perfectScrolBar']//span[text()='{row["SelectedList"]}']")).Click();
            }
            foreach (var row in _table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Click();
                _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
            }
            SaveFilter();
        }
    }

    public class LookupValueAssociationFilter : BaseFilter
    {
        private Table Table { get; set; }

        public LookupValueAssociationFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(
            driver, operatorValue, false)
        {
            Table = table;
        }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@id='md-input-3']")).Click();
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@id='md-input-3']"))
                    .SendKeys(row["SelectedValues"]);
                _driver.FindElement(By.XPath(
                        $".//div[@class='filterAddPanel ng-star-inserted']//span[contains(text(),'{row["SelectedValues"]}')]"))
                    .Click();
            }
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@id='md-input-2']")).Click();
                _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
            }
            SaveFilter();
        }
    }

    public class ValueAssociationFilter : BaseFilter
    {
        private Table Table { get; set; }

        public ValueAssociationFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(
            driver, operatorValue, false)
        {
            Table = table;
        }

        public override void Do()
        {
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//div[@class='mat-input-infix mat-form-field-infix']//input")).Click();
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel ng-star-inserted']//div[@class='mat-input-infix mat-form-field-infix']//input"))
                    .SendKeys(row["Values"]);
                _driver.FindElement(By.XPath(".//button[@class='button-small mat-primary mat-raised-button ng-star-inserted']")).Click();
            }
            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@id='md-input-2']")).Click();
                 if (!_driver.IsElementDisplayed(By.XPath($".//li//span[text()='{row["Association"]}']"))) continue;
                _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
            }
            SaveFilter();
        }
    }
}