using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.Onboarding;

namespace DashworksTestAutomation.DTO.RuntimeVariables.Onboarding
{
    public class OnboardedObjects
    {
        public List<OnboardingDto> Value { get; set; }

        public OnboardedObjects()
        {
            Value = new List<OnboardingDto>();
        }
    }
}