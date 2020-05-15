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
}