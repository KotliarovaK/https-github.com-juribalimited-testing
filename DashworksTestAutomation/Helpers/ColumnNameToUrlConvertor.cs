using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:
                    throw new Exception($"{columnName} column not found in convertor");
            }
        }
    }
}