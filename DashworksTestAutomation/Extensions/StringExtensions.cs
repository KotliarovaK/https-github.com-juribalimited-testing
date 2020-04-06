using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using AutomationUtils.Extensions;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;
using RestSharp;

namespace DashworksTestAutomation.Extensions
{
    public static class StringExtensions
    {
        public static RestRequest GenerateRequest(this string requestUri)
        {
            var request = new RestRequest(requestUri);

            request.AddParameter("origin", UrlProvider.Url.TrimEnd('/'));
            request.AddParameter("referer", UrlProvider.EvergreenUrl);

            return request;
        }

        public static Table CsvToTable(this string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new Exception("Unable to convert empty string to Table");

            var fileLines = str.Replace("\"", "").SplitByLinebraeak();

            if (!fileLines.Any())
                throw new Exception("File content is empty, nothing to convert to Table");

            var table = new Table(fileLines.First().Split(','));

            for (int i = 1; i < fileLines.Count; i++)
            {
                if (string.IsNullOrEmpty(fileLines[i]))
                    continue;
                table.AddRow(fileLines[i].Split(','));
            }

            return table;
        }

        public static string ToDate(this string str)
        {
            string format = "yyyy-MM-dd";

            string strFormat = str.Split(')').LastOrDefault();

            if (!string.IsNullOrEmpty(strFormat))
                format = strFormat;

            if (string.IsNullOrEmpty(str))
                return str;

            if (str.StartsWith("D(") && str.EndsWith(")"))
            {
                Regex regex = new Regex(@"(?<=\()(.*)(?=\))");
                Match m = regex.Match(str);
                var match = m.Value;
                var isNumeric = int.TryParse(match, out int n);
                if (isNumeric)
                    return DateTime.Now.AddDays(int.Parse(match)).ToString(format);
            }

            return str;
        }
    }
}