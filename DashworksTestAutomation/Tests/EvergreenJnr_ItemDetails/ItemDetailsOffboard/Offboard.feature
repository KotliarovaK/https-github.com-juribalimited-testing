Feature: Offboard
	Runs Offboard related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ann.Ilchenko 8/27/19: ready on 'quasar';
@Evergreen @Applications @EvergreenJnr_ItemDetails @Offboard @DAS17919 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPage
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User perform search by "Technical Information Sampler: January 2003"
	And User click content from "Application" column
	Then Details page for "Technical Information Sampler: January 2003" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "OFFBOARD" Action button
	Then Warning message is displayed and contains "This application will be offboarded, this cannot be undone" text on Item Details page
	When User clicks "OFFBOARD" button in the warning message on Item Details page
	Then Success message is displayed and contains "The application was successfully queued for offboarding from User Evergreen Capacity Project" text on Item Details page