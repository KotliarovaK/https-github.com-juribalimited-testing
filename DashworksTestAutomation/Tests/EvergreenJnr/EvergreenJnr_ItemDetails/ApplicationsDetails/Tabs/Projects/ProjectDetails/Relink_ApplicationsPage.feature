Feature: Relink_ApplicationsPage
	Runs Relink related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS17899 @DAS18196 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage
	When User navigates to the 'Application' details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then User verifies data in the fields on details page
	| Field | Data                                                       |
	| Name  | "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters 'Microsoft SQL' in the 'Application' autocomplete field and selects 'Microsoft SQL Server 2012' value
	When User selects state 'false' for 'Resync owner' checkbox
	When User clicks 'RELINK' button on popup
	Then 'This object will be relinked to the selected Evergreen object in this project' text is displayed on inline tip banner
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner
	Then Details page for "Microsoft SQL Server 2012" item is displayed to the user
	And User verifies data in the fields on details page
	| Field | Data                      |
	| Name  | Microsoft SQL Server 2012 |
	When User clicks 'RELINK' button 
	When User enters 'WPF' in the 'Application' autocomplete field and selects '"WPF/E" (codename) Community Technology Preview (Feb 2007)' value
	And User clicks 'RELINK' button on popup
	And User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner

@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18769 @DAS19124
Scenario: EvergreenJnr_ApplicationsList_CheckThatErrorIsDisplayedInTheRelinkToPopupAfterEnteringTwoSymbolsAndSpaceToTheSearchFieldAndClickingEnterButton
	When User navigates to the 'Application' details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters 'k9 ' text to 'Application' textbox
	Then Error message is not displayed
	When User enters 'gh#' text to 'Application' textbox
	Then Error message is not displayed

@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS17899 @DAS18196 @DAS18980
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage_WithOwnerToWithoutOwner
	When User navigates to the 'Application' details page for the item with '4017' ID
	Then Details page for "Microsoft Exchange Client Language Pack - Lithuanian" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters '4016' in the 'Application' autocomplete field and selects 'Microsoft Corporation Microsoft Exchange Client Language Pack - Vietnamese 15.0.1178.4 (4016)' value
	When User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner
	Then User verifies data in the fields on details page
	| Field     | Data |
	| App Owner |      |
	#return values ​​back
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters '4017' in the 'Application' autocomplete field and selects 'Microsoft Corporation Microsoft Exchange Client Language Pack - Lithuanian 15.0.847.32 (4017)' value
	When User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner

@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS17899 @DAS18196
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage_WithoutOwnerToWithoutOwner
	When User navigates to the 'Application' details page for the item with '4018' ID
	Then Details page for "Microsoft Visual C++ 2012 x86 Additional Runtime - 11.0.61030" item is displayed to the user
	When User switches to the "Project 00 M Computer Scheduled" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters '4019' in the 'Application' autocomplete field and selects 'Microsoft Corporation Microsoft .NET Framework 4.5 4.5.50709 (4019)' value
	When User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner
	#return values ​​back
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters '4018' in the 'Application' autocomplete field and selects 'Microsoft Corporation Microsoft Visual C++ 2012 x86 Additional Runtime - 11.0.61030 11.0.61030 (4018)' value
	When User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner