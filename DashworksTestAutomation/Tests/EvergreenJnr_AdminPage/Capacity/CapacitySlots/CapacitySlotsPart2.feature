Feature: CapacitySlotsPart2
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13441 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCapacitySlotClearedWhenObjectTypeIsChangedOnCapacitySlotForm
	When User creates new Slot via Api
	| Project                                           | SlotName             | DisplayName | ObjectType | Tasks                                                                        |
	| User Scheduled Project in Italian & Japanese (Jo) | CapacitySlotDAS13441 | DAS13441    | Device     | Stage 1 \ DDL Task for a Computer‡Stage 1 \ Date Task for a Computer Italian |
	And User navigates to newly created Slot
	Then User sees following tiles selected in the "Tasks" field:
	| Items                                      |
	| Stage 1 \ DDL Task for a Computer          |
	| Stage 1 \ Date Task for a Computer Italian |
	When User selects "User" in the "Object Type" dropdown
	Then User sees following tiles selected in the "Tasks" field:
	| Items                            |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13866 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticularProject
	When User creates new Slot via Api
	| Project                              | SlotName          | DisplayName |
	| Project K-Computer Scheduled Project | CapacitySlot13866 | DAS13866    |
	When User navigates to "Project K-Computer Scheduled Project" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName  |
	| CapacitySlot13866 |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected slot has been deleted" text
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS12921
Scenario: EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacitySlotsDeletionMessages
	When User navigates to "User Evergreen Capacity Project" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| User Slot 1      |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	Then Warning message with "The selected slot will be deleted, do you want to proceed?" text is displayed on the Admin page
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| User Slot 2      |
	And User clicks Delete button 
	Then Warning message with "The selected slots will be deleted, do you want to proceed?" text is displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13835 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsLinkFromUnitGridLeadsToCorrectFilteredPage
	When User navigates to "User Scheduled Project in Italian & Japanese (Jo)" project details
	And User clicks "Capacity" tab
	#prepare data
	And User selects "Capacity Details" tab on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Mode" dropdown
	When User clicks the "UPDATE" Action button
	Then User selects "Capacity Units" option in "Capacity Mode" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User creates new Capacity Unit via api
	| Name            | Description | IsDefault | Project                                           |
	| Capacity Unit 1 |             | false     | User Scheduled Project in Italian & Japanese (Jo) |
	| Capacity Unit 2 |             | false     | User Scheduled Project in Italian & Japanese (Jo) |
	#When User selects "Slots" tab on the Project details page
	And User creates new Slot via Api
	| Project                                           | SlotName | DisplayName | CapacityUnits   | CapacityType    |
	| User Scheduled Project in Italian & Japanese (Jo) | Slot1    | Slot 1      |                 |                 |
	| User Scheduled Project in Italian & Japanese (Jo) | Slot2    | Slot 2      | Capacity Unit 1 |                 |
	| User Scheduled Project in Italian & Japanese (Jo) | Slot3    | Slot 3      | Capacity Unit 2 |                 |
	| User Scheduled Project in Italian & Japanese (Jo) | Slot4    | Slot 4      |                 | Teams and Paths |
	#act1
	When User clicks "Units" tab
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And Rows counter contains "1" found row of all rows
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	#act2
	When User clicks "Capacity" tab
	And User clicks "Units" tab
	And User enters "Capacity Unit 1" text in the Search field for "Capacity Unit" column
	Then "2" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "Capacity Unit 1,All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And Rows counter contains "2" found row of all rows
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	| Slot2 |
	#act3
	When User clicks "Capacity" tab
	And User clicks "Units" tab
	And User enters "Capacity Unit 2" text in the Search field for "Capacity Unit" column
	Then "2" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "Capacity Unit 2,All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And Rows counter contains "2" found row of all rows
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	| Slot3 |
	#remove tests data
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| Slot1           |
	| Slot2           |
	| Slot3           |
	| Slot4           |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected slots have been deleted" text
	When User selects "Units" tab on the Project details page
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName |
	| Capacity Unit 1  |
	| Capacity Unit 2  |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected units have been deleted" text
	When User selects "Capacity Details" tab on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Mode" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text