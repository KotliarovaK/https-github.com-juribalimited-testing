using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_Capacity : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ProjectDto _projectDto;
        private readonly Capacity_DetailsDto _detailsDto;
        private readonly Capacity_CapacityDto _capacityDto;
        private readonly Capacity_OverrideDatesDto _overrideDatesDto;

        public Projects_Capacity(RemoteWebDriver driver, ProjectDto projectDto, Capacity_DetailsDto detailsDto, Capacity_CapacityDto capacityDto, Capacity_OverrideDatesDto overrideDatesDto)
        {
            _driver = driver;
            _projectDto = projectDto;
            _detailsDto = detailsDto;
            _capacityDto = capacityDto;
            _overrideDatesDto = overrideDatesDto;
        }

        [Then(@"User updates the Details on Capacity tab")]
        public void ThenUserUpdatesTheDetailsOnCapacityTab(Table table)
        {
            var page = _driver.NowAt<Capacity_DetailsPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<Capacity_DetailsDto>().CopyPropertiesTo(_detailsDto);

            page.EnablePlanning.SetCheckboxState(_detailsDto.EnablePlanning);
            page.DisplayColorsOnDatePicker.SetCheckboxState(_detailsDto.DisplayColors);
            page.EnforceOonSelfServicePage.SetCheckboxState(_detailsDto.EnforceOonSelfServicePage);
            page.EnforceOnProjectObjectPage.SetCheckboxState(_detailsDto.EnforceOnProjectObjectPage);
            page.CapacityToReach.SendKeys(_detailsDto.CapacityToReach);

            upd.UpdateButton.Click();
        }

        [Then(@"User updates the Capacity on Capacity tab")]
        public void ThenUserUpdatesTheCapacityOnCapacityTab(Table table)
        {
            var page = _driver.NowAt<Capacity_CapacityPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<Capacity_CapacityDto>().CopyPropertiesTo(_capacityDto);

            page.Team.SelectboxSelect(_projectDto.TeamProperties.TeamName);
            _driver.WaitWhileControlIsNotDisplayed<Capacity_CapacityPage>(() => page.RequestType);
            page.RequestType.SelectboxSelect(_projectDto.ReqestType.Name);
            //TODO check all Request Type
            _driver.WaitWhileControlIsNotDisplayed<Capacity_CapacityPage>(() => page.StartDate);
            page.StartDate.SendKeys(_capacityDto.StartDate);
            page.EndDate.SendKeys(_capacityDto.EndDate);
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

            upd.AddButton.Click();
        }

        [Then(@"User updates the Override Dates on Capacity tab")]
        public void ThenUserUpdatesTheOverrideDatesOnCapacityTab(Table table)
        {
            var page = _driver.NowAt<Capacity_OverrideDatesPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<Capacity_OverrideDatesDto>().CopyPropertiesTo(_overrideDatesDto);

            page.Date.SendKeys(_overrideDatesDto.Date);
            page.OverrideTeam.SelectboxSelect(_overrideDatesDto.OverrideTeam.GetValue());
            page.OverrideRequestType.SelectboxSelect(_overrideDatesDto.OverrideRequestType.GetValue());
            page.Capacity.SendKeys(_overrideDatesDto.Capacity.ToString());
            page.Comment.SendKeys(_overrideDatesDto.Comment);

            upd.AddButton.Click();
        }
    }
}
