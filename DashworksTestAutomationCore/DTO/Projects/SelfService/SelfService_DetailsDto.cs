using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_DetailsDto
    {
        public bool EnableSelfServicePortal { get; set; }
        public bool AllowAnonymousUsers { get; set; }
        public bool ThisProjectDefault { get; set; }
        public bool Mode1 { get; set; }
        public bool Mode2 { get; set; }
        public string BaseUrl { get; set; }
        public bool NoLink { get; set; }
        public bool DashworksProjectHomepage { get; set; }
        public bool CustomUrl { get; set; }
        public string CustomUrlTextField { get; set; }
    }
}