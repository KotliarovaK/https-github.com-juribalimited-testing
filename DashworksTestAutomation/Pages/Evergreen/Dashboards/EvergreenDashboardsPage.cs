using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class EvergreenDashboardsPage : SeleniumBasePage
    {
        #region Header

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE DASHBOARD' or text()='DASHBOARD ERSTELLEN']")]
        public IWebElement CreateDashboardBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-slide-toggle")]
        public IWebElement EditModeOnOffTrigger { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-slide-toggle-bar']")]
        public IWebElement EditModeSlideBar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-slide-toggle-thumb']")]
        public IWebElement EditModeSlideToggle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle-actions']/button")]
        public IWebElement DashboardsDetailsIcon { get; set; }

        #endregion

        #region Dashboards Panel

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenu']")]
        public IWebElement DashboardsListPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='context']/app-dashboards-details/div[@class='context-container']")]
        public IWebElement DashboardsContextMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='Dashboard name should be unique']")]
        public IWebElement DashboardUniqueError { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenuBlock']//*[starts-with(@class, 'inline-tip')]")]
        public IWebElement DashboardsPanelAlert { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='submenu-actions-dashboards']//span[contains(@class,'submenu-actions-dashboards-name')]")]
        public IList<IWebElement> ListDashboards { get; set; }

        [FindsBy(How = How.XPath, Using = ".//app-dashboard-submenu-action//div[@class='menu']//li")]
        public IList<IWebElement> DashboardMenuItems { get; set; }

        public IWebElement DashboardMenuItem(string itemName) =>
            Driver.FindElement(By.XPath($".//li[text()='{itemName}']"));

        #endregion

        #region Dashboard Area

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-menu-content']")]
        public IWebElement EllipsisMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-menu-item')]")]
        public IList<IWebElement> EllipsisMenuItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'section-edit-block')]//i[contains(@class,'arrow')]")]
        public IList<IWebElement> AllCollapseExpandSectionsArrows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'section-edit-block')]")]
        public IList<IWebElement> AllSections { get; set; }

        [FindsBy(How = How.XPath, Using = ".//app-dialog//span[text()='Select Section']")]
        public IWebElement MoveToSectionPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select//span[text()='Select Section']")]
        public IWebElement SelectSectionDropdown { get; set; }

        public IWebElement AlertButton(string buttonName) =>
            Driver.FindElement(By.XPath($".//div[contains(@class,'delete-alert') and not(@hidden)]//span[text()='{buttonName}']"));

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert') and not(@hidden)]//div[@class='inline-box-text']")]
        public IList<IWebElement> TextInDeleteAlert { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert')]//a[@href]")]
        public IWebElement LinkInWarningMessage { get; set; }

        #endregion

        #region Widget

        [FindsBy(How = How.XPath, Using = ".//div[@class='widgets']//h5")]
        public IList<IWebElement> AllWidgetsTitles { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='highcharts-legend']")]
        public IList<IWebElement> NumberOfWidgetLegends { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@class,'highcharts-tooltip')][@visibility]")]
        public IWebElement PieTooltip { get; set; }

        [FindsBy(How = How.XPath, Using = ".//table//td[contains(@class, 'splitValue')]//span")]
        public IList<IWebElement> TableWidgetContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'only-icon')]")]
        public IWebElement IconOnlyCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'icon-and-text')]")]
        public IWebElement IconAndTextCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'only-text')]")]
        public IWebElement TextOnlyCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='chartContainer ng-star-inserted']//*[@style='font-weight:bold']")]
        public IWebElement DataLabels { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='highcharts-legend']//*[@text-anchor='start']")]
        public IWebElement DataLegends { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='widget-preview']")]
        public IWebElement WidgetPreview { get; set; }

        #endregion

        #region Dashboard Details

        [FindsBy(How = How.XPath, Using = ".//input[@id='DashboardName']")]
        public IWebElement DashboardDetailsNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//input[@type='checkbox']")]
        public IWebElement DefaultDashboardCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Default dashboard']")]
        public IWebElement DefaultDashboardCheckboxLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']")]
        public IWebElement PermissionSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//td[@class='userName']")]
        public IList<IWebElement> PermissionAddedUser { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//td[@class='permission']")]
        public IList<IWebElement> PermissionTypeOfAccess { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-labelledby='sharing-label']")]
        public IWebElement SharingDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@aria-labelledby='sharing-label']//span[not (contains(@class, 'mat-select'))]")]
        public IWebElement SharingDropdownPermissionValue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='dependants action-panel-ddl ng-star-inserted']//button")]
        public IWebElement DetailsPanelExpandListsIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//table//tr[1]/td")]
        public IList<IWebElement> DetailsPanelSharedListsTableHeaders { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='Review Widget List Permissions']")]
        public IWebElement ReviewWidgetListPermissionsPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='mat-option-text']")]
        public IList<IWebElement> ReviewWidgetListPermissionExpandedOptions { get; set; }

        #endregion

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateDashboardBtn)
            };
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

        public void SelectSectionToMove(string sectionName)
        {
            SelectSectionDropdown.Click();
            var selector = $".//mat-option//span[text()='{sectionName}']";
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public void ClickMoveToSectionPopUpButton(string buttonName)
        {
            var listNameSelector = $".//app-dialog//button/span[text()='{buttonName}']";
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public bool IsWidgetExists(string widgetName)
        {
            return GetWidgetsNumberByName(widgetName) > 0;
        }

        public int GetWidgetsNumberByName(string widgetName)
        {
            var numberOfWidgets = Driver.FindElements(By.XPath($".//div[@class='widgets']//span[contains(text(),'{widgetName}')]")).Count;
            return numberOfWidgets;
        }

        public List<List<string>> GetWidgetsNamesInSections()
        {
            List<List<string>> widgetsInSections = new List<List<string>>();

            foreach (var section in AllSections)
            {
                widgetsInSections.Add(section.FindElements(By.XPath(".//following-sibling::div[@class='widgets']//h5")).Select(x => x.Text).ToList());
            }

            return widgetsInSections;
        }

        public IList<IWebElement> GetButtonsByName(string buttonLabel)
        {
            var selector = By.XPath(
                $".//span[text()='{buttonLabel}']/ancestor::button");
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

        public void SetPermissionSharingFieldTo(string newValue)
        {
            var shareType = By.XPath(".//div[@class='permissions-container']//*[@aria-labelledby='sharing-label']");
            Driver.WaitForElementToBeDisplayed(Driver.FindElement(shareType));
            Driver.SelectCustomSelectbox(Driver.FindElement(shareType), newValue);
        }

        public IWebElement DashboardMenuSelector(string dashboardName)
        {
            var dashboardSettingsSelector =
                By.XPath(
                    $".//ul[@class='submenu-actions-dashboards']//span[text()='{dashboardName}']/ancestor::li//i[contains(@class,'menu')]");
            Driver.MouseHover(dashboardSettingsSelector);
            Driver.WaitForElementToBeDisplayed(dashboardSettingsSelector);
            return Driver.FindElement(dashboardSettingsSelector);
        }

        public IWebElement GetMenuOfSharedUser(string username)
        {
            var dashboardSettingsSelector =
                By.XPath($".//div[@class='permissions-container']//td[contains(text(),'{username}')]/following-sibling::td/div[starts-with(@class, 'cog-menu')]//i");
            Driver.MouseHover(dashboardSettingsSelector);
            Driver.WaitForElementToBeDisplayed(dashboardSettingsSelector);
            return Driver.FindElement(dashboardSettingsSelector);
        }

        public IWebElement GetMenuOption(string option)
        {
            return Driver.FindElement(By.XPath($".//div[@class='permissions-container']//ul[@class='menu-settings']/li[contains(text(),'{option}')]"));
        }

        public IWebElement GetWidgetByName(string widgetName)
        {
            if (string.IsNullOrEmpty(widgetName))
            {
                if (!Driver.IsElementDisplayed(WidgetPreview, WebDriverExtensions.WaitTime.Long))
                    throw new Exception($"Widget preview is not displayed");
                return WidgetPreview;
            }
            else
            {
                var selector = By.XPath($".//h5//span[text()='{widgetName}']/ancestor::div[@class='widget-whole']");
                if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
                    throw new Exception($"Widget with '{widgetName}' is not displayed");
                return Driver.FindElement(selector);
            }
        }

        public IWebElement GetDisabledEllipsisItemByName(string itemName)
        {
            var ellipsisItem = By.XPath($".//button[@aria-disabled='true'][text()='{itemName}']");
            Driver.WaitForDataLoading();
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

        public IWebElement GetTopBarActionButton(string buttonName)
        {
            var page = By.XPath($".//div[@class='action-container']/button//i[text()='{buttonName.ToLower()}']");
            Driver.WaitForDataLoading();
            return Driver.FindElement(page);
        }

        public IList<IWebElement> GetWidgetLabels(string widgetName)
        {
            var legend =
                By.XPath(".//ancestor::div[@class='widget-whole']//*[contains(@class, 'highcharts-legend-item')]");

            Driver.WaitForDataLoading();
            return GetWidgetByName(widgetName).FindElements(legend);
        }

        public List<string> GetLegendColor(string widgetName)
        {
            var colors =
                By.XPath($".//ancestor ::div[@class='widget-whole']//*[contains(@class, 'highcharts-legend-item')]//*[contains(@class, 'highcharts-point')]");

            Driver.WaitForDataLoading();
            return GetWidgetByName(widgetName).FindElements(colors).Select(x => x.GetAttribute("fill")).ToList();
        }

        public string GetFocusedPointHover(string widgetName)
        {
            var widg = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-point highcharts-point-hover']");
            Driver.WaitForDataLoading();

            return string.Format("{0} {1}", Driver.FindElements(widg).First().GetAttribute("widget-name"),
                Driver.FindElements(widg).First().GetAttribute("widget-value"));
        }

        #region Details Panel

        public void ClickMenuButtonByDashboardName(string dashboardName)
        {
            var settingsButton =
                $".//span[@class='submenu-actions-dashboards-name' and text()='{dashboardName}']//ancestor::li//i[contains(@class,'settings')]";
            Driver.MouseHover(By.XPath(settingsButton));
            Driver.FindElement(By.XPath(settingsButton)).Click();
        }

        public bool GetFavoriteStateInDashboardDetailsPane()
        {
            var starIconEmpty = $".//i[@class='material-icons list-star-icon mat-star_border']";
            var starIconFilled = $".//i[@class='material-icons list-star-icon mat-star']";

            return Driver.FindElements(By.XPath(starIconFilled)).Count == 1 &&
                   Driver.FindElements(By.XPath(starIconEmpty)).Count == 0;
        }

        public void MarkFavoriteInDashboardDetails()
        {
            var starIconEmpty = $".//i[@class='material-icons list-star-icon mat-star_border']";
            Driver.FindElement(By.XPath(starIconEmpty)).Click();
        }

        public void UnMarkFavoriteInDashboardDetails()
        {
            var starIconFilled = $".//i[@class='material-icons list-star-icon mat-star']";
            Driver.FindElement(By.XPath(starIconFilled)).Click();
        }

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

        public IWebElement ReviewPermissionsPopupsButton(string buttonCaption)
        {
            return Driver.FindElement(By.XPath($".//mat-dialog-container/permission-popup//span[contains(text(),'{buttonCaption.ToUpper()}')]/parent::button"));
        }

        public string GetButtonStateOfReviewWidgetPermissionsPopup(string buttonCaption)
        {
            return ReviewPermissionsPopupsButton(buttonCaption).Enabled.ToString().ToUpper();
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

        public IList<IWebElement> GetTableWidgetHeaders(string widgetName)
        {
            var columnHeaders = By.XPath($".//*[text()='{widgetName}']/ancestor :: div//table//thead//th");
            return Driver.FindElements(columnHeaders);
        }

        public IList<IWebElement> GetTableGridValues(string widgetName)
        {
            var columnHeaders = By.XPath($".//*[text()='{widgetName}']/ancestor :: div//table//tbody//td//span");
            return Driver.FindElements(columnHeaders);
        }
        #endregion

        #region Card
        public IWebElement GetCardWidgetPreviewText()
        {
            var nested = By.XPath(".//div[@class='card-widget-data']//*");
            if (Driver.FindElements(nested).Count > 0)
            { return Driver.FindElement(By.XPath(".//div[@class='card-widget-data']//span[contains(@class, 'text')]")); }
            else
            { return Driver.FindElement(By.XPath(".//div[@class='card-widget-data']")); }
        }

        public IWebElement GetCardWidgetByName(string widgetName)
        {
            var dashboardWidget =
                By.XPath($".//div[@class='widget']//h5/span[text()='{widgetName}']//ancestor::div/div[@class='widget']");
            Driver.WaitForElementToBeDisplayed(dashboardWidget);
            return Driver.FindElement(dashboardWidget);
        }

        public IWebElement GetCardWidgetContent(string widgetTitle)
        {
            var cardWidget = By.XPath($".//*[text()='{widgetTitle}']/ancestor :: div[@class='widget-top']/following-sibling::div//div[@class='card-widget-value value-link ng-star-inserted']");
            //var cardWidget = By.XPath($".//*[text()='{widgetTitle}']/ancestor :: div[@class='widget-whole']//div[contains(@class, 'card-widget-value')]//span");
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
            var totalLabelsCount = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-axis-labels highcharts-xaxis-labels ']//*[@text-anchor='end']");

            Driver.WaitForDataLoading();
            var foundPoints = Driver.FindElements(totalLabelsCount).Count;

            List<string> webLabels = new List<string>();

            for (int i = 1; i <= foundPoints; i++)
            {
                if (string.IsNullOrEmpty(Driver.FindElement(By.XPath(
                        $".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-axis-labels highcharts-xaxis-labels ']//*[@text-anchor='end'][{i}]"))
                    .Text))
                {
                    webLabels.Add(Driver.FindElement(By.XPath(
                        $".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-axis-labels highcharts-xaxis-labels ']//*[@text-anchor='end'][{i}]/*")).Text);
                }
                else
                {
                    webLabels.Add(Driver.FindElement(By.XPath(
                        $".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-axis-labels highcharts-xaxis-labels ']//*[@text-anchor='end'][{i}]")).Text);
                }
            }

            return webLabels;
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
            var totalLabelsCount = By.XPath($".//div/h5/span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-axis-labels highcharts-xaxis-labels ']//*[@text-anchor]");

            List<string> webLabels = new List<string>();

            for (int i = 1; i <= Driver.FindElements(totalLabelsCount).Count; i++)
            {
                if (string.IsNullOrEmpty(Driver.FindElement(By.XPath(
                        $".//div/h5/span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-axis-labels highcharts-xaxis-labels ']/*[@text-anchor='middle'][{i}]"))
                    .Text))
                {
                    webLabels.Add(Driver.FindElement(By.XPath(
                        $".//div/h5/span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-axis-labels highcharts-xaxis-labels ']/*[@text-anchor='middle'][{i}]/*")).Text);
                }
                else
                {
                    webLabels.Add(Driver.FindElement(By.XPath(
                        $".//div/h5/span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-axis-labels highcharts-xaxis-labels ']/*[@text-anchor='middle'][{i}]")).Text);
                }
            }
            Driver.WaitForDataLoading();
            return webLabels;
        }
        #endregion

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

        public List<string> GetChartCategoryTooltipText()
        {
            Driver.WaitForElementToBeDisplayed(PieTooltip);
            return PieTooltip.FindElements(By.XPath(".//*[string-length(text())>0]")).Select(x => x.Text).ToList();
        }

        public IWebElement GetWidgetChartItem(string widgetName, string chartCategory)
        {
            var chartSection = ".//*[contains(@class,'highcharts-series-group')]//*";

            var legendColor = GetWidgetByName(widgetName)
                .FindElement(By.XPath($".//*[text()='{chartCategory}']/../following-sibling::*"))
                .GetCssValue("fill");

            //Count of pieces with the same color
            var allElementsWithColor = GetWidgetByName(widgetName)
                .FindElements(By.XPath(chartSection))
                .Count(x => x.GetCssValue("fill").Equals(legendColor));

            if (allElementsWithColor == 1)
            {
                var chart = Driver.FindElements(By.XPath(chartSection))
                    .First(x => x.GetCssValue("fill").Equals(legendColor));

                return chart;
            }

            foreach (IWebElement webElement in GetWidgetByName(widgetName)
                .FindElements(By.XPath(chartSection))
                .Where(x => x.GetCssValue("fill").Equals(legendColor)))
            {
                Driver.MouseHover(webElement);

                if (GetChartCategoryTooltipText().First().Equals(chartCategory))
                {
                    return webElement;
                }
                //Waiting till tooltip disappears 
                BodyContainer.Click();
                Thread.Sleep(2000);
            }

            throw new Exception($"Chart category '{chartCategory}' wasn't found");
        }

        public IWebElement GetListIconFromListSectionOfDetailsPanel(string listname)
        {
            var by = By.XPath($".//td[text()='{listname}']/following-sibling :: td/i");
            return Driver.FindElement(by);
        }
    }
}