using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Slots;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using DashworksTestAutomation.Pages.Evergreen.Base;
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
                action.GetButton("CREATE SLOT").Click();

                var projectElement = _driver.NowAt<ProjectsPage>();

                projectElement.SendKeysToTheNamedTextbox(slot.SlotName, "Slot Name");
                projectElement.SendKeysToTheNamedTextbox(slot.DisplayName, "Display Name");

                if (slot.SlotAvailableFrom != DateTime.MinValue)
                    projectElement.SendKeysToTheNamedTextbox(slot.SlotAvailableFrom.ToString("dd MMM yyyy"), "Slot Available From");
                if (slot.SlotAvailableTo != DateTime.MinValue)
                    projectElement.SendKeysToTheNamedTextbox(slot.SlotAvailableTo.ToString("dd MMM yyyy"), "Slot Available To");

                projectElement.SendKeysToTheNamedTextbox(slot.SlotStartTime, "Slot Start Time");
                projectElement.SendKeysToTheNamedTextbox(slot.SlotEndTime, "Slot End Time");

                action.GetDropdown("Capacity Type").Click();
                action.GetDropdownValueByName(slot.CapacityType).Click();

                #region Assertion. Just comment with comment if some bugs appears

                switch (slot.CapacityType)
                {
                    case "Capacity Units":
                        Verify.IsTrue(action.GetTextbox("Capacity Units").GetAttribute("value").Contains("All Capacity Units"),
                            $"Default text in Capacity Units field is incorrect");
                        break;
                    case "Teams and Paths":
                        Verify.IsTrue(action.GetTextbox("Teams").GetAttribute("value").Contains("All Teams"),
                            $"Default text in Teams field is incorrect");
                        Verify.IsTrue(action.GetTextbox("Paths").GetAttribute("value").Contains("All Paths"),
                            $"Default text in Paths field is incorrect");
                        break;
                    default:
                        throw new Exception($"Unknown Capacity Type: {slot.CapacityType}");
                }

                #endregion

                action.GetDropdown("Object Type").Click();
                action.GetDropdownValueByName(slot.ObjectType).Click();

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
                        action.AutocompleteSelectCheckboxes("Capacity Units", cunit, true, true);
                        _driver.ClickByJavascript(page.BodyContainer);
                        Thread.Sleep(400);
                    }
                }

                if (slot.PathsList != null && slot.PathsList.Any())
                {
                    foreach (string path in slot.PathsList.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        action.AutocompleteSelectCheckboxes("Paths", path, true, true);
                        _driver.ClickByJavascript(page.BodyContainer);
                        Thread.Sleep(400);
                    }
                }

                if (slot.TeamsList != null && slot.TeamsList.Any())
                {
                    foreach (string team in slot.TeamsList.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        action.AutocompleteSelectCheckboxes("Teams", team, true,true);
                        _driver.ClickByJavascript(page.BodyContainer);
                        Thread.Sleep(400);
                    }
                }

                if (slot.TasksList != null && slot.TasksList.Any())
                {
                    foreach (string task in slot.TasksList.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        action.AutocompleteSelectCheckboxes("Tasks", task, true, true);
                        _driver.ClickByJavascript(page.BodyContainer);
                        Thread.Sleep(400);
                    }
                }

                action.GetButton("CREATE").Click();
                _driver.WaitForDataLoading();
                _driver.CheckConsoleErrors();
            }
        }
    }
}
