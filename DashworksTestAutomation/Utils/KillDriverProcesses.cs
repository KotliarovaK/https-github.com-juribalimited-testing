using System.Diagnostics;

namespace DashworksTestAutomation.Utils
{
    public class KillDriverProcesses
    {
        public static void Do()
        {
            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName.Equals("chrome") || process.ProcessName.Equals("chromedriver") ||
                    process.ProcessName.Equals("firefox"))
                {
                    try
                    {
                        process.Kill();
                    }
                    catch { }
                }
            }
        }
    }
}
