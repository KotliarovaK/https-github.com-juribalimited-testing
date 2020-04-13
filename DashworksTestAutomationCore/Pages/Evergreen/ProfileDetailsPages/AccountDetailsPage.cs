﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    internal class AccountDetailsPage : SeleniumBasePage
    {
        public const string RoleSelector = "//li[@class='ng-star-inserted']/span";

        [FindsBy(How = How.XPath, Using = ".//input[@id='fileUploader']")]
        public IWebElement UploadButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Full Name']/ancestor::div[@class='form-item']//input")]
        public IWebElement FullNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Email']/ancestor::div[@class='form-item']//input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[@class='roles']/li")]
        public IList<IWebElement> RolesList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//userprofile-account-details//div[@class='img-bg']")]
        public IWebElement UserPicture { get; set; }

        [FindsBy(How = How.XPath, Using = RoleSelector)]
        public IList<IWebElement> AvailableRoles { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.UpdateButton),
                SelectorFor(this, p => p.FullNameField),
                SelectorFor(this, p => p.EmailField),
                SelectorFor(this, p => p.RolesList)
            };
        }
    }
}