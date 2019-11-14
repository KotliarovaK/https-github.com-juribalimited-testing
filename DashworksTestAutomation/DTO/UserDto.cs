using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        private string _confirmPassword;
        public string ConfirmPassword
        {
            get => string.IsNullOrEmpty(_confirmPassword) ? Password : _confirmPassword;
            set => _confirmPassword = value;
        }
        public string Language { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        //Default timezone
        public string TimeZone => "Kaliningrad Standard Time";
        //Just to make it possible to set via table
        public string Roles
        {
            private get { return string.Empty; }
            set
            {
                UserRoles = value.Split(',').ToList();
            }
        }
        public List<string> UserRoles { get; set; }

        public List<string> ApiUserRoles
        {
            get
            {
                var resultList = new List<string>();
                foreach (string role in UserRoles)
                {
                    switch (role)
                    {
                        case "Self Service User":
                            resultList.Add("Self Service Users");
                            break;
                        case "API User":
                            resultList.Add("API Users");
                            break;
                        case "Project Administrator":
                            resultList.Add("Project Administrators");
                            break;
                        case "Project Bulk Updater":
                            resultList.Add("Project Bulk Updaters");
                            break;
                        case "Project Onboarder":
                            resultList.Add("Project Onboarders");
                            break;
                        case "System Administrator":
                            resultList.Add("System Administrators");
                            break;
                        default:
                            resultList.Add(role);
                            break;
                    }
                }

                return resultList;
            }
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //'on' in case disabled
        public string IsDisabled { get; set; }

        private string _id;
        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                {
                    _id = DatabaseHelper.GetUserId(this.Username);
                }
                return _id;
            }
        }
    }
}