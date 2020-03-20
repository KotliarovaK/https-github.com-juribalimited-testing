using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
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

        [Then(@"'(.*)' list is displayed in the Lists panel")]
        public void ThenListIsDisplayedInTheListsPanel(string expectedList)
        {
            var lists = _driver.NowAt<CustomListElement>();
            var listData = lists.GetAllListNames();

            Verify.That(listData, Does.Contain(expectedList), "Expected list is missing in Lists Panel");
        }

        [Then(@"'(.*)' list is not displayed in the Lists panel")]
        public void ThenListIsNotDisplayedInTheListsPanel(string listToBeMissing)
        {
            var lists = _driver.NowAt<CustomListElement>();
            var listData = lists.GetAllListNames();

            Verify.That(listData, Does.Not.Contain(listToBeMissing), "Expected list is present in Lists Panel");
        }
    }
}
