using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO;

namespace DashworksTestAutomation.Providers
{
    class UserProvider
    {
        private static Mutex _mut = new Mutex();

        private static int _iter;

        public static string Password = ConfigurationManager.AppSettings["user.password"];

        private static List<UserDto> _accounts = new List<UserDto>(){ new UserDto()
            {
                UserName = ConfigurationManager.AppSettings["user.login"],
                Password = Password
            }
        };

        static UserProvider()
        {
            for (int i = 2; i < int.Parse(ConfigurationManager.AppSettings["availableUsersRange"]); i++)
            {
                _accounts.Add(new UserDto()
                {
                    UserName = $"automation_admin{i}",
                    Password = Password
                });
            }
        }

        public static UserDto GetFreeUserAccount()
        {
            _mut.WaitOne(1000);
            try
            {
                var account = _accounts[_iter];
                _iter++;
                return account;
            }
            catch (ArgumentOutOfRangeException)
            {
                _iter = 0;
                return _accounts.FirstOrDefault();
            }
            finally
            {
                _mut.ReleaseMutex();
            }
        }
    }
}
