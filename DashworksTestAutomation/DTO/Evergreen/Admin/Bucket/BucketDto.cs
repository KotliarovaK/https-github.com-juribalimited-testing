using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Bucket
{
    class BucketDto
    {
        private string Id;

        public string Name { get; set; }
        public string Team { get; set; }
        public bool IsDefault { get; set; }

        public BucketDto(string id)
        {
            Id = id;
        }

        public BucketDto() { }

        public string GetId()
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = DatabaseHelper.GetBucket(this.Name).Id;
            }

            return Id;
        }
    }
}
