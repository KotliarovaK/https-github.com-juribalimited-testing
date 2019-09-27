Feature: Resync_DevicesPage
	Runs Resync related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Devices @EvergreenJnr_ItemDetails @Resync @DAS18035 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for '011PLA470S0B9DJ' item
	Then Details page for "011PLA470S0B9DJ" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks 'RESYNC' button 
	Then Dialog Pop-up is displayed for User
	Then 'Resync owner' checkbox is checked
	Then 'Resync apps' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User clicks 'RESYNC' button 
	Then Success message is displayed and contains "Device successfully resynced" text