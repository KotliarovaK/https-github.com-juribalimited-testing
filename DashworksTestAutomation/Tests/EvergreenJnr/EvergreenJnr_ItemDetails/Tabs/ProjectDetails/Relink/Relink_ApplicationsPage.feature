Feature: Relink_ApplicationsPage
	Runs Relink related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#ready only on 'Spectrum'
	#need to add cleanup
@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS17899 @DAS18196 @Cleanup @Not_Run
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
	#And 'Resync owner' checkbox is checked
	#And 'Resync name' checkbox is checked
	When User enters 'Microsoft SQL' in the 'Application' autocomplete field and selects 'Microsoft SQL Server 2012' value
	When User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button on popup
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button on popup
	Then Success message is displayed and contains "Application successfully relinked" text
	#waiting for the relink process to be completed
	When User waits for three seconds
	Then Details page for "Microsoft SQL Server 2012" item is displayed to the user
	And User verifies data in the fields on details page
	| Field | Data                                                       |
	| Name  | "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	When User clicks 'RESYNC' button
	And User clicks 'RESYNC' button on popup
	Then Success message is displayed and contains "Application successfully resynced" text
	#waiting for the resync process to be completed
	When User waits for three seconds
	Then User verifies data in the fields on details page
	| Field | Data                      |
	| Name  | Microsoft SQL Server 2012 |
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters 'WPF' in the 'Application' autocomplete field and selects '"WPF/E" (codename) Community Technology Preview (Feb 2007)' value
	And User clicks 'RELINK' button on popup
	And User clicks 'RELINK' button on popup
	Then Success message is displayed and contains "Application successfully relinked" text
	#waiting for the relink process to be completed
	When User waits for three seconds

	#ready only on 'terminator'
@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18769 @Not_Run
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