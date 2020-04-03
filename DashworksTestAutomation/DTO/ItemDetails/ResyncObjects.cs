using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.ItemDetails
{
    public class ResyncObjects
    {
        public List<ResyncItemst> Value { get; set; }

        public ResyncObjects()
        {
            Value = new List<ResyncItemst>();
        }
    }

    public class ResyncItemst
    {
        public string List { get; set; }
        public string ProjectName { get; set; }
        public List<string> Objects { get; set; }
    }
}
