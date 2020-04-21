namespace DashworksTestAutomation.Providers
{
    public static class ResourceFilesNamesProvider
    {
        private static string ResourcesFolderName => "\\Resources";

        public static string CorrectFile => "CorrectFile.png";
        public static string IncorrectFile => "IncorrectFile.zip";
        public static string ResourcesFolderRoot => $"{ResourcesFolderName}\\";
    }
}