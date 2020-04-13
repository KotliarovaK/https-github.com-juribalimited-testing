using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DashworksTestAutomationCore.Utils
{
    public static class ConfigReader
    {
        private static string ConfigFilePath = $"{Environment.CurrentDirectory}\\appsettings.json";

        public static string ByKey(string key)
        {
            using (StreamReader sr = new StreamReader(ConfigFilePath))
            {
                try
                {
                    string configFileContent = sr.ReadToEnd();

                    var responseContent = JsonConvert.DeserializeObject<JObject>(configFileContent);
                    string value = responseContent[key].ToString();

                    return value;
                }
                catch (Exception e)
                {
                    throw new Exception($"Unable to read configuration property for '{key}' key: {e}");
                }
            }
        }
    }
}
