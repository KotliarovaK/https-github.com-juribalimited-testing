Feature: AdminPage
	Runs Admin Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12552 @DAS13011 @Do_Not_Run_With_Teams
Scenario: EvergreenJnr_AdminPage_CheckThatFiltersAreWorkingCorrectlyOnTheAdminPages
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
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
	And User clicks "Evergreen" link on the Admin page
	And User resets Search fields for columns
	And User enters "Cardiff --- Test text fill; Test text fill; ------" text in the Search field for "Bucket" column
	Then Rows counter contains "1" found row of all rows
	When User resets Search fields for columns
	When User enters "=35" text in the Search field for "Devices" column
	Then Rows counter contains "1" found row of all rows
	When User clicks Admin on the left-hand menu
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	When User clicks Reset Filters button on the Admin page
	And User enters "barry's" text in the Search field for "Bucket" column
	Then Rows counter contains "2" found row of all rows
	When User resets Search fields for columns
	And User enters "=2" text in the Search field for "Users" column
	Then Rows counter contains "2" found row of all rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12370 @DAS12369 @DAS14212
Scenario: EvergreenJnr_ImportProjectPage_CheckThatImportProjectButtonEnabledAfterWarningOnImportProjectPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	And "Projects" page should be displayed to the user
	When User clicks the "IMPORT PROJECT" Action button
	Then "Import Project" page should be displayed to the user
	When User selects "IncorrectFile.zip" file to upload on Import Project page
	And User selects "Import to new project" option in the "Import" dropdown on the Import Project Page
	And User enters "TestProjectNameDAS12370" in the Project Name field on Import Project page
	When User clicks Import Project button on the Import Project page
	Then Error message with "Selected file is not in a valid format" text is displayed
	When User selects "CorrectFile_DAS12370.xml" file to upload on Import Project page
	Then Import Project button is enabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13766 @DAS14153
Scenario Outline: EvergreenJnr_AdminPage_CheckPositionOfContextMenuInGrid
	When User clicks Admin on the left-hand menu
	And User clicks "<PageName>" link on the Admin page
	And User performs right-click on "<CellText>" cell in the grid
	Then User sees context menu placed near "<CellText>" cell in the grid

Examples:
	| PageName       | CellText   |
	| Projects       | EmailMigra |
	| Teams          | IB Team    |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13766 @DAS14153
Scenario: EvergreenJnr_AdminPage_CheckPositionOfContextMenuInGridForBuckets
	When User clicks Admin on the left-hand menu
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	And User performs right-click on "Evergreen" cell in the grid
	Then User sees context menu placed near "Evergreen" cell in the grid

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13766 @DAS14153
Scenario: EvergreenJnr_AdminPage_CheckPositionOfContextMenuInGridForCapacityUnits
	When User clicks Admin on the left-hand menu
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	And User performs right-click on "True" cell in the grid
	Then User sees context menu placed near "True" cell in the grid

#Should be added one more beforeScenario to make Unassigned backed default again
@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12948 @DAS13073 @DAS12999 @DAS13973 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckTheBucketStateForOnboardedObjects
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project12948" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User selects "Standalone Project" in the Mode Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters "Bucket12948" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User updates the "Default Bucket" checkbox state
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project12948" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User selects "Scope Changes" tab on the Project details page
	And User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 0TTSZRQ1ZTIXWM |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items          |
	| 0TTSZRQ1ZTIXWM |
	Then "Unassigned" text is displayed in the table content
	When User click on Back button
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "[Unassigned]" bucket details is displayed to the user
	When User updates the "Default Bucket" checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page
	And Delete "Bucket12948" Bucket in the Administration
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project12948" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Details" tab
	And user selects "Clone evergreen buckets to project buckets" in the Bucket dropdown
	Then There are no errors in the browser console
	When User clicks "Scope" tab
	When User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12763 @DAS12767 @DAS13973 @Cleanup @Cleanup @archived
