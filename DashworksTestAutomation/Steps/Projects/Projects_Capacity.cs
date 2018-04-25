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
        private readonly Capacity_DetailsDto _detailsDto;
        private readonly Capacity_CapacityDto _capacityDto;
        private readonly Capacity_OverrideDatesDto _overrideDatesDto;

        public Projects_Capacity(RemoteWebDriver driver, Capacity_DetailsDto detailsDto, Capacity_CapacityDto capacityDto, Capacity_OverrideDatesDto overrideDatesDto)
        {
            _driver = driver;
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

        //TODO Capacity tab

        [Then(@"User updates the Override Dates on Capacity tab")]
        public void ThenUserUpdatesTheOverrideDatesOnCapacityTab(Table table)
        {
            var page = _driver.NowAt<Capacity_OverrideDatesPage>();
            var upd = _driver.NowAt<BaseElements>();

            table.CreateInstance<Capacity_OverrideDatesDto>().CopyPropertiesTo(_overrideDatesDto);

            page.Date.SendKeys(_overrideDatesDto.Date);
            page.OverrideTeam.SelectboxSelect(_overrideDatesDto.OverrideTeam.GetValue());
            page.OverrideRequestType.SelectboxSelect(_overrideDatesDto.OverrideRequestType.GetValue());
            page.Capacity.SendKeys(_overrideDatesDto.Capacity);
            page.Comment.SendKeys(_overrideDatesDto.Comment);

            upd.UpdateButton.Click();
        }
    }
}
