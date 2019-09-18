Feature: Relink_DevicesPage
	Runs Relink related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS17655 @DAS17831 @DAS18002 @DAS18112 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for '063X2ZOB8V3GUY' item
	Then Details page for "063X2ZOB8V3GUY" item is displayed to the user
	When User switches to the "Barry's User Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "RELINK" Action button
	Then Dialog Pop-up is displayed for User
	Then 'Resync owner' checkbox is checked in Dialog Pop-up
	Then 'Resync apps' checkbox is checked in Dialog Pop-up
	Then 'Resync name' checkbox is checked in Dialog Pop-up
	When User clicks the "RELINK" Action button
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks the "RELINK" Action button
	Then Success message is displayed and contains "063X2ZOB8V3GUY successfully relinked" text