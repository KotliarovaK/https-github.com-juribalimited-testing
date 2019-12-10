Feature: ListDetailsFunctionalityPart10
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18376 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNoRedBannerWithErrorIsDisplayedAfterSelectingListWithTheAppliedAdvancedFilterOn
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Actions button
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	| 00CWZRC4UK6W20   |
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticDeviceList18376" name
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList          | Association    |
	| StaticDeviceList18376 | Used on device |
	When User create dynamic list with "ApplicationsDynamicList18376" name on "Applications" page
	When User navigates to "1803 Rollout" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects 'ApplicationsDynamicList18376' in the 'Application Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left submenu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then inline error banner is displayed
