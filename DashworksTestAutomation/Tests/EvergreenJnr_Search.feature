#@retry:3
Feature: EvergreenJnr_Search
	Runs Evergreen Search related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Search @Devices
Scenario: Evergreen Jnr_Devices List_agGrid Search Tests
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Compliance          |
	| Owner Email Address |
	| IP Address          |
	Then ColumnName is added to the list
	| ColumnName          |
	| Compliance          |
	| Owner Email Address |
	| IP Address          |
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria      | NumberOfRows |
	| Véronique Duplessis | 1            |
	| Virtual             | 2,030        |
	| Windows Vista       | 475          |
	| O'Connor            | 13           |
	| @demo.juriba.com    | 16,717       |
	| 192.168.6           | 5,100        |
	| RED                 | 9,238        |
	| 0JIE                | 1            |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Search @Devices
Scenario: Evergreen Jnr_Devices List_agGrid Search_Does Not Trigger_Update List
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Henry          | 34           |
	Then Save to New Custom List element should NOT be displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Search @Devices
Scenario: Evergreen Jnr_Devices List_Clearing agGrid Search_returns the full data set
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | 17           |
	And Clearing the agGrid Search Box
	Then "17,271" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Search @Devices
Scenario: Evergreen Jnr_Devices List_agGrid Search_No Devices Found
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Compliance          |
	| Owner Email Address |
	| IP Address          |
	Then ColumnName is added to the list
	| ColumnName          |
	| Compliance          |
	| Owner Email Address |
	| IP Address          |
	And User enters invalid SearchCriteria into the agGrid Search Box and "No devices found" message is displayed
	| SearchCriteria    |
	| 0281Z793OLLLDU66  |
	| Xavier Beaule     |
	| BLUE              |
	| Virtuals          |
	| Windows 2001      |
	| 192.168.7         |
	| demo.juriba.co.uk |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Search @Devices
Scenario: Evergreen Jnr_Devices Search withing all rows
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
	Then "17,271" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out