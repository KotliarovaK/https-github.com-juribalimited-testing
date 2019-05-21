﻿Feature: AdminPage
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
	Then Rows counter shows "1" of "6" rows
	When User clicks "Evergreen" link on the Admin page
	And User enters "Cardiff --- Test text fill; Test text fill; ------" text in the Search field for "Bucket" column
	Then Rows counter contains "1" found row of all rows
	When User resets Search fields for columns
	When User enters "=35" text in the Search field for "Devices" column
	Then Rows counter contains "0" found row of all rows
	When User clicks Admin on the left-hand menu
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	When User clicks Reset Filters button on the Admin page
	And User enters "barry's" text in the Search field for "Bucket" column
	Then Rows counter contains "2" found row of all rows
	When User resets Search fields for columns
	And User enters "=2" text in the Search field for "Users" column
	Then Rows counter contains "2" found row of all rows
	When User resets Search fields for columns
	When User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User enters "M1D" text in the Search field for "Hostname" column
	Then Rows counter shows "1" of "2" rows
	When User resets Search fields for columns
	And User enters "Windows XP" text in the Search field for "Operating System" column
	Then Rows counter shows "2" of "2" rows
	When User clicks "Users" tab
	When User enters "Danielle A. Tate" text in the Search field for "Display Name" column
	Then Rows counter shows "1" of "1" rows
	When User resets Search fields for columns
	And User enters "TZV202" text in the Search field for "Username" column
	Then Rows counter shows "1" of "1" rows
	When User click on Back button
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks "Mailboxes" tab
	And User enters "DiscoverySearchMailbox{D919BA05-46A6-415f-80AD-7E09334BB852}@juriba1.onmicrosoft.com" text in the Search field for "Email Address (Primary)" column
	Then Rows counter shows "1" of "14538" rows
	When User resets Search fields for columns
	And User enters "RD-EXCH2K3" text in the Search field for "Server Name" column
	Then Rows counter shows "6" of "14538" rows

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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12806 @DAS12999 @DAS13199 @DAS12680 @DAS12485 @DAS13803 @DAS13930 @DAS13973 @DAS12768 @Project_Creation_and_Scope @Projects @Teams @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedObjectsAreDisplayedAfterChangingProjectBucketsSetting
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject20" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject20" is displayed to user
	When User clicks "Details" tab
	And User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	When User clicks "Scope" tab
	And User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown
	When User expands the object to add
	And User selects following Objects
	| Objects         |
	| 0281Z793OLLLDU6 |
	| 03U75EKEMUQMUS  |
	Then "Devices 2/0" is displayed in the tab header on the Admin page
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then "Devices 0/0" is displayed in the tab header on the Admin page
	When User click on Back button
	And User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User clicks "Evergreen" link on the Admin page
	And User enters "Unassigned2" text in the Search field for "Bucket" column
	Then "2" Onboarded objects are displayed
	When User clicks Admin on the left-hand menu

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12948 @DAS13073 @DAS12999 @DAS13973 @Delete_Newly_Created_Project @Buckets @Projects
Scenario: EvergreenJnr_AdminPage_CheckTheBucketStateForOnboardedObjects
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE" Action button
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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12763 @DAS12767 @DAS13973 @Delete_Newly_Created_Project @Delete_Newly_Created_Bucket @archived
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
	When User clicks the "CREATE" Action button
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
	When User clicks the "CREATE" Action button
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
	#When User clicks the "CREATE" Action button
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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS15989 @Delete_Newly_Created_Project
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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS16089 @Delete_Newly_Created_Project
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
	Then "16,877" content is displayed in "Devices" column
	Then "41,049" content is displayed in "Users" column
	Then "14,538" content is displayed in "Mailboxes" column
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	And User enters "Capacity Unit" text in the Search field for "Bucket" column
	Then "9,365" content is displayed in "Devices" column
	Then "27,140" content is displayed in "Users" column
	Then "5,288" content is displayed in "Mailboxes" column
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	And User enters "Capacity Unit" text in the Search field for "Bucket" column
	Then "15,682" content is displayed in "Devices" column
	Then "38,677" content is displayed in "Users" column
	Then "13,752" content is displayed in "Mailboxes" column

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