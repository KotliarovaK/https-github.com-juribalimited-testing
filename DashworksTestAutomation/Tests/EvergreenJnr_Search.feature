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
Scenario: Evergreen Jnr_Devices List_agGrid	_Search Tests
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

@Evergreen @Search @Devices @DAS-10998
Scenario: Evergreen Jnr_Devices List_agGrid Search_Does Not Trigger_New Custom List
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Henry          | 34           |
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Search @Devices
Scenario: Evergreen Jnr_Devices List_agGrid_Clearing search returns the full data set
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
	| 67#               |
	| #12               |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Search @Devices @DAS-10772
Scenario: Evergreen Jnr_DevicesList_Search Within All Rows
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

@Evergreen @Search @Users @DAS-10769
Scenario: Evergreen Jnr_DevicesList_Select All Checkbox Status Check After Search
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
	Then "38271" selected rows are displayed in the Actions panel
	When User is deselect all rows
	And User select all rows
	Then The number of rows selected matches the number of rows of the main object list
	And Clearing the agGrid Search Box
	Then Select All selectbox is checked
	Then "42" selected rows are displayed in the Actions panel
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out
	
@Evergreen @Search @Devices @Applications @Users @Mailboxes @DAS-10580 @DAS-10667 @DAS-10624
Scenario: Evergreen Jnr_AllLists_Check search filter and table content during navigation between pages
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	Then "38,271" rows are displayed in the agGrid
	Then Search field is empty
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 58           |
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	Then "3,305" rows are displayed in the agGrid
	Then Search field is empty
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Python          | 7           |
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	Then "13,779" rows are displayed in the agGrid
	Then Search field is empty
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 44           |
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	Then "17,271" rows are displayed in the agGrid
	Then Search field is empty
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Search @Devices @DAS-10704
Scenario: Evergreen Jnr_DevicesList_agGrid_Check that quick search doesn't triggers new list menu
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Search @Devices @DAS-10704
Scenario: Evergreen Jnr_DevicesList_agGrid_Check that quick search reset when moving between lists
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |
	Then ColumnName is added to the list
	| ColumnName |
	| Build Date |
	When User create custom list with "TestList" name
	Then "TestList" is displayed to user
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	When User navigates to the "All Devices" list
	Then Search field is empty
	When User is removed custom list with "TestList" name
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out