Scenario: EvergreenJnr_AdminPage_CheckDisplayingBucketsAfterCreationProjectsWithDifferentOptions
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters "1Bucket12763" in the "Bucket Name" field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "1Bucket12763" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks the "ADD DEVICE" Action button
	And User adds following Objects from list
	| Objects         |
	| 0405FHJHVG45U71 |
	| 2A6FHO2JSIMNAQ  |
	| 4AII611FFHAZXWG |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	When User click on Back button
	And User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters "2Bucket12763" in the "Bucket Name" field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "2Bucket12763" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks the "ADD DEVICE" Action button
	And User adds following Objects from list
	| Objects         |
	| 1ONC8ASZBNVUHC  |
	| 329YFQ9EYZASK5  |
	| 4U31ASACVADPDIF |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	When User click on Back button
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "1Project12763" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "Select All" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "1Project12763" checkbox from String Filter with item list on the Admin page
	Then "Unassigned" text is displayed in the table content
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "2Project12763" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	When User selects "Scope Changes" tab on the Project details page
	And User expands the object to add
	And User selects following Objects
	| Objects         |
	| 0405FHJHVG45U71 |
	| 2A6FHO2JSIMNAQ  |
	| 4AII611FFHAZXWG |
	| 1ONC8ASZBNVUHC  |
	| 329YFQ9EYZASK5  |
	| 4U31ASACVADPDIF |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "6 objects queued for onboarding, 0 objects offboarded" text
	When User click on Back button
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks Refresh button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	And User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "2Project12763" checkbox from String Filter with item list on the Admin page
	Then "Unassigned" text is displayed in the table content
	And "1Bucket12763" text is displayed in the table content
	And "2Bucket12763" text is displayed in the table content
#The steps below are commented out because the "Evergreen" Project Mode is disabled
	#When User clicks "Projects" link on the Admin page
	#Then "Projects" page should be displayed to the user
	#When User clicks the "CREATE PROJECT" Action button
	#Then "Create Project" page should be displayed to the user
	#When User enters "3Project12763" in the "Project Name" field
	#And User selects "All Devices" in the Scope Project dropdown
	#When User selects "Evergreen" in the Mode Project dropdown
	#And User clicks Create button on the Create Project page
	#Then Success message is displayed and contains "The project has been created" text
	#When User clicks "Evergreen" link on the Admin page
	#When User clicks "Buckets" tab
	#Then "Buckets" page should be displayed to the user
	#When User clicks Reset Filters button on the Admin page
	#And User clicks String Filter button for "Project" column on the Admin page
	#And User selects "Select All" checkbox from String Filter with item list on the Admin page
	#And User clicks String Filter button for "Project" column on the Admin page
	#Then "3Project12763" is not displayed in the filter dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS15989 @Cleanup
Scenario: EvergreenJnr_ImportProjectPage_CheckThatExtraUnknownReadinessIsNotCreatedWhileImportingToANewProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	And "Projects" page should be displayed to the user
	When User clicks the "IMPORT PROJECT" Action button
	Then "Import Project" page should be displayed to the user
	When User selects "1803_Rollout.xml" file to upload on Import Project page
	And User selects "Import to new project" option in the "Import" dropdown on the Import Project Page
	And User enters "DAS15989_TestProject" in the Project Name field on Import Project page
	When User clicks Import Project button on the Import Project page
	When User clicks newly created object link
	Then Project "DAS15989_TestProject" is displayed to user
	When User clicks "Readiness" tab
	Then "UNKNOWN" content is not displayed in the grid on the Project details page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16089 @Cleanup
Scenario: EvergreenJnr_ImportProjectPage_CheckBannerMessageAfterImportProjectWithoutReadiness 
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	And "Projects" page should be displayed to the user
	When User clicks the "IMPORT PROJECT" Action button
	Then "Import Project" page should be displayed to the user
	When User selects "Windows_7_Migration_(Computer_Scheduled_Project) (jet 5.3.3).xml" file to upload on Import Project page
	And User selects "Import to new project" option in the "Import" dropdown on the Import Project Page
	And User enters "DAS16089_TestProject" in the Project Name field on Import Project page
	When User clicks Import Project button on the Import Project page
	Then Error message with "Your file doesn't contain Readiness values" text is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16417
