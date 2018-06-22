using System;

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

                case "Owner Email Address":
                    return "ownerEMailAddress";

                case "IP Address":
                    return "networkCardIPAddress";

                case "EmailMigra: Scheduled date":
                    return "project_task_48_13127_2_Task";

                case "Device Key":
                    return "computerKey";

                case "Last Logon Date":
                    return "lastLogonDate";

                case "UserSchedu: Readiness ID":
                    return "project_41_ragStatusId";

                case "Home Drive":
                    return "homeDrive";

                case "Owner Common Name":
                    return "ownerCommonName";

                case "ComputerSc: In Scope":
                    return "project_40_inScope";

                case "Floor":
                    return "floor";

                case "Cost Centre":
                    return "costCentre";

                case "Windows7Mi: Object ID":
                    return "project_1_objectID";

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

                case "Babel(Engl: Readiness":
                    return "project_46_ragStatus";

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
                    switch (pageName)
                    {
                        case "Mailboxes":
                            return "importType";
                        case "Applications":
                            return "distributionType";
                        case "Devices":
                            return "distributionType";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "Email Address":
                    return "eMailAddress";

                case "Windows7Mi: Readiness":
                    return "project_1_ragStatus";

                case "Windows7Mi: Group Computer Rag Radio Date Owner":
                    return "project_task_1_12865_1_Task";

                case "Department":
                    return "lDAP_231";

                case "Owner Username":
                    return "ownerUsername";

                case "ComplianceF": //
                    return "username,directoryname,displayname,fullydistinguishedobjectname,usermigrationrag";

                case "" +
                     "DAS-" +
                     "" +
                     "1814":
                    return "customField_2";

                case "Application":
                    return "packageName";

                case "Hostname":
                    return "hostname";

                case "Device Count (Entitled)":
                    return "computerEntitlements";

                default:
                    throw new Exception($"{columnName} column not found in convertor");
            }
        }
    }
}