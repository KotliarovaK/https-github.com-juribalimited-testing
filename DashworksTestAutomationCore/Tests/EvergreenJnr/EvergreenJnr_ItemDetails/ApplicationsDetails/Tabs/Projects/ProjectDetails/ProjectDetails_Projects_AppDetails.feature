Feature: ProjectDetails_Projects_AppDetails
	Runs Project Details related tests on App Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @DAS21184 @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_CheckThatTargetAppValueDisplayedAsALink
	When User navigates to the 'Application' details page for the item with '2015' ID
	Then Details page for '7zip' item is displayed to the user
	When User selects 'Computer Scheduled Test (Jo)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks "Adobe Reader 6.0.1 - Fran?ais (A01)" link on the Details Page
	Then Details page for 'Adobe Reader 6.0.1 - Fran?ais' item is displayed to the user