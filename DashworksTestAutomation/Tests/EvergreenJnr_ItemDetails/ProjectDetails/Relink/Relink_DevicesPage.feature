Feature: Relink_DevicesPage
	Runs Relink related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS17655 @DAS17831 @DAS18002 @DAS18112 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for '02QS1WBYUHCAG8Z' item
	Then Details page for "02QS1WBYUHCAG8Z" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	And 'Resync owner' checkbox is checked
	And 'Resync apps' checkbox is checked
	And 'Resync name' checkbox is checked
	#TODO update search data
	When User enters 'dfg' in the 'Device' autocomplete field and selects '1BTWGCA36JDFG5' value
	And User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
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