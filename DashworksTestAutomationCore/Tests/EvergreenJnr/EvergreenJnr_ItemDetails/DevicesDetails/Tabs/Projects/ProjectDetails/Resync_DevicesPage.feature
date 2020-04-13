Feature: Resync_DevicesPage
	Runs Resync related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @Resync @DAS18035
Scenario: EvergreenJnr_DevicesList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for '011PLA470S0B9DJ' item
	Then Details page for '011PLA470S0B9DJ' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button 
	Then popup is displayed to User
	Then 'Resync owner' checkbox is checked
	Then 'Resync apps' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User selects state 'false' for 'Resync owner' checkbox
	When User clicks 'RESYNC' button on popup
	Then 'Device successfully resynced' text is displayed on inline success banner