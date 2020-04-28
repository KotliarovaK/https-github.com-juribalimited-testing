Feature: Relink_DevicesPage
	Runs Relink related tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS17655 @DAS17831 @DAS18002 @DAS18112 @DAS18284 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnDevicesPage
	When User navigates to the 'Device' details page for '06RIV0KXJMHJ1K' item
	Then Details page for '06RIV0KXJMHJ1K' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title        | Value          |
	| Name         | 06RIV0KXJMHJ1K |
	| Device Owner | Tonia T. Mason |
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	And 'Resync owner' checkbox is checked
	And 'Resync apps' checkbox is checked
	And 'Resync name' checkbox is checked
	When User unchecks 'Resync owner' checkbox
	When User enters 'QSFCLB19N5524S' in the 'Device' autocomplete field and selects 'QSFCLB19N5524S' value
	When User clicks 'RELINK' button on popup
	Then 'This object will be relinked to the selected Evergreen object in this project' text is displayed on inline tip banner
	When User clicks 'RELINK' button on popup
	Then 'Device successfully relinked' text is displayed on inline success banner
	Then Details page for 'QSFCLB19N5524S' item is displayed to the user
	And following content is displayed on the Details Page
	| Title        | Value           |
	| Name         | QSFCLB19N5524S  |
	| Device Owner | Gerard C. Kelly |
	When User clicks 'RELINK' button
	When User unchecks 'Resync owner' checkbox
	And User enters '06RIV0KXJMHJ1K' in the 'Device' autocomplete field and selects '06RIV0KXJMHJ1K' value
	And User clicks 'RELINK' button on popup
	And User clicks 'RELINK' button on popup
	Then 'Device successfully relinked' text is displayed on inline success banner

@Evergreen @Devices @EvergreenJnr_ItemDetails @Relink @DAS18043 @DAS19884
Scenario: EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyRelinked
	When User navigates to the 'Device' details page for '00K4CEEQ737BA4L' item
	Then Details page for '00K4CEEQ737BA4L' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	And User enters 'L1IWSS0WKQG8IU' in the 'Device' autocomplete field and selects 'L1IWSS0WKQG8IU' value
	And User clicks 'RELINK' button on popup
	Then 'This object will be relinked to the selected Evergreen object in this project' text is displayed on inline tip banner
	When User clicks 'RELINK' button on popup
	Then 'Device successfully relinked' text is displayed on inline success banner
	When User navigates to the 'Projects Summary' left submenu item
	Then inline success banner is not displayed
	When User navigates to the 'Device' details page for 'L1IWSS0WKQG8IU' item
	Then Details page for 'L1IWSS0WKQG8IU' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	And User enters '00K4CEEQ737BA4L' in the 'Device' autocomplete field and selects '00K4CEEQ737BA4L' value
	And User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19335
Scenario: EvergreenJnr_DevicesList_CheckThatTooltipForDisabledRelinkButtonIsDisplayed
	When User navigates to the 'Device' details page for '011PLA470S0B9DJ' item
	Then Details page for '011PLA470S0B9DJ' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then popup is displayed to User
	Then Button 'RELINK' has 'Select a device' tooltip on popup

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19323 @Universe
Scenario: EvergreenJnr_DevicesList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringPartOfObjectKeyToAutocomplete
	When User navigates to the 'Device' details page for '01BQIYGGUW5PRP6' item
	Then Details page for '01BQIYGGUW5PRP6' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then only options having search term '094' are displayed in 'Device' autocomplete