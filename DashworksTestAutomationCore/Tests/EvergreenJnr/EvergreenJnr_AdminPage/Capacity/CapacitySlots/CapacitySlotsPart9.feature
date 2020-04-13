Feature: CapacitySlotsPart9
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS15878 @DAS15291
Scenario: EvergreenJnr_AdminPage_CheckDragAndDropFunctionalityForSlot
	When User navigates to "2004 Rollout" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User moves "Birmingham Morning" slot to "Manchester Morning" slot
	Then Content in the 'Capacity Slot' column is equal to
	| Content                      |
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
	When User moves "Birmingham Afternoon" slot to "Manchester Morning" slot
	Then Content in the 'Capacity Slot' column is equal to
	| Content                      |
	| Birmingham Morning           |
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
	| London Depot 15:00 - 17:00   |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13671
Scenario: EvergreenJnr_AdminPage_CheckTasksListDisplayingOnCreateAndEditSlotsScreen
	When User navigates to "Email Migration" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User enters "Slot 2018-05-01 - 2019-05-31[Team: 3; RequestType: 458]" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	When User clicks close button for "Pre-Migration \ Scheduled date" chip
	Then 'Tasks' autocomplete have following checkbox options
	| Items                                                     |
	| Migration \ BT/QMM agent switch date                      |
	| Migration \ Migrated date                                 |
	| Post-Migration \ Completed date                           |
	| Pre-Migration \ Forecast date                             |
	| Pre-Migration \ Mailbox Radiobutton RAG Date & Time Owner |
	| Pre-Migration \ Out Of Office End Date                    |
	| Pre-Migration \ Out Of Office Start Date                  |
	| Pre-Migration \ Scheduled date                            |
	| Pre-Migration \ Target date                               |
	When User clicks 'CANCEL' button
	And User clicks 'CREATE SLOT' button
	When User checks 'Shared Mailbox' option after search from 'Paths' autocomplete
	Then 'Tasks' autocomplete have following checkbox options
	| Items                                                     |
	| Migration \ BT/QMM agent switch date                      |
	| Migration \ Migrated date                                 |
	| Post-Migration \ Completed date                           |
	| Pre-Migration \ Forecast date                             |
	| Pre-Migration \ Mailbox Radiobutton RAG Date & Time Owner |
	| Pre-Migration \ Out Of Office End Date                    |
	| Pre-Migration \ Out Of Office Start Date                  |
	| Pre-Migration \ Scheduled date                            |
	| Pre-Migration \ Target date                               |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13671 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckTasksWithoutRequestTypeAlwaysAvailableForSelection
	When User clicks 'Projects' on the left-hand menu
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
	And User navigates to the 'Slots' left menu item
	And User clicks 'CREATE SLOT' button 
	And User enters 'Slot13671' text to 'Slot Name' textbox
	And User enters '13671' text to 'Display Name' textbox
	And User selects 'Teams and Paths' in the 'Capacity Type' dropdown
	And User checks '[Default (Computer)]' option after search from 'Paths' autocomplete
	And User checks 'Stage 1 \ WO Task13671' option after search from 'Tasks' autocomplete
	And User clicks 'CREATE' button 
	Then 'Your capacity slot has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then following chips value displayed in the 'Tasks' textbox
	| ChipValue              |
	| Stage 1 \ WO Task13671 |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13147 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatDisplayOrderIsResetAfterSlotDeletion
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13147 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project            | SlotName | DisplayName | CapacityUnits | CapacityType    |
	| ProjectForDAS13147 | Slot 1   | Slot 1      | Unassigned    |                 |
	| ProjectForDAS13147 | Slot 2   | Slot 2      |               | Teams and Paths |
	| ProjectForDAS13147 | Slot 3   | Slot 3      |               |                 |
	| ProjectForDAS13147 | Slot 4   | Slot 4      |               |                 |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| Slot 3           |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected slot has been deleted' text is displayed on inline success banner
	When User opens 'Capacity Slot' column settings
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Display Order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then User sees following Display order on the Automation page
	| Values |
	| 1      |
	| 2      |
	| 3      |