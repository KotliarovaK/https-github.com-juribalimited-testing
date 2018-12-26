using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class EvergreenDashboardsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='content']//i[@class='material-icons mat-menu']")]
        public IWebElement SubMenuIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='top-tools-toggle']//div[@class='mat-slide-toggle-thumb']")]
        public IWebElement EditModeOnOffTrigger { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'CREATE DASHBOARD')]")]
        public IWebElement CreateDashboard { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='status-code']")]
        public IWebElement StatusCodeLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-menu-content']")]
        public IWebElement EllipsisMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-menu-item')]")]
        public IList<IWebElement> EllipsisMenuItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'section-edit-block')]//i[contains(@class,'arrow')]")]
        public IList<IWebElement> CollapseExpandSectionArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='widgets']//h5")]
        public IList<IWebElement> AllWidgetsTitles { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'section-edit-block')]")]
        public IList<IWebElement> AllSections { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'delete-alert') and not(@hidden)]//span[text()='DELETE']")]
        public IWebElement DeleteButtonInAlert { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//input[@class='form-control search-input ng-untouched ng-pristine ng-valid']")]
        public IWebElement SearchTextbox { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.SearchTextbox)
            };
        }

        public bool IsWidgetExists(string widgetName)
        {
            return Driver.FindElement(By.XPath($".//h5[contains(text(),'{widgetName}')]")).Displayed;
        }

        public IWebElement GetEllipsisMenuForWidget(string widgetName)
        {
            return Driver.FindElement(By.XPath($".//h5[contains(text(),'{widgetName}')]/following-sibling::div/i"));
        }

        public IList<IWebElement> GetEllipsisMenusForSectionsHavingWidget(string widgetName)
        {
            return Driver.FindElements(By.XPath(
                $".//h5[contains(text(),'{widgetName}')]/ancestor::div[contains(@class,'section')]//button//i[contains(@class,'more')]"));
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

        private int GetIndexOfElementContainingText(IEnumerable<IWebElement> webElements, string text)
        {
            return webElements.TakeWhile(chart => !chart.GetAttribute("textContent").Contains(text)).Count();
        }

        private IReadOnlyCollection<IWebElement> GetWebElementsByJavaScript(string javaScriptCode)
        {
            return (IReadOnlyCollection<IWebElement>) ((IJavaScriptExecutor) Driver).ExecuteScript(javaScriptCode);
        }
    }
}