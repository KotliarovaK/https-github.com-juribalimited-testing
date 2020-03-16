Feature: DevicesDetails_Applications_EvergreenSummary
	Runs related tests for Applications > Evergreen Summary tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15913
Scenario: EvergreenJnr_DevicesList_CheckThatUnknownValuesAreNotDisplayedOnLevelOfGroupedRows
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Vendor     | true  |
	Then 'Adobe' row in the groped grid does not contains 'UNKNOWN' text

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20022
Scenario: EvergreenJnr_DevicesList_CheckThatCorrectTooltipIsDisplayedForTheUnknownValue
	When User navigates to the 'Device' details page for '00K4CEEQ737BA4L' item
	Then Details page for '00K4CEEQ737BA4L' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	When User enters "AppSight 5.5 Server" text in the Search field for "Application" column
	Then 'Unknown' tooltip is displayed for 'UNKNOWN' content in the 'Installed' column