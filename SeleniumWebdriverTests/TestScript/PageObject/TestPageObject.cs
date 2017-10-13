using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.PageObject;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.PageObject
{
    //[TestClass]
    public class TestPageObject
    {
        //[TestMethod]
        public void TestPage()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = homePage.NavigateToLogin();
            EnterBug enterbug = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            BugDetail bugDetail = enterbug.NavigateToDetail();
            bugDetail.SelectFromSeverity("trivial");
            ButtonHelper.ClickButton(By.Id("commit"));
        }
    }
}
