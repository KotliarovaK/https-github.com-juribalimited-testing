using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.RightSideActionPanels;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using RestSharp.Extensions;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_BaseDashboardPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ListsDetails _listDetails;
        private readonly ColumnValue _columnValue;

        public EvergreenJnr_BaseDashboardPage(RemoteWebDriver driver, ListsDetails listsDetails, ColumnValue columnValue)
        {
            _driver = driver;
            _listDetails = listsDetails;
            _columnValue = columnValue;
        }

        [When(@"User navigate to the bottom of the Action panel")]
        public void WhenUserNavigateToTheBottomOfTheActionPanel()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            //TODO: 27Aug2019 Yurii: changed to moveTo
            //_driver.DragAndDrop(page.ActionsScrollBar, page.UpdateButton);
            _driver.MoveToElement(page.UpdateButton);
            Thread.Sleep(2000);
        }

        [When(@"User navigate to the top of the Action panel")]
        public void WhenUserNavigateToTheTopOfTheActionPanel()
        {
            var page = _driver.NowAt<ActionsPanelElement>();
            //TODO: 27Aug2019 replaced drag and drop to moveTo
            //_driver.DragAndDrop(page.ActionsScrollBar, page.ActionsRowsCount);
            _driver.MoveToElement(page.RowsCount);
            Thread.Sleep(2000);
        }

        [Then(@"User sees context menu placed near ""(.*)"" cell in the grid")]
        public void ThenUserSeesContextMenuPlacedNearCellInTheGrid(string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            var cellTopYCoordinte = page.GetGridCellByText(columnName).Location.Y;
            var cellBottomYCoordinte = page.GetGridCellByText(columnName).BottomLocation().Y;
            var cellLeftXCoordinte = page.GetGridCellByText(columnName).BottomLocation().X;
            var cellRightXCoordinte = page.GetGridCellByText(columnName).RightTopLocation().X;

            var menuTopYCoordinate = page.AgMenu.Location.Y;
            var manuLeftXCoordinate = page.AgMenu.Location.X;

            Verify.That(menuTopYCoordinate, Is.GreaterThan(cellTopYCoordinte));
            Verify.That(menuTopYCoordinate, Is.LessThan(cellBottomYCoordinte));
            Verify.That(manuLeftXCoordinate, Is.GreaterThan(cellLeftXCoordinte));
            Verify.That(manuLeftXCoordinate, Is.LessThan(cellRightXCoordinte));
        }

        [Then(@"User sees context menu with next options")]
        public void ThenUserSeesContextMenuPlacedNearCellInTheGrid(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            List<string> options = page.AgMenuOptions.Select(x => x.Text).ToList();

            foreach (var row in table.Rows)
            {
                Verify.That(options.FindAll(x => x.Equals(row["OptionsName"])).Count == 1, "PLEASE ADD EXCEPTION MESSAGE");
            }
            Verify.That(options.Count, Is.EqualTo(table.Rows.Count));
        }

        [When(@"User selects '(.*)' option in context menu")]
        public void WhenUserClickOptionInContextMenu(string option)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();

            page.AgMenuOptions.FirstOrDefault(x => x.Text.Equals(option))?.Click();
        }

        [Then(@"Next data '(.*)' is copied")]
        public void ThenUserCopiedNextDataToClipboard(string data)
        {
            var searchElement = _driver.NowAt<GlobalSearchElement>();
            _driver.WaitForDataLoading();

            _driver.InsertFromClipboard(searchElement.SearchEverythingField);

            Verify.That(searchElement.SearchEverythingField.GetAttribute("value").Replace("\t", "   ").Trim(),
                Is.EqualTo(data.Replace(@"\t", "   ")));
        }

        [Then(@"""(.*)"" tooltip displayed in ""(.*)"" column")]
        public void ThenTooltipIsDisplayedInColumn(string textTooltip, string columnName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var cellElement = page.GetGridCellByText(textTooltip);
            _driver.MouseHover(cellElement);
            var tooltip = _driver.GetTooltipBubbleText();
            Verify.AreEqual(textTooltip.ToLower(), tooltip.ToLower(), "Tooltip is not displayed correctly");
        }

        [Then(@"""(.*)"" content is displayed for ""(.*)"" column")]
        public void ThenContentIsDisplayedForColumn(string textContent, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            //TODO: below code will take first cell in column, this is used instead of removed method that
            //took content from first cell, should be refactored later
            var firstColumnCell = page.GetColumnContentByColumnName(columnName).FirstOrDefault();
            Verify.AreEqual(textContent, firstColumnCell, "Content is not displayed correctly");
        }

        [Then(@"""(.*)"" italic content is displayed")]
        public void ThenItalicContentIsDisplayed(string textContent)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(page.GetItalicContentByColumnName(textContent).Displayed, "Content is not styled in italic or not displayed");
        }

        [Then(@"full list content is displayed to the user")]
        public void ThenFullListContentIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForElementToBeDisplayed(page.TableContent);
            Utils.Verify.IsTrue(page.TableRows.Count > 5, "Table is empty");
        }

        [Then(@"User sees ""(.*)"" rows in grid")]
        public void ThenUserSeesRowsInGrid(int rowsCount)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.TableContent);
            Verify.That(page.TableRows.Count, Is.EqualTo(rowsCount));
        }

        [Then(@"Evergreen Icon is displayed to the user")]
        public void ThenEvergreenIconIsDisplayedToTheUser()
        {
            _driver.WaitForDataLoading();
            var content = _driver.FindElements(By.XPath(BaseDashboardPage.ColumnWithEvergreenIconSelector));
            foreach (var element in content)
            {
                var evergreenIcon = element.FindElement(By.XPath(BaseDashboardPage.ImageSelector));
                Verify.IsTrue(_driver.IsElementExists(evergreenIcon), "Evergreen Icon is not found");
            }
        }

        [Then(@"table content is present")]
        public void ThenTableContentIsPresent()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            var rows = page.TableRows;
            foreach (var row in rows)
            {
                Utils.Verify.That(row.FindElement(By.XPath(BaseDashboardPage.GridCell)).Displayed, Is.True);
            }
        }

        [Then(@"Appropriate header font weight is displayed")]
        public void ThenAppropriateHeaderFontWeightIsDisplayed()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.AreEqual("400", dashboardPage.GetHeaderFontWeight(), "Header font weight is incorrect");
        }

        [Then(@"URL is ""(.*)""")]
        public void ThenURLIs(string urlPart)
        {
            var expectedUrl = $"{UrlProvider.Url}{urlPart}";
            Utils.Verify.AreEqual(expectedUrl, _driver.Url, $"URL is not {expectedUrl}");
        }

        [Then(@"URL contains ""(.*)""")]
        public void ThenURLContains(string url)
        {
            Utils.Verify.Contains(url, _driver.Url, $"URL is not contains {url}");
        }

        [Then(@"URL contains only ""(.*)"" filter")]
        public void ThenURLContainsOnly(string urlFilterExpected)
        {
            string url = _driver.Url;
            url = url.Substring(url.IndexOf("?") + 1);
            string[] filterInUrl = url.Split('$');

            foreach (var filter in filterInUrl)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    Utils.Verify.Contains(urlFilterExpected, filter, $"URL is not contains {filter}");
                }
            }
        }

        [Then(@"""(.*)"" text is displayed in filter container")]
        public void ThenTextIsDisplayedInFilterContainer(string text)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            _driver.MoveToElement(page.FilterOptions);
            _driver.WaitForElementToBeDisplayed(page.FilterOptions);
            if (!_driver.IsElementDisplayed(page.FilterContainer)) page.FilterContainerButton.Click();
            Utils.Verify.AreEqual(text, page.FilterContainer.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

        [When(@"User closes filter container")]
        [When(@"User opens filter container")]
        public void WhenUserOpensFilterContainer()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.FilterContainerButton.Click();
        }

        [Then(@"""(.*)"" text is displayed in filter container for ""(.*)"" list name")]
        public void ThenTextIsDisplayedInFilterContainerForListName(string text, string listName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.AreEqual(text.Replace("{LIST_ID}", _listDetails.GetListIdByName(listName)),
                page.FilterContainer.Text.TrimStart(' ').TrimEnd(' '),
                "Filter is created incorrectly");
        }

        [Then(@"String filter values are not duplicated")]
        public void ThenStringFilterValuesAreNotDuplicated()
        {
            var grid = _driver.NowAt<BaseDashboardPage>();
            var filtersValue = grid.StringFilterValues.Select(x => x.Text).ToList();
            Verify.AreEqual(filtersValue.Distinct().Count(), filtersValue.Count(), "String filters value are duplicated");
        }

        [Then(@"User sees following text in cell truncated with ellipsis:")]
        public void ThenUserSeesFollowingTextInCellTruncatedWithEllipsis(Table table)
        {
            var grid = _driver.NowAt<BaseDashboardPage>();
            foreach (var column in table.Rows)
            {
                var cell = grid.GetGridCellByText(column["cellText"]);

                Verify.That(cell.GetCssValue("text-overflow"), Is.EqualTo("ellipsis"), "Data in cell not truncated");
                Verify.That(cell.GetCssValue("overflow"), Is.EqualTo("hidden"), "Data in cell not truncated");
            }
        }

        [When(@"User clicks Close panel button")]
        public void WhenUserClicksClosePanelButton()
        {
            var button = _driver.NowAt<BaseDashboardPage>();
            button.ClosePanelButton.Click();
        }

        [When(@"User remembers value in ""(.*)"" column")]
        public void WhenUserRemembersValueInSpecificColumn(string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _columnValue.Value = page.GetColumnContentByColumnName(columnName).First();
        }

        [Then(@"Rows counter number equals to remembered value")]
        public void ThenUserRememberedValueEqualsToGridCounter()
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            //We need this wait for grid to be updated
            //TODO replace my something more smart
            Thread.Sleep(1000);
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(foundRowsCounter.ListRowsCounter);

            string rememberedNumber = _columnValue.Value;

            Verify.AreEqualIgnoringCase(rememberedNumber == "1" ? $"{rememberedNumber} row" : $"{rememberedNumber} rows",
                foundRowsCounter.ListRowsCounter.Text.Replace(",", ""), "Incorrect rows count");
        }

        [Then(@"Error is displayed to the User")]
        public void ThenErrorIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsTrue(page.ErrorBox.Displayed(), "Error is displayed");
        }

        [When(@"User navigates to ""(.*)"" URL in a new tab")]
        public void WhenUserNavigatesToURLInANewTab(string urlParameters)
        {
            _driver.OpenInNewTab($"{UrlProvider.Url}{urlParameters}");
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        }

        [When(@"User switches to previous tab")]
        public void WhenUserSwitchesToPreviousTab()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.First());
        }

        [Then(@"Warning Pop-up is displayed to the User")]
        public void ThenWarningPop_UpIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsTrue(page.WarningPopUpPanel.Displayed(), "Warning Pop-up is not displayed");
        }

        [When(@"User clicks ""(.*)"" button in the Warning Pop-up message")]
        public void WhenUserClicksButtonInTheWarningPop_UpMessage(string buttonName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.GetButtonInWarningPopUp(buttonName).Click();
        }
    }
}