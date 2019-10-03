Feature: Relink_DevicesPage
	Runs Relink related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS17655 @DAS17831 @DAS18002 @DAS18112
Scenario: EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for '019BFPQGKK5QT8N' item
	Then Details page for "019BFPQGKK5QT8N" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then User verifies data in the fields on details page
	| Field        | Data            |
	| Name         | 019BFPQGKK5QT8N |
	| Device Owner | Talon Brochu    |
	When User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	And 'Resync owner' checkbox is checked
	And 'Resync apps' checkbox is checked
	And 'Resync name' checkbox is checked
	When User enters 'dfg' in the 'Device' autocomplete field and selects '5L3NIDFGJQ2NF5' value
	Then User selects state 'true' for 'Resync owner' checkbox
	And User selects state 'true' for 'Resync apps' checkbox
	And User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Device successfully relinked" text
	And Details page for "5L3NIDFGJQ2NF5" item is displayed to the user
	And User verifies data in the fields on details page
	| Field        | Data            |
	| Name         | 019BFPQGKK5QT8N |
	| Device Owner | Talon Brochu    |
	When User clicks 'RESYNC ' button 
	And User clicks 'RESYNC' button in Dialog Pop-up
	Then Success message is displayed and contains "Device successfully resynced" text
	And User verifies data in the fields on details page
	| Field        | Data               |
	| Name         | 5L3NIDFGJQ2NF5     |
	| Device Owner | Valerie H. Lambert |
	When User navigates to the 'Applications' left menu item
	And User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then "9" rows found label displays on Details Page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'RELINK' button 
	And User enters '019BFPQGKK5QT8N' in the 'Device' autocomplete field and selects '019BFPQGKK5QT8N' value
	And User clicks 'RELINK' button in Dialog Pop-up
	And User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Device successfully relinked" text

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