using System;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.Dashboards;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_WidgetPage : BaseWidgetPage
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
            //This method is just for one TableRow
            PopulateWidgetData(table.Rows.First());
        }

        [When(@"User updates Widget with following info:")]
        public void WhenUserUpdateNewWidget(Table table)
        {
            CreateUpdateWidget(table, false);
        }

        [When(@"User creates new Widget")]
        public void WhenUserCreatesNewWidget(Table table)
        {
            CreateUpdateWidget(table, true);
        }

        private void PopulateWidgetData(TableRow row)
        {
            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();

            baseActionItem.SelectDropdown(row["WidgetType"], "WidgetType");

            if (string.IsNullOrEmpty(row["Title"]))
                baseActionItem.PopulateTextbox("Title", " ");

            if (!string.IsNullOrEmpty(row["Title"]))
            {
                baseActionItem.PopulateTextbox("Title", row["Title"]);
            }

            if (row.ContainsKey("List") && !string.IsNullOrEmpty(row["List"]))
            {
                baseActionItem.AutocompleteSelect("List", row["List"], true);
            }

            if (row.ContainsKey("Type") && !string.IsNullOrEmpty(row["Type"]))
            {
                baseActionItem.SelectDropdown(row["Type"], "Type");
            }

            if (row.ContainsKey("SplitBy") && !string.IsNullOrEmpty(row["SplitBy"]))
            {
                createWidgetElement.SelectSplitByItem(row["SplitBy"]);
            }

            if (row.ContainsKey("CategoriseBy") && !string.IsNullOrEmpty(row["CategoriseBy"]))
            {
                baseActionItem.SelectDropdown(row["CategoriseBy"], "CategoriseBy");
            }

            if (row.ContainsKey("DisplayType") && !string.IsNullOrEmpty(row["DisplayType"]))
            {
                baseActionItem.SelectDropdown(row["DisplayType"], "DisplayType");
            }

            if (row.ContainsKey("AggregateFunction") && !string.IsNullOrEmpty(row["AggregateFunction"]))
            {
                Thread.Sleep(500);
                baseActionItem.SelectDropdown(row["AggregateFunction"], "AggregateFunction");
            }

            if (row.ContainsKey("AggregateBy") && !string.IsNullOrEmpty(row["AggregateBy"]))
            {
                baseActionItem.SelectDropdown(row["AggregateBy"], "AggregateBy");
            }

            if (row.ContainsKey("OrderBy") && !string.IsNullOrEmpty(row["OrderBy"]))
            {
                baseActionItem.SelectDropdown(row["OrderBy"], "OrderBy");
            }

            if (row.ContainsKey("MaxValues") && !string.IsNullOrEmpty(row["MaxValues"]))
            {
                baseActionItem.PopulateTextbox("Max Values", row["MaxValues"], true);
            }

            if (row.ContainsKey("DrillDown") && !string.IsNullOrEmpty(row["DrillDown"]))
            {
                baseActionItem.SelectDropdown(row["DrillDown"], "Drilldown");
                _driver.WaitForDataLoadingOnProjects();
            }

            if (row.ContainsKey("TableOrientation") && !string.IsNullOrEmpty(row["TableOrientation"]))
            {
                baseActionItem.SelectDropdown(row["TableOrientation"], "TableOrientation");
                _driver.WaitForDataLoadingOnProjects();
            }

            if (row.ContainsKey("ShowLegend") && !string.IsNullOrEmpty(row["ShowLegend"])
                                              && row["ShowLegend"].Equals("true"))
            {
                createWidgetElement.ShowLegend.Click();
            }

            if (row.ContainsKey("ShowDataLabels") && !string.IsNullOrEmpty(row["ShowDataLabels"])
                                              && row["ShowDataLabels"].Equals("true"))
            {
                createWidgetElement.ShowDataLabel.Click();
            }

            if (row.ContainsKey("Layout") && !string.IsNullOrEmpty(row["Layout"]))
            {
                baseActionItem.SelectDropdown(row["Layout"], "Layout");
            }
        }

        private void CreateUpdateWidget(Table table, bool create)
        {
            foreach (var row in table.Rows)
            {
                PopulateWidgetData(row);
                var page = _driver.NowAt<BaseDashboardPage>();
                page.ClickButton(create ? "CREATE" : "UPDATE");
                _driver.WaitForDataLoading();
            }
        }

        #endregion

        [When(@"User enters '(.*)' as Widget Title")]
        public void WhenUserSetsWidgetTitle(string widgetTitle)
        {
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();
            baseActionItem.PopulateTextbox("Title", widgetTitle);
        }


        #region Color Scheme

        [When(@"User selects '(.*)' in the Colour Scheme")]
        public void WhenUserSelectsInTheColourScheme(string colorTitle)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            dropdown.GetDropdown("Colour Scheme").Click();

            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            createWidgetElement.GetColorFromColorScheme(colorTitle).Click();
        }


        [When(@"User selects the Colour Scheme by index '(.*)'")]
        public void SetColourSchemeByIndex(string index)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            dropdown.GetDropdown("Colour Scheme").Click();

            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeDisplayed(createWidgetElement.GetDropdownOptions().First());

            try
            {
                createWidgetElement.ClickColorSchemeByIndex(Convert.ToInt32(index));
            }
            catch (StaleElementReferenceException)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                createWidgetElement.ClickColorSchemeByIndex(Convert.ToInt32(index));
            }
        }

        [When(@"User selects the Colour Scheme by color code '(.*)'")]
        public void SetColorSchemeByColorCode(string code)
        {
            var dropdown = _driver.NowAt<BaseDashboardPage>();
            dropdown.GetDropdown("Colour Scheme").Click();

            _driver.WaitForDataLoading();

            var createWidgetElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeDisplayed(createWidgetElement.ColorSchemePartByCode(code));

            createWidgetElement.ClickColorSchemeByColorCode(code);
        }

        [Then(@"Colour Scheme dropdown is displayed to the user")]
        public void ThenColourSchemeDropdownIsDisplayedToTheUser()
        {
            var dropdownContainer = _driver.FindElements(By.XPath(AddWidgetPage.ColorSchemeDropdownContainer));
            foreach (var element in dropdownContainer)
            {
                var innerColour = element.FindElement(By.XPath(AddWidgetPage.ColorSchemeDropdownContent));
                Verify.IsTrue(_driver.IsElementExists(innerColour), "Colour item is not found");
            }
            var page = _driver.NowAt<BaseGridPage>();
             _driver.ClickByJavascript(page.BodyContainer);
        }

        [Then(@"Color Scheme dropdown displayed with '(.*)' placeholder")]
        public void ThenColourSchemeHasCorrectPlaceholder(string placeholder)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.ColorSchemePlaceholder.Text, Is.EqualTo(placeholder), "Colour Scheme dropdown is displayed with wrong placeholder");
        }

        #endregion


        [When(@"User selects '(.*)' checkbox on the Create Widget page")]
        public void WhenUserSelectsCheckboxOnTheCreateWidgetPage(string checkboxName)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            page.GetDashboardCheckboxByName(checkboxName).Click();
        }

        [Then(@"Table widget displayed inside preview pane correctly")]
        public void ThenTableWidgetDisplayedInsidePreviewPane()
        {
            var preview = _driver.NowAt<AddWidgetPage>();
            int prevWidth = preview.WidgetPreview.Size.Width;

            var widget = _driver.NowAt<AddWidgetPage>();
            int widgetWidth = widget.GetTableWidgetPreview().Size.Width;

            Verify.That(widgetWidth > prevWidth * 0.85 && widgetWidth < prevWidth, Is.True, "Widget preview less than 85 percent preview box");
        }
     
        [Then(@"User sees following options for Order By selector on Create Widget page:")]
        public void WhenUserSeesFollowingOptionsForOrderBySelectorOnCreateWidgetPage(Table items)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();

            baseActionItem.GetDropdown("OrderBy").Click();

            Thread.Sleep(1000);

            Verify.AreEqual(items.Rows.SelectMany(row => row.Values).ToList(),
                page.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
            //close expanded list
            baseActionItem.GetDropdown("OrderBy").SendKeys(OpenQA.Selenium.Keys.Escape);
        }

        [Then(@"Aggregate Function dropdown is placed above the Aggregate By dropdown")]
        public void ThenUserSeesAggregateFunctionAboveTheAggregateByDropdown()
        {
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();

            Verify.That(baseActionItem.GetDropdown("AggregateFunction").Location.Y, Is.LessThan(baseActionItem.GetDropdown("AggregateBy").Location.Y));
        }

        [Then(@"User sees following options for Aggregate By selector on Create Widget page:")]
        public void WhenUserSeesFollowingOptionsForAggregateBySelectorOnCreateWidgetPage(Table items)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();

            baseActionItem.GetDropdown("AggregateBy").Click();
            Thread.Sleep(1000);

            Verify.AreEqual(items.Rows.SelectMany(row => row.Values).ToList(),
                page.GetDropdownOptions().Select(p => p.Text), "Incorrect options in lists dropdown");
        }

        [Then(@"Message saying that list is unavailable appears in Edit Widget page")]
        public void ThenMessageIsDisplayedInTheListsPanel()
        {
            var listElement = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeDisplayed(listElement.ListDoesNotExistMessage);
        }

        [Then(@"'(.*)' checkbox has a correct label")]
        public void ThenCheckboxLabelDisplayedOnForm(string checkbox)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForElementToBeDisplayed(page.ShowLegend);

            switch (checkbox)
            {
                case "Show legend":
                    Verify.That(page.ShowLegendLabel.Text, Is.EqualTo("Show legend"), "Show legend label wrong");
                    break;
                case "Show data labels":
                    Verify.That(page.ShowDataLabel.Text, Is.EqualTo("Show data labels"), "Show data labels label wrong");
                    break;

                default:
                    Verify.IsTrue(false, "Wrong checkbox specified");
                    break;
            }
        }

        [Then(@"Text Only is displayed for Card widget on Preview")]
        public void ThenTextOnlyIsDisplayedForCardWidgetOnPreview()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.TextOnlyCardWidget.Displayed(), "Text Only is not displayed for Card widget");
        }

        [Then(@"Icon and Text is displayed for Card widget on Preview")]
        public void ThenIconAndTextIsDisplayedForCardWidgetOnPreview()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.IconAndTextCardWidget.Displayed(), "Icon and Text is not displayed for Card widget");
        }

        [Then(@"Icon Only is displayed for Card widget on Preview")]
        public void ThenIconOnlyIsDisplayedForCardWidgetOnPreview()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.IconOnlyCardWidget.Displayed(), "Icon Only is not displayed for Card widget");
        }

        [Then(@"Widget Preview is displayed to the user")]
        public void ThenWidgetPreviewIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.WidgetPreview.Displayed(), "Widget Preview is not displayed");
        }

        [Then(@"Widget Preview is not displayed to the user")]
        public void ThenWidgetPreviewIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Verify.IsTrue(page.WidgetPreviewEmpty.Displayed(), "Widget Preview displayed not empty");
        }

        [Then(@"Card widget displayed inside preview pane")]
        public void ThenCardWidgetDisplayedInsidePreviewPane()
        {
            var preview = _driver.NowAt<AddWidgetPage>();
            int prevWidth = preview.WidgetPreview.Size.Width;
            int prevX = preview.WidgetPreview.Location.X;
            int prevY = preview.WidgetPreview.Location.Y;

            var widget = _driver.NowAt<AddWidgetPage>();
            int widgetWidth = widget.GetWidgetPreviewText().Size.Width;
            int widgetX = widget.GetWidgetPreviewText().Location.X;
            int widgetY = widget.GetWidgetPreviewText().Location.Y;

            Verify.That(prevX < widgetX && prevY < widgetY, Is.True, "Widget XY coordinate displayed outside preview box");
            Verify.That(prevWidth > widgetWidth, Is.True, "Widget width displayed outside preview box");
        }

        [Then(@"'(.*)' color is displayed for Card Widget on Preview")]
        public void ThenColorIsDisplayedForCardWidgetOnPreview(string color)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            var getColor = page.GetWidgetPreviewText().GetCssValue("color");
            Verify.AreEqual(ColorWidgetConvertor.ConvertComplianceColorWidget(color), getColor, $"{color} color is displayed for widget");
        }

        [Then(@"'(.*)' message is displayed in Preview")]
        public void ThenEmptyMessageTextDisplayedInPreview(string message)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Verify.That(page.PreviewPaneMessageText.Text, Is.EqualTo(message), "Preview message is different.");
        }

        [Then(@"'(.*)' alert is displayed in Preview")]
        public void ThenAlertTestDisplayedInPreview(string message)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Verify.That(page.PreviewPaneAlertText.Text, Is.EqualTo(message), "Preview alert is different.");
        }

        [Then(@"Data Labels are displayed on the Preview page")]
        public void ThenDataLabelsAreDisplayedOnThePreviewPage()
        {
            var page = _driver.NowAt<BaseWidgetPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(page.DataLabels.Displayed(), "Data Labels are not displayed");
        }

        [Then(@"Data Legends values are displayed on the Add Widget page")]
        public void ThenDataLegendsValuesAreDisplayedOnTheAddWidgetPage(Table table)
        {
            var page = _driver.NowAt<BaseWidgetPage>();
            _driver.WaitForDataLoading();
            var expectedLabels = table.Rows.Select(x => x.Values).Select(x => x.FirstOrDefault());
            var actualLables = page.GetWidgetLabels(string.Empty).Select(x => x.Text).ToList();

            Verify.AreEqual(expectedLabels, actualLables, $"The label(s) was not found'");
        }

        [Then(@"'(.*)' data label is displayed on the Preview page")]
        public void ThenDataLabelIsDisplayedOnThePreviewPage(string text)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            _driver.WaitForDataLoading();
            Verify.That(page.DataLabels.Text, Is.EqualTo(text), $"{text} data label is not displayed");
        }

        [Then(@"Widget Preview shows '(.*)' as First Cell value")]
        public void ThenWidgetPreviewShowsAsFirstCellValue(string option)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Verify.That(page.GetWidgetPreviewText().Text, Is.EqualTo(option), "Widget Preview shown different value");
        }

        [Then(@"'(.*)' option displayed for Widget OrderBy")]
        public void ThenTheNextOptionDisplayedForWidgetOrderBy(string option)
        {
            var page = _driver.NowAt<AddWidgetPage>();
            Verify.That(page.GetOrderBySelectedOption(), Is.EqualTo(option), $"DDL has wrong option selected {page.GetOrderBySelectedOption()}");
        }

        [Then(@"List dropdown has next item categories:")]
        public void ThenListDdlHasNextItemCategories(Table items)
        {
            var baseActionItem = _driver.NowAt<BaseDashboardPage>();
            baseActionItem.GetTextbox("List").Click();

            var page = _driver.NowAt<AddWidgetPage>();
            var actualItems = page.GetMainCategoriesOfListDDL().Select(x => x.Text).ToList();
            var expectedItems = items.Rows.SelectMany(row => row.Values).ToList();

            for (int i = 0; i < expectedItems.Count; i++)
            {
                Verify.That(actualItems[i].StartsWith(expectedItems[i]), Is.True,
                                  $"List has wrong items/order at {actualItems[i]}");
            }
            Verify.That(actualItems.Count, Is.EqualTo(expectedItems.Count), $"Lists item count is different");
        }

        [When(@"User clicks on '(.*)' category of '(.*)' widget")]
        public void WhenUserClicksOnCategoryOfWidget(string category, string widgetName)
        {
            var page = _driver.NowAt<EvergreenDashboardsPage>();

            _driver.ExecuteAction(() => page.GetWidgetChartItem(widgetName, category).Click());
        }

        [When(@"User move '(.*)' widget to '(.*)' widget")]
        public void WhenUserMoveWidgetToWidget(string widgetName, string widgetNameToMove)
        {
            var page = _driver.NowAt<BaseWidgetPage>();
            _driver.DragAndDrop(page.GetWidgetDragAndDropElement(widgetName),
                page.GetWidget(widgetNameToMove));
        }
    }
}