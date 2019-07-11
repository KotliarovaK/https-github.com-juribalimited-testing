using System;
using System.Globalization;
using System.Text.RegularExpressions;
using DashworksTestAutomation.Providers;
using RestSharp;

namespace DashworksTestAutomation.Extensions
{
    public static class StringExtensions
    {
        private static readonly Regex SpaceTrimmer = new Regex(@"\s\s+");

        public static bool ContainsText(this string fullText, string term)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            return culture.CompareInfo.IndexOf(fullText, term, CompareOptions.IgnoreCase) >= 0;
        }

        public static string RemoveExtraSpaces(this string str)
        {
            try
            {
                return SpaceTrimmer.Replace(str, " ");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static RestRequest GenerateRequest(this string requestUri)
        {
            var request = new RestRequest(requestUri);

            request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
            request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("Referer", UrlProvider.EvergreenUrl);

            return request;
        }
    }
}