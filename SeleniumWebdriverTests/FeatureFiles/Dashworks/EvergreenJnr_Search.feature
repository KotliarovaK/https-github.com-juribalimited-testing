Feature: EvergreenJnr_Search
	Runs Evergreen Search related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage with dashworksUrl "http://automation.corp.juriba.com/"
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user

@Evergreen @Search @Devices
Scenario Outline: Evergreen Jnr_Devices List_agGrid Search Tests
	When User provides the "<username>" and "<password>" and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "<listPage>" on the left-hand menu
	Then "<listPage>" list should be displayed to the user
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
	Examples:
	| TestCase   | username | password  | listPage |
	| Admin User | admin    | m!gration | Devices  |

@Evergreen @Search @Devices
Scenario Outline: Evergreen Jnr_Devices List_agGrid Search_Does Not Trigger_Update List
	When User provides the "<username>" and "<password>" and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "<listPage>" on the left-hand menu
	Then "<listPage>" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Henry          | 34           |
	Then Save to New Custom List element should NOT be displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out
	Examples:
	| TestCase   | username | password  | listPage |
	| Admin User | admin    | m!gration | Devices  |

@Evergreen @Search @Devices
Scenario Outline: Evergreen Jnr_Devices List_Clearing agGrid Search_returns the full data set
	When User provides the "<username>" and "<password>" and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "<listPage>" on the left-hand menu
	Then "<listPage>" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | 17           |
	And Clearing the agGrid Search Box
	| SearchValueLength |
	| 4                 |
	Then All rows are displayed in the agGrid
	| NumberOfRows |
	| 17,271       |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out
	Examples:
	| TestCase   | username | password  | listPage |
	| Admin User | admin    | m!gration | Devices  |

@Evergreen @Search @Devices
Scenario Outline: Evergreen Jnr_Devices List_agGrid Search_No Devices Found
	When User provides the "<username>" and "<password>" and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "<listPage>" on the left-hand menu
	Then "<listPage>" list should be displayed to the user
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
	And User enters invalid SearchCriteria into the agGrid Search Box and No Devices are found
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
	Examples:
	| TestCase   | username | password  | listPage |
	| Admin User | admin    | m!gration | Devices  |