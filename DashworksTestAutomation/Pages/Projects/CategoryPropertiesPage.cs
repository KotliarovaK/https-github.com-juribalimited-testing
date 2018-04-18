﻿using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class CategoryPropertiesPage : BaseDashboardPage
    {


        [FindsBy(How = How.XPath, Using = ".//input[@id='tb_Name']")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@id='tb_Description']")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@id='select_ObjectType']")]
        public IWebElement ObjectType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='btn_Create']")]
        public IWebElement ConfirmCreateCategoryButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Name),
                SelectorFor(this, p => p.Description),
                SelectorFor(this, p => p.ObjectType)
            };
        }
    }
}