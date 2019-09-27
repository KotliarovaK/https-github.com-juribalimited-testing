Feature: Resync_ApplicationsPage
	Runs Resync related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Applications @EvergreenJnr_ItemDetails @Resync @DAS18035 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage
	When User navigates to the 'Application' details page for 'Borland Together Edition for Microsoft Visual Studio .NET' item
	Then Details page for "Borland Together Edition for Microsoft Visual Studio .NET" item is displayed to the user
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks 'RESYNC' button 
	Then Dialog Pop-up is displayed for User
	Then 'Resync name' checkbox is checked
	When User clicks 'RESYNC' button 
	Then Success message is displayed and contains "Application successfully resynced" text