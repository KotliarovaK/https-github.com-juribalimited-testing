using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.TestScript.MouseActions
{
    //[TestClass]
    public class TestMouseActions
    {
        //[TestMethod]
        public void TestContextClick() //right click of the mouse
        {
            NavigationHelper.NagigateToURL("http://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("draggable"));

            act.ContextClick(ele)
                .Build()
                .Perform();

            Thread.Sleep(5000);
        }

        //[TestMethod]
        public void TestDragAndDrop() //drags and drops an object using the mouse
        {
            NavigationHelper.NagigateToURL("http://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement sourceObject = ObjectRepository.Driver.FindElement(By.Id("draggable")); //set source object to drag
            IWebElement targetObject = ObjectRepository.Driver.FindElement(By.Id("droptarget")); //set target object to drop to

            act.DragAndDrop(sourceObject, targetObject)
                .Build()
                .Perform();

            Thread.Sleep(5000);
        }

        //[TestMethod]
        public void TestClickAndHold() //simulates a left mouse click, and holds onto an element, then moves it to another element
        {
            NavigationHelper.NagigateToURL("http://demos.telerik.com/kendo-ui/sortable/index");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement ele = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[12]")); //set the element you want to click and hold left mouse on
            IWebElement tar = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[2]/span")); //set the element you want to move the element to
            act.ClickAndHold(ele)
                .MoveToElement(tar,0,30) //then moves it to another element
                .Release() //then releases the element
                .Build()
                .Perform();

            Thread.Sleep(10000);
        }
    }
}
