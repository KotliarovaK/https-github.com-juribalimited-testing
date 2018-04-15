using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class DetailsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='selectedItemBox']")]
        public IWebElement OnboardedApplications { get; set; }

        private const string OnboardedApplicationsColorsSelector =
            ".//div[contains(@id,'DefaultPkgOnboardRagStatusID')]//label[text()='{0}']";

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Default Value for Show Linked Objects']")]
        public IWebElement ShowLinkedObjects { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DV_Project_DefaultAppsViewStateID']")]
        public IWebElement ApplicationsTab1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='ctl00_MainContent_DV_Project_DefaultAppsViewOrderID']")]
        public IWebElement ApplicationsTab2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Default Value for Application Rationalization']")]
        public IWebElement ApplicationRationalization { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Show Original Application Column On Application Dashboards']")]
        public IWebElement OriginalApplicationColumn { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Include Site Name in Application Name']")]
        public IWebElement IncludeSiteName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Not Applicable Applications']")]
        public IWebElement OnboardNotApplicableApplications { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Installed Applications by Association']")]
        public IWebElement OnboardInstalledApplicationsByAssociation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Entitled Applications by Association']")]
        public IWebElement OnboardEntitledApplicationsByAssociation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@title='Onboard Used Applications by Association to']")]
        public IWebElement OnboardUsedApplicationsByAssociationTo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@title='Task Email CC Email Address']")]
        public IWebElement CcEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@title='Task Email BCC Email Address']")]
        public IWebElement BccEmail { get; set; }

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
                SelectorFor(this, p => p.OnboardedApplications),
                SelectorFor(this, p => p.ShowLinkedObjects),
                SelectorFor(this, p => p.ApplicationsTab1),
                SelectorFor(this, p => p.ApplicationsTab2),
                SelectorFor(this, p => p.ApplicationRationalization),
                SelectorFor(this, p => p.OriginalApplicationColumn),
                SelectorFor(this, p => p.IncludeSiteName),
                SelectorFor(this, p => p.OnboardNotApplicableApplications),
                SelectorFor(this, p => p.OnboardInstalledApplicationsByAssociation),
                SelectorFor(this, p => p.OnboardEntitledApplicationsByAssociation),
                SelectorFor(this, p => p.OnboardUsedApplicationsByAssociationTo),
                SelectorFor(this, p => p.CcEmail),
                SelectorFor(this, p => p.BccEmail),
                SelectorFor(this, p => p.StartDate),
                SelectorFor(this, p => p.EndDate)
            };
        }

        public void SelectOnboardedApplications(DefaultReadinessForOnboardedApplicationsEnum color)
        {
            OnboardedApplications.Click();
            string selector = string.Format(OnboardedApplicationsColorsSelector, color.GetValue());
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();
        }
    }
}