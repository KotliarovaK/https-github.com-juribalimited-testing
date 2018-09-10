using System.Collections.Generic;
using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class TaskProperties_ValuesDto
    {
        public string Name { get; set; }
        public int ReadinessIndex { get; set; }
        public List<KeyValuePair<int, string>> Readiness;  
        public string TaskStatusString { get; set; }
        public TaskStatusEnum TaskStatus;
        public bool DefaultValue { get; set; }

        public TaskProperties_ValuesDto()
        {
            Readiness = new List<KeyValuePair<int, string>>();
        }
    }

    public enum TaskStatusEnum
    {
        Open,
        Closed
    }
}