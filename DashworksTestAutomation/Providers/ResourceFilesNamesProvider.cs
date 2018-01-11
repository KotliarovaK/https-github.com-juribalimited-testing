using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Providers
{
    public static class ResourceFilesNamesProvider
    {
        private static string ResourcesFolderName => "\\Resources";

        public static string CorrectFile => $"{ResourcesFolderName}\\CorrectFile.png";
        public static string IncorrectFile => $"{ResourcesFolderName}\\IncorrectFile.zip";
    }
}
