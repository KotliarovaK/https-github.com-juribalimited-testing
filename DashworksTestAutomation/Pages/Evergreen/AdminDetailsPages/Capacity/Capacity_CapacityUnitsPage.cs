using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity
{
    public class Capacity_CapacityUnitsPage : SeleniumBasePage
    {
        public const string ApplicationsRow = "//div[@col-id='application']//a";

        [FindsBy(How = How.XPath, Using = ApplicationsRow)]
        public IList<IWebElement> ApplicationsRowsList { get; set; }
    }
}
