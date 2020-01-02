﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    class EvergreenJnr_BaseTable : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseTable(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"table is displayed")]
        public void ThenTableIsDisplayed()
        {
            var page = _driver.NowAt<BaseTable>();
            Verify.IsTrue(page.Table.Displayed(), "Table is not displayed");
        }

        #region Keys

        [Then(@"'(.*)' field is displayed in the table")]
        public void ThenFieldIsDisplayedInTheTable(string key)
        {
            var page = _driver.NowAt<BaseTable>();
            Verify.IsTrue(page.IsRowWithKeyExists(key), $"'{key}' field was not displayed in the table");
        }

        [Then(@"'(.*)' field is not displayed in the table")]
        public void ThenFieldIsNotDisplayedInTheTable(string key)
        {
            var page = _driver.NowAt<BaseTable>();
            Verify.IsFalse(page.IsRowWithKeyExists(key), $"'{key}' field is displayed in the table");
        }

        #endregion

        #region Values

        [Then(@"'(.*)' text is not present in the table")]
        public void ThenTextIsNotPresentInTheTable(string text)
        {
            var page = _driver.NowAt<BaseTable>();
            var listOfValues = page.GetRowsContent();
            Verify.That(listOfValues, Does.Not.Contain(text),
                $"'{text}' item displayed in the table");
        }

        #endregion
    }
}
