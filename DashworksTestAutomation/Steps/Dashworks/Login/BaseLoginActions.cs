using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Extensions;
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
        protected readonly AuthObject _authObject;

        public BaseLoginActions(UserDto user, UsedUsers usedUsers, RestWebClient client, AuthObject authObject)
        {
            User = user;
            UsedUsers = usedUsers;
            _client = client;
            _authObject = authObject;
        }

        protected UserDto GetFreeUserAndAddToUsedUsersList()
        {
            var user = UserProvider.GetFreeUserAccount();
            UsedUsers.Value.Add(user);

            //Add user credentials to context
            user.CopyPropertiesTo(User);
            return user;
        }

        protected void LoginViaApiAsUser(RemoteWebDriver driver, UserDto user)
        {
            //Add user credentials to context
            UsedUsers.Value.Add(user);
            user.CopyPropertiesTo(User);

            var restClient = new RestClient(UrlProvider.Url);
            //Get cookies
            var client = new HttpClientHelper(user, restClient);
            //We will use those properties to work with Senior API
            client.AuthObject.CopyPropertiesTo(_authObject);

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
            _client.Evergreen.AddCookies(client.CookiesJar);
            _client.Senior.AddCookies(client.CookiesJar);

            //Change profile language
            try
            {
                _client.ChangeUserProfileLanguage(User.Username, User.Language);
            }
            catch (Exception)
            {
                _client.ChangeUserProfileLanguage(User.Username, User.Language);
            }
        }

        protected void LoginViaApi(RemoteWebDriver driver)
        {
            var user = GetFreeUserAndAddToUsedUsersList();
            LoginViaApiAsUser(driver, user);
        }

        protected void LoginViaApiOnSenior(RemoteWebDriver driver, UserDto user)
        {
            var restClient = new RestClient(UrlProvider.Url);
            //Get cookies
            var client = new HttpClientHelper(user, restClient);
            //We will use those properties to work with Senior API
            client.AuthObject.CopyPropertiesTo(_authObject);

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
            _client.Evergreen.AddCookies(client.CookiesJar);
            _client.Senior.AddCookies(client.CookiesJar);
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
