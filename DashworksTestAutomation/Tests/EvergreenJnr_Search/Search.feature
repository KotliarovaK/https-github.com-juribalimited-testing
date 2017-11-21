Feature: Search
	Runs Search related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS-10704 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_agGrid_Check that quick search reset when moving between lists
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

@Evergreen @Devices @Applications @Users @Mailboxes @EvergreenJnr_Search @Search @DAS-10580 @DAS-10667 @DAS-10624
Scenario: EvergreenJnr_AllLists_Check search filter and table content during navigation between pages
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	Then "41,335" rows are displayed in the agGrid
	Then Search field is empty
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 59           |
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	Then "2,223" rows are displayed in the agGrid
	Then Search field is empty
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Python          | 7           |
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	Then "4,835" rows are displayed in the agGrid
	Then Search field is empty
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 39           |
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	Then "17,225" rows are displayed in the agGrid
	Then Search field is empty
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out


@Evergreen @Devices @EvergreenJnr_Search @Search
Scenario: EvergreenJnr_DevicesList_Search Tests
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
	| Virtual             | 1,996        |
	| Windows Vista       | 475          |
	| O'Connor            | 13           |
	| @demo.juriba.com    | 16,717       |
	| 192.168.6           | 5,100        |
	| RED                 | 9,238        |
	| 0JIE                | 1            |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_Search @Search
Scenario: EvergreenJnr_DevicesList_Clearing search returns the full data set
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | 17           |
	Then URL is "http://automation.corp.juriba.com/evergreen/#/devices"
	And Clearing the agGrid Search Box
	Then "17,225" rows are displayed in the agGrid
	Then URL is "http://automation.corp.juriba.com/evergreen/#/devices"
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_Search @Search
Scenario: EvergreenJnr_DevicesList_Search_No Devices Found
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