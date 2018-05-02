using System;

namespace DashworksTestAutomation.Helpers
{
    internal class DetailsSectionToUrlConvertor
    {
        public string SectionConvertor(string sectionName)
        {
            switch (sectionName)
            {
                case "Mailbox":
                    return "mailboxDetails";
                case "Device Owner":
                    return "deviceOwner";
                case "Department and Location":
                    return "departmentLocation";
                default:
                    throw new Exception($"'{sectionName}' not found convertor");
            }
        }
    }

    internal class PageToUrlConvertor
    {
        public string PageConvertor(string pageName)
        {
            switch (pageName)
            {
                case "Mailbox":
                    return "mailbox";
                case "Device":
                    return "device";
                case "Applications":
                    return "applications";
                case "":
                    return "departmentLocation";
                default:
                    throw new Exception($"'{pageName}' not found convertor");
            }
        }
    }
}