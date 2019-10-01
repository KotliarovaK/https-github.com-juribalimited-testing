﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Base
{
    public abstract class SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//body")]
        public IWebElement BodyContainer { get; set; }

        public RemoteWebDriver Driver { get; set; }

        public Actions Actions { get; set; }

        public IWebStorage Storage;

        public void InitElements()
        {
            PageFactory.InitElements(Driver, this);
            Storage = new RemoteWebStorage((RemoteWebDriver)Driver);
        }

        public virtual List<By> GetPageIdentitySelectors()
        {
            return GetType()
                .GetProperties()
                .Select(p => p.GetFirstDecoration<FindsByAttribute>())
                .Where(a =>
                    (object)a != null
                    && a != null)
                .Select(DashworksTestAutomation.Utils.ByFactory.From)
                .ToList();
        }

        public By SelectorFor<TPage, TProperty>(TPage page, Expression<Func<TPage, TProperty>> expression)
        {
            var attribute = ReflectionExtensions.ResolveMember(page, expression)
                .GetFirstDecoration<FindsByAttribute>();
            return DashworksTestAutomation.Utils.ByFactory.From(attribute);
        }

        public void CheckElementDisabledState(IWebElement element, bool expectedCondition, string exceptionMessage)
        {
            Driver.WaitForElementToBeDisplayed(element);
            Verify.AreEqual(expectedCondition, element.Disabled(), exceptionMessage);
        }

        public void CheckElementDisplayedState(IWebElement element, bool expectedCondition, string exceptionMessage)
        {
            Verify.AreEqual(expectedCondition, Driver.IsElementDisplayed(element, WebDriverExtensions.WaitTime.Short), exceptionMessage);
        }

        //Usage By selector = page.GetByFor(() => page.LoginButton);
        public By GetByFor<TProperty>(Expression<Func<TProperty>> expression)
        {
            var attribute = ReflectionExtensions.ResolveMember(expression).GetFirstDecoration<FindsByAttribute>();
            return ByFactory.From(attribute);
        }

        //Usage By selector = page.GetByFor(() => page.LoginButton);
        public string GetStringByFor<TProperty>(Expression<Func<TProperty>> expression)
        {
            var attribute = ReflectionExtensions.ResolveMember(expression).GetFirstDecoration<FindsByAttribute>();
            return ByFactory.From(attribute).ToString().Split(": ").Last();
        }

        //Usage By selector = page.Click(() => page.LoginButton);
        //For cases when element can be Staled
        public void Click<TProperty>(Expression<Func<TProperty>> expression)
        {
            var by = GetByFor(expression);
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Driver.FindElement(by).Click();
                    return;
                }
                catch (NoSuchElementException)
                {
                    Thread.Sleep(1000);
                }
                catch (StaleElementReferenceException)
                {
                    Thread.Sleep(1000);
                }
                catch (NullReferenceException)
                {
                    Thread.Sleep(1000);
                }
                catch (TargetInvocationException)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}