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

        public string DetailsIconConvertor(string detailsIconName)
        {
            switch (detailsIconName)
            {
                case "Mailboxes":
                    return "material-icons pull-right mat-mail";
                case "Devices ":
                    return "material-icons pull-right mat-laptop";
                case "Applications":
                    return "material-icons pull-right mat-widgets";
                case "Users":
                    return "material-icons pull-right mat-person";
                default:
                    throw new Exception($"'{detailsIconName}' not found convertor");
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