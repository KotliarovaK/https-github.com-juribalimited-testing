using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

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
            _driver.WaitForElementToBeDisplayed(
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
            var updateButtonSelector = ".//div[contains(@class, 'actions')]//div[@class='actions-btn']/button";
            _driver.MouseHover(By.XPath(updateButtonSelector));
            _driver.FindElement(By.XPath(updateButtonSelector)).Click();
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
            if (_driver.FindElements(By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']")).Count > 0)
            {
                _driver.FindElement(
                        By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']"))
                    .SendKeys(_value);
            }
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

    public class TreeAssociationFilter : BaseFilter
    {
        public TreeAssociationFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(driver, operatorValue, false)
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
                if (string.IsNullOrEmpty(row["Value"]))
                    return;

                _driver.FindElement(
                        By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']"))
                    .SendKeys(row["Value"]);
                _driver.FindElement(By.XPath(".//ul[@class='tree-list ng-star-inserted']//mat-checkbox"))
                    .Click();
            }

            foreach (var row in Table.Rows)
            {
                if (string.IsNullOrEmpty(row["Association"]))
                    break;
                _driver.FindElement(By.XPath(".//div[contains(@class, 'title-beetwen-blocks')]/following-sibling::div//input[@placeholder='Search']")).SendKeys(row["Association"]);
                if (_driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Displayed)
                    _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
                else
                    _driver.FindElement(By.XPath($".//li//div[text()='{row["Association"]}']")).Click();
                _driver.FindElement(By.XPath(".//div[contains(@class, 'title-beetwen-blocks')]/following-sibling::div//input[@placeholder='Search']")).Clear();
            }

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
                if (_driver.FindElements(
                        By.XPath(".//div[@class='filterAddPanel ng-star-inserted']//input[@placeholder='Search']"))
                    .Count > 0)
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
                }

                _driver.FindElement(By.XPath(
                        $".//div[@id='perfectScrolBar']//span[contains(text(),'{row["SelectedValues"]}')]"))
                    .Click();
            }
            SaveFilter();
        }
    }

    public class LookupFilterTableWithoutSave : BaseFilter
    {
        public LookupFilterTableWithoutSave(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table table) : base(
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
        }
    }

    public class CheckBoxesFilter : BaseFilter
    {
        protected string CheckboxSelector =
            ".//div[@class='filterAddPanel ng-star-inserted']//span[text()='{0}']/ancestor::div/mat-checkbox";

        protected string CheckboxSelectorName =
            ".//div[@class='filterAddPanel ng-star-inserted']//span[starts-with(text(),'{0}')]";

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

                if (_driver.FindElements(By.XPath(string.Format(CheckboxSelectorName, row["SelectedCheckboxes"])))
                        .Count > 1)
                {
                    _driver.FindElement(
                        By.XPath(string.Format(".//div[@class='filterAddPanel ng-star-inserted']//span[(text()='{0}')]", row["SelectedCheckboxes"]))).Click();
                }
                else
                {
                    try
                    {
                        _driver.FindElement(By.XPath(".//div[@class='filter-panel']//i[contains(@class,'icon-search')]")).Click();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    _driver.FindElement(
                        By.XPath(string.Format(CheckboxSelectorName, row["SelectedCheckboxes"]))).Click();
                }

            SaveFilter();
        }

        public override void CheckFilterDate(string filtersName)
        {
            var basePage = _driver.NowAt<BaseGridPage>();
            var columnContent = basePage.GetColumnContentByColumnName(filtersName);
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
                        Verify.IsTrue(_optionsTable.Rows.Select(x => x["SelectedCheckboxes"]).All(x => !value.Equals(x)), "PLEASE ADD EXCEPTION MESSAGE");
                        break;

                    case "Equals":
                        Verify.IsTrue(_optionsTable.Rows.Select(x => x["SelectedCheckboxes"]).All(x => value.Equals(x)), "PLEASE ADD EXCEPTION MESSAGE");
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
                var checkbox = _driver.FindElements(By.XPath(selector));

                if (checkbox.FirstOrDefault().Displayed())
                {
                    if (bool.Parse(row["State"]) != checkbox.FirstOrDefault().GetFilterCheckboxSelectedState())
                        checkbox.FirstOrDefault().Click();
                }
                else
                {
                    try
                    {
                        _driver.FindElement(By.XPath(".//div[@class='filter-panel']//i[contains(@class,'icon-search')]")).Click();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    if (bool.Parse(row["State"]) != checkbox.FirstOrDefault().GetFilterCheckboxSelectedState())
                        checkbox.FirstOrDefault().Click();
                }
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
                ".//span[@class='chips-item-text ng-star-inserted' and contains(text(), '{0}')]";
            var allAddedOptionsSelector =
                ".//div[@class='filterAddPanel ng-star-inserted']/div[contains(@class,'form-container')]//div[@class='form-group ng-star-inserted']//li/span";
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
                    Verify.Contains(row["Values"], addedOptions, "PLEASE ADD EXCEPTION MESSAGE");
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
            {
                var item = _driver.FindElement(By.XPath(
                        $".//div[@id='perfectScrolBar']//span[text()='{row["SelectedList"]}']"));
                _driver.MouseHoverByJavascript(item);
                item.Click();
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
                    selector = $".//li//span[contains(text(), '{row["Association"]}')]";
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

                //if tests will fail then remove next string
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Clear();

                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']"))
                    .SendKeys(row["SelectedValues"]);
                _driver.FindElement(By.XPath(
                        $".//div[@class='filterAddPanel ng-star-inserted']//span[contains(text(),'{row["SelectedValues"]}')]"))
                    .Click();
            }

            foreach (var row in Table.Rows)
            {
                if (string.IsNullOrEmpty(row["Association"]))
                    break;
                //TODO: try to fix not found element by path below(input[@id='mat-input-7'] sometimes has 76 digit)
                //_driver.FindElement(By.XPath("//div[contains(@class, 'associationmultiselect')]//input[@id='mat-input-7']")).SendKeys(row["Association"]);
                _driver.FindElement(By.XPath(".//div[contains(@class, 'title-beetwen-blocks')]/following-sibling::div//input[@placeholder='Search']")).SendKeys(row["Association"]);
                if (_driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Displayed)
                    _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
                else
                    _driver.FindElement(By.XPath($".//li//div[text()='{row["Association"]}']")).Click();
                //TODO: try to fix not found element by path below(input[@id='mat-input-7'] sometimes has 76 digit)
                //_driver.FindElement(By.XPath("//div[contains(@class, 'associationmultiselect')]//input[@id='mat-input-7']")).Clear();
                _driver.FindElement(By.XPath(".//div[contains(@class, 'title-beetwen-blocks')]/following-sibling::div//input[@placeholder='Search']")).Clear();
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
                if (!_driver.IsElementDisplayed(By.XPath(".//div[@id='context']//input[@placeholder='Search']"))) continue;
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
                if (string.IsNullOrEmpty(row["Association"]))
                    break;
                _driver.FindElement(By.XPath($".//li//span[text()='{row["Association"]}']")).Click();
            }
        }
    }

    public class ExpandedCheckboxesAssociationFilter : BaseFilter
    {
        protected string CheckboxSelectorName =
            ".//span[text()='{0}']/ancestor::div[1]//div[contains(@class, 'mat-checkbox-inner-container')]";

        public ExpandedCheckboxesAssociationFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table optionsTable) :
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
                if (string.IsNullOrEmpty(row["Association"]))
                    break;
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
                if (!string.IsNullOrEmpty(row["Values"]))
                {
                    _driver.FindElement(By.XPath(
                            ".//div[@class='filterAddPanel ng-star-inserted']//input[@id='chipInput']"))
                        .Click();
                    _driver.FindElement(By.XPath(
                            ".//div[@class='filterAddPanel ng-star-inserted']//input[@id='chipInput']"))
                        .SendKeys(row["Values"]);
                    _driver.FindElement(
                            By.XPath(
                                ".//div[@class='filter-panel']//button[contains(@class,'button-small')]"))
                        .Click();
                }
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
                var selector = string.Empty;
                if (row["Association"].Contains("'"))
                {
                    var strings = row["Association"].Split('\'');
                    selector =
                        $".//li//span[contains(text(),'{strings[0]}')][contains(text(),'{strings[1]}')]";
                }
                else
                {
                    selector = $".//li//span[text()='{row["Association"]}']";
                }
                if (!_driver.IsElementDisplayed(By.XPath(selector))) continue;
                _driver.FindElement(By.XPath(selector)).Click();
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
                if (!_driver.IsElementDisplayed(By.XPath($".//li//span[contains(text(), '{row["Association"]}')]"))) continue;
                _driver.FindElement(By.XPath($".//li//span[contains(text(), '{row["Association"]}')]")).Click();
            }

            SaveFilter();
        }
    }

    public class BetweenOperatorFilter : BaseFilter
    {
        public BetweenOperatorFilter(RemoteWebDriver driver, string operatorValue, bool acceptCheckbox, Table table) : base(
            driver, operatorValue, acceptCheckbox)
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
                        ".//div[@class='mat-form-field-wrapper']//input[@placeholder='Start Date (Inclusive)']"))
                    .Click();
                _driver.FindElement(By.XPath(
                        ".//div[@class='mat-form-field-wrapper']//input[@placeholder='Start Date (Inclusive)']"))
                    .SendKeys(row["StartDateInclusive"]);
            }

            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(
                        ".//div[@class='mat-form-field-wrapper']//input[@placeholder='End Date (Inclusive)']"))
                    .Click();
                _driver.FindElement(By.XPath(
                        ".//div[@class='mat-form-field-wrapper']//input[@placeholder='End Date (Inclusive)']"))
                    .SendKeys(row["EndDateInclusive"]);
            }
            _driver.FindElement(By.XPath(".//body")).Click();
            SaveFilter();
        }
    }

    public class BetweenDataAssociationFilter : BaseFilter
    {
        public BetweenDataAssociationFilter(RemoteWebDriver driver, string operatorValue, Table table) : base(
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
                if (!row["StartDateInclusive"].Equals(string.Empty))
                {
                    _driver.FindElement(By.XPath(
                            ".//div[@class='mat-form-field-wrapper']//input[@placeholder='Start Date (Inclusive)']"))
                        .Click();
                    _driver.FindElement(By.XPath(
                            ".//div[@class='mat-form-field-wrapper']//input[@placeholder='Start Date (Inclusive)']"))
                        .SendKeys(row["StartDateInclusive"]);
                }
            }

            foreach (var row in Table.Rows)
            {
                if (!row["EndDateInclusive"].Equals(string.Empty))
                {
                    _driver.FindElement(By.XPath(
                        ".//div[@class='mat-form-field-wrapper']//input[@placeholder='End Date (Inclusive)']"))
                    .Click();
                    _driver.FindElement(By.XPath(
                            ".//div[@class='mat-form-field-wrapper']//input[@placeholder='End Date (Inclusive)']"))
                        .SendKeys(row["EndDateInclusive"]);
                }
            }
            _driver.ClickByJavascript(_driver.FindElement(By.XPath(".//body")));

            foreach (var row in Table.Rows)
            {
                _driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Click();
                if (!_driver.IsElementDisplayed(By.XPath($".//li//span[contains(text(), '{row["Association"]}')]"))) continue;
                _driver.FindElement(By.XPath($".//li//span[contains(text(), '{row["Association"]}')]")).Click();
            }

            SaveFilter();
        }
    }
}