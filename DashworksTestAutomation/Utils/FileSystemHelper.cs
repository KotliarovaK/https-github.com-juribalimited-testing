using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DashworksTestAutomation.Utils
{
    internal class FileSystemHelper
    {
        public static void EnsureScreensotsFolderExists()
        {
            var folder = GetScreenshotFolder();
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
        }

        public static string GetPathForScreenshot(string testName)
        {
            var date = DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            var fileName = $"{testName}_{date}.png";

            return Path.Combine(GetScreenshotFolder(), fileName);
        }

        private static string GetScreenshotFolder()
        {
            return ConfigurationManager.AppSettings["screenshotsFolder"];
        }

        public static string GeneratePathToEmbeddedResource(string pathPart)
        {
            if (string.IsNullOrEmpty(pathPart))
                throw new Exception("Path not set");

            string executingAssemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var pathParts = new List<string>() { executingAssemblyFolder, "TestData" };
            pathParts.AddRange(pathPart.Split('\\'));
            var fullPath = Path.Combine(pathParts.ToArray());

            return fullPath;
        }

        public static IList<T> ReadJsonListFromSystem<T>(string pathToJson)
        {
            var fullPath = FileSystemHelper.GeneratePathToEmbeddedResource(pathToJson);
            var reader = new StreamReader(fullPath);
            string myJson = reader.ReadToEnd();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(myJson);
        }

        public static object ReadJsonFromSystem<T>(string pathToJson)
        {
            var fullPath = FileSystemHelper.GeneratePathToEmbeddedResource(pathToJson);
            var reader = new StreamReader(fullPath);
            string myJson = reader.ReadToEnd();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(myJson);
        }
    }
}