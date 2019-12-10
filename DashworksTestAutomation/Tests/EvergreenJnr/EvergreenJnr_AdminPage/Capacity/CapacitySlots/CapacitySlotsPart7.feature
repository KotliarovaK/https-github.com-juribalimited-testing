Feature: CapacitySlotsPart7
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13593 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyDateTasksCanBeAvailableForSelectionInCreateSlotPage
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13593 | All Devices | None            | Standalone Project |
	And User clicks 'Projects' on the left-hand menu
	And User navigate to "ProjectDAS13593" Project
	And User navigate to "Stages" tab
	And User clicks "Create Stage" button
	And User create Stage
	| StageName  |
	| Stage13593 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	And User clicks "Create Task" button
	#Please keep Taks creation via UI to verify DAS-15668
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 1Task13593 | 13593 | Stage13593       | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 2Task13593 | 13593 | Stage13593       | Normal         | Date            | Application      |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 3Task13593 | 13593 | Stage13593       | Normal         | Date            | User             |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString        |
	| 4Task13593 | 13593 | Stage13593       | Normal         | DropDownList    | Computer         | Readiness (NNSFC) with due date |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString        |
	| 5Task13593 | 13593 | Stage13593       | Normal         | Radiobutton     | User             | Readiness (NNSFC) with due date |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString        |
	| 6Task13593 | 13593 | Stage13593       | Normal         | DropDownList    | Application      | Readiness (NNSFC) with due date |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 7Task13593 | 13593 | Stage13593       | Normal         | DropDownList    | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 8Task13593 | 13593 | Stage13593       | Normal         | Text            | Application      |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 9Task13593 | 13593 | Stage13593       | Normal         | Radiobutton     | User             |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "ProjectDAS13593" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User clicks 'CREATE SLOT' button 
	And User selects 'Device' in the 'Object Type' dropdown
	And User clicks on "Tasks" dropdown on the Capacity Slots page
	Then following checkbox items are displayed in the dropdown:
	| Items      |
	| 1Task13593 |
	| 4Task13593 |
	When User selects 'User' in the 'Object Type' dropdown
	And User clicks on "Tasks" dropdown on the Capacity Slots page
	Then following checkbox items are displayed in the dropdown:
	| Items      |
	| 3Task13593 |
	| 5Task13593 |
	When User selects 'Application' in the 'Object Type' dropdown
	And User clicks on "Tasks" dropdown on the Capacity Slots page
	Then following checkbox items are displayed in the dropdown:
	| Items      |
	| 2Task13593 |
	| 6Task13593 |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13500 @DAS13636 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots @Do_Not_Run_With_Senior @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatTasksAreUnpublishedAfterBeingAssociatedToACapacitySlot
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User creates new Slot
	| Project                                          | SlotName | DisplayName | Tasks                                                                                                                                              |
	| Windows 7 Migration (Computer Scheduled Project) | Slot 1   | Slot 1      | Pre-Migration \ Scheduled Date‡Pre-Migration \ Forecast Date‡Computer Information ---- Text fill; Text fill; \ Group Computer Rag Radio Date Owner |
	And User clicks content from "Project" column
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	#TODO Remove commented steps. I have saved them just to save data during NotRun removing
	#And User clicks 'CREATE NEW SLOT' button 
	#And User enters 'Slot 1' text to 'Slot Name' textbox
	#And User enters 'Slot 1' text to 'Display Name' textbox
	#And User selects "Pre-Migration \ Scheduled Date" checkbox in the "Tasks" field on the Project details page
	#And User selects "Pre-Migration \ Forecast Date" checkbox in the "Tasks" field on the Project details page
	#And User selects "Computer Information ---- Text fill; Text fill; \ Group Computer Rag Radio Date Owner" checkbox in the "Tasks" field on the Project details page
	#And User clicks 'CREATE' button 
	And User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	And User navigate to "Tasks" tab
	And User navigate to "Forecast Date" Task
	And User unpublishes the task
	And User navigate to "Tasks" tab
	And User navigate to "Group Computer Rag Radio Date Owner" Task
	And User unpublishes the task
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	When User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User enters "Slot 1" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	Then only below options are selected in the '(.*)' autocomplete
	| Value                                                                                 |
	| Pre-Migration \ Forecast Date                                                         |
	| Computer Information ---- Text fill; Text fill; \ Group Computer Rag Radio Date Owner |
	| Pre-Migration \ Scheduled Date                                                        |
	When User clicks 'CANCEL' button 
	And User clicks 'CREATE NEW SLOT' button 
	And User enters 'Slot 2' text to 'Slot Name' textbox
	And User enters 'Slot 2' text to 'Display Name' textbox
	Then Next checkboxes in the "Tasks" dropdown are not available to select:
	| Value                                                                                 |
	| Pre-Migration \ Forecast Date                                                         |
	| Computer Information ---- Text fill; Text fill; \ Group Computer Rag Radio Date Owner |
	And "Pre-Migration \ Scheduled Date" checkbox in the "Tasks" field are available to select
	When User clicks 'CANCEL' button 
	And User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| Slot 1           |
	And User removes selected item
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	And User navigate to "Tasks" tab
	And User navigate to "Forecast Date" Task
	And User publishes the task
	And User navigate to "Tasks" tab
	And User navigate to "Group Computer Rag Radio Date Owner" Task
	And User publishes the task

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13502 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots @Do_Not_Run_With_Senior @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCapacityEnabledFlagUpdatesAfterAddingRemovingTaskFromCapacitySlot
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name      | Help  | StagesNameString                                | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| Task13502 | 13502 | Computer Information ---- Text fill; Text fill; | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User creates new Slot via Api
	| Project                                          | SlotName      | DisplayName    | CapacityType   | Tasks                                                       |
	| Windows 7 Migration (Computer Scheduled Project) | SlotTask13502 | Slot Task13502 | Capacity Units | Computer Information ---- Text fill; Text fill; \ Task13502 |
	And User navigates to newly created Slot
	Then CapacityEnabled flag is equal to "True"
	When User removes "Computer Information ---- Text fill; Text fill; \ Task13502" on the Project details page
	Then "Computer Information ---- Text fill; Text fill; \ Task13502" checkbox in the "Tasks" field are available to select
	When User clicks 'UPDATE' button 
	Then CapacityEnabled flag is equal to "False"

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13500 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots @Do_Not_Run_With_Senior @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatTasksAreDeletedAfterBeingAssociatedToACapacitySlot
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString                                | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 1Task13500 | 13500 | Computer Information ---- Text fill; Text fill; | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString                                | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 2Task13500 | 13500 | Computer Information ---- Text fill; Text fill; | Group          | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User creates new Slot via Api
	| Project                                          | SlotName | DisplayName | CapacityType   | Tasks                                                                                                                                                    |
	| Windows 7 Migration (Computer Scheduled Project) | Slot 1   | Slot 1      | Capacity Units | Computer Information ---- Text fill; Text fill; \ 1Task13500‡Computer Information ---- Text fill; Text fill; \ 2Task13500‡Pre-Migration \ Scheduled Date |
	And User navigates to newly created Slot
	And User clicks 'Admin' on the left-hand menu
	And User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User removes "1Task13500" Task
	And User removes "2Task13500" Task
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User enters "Slot 1" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	Then only below options are selected in the 'Tasks' autocomplete
	| Options                        |
	| Pre-Migration \ Scheduled Date |
	When User clicks 'CANCEL' button 
	And User clicks 'CREATE SLOT' button 
	And User enters 'Slot 2' text to 'Slot Name' textbox
	And User enters 'Slot 2' text to 'Display Name' textbox
	And User selects 'Capacity Units' in the 'Capacity Type' dropdown
	Then Next checkboxes in the "Tasks" dropdown are not available to select:
	| Value                                                        |
	| Computer Information ---- Text fill; Text fill; \ 1Task13500 |
	| Computer Information ---- Text fill; Text fill; \ 2Task13500 |
	And "Pre-Migration \ Scheduled Date" checkbox in the "Tasks" field are available to select