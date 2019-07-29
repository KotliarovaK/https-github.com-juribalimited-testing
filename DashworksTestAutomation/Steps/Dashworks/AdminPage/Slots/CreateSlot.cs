using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.Slots;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Slots
{
    [Binding]
    class CreateSlot : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Slots _slots;

        public CreateSlot(RemoteWebDriver driver, DTO.RuntimeVariables.Slots slots)
        {
            _driver = driver;
            _slots = slots;
        }

        [When(@"User creates new Slot")]
        public void WhenUserCreatesNewSlot(Table table)
        {
            var slots = table.CreateSet<SlotDto>();
            _slots.Value.AddRange(slots);

            foreach (SlotDto slot in slots)
            {
                var action = _driver.NowAt<BaseDashboardPage>();
                action.GetActionsButtonByName("CREATE SLOT").Click();

                var projectElement = _driver.NowAt<ProjectsPage>();

                projectElement.SendKeysToTheNamedTextbox(slot.SlotName, "Slot Name");
                projectElement.SendKeysToTheNamedTextbox(slot.DisplayName, "Display Name");

                if (slot.SlotAvailableFrom != DateTime.MinValue)
                    projectElement.SendKeysToTheNamedTextbox(slot.SlotAvailableFrom.ToString("dd MMM yyyy"), "Slot Available From");
                if (slot.SlotAvailableTo != DateTime.MinValue)
                    projectElement.SendKeysToTheNamedTextbox(slot.SlotAvailableTo.ToString("dd MMM yyyy"), "Slot Available To");

                projectElement.SendKeysToTheNamedTextbox(slot.SlotStartTime, "Slot Start Time");
                projectElement.SendKeysToTheNamedTextbox(slot.SlotEndTime, "Slot End Time");

                var dropdown = _driver.NowAt<BaseGridPage>();
                dropdown.GetDropdownByName("Capacity Type").Click();
                action.GetOptionByName(slot.CapacityType).Click();

                dropdown.GetDropdownByName("Object Type").Click();
                action.GetOptionByName(slot.ObjectType).Click();

                var page = _driver.NowAt<Capacity_SlotsPage>();
                page.EnterValueByDayName(slot.Monday, "Monday");
                page.EnterValueByDayName(slot.Tuesday, "Tuesday");
                page.EnterValueByDayName(slot.Wednesday, "Wednesday");
                page.EnterValueByDayName(slot.Thursday, "Thursday");
                page.EnterValueByDayName(slot.Friday, "Friday");
                page.EnterValueByDayName(slot.Saturday, "Saturday");
                page.EnterValueByDayName(slot.Sunday, "Sunday");

                if (slot.CapacityUnitsList != null && slot.CapacityUnitsList.Any())
                {
                    foreach (string cunit in slot.CapacityUnitsList.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        projectElement.SendKeysToTheNamedTextbox(cunit, "Capacity Units");
                        page.GetCheckboxByName(cunit).Click();
                        page.BodyContainer.Click();
                        Thread.Sleep(400);
                    }
                }

                if (slot.PathsList != null && slot.PathsList.Any())
                {
                    foreach (string path in slot.PathsList.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        projectElement.SendKeysToTheNamedTextbox(path, "Paths");
                        page.GetCheckboxByName(path).Click();
                        page.BodyContainer.Click();
                        Thread.Sleep(400);
                    }
                }

                if (slot.TeamsList != null && slot.TeamsList.Any())
                {
                    foreach (string team in slot.TeamsList.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        projectElement.SendKeysToTheNamedTextbox(team, "Teams");
                        page.GetCheckboxByName(team).Click();
                        page.BodyContainer.Click();
                        Thread.Sleep(400);
                    }
                }

                if (slot.TasksList != null && slot.TasksList.Any())
                {
                    foreach (string task in slot.TasksList.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        projectElement.SendKeysToTheNamedTextbox(task, "Tasks");
                        page.GetCheckboxByName(task).Click();
                        page.BodyContainer.Click();
                        Thread.Sleep(400);
                    }
                }

                action.GetActionsButtonByName("CREATE").Click();
                _driver.WaitForDataLoading();
                _driver.CheckConsoleErrors();
            }
        }
    }
}
