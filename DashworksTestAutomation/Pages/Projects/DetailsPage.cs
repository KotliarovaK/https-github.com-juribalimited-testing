using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class DetailsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='selectedItemBox']")]
        public IWebElement ReadinessForOnboardedApplications { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Default Value for Show Linked Objects']")]
        public IWebElement ValueForShowLinkedObjects { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DV_Project_DefaultAppsViewStateID']")]
        public IWebElement DefaultViewForProjectObjectApplicationsTab1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DV_Project_DefaultAppsViewOrderID']")]
        public IWebElement DefaultViewForProjectObjectApplicationsTab2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Default Value for Application Rationalization']")]
        public IWebElement ValueForApplicationRationalization { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Show Original Application Column On Application Dashboards']")]
        public IWebElement ShowOriginalApplicationColumnOnApplicationDashboards { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Include Site Name in Application Name']")]
        public IWebElement IncludeSiteNameInApplicationName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Not Applicable Applications']")]
        public IWebElement OnboardNotApplicableApplications { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Installed Applications by Association']")]
        public IWebElement OnboardInstalledApplicationsByAssociation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Entitled Applications by Association']")]
        public IWebElement OnboardEntitledApplicationsByAssociation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@title='Onboard Used Applications by Association to']")]
        public IWebElement OnboardUsedApplicationsByAssociationTo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@title='Task Email CC Email Address']")]
        public IWebElement TaskEmailCcEmailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@title='Task Email BCC Email Address']")]
        public IWebElement TaskEmailBccEmailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_DV_Project_UC_ProjectStartDate_TB_SelectDate']")]
        public IWebElement StartDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_DV_Project_UC_ProjectEndDate_TB_SelectDate']")]
        public IWebElement EndDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Update']")]
        public IWebElement UpdateButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ReadinessForOnboardedApplications),
                SelectorFor(this, p => p.ValueForShowLinkedObjects),
                SelectorFor(this, p => p.DefaultViewForProjectObjectApplicationsTab1),
                SelectorFor(this, p => p.DefaultViewForProjectObjectApplicationsTab2),
                SelectorFor(this, p => p.ValueForApplicationRationalization),
                SelectorFor(this, p => p.ShowOriginalApplicationColumnOnApplicationDashboards),
                SelectorFor(this, p => p.IncludeSiteNameInApplicationName),
                SelectorFor(this, p => p.OnboardNotApplicableApplications),
                SelectorFor(this, p => p.OnboardInstalledApplicationsByAssociation),
                SelectorFor(this, p => p.OnboardEntitledApplicationsByAssociation),
                SelectorFor(this, p => p.OnboardUsedApplicationsByAssociationTo),
                SelectorFor(this, p => p.TaskEmailCcEmailAddress),
                SelectorFor(this, p => p.TaskEmailBccEmailAddress),
                SelectorFor(this, p => p.StartDate),
                SelectorFor(this, p => p.EndDate)
            };
        }
    }
}