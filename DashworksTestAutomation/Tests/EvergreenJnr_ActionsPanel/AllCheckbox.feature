@retry:1
Feature: AllCheckbox
	Runs All Checkbox related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @Evergreen_ActionsPanel @AllCheckbox @DAS10769 @DAS10656 @DAS12206
Scenario: EvergreenJnr_UsersList_SelectAllCheckboxStatusCheckAfterSearch
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then The number of rows selected matches the number of rows of the main object list
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| alain          | 42           |
	And Select All selectbox is checked
	When User click on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	And Select All selectbox is checked
	And "42" rows are displayed in the agGrid
	And "41339" selected rows are displayed in the Actions panel
	And Clearing the agGrid Search Box
	And Select All selectbox is checked
	When User is deselect all rows
	Then "0" selected rows are displayed in the Actions panel
	When User select all rows
	Then The number of rows selected matches the number of rows of the main object list
	And Select All selectbox is checked

@Evergreen @AllLists @Evergreen_ActionsPanel @AllCheckbox @DAS10775 @DAS10656
Scenario Outline: EvergreenJnr_AllLists_CheckThatSelectAllCheckboxStatusAfterClosingActionPanel
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User clicks the Actions button
	Then Select all checkbox is not displayed

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @Devices @Evergreen_ActionsPanel @AllCheckbox @DAS10772 @DAS10656 @DAS11664 @DAS12206
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

@Evergreen @AllLists @Evergreen_ActionsPanel @AllCheckbox @DAS10656
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
	And User select all rows
	And User select "<Columnname>" rows in the grid
	| SelectedRowsName  |
	| <SelectedRowName> |
	Then "<SelectedRowsCountAfterDiselect>" selected rows are displayed in the Actions panel
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	And "<SelectedRowsCountAfterDiselect>" selected rows are displayed in the Actions panel

Examples: 
	| PageName     | SelectedRowsCount | Columnname    | SelectedRowName                                            | SelectedRowsCountAfterDiselect |
	| Devices      | 17225             | Hostname      | 00BDM1JUR8IF419                                            | 17224                          |
	| Users        | 41339             | Username      | $6BE000-SUDQ9614UVO8                                       | 41338                          |
	| Applications | 2223              | Application   | "WPF/E" (codename) Community Technology Preview (Feb 2007) | 2222                           |
	| Mailboxes    | 14784             | Email Address | 000F977AC8824FE39B8@bclabs.local                           | 14783                          |

@Evergreen @AllLists @Evergreen_ActionsPanel @AllCheckbox @DAS10656
Scenario: EvergreenJnr_UsersList_CheckThatSelectAllWorksCorrectlyForFilteredListsWithAdditionalColumn
	When User add following columns using URL to the "Users" page:
	| ColumnName |
	| Enabled    |
	| Username   |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	| TRUE               |
	Then "Enabled" filter is added to the list
	Then "41,339" rows are displayed in the agGrid
	And table data is filtered correctly
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then "41339" selected rows are displayed in the Actions panel

@Evergreen @Mailboxes @Evergreen_ActionsPanel @AllCheckbox @DAS11894
Scenario: EvergreenJnr_MailboxesList_CheckThatAllCheckboxesAreCheckedAfterAFirstClick
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then All checkboxes are checked in the table
	And The number of rows selected matches the number of rows of the main object list