Feature: Resync_ApplicationsPage
	Runs Resync related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @Resync @DAS18035
Scenario: EvergreenJnr_ApplicationsList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage
	When User navigates to the 'Application' details page for 'Borland Together Edition for Microsoft Visual Studio .NET' item
	Then Details page for 'Borland Together Edition for Microsoft Visual Studio .NET' item is displayed to the user
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button 
	Then popup is displayed to User
	Then 'Resync name' checkbox is checked
	When User clicks 'RESYNC' button on popup
	Then 'Application successfully resynced' text is displayed on inline success banner