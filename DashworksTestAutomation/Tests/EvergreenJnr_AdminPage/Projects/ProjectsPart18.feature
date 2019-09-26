Feature: ProjectsPart18
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11944 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckSelectedRowsCountDisplayingOnProjectsGrid
	When User clicks 'Admin' on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "TestProjectDAS11944" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks the "CREATE" Action button
	When User enters "Barry's User Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	Then Rows counter contains "1" found row of all rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11931 @DAS12742 @DAS11769 @DAS12999 @DAS13973 @Project_Creation_and_Scope @Cleanup @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckThatProjectsAreDeletedSuccessfullyAndThereAreNoConsoleErrors
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| <ProjectName> | <ScopeList> | None            | Standalone Project |
	When User clicks 'Admin' on the left-hand menu
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message is displayed and contains "The selected project has been deleted" text
	And There are no errors in the browser console
	Then "<ProjectName>" item was removed
	When User create static list with "<StaticList>" name on "<PageName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the "Project Name" field
	And User selects '<StaticList>' option from 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks '<PageName>' on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<PageName>" page
	Then "<DynamicList>" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the "Project Name" field
	And User selects '<DynamicList>' option from 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text

Examples:
	| ProjectName  | ScopeList     | StaticList     | PageName  | Item                   | ColumnName    | DynamicList     |
	| TestProject2 | All Devices   | StaticList8812 | Devices   | 00KWQ4J3WKQM0G         | Hostname      | DynamicList9517 |
	| TestProject3 | All Users     | StaticList8813 | Users     | 003F5D8E1A844B1FAA5    | Username      | DynamicList9518 |
	| TestProject4 | All Mailboxes | StaticList8814 | Mailboxes | ZVI880605@bclabs.local | Email Address | DynamicList9519 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS11726 @DAS12761 @DAS11770 @DAS12999 @DAS11892 @Project_Creation_and_Scope @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyProjectName
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters " " in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	Then Create Project button is disabled
	When User enters "AllDevices Project" in the "Project Name" field
	And User clicks Create button on the Create Project page
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters " alldevices project" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Error message with "A project already exists with this name" text is displayed
	When User create static list with "StaticList4581" name on "Devices" page with following items
	| ItemName       |
	| 0AN6PG99INA7R2 |
	| 0B4UHHUZQBRXKE |
	Then "StaticList4581" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject84" in the "Project Name" field
	And User selects 'StaticList4581' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User enters "TestProject84" text in the Search field for "Project" column
	Then "TestProject84" text in search field is displayed correctly for "Project" column
	When User selects all rows on the grid
	And User removes selected item
	When User clicks 'Devices' on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks on 'Hostname' column header
	And User create dynamic list with "DynamicList5531" name on "Devices" page
	Then "DynamicList5531" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "AllDevices Project1258" in the "Project Name" field
	And User selects 'DynamicList5531' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	And User enters "AllDevices Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13733 @DAS14682 @DAS11565 @Projects
Scenario: EvergreenJnr_ImportProjectPage_CheckThatImportIsSuccessAfterDuplicatesInProjectTasksError
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks the "IMPORT PROJECT" Action button
	#DAS11565
	Then "Import Task to Request Type relationships" checkbox is displayed on the Admin page
	Then "Import Mail Templates" checkbox is displayed on the Admin page
	Then "Import Mail Template to Task Relationships" checkbox is displayed on the Admin page
	When User clicks "Import Request Types" checkbox on the Project details page
	Then "Import Mail Template to Task Relationships" checkbox is disabled on the Admin page
	When User clicks the "CANCEL" Action button
	When User clicks the "IMPORT PROJECT" Action button
	#DAS11565
	When User selects "DAS_13733_Duplicates_in_project_tasks.xml" file to upload on Import Project page
	And User selects "Import to new project" option in the "Import" dropdown on the Import Project Page
	And User enters "TestProjectDAS13733" in the Project Name field on Import Project page
	And User clicks following checkboxes on the Project details page:
	| CheckboxesToBeClicked |
	| Import Readiness      |
	And User clicks Import Project button on the Import Project page
	Then Error message with "This XML file contains duplicates in project tasks" text is displayed
	When User selects "DAS_13733_Valid_file.xml" file to upload on Import Project page
	And User clicks the "IMPORT PROJECT" Action button
	Then "Projects" page should be displayed to the user
	And Success message is displayed and contains "The project has been imported, click here to view the TestProjectDAS13733 project" text
	When User enters "TestProjectDAS13733" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item