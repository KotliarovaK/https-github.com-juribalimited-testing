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
	When User selects 'User' in the 'Object Type' dropdown
	Then User sees following tiles selected in the "Tasks" field:
	| Items                            |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13866 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticularProject
	When User creates new Slot via Api
	| Project                               | SlotName          | DisplayName |
	| *Project K-Computer Scheduled Project | CapacitySlot13866 | DAS13866    |
	When User navigates to "*Project K-Computer Scheduled Project" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName  |
	| CapacitySlot13866 |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected slot has been deleted' text is displayed on inline success banner
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS12921
Scenario: EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacitySlotsDeletionMessages
	When User navigates to "User Evergreen Capacity Project" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| User Slot 1      |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then 'The selected slot will be deleted, do you want to proceed?' text is displayed on inline tip banner
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| User Slot 2      |
	And User clicks 'DELETE' button 
	Then 'The selected slots will be deleted, do you want to proceed?' text is displayed on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13835 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsLinkFromUnitGridLeadsToCorrectFilteredPage
	#prepare data
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| TestName13835 | All Mailboxes | None            | Standalone Project |
	And User creates new Capacity Unit via api
	| Name            | Description | IsDefault | Project       |
	| Capacity Unit 1 |             | false     | TestName13835 |
	| Capacity Unit 2 |             | false     | TestName13835 |
	And User creates new Slot via Api
	| Project       | SlotName | DisplayName | CapacityUnits   | CapacityType    |
	| TestName13835 | Slot1    | Slot 1      |                 |                 |
	| TestName13835 | Slot2    | Slot 2      | Capacity Unit 1 |                 |
	| TestName13835 | Slot3    | Slot 3      | Capacity Unit 2 |                 |
	| TestName13835 | Slot4    | Slot 4      |                 | Teams and Paths |
	#act1
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then '1' content is displayed in the 'Slots' column
	When User clicks content from "Slots" column
	Then 'All Capacity Units' text is displayed in the filter dropdown for the 'Capacity Units' column
	And Rows counter contains "1" found row of all rows
	Then Content in the 'Capacity Slot' column is equal to
	| Content |
	| Slot1   |
	#act2
	When User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User enters "Capacity Unit 1" text in the Search field for "Capacity Unit" column
	Then '2' content is displayed in the 'Slots' column
	When User clicks content from "Slots" column
	Then 'Capacity Unit 1,All Capacity Units' text is displayed in the filter dropdown for the 'Capacity Units' column
	And Rows counter contains "2" found row of all rows
	Then Content in the 'Capacity Slot' column is equal to
	| Content |
	| Slot1   |
	| Slot2   |
	#act3
	When User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User enters "Capacity Unit 2" text in the Search field for "Capacity Unit" column
	Then '2' content is displayed in the 'Slots' column
	When User clicks content from "Slots" column
	Then 'Capacity Unit 2,All Capacity Units' text is displayed in the filter dropdown for the 'Capacity Units' column
	And Rows counter contains "2" found row of all rows
	Then Content in the 'Capacity Slot' column is equal to
	| Content |
	| Slot1   |
	| Slot3   |