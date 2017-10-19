using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.DTO;

namespace Autotest.Providers
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
