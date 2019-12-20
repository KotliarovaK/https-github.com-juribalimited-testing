using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService
{
    class SelfServiceDto
    {
        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serviceIdentifier")]
        public string ServiceIdentifier { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("objectTypeId")]
        public int ObjectTypeId { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("selfServiceURL")]
        public string SelfServiceURL { get; set; }

        [JsonProperty("allowAnonymousUsers")]
        public bool AllowAnonymousUsers { get; set; }

        [JsonProperty("scopeId")]
        public int ScopeId { get; set; }

        [JsonProperty("scopeName")]
        public string ScopeName { get; set; }

        [JsonProperty("createdByUser")]
        public string CreatedByUser { get; set; }

        public bool Equals(SelfServiceDto value)
        {
            SelfServiceDto obj = value as SelfServiceDto;

            return !Object.ReferenceEquals(null, obj)
                && int.Equals(ServiceId, obj.ServiceId)
                && String.Equals(Name, obj.Name)
                && String.Equals(ServiceIdentifier, obj.ServiceIdentifier)
                && String.Equals(Enabled, obj.Enabled)
                && String.Equals(ObjectType, obj.ObjectType)
                && String.Equals(ObjectTypeId, obj.ObjectTypeId)
                && String.Equals(StartDate, obj.StartDate)
                && String.Equals(EndDate, obj.EndDate)
                && String.Equals(SelfServiceURL, obj.SelfServiceURL)
                && String.Equals(AllowAnonymousUsers, obj.AllowAnonymousUsers)
                && int.Equals(ScopeId, obj.ScopeId)
                && String.Equals(ScopeName, obj.ScopeName)
                && String.Equals(CreatedByUser, obj.CreatedByUser);
        }
    }
}
