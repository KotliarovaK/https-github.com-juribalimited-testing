using System.Configuration;
using DashworksTestAutomation.DTO;

namespace DashworksTestAutomation.Providers
{
    class UserProvider
    {
        public static UserDto User = new UserDto()
        {
            UserName = ConfigurationManager.AppSettings["user.login"],
            Password = ConfigurationManager.AppSettings["user.password"]
        };
    }
}
