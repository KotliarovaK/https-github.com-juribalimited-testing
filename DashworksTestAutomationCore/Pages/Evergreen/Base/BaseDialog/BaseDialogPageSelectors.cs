using System;
using System.Collections.Generic;
using System.Text;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomationCore.Pages.Evergreen.Base.BaseDialog
{
    public class BaseDialogPageSelectors
    {
        public const string PopupSelector = ".//mat-dialog-container[contains(@class, 'dialogContainer')]";
    }
}
