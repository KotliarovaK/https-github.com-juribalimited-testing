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
    //TODO looks like this should be moved to BaseGrid
    public class AggridHeaderCounterElement : SeleniumBasePage
    {
        //Commented selector point to the GroupBy button on the grid.
        //But if greed is empty than those controls will not appears
        //[FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'aggrid-container wrapper-flexbox')]")]

        [FindsBy(How = How.XPath, Using = ".//button[@automation='create custom-field']")]
        public IWebElement CreateCustomFieldsButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }
    }
}
