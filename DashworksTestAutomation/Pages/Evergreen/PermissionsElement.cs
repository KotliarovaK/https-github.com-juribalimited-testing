using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class PermissionsElement : BaseRightSideActionsPanel
    {
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'action-panel-inner-wrapper')]")]
        public IWebElement SharingFormContainer { get; set; }
    }
}