using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Helpers
{
    internal class DetailsSectionToUrlConvertor
    {
        public string Convert(string sectionName)
        {
            switch (sectionName)
            {
                case "Mailbox":
                    return "mailboxDetails";
                case "Device Owner":
                    return "deviceOwner";
                default:
                    throw new Exception($"{sectionName} not found convertor");
            }
        }
    }
}
