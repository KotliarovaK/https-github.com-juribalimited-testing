Feature: CapacitySlotsPart5
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13792 @DAS13788 @DAS14241 @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatNewSlotAppearsAfterDuplicateActionWithCorrectNameAndSameContent
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13979 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 13979" Name in the "Slot Name" field on the Project details page
	And User type "13979" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User changes value to "0" for "Monday" day column
	And User changes value to "1" for "Tuesday" day column
	And User changes value to "2" for "Wednesday" day column
	And User changes value to "3" for "Thursday" day column
	And User changes value to "4" for "Friday" day column
	And User changes value to "5" for "Saturday" day column
	And User changes value to "6" for "Sunday" day column
	And User clicks the "CREATE" Action button
	And User opens settings for "Slot 13979" row
	And User selects "Duplicate" option from settings menu
	Then Success message is displayed and contains "Your capacity slot has been created, click here to view the Slot 13979 (copy) slot" text
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
	When User opens settings for "Slot 13979 (copy)" row
	And User selects "Duplicate" option from settings menu
	Then Success message is displayed and contains "Your capacity slot has been created, click here to view the Slot 13979 (copy) (copy) slot" text
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
	And User sees next Slots on the Capacity Slots page:
	| slots                    |
	| Slot 13979               |
	| Slot 13979 (copy)        |
	| Slot 13979 (copy) (copy) |
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName         |
	| Slot 13979 (copy)        |
	| Slot 13979 (copy) (copy) |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected slots have been deleted" text
	When User clicks refresh button in the browser
	Then Counter shows "1" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS14478 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCopySuffixDisplayingForNames
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS14478 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 14478" Name in the "Slot Name" field on the Project details page
	And User type "14478" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User opens settings for "Slot 14478" row
	And User selects "Duplicate" option from settings menu
	Then Success message is displayed and contains "Your capacity slot has been created, click here to view the Slot 14478 (copy) slot" text
	When User clicks newly created object link
	Then "Slot 14478 (copy)" content is displayed in "Slot Name" field
	And "14478" content is displayed in "Display Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13980 @DAS13981 @DAS17458
Scenario: EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValueEnteredInSlotMoveToPositionDialog
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	#DAS-17458 Uncomment after DAS-17458 fixed
	#And User clicks String Filter button for "Paths" column on the Admin page
	#When User selects "No Paths" checkbox from String Filter on the Admin page
	#When User clicks Reset Filters button on the Admin page
	#DAS-17458
	And User opens settings for "User Slot" row
	And User selects "Move to position" option from settings menu
	And User remembers the Move to position dialog size
	And User enters "1.2" value in Move to position dialog
	Then User checks that Move to position dialog has the same size
	And Button "Move" in Move to position dialog is displayed disabled
	And Alert message is displayed and contains "Enter integer value between 1 and 32767" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13791 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotIsMovedToLastPositionIfValueEnteredInMoveToPositionIsGreaterThanTotalresocordsNumber
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13791 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 10001" Name in the "Slot Name" field on the Project details page
	And User type "10001" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 10002" Name in the "Slot Name" field on the Project details page
	And User type "10002" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 10003" Name in the "Slot Name" field on the Project details page
	And User type "10003" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then User sees next Slots on the Capacity Slots page:
	| slots      |
	| Slot 10001 |
	| Slot 10002 |
	| Slot 10003 |
	When User move "Slot 10001" item to "32767" position on Admin page
	Then User sees next Slots on the Capacity Slots page:
	| slots      |
	| Slot 10002 |
	| Slot 10003 |
	| Slot 10001 |
	And There are no errors in the browser console
