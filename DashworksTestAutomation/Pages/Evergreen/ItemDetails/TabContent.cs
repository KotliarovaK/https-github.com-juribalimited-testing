using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    internal class TabContent : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Elements']")]
        public IWebElement ElementsTable { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By> { };
        }

        //TODO not clear what this step check. Delete or refactor it
        public bool GetTheDisplayStateOfContentOnOpenTab(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[@class='table-responsive ng-star-inserted']//span[text()='{name}']"));
        }
    }
}