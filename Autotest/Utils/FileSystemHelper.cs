﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotest.Utils
{
    class FileSystemHelper
    {
        public static void EnsureScreensotsFolderExists()
        {
            var folder = GetScreenshotFolder();
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
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
    }
}
