using System;
using System.Collections.Generic;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components
{
    public class SelfServiceApplicationOwnershipComponent : BaseSelfServiceComponent
    {
        private string _project;
        public string ProjectName
        {
            get => _project;
            set
            {
                _project = value;
                ExtraProperties.ProjectId = int.Parse(DatabaseHelper.GetProjectId(value));
            }
        }

        private string _ownerPermission;
        public string OwnerPermission
        {
            get => _ownerPermission;
            set
            {
                _ownerPermission = value;
                switch (value)
                {
                    case "Do not allow owner to be changed":
                        ExtraProperties.OwnerChangePermissionId = 1;
                        break;
                    case "Allow owner to be removed only":
                        ExtraProperties.OwnerChangePermissionId = 2;
                        break;
                    case "Allow owner to be set to another user only":
                        ExtraProperties.OwnerChangePermissionId = 3;
                        break;
                    case "Allow owner to be removed or set to another user":
                        ExtraProperties.OwnerChangePermissionId = 4;
                        break;
                    default:
                        throw new Exception($"Unknown Owner Permission: '{value}'");
                }
            }
        }

        private string _userScope;
        public string UserScope
        {
            get => _userScope;
            set
            {
                _userScope = value;
                ExtraProperties.UserListId = int.Parse(DatabaseHelper.GetProjectListIdScope(value));
            }
        }

        public SelfServiceApplicationOwnershipComponent()
        {
            ComponentId = 1;
            ComponentTypeId = 2;
        }

        [JsonProperty("extraProperties")]
        public ApplicationOwnershipExtraProperties ExtraProperties = new ApplicationOwnershipExtraProperties();
    }

    public partial class ApplicationOwnershipExtraProperties
    {
        [JsonProperty("objectTypeId")] public int ObjectTypeId = 2;

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("ownerChangePermissionId")]
        public int OwnerChangePermissionId { get; set; }

        [JsonProperty("userListId")]
        public int UserListId { get; set; }

        [JsonProperty("displayFields")]
        public List<DisplayFields> DisplayFields = new List<DisplayFields>()
        {
            new DisplayFields()
            {
                OwnershipFieldId = -1,
                Order = 1,
                DisplayName = "Username (User)"
            },
            new DisplayFields()
            {
                OwnershipFieldId = -1,
                Order = 2,
                DisplayName = "Domain"
            },
            new DisplayFields()
            {
                OwnershipFieldId = -1,
                Order = 3,
                DisplayName = "Display Name"
            }
        };
    }

    public partial class DisplayFields
    {
        [JsonProperty("ownershipFieldId")]
        public int OwnershipFieldId { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
