using System;

namespace DashworksTestAutomation.Helpers
{
    internal class ColumnNameToUrlConvertor
    {
        public static string Convert(string pageName, string columnName)
        {
            switch (columnName)
            {
                case "Windows7Mi: Computer Information ---- Text fill; Text fill; \\ Date & Time Task":
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

                case "EmailMigra: Pre-Migration \\ Scheduled date":
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

                case "Evergreen Target App Name":
                    return "evergreenTargetApplicationName";

                case "Floor":
                    return "floor";

                case "Cost Centre":
                    return "costCentre";

                case "Windows7Mi: Object ID":
                    return "project_1_objectID";

                case "Windows7Mi: Portal Self Service \\ SS Project Date Enabled":
                    return "project_task_1_13063_4_Task";

                case "Enabled":
                    return "enabled";

                case "Windows7Mi: Stage for User Tasks \\ Read Only on Project Object Page":
                    return "project_task_1_13090_1_Task";

                case "Application Key":
                    return "packageKey";

                case "Windows7Mi: Application Information \\ Technical Test":
                    return "project_task_1_480_1_Task";

                case "Owner Department Full Path":
                    return "ownerFullDepartmentPath";

                case "Username":
                    return "username";

                case "Windows7Mi: Application Readiness":
                    switch (pageName)
                    {
                        case "Devices":
                            return "project_1_linkedApplicationReadiness";
                        case "Applications":
                            return "project_1_applicationReadiness";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "Barry'sUse: Application Readiness":
                    switch (pageName)
                    {
                        case "Users":
                            return "project_38_linkedApplicationReadiness";
                        
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "Babel(Engl: Readiness":
                    return "project_46_ragStatus";

                case "UserSchedu: Readiness":
                    return "project_41_ragStatus";

                case "User Application Compliance":
                    return "userApplicationCompliance";

                case "Windows7Mi: Rationalisation":
                    return "project_1_applicationRationalisation";

                case "Windows7Mi: Core Application":
                    return "project_1_coreApplication";

                case "Windows7Mi: Hide From End Users":
                    return "project_1_hideFromEndUsers";

                case "Manufacturer":
                    return "manufacturer";

                case "Import":
                    return "distributionHierarchy";

                case "Build Date":
                    return "buildDate";

                case "Windows7Mi: Target App Name":
                    return "project_1_targetApplication";

                case "Babel(Engl: Target App Name":
                    return "project_46_targetApplication";

                case "Barry'sUse: Target App Name":
                    return "project_38_targetApplication";

                case "ComputerSc: Target App Name":
                    return "project_40_targetApplication";

                case "Havoc(BigD: Target App Name":
                    return "project_43_targetApplication";

                case "MigrationP: Target App Name":
                    return "project_34_targetApplication";

                case "UserSchedu: Target App Name":
                    return "project_41_targetApplication";

                case "MailboxEve: Target App Name":
                    return "project_54_targetApplication";

                case "User Key":
                    return "objectKey";

                case "Zip Code":
                    return "customField_34";

                case "Owner Compliance":
                    return "ownerMigrationRAG";

                case "MigrationP: Important Dates \\ Migrated Date":
                    return "project_task_34_10290_2_Task";

                case "Barry'sUse: Audit & Configuration \\ Package Delivery Date":
                    return "project_task_38_10484_2_Task";

                case "Barry'sUse: Project Dates \\ Migrated Date":
                    return "project_task_38_12637_2_Task";

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

                case "department":
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

                case "Mailbox Key":
                    return "mailboxKey";

                case "Device Count (Installed)":
                    return "installed";

                case "Device Count (Used)":
                    return "computerUsage";

                case "Owner title":
                    return "userLDAPField_242";

                case "Owner usncreated":
                    return "userLDAPField_37";

                case "Owner lastlogon":
                    return "userLDAPField_115";

                case "Owner admincount":
                    return "userLDAPField_43";

                case "MigrationP: Readiness":
                    return "project_34_ragStatus";

                case "Secure Boot Enabled":
                    return "secureBootEnabled";

                case "Windows7Mi: In Scope":
                    return "project_1_inScope";

                case @"Windows7Mi: Pre-Migration \ Scheduled Date (Slot)":
                    return "project_task_1_3_2_taskSlot";

                case "UserEvergr: Ring (All Users)":
                    return "project_56_allUsersRing";

                case "CPU Architecture":
                    return "processorArchitecture";

                case "Sticky Compliance":
                    return "stickyCompliance";

                case "2004: Target App Name":
                    return "project_63_targetApplication";

                case "2004: Target App Vendor":
                    return "project_63_targetApplicationVendor";

                case "2004: Target App Version":
                    return "project_63_targetApplicationVersion";

                case "2004: Target App Readiness":
                    return "project_63_targetApplicationReadiness";

                case "2004: Target App Key":
                    return "project_63_targetApplicationKey";

                case "Evergreen Rationalisation":
                    return "evergreenRationalisation";

                case "Model":
                    return "model";

                case "Evergreen Target App Vendor":
                    return "evergreenTargetApplicationVendor";

                case "Evergreen Target App":
                    return "evergreenTargetApplication";

                case "2004: In Scope":
                    return "project_63_inScope";

                case "HDD Total Size (GB)":
                    return "hDDTotalSpaceGB";

                case "First Seen Date":
                    return "firstSeenDate";

                case @"Windows7Mi: Communication \ DateTime":
                    return "project_task_1_250_2_Task";

                case @"Service Pack or Build":
                    return "oSServicePackName";

                case @"CPU Virtualisation Capable":
                    return "processorVirtualisationCapable";

                case "prK: Application Readiness":
                    switch (pageName)
                    {
                        case "Users":
                            return "project_49_linkedApplicationReadiness";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "Device Application Compliance":
                    switch (pageName)
                    {
                        case "Users":
                            return "deviceApplicationCompliance";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "Application Compliance":
                    switch (pageName)
                    {
                        case "Devices":
                            return "applicationCompliance";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "MigrationP: Application Readiness":
                    switch (pageName)
                    {
                        case "Applications":
                            return "project_34_applicationReadiness";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "2004: Status":
                    switch (pageName)
                    {
                        case "Devices":
                            return "project_63_objectStatus";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "Computer Warranty":
                    switch (pageName)
                    {
                        case "Devices":
                            return "customField_32";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "2004: Readiness":
                    switch (pageName)
                    {
                        case "Devices":
                            return "project_63_ragStatus";
                        default:
                            throw new Exception($"'{pageName}' page not found in convertor");
                    }

                case "2004: Pre-Migration \\ Ready to Migrate":
                    return "project_task_63_13266_1_Task";

                case "Havoc(BigD: Application Readiness":
                    return "project_43_applicationReadiness";

                case "Windows7Mi: Computer Information ---- Text fill; Text fill; \\ Radiobutton Task for Workstation":
                    return "project_task_1_8397_1_Task";

                case "Devices_Scope \\ First_Action":
                    return "automationField_11_10_date";

                case "UserSchedu: Three \\ Migrated Date":
                    return "project_task_41_12844_2_Task";

                default:
                    throw new Exception($"{columnName} column not found in convertor");
            }
        }
    }
}