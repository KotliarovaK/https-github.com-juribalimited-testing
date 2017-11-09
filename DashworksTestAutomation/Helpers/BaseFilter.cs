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

        public BaseFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox)
        {
            _driver = driver;
            _operatorValue = operatorValue;
            _acceptCheckbox = acceptCheckbox;
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
            _driver.FindElement(By.XPath(".//div[@class='filterAddPanel']//span[text()='London']")).Click();
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
}