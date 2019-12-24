Feature: Relink_DevicesPage
	Runs Relink related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS17655 @DAS17831 @DAS18002 @DAS18112 @DAS18284 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for '06RIV0KXJMHJ1K' item
	Then Details page for "06RIV0KXJMHJ1K" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then User verifies data in the fields on details page
	| Field        | Data           |
	| Name         | 06RIV0KXJMHJ1K |
	| Device Owner | Tonia T. Mason |
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	And 'Resync owner' checkbox is checked
	And 'Resync apps' checkbox is checked
	And 'Resync name' checkbox is checked
	When User enters 'QSFCLB19N5524S' in the 'Device' autocomplete field and selects 'QSFCLB19N5524S' value
	When User clicks 'RELINK' button on popup
	Then 'This object will be relinked to the selected Evergreen object in this project' text is displayed on inline tip banner
	When User clicks 'RELINK' button on popup
	Then 'The Evergreen owner of this Device has been queued for onboarding into this project, the change in ownership for this Device will show once this is complete' text is displayed on inline success banner
	Then Details page for "QSFCLB19N5524S" item is displayed to the user
	And User verifies data in the fields on details page
	| Field        | Data            |
	| Name         | QSFCLB19N5524S  |
	| Device Owner | Gerard C. Kelly |
	When User clicks 'RELINK' button 
	And User enters '06RIV0KXJMHJ1K' in the 'Device' autocomplete field and selects '06RIV0KXJMHJ1K' value
	And User clicks 'RELINK' button on popup
	And User clicks 'RELINK' button on popup
	Then 'Device successfully relinked' text is displayed on inline success banner
	When User navigates to the 'User' details page for 'ZHC394580' item
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	When User clicks 'OFFBOARD' button on popup
	And User clicks 'OFFBOARD' button on popup

	#Ready on the 'radiant' server
@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS18043 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyRelinked
	When User navigates to the 'Device' details page for 'FISC5NOXFB8Q7M' item
	Then Details page for "FISC5NOXFB8Q7M" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button 
	And User enters '5XW9ZW6O6HG7IP9' in the 'Device' autocomplete field and selects '5XW9ZW6O6HG7IP9' value
	And User clicks 'RELINK' button on popup
	Then 'This object will be relinked to the selected Evergreen object in this project' text is displayed on inline tip banner
	When User clicks 'RELINK' button on popup
	Then inline success banner is displayed
	When User navigates to the 'Projects Summary' left submenu item
	Then inline success banner is not displayed
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button 
	And User enters 'FISC5NOXFB8Q7M' in the 'Device' autocomplete field and selects 'FISC5NOXFB8Q7M' value
	And User clicks 'RELINK' button on popup
	And User clicks 'RELINK' button on popup
	#waiting for the RELINK process to be completed
	When User waits for '3' seconds
	When User clicks "Sherri R. Bautista" link on the Details Page
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	When User clicks 'OFFBOARD' button on popup
	And User clicks 'OFFBOARD' button on popup

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19335
Scenario: EvergreenJnr_DevicesList_CheckThatTooltipForDisabledRelinkButtonIsDisplayed
	When User navigates to the 'Device' details page for '011PLA470S0B9DJ' item
	Then Details page for "011PLA470S0B9DJ" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then popup is displayed to User
	Then Button 'RELINK' has 'Select a device' tooltip on popup