using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.ItemDetails
{
    public class ApplicationOwnedUserDto
    {
        public string ApplicationId
        {
            set => PackageKey = value;
        }
        public string PackageKey { get; set; }

        public string UserName
        {
            set
            {
                var displayName = DatabaseHelper.GetUserDisplayName(value);
                OwnerUser = $"{value} ({displayName})";

                OwnerUserDirectoryObjectKey = DatabaseHelper.GetUserDetailsIdByName(value);
            }
        }
        public string OwnerUser { get; set; }
        public string OwnerUserDirectoryObjectKey { get; set; }
    }
}
