using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium.Remote;

namespace DashworksTestAutomation.Helpers
{
    public abstract class BaseFilter
    {
        public abstract void Do(RemoteWebDriver driver);
    }

    public class DateTimeFilter : BaseFilter
    {
        public string Operator { get; set; }
        public DateTime Date { get; set; }

        public override void Do(RemoteWebDriver driver)
        {
            var filterElement = driver.NowAt<FiltersElement>();
        }
    }
}
