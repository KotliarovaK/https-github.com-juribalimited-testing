using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.SelfService
{
    internal class SelfService_ComputerOwnershipPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'OwnershipShowScreen')]")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'ShowComputerNameFromHTTPHeader')]")]
        public IWebElement NameFromHttp { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowComputersUsedButNotOwnedByTheUser')]")]
        public IWebElement ShowComputers { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowCategory')]")]
        public IWebElement ShowCategory { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowUsersOfTheComputer')]")]
        public IWebElement UsersOfTheComputer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowOwnerOfTheComputerInTheListOfUsers')]")]
        public IWebElement OwnerOfTheComputer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToChangeOwnerOfTheComputer')]")]
        public IWebElement AllowUsersToChangeOwner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToChangeUsersOfTheComputer')]")]
        public IWebElement AllowUsersToChangeUsers { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToSearch')]")]
        public IWebElement AllowUsersToSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToSetPrimary')]")]
        public IWebElement AllowUsersToSetPrimary { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowUsersToAddANoteFromThisPage')]")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'LimitMaximum')]")]
        public IWebElement LimitMaximum { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'LimitMinimum')]")]
        public IWebElement LimitMinimum { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@aria-label='Page Description']")]
        public IWebElement PageDescription { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ShowScreen),
                SelectorFor(this, p => p.PageDescription),
            };
        }
    }
}