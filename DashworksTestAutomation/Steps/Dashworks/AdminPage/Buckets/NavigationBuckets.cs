using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Buckets
{
    [Binding]
    class NavigationBuckets : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Buckets.Buckets _buckets;

        public NavigationBuckets(RemoteWebDriver driver, DTO.RuntimeVariables.Buckets.Buckets buckets)
        {
            _driver = driver;
            _buckets = buckets;
        }

        [When(@"User navigates to newly created Bucket")]
        public void WhenUserNavigatesToNewlyCreatedBucket()
        {
            if (!_buckets.Value.Any())
            {
                throw new Exception("There are no created Buckets to navigate");
            }

            var url = $"{UrlProvider.EvergreenUrl}/#/admin/bucket/{_buckets.Value.Last().GetId()}/settings";
            _driver.NavigateToUrl(url);
            _driver.WaitForDataLoading();
        }
    }
}
