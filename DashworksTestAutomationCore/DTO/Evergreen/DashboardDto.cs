using System;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Utils;

namespace DashworksTestAutomation.DTO.Evergreen.Admin
{
    public class DashboardDto
    {
        private string _id;

        public string DashboardId
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                {
                    if (User == null)
                    {
                        throw new Exception($"Unable to get '{DashboardName}' dashboard as related User is not set");
                    }

                    _id = DatabaseHelper.GetDashboardId(DashboardName, User.Id);
                }

                return _id;
            }
            set => _id = value;
        }

        public string DashboardName { get; set; }
        public string SharedAccessType { get; set; }
        public UserDto User { get; set; }
    }
}