using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]

    internal class EvergreenJnr_ListsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ListsPanel (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"All lists are unique on the Lists panel")]
        public void ThenAllListsIsUniqueOnTheListsPanel()
        {
            var lists = _driver.NowAt<CustomListElement>();
            var listData = lists.GetAllListNames();

            //Get all elements that has more than one occurence in the list
            var duplicates = listData.GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .Where(x => x.Count > 1).ToList();
            if (duplicates.Any())
                throw new Exception($"Some duplicates are spotted in the column");
        }
    }
}
