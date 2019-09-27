Feature: Relink_DevicesPage
	Runs Relink related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS17655 @DAS17831 @DAS18002 @DAS18112 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for 'ZYCNSN5PALBTRJJ' item
	Then Details page for "ZYCNSN5PALBTRJJ" item is displayed to the user
	When User switches to the "Barry's User Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "RELINK" Action button
	Then Dialog Pop-up is displayed for User
	And 'Resync owner' checkbox is checked
	And 'Resync apps' checkbox is checked
	And 'Resync name' checkbox is checked
	#TODO update search data
	When User enters '0X0ZK6HNQMDU7EY' in the 'Device' autocomplete field and selects '0X0ZK6HNQMDU7EY' value
	And User clicks the "RELINK" Action button
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks the "RELINK" Action button
	Then Success message is displayed and contains "ZYCNSN5PALBTRJJ successfully relinked" text
	
	#Ready on the 'radiant' server
@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS18043 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyRelinked
	When User navigates to the 'Device' details page for '00OMQQXWA1DRI6' item
	Then Details page for "00OMQQXWA1DRI6" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "RELINK" Action button
	And User enters 'fgd' in the 'Device' autocomplete field and selects 'DRDFGDQ1LQA2HJ (6102)' value
	And User clicks the "RELINK" Action button
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks the "RELINK" Action button
	Then Success message is displayed and contains "00OMQQXWA1DRI6 successfully relinked" text
	When User navigates to the "Project Details" sub-menu on the Details page
	Then Success message is not displayed