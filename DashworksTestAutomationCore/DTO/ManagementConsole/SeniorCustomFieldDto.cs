using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.ManagementConsole
{
    public class SeniorCustomFieldDto
    {
        public string FieldName { get; set; }
        public string FieldLabel { get; set; }

        public bool AllowExternalUpdate { get; set; }
        public bool Enabled { get; set; }

        public bool User { get; set; }
        public bool Computer { get; set; }
        public bool Application { get; set; }
        public bool Mailbox { get; set; }

        private string _id;
        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                    _id = DatabaseHelper.GetCustomFieldId(this.FieldLabel);

                return _id;
            }
        }
    }
}
