using System;

//Convertor for account preference language 

namespace DashworksTestAutomation.Helpers
{
    internal class PreferenceLanguageConverter
    {
        public static string Convert(string fullLanguage)
        {
            string langToLower = fullLanguage.ToLower();

            switch (langToLower)
            {
                case "english us":
                    return "en-US";
                case "english uk":
                    return "en-GB";
                case "deutsch":
                    return "de-DE";
                case "français":
                    return "fr-FR";
                case "test language":
                    return "yo";

                default:
                    throw new Exception($"{fullLanguage} lng not found in convertor");
            }
        }
    }
}