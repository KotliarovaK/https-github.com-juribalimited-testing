Feature: CapacitySlotsPart9
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS15878 @DAS15291
Scenario: EvergreenJnr_AdminPage_CheckDragAndDropFunctionalityForSlot
	When User navigates to "1803 Rollout" project details
	And User navigates to the 'Capacity' left menu item
	And User selects "Slots" tab on the Project details page
	When User moves "Birmingham Morning" slot to "London Depot 15:00 - 17:00" slot
	Then "Capacity Slot" column content is displayed in the following order:
	| Items                        |
	| Birmingham Afternoon         |
	| Manchester Morning           |
	| Manchester Afternoon         |
	| London - City Morning        |
	| London - City Afternoon      |
	| London - Southbank Morning   |
	| London - Southbank Afternoon |
	| London Depot 09:00 - 11:00   |
	| London Depot 11:00 - 13:00   |
	| London Depot 13:00 - 15:00   |
	| Birmingham Morning           |
	| London Depot 15:00 - 17:00   |
	When User moves "Birmingham Morning" slot to "Birmingham Afternoon" slot
	Then "Capacity Slot" column content is displayed in the following order:
	| Items                        |
	| Birmingham Afternoon         |
	| Birmingham Morning           |
	| Manchester Morning           |
	| Manchester Afternoon         |
	| London - City Morning        |
	| London - City Afternoon      |
	| London - Southbank Morning   |
	| London - Southbank Afternoon |
	| London Depot 09:00 - 11:00   |
	| London Depot 11:00 - 13:00   |
	| London Depot 13:00 - 15:00   |
	| London Depot 15:00 - 17:00   |

@Evergreen @Admin @EvergreenJnr_AdminPage @DAS13671
Scenario: EvergreenJnr_AdminPage_CheckTasksListDisplayingOnCreateAndEditSlotsScreen
	When User navigates to "I-Computer Scheduled Project" project details
	And User navigates to the 'Capacity' left menu item
	And User selects "Slots" tab on the Project details page
	And User enters "Scheduled/Targeted" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User clicks on "Tasks" dropdown on the Capacity Slots page
	Then Tasks are displayed in the following order on Action panel:
	| Items                   |
	| i-stage A \ i-Completed |
	| i-stage A \ i-comp-radb |
	| i-stage A \ i-Forecast  |
	| i-stage A \ i-Migrated  |
	| i-stage A \ i-Schedule  |
	| i-stage A \ i-Targeted  |
	When User navigates to the 'Capacity' left menu item
	When User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User selects following items in "Paths" dropdown:
	| items                             |
	| req type comp              |
	And User clicks on "Tasks" dropdown on the Capacity Slots page
	Then Tasks are displayed in the following order on Action panel:
	| Items                   |
	| i-stage A \ i-Completed |
	| i-stage A \ i-comp-radb |
	| i-stage A \ i-Forecast  |
	| i-stage A \ i-Migrated  |
	| i-stage A \ i-Schedule  |
	| i-stage A \ i-Targeted  |

@Evergreen @Admin @EvergreenJnr_AdminPage @DAS13671 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckTasksWithoutRequestTypeAlwaysAvailableForSelection
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Devices Evergreen Capacity Project" Project
	Then Project with "Devices Evergreen Capacity Project" name is displayed correctly
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates Task
	| Name         | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| WO Task13671 | 13671 | Stage 1          | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	When User navigates to "Devices Evergreen Capacity Project" project details
	And User navigates to the 'Capacity' left menu item
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot13671" Name in the "Slot Name" field on the Project details page
	And User type "13671" Name in the "Display Name" field on the Project details page
	And User selects 'Teams and Paths' in the 'Capacity Type' dropdown
	And User selects "[Default (Computer)]" checkbox in the "Paths" field on the Project details page
	And User selects "Stage 1 \ WO Task13671" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks newly created object link
	Then 'Stage 1 \ WO Task13671' value is displayed in the 'Tasks' dropdown