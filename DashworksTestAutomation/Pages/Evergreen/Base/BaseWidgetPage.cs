using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    public class BaseWidgetPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='widget-preview']")]
        public IWebElement WidgetPreview { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='chartContainer ng-star-inserted']//*[@style='font-weight:bold']")]
        public IWebElement DataLabels { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@class,'highcharts-tooltip')][@visibility]")]
        public IWebElement PieTooltip { get; set; }

        #region Widgets types content

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'only-text')]")]
        public IWebElement TextOnlyCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'icon-and-text')]")]
        public IWebElement IconAndTextCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'only-icon')]")]
        public IWebElement IconOnlyCardWidget { get; set; }

        [FindsBy(How = How.XPath, Using = ".//table//td[contains(@class, 'splitValue')]//span")]
        public IList<IWebElement> TableWidgetContent { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//*[@class='highcharts-legend']")]
        public IList<IWebElement> NumberOfWidgetLegends { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='highcharts-legend']//*[@text-anchor='start']")]
        public IWebElement DataLegends { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By> { };
        }

        //Do not pass 'widgetName' to work with widget preview
        public IWebElement GetWidget(string widgetName)
        {
            if (string.IsNullOrEmpty(widgetName))
            {
                //For preview
                if (!Driver.IsElementDisplayed(WidgetPreview, WebDriverExtensions.WaitTime.Long))
                    throw new Exception($"Widget preview is not displayed");
                return WidgetPreview;
            }
            else
            {
                //For overview
                var selector = By.XPath($".//h5//span[text()='{widgetName}']/ancestor::div[@class='widget-whole']");
                if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
                    throw new Exception($"Widget with '{widgetName}' is not displayed");
                return Driver.FindElement(selector);
            }
        }

        public IList<IWebElement> GetWidgetLabels(string widgetName)
        {
            var legend =
                By.XPath(".//*[contains(@class, 'highcharts-legend-item')]");

            Driver.WaitForDataLoading();
            return GetWidget(widgetName).FindElements(legend);
        }

        public IWebElement GetWidgetDragAndDropElement(string widgetName)
        {
            var dragAndDropElement = By.XPath(".//button[contains(@class,'drag-drop')]");
            var widget = GetWidget(widgetName);

            Driver.WaitForElementInElementToBeDisplayed(widget, dragAndDropElement);
            return widget.FindElement(dragAndDropElement);
        }
    }
}
