using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Bucket
{
    public class BucketDto
    {
        private string Id;

        public string Name { get; set; }

        public string TeamName
        {
            set => this.Team = new TeamDto() { TeamName = value };
        }
        public TeamDto Team { get; set; }
        public bool IsDefault { get; set; }

        public string Project { get; set; }

        public BucketDto(string id)
        {
            Id = id;
        }

        public BucketDto() { }

        public string GetId()
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = string.IsNullOrEmpty(this.Project) ?
                    DatabaseHelper.GetBucket(this.Name).Id : GetId(this.Project);
            }
            return Id;
        }

        public string GetId(string projectName)
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = DatabaseHelper.GetBucket(this.Name, projectName).Id;
            }
            return Id;
        }
    }
}
