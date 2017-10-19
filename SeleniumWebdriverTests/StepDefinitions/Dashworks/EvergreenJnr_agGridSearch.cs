using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;

namespace SeleniumWebdriverTests.StepDefinitions.Dashworks
{
    [Binding]
    public sealed class EvergreenJnr_ListSearch
    {
        public string rowsXPath;
        public string strValueLength;
        public int intValueLength;
        public int i;

        #region Then

        [Then(@"User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned")]
        public void ThenUserEntersSearchCriteriaIntoTheAgGridSearchBoxAndTheCorrectNumberOfRowsAreReturned(Table table)
        {
                foreach (var row in table.Rows)
                {
                    TextBoxHelper.ClearTextBox(By.XPath("//input[contains(@class,'test-dg-vsbl')]"));
                    Thread.Sleep(1000);
                    TextBoxHelper.TypeInTextBox(By.XPath("//input[contains(@class,'test-dg-vsbl')]"), row["SearchCriteria"]);
                    Thread.Sleep(3000);

                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);

                if (GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-container']")))
                    {
                        rowsXPath = "//span[.='" + row["NumberOfRows"] + " rows']";
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath(rowsXPath)));
                        Console.WriteLine("Evergreen agGrid Search returned the correct number of rows for: {0}", row["SearchCriteria"] + " search");     
                    }
                else
                    {
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-containertesting']")));
                    rowsXPath = "//span[.='" + row["NumberOfRows"] + " rows']";
                    Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath(rowsXPath)));
                    Console.WriteLine("Evergreen agGrid Search returned the correct number of rows for: {0}", row["SearchCriteria"] + " search");
                    }

                Thread.Sleep(1000);
                GenericHelper.TakeScreenShot();
                }
        }

        [Then(@"Clearing the agGrid Search Box")]
        public void ThenClearingTheAgGridSearchBox(Table table)
        {
            foreach (var row in table.Rows)
            {
                strValueLength = row["SearchValueLength"];
                intValueLength = Convert.ToInt32(strValueLength);

                for (int i = 1; i <= intValueLength; i++)
                {
                    ObjectRepository.Driver.FindElement(By.XPath("//input[contains(@class,'test-dg-vsbl')]")).SendKeys(Keys.Backspace);
                }
                Thread.Sleep(3000);
            }
        }


        [Then(@"All rows are displayed in the agGrid")]
        public void ThenAllRowsAreDisplayedInTheAgGrid(Table table)
        {
            foreach (var row in table.Rows)
            {
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-container']")));

                rowsXPath = "//span[.='" + row["NumberOfRows"] + " rows']";
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath(rowsXPath)));
                Console.WriteLine("Clearing the agGrid Search returned the correct number of rows");
                GenericHelper.TakeScreenShot();
            }
        }

        [Then(@"User enters invalid SearchCriteria into the agGrid Search Box and No Devices are found")]
        public void ThenUserEntersInvalidSearchCriteriaIntoTheAgGridSearchBoxAndNoDevicesAreFound(Table table)
        {
            foreach (var row in table.Rows)
            {
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                TextBoxHelper.ClearTextBox(By.XPath("//input[contains(@class,'test-dg-vsbl')]"));
                Thread.Sleep(1000);

                TextBoxHelper.TypeInTextBox(By.XPath("//input[contains(@class,'test-dg-vsbl')]"), row["SearchCriteria"]);
                Thread.Sleep(5000);

                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[.='No devices found']")));
                Console.WriteLine("No devices found message was correctly displayed");
                GenericHelper.TakeScreenShot();
            }
        }
        #endregion Then
    }
}
