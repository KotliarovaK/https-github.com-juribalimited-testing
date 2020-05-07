using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomationCore.Pages.Evergreen.Base.BaseDialog
{
    public class BaseDialogGridPage : BaseGridPage
    {
        [FindsBy(How = How.XPath, Using = BaseDialogPageSelectors.PopupSelector)]
        public IWebElement PopupElement { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.PopupElement)
            };
        }

        #region Column Header

        public IList<IWebElement> GetAllHeaders()
        {
            return GetAllHeaders(this.GetStringByFor(() => this.PopupElement));
        }

        public List<string> GetAllHeadersText()
        {
            return GetAllHeadersText(this.GetStringByFor(() => this.PopupElement));
        }

        #endregion
    }
}
