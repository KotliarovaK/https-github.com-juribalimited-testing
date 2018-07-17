using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.ManagementConsole
{
    public class ManageUsersDto
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string RolesString { get; set; }
        public RolesEnum Roles;
    }

    public enum RolesEnum
    {
        [Description("Dashworks Users")]
        DashworksUsers,
        [Description("Dashworks Evergreen Users")]
        DashworksEvergreenUsers,
        [Description("Project Bulk Updaters")]
        ProjectBulkUpdaters,
        [Description("Project Administrator")]
        ProjectAdministrator
    }
}