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
        public bool ModeUser { get; set; }
        public bool ModeComputer { get; set; }
        public string BaseUrl { get; set; }
        public bool NoLink { get; set; }
        public bool DashworksProjectHomepage { get; set; }
        public bool CustomUrl { get; set; }
        //TODO HeaderLogo Choose File
        //TODO BannerImage Choose File
        public string BackgroundColour { get; set; }
        public string PrimaryColour { get; set; }
        public string SecondaryColour { get; set; }
        public string HighlightFontColor { get; set; }
        public string MenuHeaderFontColor { get; set; }
    }
}