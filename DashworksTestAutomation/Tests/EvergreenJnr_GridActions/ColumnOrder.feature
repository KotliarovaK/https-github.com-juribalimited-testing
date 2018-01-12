@retry:1
Feature: ColumnOrder
	Runs Column Order related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_GridActions @ColumnOrder @DAS10836 @DAS11666 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearch
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User have opened column settings for "Owner Display Name" column
	When User have select "Pin Left" option from column settings
	Then "Owner Display Name" column is "Left" Pinned
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	Then "Owner Display Name" column is "Left" Pinned

@Evergreen @Users @EvergreenJnr_GridActions @ColumnOrder @DAS10836 @DAS11664 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearch
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Compliance          |
	When User have opened column settings for "Compliance" column
	When User have select "Pin Right" option from column settings
	Then "Compliance" column is "Right" Pinned
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 51           |
	Then "Compliance" column is "Right" Pinned

@Evergreen @Devices @EvergreenJnr_GridActions @ColumnOrder @DAS10621 @DAS11666 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| Compliance   |
	| Boot Up Date |
	When User move 'Boot Up Date' column to 'Hostname' column
	Then Column is displayed in following order:
	| ColumnName         |
	| Hostname           |
	| Boot Up Date       |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Compliance         |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	Then Column is displayed in following order:
	| ColumnName           |
	| Hostname             |
	| Boot Up Date         |
	| Device Type          |
	| Operating System     |
	| Owner Display Name   |
	| Compliance           |
	| Windows7Mi: Category |