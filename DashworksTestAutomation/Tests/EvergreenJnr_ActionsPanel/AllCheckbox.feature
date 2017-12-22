@retry:1
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

@Evergreen @Users @Evergreen_ActionsPanel @AllCheckbox @DAS-10769 @DAS-10656
Scenario: EvergreenJnr_UsersList_SelectAllCheckboxStatusCheckAfterSearch
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

@Evergreen @AllLists @Evergreen_ActionsPanel @AllCheckbox @DAS-10775 @DAS-10656
Scenario Outline: EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User clicks the Actions button
	Then Select all checkbox is not displayed

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @Devices @Evergreen_ActionsPanel @AllCheckbox @DAS-10772 @DAS-10656
Scenario: EvergreenJnr_DevicesList_SearchWithinAllRows
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

@Evergreen @AllLists @Evergreen_ActionsPanel @AllCheckbox @DAS-10656
Scenario Outline: EvergreenJnr_AllLists_SelectAllChecboxMainFunctionalityTest
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then "<SelectedRowsCount>" selected rows are displayed in the Actions panel
	When User clicks the Actions button
	Then Select all checkbox is not displayed
	When User clicks the Actions button
	When User select all rows
	When User select "<Columnname>" rows in the grid
	| SelectedRowsName  |
	| <SelectedRowName> |
	Then "<SelectedRowsCountAfterDiselect>" selected rows are displayed in the Actions panel
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in descending order
	Then "<SelectedRowsCountAfterDiselect>" selected rows are displayed in the Actions panel

Examples: 
	| PageName     | SelectedRowsCount | Columnname    | SelectedRowName      | SelectedRowsCountAfterDiselect |
	| Devices      | 17225             | Hostname      | 02QS1WBYUHCAG8Z      | 17224                          |
	| Users        | 41335             | Username      | AAV4528222           | 41334                          |
	| Applications | 2223              | Application   | MKS Source Integrity | 2222                           |
	| Mailboxes    | 4835              | Email Address | blogs@juriba.com     | 4834                           |

@Evergreen @AllLists @Evergreen_ActionsPanel @AllCheckbox @DAS-10656
Scenario: EvergreenJnr_UsersList_CheckThatSelectAllWorksCorrectlyForFilteredListsWithAdditionalColumn
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Username   |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	| Green              |
	Then "Compliance" filter is added to the list
	And "41,161" rows are displayed in the agGrid
	And table data is filtered correctly
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then "41161" selected rows are displayed in the Actions panel