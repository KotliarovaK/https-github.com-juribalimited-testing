Feature: CapacitySlotsPart9
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS15878 @DAS15291
Scenario: EvergreenJnr_AdminPage_CheckDragAndDropFunctionalityForSlot
	When User navigates to "1803 Rollout" project details
	And User clicks "Capacity" tab
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
	And User clicks "Capacity" tab
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
	When User clicks "Capacity" tab
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