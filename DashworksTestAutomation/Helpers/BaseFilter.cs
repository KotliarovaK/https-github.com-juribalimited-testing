using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
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
            var selectbox = _driver.FindElement(By.XPath(".//div[@class='mat-select-trigger']"));
            _driver.SelectCustomSelectbox(selectbox, _operatorValue);
        }

        public virtual void Do()
        {
        }

        public void SaveFilter()
        {
            if (_acceptCheckbox)
                _driver.FindElement(By.XPath(
                        ".//div[@class='filterAddPanel']//md-checkbox//div[@class='mat-checkbox-inner-container']"))
                    .Click();
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
            _driver.FindElement(By.XPath(".//input[@aria-label='Date']")).SendKeys(_dateValue);
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
            _driver.FindElement(By.XPath(".//div[@class='filterAddPanel']//input[@placeholder='Search']"))
                .SendKeys(_value);
            _driver.FindElement(By.XPath($".//div[@class='filterAddPanel']//span[contains(text(),'{_value}')]")).Click();
            SaveFilter();
        }
    }

    public class CheckBoxesFilter : BaseFilter
    {
        private Table _optionsTable { get; set; }

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
                    By.XPath($".//div[@class='filterAddPanel']//span[text()='{row["SelectedCheckboxes"]}']")).Click();
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
            var filterValueSelector = By.XPath(
                ".//div[@class='filterAddPanel']//div[@class='mat-input-infix mat-form-field-infix']//input");
            var addButtonSelector = By.XPath(".//div[@class='filterAddPanel']//button[@title='Add']");
            SelectOperator();
            _driver.WaitForDataLoading();
            foreach (var row in _optionsTable.Rows)
            {
                if (!_driver.IsElementDisplayed(filterValueSelector)) continue;
                _driver.FindElement(filterValueSelector).SendKeys(row["Values"]);
                _driver.FindElement(addButtonSelector).Click();
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
}