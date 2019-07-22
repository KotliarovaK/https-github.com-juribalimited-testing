﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;

namespace DashworksTestAutomation.Helpers
{
    public class HttpClientHelper
    {
        private readonly CookieContainer _cookies = new CookieContainer();
        private readonly HttpClientHandler _handler = new HttpClientHandler();

        public IEnumerable<Cookie> CookiesJar;

        public HttpClientHelper()
        {
            _handler.CookieContainer = _cookies;
        }

        public HttpClientHelper(UserDto credentials, RestClient client)
        {
            _handler.CookieContainer = _cookies;
            var auth = client.GetAuthenticationDetails(UrlProvider.Url);
            InitCookies(credentials, auth);
        }

        public IEnumerable<OpenQA.Selenium.Cookie> SeleniumCookiesJar => CookiesJar.Select(x => x.ToSeleniumCookies());

        private void InitCookies(UserDto credentials, AuthObject auth)
        {
            var loginUrl = $"{UrlProvider.Url}LoginSplash.aspx?ReturnUrl=/";

            if (CookiesJar == null)
                using (var httpClient = new HttpClient(_handler))
                {
                    var uri = new Uri(loginUrl);

                    var content = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("__VIEWSTATEGENERATOR", auth.ViewstateGenerator),
                        new KeyValuePair<string, string>("__VIEWSTATE", auth.Viewstate),
                        new KeyValuePair<string, string>("__EVENTVALIDATION", auth.Eventvalidation),
                        new KeyValuePair<string, string>("TB_UserName", credentials.Username),
                        new KeyValuePair<string, string>("TB_Password", credentials.Password),
                        new KeyValuePair<string, string>("Btn_Login", "Login")
                    });

                    // Execute Authorisation request
                    var results = httpClient.PostAsync(loginUrl, content).Result;

                    // Get all cookies
                    CookiesJar = _cookies.GetCookies(uri).Cast<Cookie>();
                }
        }
    }
}