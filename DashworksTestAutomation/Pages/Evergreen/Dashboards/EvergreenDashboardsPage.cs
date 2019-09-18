using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class EvergreenDashboardsPage : SeleniumBasePage
    {

        [FindsBy(How = How.XPath, Using = ".//div[@class='status-code']")]
        public IWebElement StatusCodeLabel { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//input[@class='form-control search-input ng-untouched ng-pristine ng-valid']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-slide-toggle")]
        public IWebElement EditModeOnOffTrigger { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-slide-toggle-bar']")]
        public IWebElement EditModeSlideBar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-slide-toggle-thumb']")]
        public IWebElement EditModeSlideToggle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenu']")]
        public IWebElement DashboardsSubmenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='content']//i[@class='material-icons mat-menu']")]
        public IWebElement DashboardsPanelIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='context']/app-dashboards-details/div[@class='context-container']")]
        public IWebElement DashboardsContextMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle-actions']/button")]
        public IWebElement DashboardsDetailsIcon { get; set; }


        #region Dashboards Panel

        [FindsBy(How = How.XPath, Using = ".//ul[@class='submenu-actions-dashboards']//span[@class='submenu-actions-dashboards-name']")]
        public IList<IWebElement> AllDashboardsInPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='Dashboard name should be unique']")]
        public IWebElement DashboardUniqueError { get; set; }

        [FindsBy(How = How.XPath, Using = ".//app-dashboard-submenu-action//div[@class='menu']//li")]
        public IList<IWebElement> DashboardMenuOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Manage']")]
        public IWebElement ManageContextMenuItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Make favourite']")]
        public IWebElement MakeFavoriteContextMenuItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Unfavourite']")]
        public IWebElement UnfavoriteContextMenuItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Set default']")]
        public IWebElement MakeDefaultContextMenuItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[text()='Duplicate']")]
        public IWebElement DuplicateContextMenuItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessMessage { get; set; }

        #endregion


        #region Dashboard Area

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-menu-content']")]
        public IWebElement EllipsisMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-menu-item')]")]
        public IList<IWebElement> EllipsisMenuItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'section-edit-block')]//i[contains(@class,'arrow')]")]
        public IList<IWebElement> AllCollapseExpandSectionsArrows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='widgets']//h5")]
        public IList<IWebElement> AllWidgetsTitles { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='highcharts-legend']")]
        public IList<IWebElement> NumberOfWidgetLegends { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'section-edit-block')]")]
        public IList<IWebElement> AllSections { get; set; }

        [FindsBy(How = How.XPath, Using = ".//app-dialog//span[text()='Select Section']")]
        public IWebElement MoveToSectionPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select//span[text()='Select Section']")]
        public IWebElement SelectSectionDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//table//td[contains(@class, 'splitValue')]//span")]
        public IList<IWebElement> TableWidgetContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert') and not(@hidden)]//span[text()='DELETE']")]
        public IWebElement DeleteButtonInAlert { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert') and not(@hidden)]//span[text()='CANCEL']")]
        public IWebElement CancelButtonInAlert { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert') and not(@hidden)]//span[text()='EDIT']")]
        public IWebElement EditButtonInAlert { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert') and not(@hidden)]//div[@class='inline-box-text']")]
        public IList<IWebElement> TextInDeleteAlert { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert')]//a[@href]")]
        public IWebElement LinkInWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='submenuBlock']//*[starts-with(@class, 'inline-tip')]")]
        public IWebElement SubmenuAlertMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='widget-preview']")]  ////div[@class='widget-preview']//div[@dir='ltr'] old locator
        public IWebElement WidgetPreview { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'only-icon')]")]
        public IWebElement IconOnlyCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'icon-and-text')]")]
        public IWebElement IconAndTextCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'only-text')]")]
        public IWebElement TextOnlyCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='chartContainer ng-star-inserted']//*[@style='font-weight:bold']")]
        public IWebElement DataLabels { get; set; }

        #endregion


        #region Dashboard Details

        [FindsBy(How = How.XPath, Using = ".//input[@id='DashboardName']")]
        public IWebElement DashboardDetailsNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-container']/form")]
        public IWebElement UserTeamSectionOnDashboardDetails { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//input[@type='checkbox']")]
        public IWebElement DefaultDashboardCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Default dashboard']")]
        public IWebElement DefaultDashboardCheckboxLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']")]
        public IWebElement PermissionPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//span[contains(text(), 'ADD USER')]")]
        public IWebElement PermissionAddUserButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//input[@placeholder='User']")]
        public IWebElement PermissionUserField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//mat-select[@role='listbox']//span[contains(text(), 'Permission')]")]
        public IWebElement PermissionTypeField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//td[@class='userName']")]
        public IWebElement PermissionNameOfAddedUser { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='permissions-container']//td[@class='permission']")]
        public IWebElement PermissionAccessTypeOfAddedUser { get; set; }

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
                SelectorFor(this, p => p.SearchTextbox)
            };
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
            return Driver.FindElements(By.XPath($".//div[@class='widgets']//span[contains(text(),'{widgetName}')]")).Count > 0;
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

        public IWebElement GetDashboardDetailsButtonsByName(string buttonLabel)
        {
            var selector = By.XPath($".//div[@class='context-container']//span[text()='{buttonLabel}']/ancestor::button");
            return Driver.FindElement(selector);
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

        public IWebElement GetTableWidgetContentWithoutLink(string content)
        {
            var columnContent = By.XPath($".//td[not(contains(@class, 'link'))]/span[text()='{content}']");
            return Driver.FindElement(columnContent);
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
        
        public void ClickSectionFromCircleChart(string chartName, string sectionName)
        {
            //JavaScript to get all circle charts on page
            var javaScriptCodeToGetCharts = "return document.getElementsByTagName('svg')";
            //get all circle charts as web elements
            var allChartsAsWebElements =
                GetWebElementsByJavaScript(javaScriptCodeToGetCharts);

            //find index of chart by chart name
            var i = GetIndexOfElementContainingText(allChartsAsWebElements, chartName);

            //JavaScript to get all text of particular chart(determined by i index)
            var javaScriptCodeToGetTextInParticularChart =
                $"return document.getElementsByTagName('svg')[{i}].getElementsByTagName('tspan')";
            //get all texts in particular chart as web elements
            var allTextsInParticularChartAsWebElements =
                GetWebElementsByJavaScript(javaScriptCodeToGetTextInParticularChart);

            //find index of section by name in particular chart
            var j = GetIndexOfElementContainingText(allTextsInParticularChartAsWebElements, sectionName);

            //find color of required section by text
            var color = ((IJavaScriptExecutor) Driver)
                .ExecuteScript(
                    $"return document.getElementsByTagName('svg')[{i}].getElementsByTagName('tspan')[{j}].parentElement.nextSibling.getAttribute('fill')")
                .ToString();

            //JavaScript to get all sections in particular chart
            var javaScriptCodeToGetAllSectionsInParticularChart =
                $"return document.getElementsByTagName('svg')[{i}].getElementsByTagName('path')";
            //get all sections in particular chart as web elements
            var allSectionsInParticularChartAsWebElement =
                GetWebElementsByJavaScript(javaScriptCodeToGetAllSectionsInParticularChart);

            //click section in particular chart by color
            foreach (var section in allSectionsInParticularChartAsWebElement)
                if (section.GetAttribute("fill").Contains(color))
                {
                    section.Click();
                    break;
                }
        }

        public void ChangePermissionSharingFieldFromTo(string valueInField, string newValue)
        {
            var from = $" .//div[@class='permissions-container']//span[contains(text(), '{valueInField}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(from));
            Driver.FindElement(By.XPath(from)).Click();

            var to = $".//span[@class='mat-option-text'][contains(text(), '{newValue}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(to));
            Driver.FindElement(By.XPath(to)).Click();

            var newVal = $" .//div[@class='permissions-container']//span[contains(text(), '{newValue}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(newVal));
        }

        public void SelectOptionFromList(string option)
        {
            var selector = $".//span[@class='mat-option-text'][contains(text(), '{option}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }

        public IWebElement OpenSettingsByDashboardName(string dashboardName)
        {
            var dashboardSettingsSelector =
                By.XPath(
                    $".//ul[@class='submenu-actions-dashboards']//span[text()='{dashboardName}']/ancestor::li//i[contains(@class,'menu')]");
            Driver.MouseHover(dashboardSettingsSelector);
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(dashboardSettingsSelector);
            return Driver.FindElement(dashboardSettingsSelector);
        }

        public IWebElement GetSettingsMenuOfSharedUser(string username)
        {
            var dashboardSettingsSelector =
                By.XPath($".//div[@class='permissions-container']//td[contains(text(),'{username}')]/following-sibling::td/div[starts-with(@class, 'cog-menu')]");
            Driver.MouseHover(dashboardSettingsSelector);
            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(dashboardSettingsSelector);
            return Driver.FindElement(dashboardSettingsSelector);
        }

        public IWebElement GetSettingsOption(string option)
        {
            return Driver.FindElement(By.XPath($".//div[@class='permissions-container']//ul[@class='menu-settings']/li[contains(text(),'{option}')]"));
        }

        private int GetIndexOfElementContainingText(IEnumerable<IWebElement> webElements, string text)
        {
            return webElements.TakeWhile(chart => !chart.GetAttribute("textContent").Contains(text)).Count();
        }

        private IReadOnlyCollection<IWebElement> GetWebElementsByJavaScript(string javaScriptCode)
        {
            return (IReadOnlyCollection<IWebElement>) ((IJavaScriptExecutor) Driver).ExecuteScript(javaScriptCode);
        }

        public IWebElement GetWidgetByName(string widgetName)
        {
            var dashboardWidget =
                By.XPath($".//div[@class='widget']//span[text()='{widgetName}']//ancestor::div/div[@class='widget']");

            Driver.WaitForElementToBeDisplayed(dashboardWidget);
            return Driver.FindElement(dashboardWidget);
        }

        public IWebElement GetDisabledEllipsisItemByName(string itemName)
        {
            var ellipsisItem = By.XPath($".//button[@aria-disabled='true'][text()='{itemName}']");
            Driver.WaitForDataLoading();
            return Driver.FindElement(ellipsisItem);
        }

        public string GetDeleteWidgetSquareColor()
        {
            return Driver.FindElement(By.XPath(".//div[@class='widgets']//div[@class='inline-tip' and @role='alert']")).GetCssValue("background-color");
        }

        public IWebElement GetCardWidgetByName(string widgetName)
        {
            var dashboardWidget =
                By.XPath($".//div[@class='widget']//h5/span[text()='{widgetName}']//ancestor::div/div[@class='widget']");
            Driver.WaitForElementToBeDisplayed(dashboardWidget);
            return Driver.FindElement(dashboardWidget);
        }

        public string GetWidgwtRowContentByColumnName(string columnName)
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

        public IWebElement GetCountForTableWidget(string boolean, string number)
        {
            var dashboardWidget = By.XPath($".//table//th[text()='{boolean}']//ancestor::table//span[text()='{number}']");
            Driver.WaitForDataLoading();
            return Driver.FindElement(dashboardWidget);
        }

        public IWebElement GetCardWidgetContent(string widgetTitle)
        {
            var cardWidget = By.XPath($".//*[text()='{widgetTitle}']/ancestor :: div[@class='widget-top']/following-sibling::div//div[@class='card-widget-value value-link ng-star-inserted']");
            //var cardWidget = By.XPath($".//*[text()='{widgetTitle}']/ancestor :: div[@class='widget-whole']//div[contains(@class, 'card-widget-value')]//span");
            Driver.WaitForElementToBeDisplayed(cardWidget);
            return Driver.FindElement(cardWidget);
        }

        public IWebElement GetWidgetEmptyMessageByName(string widgetTitle)
        {
            var cardWidget = By.XPath($".//*[text()='{widgetTitle}']/ancestor :: div[@class='widget-whole']//div[contains(@class,'empty-message')]");
            Driver.WaitForDataLoading();
            return Driver.FindElement(cardWidget);
        }

        public IWebElement GetTopBarActionButton(string buttonName)
        {
            var cardWidget = By.XPath($".//div[@class='action-container']/button//i[text()='{buttonName.ToLower()}']");
            Driver.WaitForDataLoading();
            return Driver.FindElement(cardWidget);
        }

        public IWebElement GetFirstDashboardFromList()
        {
            var cardWidget = By.XPath($".//ul[@class='submenu-actions-dashboards']/li[@mattooltipposition]");
            Driver.WaitForDataLoading();
            return Driver.FindElements(cardWidget).First();
        }

        public IWebElement GetPointOfLineWidgetByName(string widgetName, string pointNumber)
        {
            var cardWidget = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[contains(@class,'highcharts-point') and @widget-name!='Empty'][{pointNumber}]");
            Driver.WaitForDataLoading();
            return Driver.FindElements(cardWidget).First();
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

        public IList <IWebElement> GetWidgetLabels(string widgetName)
        {
            var legend =
                By.XPath($".//span[text()='{widgetName}']/ancestor ::div[@class='widget-whole']//*[contains(@class, 'highcharts-legend-item')]");

            Driver.WaitForDataLoading();
            return Driver.FindElements(legend);
        }

        public List<string> GetLegendColor(string widgetName)
        {
            var colors =
                By.XPath($".//span[text()='{widgetName}']/ancestor ::div[@class='widget-whole']//*[contains(@class, 'highcharts-legend-item')]//*[contains(@class, 'highcharts-point')]");

            Driver.WaitForDataLoading();
            return Driver.FindElements(colors).Select(x=>x.GetAttribute("fill")).ToList();
        }

        public string GetFocusedPointHover(string widgetName)
        {
            var cardWidget = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[@class='highcharts-point highcharts-point-hover']");
            Driver.WaitForDataLoading();

            return string.Format("{0} {1}", Driver.FindElements(cardWidget).First().GetAttribute("widget-name"),
                Driver.FindElements(cardWidget).First().GetAttribute("widget-value"));
        }

        public bool IsLineWidgetPointsAreDisplayed(string widgetName)
        {
            var cardWidget = By.XPath($".//span[text()='{widgetName}']/ancestor ::div/following-sibling::div//*[contains(@class,'highcharts-point') and @widget-name!='Empty']");
            Driver.WaitForDataLoading();

            //greater than 1 because line must have at least two points
            return Driver.FindElements(cardWidget).Count>1;
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

        public IWebElement WidgetValueForList(string listName)
        {
            return Driver.FindElement(By.XPath($".//td[contains(text(), '{listName}')]/parent::tr//td[contains(@class, 'widgetNames')]/span"));
        }

        public IWebElement OwnerValueForList(string listName)
        {
            return Driver.FindElement(By.XPath($".//td[contains(text(), '{listName}')]/parent::tr//td[contains(@class, 'ownerName')]"));
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
        public IWebElement GetCardWidgetPreviewText()
        {
            var nested = By.XPath(".//div[@class='card-widget-data']//*");
            if (Driver.FindElements(nested).Count > 0)
            { return Driver.FindElement(By.XPath(".//div[@class='card-widget-data']//span[contains(@class, 'text')]")); }
            else
            { return Driver.FindElement(By.XPath(".//div[@class='card-widget-data']")); }
        }

        public void ClickSettingsButtonByDashboardName(string dashboardName)
        {
            var settingsButton =
                $".//span[@class='submenu-actions-dashboards-name' and text()='{dashboardName}']//ancestor::li//i[contains(@class,'settings')]";
            Driver.MouseHover(By.XPath(settingsButton));
            Driver.FindElement(By.XPath(settingsButton)).Click();
        }

        public void ClickDashboardByName(string dashboardName)
        {
            var dashboardItem =$".//span[@class='submenu-actions-dashboards-name' and text()='{dashboardName}']";
            Driver.FindElement(By.XPath(dashboardItem)).Click();
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

        public IList<IWebElement> GetWidgetLinks(string widgetName)
        {
            var links =
                By.XPath($".//span[text()='{widgetName}']/ancestor ::div[@class='widget-whole']//a");

            Driver.WaitForDataLoading();
            return Driver.FindElements(links);
        }

    }
}