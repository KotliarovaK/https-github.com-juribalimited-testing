using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumWebdriverTests.StepDefinitions.Dashworks
{
    [Binding]
    public sealed class EvergreenJnr_AddColumns
    {
        #region When

        [When(@"User clicks the Columns button")]
        public void WhenUserClicksTheColumnsButton()
        {
            ButtonHelper.ClickButton(By.Id("_clmnBtn"));
            Console.WriteLine("Column button was clicked");
        }

        [When(@"ColumnName is entered into the search box and the selection is clicked")]
        public void WhenColumnNameIsEnteredIntoTheSearchBoxAndTheSelectionIsClicked(Table table)
        {
            foreach (var row in table.Rows)
            {
                switch (row["ColumnName"])
                {
                    #region device

                    case "Boot Up Date":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Boot Up Date");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Boot Up Date']"));
                        break;

                    case "Build Date":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Build Date");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Build Date']"));
                        break;

                    case "Compliance":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Compliance");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Compliance']"));
                        break;

                    case "Device Key":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Device Key");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Device Key']"));
                        break;

                    case "First Seen Date":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "First Seen Date");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='First Seen Date']"));
                        break;

                    case "Hostname":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Hostname");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Hostname']"));
                        break;

                    case "Import":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Import");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Import']"));
                        break;

                    case "Import Type":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Import Type");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Import Type']"));
                        break;

                    case "Inventory Site":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Inventory Site");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Inventory Site']"));
                        break;

                    case "Last Seen Date":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Last Seen Date");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Last Seen Date']"));
                        break;

                    case "Purchase Date":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Purchase Date");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Purchase Date']"));
                        break;

                    #endregion device

                    #region Hardware

                    case "Device Type":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Device Type");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Device Type']"));
                        break;

                    case "IP Address":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "IP Address");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='IP Address']"));
                        break;

                    case "Manufacturer":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Manufacturer");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Manufacturer']"));
                        break;

                    #endregion Hardware

                    #region Operating System

                    //Need a unique id for this option as it's the same as its heading!!
                    //case "Operating System":
                    //    TextBoxHelper.TypeInTextBox(By.Name("search"), "Operating Systemr");
                    //    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                    //    ButtonHelper.ClickButton(By.XPath("//span[.='Operating System']"));
                    //    break;

                    case "OS Full Name":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "OS Full Name");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='OS Full Name']"));
                        break;

                    case "OS Version Number":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "OS Version Number");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='OS Version Number']"));
                        break;

                    #endregion Operating System

                    #region Device Owner

                    case "Owner Compliance":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Owner Compliance");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Owner Compliance']"));
                        break;

                    case "Owner Display Name":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Owner Display Name");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Owner Display Name']"));
                        break;

                    case "Owner Email Address":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Owner Email Address");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Owner Email Address']"));
                        break;

                    case "Owner Username":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Owner Username");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Owner Username']"));
                        break;

                    #endregion Device Owner

                    #region Application

                    case "App Count (Entitled)":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "App Count (Entitled)");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='App Count (Entitled)']"));
                        break;

                    case "App Count (Installed)":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "App Count (Installed)");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='App Count (Installed)']"));
                        break;

                    case "App Count (Used)":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "App Count (Used)");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='App Count (Used)']"));
                        break;

                    #endregion Application

                    #region Organisation

                    case "Cost Centre":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Cost Centre");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Cost Centre']"));
                        break;

                    case "Department Code":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Department Code");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Department Code']"));
                        break;

                    case "Department Full Path":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Department Full Path");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Department Full Path']"));
                        break;

                    case "Department Name":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Department Name");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Department Name']"));
                        break;

                    #endregion Organisation

                    #region Location

                    case "Building":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Building");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Building']"));
                        break;

                    case "City":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "City");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='City']"));
                        break;

                    case "Country":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Country");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Country']"));
                        break;

                    case "Floor":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Floor");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Floor']"));
                        break;

                    case "Location Name":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Location Name");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Location Name']"));
                        break;

                    case "Region":
                        TextBoxHelper.TypeInTextBox(By.Name("search"), "Region");
                        ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                        ButtonHelper.ClickButton(By.XPath("//span[.='Region']"));
                        break;

                    #endregion Location

                    default:
                        break;
                }
                Thread.Sleep(2000);
                GenericHelper.TakeScreenShot();
                //Clear the textbox after adding a column, so it is reset for the next loop
                TextBoxHelper.ClearTextBox(By.Name("search"));
                
            }
            //Minimise the Selected Columns
            ButtonHelper.ClickButton(By.XPath("//button[@title='Minimize Group']"));
            //Close the Columns Panel
            ButtonHelper.ClickButton(By.Id("_clmnBtn"));
        }

        #endregion When

        #region Then

        [Then(@"Columns panel is displayed to the user")]
        public void ThenColumnsPanelIsDisplayedToTheUser()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            Assert.IsTrue(GenericHelper.IsElementPresent(By.ClassName("columns-panel")));
            GenericHelper.TakeScreenShot();
            Console.WriteLine("Columns panel is visible");
        }

        [Then(@"ColumnName is added to the list")]
        public void ThenColumnNameIsAddedToTheList(Table table)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            foreach (var row in table.Rows)
            {
                switch (row["ColumnName"])
                {

                    #region Device

                    case "Boot Up Date":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Boot Up Date']")));
                        break;

                    case "Build Date":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Build Date']")));
                        break;

                    case "Compliance":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Compliance']")));
                        break;

                    case "Device Key":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Device Key']")));
                        break;

                    case "First Seen Date":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='First Seen Date']")));
                        break;

                    case "Hostname":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Hostname']")));
                        break;

                    case "Import":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Import']")));
                        break;

                    case "Import Type":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Import Type']")));
                        break;

                    case "Inventory Site":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Inventory Site']")));
                        break;

                    case "Last Seen Date":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Last Seen Date']")));
                        break;

                    case "Purchase Date":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Purchase Date']")));
                        break;

                    #endregion Device

                    #region Hardware

                    case "Device Type":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Device Type']")));
                        break;

                    case "IP Address":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='IP Address']")));
                        break;

                    case "Manufacturer":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Manufacturer']")));
                        break;

                    #endregion Hardware

                    #region Operating System

                    //Need a unique id for this option as it's the same as its heading!!
                    //case "Operating System":
                    //Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Operating System']")));
                    //break;

                    case "OS Full Name":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='OS Full Name']")));
                        break;

                    case "OS Version Number":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='OS Version Number']")));
                        break;

                    #endregion Operating System

                    #region Device Owner

                    case "Owner Email Address":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Owner Email Address']")));
                        break;

                    #endregion Device Owner

                    #region Application

                    case "App Count (Entitled)":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='App Count (Entitled)']")));
                        break;

                    case "App Count (Installed)":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='App Count (Installed)']")));
                        break;

                    case "App Count (Used)":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='App Count (Used)']")));
                        break;

                    #endregion Application

                    #region Organisation

                    case "Cost Centre":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Cost Centre']")));
                        break;

                    case "Department Code":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Department Code']")));
                        break;

                    case "Department Full Path":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Department Full Path']")));
                        break;

                    case "Department Name":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Department Name']")));
                        break;

                    #endregion Organisation

                    #region Location

                    case "Building":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Building']")));
                        break;

                    case "City":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='City']")));
                        break;

                    case "Country":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Country']")));
                        break;

                    case "Floor":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Floor']")));
                        break;

                    case "Location Name":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Location Name']")));
                        break;

                    case "Region":
                        Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[.='Region']")));
                        break;
                    #endregion Location

                    default:
                        break;
                }
            }
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot();
        }

        #endregion Then

    }
}
