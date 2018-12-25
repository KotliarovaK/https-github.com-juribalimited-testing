﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Base
{
    public abstract class SeleniumBasePage
    {
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
                    (object) a != null
                    && a != null)
                .Select(ByFactory.From)
                .ToList();
        }

        public By SelectorFor<TPage, TProperty>(TPage page, Expression<Func<TPage, TProperty>> expression)
        {
            var attribute = ReflectionExtensions.ResolveMember(page, expression)
                .GetFirstDecoration<FindsByAttribute>();
            return ByFactory.From(attribute);
        }
    }
}