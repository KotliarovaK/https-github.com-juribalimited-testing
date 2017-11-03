﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class CustomListElemnt : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='listEdit list-edit-wrapper']")]
        public IWebElement CreateCustomListElement { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='action-item']")]
        public IWebElement CreateNewListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='List Name']")]
        public IWebElement ListNameTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Save List']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Cancel']")]
        public IWebElement CancelButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateCustomListElement),
                SelectorFor(this, p => p.CreateNewListButton)
            };
        }
    }
}