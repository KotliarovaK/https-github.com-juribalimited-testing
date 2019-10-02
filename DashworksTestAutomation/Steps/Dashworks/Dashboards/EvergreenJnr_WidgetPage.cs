using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

                if (row.ContainsKey("List") && !string.IsNullOrEmpty(row["List"]))
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

                if (row.ContainsKey("SplitBy") && !string.IsNullOrEmpty(row["SplitBy"]))
                {
                    createWidgetElement.SelectSplitByItem(row["SplitBy"]);
                }

                if (row.ContainsKey("AggregateFunction") && !string.IsNullOrEmpty(row["AggregateFunction"]))
                {
                    _driver.WaitForElementToBeEnabled(createWidgetElement.AggregateFunction);
                    createWidgetElement.AggregateFunction.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateFunction"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (row.ContainsKey("AggregateBy") && !string.IsNullOrEmpty(row["AggregateBy"]))
                {
                    createWidgetElement.AggregateBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["AggregateBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (row.ContainsKey("OrderBy") && !string.IsNullOrEmpty(row["OrderBy"]))
                {
                    createWidgetElement.OrderBy.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["OrderBy"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (row.ContainsKey("MaxValues") && !string.IsNullOrEmpty(row["MaxValues"]))
                {
                    createWidgetElement.MaxValues.Clear();
                    createWidgetElement.MaxValues.SendKeys(row["MaxValues"]);
                }

                if (row.ContainsKey("TableOrientation") && !string.IsNullOrEmpty(row["TableOrientation"]))
                {
                    createWidgetElement.TableOrientation.Click();
                    createWidgetElement.SelectObjectForWidgetCreation(row["TableOrientation"]);
                    _driver.WaitForDataLoadingOnProjects();
                }

                if (row.ContainsKey("ShowLegend") && !string.IsNullOrEmpty(row["ShowLegend"]) 
                                                  && row["ShowLegend"].Equals("true"))
                {
                    createWidgetElement.ShowLegend.Click();
                }

                if (row.ContainsKey("Layout") && !string.IsNullOrEmpty(row["Layout"]))
                {
                    _driver.WaitForElementToBeDisplayed(createWidgetElement.Layout);
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
                PupualteWidgetData(row);
                createWidgetElement.CreateUpdateWidgetButton.Click();
                _driver.WaitForDataLoading();
            }
        }

        [When(@"User creates new Widget with double click")]
        public void WhenUserCreatesNewWidgetWithDubleClick(Table table)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            foreach (var row in table.Rows)
            {
                PupualteWidgetData(row);

                _driver.DoubleClick(createWidgetElement.CreateUpdateWidgetButton);
                
                _driver.WaitForDataLoading();
            }
        }

        [When(@"Then User pupualtes Widget Data")]
        public void PupualteWidgetData(TableRow tableRow)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();

            createWidgetElement.WidgetType.Click();
            createWidgetElement.SelectObjectForWidgetCreation(tableRow["WidgetType"]);

            if (string.IsNullOrEmpty(tableRow["Title"])) createWidgetElement.Title.SendKeys(" ");

            if (createWidgetElement.Title.Displayed() & !string.IsNullOrEmpty(tableRow["Title"]))

            {
                createWidgetElement.Title.Clear();
                createWidgetElement.Title.SendKeys(tableRow["Title"]);
            }

            if (createWidgetElement.List.Displayed() && !string.IsNullOrEmpty(tableRow["List"]))
            {
                createWidgetElement.List.Click();
                createWidgetElement.SelectListForWidgetCreation(tableRow["List"]);
                _driver.WaitForDataLoadingOnProjects();
            }

            if (createWidgetElement.Type.Displayed() && tableRow.ContainsKey("Type")
                                                     && !string.IsNullOrEmpty(tableRow["Type"]))
            {
                createWidgetElement.Type.Click();
                createWidgetElement.SelectListForWidgetCreation(tableRow["Type"]);
                _driver.WaitForDataLoadingOnProjects();
            }

            if (createWidgetElement.SplitBy.Displayed() && tableRow.ContainsKey("SplitBy")
                                                        && !string.IsNullOrEmpty(tableRow["SplitBy"]))
            {
                createWidgetElement.SelectSplitByItem(tableRow["SplitBy"]);
            }

            if (createWidgetElement.AggregateFunction.Displayed() && tableRow.ContainsKey("AggregateFunction")
                                                                  && !string.IsNullOrEmpty(tableRow["AggregateFunction"]))
            {
                createWidgetElement.AggregateFunction.Click();
                createWidgetElement.SelectObjectForWidgetCreation(tableRow["AggregateFunction"]);
                _driver.WaitForDataLoadingOnProjects();
            }

            if (createWidgetElement.AggregateBy.Displayed() && tableRow.ContainsKey("AggregateBy")
                                                            && !string.IsNullOrEmpty(tableRow["AggregateBy"]))
            {
                createWidgetElement.AggregateBy.Click();
                createWidgetElement.SelectObjectForWidgetCreation(tableRow["AggregateBy"]);
                _driver.WaitForDataLoadingOnProjects();
            }

            if (createWidgetElement.OrderBy.Displayed() && tableRow.ContainsKey("OrderBy")
                                                        && !string.IsNullOrEmpty(tableRow["OrderBy"]))
            {
                createWidgetElement.OrderBy.Click();
                createWidgetElement.SelectObjectForWidgetCreation(tableRow["OrderBy"]);
                _driver.WaitForDataLoadingOnProjects();
            }

            if (createWidgetElement.MaxValues.Displayed() && tableRow.ContainsKey("MaxValues")
                                                          && !string.IsNullOrEmpty(tableRow["MaxValues"]))
            {
                createWidgetElement.MaxValues.Clear();
                createWidgetElement.MaxValues.SendKeys(tableRow["MaxValues"]);
            }

            if (createWidgetElement.TableOrientation.Displayed() && tableRow.ContainsKey("TableOrientation"))
            {
                createWidgetElement.TableOrientation.Click();
                createWidgetElement.SelectObjectForWidgetCreation(tableRow["TableOrientation"]);
                _driver.WaitForDataLoadingOnProjects();
            }

            if (createWidgetElement.MaxRows.Displayed() && tableRow.ContainsKey("MaxRows"))
            {
                createWidgetElement.MaxRows.Clear();
                createWidgetElement.MaxRows.SendKeys(tableRow["MaxRows"]);
            }

            if (createWidgetElement.MaxColumns.Displayed() && tableRow.ContainsKey("MaxColumns"))
            {
                createWidgetElement.MaxColumns.Clear();
                createWidgetElement.MaxColumns.SendKeys(tableRow["MaxColumns"]);
            }

            if (createWidgetElement.ShowLegend.Displayed() && tableRow.ContainsKey("ShowLegend")
                                                           && !string.IsNullOrEmpty(tableRow["ShowLegend"]))
            {
                createWidgetElement.ShowLegend.Click();

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
            createWidgetElement.Title.Clear();
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
            createWidgetElement.SelectSplitByItem(SplitBy);
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
                Utils.Verify.IsTrue(_driver.IsElementExists(innerColour), "Colour item is not found");
            }
            var page = _driver.NowAt<BaseGridPage>();
            page.BodyContainer.Click();
        }

        [Then(@"Colour Scheme dropdown is not displayed to the user")]
        public void ThenColourSchemeDropdownIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsFalse(page.ColorScheme.Displayed(), "Colour Scheme dropdown is displayed to the user");
        }

        [Then(@"Color Scheme dropdown displayed with ""(.*)"" placeholder")]
        public void ThenColourSchemeHasCorrectPlaceholder(string placeholder)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.ColorSchemePlaceholder.Text, Is.EqualTo(placeholder), "Colour Scheme dropdown is displayed with wrong placeholder");
        }

        [Then(@"Table widget displayed inside preview pane correctly")]
        public void ThenTableWidgetDisplayedInsidePreviewPane()
        {
            var preview = _driver.NowAt<AddWidgetPage>();
            int prevWidth = preview.WidgetPreview.Size.Width;

            var widget = _driver.NowAt<AddWidgetPage>();
            int widgetWidth = widget.GetTableWidgetPreview().Size.Width;

            Utils.Verify.That(widgetWidth > prevWidth * 0.85 && widgetWidth < prevWidth, Is.True, "Widget preview less than 85 percent preview box");
        }
    
        [Then(@"Widget title ""(.*)"" is displayed on Widget page")]
        public void ThenWidgetTitleDisplayedOnThePage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.AreEqual(text, page.Title.GetAttribute("innerHTML"), "Widget title is not the same");
        }

        [Then(@"Error message with ""(.*)"" text is displayed on Widget page")]
        public void ThenErrorMessageWithTextIsDisplayedOnTheBucketsPage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.ErrorMessage);
            Utils.Verify.AreEqual(text, page.ErrorMessage.Text, "Error Message is not displayed");
        }

        [Then(@"Unsaved Changes alert not displayed to the user")]
        public void ThenNoUnsavedChangesAlertDisplayedOnEditWidgetPage()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeNotDisplayed(page.UnsavedChangesAlert);
            Utils.Verify.IsFalse(_driver.IsElementDisplayed(page.UnsavedChangesAlert), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"User sees ""(.*)"" text in alert on Edit Widget page")]
        public void ThenUserSeesTextInAlertOnEditWidgetPage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeDisplayed(page.UnsavedChangesAlert);
            Utils.Verify.AreEqual(text, page.GetUnsavedChangesAlertText().Text, "PLEASE ADD EXCEPTION MESSAGE");
        }
 
        [Then(@"User sees following options for Order By selector on Create Widget page:")]
        public void WhenUserSeesFollowingOptionsForOrderBySelectorOnCreateWidgetPage(Table items)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.OrderBy.Click();
            Thread.Sleep(1000);

            Utils.Verify.AreEqual(items.Rows.SelectMany(row => row.Values).ToList(),
                page.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
            //close expanded list
            page.OrderBy.SendKeys(OpenQA.Selenium.Keys.Escape);

            //Actions action = new Actions(driver);
            //action.SendKeys(OpenQA.Selenium.Keys.Escape);
        }

        [Then(@"User sees ""(.*)"" option for Order By selector on Create Widget page")]
        public void WhenUserSeesFollowingOptionForOrderBySelectorOnCreateWidgetPage(string option)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.AreEqual(page.OrderBy.Text, option, "Incorrect option in OrderBy dropdown");
        }

        [Then(@"""(.*)"" checkbox is checked on the Create Widget page")]
        public void ThenCheckboxIsCheckedOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.GetDashboardCheckboxByName(checkboxName).GetAttribute("class").Contains("checked"),
                "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"""(.*)"" checkbox is not displayed on the Create Widget page")]
        public void ThenCheckboxIsNotDisplayedOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.IsFalse(page.GetCheckboxByName(checkboxName), $"{checkboxName} checkbox is displayed");
        }

        [Then(@"User sees ""(.*)"" warning text below Lists field")]
        public void ThenUserSeesWarningTextBelowListsField(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.AreEqual(text, page.WarningTextUnderField.Text, "PLEASE ADD EXCEPTION MESSAGE");
        }
        
        [Then(@"Aggregate Function dropdown is placed above the Aggregate By dropdown")]
        public void ThenUserSeesAggregateFunctionAboveTheAggregateByDropdown()
        {
            var page = _driver.NowAt<AddWidgetPage>();

            Utils.Verify.That(page.AggregateFunction.Location.Y, Is.LessThan(page.AggregateBy.Location.Y));
        }

        [Then(@"""(.*)"" dropdown is missing")]
        public void ThenSelectedDropdownIsMissing(string label)
        {
            var page = _driver.NowAt<AddWidgetPage>();

            Utils.Verify.That(page.Dropdowns.Any(x=>x.Text.Equals(label)), Is.EqualTo(false));
        }

        [Then(@"Aggregate By dropdown is disabled")]
        public void ThenSelectedDropdownIsMissing()
        {
            var page = _driver.NowAt<AddWidgetPage>();

            Assert.That(page.IsAggregateByDropdownDisabled, Is.EqualTo(true), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"Color Scheme dropdown is disabled")]
        public void ThenColorSchemeDropdownIsDisabled()
        {
            var page = _driver.NowAt<AddWidgetPage>();

            Assert.That(page.IsColorSchemeDropdownDisabled, Is.EqualTo(true), "Color Scheme dropdown displayed enabled");
        }

        [Then(@"User sees following options for Aggregate By selector on Create Widget page:")]
        public void WhenUserSeesFollowingOptionsForAggregateBySelectorOnCreateWidgetPage(Table items)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.AggregateBy.Click();

            Utils.Verify.AreEqual(items.Rows.SelectMany(row => row.Values).ToList(),
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
                    Utils.Verify.That(page.ShowLegendLabel.Text, Is.EqualTo("Show legend"), "Show legend label wrong");
                    break;
                case "Show data labels":
                    Utils.Verify.That(page.ShowDataLabel.Text, Is.EqualTo("Show data labels"), "Show data labels label wrong");
                    break;

                default:
                    Utils.Verify.IsTrue(false, "Wrong checkbox specified");
                    break;
            }
        }
      
        [Then(@"Text Only is displayed for Card widget on Preview")]
        public void ThenTextOnlyIsDisplayedForCardWidgetOnPreview()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.TextOnlyCardWidget.Displayed(), "Text Only is not displayed for Card widget");
        }

        [Then(@"Icon and Text is displayed for Card widget on Preview")]
        public void ThenIconAndTextIsDisplayedForCardWidgetOnPreview()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.IconAndTextCardWidget.Displayed(), "Icon and Text is not displayed for Card widget");
        }

        [Then(@"Icon Only is displayed for Card widget on Preview")]
        public void ThenIconOnlyIsDisplayedForCardWidgetOnPreview()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.IconOnlyCardWidget.Displayed(), "Icon Only is not displayed for Card widget");
        }

        [Then(@"Widget Preview is displayed to the user")]
        public void ThenWidgetPreviewIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.WidgetPreview.Displayed(), "Widget Preview is not displayed");
        }

        [Then(@"Widget Preview is not displayed to the user")]
        public void ThenWidgetPreviewIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.IsTrue(page.WidgetPreviewEmpty.Displayed(), "Widget Preview displayed not empty");
        }

        [Then(@"Card widget displayed inside preview pane")]
        public void ThenCardWidgetDisplayedInsidePreviewPane()
        {
            var preview = _driver.NowAt<AddWidgetPage>();
            int prevWidth = preview.WidgetPreview.Size.Width;
            int prevX = preview.WidgetPreview.Location.X;
            int prevY = preview.WidgetPreview.Location.Y;

            var widget = _driver.NowAt<AddWidgetPage>();
            int widgetWidth = widget.GetCardWidgetPreviewText().Size.Width;
            int widgetX = widget.GetCardWidgetPreviewText().Location.X;
            int widgetY = widget.GetCardWidgetPreviewText().Location.Y;

            Utils.Verify.That(prevX < widgetX && prevY < widgetY, Is.True, "Widget XY coordinate displayed outside preview box");
            Utils.Verify.That(prevWidth > widgetWidth, Is.True, "Widget width displayed outside preview box");
        }

        [Then(@"""(.*)"" color is displayed for Card Widget on Preview")]
        public void ThenColorIsDisplayedForCardWidgetOnPreview(string color)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            var getColor = page.GetCardWidgetPreviewText().GetCssValue("color");
            Utils.Verify.AreEqual(ColorWidgetConvertor.ConvertComplianceColorWidget(color), getColor, $"{color} color is displayed for widget");
        }

        [Then(@"'(.*)' message is displayed in Preview")]
        public void ThenEmptyMessageTextDisplayedInPreview(string message)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.That(page.PreviewPaneMessageText.Text, Is.EqualTo(message), "Preview message is different.");
        }

        [Then(@"'(.*)' alert is displayed in Preview")]
        public void ThenAlertTestDisplayedInPreview(string message)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.That(page.PreviewPaneAlertText.Text, Is.EqualTo(message), "Preview alert is different.");
        }

        [When(@"User clicks first Dashboard in dashboards list")]
        public void WhenUserClickFirstDashboardInDashboardsList()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.GetFirstDashboardFromList().Click();
        }

        [Then(@"Data Labels are displayed on the Preview page")]
        public void ThenDataLabelsAreDisplayedOnThePreviewPage()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.DataLabels.Displayed(), "Data Labels are not displayed");
        }

        [Then(@"""(.*)"" data label is displayed on the Preview page")]
        public void ThenDataLabelIsDisplayedOnThePreviewPage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.That(page.DataLabels.Text, Is.EqualTo(text), $"{text} data label is not displayed");
        }

        [Then(@"Widget Preview shows ""(.*)"" as First Cell value")]
        public void ThenWidgetPreviewShowsAsFirstCellValue(string option)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.That(page.GetCardWidgetPreviewText().Text, Is.EqualTo(option), "Widget Preview shown different value");
        }

        [Then(@"'(.*)' option displayed for Widget OrderBy")]
        public void ThenTheNextOptionDisplayedForWidgetOrderBy(string option)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Utils.Verify.That(page.GetOrderBySelectedOption(), Is.EqualTo(option), $"DDL has wrong option selected {page.GetOrderBySelectedOption()}");
        }
    }
}