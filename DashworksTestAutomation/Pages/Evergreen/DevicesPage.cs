using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class DevicesPage : BaseDashboardPage
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