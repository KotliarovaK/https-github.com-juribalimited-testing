Feature: AdminPage
	Runs Admin Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12552 @DAS13011 @Do_Not_Run_With_Teams
Scenario: EvergreenJnr_AdminPage_CheckThatFiltersAreWorkingCorrectlyOnTheAdminPages
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "Migration phase 3 team" text in the Search field for "Team" column
	Then Rows counter contains "1" found row of all rows
	When User resets Search fields for columns
	And User enters "=8" text in the Search field for "Project Buckets" column
	Then Rows counter contains "0" found row of all rows
	When User resets Search fields for columns
	And User enters "Administrative Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User enters "readonly" text in the Search field for "Username" column
	Then Rows counter contains "1" found row of all rows
	When User click on Back button
	And User navigates to the 'Evergreen' left menu item
	And User resets Search fields for columns
	And User enters "Cardiff --- Test text fill; Test text fill; ------" text in the Search field for "Bucket" column
	Then Rows counter contains "1" found row of all rows
	When User resets Search fields for columns
	When User enters "=35" text in the Search field for "Devices" column
	Then Rows counter contains "1" found row of all rows
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Buckets' left menu item
	When User clicks Reset Filters button on the Admin page
	And User enters "barry's" text in the Search field for "Bucket" column
	Then Rows counter contains "2" found row of all rows
	When User resets Search fields for columns
	And User enters "=2" text in the Search field for "Users" column
	Then Rows counter contains "2" found row of all rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13766 @DAS14153
Scenario Outline: EvergreenJnr_AdminPage_CheckPositionOfContextMenuInGrid
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the '<PageName>' left menu item
	When User right clicks on '<CellText>' cell from '<Column>' column
	Then User sees context menu placed near '<CellText>' cell in the '<Column>' column

Examples:
	| PageName | CellText   | Column     |
	| Projects | EmailMigra | Short Name |
	| Teams    | IB Team    | Team       |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13766 @DAS14153
Scenario Outline: EvergreenJnr_AdminPage_CheckPositionOfContextMenuInGridForBucketsAndCapacityUnits
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	When User right clicks on 'Evergreen' cell from 'Project' column
	Then User sees context menu placed near 'Evergreen' cell in the 'Project' column

Examples:
	| PageName       | CellText  | Column  |
	| Buckets        | Evergreen | Project |
	| Capacity Units | True      | Default |

#Should be added one more beforeScenario to make Unassigned backed default again
@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12948 @DAS13073 @DAS12999 @DAS13973 @Cleanup @Set_Default_Bucket @Do_Not_Run_With_Buckets
Scenario: EvergreenJnr_AdminPage_CheckTheBucketStateForOnboardedObjects
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project12948 | All Devices | None            | Standalone Project |
	And User creates new Bucket via api
	| Name        | TeamName | IsDefault |
	| Bucket12948 | Admin IT | true      |
	And User clicks 'Admin' on the left-hand menu
	Then Page with 'Projects' header is displayed to user
	When User enters "Project12948" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope Changes' left menu item
	And User expands multiselect and selects following Objects
	| Objects        |
	| 0TTSZRQ1ZTIXWM |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	And User navigates to the 'Queue' left menu item
	Then following Items are displayed in the Queue table
	| Items          |
	| 0TTSZRQ1ZTIXWM |
	Then 'Unassigned' content is displayed in the 'Bucket' column
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
	Then 'Unassigned' content is displayed in the 'Ring' column
	When User click on Back button
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then Page with 'Unassigned' header is displayed to user
	When User updates the "Default Bucket" checkbox state
	When User clicks 'UPDATE' button
	Then 'Unassigned' text in 'The {0} bucket has been updated' message is displayed on inline success banner
	And Delete "Bucket12948" Bucket in the Administration
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "Project12948" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Details' left menu item
	When User selects 'Clone Evergreen buckets to project buckets' in the 'Buckets' dropdown
	Then There are no errors in the browser console
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	Then 'Match to Evergreen Bucket' content is displayed in 'Bucket' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16417
Scenario: EvergreenJnr_ImportProjectPage_CheckFormattingForIntegerValues
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	And User enters "Unassigned" text in the Search field for "Bucket" column
	Then '16933' content is displayed in the 'Devices' column
	Then '41049' content is displayed in the 'Users' column
	Then '14637' content is displayed in the 'Mailboxes' column
	When User navigates to the 'Capacity Units' left menu item
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then '9420' content is displayed in the 'Devices' column
	Then '27140' content is displayed in the 'Users' column
	Then '5391' content is displayed in the 'Mailboxes' column
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Rings' left menu item
	And User enters "Unassigned" text in the Search field for "Ring" column
	Then '15737' content is displayed in the 'Devices' column
	Then '38677' content is displayed in the 'Users' column
	Then '13852' content is displayed in the 'Mailboxes' column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16384
