﻿using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class TaskProperties_DetailsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'TaskControlTypeID')]")]
        public IWebElement ValueType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'HasDueDate')]")]
        public IWebElement TaskHaADueDate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'HookType')]")]
        public IWebElement TaskProjectRole { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AffectsStatus')]")]
        public IWebElement TaskImpactsReadiness { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'HasOwner')]")]
        public IWebElement TaskHasAnOwner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowLastChangeInfo')]")]
        public IWebElement ShowDetails { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'DateMode')]")]
        public IWebElement DateMode { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ProjectObject')]")]
        public IWebElement ProjectObject { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'BulkUpdate')]")]
        public IWebElement BulkUpdate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SelfService')]")]
        public IWebElement SelfService { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Update Task']")]
        public IWebElement UpdateTaskButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Publish Task...']")]
        public IWebElement PublishTaskButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Unpublish Task...']']")]
        public IWebElement UnpublishTaskButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ValueType),
                SelectorFor(this, p => p.TaskHaADueDate),
                SelectorFor(this, p => p.TaskProjectRole),
                SelectorFor(this, p => p.TaskImpactsReadiness),
                SelectorFor(this, p => p.TaskHasAnOwner),
                SelectorFor(this, p => p.ShowDetails),
                SelectorFor(this, p => p.ProjectObject),
                SelectorFor(this, p => p.BulkUpdate),
                SelectorFor(this, p => p.SelfService)
            };
        }
    }
}