using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.RuntimeVariables;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.API
{
    [Binding]
    internal class EvergreenJnr_ListDetailsPage
    {
        private readonly ResponceDetails _responce;

        public EvergreenJnr_ListDetailsPage(ResponceDetails responce)
        {
            _responce = responce;
        }

        [Then(@"""(.*)"" field display state is ""(.*)"" on Details tab API")]
        public void ThenFieldIsDisplayedOnDetailsTab(string fieldName, string state)
        {
            var content = _responce.Value.Content;
            var allItems = JsonConvert.DeserializeObject<JObject>(content)["metadata"];
            try
            {
                var item = allItems.First(x => x["friendlyName"].ToString().Equals(fieldName));
                Assert.AreEqual(state, item["visible"].ToString(), $"Incorrect display state for {fieldName}");
            }
            catch
            {
                Assert.AreEqual(state, "False", $"Incorrect display state for {fieldName}");
            }
        }

        [Then(@"""(.*)"" text displayed for ""(.*)"" empty fields")]
        public void ThenTextDisplayedForEmptyFields(string text, string sectionName)
        {
            var content = _responce.Value.Content;
            var allFields = JsonConvert.DeserializeObject<JObject>(content)["results"];
            foreach (var pair in allFields)
            {
                if (pair.ToString().Contains("address2") || pair.ToString().Contains("address3") ||
                    pair.ToString().Contains("address4") ||
                    pair.ToString().Contains("pendingStickyDepartmentMessage") ||
                    pair.ToString().Contains("pendingStickyLocationMessage"))
                    continue;
                Assert.IsFalse(!string.IsNullOrEmpty(pair.Last.ToString()),
                    "'Unknown' text is displayed for field ");
            }
        }
    }
}
