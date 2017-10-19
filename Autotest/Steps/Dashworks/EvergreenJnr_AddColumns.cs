using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autotest.Extensions;
using Autotest.Pages.Evergreen;
using Autotest.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace Autotest.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_AddColumns : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AddColumns(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks the Columns button")]
        public void WhenUserClicksTheColumnsButton()
        {
            var menu = _driver.NowAt<BaseDashbordPage>();
            menu.Column.Click();
            Logger.Write("Column button was clicked");
        }
    }
}
