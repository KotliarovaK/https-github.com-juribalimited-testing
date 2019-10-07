Feature: Relink_DevicesPage
	Runs Relink related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS17655 @DAS17831 @DAS18002 @DAS18112 @DAS18284
Scenario: EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for '06RIV0KXJMHJ1K' item
	Then Details page for "06RIV0KXJMHJ1K" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then User verifies data in the fields on details page
	| Field        | Data           |
	| Name         | 06RIV0KXJMHJ1K |
	| Device Owner | Tonia T. Mason |
	When User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	And 'Resync owner' checkbox is checked
	And 'Resync apps' checkbox is checked
	And 'Resync name' checkbox is checked
	When User enters 'QSFCLB19N5524S' in the 'Device' autocomplete field and selects 'QSFCLB19N5524S' value
	Then User selects state 'true' for 'Resync owner' checkbox
	And User selects state 'true' for 'Resync apps' checkbox
	And User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Device successfully relinked" text
	And Details page for "QSFCLB19N5524S" item is displayed to the user
	And User verifies data in the fields on details page
	| Field        | Data           |
	| Name         | 06RIV0KXJMHJ1K |
	| Device Owner | Tonia T. Mason |
	#Andrew will remove space in button name
	When User clicks 'RESYNC ' button 
	And User clicks 'RESYNC' button in Dialog Pop-up
	Then Success message is displayed and contains "The Evergreen owner of this Device has been queued for onboarding into this project, the change in ownership for this Device will show once this is complete" text
	#waiting for the RESYNC process to be completed
	When User waits for three seconds
	Then User verifies data in the fields on details page
	| Field        | Data            |
	| Name         | QSFCLB19N5524S  |
	| Device Owner | Gerard C. Kelly |
	When User clicks 'RELINK' button 
	And User enters '06RIV0KXJMHJ1K' in the 'Device' autocomplete field and selects '06RIV0KXJMHJ1K' value
	And User clicks 'RELINK' button in Dialog Pop-up
	And User clicks 'RELINK' button in Dialog Pop-up
	#Andrew will check the delay time for message
	#Then Success message is displayed and contains "Device successfully relinked" text
	#waiting for the RELINK process to be completed
	When User waits for three seconds
	When User navigates to the 'User' details page for 'ZHC394580' item
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	When User clicks 'OFFBOARD' button in Dialog Pop-up
	And User clicks 'OFFBOARD' button in Dialog Pop-up

	#Ready on the 'radiant' server
@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS18043 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyRelinked
	When User navigates to the 'Device' details page for 'FISC5NOXFB8Q7M' item
	Then Details page for "FISC5NOXFB8Q7M" item is displayed to the user
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks 'RELINK' button 
	And User enters 'fds' in the 'Device' autocomplete field and selects '9ZW79DFDSJ7X1V' value
	And User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Device successfully relinked" text
	When User navigates to the "Projects Summary" sub-menu on the Details page
	Then Success message is not displayed