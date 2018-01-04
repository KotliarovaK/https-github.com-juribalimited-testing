using System;

namespace DashworksTestAutomation.Helpers
{
    class ColumnNameToUrlConvertor
    {
        public string Convert(string columnName)
        {
            switch (columnName)
            {
                case "Windows7Mi: Date & Time Task":
                    return "project_task_1_9950_2_Task";
                case "Boot Up Date":
                    return "bootupDate";
                case "Directory Type":
                    return "directoryType";
                case "Compliance":
                    return "migrationRAG";
                case "Device Key":
                    return "computerKey";
                case "Last Logon Date":
                    return "lastLogonDate";
                case "Home Drive":
                    return "homeDrive";
                case "Owner Common Name":
                    return "ownerCommonName";
                case "Windows7Mi: SS Project Date Enabled":
                    return "project_task_1_13063_4_Task";
                case "Enabled":
                    return "enabled";
                case "Windows7Mi: Read Only on Project Object Page":
                    return "project_task_1_13090_1_Task";
                case "Application Key":
                    return "packageKey";
                case "Windows7Mi: Technical Test":
                    return "project_task_1_480_1_Task";
                case "" +
                     "DAS-" +
                     "" +
                     "1814":
                    return "customField_2";
                default:
                    throw new Exception($"{columnName} column not found in convertor");
            }
        }
    }
}