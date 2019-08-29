Feature: Relink
	Runs Relink related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO This test is in progress. Update the test when there will be more details.
	#Ann.Ilchenko 8/29/19: ready on 'quasar';
@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS17655 @DAS17831 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "063X2ZOB8V3GUY"
	And User click content from "Application" column
	Then Details page for "063X2ZOB8V3GUY" item is displayed to the user
	When User switches to the "Barry's User Project" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "RELINK" Action button
	#TODO check selector for the next step
	Then Offboard Pop-up is displayed on the Item Details page
	Then Warning message is displayed and contains 'This object will be relinked to the selected Evergreen object in this project' text on Item Details page
	#TODO check selector for the next step
	When User clicks 'RELINK' button in the Offboard Pop-up on the Item Details page
	Then Success message is displayed and contains '063X2ZOB8V3GUY successfully relinked' text on Item Details page