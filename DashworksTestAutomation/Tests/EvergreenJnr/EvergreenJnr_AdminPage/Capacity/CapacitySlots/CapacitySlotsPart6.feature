Feature: CapacitySlotsPart6
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13792 @DAS13788 @DAS14241 @DAS17419 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatSortingWorkCorrectlyForRequestTypeTeamsCapacityUnitsColumnsOnSlotsPage
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13792 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project            | SlotName | DisplayName | CapacityUnits | CapacityType    |
	| ProjectForDAS13792 | Slot 1   | Slot 1      | Unassigned    |                 |
	| ProjectForDAS13792 | Slot 2   | Slot 2      |               | Teams and Paths |
	| ProjectForDAS13792 | Slot 3   | Slot 3      |               |                 |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User clicks on 'Capacity Units' column header
	Then data in table is sorted by 'Capacity Units' column in ascending order
	When User clicks on 'Capacity Units' column header
	Then data in table is sorted by 'Capacity Units' column in descending order
	And There are no errors in the browser console
	When User clicks on 'Teams' column header
	Then data in table is sorted by 'Teams' column in ascending order
	When User clicks on 'Teams' column header
	Then data in table is sorted by 'Teams' column in descending order
	And There are no errors in the browser console
	When User clicks on 'Paths' column header
	Then data in table is sorted by 'Paths' column in ascending order
	When User clicks on 'Paths' column header
	Then data in table is sorted by 'Paths' column in descending order
	And There are no errors in the browser console
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	Then 'No units,Unassigned' text is displayed in the filter dropdown for the 'Capacity Units' column
	And There are no errors in the browser console
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "Unassigned" checkbox from String Filter on the Admin page
	Then 'All Capacity Units,No units' text is displayed in the filter dropdown for the 'Capacity Units' column
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13811 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatListOfSelectedItemsIsTruncatedForRequestTypeTeamsAndCapacityUnitsColumnOnCapacitySlotsGrid
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User creates new Slot via Api
	| Project                                          | SlotName    | DisplayName | CapacityType    | Paths                                                  | Teams                        | CapacityUnits                              |
	| Windows 7 Migration (Computer Scheduled Project) | DAS_13811_1 | 13811_1     | Teams and Paths | Computer: PC Rebuild‡Computer: Workstation Replacement | Administrative Team‡Admin IT |                                            |
	| Windows 7 Migration (Computer Scheduled Project) | DAS_13811_2 | 13811_2     | Capacity Units  |                                                        |                              | Unassigned‡Capacity Unit 1‡Capacity Unit 2 |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	Then User sees following text in cell truncated with ellipsis:
	| CellText                                                | Column         |
	| Computer: PC Rebuild, Computer: Workstation Replacement | Paths          |
	| Admin IT, Administrative Team                           | Teams          |
	| Capacity Unit 1, Capacity Unit 2, Unassigned            | Capacity Units |
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13526 @DAS17419 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatInSlotsColumnOnCapacityUnitsPageTheCorrectDataIsDisplayed
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13526 | All Devices | None            | Standalone Project |
	And User creates new Capacity Unit via api
	| Name   | Description | IsDefault | Project            |
	| Unit 1 |             | false     | ProjectForDAS13526 |
	| Unit 2 |             | false     | ProjectForDAS13526 |
	And User creates new Slot via Api
	| Project            | SlotName | DisplayName |
	| ProjectForDAS13526 | Slot 1   | Slot 1      |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User navigates to the 'Units' left menu item
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then '1' content is displayed in the 'Slots' column
	When User enters "Unit 1" text in the Search field for "Capacity Unit" column
	Then '1' content is displayed in the 'Slots' column
	When User enters "Unit 2" text in the Search field for "Capacity Unit" column
	Then '1' content is displayed in the 'Slots' column
	When User navigates to the 'Slots' left menu item
	And User creates new Slot
	| SlotName | DisplayName | CapacityUnits |
	| Slot 2   | Slot 2      | Unassigned    |
	And User navigates to the 'Units' left menu item
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then '2' content is displayed in the 'Slots' column
	When User enters "Unit 1" text in the Search field for "Capacity Unit" column
	Then '1' content is displayed in the 'Slots' column
	When User enters "Unit 2" text in the Search field for "Capacity Unit" column
	Then '1' content is displayed in the 'Slots' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13812 @DAS13676 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateButtonIsDisplayedCorrectlyOnTheEditCapacitySlotScreenIfAnAllocatedTaskHasSinceBeenChanged
	When User clicks 'Projects' on the left-hand menu
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
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 1Task13812 | 13812 | Stage13812       | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 2Task13812 | 13812 | Stage13812       | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 3Task13812 | 13812 | Stage13812       | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	When User navigates to "ProjectForDAS13812" project details
	And User creates new Slot via Api
	| Project            | SlotName | DisplayName | Tasks                                                                   |
	| ProjectForDAS13812 | Slot 1   | Slot 1      | Stage13812 \ 1Task13812‡Stage13812 \ 2Task13812‡Stage13812 \ 3Task13812 |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS13812" Project
	And User navigate to "Tasks" tab
	And User navigate to "1Task13812" Task
	And User unpublishes the task
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "ProjectForDAS13812" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User clicks content from "Capacity Slot" column
	And User changes value to "1" for "Tuesday" day column
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'This slot cannot be saved because it is associated to at least 1 unpublished task (Stage13812 \ 1Task13812)' text
	When User clicks 'CANCEL' button 
	And User creates new Slot
	| SlotName | DisplayName | Tasks                                           |
	| Slot 2   | Slot 2      | Stage13812 \ 2Task13812‡Stage13812 \ 3Task13812 |
	And User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS13812" Project
	And User navigate to "Tasks" tab
	And User removes "2Task13812" Task
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to "ProjectForDAS13812" project details
	Then Page with 'ProjectForDAS13812' header is displayed to user
	When User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User enters "Slot 2" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User changes value to "1" for "Tuesday" day column
	Then 'UPDATE' button is not disabled
