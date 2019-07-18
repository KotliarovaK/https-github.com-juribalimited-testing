Feature: CapacitySlotsPart6
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13792 @DAS13788 @DAS14241 @DAS17419 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatSortingWorkCorrectlyForRequestTypeTeamsCapacityUnitsColumnsOnSlotsPage
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13792 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot 3" Name in the "Slot Name" field on the Project details page
	And User type "Slot 3" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User click on 'Capacity Units' column header
	Then data in table is sorted by "Capacity Units" column in ascending order on the Admin page
	When User click on 'Capacity Units' column header
	Then data in table is sorted by "Capacity Units" column in descending order on the Admin page
	And There are no errors in the browser console
	When User click on 'Teams' column header
	Then data in table is sorted by "Teams" column in ascending order on the Admin page
	When User click on 'Teams' column header
	Then data in table is sorted by "Teams" column in descending order on the Admin page
	And There are no errors in the browser console
	When User click on 'Paths' column header
	Then data in table is sorted by "Paths" column in ascending order on the Admin page
	When User click on 'Paths' column header
	Then data in table is sorted by "Paths" column in descending order on the Admin page
	And There are no errors in the browser console
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	Then "No units,Unassigned" is displayed in the dropdown filter for "Capacity Units" column
	And There are no errors in the browser console
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "Unassigned" checkbox from String Filter on the Admin page
	Then "All Capacity Units,No units" is displayed in the dropdown filter for "Capacity Units" column
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13811
Scenario: EvergreenJnr_AdminPage_CheckThatListOfSelectedItemsIsTruncatedForRequestTypeTeamsAndCapacityUnitsColumnOnCapacitySlotsGrid
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "DAS_13811_1" Name in the "Slot Name" field on the Project details page
	And User type "13811_1" Name in the "Display Name" field on the Project details page
	And User selects following items in "Paths" dropdown:
	| items                             |
	| Computer: PC Rebuild              |
	| Computer: Workstation Replacement |
	And User selects following items in "Teams" dropdown:
	| items               |
	| Administrative Team |
	| Admin IT            |
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE SLOT" Action button
	And User type "DAS_13811_2" Name in the "Slot Name" field on the Project details page
	And User type "13811_2" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	And User selects following items in "Capacity Units" dropdown:
	| items           |
	| Unassigned      |
	| Capacity Unit 1 |
	| Capacity Unit 2 |
	And User clicks the "CREATE" Action button
	Then User sees following text in cell truncated with ellipsis:
	| cellText                                               |
	| Computer: PC Rebuild,Computer: Workstation Replacement |
	| Admin IT,Administrative Team                           |
	| Capacity Unit 1,Capacity Unit 2,Unassigned             |
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| DAS_13811_1      |
	| DAS_13811_2      |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13526 @DAS17419 @Delete_Newly_Created_Projec
Scenario: EvergreenJnr_AdminPage_ChecksThatInSlotsColumnOnCapacityUnitsPageTheCorrectDataIsDisplayed
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13526 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "Unit 1" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "Unit 2" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	When User clicks the "CREATE" Action button
	And User selects "Units" tab on the Project details page
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User enters "Unit 1" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User enters "Unit 2" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User selects "Slots" tab on the Project details page
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	When User clicks the "CREATE" Action button
	And User selects "Units" tab on the Project details page
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "2" content is displayed in "Slots" column
	When User enters "Unit 1" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User enters "Unit 2" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13812 @DAS13676 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateButtonIsDisplayedCorrectlyOnTheEditCapacitySlotScreenIfAnAllocatedTaskHasSinceBeenChanged
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName        | ShortName | Description | Type |
	| ProjectForDAS13812 | 13812     |             |      |
	And User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName  |
	| Stage13812 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| 1Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 2Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 3Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	When User navigates to "ProjectForDAS13812" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "Stage13812 \ 1Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "Stage13812 \ 2Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "Stage13812 \ 3Task13812" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS13812" Project
	And User navigate to "Tasks" tab
	And User navigate to "1Task13812" Task
	And User unpublishes the task
	And User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "ProjectForDAS13812" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks content from "Capacity Slot" column
	And User changes value to "1" for "Tuesday" day column
	Then "UPDATE" Action button is disabled
	And "UPDATE" Action button have tooltip with "This slot cannot be saved because it is associated to at least 1 unpublished task (Stage13812 \ 1Task13812)" text
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	And User selects "Stage13812 \ 2Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "Stage13812 \ 3Task13812" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS13812" Project
	And User navigate to "Tasks" tab
	And User removes "2Task13812" Task
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	
	When User navigates to "ProjectForDAS13812" project details
	Then Project "ProjectForDAS13812" is displayed to user
	When User clicks "Capacity" tab
	
	And User selects "Slots" tab on the Project details page
	And User enters "Slot 2" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User changes value to "1" for "Tuesday" day column
	Then "UPDATE" Action button is active
