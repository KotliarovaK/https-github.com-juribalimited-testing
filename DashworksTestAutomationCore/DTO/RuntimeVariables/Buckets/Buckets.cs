using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;

namespace DashworksTestAutomation.DTO.RuntimeVariables.Buckets
{
    //Created buckets names are stored here
    public class Buckets
    {
        public List<BucketDto> Value { get; set; }

        public Buckets()
        {
            Value = new List<BucketDto>();
        }
    }
}
