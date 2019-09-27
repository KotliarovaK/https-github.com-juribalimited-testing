﻿using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class ApplicationsPage : BaseDashboardPage
    {
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.Header),
                SelectorFor(this, p => p.List)
            };
        }
    }
}