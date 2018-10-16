Feature: AdminPage
	Runs Admin Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12552 @DAS13011
Scenario: EvergreenJnr_AdminPage_CheckThatFiltersAreWorkingCorrectlyOnTheAdminPages
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "Migration phase 3 team" text in the Search field for "Team" column
	Then Counter shows "1" found rows
	When User resets Search fields for columns
	And User enters "=8" text in the Search field for "Project Buckets" column
	Then Counter shows "0" found rows
	When User resets Search fields for columns
	And User enters "Administrative Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User enters "readonly" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User clicks "Buckets" tab
	And User enters "Cardiff --- Test text fill; Test text fill; ------" text in the Search field for "Bucket" column
	Then Counter shows "1" found rows
	When User resets Search fields for columns
	When User enters "=35" text in the Search field for "Devices" column
	Then Counter shows "0" found rows
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	When User clicks Reset Filters button on the Admin page
	And User enters "barry's" text in the Search field for "Bucket" column
	Then Counter shows "2" found rows
	When User resets Search fields for columns
	And User enters "=2" text in the Search field for "Users" column
	Then Counter shows "2" found rows
	When User resets Search fields for columns
	When User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User enters "M1D" text in the Search field for "Hostname" column
	Then Counter shows "1" found rows
	When User resets Search fields for columns
	And User enters "Windows XP" text in the Search field for "Operating System" column
	Then Counter shows "2" found rows
	When User clicks "Users" tab
	When User enters "Danielle A. Tate" text in the Search field for "Display Name" column
	Then Counter shows "1" found rows
	When User resets Search fields for columns
	And User enters "TZV202" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User click on Back button
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks "Mailboxes" tab
	And User enters "DiscoverySearchMailbox{D919BA05-46A6-415f-80AD-7E09334BB852}@juriba1.onmicrosoft.com" text in the Search field for "Email Address (Primary)" column
	Then Counter shows "1" found rows
	When User resets Search fields for columns
	And User enters "RD-EXCH2K3" text in the Search field for "Server Name" column
	Then Counter shows "6" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12370 @DAS12369
Scenario: EvergreenJnr_ImportProjectPage_CheckThatImportProjectButtonEnabledAfterWarningOnImportProjectPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	And "Projects" page should be displayed to the user
	When User clicks the "IMPORT PROJECT" Action button
	Then "Import Project" page should be displayed to the user
	When User selects incorrect file to upload on Import Project page
	And User selects "Import to new project" option in the "Import" dropdown on the Import Project Page
	And User enters "TestProjectNameDAS12370" in the Project Name field on Import Project page
	When User clicks Import Project button on the Import Project page
	Then Error message with "Selected file is not in a valid format" text is displayed
	When User selects correct file to upload on Import Project page
	Then Import Project button is enabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12806 @DAS12999 @DAS13199 @DAS12680 @DAS12485 @DAS13803 @Project_Creation_and_Scope @Projects @Teams @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedObjectsAreDisplayedAfterChangingProjectBucketsSetting
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject20" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject20" is displayed to user
	When User clicks "Details" tab
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	When User selects "Scope Changes" tab on the Project details page
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
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User clicks "Buckets" tab
	When User enters "Unassigned2" text in the Search field for "Bucket" column
	Then "2" Onboarded objects are displayed
	When User clicks Admin on the left-hand menu

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12948 @DAS13073 @DAS12999 @Delete_Newly_Created_Project @Buckets @Projects @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckTheBucketStateForOnboardedObjects
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project12948" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	Then Bucket dropdown is not displayed on the Project details page
	When User click on Back button
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
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
	When User have opened Column Settings for "Action" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Bucket" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Bucket     |
	Then "Unassigned" text is displayed in the table content
	When User click on Back button
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "[Unassigned]" bucket details is displayed to the user
	When User clicks "Bucket Settings" tab
	And User updates the "Default Bucket" checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page
	And Delete "Bucket12948" Bucket in the Administration
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project12948" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Details" tab
	And User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12763 @DAS12767 @Delete_Newly_Created_Project @Delete_Newly_Created_Bucket @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckDisplayingBucketsAfterCreationProjectsWithDifferentOptions
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
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
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "2Bucket12763" in the "Bucket Name" field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "2Bucket12763" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks the "ADD DEVICE" Action button
	And User adds following Objects from list
	| Objects         |
	| 1ONC8ASZBNVUHC  |
	| 329YFQ9EYZASK5  |
	| 4U31ASACVADPDIF |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	When User click on Back button
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "1Project12763" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User clicks "Select All" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "1Project12763" checkbox from String Filter on the Admin page
	Then "Unassigned" text is displayed in the table content
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "2Project12763" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User clicks "Select All" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "2Project12763" checkbox from String Filter on the Admin page
	#Then Counter shows "3" found rows
	Then "Unassigned" text is displayed in the table content
	Then "1Bucket12763" text is displayed in the table content
	Then "2Bucket12763" text is displayed in the table content
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "3Project12763" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User clicks "Select All" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	Then "3Project12763" is not displayed in the filter dropdown