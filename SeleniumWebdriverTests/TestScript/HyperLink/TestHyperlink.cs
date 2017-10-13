using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.HyperLink
{
    //[TestClass]
    public class TestHyperlink
    {
        //[TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NagigateToURL(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            LinkHelper.ClickLink(By.PartialLinkText("File"));
        }
    }
}
