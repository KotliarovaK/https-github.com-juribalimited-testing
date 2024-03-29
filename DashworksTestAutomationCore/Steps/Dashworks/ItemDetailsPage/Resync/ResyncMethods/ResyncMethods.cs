﻿using System;
using System.Net;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;

namespace DashworksTestAutomationCore.Steps.Dashworks.ItemDetailsPage.Resync.ResyncMethods
{
    public class ResyncMethods
    {
        private RestWebClient _client;

        public ResyncMethods(RestWebClient client)
        {
            _client = client;
        }

        public void Resync(ResyncItemst item)
        {
            foreach (string itemName in item.Objects)
            {
                var id = DatabaseHelper.GetItemId(item.List, itemName);
                var projId = DatabaseHelper.GetProjectId(item.ProjectName);
                var requestUri = $"{UrlProvider.RestClientBaseUrl}{item.List.ToLower()}/{id}/relinkObjects";
                var request = requestUri.GenerateRequest();
                request.AddParameter("projectId", projId);
                switch (item.List)
                {
                    case "Device":
                        request.AddParameter("IsOwnerResync", true);
                        request.AddParameter("IsAppsResync", true);
                        break;
                    case "User":
                        request.AddParameter("IsAppsResync", true);
                        break;
                    case "Application":
                        request.AddParameter("IsAppAttributesResync", true);
                        request.AddParameter("IsOwnerResync", true);
                        break;
                    case "Mailbox":
                        request.AddParameter("IsOwnerResync", true);
                        break;
                    default:
                        throw new Exception($"Unknown list type: {item.List}");
                }

                request.AddParameter("IsNameResync", true);
                request.AddParameter("IsSkipRelink", true);
                request.AddParameter("objectId", id);

                var response = _client.Evergreen.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Unable to resynk '{itemName}' {item.List} object for '{item.ProjectName}' project: {response.StatusCode}, {response.ErrorMessage}");
                }

                //Ping application about project status
                var projRequestUri = $"{UrlProvider.RestClientBaseUrl}{item.List}/{id}/project?$lang=en-GB&projectId={projId}";
                var projRequest = projRequestUri.GenerateRequest();

                var projResponse = _client.Evergreen.Get(projRequest);

                if (projResponse.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Bad request from proj details. Unable to resynk '{itemName}' {item.List} object for '{item.ProjectName}' project: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
        }
    }
}
