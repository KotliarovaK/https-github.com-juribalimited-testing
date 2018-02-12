using System;
using DashworksTestAutomation.Utils;

namespace DashworksTestAutomation.Helpers
{
    internal class ColumnNameToUrlConvertor
    {
        public static string Convert(string pageName, string columnName)
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
                    switch (pageName)
                    {
                        case "Devices":
                            return "migrationRAG";
                        case "Applications":
                            return "migrationRAG";
                        case "Users":
                            return "userMigrationRAG";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "Created Date":
                    return "createdDate";

                case "EmailMigra: Scheduled date":
                    return "project_task_48_13127_2_Task";

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

                case "Owner Department Full Path":
                    return "ownerFullDepartmentPath";

                case "Username":
                    return "username";

                case "Windows7Mi: Application Readiness":
                    switch (pageName)
                    {
                        case "Devices":
                            return "project_1_applicationColorStatus";
                        case "Applications":
                            return "project_1_applicationReadiness";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "UserSchedu: Readiness":
                    return "project_41_ragStatus";

                case "Windows7Mi: Application Rationalisation":
                    return "project_1_applicationRationalisation";

                case "Windows7Mi: Core Application":
                    return "project_1_coreApplication";

                case "Windows7Mi: Hide from End Users":
                    return "project_1_hideFromEndUsers";

                case "Manufacturer":
                    return "manufacturer";

                case "Import":
                    return "distributionHierarchy";

                case "Build Date":
                    return "buildDate";

                case "Windows7Mi: Target App":
                    return "project_1_targetApplication";

                case "Babel(Engl: Target App":
                    return "project_46_targetApplication";

                case "Barry'sUse: Target App":
                    return "project_38_targetApplication";

                case "ComputerSc: Target App":
                    return "project_40_targetApplication";

                case "Havoc(BigD: Target App":
                    return "project_43_targetApplication";

                case "MigrationP: Target App":
                    return "project_34_targetApplication";

                case "UserSchedu: Target App":
                    return "project_41_targetApplication";

                case "User Key":
                    return "objectKey";

                case "Zip Code":
                    return "customField_34";

                case "Owner Compliance":
                    return "ownerMigrationRAG";

                case "MigrationP: Migrated Date":
                    return "project_task_34_10290_2_Task";

                case "Barry'sUse: Package Delivery Date":
                    return "project_task_38_10484_2_Task";

                case "Email Count":
                    return "emailCount";

                case "Import Type":
                    return "importType";

                case "Email Address":
                    return "eMailAddress";

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