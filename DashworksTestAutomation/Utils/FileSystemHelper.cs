﻿using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;

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

        public static string WaitForFileWithNameContainingToBeDownloaded(string partOfFileName, int attempts = 15)
        {
            var directory = new DirectoryInfo(GetPathForDownloadsFolder());

            for (int i = 0; i < attempts; i++)
            {
                if (IsFolderContainsFileContainingName(directory, partOfFileName))
                    return GetLastFileWithNameContains(partOfFileName);

                Thread.Sleep(3000);
            }

            throw new Exception($"File containing '{partOfFileName}' name was not downloaded in {attempts} seconds");
        }

        public static string GetPathForDownloadsFolder()
        {
            var downloadFolder = ConfigurationManager.AppSettings["downloadsFolder"];
            return downloadFolder.Equals("DEFAULT_DOWNLOADS_FOLDER") ? Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Downloads") : downloadFolder;
        }

        private static bool IsFolderContainsFileContainingName(DirectoryInfo directory, string partOfFileName)
        {
            return directory.GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .Any(x => x.Name.Contains(partOfFileName));
        }

        public static string GetLastFileWithNameContains(string partOfFileName)
        {
            var directory = new DirectoryInfo(GetPathForDownloadsFolder());

            if (!IsFolderContainsFileContainingName(directory, partOfFileName))
            {
                throw new Exception($"File containing '{partOfFileName}' name was not found");
            }

            var file = directory.GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .First(x => x.Name.Contains(partOfFileName)).FullName;

            return file;
        }
    }
}