using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Login
{
    [Binding]
    class BaseLoginActions : SpecFlowContext
    {
        protected readonly RestWebClient _client;
        protected readonly UsedUsers UsedUsers;
        protected readonly UserDto User;

        public BaseLoginActions(UserDto user, UsedUsers usedUsers, RestWebClient client)
        {
            User = user;
            UsedUsers = usedUsers;
            _client = client;
        }

        protected UserDto GetFreeUserAndAddToUsedUsersList()
        {
            var user = UserProvider.GetFreeUserAccount();
            UsedUsers.Value.Add(user);

            //Add user credentials to context
            user.CopyPropertiesTo(User);
            return user;
        }

        protected void LoginViaApi(RemoteWebDriver driver)
        {
            var user = GetFreeUserAndAddToUsedUsersList();

            var restClient = new RestClient(UrlProvider.Url);
            //Get cookies
            var client = new HttpClientHelper(user, restClient);

            //Init session
            if (driver != null)
            {
                driver.NavigateToUrl(UrlProvider.Url);

                //Set cookies to browser
                foreach (var cookie in client.SeleniumCookiesJar)
                {
                    //TODO remove this workaround for Expiry until https://github.com/Codeception/Codeception/issues/5401 not fixed
                    OpenQA.Selenium.Cookie nc = new Cookie(cookie.Name, cookie.Value, cookie.Path, DateTime.Now.AddDays(1));
                    driver.Manage().Cookies.AddCookie(nc);
                }
            }

            // Add cookies to the RestClient to authorize it
            _client.Value.AddCookies(client.CookiesJar);

            //Change profile language
            try
            {
                _client.ChangeUserProfileLanguage(User.UserName, User.Language);
            }
            catch (Exception)
            {
                _client.ChangeUserProfileLanguage(User.UserName, User.Language);
            }
        }

        protected void LoginViaApiOnSenior(RemoteWebDriver driver)
        {
            var user = GetSupperAdminAndAddToUsedUsersList();

            var restClient = new RestClient(UrlProvider.Url);
            //Get cookies
            var client = new HttpClientHelper(user, restClient);

            //Init session
            if (driver != null)
            {
                driver.NavigateToUrl(UrlProvider.Url);

                //Set cookies to browser
                foreach (var cookie in client.SeleniumCookiesJar)
                {
                    //TODO remove this workaround for Expiry until https://github.com/Codeception/Codeception/issues/5401 not fixed
                    OpenQA.Selenium.Cookie nc = new Cookie(cookie.Name, cookie.Value, cookie.Path, DateTime.Now.AddDays(1));
                    driver.Manage().Cookies.AddCookie(nc);
                }
            }

            // Add cookies to the RestClient to authorize it
            _client.Value.AddCookies(client.CookiesJar);
        }

        protected UserDto GetSupperAdminAndAddToUsedUsersList()
        {
            var user = UserProvider.GetSupperAdmin();
            UsedUsers.Value.Add(user);

            //Add user credentials to context
            user.CopyPropertiesTo(User);
            return user;
        }
    }
}