Scenario: EvergreenJnr_ImportProjectPage_CheckFormattingForIntegerValues
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	And User enters "Unassigned" text in the Search field for "Bucket" column
	Then "16933" content is displayed in "Devices" column
	Then "41050" content is displayed in "Users" column
	Then "14538" content is displayed in "Mailboxes" column
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "9420" content is displayed in "Devices" column
	Then "27140" content is displayed in "Users" column
	Then "5288" content is displayed in "Mailboxes" column
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Rings" tab
	And User enters "Unassigned" text in the Search field for "Ring" column
	Then "15802" content is displayed in "Devices" column
	Then "38677" content is displayed in "Users" column
	Then "13752" content is displayed in "Mailboxes" column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16384
Scenario: EvergreenJnr_ImportProjectPage_CheckAdditionalColumnClickthroughsFromBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Birmingham" text in the Search field for "Bucket" column
	When User clicks content from "Devices" column
	Then "Devices" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName       |
	| Evergreen Bucket |
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User enters "Manchester" text in the Search field for "Bucket" column
	When User clicks content from "Users" column
	Then "Users" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName       |
	| Evergreen Bucket |
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	When User clicks content from "Mailboxes" column
	Then "Mailboxes" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName       |
	| Evergreen Bucket |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16384
Scenario: EvergreenJnr_ImportProjectPage_CheckAdditionalColumnClickthroughsFromCapacityUnits
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User clicks content from "Devices" column
	Then "Devices" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	When User clicks content from "Users" column
	Then "Users" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	When User clicks content from "Mailboxes" column
	Then "Mailboxes" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |
	When User clicks Admin on the left-hand menu
	When User enters "1803 Rollout" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User selects "Capacity" tab on the Project details page
	When User selects "Units" tab on the Project details page
	When User clicks content from "Applications" column
	Then "Applications" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName          |
	| 1803: Capacity Unit |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16384
Scenario: EvergreenJnr_ImportProjectPage_CheckAdditionalColumnClickthroughsFromRings
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Rings" tab
	Then "Rings" page should be displayed to the user
	When User clicks content from "Devices" column
	Then "Devices" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName     |
	| Evergreen Ring |
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Rings" tab
	When User clicks content from "Users" column
	Then "Users" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName     |
	| Evergreen Ring |
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Rings" tab
	When User clicks content from "Mailboxes" column
	Then "Mailboxes" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName     |
	| Evergreen Ring |
	When User clicks Admin on the left-hand menu
	When User enters "Barry's User Project" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User selects "Rings" tab on the Project details page
	When User clicks content from "Users" column
	Then "Users" list should be displayed to the user
	Then ColumnName is added to the list
	| ColumnName       |
	| Barry'sUse: Ring |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16675 @DAS16676
Scenario: EvergreenJnr_AdminPage_CheckThatAppropriatePageIsDisplayedAfterClickingCrumbTrailOnAdminPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User selects "Buckets" tab on the Project details page
	Then "Buckets" page should be displayed to the user
	When User clicks content from "Bucket" column
	When User clicks on "Buckets" navigation link
	Then "Buckets" page should be displayed to the user
	When User selects "Capacity Units" tab on the Project details page
	Then "Capacity Units" page should be displayed to the user
	When User clicks content from "Capacity Unit" column
	When User clicks on "Capacity Units" navigation link
	Then "Capacity Units" page should be displayed to the user
	When User selects "Rings" tab on the Project details page
	Then "Rings" page should be displayed to the user
	When User clicks content from "Ring" column
	When User clicks on "Rings" navigation link
	Then "Rings" page should be displayed to the user
	#ready on 'Nova'
	#When User clicks "Automations" link on the Admin page
	#When User selects "Automations" tab on the Project details page
	#Then "Automations" page should be displayed to the user
	#When User clicks content from "Automation" column
	#When User clicks on "Automations" navigation link
	#Then "Automations" page should be displayed to the user
	#Then "Automations" tab-menu on the Admin page is expanded