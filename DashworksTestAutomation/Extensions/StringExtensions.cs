﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using DashworksTestAutomation.Providers;
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
    }
}