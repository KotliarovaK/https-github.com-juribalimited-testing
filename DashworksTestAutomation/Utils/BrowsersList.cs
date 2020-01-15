using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace DashworksTestAutomation.Utils
{
    public class BrowsersList
    {
        private List<RemoteWebDriver> _drivers = new List<RemoteWebDriver>();

        private Thread _pingDriversThread = null;

        private RemoteWebDriver DriverInUse { get; set; }

        //id starts from 0 where zero is the main browser
        public RemoteWebDriver GetBrowser(int id)
        {
            //Drop current driver
            DriverInUse = null;

            if (id > _drivers.Count - 1)
            {
                throw new Exception($"Unable to get driver with {id} id");
            }

            //Set new current driver
            DriverInUse = _drivers[id];

            //Start ping thread if not yet started
            if (_pingDriversThread.Equals(null))
            {
                _pingDriversThread = new Thread(PingDrivers);
            }

            return DriverInUse;
        }

        public void AddDriver(RemoteWebDriver driver)
        {
            _drivers.Add(driver);
        }

        public List<RemoteWebDriver> GetAllBrowsers()
        {
            //Stop ping
            _pingDriversThread?.Abort();
            return _drivers;
        }

        public void PingDrivers()
        {
            try
            {
                var driversForPing = _drivers.Where(x => !x.Equals(DriverInUse));

                foreach (RemoteWebDriver driver in driversForPing)
                {
                    try
                    {
                        driver.IsElementExists(By.XPath(".//body"));
                    }
                    catch (Exception e)
                    {
                        Logger.Write(e);
                    }
                }

                Thread.Sleep(20000);
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
        }
    }
}
