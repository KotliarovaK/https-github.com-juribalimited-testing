using System.Collections.Generic;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class DetailsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@title='Project Name']")]
        public IWebElement ProjectName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Project Short Name']")]
        public IWebElement ProjectShortName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@id='ctl00_MainContent_DV_Project_ProjectDescription']")]
        public IWebElement ProjectDescription { get; set; }

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
        public IWebElement OriginalApplicationColumnCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Include Site Name in Application Name']")]
        public IWebElement IncludeSiteNameCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Not Applicable Applications']")]
        public IWebElement OnboardNotApplicableApplicationsCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Installed Applications by Association']")]
        public IWebElement OnboardInstalledApplicationsByAssociationCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Onboard Entitled Applications by Association']")]
        public IWebElement OnboardEntitledApplicationsByAssociationCheckbox { get; set; }

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

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ProjectName),
                SelectorFor(this, p => p.ProjectShortName),
                SelectorFor(this, p => p.ProjectDescription),
                SelectorFor(this, p => p.OnboardedApplications),
                SelectorFor(this, p => p.ShowLinkedObjects),
                SelectorFor(this, p => p.ApplicationsTab1),
                SelectorFor(this, p => p.ApplicationsTab2),
                SelectorFor(this, p => p.ApplicationRationalization),
                SelectorFor(this, p => p.OriginalApplicationColumnCheckbox),
                SelectorFor(this, p => p.IncludeSiteNameCheckbox),
                SelectorFor(this, p => p.OnboardNotApplicableApplicationsCheckbox),
                SelectorFor(this, p => p.OnboardInstalledApplicationsByAssociationCheckbox),
                SelectorFor(this, p => p.OnboardEntitledApplicationsByAssociationCheckbox),
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