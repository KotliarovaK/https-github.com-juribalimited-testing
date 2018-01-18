using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //We store filter settings in this object
    internal class Filter
    {
        public string FilterName { get; set; }
        public BaseFilter FilterSettings { get; set; }

        public void CheckFilterDate()
        {
            FilterSettings.CheckFilterDate(FilterName);
        }
    }
}