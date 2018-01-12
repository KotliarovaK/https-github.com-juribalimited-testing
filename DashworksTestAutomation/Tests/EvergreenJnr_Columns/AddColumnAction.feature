@retry:1
Feature: AddColumnAction
	Runs Add column related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @AddColumnAction @DAS10665
Scenario: EvergreenJnr_DevicesList_AddTheDeviceKeyColumnToTheDevicesList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Device Key          |
	Then ColumnName is added to the list
	| ColumnName          |
	| Device Key          |
	And Content is present in the newly added column
	| ColumnName          |
	| Device Key          |

@Evergreen @Mailboxes @EvergreenJnr_Columns @AddColumnAction @DAS10665
Scenario: EvergreenJnr_MailboxesList_CheckThat500ErrorIsNotDisplayedAfterSortingForSelectedColumn
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| Owner Department Full Path |
	Then ColumnName is added to the list
	| ColumnName                 |
	| Owner Department Full Path |
	When User click on 'Owner Department Full Path' column header
	Then data in table is sorted by 'Owner Department Full Path' column in ascending order
	And "Mailboxes" list should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_Columns @AddColumnAction @DAS11576
Scenario Outline: EvergreenJnr_MailboxesList_CheckThatMaxReceiveSizeAndMaxSendSizeColumnIsDisplayedAfterSelectingOnFilterPanel 
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	Then "<FilterName>" filter is added to the list
	Then ColumnName is added to the list
	| ColumnName   |
	| <FilterName> |

Examples:
	| FilterName            |
	| Max Receive Size (MB) |
	| Max Send Size (MB)    |