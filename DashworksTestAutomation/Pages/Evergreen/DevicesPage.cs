using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class DevicesPage : BaseDashboardPage
    {
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Heading),
                SelectorFor(this, p => p.List)
            };
        }
    }
}