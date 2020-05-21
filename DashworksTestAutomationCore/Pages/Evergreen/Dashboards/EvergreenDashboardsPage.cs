using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Dashboards
{
    internal class EvergreenDashboardsPage : BaseWidgetPage
    {
        #region Header

        [FindsBy(How = How.XPath, Using = ".//mat-slide-toggle")]
        public IWebElement EditModeOnOffTrigger { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-slide-toggle-bar']")]
        public IWebElement EditModeSlideBar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-slide-toggle-thumb']")]
        public IWebElement EditModeSlideToggle { get; set; }

        #endregion

        #region Dashboards Panel

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenu']")]
        public IWebElement DashboardsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenuBlock']//*[starts-with(@class, 'inline-tip')]")]
        public IWebElement DashboardsAlert { get; set; }

        #endregion

        #region Dashboard Area

        [FindsBy(How = How.XPath, Using = ".//span[text()='Hide section']/ancestor::label")]
        public IWebElement SectionHideSectionCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-menu-item')]")]
        public IList<IWebElement> EllipsisMenuItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'section-edit-block')]//i[contains(@class,'arrow')]")]
        public IList<IWebElement> AllCollapseExpandSectionsArrows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'section-edit-block')]")]
        public IList<IWebElement> AllSections { get; set; }

        public IWebElement AlertButton(string buttonName) =>
            Driver.FindElement(By.XPath($".//div[contains(@class,'delete-alert') and not(@hidden)]//span[text()='{buttonName}']"));

        public IWebElement TextInDeleteAlert(string widgetName)
        {
            try
            {
                return Driver.FindElement(By.XPath(
                    $".//div[starts-with(text(), '{widgetName}')]/ancestor::div[contains(@class,'widget-delete-alert')]/preceding::div[contains(@class,'widget-delete-alert')][1]//div[@class='inline-box-text']"));
            }
            catch
            {
                return Driver.FindElement(By.XPath(
                    $".//div[starts-with(text(), '{widgetName}')]/ancestor::div[contains(@class,'widget-delete-alert')]//div[@class='inline-box-text']"));
            }
        }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert')]//a[@href]")]
        public IWebElement LinkInWarningMessage { get; set; }

        #endregion

        #region Widget

        [FindsBy(How = How.XPath, Using = ".//div[@class='widgets']//h5")]
        public IList<IWebElement> AllWidgetsTitles { get; set; }

        #endregion

        #region Dashboard Details

        [FindsBy(How = How.XPath, Using = ".//input[@id='DashboardName']")]
        public IWebElement DetailsDashboardName { get; set; }

        //TODO looks like generic element and should be moved to BaseDashboardPage
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'dependants')]//button")]
        public IWebElement DetailsExpandListsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'dependants')]//table//tr[1]/td")]
        public IList<IWebElement> DetailsSharedListTableHeaders { get; set; }

        public IWebElement GetListIconFromListSectionOfDetailsPanel(string listName)
        {
            var by = By.XPath($".//td[text()='{listName}']/following-sibling::td/i");
            return Driver.FindElement(by);
        }

        #endregion

        #region Review widget permission

        [FindsBy(How = How.XPath, Using = ".//div[text()='Review Widget List Permissions']")]
        public IWebElement ReviewWidgetListPermissionsPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='mat-option-text']")]
        public IList<IWebElement> ReviewWidgetListPermissionExpandedOptions { get; set; }

        #endregion

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }

        #region HeaderMethods

        public IWebElement GetTopBarActionButton(string buttonName)
        {
            var page = By.XPath($".//div[@class='action-container']/button//i[text()='{buttonName.ToLower()}']");
            Driver.WaitForDataLoading();
            return Driver.FindElement(page);
        }

        public string GetEditModeSlideBarColor()
        {
            return EditModeSlideBar.GetCssValue("background-color");
        }

        public string GetEditModeSlideToggleColor()
        {
            return EditModeSlideToggle.GetCssValue("background-color");
        }

        public bool GetEditModeState()
        {
            return EditModeOnOffTrigger.GetAttribute("class").Contains("checked");
        }

        #endregion

        #region Details Panel Methods

        public bool IsDashboardMarkedAsFavoriteInList(string dashboardName)
        {
            var starIcon =
                $".//span[text()='{dashboardName}']/preceding-sibling::span//i[@class='material-icons mat-star']";

            return Driver.FindElements(By.XPath(starIcon)).Count == 1;
        }

        public bool IsDashboardMarkedAsDefaultInList(string dashboardName)
        {
            var starIcon =
                $".//span[text()='{dashboardName}']/preceding-sibling::span//i[@class='material-icons mat-home']";

            return Driver.FindElements(By.XPath(starIcon)).Count == 1;
        }

        public void SelectDoNotChangeReviewPermission()
        {
            Driver.FindElement(By.XPath(".//span[@class='mat-option-text'][contains(text(), 'Do not change')]")).Click();
        }

        public IWebElement NewPermissionsDropdownForList(string listName)
        {
            return Driver.FindElement(By.XPath($".//td[contains(text(), '{listName}')]/parent::tr//mat-select[@aria-label='New Permissions']"));
        }

        public IWebElement CurrentPermissionValueForList(string listName)
        {
            return Driver.FindElement(By.XPath($".//td[contains(text(), '{listName}')]/parent::tr//td[contains(@class, 'sharedAccessType')]"));
        }

        public IWebElement NewPermissionsValueForList(string listName)
        {
            return Driver.FindElement(By.XPath($".//td[contains(text(), '{listName}')]/parent::tr//mat-select[@aria-label='New Permissions']//span[not (contains(@class, 'mat-select'))]"));
        }

        public string GetDropdownStateOfReviewWidgetPermissionsPopup(string listName)
        {
            return NewPermissionsDropdownForList(listName).GetAttribute("aria-disabled").ToString().ToUpper();
        }

        public IWebElement WidgetValueForList(string listName)
        {
            return Driver.FindElement(By.XPath($".//td[contains(text(), '{listName}')]/parent::tr//td[contains(@class, 'widgetNames')]/span"));
        }

        public IWebElement OwnerValueForList(string listName)
        {
            return Driver.FindElement(By.XPath($".//td[contains(text(), '{listName}')]/parent::tr//td[contains(@class, 'ownerName')]"));
        }

        #endregion

        #region Widgets Area Methods

        public string GetSectionNumberByWidgetName(string widgetName)
        {
            var locator = By.XPath($".//span[text()='{widgetName}']/ancestor::div[@class='section ng-star-inserted']");
            return Driver.FindElement(locator).GetAttribute("id");
        }

        public IWebElement GetSectionMenuByWidgetName(string widgetName)
        {
            var locator = By.XPath($".//span[text()='{widgetName}']/ancestor::div[@class='section ng-star-inserted']//div[contains(@class, 'edit-block-toggle')]//button//i[contains(@class,'more')]");
            return Driver.FindElement(locator);
        }

        public List<List<string>> GetWidgetsNamesInSections()
        {
            List<List<string>> widgetsInSections = new List<List<string>>();

            foreach (var section in AllSections)
            {
                widgetsInSections.Add(section.FindElements(By.XPath(".//ancestor::mat-expansion-panel//div[@class='widgets']//h5/span[1]")).Select(x => x.Text).ToList());
            }

            return widgetsInSections;
        }

        public IList<IWebElement> GetAddWidgetButtons()
        {
            var selector = By.XPath($".//span[text()='ADD WIDGET']/ancestor::button");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElements(selector);
        }

        public IWebElement GetEllipsisMenuForWidget(string widgetName)
        {
            try
            {
                return Driver.FindElement(By.XPath($".//h5/span[contains(text(),'{widgetName}')]//ancestor::div[contains(@class, 'widget-top')]//button//i"));
            }
            catch
            {
                return null;
            }
        }

        public IList<IWebElement> GetEllipsisIconsForSectionsHavingWidget(string widgetName)
        {
            return Driver.FindElements(By.XPath(
                $".//span[contains(text(),'{widgetName}')]/ancestor::div[contains(@class,'section')]//button//i[contains(@class,'more')]"));
        }

        public IList<IWebElement> GetExpandCollapseIconsForSectionsHavingWidget(string widgetName)
        {
            return Driver.FindElements(By.XPath(
                $".//span[contains(text(),'{widgetName}')]/ancestor::div[contains(@class,'section')]//i[contains(@class,'arrow')]"));
        }

        public void SetSectionExpandStatusTo(string sectionName, string state)
        {
            var collapsed = By.XPath($".//mat-panel-title[text()='{sectionName}']/ancestor::div[contains(@class,'section')]//i[contains(@class,'arrow_down')]");
            var expanded = By.XPath($".//mat-panel-title[text()='{sectionName}']/ancestor::div[contains(@class,'section')]//i[contains(@class,'arrow_up')]");

            if (state.Equals("true") && Driver.FindElements(collapsed).Any())
            {
                Driver.FindElement(collapsed).Click();
                Driver.WaitForElementToBeDisplayed(expanded);
            }

            if (state.Equals("false") && Driver.FindElements(expanded).Any())
            {
                Driver.FindElement(expanded).Click();
                Driver.WaitForElementToBeDisplayed(collapsed);
            }
        }

        public string SectionDescriptionByName(string sectionName)
        {
            var by = By.XPath($".//mat-panel-title[text()='{sectionName}']/following-sibling::div/div[contains(@class, 'description')]/div");
            IWebElement elem = Driver.FindElement(by);

            return  (String)((IJavaScriptExecutor)Driver).ExecuteScript("return arguments[0].childNodes[0].textContent;", elem);
        }

        public IWebElement SectionDescriptionLinkByName(string sectionName, string link)
        {
            var by = By.XPath($".//mat-panel-title[text()='{sectionName}']/following-sibling::div/div[contains(@class, 'description')]//a[text()='{link}']");
            return Driver.FindElement(by);
        }

        public IWebElement GetDisabledMenuItemByName(string itemName)
        {
            var ellipsisItem = By.XPath($".//button[@aria-disabled='true'][text()='{itemName}']");
            return Driver.FindElement(ellipsisItem);
        }

        public string GetDeleteWidgetAreaColor()
        {
            return Driver.FindElement(By.XPath(".//div[@class='widgets']//div[@class='inline-tip' and @role='alert']")).GetCssValue("background-color");
        }

        public IWebElement GetWidgetEmptyMessageByName(string widgetTitle)
        {
            var widg = By.XPath($".//*[text()='{widgetTitle}']/ancestor :: div[@class='widget-whole']//div[contains(@class,'empty-message')]");
            Driver.WaitForDataLoading();
            return Driver.FindElement(widg);
        }

        public List<string> GetLegendColor(string widgetName)
        {
            var colors =
                By.XPath($".//ancestor ::div[@class='widget-whole']//*[contains(@class, 'highcharts-legend-item')]//*[contains(@class, 'highcharts-point')]");

            Driver.WaitForDataLoading();
            return GetWidget(widgetName).FindElements(colors).Select(x => x.GetAttribute("fill")).ToList();
        }

        public string GetFocusedPointHover(string widgetName)
        {
            var widg = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-point highcharts-point-hover']");
            Driver.WaitForDataLoading();

            return string.Format("{0} {1}", Driver.FindElements(widg).First().GetAttribute("widget-name"),
                Driver.FindElements(widg).First().GetAttribute("widget-value"));
        }

        public IList<IWebElement> GetWidgetLinks(string widgetName)
        {
            var links =
                By.XPath($".//span[text()='{widgetName}']/ancestor ::div[@class='widget-whole']//a");

            Driver.WaitForDataLoading();
            return Driver.FindElements(links);
        }

        public string GetWidgetRowContentByColumnName(string columnName)
        {
            var by = By.XPath(
                $".//td[@role='gridcell'][{GetWidgetColumnNumberByName(columnName)}]");
            return Driver.FindElement(by).Text;
        }

        public int GetWidgetColumnNumberByName(string columnName)
        {
            var allHeadersSelector = By.XPath(".//tr[@class='mat-header-row ng-star-inserted']//th[@role]");
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(allHeadersSelector);
            var allHeaders = Driver.FindElements(allHeadersSelector);
            if (!allHeaders.Any())
                throw new Exception("Table does not contains any columns");
            var columnNumber =
                allHeaders.IndexOf(allHeaders.First(x => x.Text.Equals(columnName))) + 1;

            return columnNumber;
        }

        #endregion

        #region Table

        public IWebElement GetTableWidgetContentWithoutLink(string content)
        {
            var columnContent = By.XPath($".//td[not(contains(@class, 'link'))]/span[text()='{content}']");
            return Driver.FindElement(columnContent);
        }

        public IWebElement GetCountForTableWidget(string boolean, string number)
        {
            var dashboardWidget = By.XPath($".//table//th[text()='{boolean}']//ancestor::table//span[text()='{number}']");
            Driver.WaitForDataLoading();
            return Driver.FindElement(dashboardWidget);
        }

        public IList<IWebElement> GetTableWidgetHorizontalHeaders(string widgetName)
        {
            var columnHeaders = By.XPath($".//*[text()='{widgetName}']/ancestor :: div//table//thead//th");
            return Driver.FindElements(columnHeaders);
        }

        public IList<IWebElement> GetTableWidgetVerticalHeaders(string widgetName)
        {
            var columnHeaders = By.XPath($".//*[text()='{widgetName}']/ancestor :: div//table/tbody//td[1]/span");
            return Driver.FindElements(columnHeaders);
        }

        public IList<IWebElement> GetTableGridValues(string widgetName)
        {
            var columnHeaders = By.XPath($".//*[text()='{widgetName}']/ancestor :: div//table//tbody//td//span");
            return Driver.FindElements(columnHeaders);
        }

        public bool IsChartHasSpecifiedColor(string widgetName, string colorCode)
        {
            var coloredPart = By.XPath($".//*[text()='{widgetName}']//ancestor :: div[@class='widget-whole']//*[@fill='{colorCode}']");
            return Driver.IsElementDisplayed(coloredPart);
        }
        public bool IsComplianceValueHasColorPoint(string widgetName, string compliance)
        {
           var parent = By.XPath($".//*[text()='{widgetName}']/ancestor :: div[@class='widget-whole']//div[contains(@class, 'table-widget-value icon-and-text')]/div");
           var cell = Driver.FindElements(parent).First(x => x.Text.Contains(compliance));
           var colorPoint = ".//div[contains(@class,'status status')]";

           try
           {
               cell.FindElement(By.XPath(colorPoint));
               return true;
           }
           catch (Exception)
           {
               return false;
           }
        }

        #endregion

        #region Card

        public IWebElement GetWidgetText()
        {
            try
            {
                // .//*[text()='{WIDGET_NAME}']/ancestor :: div[@class='widget-top']/following-sibling::div//div[contains(@class, 'widget-value')]//span[contains(@class, 'text')]
                return Driver.FindElement(
                    By.XPath(".//div[contains(@class, 'widget-value')]//span[contains(@class, 'text')]"));
            }
            catch (NoSuchElementException)
            {
                return Driver.FindElement(
                    By.XPath(".//div[contains(@class, 'widget-data')]"));
            }
        }

        public IWebElement GetCardWidgetContent(string widgetTitle)
        {
            var cardWidget = By.XPath($".//*[text()='{widgetTitle}']/ancestor :: div[@class='widget-top']/following-sibling::div//div[@class='card-widget-value value-link ng-star-inserted']");
            Driver.WaitForElementToBeDisplayed(cardWidget);
            return Driver.FindElement(cardWidget);
        }

        #endregion

        #region Line

        public IWebElement GetPointOfLineWidgetByName(string widgetName, string pointNumber)
        {
            var lineWidget = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[contains(@class,'highcharts-point') and @widget-name!='Empty'][{pointNumber}]");
            Driver.WaitForDataLoading();
            return Driver.FindElements(lineWidget).First();
        }

        public List<string> GetPointOfLineWidgetByName(string widgetName)
        {
            var totalLabelsCount = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[contains(@class,'highcharts-point')]");
            Driver.WaitForDataLoading();
            return Driver.FindElements(totalLabelsCount).Select(x => x.GetAttribute("widget-name")).ToList();
        }

        public bool IsLineWidgetPointsAreDisplayed(string widgetName)
        {
            var widg = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[contains(@class,'highcharts-point') and @widget-name!='Empty']");
            Driver.WaitForDataLoading();

            //greater than 1 because line must have at least two points
            return Driver.FindElements(widg).Count > 1;
        }

        #endregion

        #region Column
        public List<string> GetPointOfColumnWidgetByName(string widgetName)
        {
            var totalLabelsCount = By.XPath($"//div/h5/span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[contains(@class, 'xaxis-labels')]/*[@text-anchor='middle' or @text-anchor='end']");
            return Driver.FindElements(totalLabelsCount).Select(x => x.Text).ToList();
        }
        #endregion

        #region Chart

        public List<string> GetChartCategoryTooltipText()
        {
            Driver.WaitForElementToBeDisplayed(PieTooltip);
            return PieTooltip.FindElements(By.XPath(".//*[string-length(text())>0]")).Select(x => x.Text).ToList();
        }

        public IWebElement GetWidgetChartItem(string widgetName, string chartCategory)
        {
            var chartSection = ".//*[contains(@class,'highcharts-series-group')]//*";

            var legendColor = GetWidget(widgetName)
                .FindElement(By.XPath($".//*[text()='{chartCategory}']/../following-sibling::*"))
                .GetCssValue("fill");

            //Count of pieces with the same color
            var allElementsWithColor = GetWidget(widgetName)
                .FindElements(By.XPath(chartSection))
                .Count(x => x.GetCssValue("fill").Equals(legendColor));

            if (allElementsWithColor == 1)
            {
                var chart = Driver.FindElements(By.XPath(chartSection))
                    .First(x => x.GetCssValue("fill").Equals(legendColor));

                return chart;
            }

            foreach (IWebElement webElement in GetWidget(widgetName)
                .FindElements(By.XPath(chartSection))
                .Where(x => x.GetCssValue("fill").Equals(legendColor)))
            {
                //Driver.MouseHover(webElement);
                Driver.MouseHover(webElement);

                if (GetChartCategoryTooltipText().First().Equals(chartCategory))
                {
                    return webElement;
                }
                //Waiting till tooltip disappears 
                Driver.ClickByJavascript(BodyContainer);
                Thread.Sleep(2000);
            }

            throw new Exception($"Chart category '{chartCategory}' wasn't found");
        }

        public IWebElement GetDataLabel(string widget, string label)
        {
            var FullWidgetElement = By.XPath($".//*[text()='{widget}']/ancestor :: div[@class='widget-whole']");
            var data_label = By.XPath($".//*[@class='highcharts-text-outline' and text() = '{label}']/following-sibling::*[@dx][2]");

            var WidgetBlock = Driver.FindElement(FullWidgetElement);
            return WidgetBlock.FindElement(data_label);
        }

        #endregion
    }
}