using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Senior.Tasks.AfterScenario
{
    [Binding]
    class RemoveTaskAfterScenario : SpecFlowContext
    {
        private readonly DTO.Projects.Tasks.Tasks _tasks;

        public RemoveTaskAfterScenario(DTO.Projects.Tasks.Tasks tasks)
        {
            _tasks = tasks;
        }

        [AfterScenario("Cleanup")]
        public void DeleteNewlyCreatedTask()
        {
            if (!_tasks.Value.Any())
                return;

            foreach (TaskPropertiesDto task in _tasks.Value)
            {
                try
                {
                    DatabaseHelper.DeleteTask(task);
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete '{task.Name}' task: {e}");
                }
            }
        }
    }
}
