﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class ActionsElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='actions-container']")]
        public IWebElement ActionsPanel { get; set; }

        private const string RowsSelectedCountSelctor = ".//div[@class='actions-container-row-select']";

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List name']")]
        public IWebElement ListNameTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='CREATE']//ancestor::button")]
        public IWebElement CreateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Cancel']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='styleSelectDropdown']")]
        public IWebElement DropdownBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='REMOVE']//ancestor::button")]
        public IWebElement RemoveButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ActionsPanel),
            };
        }

        public string GetSelectedRowsCount()
        {
            return Driver.FindElement(By.XPath(RowsSelectedCountSelctor)).Text.Split(' ').First();
        }
    }
}