using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO;
using RestSharp;

namespace DashworksTestAutomation.Providers
{
    internal class UserProvider
    {
        public static string DefaultUserLanguage = ConfigurationManager.AppSettings["user.language"];
        private static readonly bool UseSupperAdmin = bool.Parse(ConfigurationManager.AppSettings["useSupperAdmin"]);

        static readonly RestClient client = new RestClient(JuribaAutomationApiProvider.Uri);

        private static readonly Mutex _mut = new Mutex();

        //private static int _iter;

        public static string Password = ConfigurationManager.AppSettings["user.password"];

        private static readonly List<UserDto> _accounts = new List<UserDto> { };

        static UserProvider()
        {
            for (var i = 2; i < int.Parse(ConfigurationManager.AppSettings["availableUsersRange"]); i++)
                _accounts.Add(new UserDto
                {
                    Username = $"automation_admin{i}",
                    Password = Password,
                    Language = DefaultUserLanguage
                });
        }

        public static UserDto GetSupperAdmin()
        {
            return new UserDto()
            {
                Username = $"admin",
                Password = Password,
                Language = DefaultUserLanguage
            };
        }

        public static UserDto GetFreeUserAccount()
        {
            if (UseSupperAdmin)
            {
                return GetSupperAdmin();
            }
            var iterator = GetUserIterator();
            _mut.WaitOne(1000);
            try
            {
                var account = _accounts[iterator];
                iterator++;
                return account;
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to get user with '{iterator}' iterator: {e}");
            }
            finally
            {
                _mut.ReleaseMutex();
            }
        }

        private static int GetUserIterator()
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    var request = new RestRequest("users", Method.GET);
                    IRestResponse response = client.Execute(request);
                    var iterator = int.Parse(response.Content);
                    return iterator;
                }
                catch
                {
                    Thread.Sleep(2000);
                }
            }

            throw new Exception("Unable to get user iterator from API");
        }
    }
}