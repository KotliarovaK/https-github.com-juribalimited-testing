using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using Assert = NUnit.Framework.Assert;

namespace DashworksTestAutomation.Steps
{
    [Binding]
    internal class TestApiStep : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly ResponceDetails _responce;
        private readonly DetailsSectionToUrlConvertor _sectionConvertor;

        public TestApiStep(RestWebClient client, ResponceDetails responce,
            DetailsSectionToUrlConvertor sectionConvertor)
        {
            _client = client;
            _responce = responce;
            _sectionConvertor = sectionConvertor;
        }

        [When(@"I perform test request to the ""(.*)"" API and get ""(.*)"" item summary for ""(.*)"" section")]
        public void WhenIPerformTestRequestToTheApiAndGetItemSummaryForSection(string pageName, string itemName,
            string sectionName)
        {
            var itemId = _client.GetDeviceIdByName(itemName, pageName);
            var section = _sectionConvertor.SectionConvertor(sectionName);
            var requestUri = "";
            if (pageName == "Mailboxes")
            {
                requestUri =
                    $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower().TrimEnd('s').TrimEnd('e')}/{itemId}/{section}?$lang=en-GB";
            }
            else
            {
                requestUri =
                    $"{UrlProvider.RestClientBaseUrl}{pageName.ToLower().TrimEnd('s')}/{itemId}/{section}?$lang=en-GB";
            }

            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            _responce.Value = _client.Value.Get(request);

            if (_responce.Value.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to execute request. URI: {requestUri}");
        }
    }
}