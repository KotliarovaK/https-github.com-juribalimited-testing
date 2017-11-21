#@retry:3
Feature: ColumnOrder
	Runs Column Order related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_GridActions @ColumnOrder @DAS-10836
Scenario: EvergreenJnr_DevicesList_Check that columns order saved after search
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User have opened column settings for "Owner Display Name" column
	When User have select "Pin Left" option from column settings
	Then "Owner Display Name" column is "Left" Pinned
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	Then "Owner Display Name" column is "Left" Pinned
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @EvergreenJnr_GridActions @ColumnOrder @DAS-10836
Scenario: EvergreenJnr_UsersList_Check that columns order saved after search
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
	| Smith          | 59           |
	Then "Compliance" column is "Right" Pinned
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_GridActions @ColumnOrder @DAS-10621
Scenario: EvergreenJnr_DevicesList_Check that columns order saved after adding a filter
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
	When user select "Windows7Mi: Category" filter
	When User have created "Equals" filter with "true" column checkbox and following options:
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
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out