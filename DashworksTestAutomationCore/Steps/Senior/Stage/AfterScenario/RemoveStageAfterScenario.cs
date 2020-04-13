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
    class RemoveStageAfterScenario : SpecFlowContext
    {
        private readonly DTO.Projects.Tasks.Stages _stages;

        public RemoveStageAfterScenario(DTO.Projects.Tasks.Stages stages)
        {
            _stages = stages;
        }

        [AfterScenario("Cleanup")]
        public void DeleteNewlyCreatedStage()
        {
            if (!_stages.Value.Any())
                return;

            foreach (StagePropertiesDto stage in _stages.Value)
            {
                try
                {
                    DatabaseHelper.DeleteStageFromDb(stage.StageName);
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete '{stage.StageName}' stage: {e}");
                }
            }
        }
    }
}
