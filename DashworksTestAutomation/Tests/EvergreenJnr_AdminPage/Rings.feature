Feature: Rings
	Runs Rings related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14867 @DAS15417 @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorDisplayedWhenDeletingRing
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Rings" tab
	And User clicks the "CREATE PROJECT RING" Action button
	Then "Create Project Ring" page should be displayed to the user
	When User type "TestRing" Name in the "Ring name" field on the Project details page
	And User clicks Create button on the Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| TestRing         |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected ring has been deleted" text
	And There are no errors in the browser console

@Evergreen @Admin @@EvergreenJnr_AdminPage @Rings @DAS14780 @DAS13530 @Buckets @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChanged
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForDAS14780" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User enters "ProjectForDAS14780" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "ProjectForDAS14780" is displayed to user
	When User clicks "Details" tab
	Then "Clone evergreen rings to project rings" text value is displayed in the "Rings" dropdown
	When User clicks "Rings" tab
	And User enters "Unassigned" text in the Search field for "Ring" column
	And User clicks content from "Ring" column
	Then Ring settings Maps to evergreen ring is displayed as "Unassigned"
	When User sets "None" value in Maps to evergreen ring field
	Then Ring settings Maps to evergreen ring is displayed as "None"
	When User clicks "Administration" navigation link on the Admin page
	When User clicks "Buckets" link on the Admin page
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "ProjectForDAS14780" checkbox from String Filter with item list on the Admin page
	Then "Unassigned" text is displayed in the table content

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14901
Scenario: EvergreenJnr_AdminPage_CheckThatOneRingAddeddAfterMulticlickingCreateButton
	When User clicks Admin on the left-hand menu
	And User clicks "Rings" link on the Admin page
	And User clicks the "CREATE EVERGREEN RING" Action button
	And User type "OneRing" Name in the "Ring name" field on the Project details page
	And User doubleclicks Create button on Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User enters "OneRing" text in the Search field for "Ring" column
	Then Counter shows "1" found rows
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14903
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectPageDisplayedWhenOpeningNotExistingRingDetailsExist
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Rings" tab
	And User enters "Unassigned" text in the Search field for "Ring" column
	And User clicks content from "Ring" column
	And User tries to open same page with another item id
	Then Page not found displayed for Ring details page
	And There are only page not found errors in console

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14690 @DAS14691 @DAS15370 @DAS14692 @DAS14695 @DAS15415 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckProjectDetailFormAndRingDropdown
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "14690_Project" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "None" in the "Project Template" dropdown
	When User selects "Standalone Project" in the "Mode" dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "14690_Project" is displayed to user
	When User clicks "Rings" tab
	When User clicks content from "Ring" column
	Then "Unassigned" content is displayed in "Ring name" field
	Then "Unassigned" content is displayed in "Description" field
	Then "UPDATE" Action button is disabled
	When User changes Name to "NewDescription" in the "Description" field on the Project details page
	Then "UPDATE" Action button is active
	#Update after DAS-15415 fixed
	#Then "Default Ring" checkbox is checked and cannot be unchecked
	#Then "Maps to Evergreen Ring" dropdown is not displayed on the Admin Settings screen
	When User clicks the "CANCEL" Action button
	Then "TRUE" content is displayed in "Default" column
	When User have opened Column Settings for "Ring" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then Content is empty in the column
	| ColumnName        |
	| Maps to Evergreen |
	When User clicks "Details" tab
	And User changes Project Name to "New_14690_Project"
	Then "14690_Pro" content is displayed in "Project Short Name" field
	When User changes Project Short Name to "New_Short"
	Then "14690_Project" content is displayed in "Project Description" field
	When User changes Project Description to "New_14690_Description"
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then "Device scoped project" is displayed in the disabled Project Type field
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then "Use project rings" text value is displayed in the "Rings" dropdown
	When User selects "Clone evergreen rings to project rings" in the "Rings" dropdown
	When User clicks "Projects" navigation link on the Admin page
	When User enters "New_14690_Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "New_14690_Project" is displayed to user
	When User clicks "Details" tab
	Then "Clone evergreen buckets to project buckets" text value is displayed in the "Buckets" dropdown
	Then "Clone evergreen rings to project rings" text value is displayed in the "Rings" dropdown
	Then "New_Short" content is displayed in "Project Short Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14695 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "14695_Project" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "14695_Project" is displayed to user
	When User clicks "Rings" tab
	Then Columns on Admin page is displayed in following order:
	| ColumnName |
	|            |
	|            |
	| Ring       |
	|            |
	| Default    |
	| Devices    |
	When User clicks Cog-menu on the Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	When User clicks the "CREATE PROJECT RING" Action button
	Then "Create Project Ring" page should be displayed to the user
	When User type "14695_Ring" Name in the "Ring name" field on the Project details page
	And User clicks Create button on the Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User clicks the "CREATE PROJECT RING" Action button
	Then "Create Project Ring" page should be displayed to the user
	When User type "Ring_Test" Name in the "Ring name" field on the Project details page
	When User clicks Default Ring checkbox
	And User clicks Create button on the Create Ring page
	Then column content is displayed in the following order:
    | Items      |
    | Unassigned |
    | 14695_Ring |
    | Ring_Test  |
	When User click on 'Ring' column header
	Then data in table is sorted by "Ring" column in ascending order on the Admin page
	When User click on 'Ring' column header
	Then data in table is sorted by "Ring" column in descending order on the Admin page
	When User clicks Cog-menu on the Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Set default      |
	| Delete           |
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| Unassigned       |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "This ring will be permanently deleted and any objects within it reassigned to the default ring" text is displayed on the Admin page
	When User clicks Delete button in the warning message