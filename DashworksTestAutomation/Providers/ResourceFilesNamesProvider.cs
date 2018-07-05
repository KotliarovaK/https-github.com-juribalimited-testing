namespace DashworksTestAutomation.Providers
{
    public static class ResourceFilesNamesProvider
    {
        private static string ResourcesFolderName => "\\Resources";

        public static string CorrectFile => $"{ResourcesFolderName}\\CorrectFile.png";
        public static string IncorrectFile => $"{ResourcesFolderName}\\IncorrectFile.zip";
        public static string CorrectFileDas12370 => $"{ResourcesFolderName}\\CorrectFile_DAS12370.xml";
    }
}