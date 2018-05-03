using RestSharp;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //We store responce data in the variable to assert its parts in further steps
    internal class ResponceDetails
    {
        public IRestResponse Value { get; set; }
    }
}