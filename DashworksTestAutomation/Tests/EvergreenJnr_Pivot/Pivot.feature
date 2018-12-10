Feature: Pivot
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot
Scenario: EvergreenJnr_DevicesList_TestPivot
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	When User adds the following Row Groups:
	| RowGroups    |
	| Boot Up Date |
	| Build Date   |
	When User adds the following Columns:
	| Columns |
	|         |
	When User adds the following Values:
	| Values |
	|        |