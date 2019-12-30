using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService
{
    class SelfServiceDto
    {
        private string _id;

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

        public int GetId()
        {
            if (string.IsNullOrEmpty(_id))
            {
                _id = this.ServiceId > 0 ?
                    this.ServiceId.ToString() : DatabaseHelper.GetSelfServiceId(this.Name, this.CreatedByUser);
            }
            return int.Parse(_id);
        }

        public bool Equals(SelfServiceDto value)
        {
            SelfServiceDto obj = value as SelfServiceDto;

            List<string> messages = new List<string>();

            if (!int.Equals(ServiceId, obj.ServiceId))
            {
                messages.Add($"Self Service ID is '{obj.ServiceId}', but it should be '{ServiceId}'");
            }

            if (!int.Equals(Name, obj.Name))
            {
                messages.Add($"Self Service Name is '{obj.Name}', but it should be '{Name}'");
            }

            if (!int.Equals(ServiceIdentifier, obj.ServiceIdentifier))
            {
                messages.Add($"Self Service Identifier is '{obj.ServiceIdentifier}', but it should be '{ServiceIdentifier}'");
            }

            if (!int.Equals(Enabled, obj.Enabled))
            {
                messages.Add($"Self Service checkbox 'Enable self service portal' is '{obj.Enabled}', but it should be '{Enabled}'");
            }

            if (!int.Equals(ObjectType, obj.ObjectType))
            {
                messages.Add($"Self Service ObjectType is '{obj.ObjectType}', but it should be '{ObjectType}'");
            }

            if (!int.Equals(ObjectTypeId, obj.ObjectTypeId))
            {
                messages.Add($"Self Service ObjectType is '{obj.ObjectTypeId}', but it should be '{ObjectTypeId}'");
            }

            if (!int.Equals(StartDate, obj.StartDate))
            {
                messages.Add($"Self Service StartDate is '{obj.StartDate}', but it should be '{StartDate}'");
            }

            if (!int.Equals(EndDate, obj.EndDate))
            {
                messages.Add($"Self Service EndDate is '{obj.EndDate}', but it should be '{EndDate}'");
            }

            if (!int.Equals(SelfServiceURL, obj.SelfServiceURL))
            {
                messages.Add($"Self Service URL is '{obj.SelfServiceURL}', but it should be '{SelfServiceURL}'");
            }

            if (!int.Equals(AllowAnonymousUsers, obj.AllowAnonymousUsers))
            {
                messages.Add($"Self Service AllowAnonymousUsers is '{obj.AllowAnonymousUsers}', but it should be '{AllowAnonymousUsers}'");
            }

            if (!int.Equals(ScopeId, obj.ScopeId))
            {
                messages.Add($"Self Service ScopeId is '{obj.ScopeId}', but it should be '{ScopeId}'");
            }

            if (!int.Equals(ScopeName, obj.ScopeName))
            {
                messages.Add($"Self Service ScopeName is '{obj.ScopeName}', but it should be '{ScopeName}'");
            }

            if (!int.Equals(CreatedByUser, obj.CreatedByUser))
            {
                messages.Add($"Self Service CreatedByUser is '{obj.CreatedByUser}', but it should be '{CreatedByUser}'");
            }

            if (messages.Any())
            {

                var result = messages.Aggregate((a, b) => a + "\r\n " + b);
                throw new Exception(result);
            }

            return true;
        }
    }
}