Scenario: EvergreenJnr_ImportProjectPage_CheckAdditionalColumnClickthroughsFromBuckets
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User enters "Birmingham" text in the Search field for "Bucket" column
	When User clicks content from "Devices" column
	Then 'All Devices' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName       |
	| Evergreen Bucket |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	When User enters "Manchester" text in the Search field for "Bucket" column
	When User clicks content from "Users" column
	Then 'All Users' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName       |
	| Evergreen Bucket |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	When User enters "Unassigned" text in the Search field for "Bucket" column
	When User clicks content from "Mailboxes" column
	Then 'All Mailboxes' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName       |
	| Evergreen Bucket |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16384
Scenario: EvergreenJnr_ImportProjectPage_CheckAdditionalColumnClickthroughsFromCapacityUnits
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	When User clicks content from "Devices" column
	Then 'All Devices' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	When User clicks content from "Users" column
	Then 'All Users' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	When User clicks content from "Mailboxes" column
	Then 'All Mailboxes' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	When User clicks 'Admin' on the left-hand menu
	When User enters "2004 Rollout" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Units' left menu item
	When User clicks content from "Applications" column
	Then 'All Applications' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName          |
	| 2004: Capacity Unit |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16384
Scenario: EvergreenJnr_ImportProjectPage_CheckAdditionalColumnClickthroughsFromRings
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Rings' left menu item
	Then Page with 'Rings' header is displayed to user
	When User clicks content from "Devices" column
	Then 'All Devices' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName     |
	| Evergreen Ring |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Rings' left menu item
	When User clicks content from "Users" column
	Then 'All Users' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName     |
	| Evergreen Ring |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Rings' left menu item
	When User clicks content from "Mailboxes" column
	Then 'All Mailboxes' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName     |
	| Evergreen Ring |
	When User clicks 'Admin' on the left-hand menu
	When User enters "Barry's User Project" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Rings' left menu item
	When User clicks content from "Users" column
	Then 'All Users' list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName       |
	| Barry'sUse: Ring |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16675 @DAS16676
Scenario: EvergreenJnr_AdminPage_CheckThatAppropriatePageIsDisplayedAfterClickingCrumbTrailOnAdminPage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks content from "Bucket" column
	When User clicks 'Buckets' header breadcrumb
	Then Page with 'Buckets' header is displayed to user
	When User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	When User clicks content from "Capacity Unit" column
	When User clicks 'Capacity Units' header breadcrumb
	Then Page with 'Capacity Units' header is displayed to user
	When User navigates to the 'Rings' left menu item
	Then Page with 'Rings' header is displayed to user
	When User clicks content from "Ring" column
	When User clicks 'Rings' header breadcrumb
	Then Page with 'Rings' header is displayed to user
	When User navigates to the 'Automations' left menu item
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks content from "Automation" column
	When User clicks 'Automations' header breadcrumb
	Then Page with 'Automations' header is displayed to user
	Then 'Automations' left menu item is expanded

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS15896
Scenario: EvergreenJnr_AdminPage_CheckThatNumberOfRequestsDontExceedAllowedCount
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	Then Number of requests to '/admin' is not greater than '7'