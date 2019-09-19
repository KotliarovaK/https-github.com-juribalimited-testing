Feature: Relink_ApplicationsPage
	Runs Relink related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage
	When User navigates to the 'Application' details page for 'Mozilla Firefox (1.0.7)' item
	Then Details page for "Mozilla Firefox (1.0.7)" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "RELINK" Action button
	Then Dialog Pop-up is displayed for User
	Then 'Resync name' checkbox is checked
	When User clicks the "RELINK" Action button
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks the "RELINK" Action button
	Then Success message is displayed and contains "Mozilla Firefox (1.0.7) successfully relinked" text