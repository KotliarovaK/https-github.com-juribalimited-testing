using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriverTests.BaseClasses;
using SeleniumWebdriverTests.ComponentHelper;

namespace SeleniumWebdriverTests.PageObject
{
    public class BugDetail : PageBase
    {
        #region WebElement

#pragma warning disable 0649

        [FindsBy(How = How.Id, Using = "bug_severity")]
        private IWebElement SeverityDropDown;

        [FindsBy(How = How.Id, Using = "rep_platform")]
        private IWebElement HardwareDropdown;

        [FindsBy(How = How.Id, Using = "op_sys")]
        private IWebElement OSDropdown;

        [FindsBy(How = How.Id, Using = "short_desc")]
        private IWebElement SummaryTextbox;

        //[FindsBy(How = How.Id, Using = "commit")]
        //private IWebElement SubmitButton;

#pragma warning restore 0649

        #endregion WebElement

        public BugDetail(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Action

        public void SelectFromSeverity(string value)
        {
            DropDownHelper.SelectElement(SeverityDropDown, value);
        }

        public void SelectFromHardware(string value)
        {
            DropDownHelper.SelectElement(HardwareDropdown, value);
        }

        public void SelectFromOS(string value)
        {
            DropDownHelper.SelectElement(OSDropdown, value);
        }

        public void SummaryTypeIn(string value)
        {
            TextBoxHelper.SelectElement(SummaryTextbox, value);
        }

        public void ClickSubmit()
        {
            ButtonHelper.ClickButton(By.Id("commit"));
        }

        #endregion Action
    }
}