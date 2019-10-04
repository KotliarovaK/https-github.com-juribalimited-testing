Feature: Relink_ApplicationsPage
	Runs Relink related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS17899
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage
	When User navigates to the 'Application' details page for 'ActiveCGM Browser Netscape Plugin V6P07' item
	Then Details page for "ActiveCGM Browser Netscape Plugin V6P07" item is displayed to the user
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then User verifies data in the fields on details page
	| Field | Data                                    |
	| Name  | ActiveCGM Browser Netscape Plugin V6P07 |
	When User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	And 'Resync name' checkbox is checked
	When User enters '012' in the 'Application' autocomplete field and selects 'Configuration Pack for System Center 2012 Configuration Manager 1.0.0' value
	Then User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Application successfully relinked" text
	And Details page for "Configuration Pack for System Center 2012 Configuration Manager" item is displayed to the user
	And User verifies data in the fields on details page
	| Field | Data                                    |
	| Name  | ActiveCGM Browser Netscape Plugin V6P07 |
	When User clicks 'RESYNC ' button 
	And User clicks 'RESYNC' button in Dialog Pop-up
	Then Success message is displayed and contains "Application successfully resynced" text
	And User verifies data in the fields on details page
	| Field | Data                                                            |
	| Name  | Configuration Pack for System Center 2012 Configuration Manager |
	When User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	When User enters 'V6P07' in the 'Application' autocomplete field and selects 'ActiveCGM Browser Netscape Plugin V6P07' value
	And User clicks 'RELINK' button in Dialog Pop-up
	And User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Application successfully relinked" text