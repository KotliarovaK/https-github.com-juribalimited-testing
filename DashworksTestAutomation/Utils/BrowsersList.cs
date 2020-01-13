using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace DashworksTestAutomation.Utils
{
    public class BrowsersList
    {
        public List<RemoteWebDriver> Drivers { get; set; }

        private RemoteWebDriver DriverInUse { get; set; }

        //id starts from 0 where zero is the main browser
        public RemoteWebDriver GetBrowser(int id)
        {
            if (id > Drivers.Count - 1)
            {
                throw new Exception($"Unable to get driver with {id} id");
            }

            DriverInUse = Drivers[id];

            return DriverInUse;
        }

        public void PingDrivers()
        {
            try
            {
                var driversForPing = Drivers.Where(x => !x.Equals(DriverInUse));

                foreach (RemoteWebDriver driver in driversForPing)
                {
                    driver.IsElementExists(By.XPath(".//body"));
                }
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
        }
    }
}
