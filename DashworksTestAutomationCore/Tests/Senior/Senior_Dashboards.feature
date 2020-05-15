Feature: Projects_Dashboards
	Runs Projects Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Senior @Dashworks @Senior_Projects @DAS12651
Scenario Outline: Senior_CheckThatDataInGroupWithApostrophesOnDashboardsPageIsDisplayedCorectly
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigates to the "<PageName>" page on Dashboards tab
	Then "<PageName>" page is displayed to the user
	When User select "Barry's User Project" Project on toolbar
	When User navigate to "Barry's Pilot Group 1" group
	Then content for the "Barry's Pilot Group 1" group is displayed correctly

Examples:
	| PageName           |
	| User Dashboard     |
	| Computer Dashboard |

@Senior @Dashworks @Projects_Dashworks @Senior_Teams @DAS13000
Scenario: Senior_ChecksThatUserCantRemoveDefaultTeamOnSeniorPage
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Computer Scheduled Test (Jo)" Project
	And User navigate to "Teams" tab
	Then "My Team" Team have a default value 
	When User navigates to "My Team" Team
	And User navigate to "Details" page
	Then Default Team checkbox is checked and cannot be unchecked
	When User clicks "Cancel" button
	And User navigates to "Admin IT" Team
	And User navigate to "Details" page
	And User makes selected Team by default
	And User clicks "Update" button
	Then information message is displayed with "Team was successfully updated." text
	And Default Team checkbox is checked and cannot be unchecked
	When User clicks "Cancel" button
	And User navigates to "My Team" Team
	And User navigate to "Details" page
	And User makes selected Team by default
	And User clicks "Update" button
	Then information message is displayed with "Team was successfully updated." text
	And Default Team checkbox is checked and cannot be unchecked

@Senior @Dashworks @Projects_Dashworks @Senior_Projects @Senior_Tasks @DAS14322 @Cleanup
Scenario: Senior_ChecksThatAnyTabsCanBeOpenedAfterAddingNewValuesToTask
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName        | ShortName | Description | Type |
	| ProjectForDAS14322 | 14322     |             |      |
	And User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| Stage 14322 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name      | Help      | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| for 14322 | for 14322 | Stage 14322      | Normal         | Radiobutton     | User             | None                     |
	Then Success message is displayed with "Task successfully created" text
	When User navigate to "Values" page
	And User clicks "Add value" button
	When User create new Value
	| Name          | TaskStatusString | DefaultValue |
	| TestValueName | Open             | false        |
	And User clicks "Save Value" button
	When User navigate to "Details" page
	Then "Edit Task" page is displayed to the user
	And There are no errors in the browser console
	When User navigate to "Request Types" page
	Then "Edit Task" page is displayed to the user
	And There are no errors in the browser console

#4/24/20 AnnI: upd this test!!! You cannot delete a project!
@Senior @Projects_Dashboards @Senior_Projects @DAS14171 @Cleanup
Scenario: Senior_Projects_ChecksThatSeniorProjectHavingCapacitySlotCanBeDeletedWithoutError
	When User creates new Project on Senior
	| ProjectName      | ShortName | Description | Type |
	| Project_DAS14171 | DAS14171  |             |      |
	When User creates new Capacity Unit via api
	| Name          | Description | IsDefault | Project          |
	| DAS14171_CU_1 | DAS14171    | false     | Project_DAS14171 |
	| DAS14171_CU_2 | DAS14171    | false     | Project_DAS14171 |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Project_DAS14171" Project
	And User removes the Project
	Then Error message is not displayed
	And There are no errors in the browser console

@Senior @Projects_Dashboards @Senior_Tasks @DAS13887
Scenario: Senior_TasksPage_ChecksThatTasksObjectTypeDropBoxValuesNotDuplicatedAfterRechosingValueType
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User selects "Date" as Task Value Type
	Then Next items are displayed as options of Object Type property:
	| Items       |
	| [Select]    |
	| User        |
	| Computer    |
	| Application |
	When User selects "Text" as Task Value Type
	Then Next items are displayed as options of Object Type property:
	| Items       |
	| [Select]    |
	| User        |
	| Computer    |
	| Application |

@Senior @Projects_Dashboards @Senior_Tasks @DAS18247 @Cleanup
Scenario: Senior_TasksPage_ChecksThatSpecialSymbolsCanBeUsedInTaskName
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| ProjectForTask18247 | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForTask18247" Project
	Then Project with "ProjectForTask18247" name is displayed correctly
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName  |
	| Stage18247 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name          | Help          | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| Task“'<>13152 | Help“'<>13152 | Stage18247       | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User clicks property icon on task details page
	Then Task name displayed as 'Task“'<>13152' on Task details page