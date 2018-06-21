using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class TaskProperties_ValuesDto
    {
        public string Name { get; set; }
        public string ReadinessString { get; set; }
        public ReadinessEnum Readiness;
        public string TaskStatusString { get; set; }
        public TaskStatusEnum TaskStatus;
        public bool DefaultValue { get; set; }
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
        Grey,
        None
    }

    public enum TaskStatusEnum
    {
        Open,
        Closed
    }
}