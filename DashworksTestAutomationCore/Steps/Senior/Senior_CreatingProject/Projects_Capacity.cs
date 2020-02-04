﻿using System.Linq;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
using DashworksTestAutomation.Pages.Projects.CreatingProjects.Capacity;
using DashworksTestAutomation.Pages.Projects.CreatingProjects.SelfService;
using DashworksTestAutomation.Pages.Senior;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Projects.Projects_CreatingProject
{
    [Binding]
    internal class Projects_Capacity : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;
        private readonly Capacity_DetailsDto _detailsDto;
        private readonly Capacity_CapacityDto _capacityDto;
        private readonly Capacity_OverrideDatesDto _overrideDatesDto;


        public Projects_Capacity(RemoteWebDriver driver, ProjectDto projectDto, Capacity_DetailsDto detailsDto,
            Capacity_CapacityDto capacityDto, Capacity_OverrideDatesDto overrideDatesDto)
        {
            _driver = driver;
            _projectDto = projectDto;
            _detailsDto = detailsDto;
            _capacityDto = capacityDto;
            _overrideDatesDto = overrideDatesDto;
        }

        [When(@"User updates the Details on Capacity tab")]
        public void ThenUserUpdatesTheDetailsOnCapacityTab(Table table)
        {
            var page = _driver.NowAt<Capacity_DetailsPage>();

            table.CreateInstance<Capacity_DetailsDto>().CopyPropertiesTo(_detailsDto);

            page.EnablePlanning.SetCheckboxState(_detailsDto.EnablePlanning);
            page.DisplayColorsOnDatePicker.SetCheckboxState(_detailsDto.DisplayColors);
            page.EnforceOonSelfServicePage.SetCheckboxState(_detailsDto.EnforceOonSelfServicePage);
            page.EnforceOnProjectObjectPage.SetCheckboxState(_detailsDto.EnforceOnProjectObjectPage);
            page.CapacityToReach.Clear();
            page.CapacityToReach.SendKeys(_detailsDto.CapacityToReach);

            var upd = _driver.NowAt<MainElementsOfProjectCreation>();
            upd.UpdateButton.Click();
        }

        [When(@"User selects ""(.*)"" type of date")]
        public void WhenUserSelectsTypeOfDate(string checkboxName)
        {
            var page = _driver.NowAt<Capacity_DetailsPage>();
            page.SelectTheTypeOfDateByName(checkboxName);
        }

        //TODO move this. Action on Senior part
        [When(@"User selects ""(.*)"" Task")]
        public void WhenUserSelectsTask(string checkboxName)
        {
            var page = _driver.NowAt<SeniorProjectsBaseElements>();
            page.SelectCheckboxByName(checkboxName);
        }

        [When(@"User adds ""(.*)"" Additional Task")]
        public void WhenUserAddsAdditionalTask(string taskName)
        {
            var page = _driver.NowAt<SelfService_ProjectDatePage>();

            page.AdditionalTasks.Click();
            page.SelectTaskByName(taskName).Click();
            page.AddAdditionalTasks.Click();
        }

        [When(@"User updates the Capacity page on Capacity tab for ""(.*)"" Team")]
        public void WhenUserUpdatesTheCapacityPageOnCapacityTabForTeam(int teamIndex, Table table)
        {
            var page = _driver.NowAt<Capacity_CapacityPage>();

            table.CreateInstance<Capacity_CapacityDto>().CopyPropertiesTo(_capacityDto);

            page.Team.SelectboxSelect(_projectDto.TeamProperties[teamIndex - 1].TeamName);
            _driver.WaitForDataLoadingOnProjects();
            try
            {
                _driver.WaitForElementToBeDisplayed(page.RequestType);
                page.RequestType.SelectboxSelect(_projectDto.ReqestTypes.Last().Name);
                _driver.WaitForDataLoadingOnProjects();
            }
            catch (StaleElementReferenceException)
            {
                page = _driver.NowAt<Capacity_CapacityPage>();
                _driver.WaitForElementToBeDisplayed(page.RequestType);
                page.RequestType.SelectboxSelect(_projectDto.ReqestTypes.Last().Name);
                _driver.WaitForDataLoadingOnProjects();
            }

            _driver.WaitForElementToBeDisplayed(page.Table);
            page.StartDate.Clear();
            page.StartDate.SendKeys(_capacityDto.StartDate);
            page.StartDateButton.Click();
            _driver.WaitForDataLoadingOnProjects();
            page.EndDate.Clear();
            page.EndDate.SendKeys(_capacityDto.EndDate);
            page.EndDateButton.Click();
            _driver.WaitForDataLoadingOnProjects();
            page.MondayCheckbox.SetCheckboxState(_capacityDto.MondayCheckbox);
            page.TuesdayCheckbox.SetCheckboxState(_capacityDto.TuesdayCheckbox);
            page.WednesdayCheckbox.SetCheckboxState(_capacityDto.WednesdayCheckbox);
            page.ThursdayCheckbox.SetCheckboxState(_capacityDto.ThursdayCheckbox);
            page.FridayCheckbox.SetCheckboxState(_capacityDto.FridayCheckbox);
            page.SaturdayCheckbox.SetCheckboxState(_capacityDto.SaturdayCheckbox);
            page.SundayCheckbox.SetCheckboxState(_capacityDto.SundayCheckbox);
            page.Monday.SendKeys(_capacityDto.Monday);
            page.Tuesday.SendKeys(_capacityDto.Tuesday);
            page.Wednesday.SendKeys(_capacityDto.Wednesday);
            page.Thursday.SendKeys(_capacityDto.Thursday);
            page.Friday.SendKeys(_capacityDto.Friday);
            page.Saturday.SendKeys(_capacityDto.Saturday);
            page.Sunday.SendKeys(_capacityDto.Sunday);

            var upd = _driver.NowAt<MainElementsOfProjectCreation>();
            upd.UpdateButton.Click();
        }

        [When(@"User select created request type on Summary tab")]
        public void WhenUserSelectCreatedRequestTypeOnSummaryTab()
        {
            var page = _driver.NowAt<Capacity_SummaryPage>();

            page.RequestType.SelectboxSelect(_projectDto.ReqestTypes.Last().Name);
        }

        [Then(@"table for selected request type is displayed")]
        public void ThenTableForSelectedRequestTypeIsDisplayed()
        {
            var page = _driver.NowAt<Capacity_SummaryPage>();
            _driver.WaitForElementToBeDisplayed(page.Table);
            Utils.Verify.IsTrue(page.Table.Displayed, "Table is not displayed for selected request type");
        }

        [When(@"User updates the Override Dates on Capacity tab")]
        public void ThenUserUpdatesTheOverrideDatesOnCapacityTab(Table table)
        {
            var page = _driver.NowAt<Capacity_OverrideDatesPage>();

            table.CreateInstance<Capacity_OverrideDatesDto>().CopyPropertiesTo(_overrideDatesDto);

            page.Date.SendKeys(_overrideDatesDto.Date);
            page.OverrideTeam.SelectboxSelect(_overrideDatesDto.OverrideTeam.GetValue());

            switch (_projectDto.ProjectType)
            {
                case ProjectTypeEnum.ComputerScheduledProject:
                    _overrideDatesDto.OverrideRequestType = OverrideRequestTypeEnum.DefaultComputer;
                    break;
                case ProjectTypeEnum.MailboxScheduledProject:
                    _overrideDatesDto.OverrideRequestType = OverrideRequestTypeEnum.DefaultMailbox;
                    break;
                case ProjectTypeEnum.UserScheduledProject:
                    _overrideDatesDto.OverrideRequestType = OverrideRequestTypeEnum.DefaultUser;
                    break;
            }

            page.Capacity.SendKeys(_overrideDatesDto.Capacity.ToString());
            page.Comment.SendKeys(_overrideDatesDto.Comment);

            var upd = _driver.NowAt<MainElementsOfProjectCreation>();
            upd.AddButton.Click();
        }
    }
}