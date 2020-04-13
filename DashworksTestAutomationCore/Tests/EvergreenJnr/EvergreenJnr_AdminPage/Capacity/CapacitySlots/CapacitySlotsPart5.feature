Feature: CapacitySlotsPart5
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13792 @DAS13788 @DAS14241 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNewSlotAppearsAfterDuplicateActionWithCorrectNameAndSameContent
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13979 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project            | SlotName   | DisplayName | Tasks | CapacityType    | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday |
	| ProjectForDAS13979 | Slot 13979 | 13979       |       | Teams and Paths | 0      | 1       | 2         | 3        | 4      | 5        | 6      |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User clicks 'Duplicate' option in Cog-menu for 'Slot 13979' item from 'Capacity Slot' column
	Then 'Your capacity slot has been created' text is displayed on inline success banner
	Then 'click here to view the  Slot 13979 (copy) slot' link is displayed on inline success banner
	And User sees following duplicates counts for columns:
	| column         | duplicatedValue | duplicateCount |
	| Monday         | 0               | 2              |
	| Tuesday        | 1               | 2              |
	| Wednesday      | 2               | 2              |
	| Thursday       | 3               | 2              |
	| Friday         | 4               | 2              |
	| Saturday       | 5               | 2              |
	| Sunday         | 6               | 2              |
	| Paths          | All Paths       | 2              |
	| Teams          | All Teams       | 2              |
	| Capacity Units |                 | 2              |
	When User clicks 'Duplicate' option in Cog-menu for 'Slot 13979 (copy)' item from 'Capacity Slot' column
	Then 'Your capacity slot has been created' text is displayed on inline success banner
	Then 'click here to view the  Slot 13979 (copy) (copy) slot' link is displayed on inline success banner
	And User sees following duplicates counts for columns:
	| column         | duplicatedValue | duplicateCount |
	| Monday         | 0               | 3              |
	| Tuesday        | 1               | 3              |
	| Wednesday      | 2               | 3              |
	| Thursday       | 3               | 3              |
	| Friday         | 4               | 3              |
	| Saturday       | 5               | 3              |
	| Sunday         | 6               | 3              |
	| Paths          | All Paths       | 3              |
	| Teams          | All Teams       | 3              |
	| Capacity Units |                 | 3              |
	Then Content in the 'Capacity Slot' column is equal to
	| Content                  |
	| Slot 13979               |
	| Slot 13979 (copy)        |
	| Slot 13979 (copy) (copy) |
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName         |
	| Slot 13979 (copy)        |
	| Slot 13979 (copy) (copy) |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected slots have been deleted' text is displayed on inline success banner
	When User clicks refresh button in the browser
	Then Counter shows "1" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS14478 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCopySuffixDisplayingForNames
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS14478 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project            | SlotName   | DisplayName | CapacityType    |
	| ProjectForDAS14478 | Slot 14478 | 14478       | Teams and Paths |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User clicks 'Duplicate' option in Cog-menu for 'Slot 14478' item from 'Capacity Slot' column
	Then 'Your capacity slot has been created' text is displayed on inline success banner
	Then 'click here to view the  Slot 14478 (copy) slot' link is displayed on inline success banner
	When User clicks newly created object link
	Then "Slot 14478 (copy)" content is displayed in "Slot Name" field
	And "14478" content is displayed in "Display Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13980 @DAS13981 @DAS17458
Scenario: EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValueEnteredInSlotMoveToPositionDialog
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User clicks String Filter button for "Paths" column on the Admin page
	When User selects "No Paths" checkbox from String Filter on the Admin page
	When User clicks Reset Filters button on the Admin page
	When User clicks 'Move to position' option in Cog-menu for 'User Slot' item from 'Capacity Slot' column
	And User remembers the Move to position dialog size
	And User enters "1.2" value in Move to position dialog
	Then User checks that Move to position dialog has the same size
	Then 'MOVE' button is disabled on popup
	And Alert message is displayed and contains "Enter integer value between 1 and 32767" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13791 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotIsMovedToLastPositionIfValueEnteredInMoveToPositionIsGreaterThanTotalresocordsNumber
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13791 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project            | SlotName   | DisplayName | CapacityType    |
	| ProjectForDAS13791 | Slot 10001 | 10001       | Teams and Paths |
	| ProjectForDAS13791 | Slot 10002 | 10002       | Teams and Paths |
	| ProjectForDAS13791 | Slot 10003 | 10003       | Teams and Paths |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	Then Content in the 'Capacity Slot' column is equal to
	| Content    |
	| Slot 10001 |
	| Slot 10002 |
	| Slot 10003 |
	When User moves 'Slot 10001' item from 'Capacity Slot' column to the '32767' position
	Then Content in the 'Capacity Slot' column is equal to
	| Content    |
	| Slot 10002 |
	| Slot 10003 |
	| Slot 10001 |
	And There are no errors in the browser console