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

        public static List<string> SplitByLinebraeak(this string str)
        {
            return str.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
        }

        public static List<string> Split(this string str, string separator)
        {
            return str.Split(new string[] { separator }, StringSplitOptions.None).ToList();
        }

        public static List<string> Split(this string str, char separator, params char[] additionalSeparators)
        {
            var separators = new List<char> { separator };
            if (additionalSeparators.Any())
            {
                separators.AddRange(additionalSeparators);
            }
            return str.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
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

        public static DateTime GetNextWeekday(this string dayOfWeek)
        {
            var day = EnumExtensions.Parse<DayOfWeek>(dayOfWeek);
            //to get the value for "today or in the next 6 days"
            var start = DateTime.Today.AddDays(1);
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }

        public static string RemoveBracketsText(this string str)
        {
            Regex regex = new Regex(@"\(.*?\)");
            string cleanString = regex.Replace(str, String.Empty).TrimEnd(' ');
            return cleanString;
        }

        public static string GetBracketsValue(this string str)
        {
            Regex regex = new Regex(@"(?<=\()(.*)(?=\))");
            Match m = regex.Match(str);
            var match = m.Value;
            return match;
        }

        public static string ReadJsonProperty(this string str, string property)
        {
            var responseContent = JsonConvert.DeserializeObject<JObject>(str);
            var content = responseContent[property].ToString();
            return content;
        }
    }
}