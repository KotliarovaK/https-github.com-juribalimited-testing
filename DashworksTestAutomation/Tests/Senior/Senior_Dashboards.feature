Feature: Projects_Dashboards
	Runs Projects Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Senior @Dashworks @Senior_Projects @DAS12651
Scenario Outline: Projects_CheckThatDataInGroupWithApostrophesOnDashboardsPageIsDisplayedCorectly
	When User clicks "Projects" on the left-hand menu
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
Scenario: Projects_ChecksThatUserCantRemoveDefaultTeamOnSeniorPage
	When User clicks "Projects" on the left-hand menu
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

@Senior @Dashworks @Projects_Dashworks @Senior_Tasks @DAS14322
Scenario: Projects_ChecksThatAnyTabsCanBeOpenedAfterAddingNewValuesToTask
	When User clicks "Projects" on the left-hand menu
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
	And User creates new Task on Senior
	| Name      | Help      | StagesName  | TaskType | ValueType   | ObjectType | TaskValuesTemplate |
	| for 14322 | for 14322 | Stage 14322 | Normal   | Radiobutton | User       | None               |
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
	When User navigate to "Details" tab
	When User removes the Project


@Senior @DAS14171 @Projects_Dashboards
Scenario: Projects_ChecksThatSeniorProjectHavingCapacitySlotCanBeDeletedWithoutError
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "User Scheduled Test (Jo)" Project
	And User removes the Project
	Then Error message is not displayed
	And There are no errors in the browser console
