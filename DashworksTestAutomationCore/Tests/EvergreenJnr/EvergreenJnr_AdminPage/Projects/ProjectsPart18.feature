Feature: ProjectsPart18
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11944 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckSelectedRowsCountDisplayingOnProjectsGrid
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User clicks 'CREATE PROJECT' button 
	And User enters 'TestProjectDAS11944' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks 'CREATE' button 
	When User enters "Barry's User Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	Then Rows counter contains "1" found row of all rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11931 @DAS12742 @DAS11769 @DAS12999 @DAS13973 @Project_Creation_and_Scope @Cleanup @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckThatProjectsAreDeletedSuccessfullyAndThereAreNoConsoleErrors
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| <ProjectName> | <ScopeList> | None            | Standalone Project |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	Then 'The selected project has been deleted' text is displayed on inline success banner
	And There are no errors in the browser console
	Then '<ProjectName>' content is not displayed in the 'Project' column
	When User create static list with "<StaticList>" name on "<PageName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	And User selects '<StaticList>' option from 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button 
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<PageName>" page
	Then "<DynamicList>" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	And User selects '<DynamicList>' option from 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button 
	Then 'The project has been created' text is displayed on inline success banner

Examples:
	| ProjectName  | ScopeList     | StaticList     | PageName  | Item                   | ColumnName    | DynamicList     |
	| TestProject2 | All Devices   | StaticList8812 | Devices   | 00KWQ4J3WKQM0G         | Hostname      | DynamicList9517 |
	| TestProject3 | All Users     | StaticList8813 | Users     | 003F5D8E1A844B1FAA5    | Username      | DynamicList9518 |
	| TestProject4 | All Mailboxes | StaticList8814 | Mailboxes | ZVI880605@bclabs.local | Email Address | DynamicList9519 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS11726 @DAS12761 @DAS11770 @DAS12999 @DAS11892 @Project_Creation_and_Scope @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyProjectName
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters ' ' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	Then 'CREATE' button is displayed
	When User enters 'AllDevices Project' text to 'Project Name' textbox
	And User clicks 'CREATE' button
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters ' alldevices project' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'A project already exists with this name' text is displayed on inline error banner
	When User create static list with "StaticList4581" name on "Devices" page with following items
	| ItemName       |
	| 0AN6PG99INA7R2 |
	| 0B4UHHUZQBRXKE |
	Then "StaticList4581" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'TestProject84' text to 'Project Name' textbox
	And User selects 'StaticList4581' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "TestProject84" text in the Search field for "Project" column
	Then "TestProject84" text in search field is displayed correctly for "Project" column
	When User selects all rows on the grid
	And User removes selected item
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	And User create dynamic list with "DynamicList5531" name on "Devices" page
	Then "DynamicList5531" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'AllDevices Project1258' text to 'Project Name' textbox
	And User selects 'DynamicList5531' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	And User enters "AllDevices Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13733 @DAS14682 @DAS11565 @Projects @Cleanup
Scenario: EvergreenJnr_ImportProjectPage_CheckThatImportIsSuccessAfterDuplicatesInProjectTasksError
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User clicks 'IMPORT PROJECT' button 
	Then 'Import Task to Request Type relationships' checkbox is displayed
	Then 'Import Mail Templates' checkbox is displayed
	Then 'Import Mail Template to Task Relationships' checkbox is displayed
	When User unchecks 'Import Request Types' checkbox
	Then "Import Mail Template to Task Relationships" checkbox is disabled on the Admin page
	When User clicks 'CANCEL' button 
	When User clicks 'IMPORT PROJECT' button 
	#DAS11565
	When User selects "DAS_13733_Duplicates_in_project_tasks.xml" file to upload on Import Project page
	And User selects 'Import to new project' in the 'Import' dropdown
	When User enters 'TestProjectDAS13733' text to 'Project Name' textbox
	And User checks following checkboxes:
	| CheckboxesToBeClicked |
	| Import Readiness      |
	And User clicks 'IMPORT PROJECT' button
	Then 'This XML file contains duplicates in project tasks' text is displayed on inline error banner
	When User selects "DAS_13733_Valid_file.xml" file to upload on Import Project page
	And User clicks 'IMPORT PROJECT' button 
	Then Page with 'Projects' header is displayed to user
	Then 'The project has been imported' text is displayed on inline success banner
	Then 'click here to view the  TestProjectDAS13733 project' link is displayed on inline success banner