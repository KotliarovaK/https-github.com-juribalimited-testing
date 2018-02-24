@retry:1
Feature: AddColumnAction
	Runs Add column related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @AddColumnAction @DAS10665
Scenario: EvergreenJnr_DevicesList_AddTheDeviceKeyColumnToTheDevicesList
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Device Key          |
	Then Content is present in the newly added column
	| ColumnName          |
	| Device Key          |

@Evergreen @Mailboxes @EvergreenJnr_Columns @AddColumnAction @DAS10665
Scenario: EvergreenJnr_MailboxesList_CheckThat500ErrorIsNotDisplayedAfterSortingForSelectedColumn
	When User add following columns using URL to the "Mailboxes" page:
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

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS11689
Scenario Outline: EvergreenJnr_AllLists_CheckThatTableIsFullyLoadedAfterAddingTheColumns
	When User add following columns using URL to the "<ListName>" page:
	| ColumnName                        |
	| Windows7Mi: Application Readiness |
	| UserSchedu: Readiness             |
	Then Content is present in the newly added column
	| ColumnName                        |
	| Windows7Mi: Application Readiness |
	| UserSchedu: Readiness             |
	Then full list content is displayed to the user
	Then There are no errors in the browser console

Examples: 
	| ListName     |
	| Devices      |
	| Applications |

@Evergreen @Applications @EvergreenJnr_Columns @AddColumnAction @DAS10997 @DAS12026 @Not_Run
Scenario Outline: EvergreenJnr_Applications_CheckThatConsoleErrorsAreNotDisplayedForImages
	When User add following columns using URL to the "Applications" page:
	| ColumnName   |
	| <ColumnName> |
	Then There are no errors in the browser console

Examples: 
	| ColumnName                              |
	| Windows7Mi: Application Rationalisation |
	| Windows7Mi: Application Readiness       |
	| Windows7Mi: Core Application            |
	| Windows7Mi: Hide from End Users         |

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS11871
Scenario Outline: EvergreenJnr_AllLists_CheckThatConsoleErrorsAreNotDisplayedAfterSortingUserScheduReadinessIDColumn
	When User add following columns using URL to the "<ListName>" page:
	| ColumnName               |
	| UserSchedu: Readiness ID |
	Then Content is present in the newly added column
	| ColumnName               |
	| UserSchedu: Readiness ID |
	Then full list content is displayed to the user
	When User click on 'UserSchedu: Readiness ID' column header
	Then data in table is sorted by 'UserSchedu: Readiness ID' column in descending order
	Then There are no errors in the browser console

Examples: 
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |