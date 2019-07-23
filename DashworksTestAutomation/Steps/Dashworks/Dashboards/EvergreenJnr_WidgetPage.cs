using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_WidgetPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_WidgetPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        #region Constructors
        [When(@"User adds new Widget")]
        public void WhenUserAddsNewWidget(Table table)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            foreach (var row in table.Rows)
            {
                createWidgetElement.WidgetType.Click();
                createWidgetElement.SelectObjectForWidgetCreation(row["WidgetType"]);

                if (string.IsNullOrEmpty(row["Title"])) createWidgetElement.Title.SendKeys(" ");

                if (!string.IsNullOrEmpty(row["Title"]))
                {
                    createWidgetElement.Title.Clear();
                    createWidgetElement.Title.SendKeys(row["Title"]);
                }

                if (!string.IsNullOrEmpty(row["List"]))
                {
                    createWidgetElement.List.Click();
                    createWidgetElement.SelectListForWidgetCreation(row["List"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (row.ContainsKey("Type") && !string.IsNullOrEmpty(row["Type"]))
                {
                    createWidgetElement.Type.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["Type"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["SplitBy"]))
                {
                    _driver.WaitForElementToBeDisplayed(createWidgetElement.SplitBy);
                    createWidgetElement.SplitBy.Click();
                    _driver.WaitForElementToBeDisplayed(createWidgetElement.DropdownMenu);
                    createWidgetElement.SelectObjectForWidgetCreation(row["SplitBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["AggregateFunction"]))
                {
                    createWidgetElement.AggregateFunction.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateFunction"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["AggregateBy"]))
                {
                    createWidgetElement.AggregateBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["OrderBy"]))
                {
                    createWidgetElement.OrderBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["OrderBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["MaxValues"]))
                {
                    createWidgetElement.MaxValues.Clear();
                    createWidgetElement.MaxValues.SendKeys(row["MaxValues"]);
                }

                if (!string.IsNullOrEmpty(row["TableOrientation"]))
                {
                    createWidgetElement.TableOrientation.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["TableOrientation"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (!string.IsNullOrEmpty(row["ShowLegend"]) && row["ShowLegend"].Equals("true"))
                {
                    createWidgetElement.ShowLegend.Click();
                }

                if (!string.IsNullOrEmpty(row["Layout"]))
                {
                    _driver.ClickByJavascript(createWidgetElement.GetDropdownForWidgetByName("Layout"));
                    createWidgetElement.SelectObjectForWidgetCreation(row["Layout"]);
                }
            }
        }

        [When(@"User updates Widget with following info:")]
        [When(@"User creates new Widget")]
        public void WhenUserCreatesNewWidget(Table table)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            foreach (var row in table.Rows)
            {
                createWidgetElement.WidgetType.Click();
                createWidgetElement.SelectObjectForWidgetCreation(row["WidgetType"]);

                if (string.IsNullOrEmpty(row["Title"])) createWidgetElement.Title.SendKeys(" ");

                if (createWidgetElement.Title.Displayed() & !string.IsNullOrEmpty(row["Title"]))

                {
                    createWidgetElement.Title.Clear();
                    createWidgetElement.Title.SendKeys(row["Title"]);
                }

                if (createWidgetElement.List.Displayed() && !string.IsNullOrEmpty(row["List"]))
                {
                    createWidgetElement.List.Click();
                    createWidgetElement.SelectListForWidgetCreation(row["List"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.SplitBy.Displayed() && !string.IsNullOrEmpty(row["SplitBy"]))
                {
                    _driver.WaitForElementToBeDisplayed(createWidgetElement.SplitBy);
                    createWidgetElement.SplitBy.Click();
                    _driver.WaitForElementToBeDisplayed(createWidgetElement.DropdownMenu);
                    createWidgetElement.SelectObjectForWidgetCreation(row["SplitBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.AggregateFunction.Displayed() && !string.IsNullOrEmpty(row["AggregateFunction"]))
                {
                    createWidgetElement.AggregateFunction.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateFunction"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.AggregateBy.Displayed() && row.ContainsKey("AggregateBy") && !string.IsNullOrEmpty(row["AggregateBy"]))
                {
                    createWidgetElement.AggregateBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.OrderBy.Displayed() && !string.IsNullOrEmpty(row["OrderBy"]))
                {
                    createWidgetElement.OrderBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["OrderBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.MaxValues.Displayed() && !string.IsNullOrEmpty(row["MaxValues"]))
                {
                    createWidgetElement.MaxValues.Clear();
                    createWidgetElement.MaxValues.SendKeys(row["MaxValues"]);
                }

                if (createWidgetElement.TableOrientation.Displayed())
                {
                    createWidgetElement.TableOrientation.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["TableOrientation"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (createWidgetElement.MaxRows.Displayed())
                {
                    createWidgetElement.MaxRows.Clear();
                    createWidgetElement.MaxRows.SendKeys(row["MaxRows"]);
                }

                if (createWidgetElement.MaxColumns.Displayed())
                {
                    createWidgetElement.MaxColumns.Clear();
                    createWidgetElement.MaxColumns.SendKeys(row["MaxColumns"]);
                }

                if (createWidgetElement.ShowLegend.Displayed() && !string.IsNullOrEmpty(row["ShowLegend"]))
                {
                    createWidgetElement.ShowLegend.Click();
                }

                createWidgetElement.CreateUpdateWidgetButton.Click();
                _driver.WaitForDataLoading();
            }
        }
        #endregion


        [When(@"User selects ""(.*)"" in the ""(.*)"" Widget dropdown")]
        public void WhenUserSelectsInTheWidgetDropdown(string objectName, string dropdownName)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            _driver.ClickByJavascript(createWidgetElement.GetDropdownForWidgetByName(dropdownName));
            createWidgetElement.SelectObjectForWidgetCreation(objectName);
        }

        [When(@"User enters ""(.*)"" as Widget Title")]
        public void WhenUserSetsWidgetTitle(string widgetTitle)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.Title.SendKeys(widgetTitle);
        }

        [When(@"User selects ""(.*)"" as Widget List")]
        public void WhenUserSetsWidgetList(string widgetList)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.List.Click();
            createWidgetElement.SelectListForWidgetCreation(widgetList);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User selects ""(.*)"" as Widget Split By")]
        public void WhenUserSetsWidgetSplitBy(string SplitBy)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoadingOnProjects();
            createWidgetElement.SplitBy.Click();
            createWidgetElement.SelectListForWidgetCreation(SplitBy);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User selects ""(.*)"" as Widget Type")]
        public void WhenUserSetsWidgetType(string Type)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            createWidgetElement.Type.Click();
            createWidgetElement.SelectObjectForWidgetCreation(Type);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User selects ""(.*)"" as Widget AggregateBy")]
        public void WhenUserSetsWidgetAggregateBy(string aggregateBy)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.AggregateBy.Click();
            createWidgetElement.SelectObjectForWidgetCreation(aggregateBy);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User selects ""(.*)"" as Widget Aggregate Function")]
        public void WhenUserSetsWidgetAggregateFunction(string aggregateFunc)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.AggregateFunction.Click();
            createWidgetElement.SelectObjectForWidgetCreation(aggregateFunc);
            _driver.WaitForDataLoadingOnProjects();
        }
       
        [When(@"User selects ""(.*)"" as Widget OrderBy")]
        public void WhenUserSetsWidgetOrderBy(string orderBy)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.OrderBy.Click();
            createWidgetElement.SelectObjectForWidgetCreation(orderBy);
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User enters ""(.*)"" as Widget Max Values")]
        public void WhenUserSetsWidgetMaxValues(string value)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.MaxValues.Clear();
            createWidgetElement.MaxValues.SendKeys(value);
        }

        [When(@"User clicks on the Colour Scheme dropdown")]
        public void WhenUserClicksOnTheColourSchemeDropdown()
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            createWidgetElement.ColorScheme.Click();
        }

        [When(@"User selects ""(.*)"" in the Colour Scheme")]
        public void WhenUserSelectsInTheColourScheme(string colorTitle)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            createWidgetElement.ColorScheme.Click();
            createWidgetElement.GetColorFromColorScheme(colorTitle).Click();
        }

        [When(@"User selects the Colour Scheme by index ""(.*)""")]
        public void SetColourSchemeByIndex(string index)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            createWidgetElement.ColorScheme.Click();
            Thread.Sleep(500);
            if (Convert.ToInt32(index) <= createWidgetElement.GetDropdownOptions().Count)
            {
                createWidgetElement.ClickColorSchemeByIndex(Convert.ToInt32(index));
            }           
        }

        [When(@"User selects ""(.*)"" checkbox on the Create Widget page")]
        public void WhenUserSelectsCheckboxOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.GetDashboardCheckboxByName(checkboxName).Click();
        }

        [When(@"User clicks ""(.*)"" button in Unsaved Changes alert")]
        public void WhenUserClickButtonInUnsavedChangesAlert(string buttonTitle)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.UnsavedChangesAlertButton(buttonTitle).Click();
        }


        [Then(@"Colour Scheme dropdown is displayed to the user")]
        public void ThenColourSchemeDropdownIsDisplayedToTheUser()
        {
            var dropdownContainer = _driver.FindElements(By.XPath(AddWidgetPage.ColorSchemeDropdownContainer));
            foreach (var element in dropdownContainer)
            {
                var innerColour = element.FindElement(By.XPath(AddWidgetPage.ColorSchemeDropdownContent));
                Assert.IsTrue(_driver.IsElementExists(innerColour), "Colour item is not found");
            }
            var page = _driver.NowAt<BaseGridPage>();
            page.BodyContainer.Click();
        }

        [Then(@"Colour Scheme dropdown is not displayed to the user")]
        public void ThenColourSchemeDropdownIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Assert.IsFalse(page.ColorScheme.Displayed(), "Colour Scheme dropdown is displayed to the user");
        }

        [Then(@"Table widget displayed inside preview pane correctly")]
        public void ThenTableWidgetDisplayedInsidePreviewPane()
        {
            var preview = _driver.NowAt<EvergreenDashboardsPage>();
            int prevWidth = preview.WidgetPreview.Size.Width;

            var widget = _driver.NowAt<AddWidgetPage>();
            int widgetWidth = widget.GetTableWidgetPreview().Size.Width;

            Assert.That(widgetWidth > prevWidth * 0.85 && widgetWidth < prevWidth, Is.True, "Widget preview less than 85 percent preview box");
        }
    
        [Then(@"Widget title ""(.*)"" is displayed on Widget page")]
        public void ThenWidgetTitleDisplayedOnThePage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.AreEqual(text, page.Title.GetAttribute("innerHTML"), "Widget title is not the same");
        }

        [Then(@"Error message with ""(.*)"" text is displayed on Widget page")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.ErrorMessage);
            Assert.AreEqual(text, page.ErrorMessage.Text, "Error Message is not displayed");
        }

        [Then(@"Unsaved Changes alert not displayed to the user")]
        public void ThenNoUnsavedChangesAlertDisplayedOnEditWidgetPage()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeNotDisplayed(page.UnsavedChangesAlert);
            Assert.IsFalse(_driver.IsElementDisplayed(page.UnsavedChangesAlert));
        }

        [Then(@"User sees ""(.*)"" text in alert on Edit Widget page")]
        public void ThenUserSeesTextInAlertOnEditWidgetPage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeDisplayed(page.UnsavedChangesAlert);
            Assert.AreEqual(text, page.GetUnsavedChangesAlertText().Text);
        }
 
        [Then(@"User sees following options for Order By selector on Create Widget page:")]
        public void WhenUserSeesFollowingOptionsForOrderBySelectorOnCreateWidgetPage(Table items)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.OrderBy.Click();

            Assert.AreEqual(items.Rows.SelectMany(row => row.Values).ToList(),
                page.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
        }

        [Then(@"""(.*)"" checkbox is checked on the Create Widget page")]
        public void ThenCheckboxIsCheckedOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(page.GetDashboardCheckboxByName(checkboxName).GetAttribute("class").Contains("checked"));
        }

        [Then(@"""(.*)"" checkbox is not displayed on the Create Widget page")]
        public void ThenCheckboxIsNotDisplayedOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.IsFalse(page.GetCheckboxByName(checkboxName), $"{checkboxName} checkbox is displayed");
        }

        [Then(@"User sees ""(.*)"" warning text below Lists field")]
        public void ThenUserSeesWarningTextBelowListsField(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Assert.AreEqual(text, page.WarningTextUnderField.Text);
        }
        
        [Then(@"Aggregate Function dropdown is placed above the Aggregate By dropdown")]
        public void ThenUserSeesAggregateFunctionAboveTheAggregateByDropdown()
        {
            var page = _driver.NowAt<AddWidgetPage>();

            Assert.That(page.AggregateFunction.Location.Y, Is.LessThan(page.AggregateBy.Location.Y));
        }

        [Then(@"""(.*)"" dropdown is missing")]
        public void ThenSelectedDropdownIsMissing(string label)
        {
            var page = _driver.NowAt<AddWidgetPage>();

            Assert.That(page.Dropdowns.Any(x=>x.Text.Equals(label)), Is.EqualTo(false));
        }

        [Then(@"Aggregate By dropdown is disabled")]
        public void ThenSelectedDropdownIsMissing()
        {
            var page = _driver.NowAt<AddWidgetPage>();

            Assert.That(page.IsAggregateByDropdownDisabled, Is.EqualTo(true));
        }

        [Then(@"User sees following options for Aggregate By selector on Create Widget page:")]
        public void WhenUserSeesFollowingOptionsForAggregateBySelectorOnCreateWidgetPage(Table items)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.AggregateBy.Click();

            Assert.AreEqual(items.Rows.SelectMany(row => row.Values).ToList(),
                page.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
        }

        [Then(@"Message saying that list is unavailable appears in Edit Widget page")]
        public void ThenMessageIsDisplayedInTheListsPanel()
        {
            var listElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeDisplayed(listElement.ListDoesntExistMessage);
        }

        [Then(@"""(.*)"" checkbox has a correct label")]
        public void ThenCheckboxLabelDisplayedOnForm(string checkbox)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeDisplayed(page.ShowLegend);

            switch (checkbox)
            {
                case "Show legend":
                    Assert.That(page.ShowLegendLabel.Text, Is.EqualTo("Show legend"), "Show legend label wrong");
                    break;
                case "Show data labels":
                    Assert.That(page.ShowDataLabel.Text, Is.EqualTo("Show data labels"), "Show data labels label wrong");
                    break;

                default:
                    Assert.True(false, "Wrong checkbox specified");
                    break;
            }
        }
    }
}