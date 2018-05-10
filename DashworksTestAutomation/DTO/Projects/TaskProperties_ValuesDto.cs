using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class TaskProperties_ValuesDto
    {
        public string Name;
        public string Help;
        public ReadinessEnum Readiness;
        public TaskStatusEnum TaskStatus;
        public bool DefaultValue;

        public TaskProperties_ValuesDto()
        {
            Readiness = EnumExtensions.GetRandomValue<ReadinessEnum>();
            TaskStatus = EnumExtensions.GetRandomValue<TaskStatusEnum>();
        }
    }

    public enum ReadinessEnum
    {
        [Description("Out Of Scope")]
        OutOfScope,
        Blue,
        [Description("Light Blue")]
        LightBlue,
        Red,
        Brown,
        Amber,
        [Description("Really Extremely Orange")]
        ReallyExtremelyOrange,
        Purple,
        Green,
        Grey
    }

    public enum TaskStatusEnum
    {
        Open,
        Closed
    }
}