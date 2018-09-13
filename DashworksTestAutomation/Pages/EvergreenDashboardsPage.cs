using System;
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
        [FindsBy(How = How.XPath, Using = ".//div[@class='status-code']")]
        public IWebElement StatusCodeLabel { get; set; }

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

        public void ClickSectionFromCircleChart(string chartName, string sectionName)
        {
            //JavaScript to get all circle charts on page
            string javaScriptCodeToGetCharts = "return document.getElementsByTagName('svg')";
            //get all circle charts as web elements
            IReadOnlyCollection<IWebElement> allChartsAsWebElements =
                GetWebElementsByJavaScript(javaScriptCodeToGetCharts);

            //find index of chart by chart name
            int i = GetIndexOfElementContainingText(allChartsAsWebElements, chartName);

            //JavaScript to get all text of particular chart(determined by i index)
            string javaScriptCodeToGetTextInParticularChart =
                String.Format("return document.getElementsByTagName('svg')[{0}].getElementsByTagName('tspan')", i);
            //get all texts in particular chart as web elements
            IReadOnlyCollection<IWebElement> allTextsInParticularChartAsWebElements =
                GetWebElementsByJavaScript(javaScriptCodeToGetTextInParticularChart);

            //find index of section by name in particular chart
            int j = GetIndexOfElementContainingText(allTextsInParticularChartAsWebElements, sectionName);

            //find color of required section by text
            string color = ((IJavaScriptExecutor) Driver)
                .ExecuteScript(String.Format(
                    "return document.getElementsByTagName('svg')[{0}].getElementsByTagName('tspan')[{1}].parentElement.nextSibling.getAttribute('fill')",
                    i, j)).ToString();

            //JavaScript to get all sections in particular chart
            string javaScriptCodeToGetAllSectionsInParticularChart =
                String.Format("return document.getElementsByTagName('svg')[{0}].getElementsByTagName('path')", i);
            //get all sections in particular chart as web elements
            IReadOnlyCollection<IWebElement> allSectionsInParticularChartAsWebElement =
                GetWebElementsByJavaScript(javaScriptCodeToGetAllSectionsInParticularChart);

            //click section in particular chart by color
            foreach (var section in allSectionsInParticularChartAsWebElement)
            {
                if (section.GetAttribute("fill").Contains(color))
                {
                    section.Click();
                    break;
                }
            }
        }

        private int GetIndexOfElementContainingText(IReadOnlyCollection<IWebElement> webElememnts, string text)
        {
            int i = 0;

            foreach (var chart in webElememnts)
            {
                if (chart.GetAttribute("textContent").Contains(text))
                {
                    break;
                }

                i++;
            }

            return i;
        }

        private IReadOnlyCollection<IWebElement> GetWebElementsByJavaScript(string javaScriptCode)
        {
            return (IReadOnlyCollection<IWebElement>) ((IJavaScriptExecutor) Driver).ExecuteScript(javaScriptCode);
        }
    }
}