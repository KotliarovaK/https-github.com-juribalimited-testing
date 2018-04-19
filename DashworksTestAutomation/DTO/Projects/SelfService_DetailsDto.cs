using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_DetailsDto
    {
        public bool EnableSelfServicePortal;
        public bool AllowAnonymousUsers;
        public bool ThisProjectDefault;
        //TODO public bool SelfServiceMode;
        public string BaseUrl { get; set; }
        //TODO public bool HeaderLogoUrl;
        //TODO HeaderLogo Choose File
        //TODO BannerImage Choose File
        public string BackgroundColour { get; set; }
        public string PrimaryColour { get; set; }
        public string SecondaryColour { get; set; }
        public string HighlightFontColor { get; set; }
        public string MenuHeaderFontColor { get; set; }
    }
}