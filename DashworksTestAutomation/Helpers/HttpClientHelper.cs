using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;

namespace DashworksTestAutomation.Helpers
{
    public class HttpClientHelper
    {
        private CookieContainer cookies = new CookieContainer();
        private HttpClientHandler handler = new HttpClientHandler();

        public IEnumerable<OpenQA.Selenium.Cookie> _cookiesJar = null;

        public HttpClientHelper()
        {
            handler.CookieContainer = cookies;
        }

        public HttpClientHelper(UserDto credentials, RestClient client)
        {
            handler.CookieContainer = cookies;
            var auth = client.GetAuthenticationDetails(UrlProvider.Url);
            InitCookies(credentials, auth);
        }

        private void InitCookies(UserDto credentials, AuthObject auth)
        {
            var loginUrl = $"{UrlProvider.Url}LoginSplash.aspx?ReturnUrl=/";

            if (_cookiesJar == null)
            {
                using (var httpClient = new HttpClient(handler))
                {
                    var uri = new Uri(loginUrl);

                    var content = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("__VIEWSTATEGENERATOR", auth.ViewstateGenerator),
                        new KeyValuePair<string, string>("__VIEWSTATE", auth.Viewstate),
                        new KeyValuePair<string, string>("__EVENTVALIDATION", auth.Eventvalidation),
                        new KeyValuePair<string, string>("TB_UserName", credentials.UserName),
                        new KeyValuePair<string, string>("TB_Password", credentials.Password),
                        new KeyValuePair<string, string>("Btn_Login", "Login"),
                    });

                    // Execute Authorisation request
                    var results = httpClient.PostAsync(loginUrl, content).Result;

                    // Get all cookies
                    _cookiesJar = cookies.GetCookies(uri).Cast<Cookie>().Select(x=>x.ToSeleniumCookies());
                }
            }
        }
    }
}
