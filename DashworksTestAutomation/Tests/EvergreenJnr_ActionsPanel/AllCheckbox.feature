Feature: AllCheckbox
	Runs All Checkbox related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @Evergreen_ActionsPanel @AllCheckbox @DAS-10769
Scenario: EvergreenJnr_UsersList_Select All Checkbox Status Check After Search
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then The number of rows selected matches the number of rows of the main object list
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| alain          | 42           |
	Then Select All selectbox is checked
	Then "42" rows are displayed in the agGrid
	Then "41335" selected rows are displayed in the Actions panel
	When User is deselect all rows
	And User select all rows
	Then The number of rows selected matches the number of rows of the main object list
	And Clearing the agGrid Search Box
	Then Select All selectbox is checked
	Then "42" selected rows are displayed in the Actions panel
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @AllLists @Evergreen_ActionsPanel @AllCheckbox @DAS-10775
Scenario Outline: EvergreenJnr_AllLists_Check that select All Checkbox status after closing action panel
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User clicks the Actions button
	Then Select all checkbox is not displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @Devices @Evergreen_ActionsPanel @AllCheckbox @DAS-10772
Scenario: EvergreenJnr_DevicesList_Search Within All Rows
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria  | NumberOfRows |
	| Mary            | 17           |
	| Henry           | 34           |
	| Yolande Sylvain | 1            |
	And Clearing the agGrid Search Box
	Then "17,225" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_ActionsPanel @AllCheckbox @DAS-10656
Scenario: EvergreenJnr_DevicesList_Select All checbox main functionality test
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then "17225" selected rows are displayed in the Actions panel
	When User clicks the Actions button
	Then Select all checkbox is not displayed
	When User clicks the Actions button
	When User select all rows
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 02QS1WBYUHCAG8Z  |
	| 01COJATLYVAR7A6  |
	Then "17223" selected rows are displayed in the Actions panel
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in descending order
	Then "17223" selected rows are displayed in the Actions panel
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out