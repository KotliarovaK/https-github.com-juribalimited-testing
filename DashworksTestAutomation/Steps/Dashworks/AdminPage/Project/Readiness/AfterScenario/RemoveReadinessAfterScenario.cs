using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Readiness;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.Buckets;
using DashworksTestAutomation.DTO.RuntimeVariables.Readiness;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.Readiness.AfterScenario
{
    [Binding]
    public class RemoveReadinessAfterScenario : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.Readiness.Readiness _readiness;
        private readonly RestWebClient _client;
        private readonly DefaultReadinessId _defaultReadinessId;

        private RemoveReadinessAfterScenario(DTO.RuntimeVariables.Readiness.Readiness readiness, RestWebClient client, DefaultReadinessId defaultReadinessId)
        {
            _readiness = readiness;
            _client = client;
            _defaultReadinessId = defaultReadinessId;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedReadiness()
        {
            //Default readiness
            if (_defaultReadinessId.Value.Any())
            {
                foreach (KeyValuePair<int, int> pair in _defaultReadinessId.Value)
                {
                    try
                    {
                        DatabaseHelper.SetProjectDefaultReadinessId(pair.Key, pair.Value);
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"Some issues appears during set of Default Bucket in after scenario: {e}");
                    }
                }
            }

            //Delete readiness
            if (!_readiness.Value.Any())
                return;

            foreach (ReadinessDto readiness in _readiness.Value)
            {
                try
                {
                    var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/project/{readiness.ProjectId}/readiness/deleteReadiness";
                    var request = requestUri.GenerateRequest();
                    request.AddParameter("selectedObjectsList", DatabaseHelper.GetReadinessId(readiness.ReadinessName, readiness.ProjectId));
                    request.AddParameter("replaceReadinessId", DatabaseHelper.GetProjectReadinessesIds(readiness.ProjectId).FirstOrDefault());

                    var response = _client.Evergreen.Put(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Logger.Write($"Unable to delete '{readiness.ReadinessName}' Readiness via API");
                    }
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Readiness via API: {e}");
                }
            }
        }
    }
}