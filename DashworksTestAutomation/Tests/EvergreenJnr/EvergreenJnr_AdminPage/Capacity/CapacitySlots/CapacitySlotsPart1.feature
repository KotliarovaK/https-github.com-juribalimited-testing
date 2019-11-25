﻿Feature: CapacitySlotsPart1
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13171 @DAS13432 @DAS13430 @DAS13412 @DAS13493 @DAS13375 @DAS13711 @DAS17271 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacity13171 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User clicks 'CREATE SLOT' button 
	And User clicks on the Unlimited field on the Capacity Slots page
	Then Unlimited text disappears from column
	Then "All Capacity Units" content is displayed in "Capacity Units" field
	When User clicks 'CANCEL' button 
	And User creates new Slot
	| SlotName      | DisplayName | CapacityType   |
	| CapacitySlot1 | DAS13432    | Capacity Units |
	Then Success message is displayed and contains "Your capacity slot has been created" text
	Then 'All Capacity Units' content is displayed in the 'Capacity Units' column
	When User creates new Slot
	| SlotName      | DisplayName | CapacityType   |
	| CapacitySlot1 | DAS13432    | Capacity Units |
	Then Error message with "A capacity slot already exists with this name" text is displayed
	When User creates new Slot via Api
	| Project                 | SlotName       | DisplayName |
	| ProjectForCapacity13171 | UniqueNameSlot | DAS13432    |
	And User navigates to newly created Slot
	And User enters 'NewSlotName' text to 'Slot Name' textbox
	And User enters 'NewDisplayName' text to 'Display Name' textbox
	Then tooltip is not displayed for 'UPDATE' button
	When User clicks 'UPDATE' button 
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	And 'NewSlotName' content is displayed in the 'Capacity Slot' column
	When User clicks on 'Capacity Slot' column header
	Then data in table is sorted by "Capacity Slot" column in ascending order on the Admin page
	When User clicks on 'Capacity Slot' column header
	Then data in table is sorted by "Capacity Slot" column in descending order on the Admin page
	And There are no errors in the browser console
	When User creates new Slot
	| SlotName      | DisplayName | CapacityType    |
	| CapacitySlot2 | DAS13432    | Teams and Paths |
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter on the Admin page
	Then 'No units' text is displayed in the filter dropdown for the 'Capacity Units' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS18894 @DAS13780 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsUnableToCreateMoreThanOneOverrideDateForSameSlotWithSameDate
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13780 | All Devices | None            | Standalone Project |
	When User creates new Slot via Api
	| Project         | SlotName       | DisplayName | SlotAvailableFrom | SlotAvailableTo |
	| ProjectDAS13780 | SlotDAS13780_1 | 13780_1     | 17 Oct 2018       | 18 Oct 2018     |
	| ProjectDAS13780 | SlotDAS13780_2 | 13780_2     | 17 Oct 2018       | 18 Oct 2018     |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User navigates to the 'Override Dates' left menu item
	And User clicks 'CREATE OVERRIDE DATE' button 
	And User enters '17 Oct 2018' text to 'Override Start Date' datepicker
	And User enters '17 Oct 2018' text to 'Override End Date' datepicker
	And User selects 'SlotDAS13780_1' in the 'Slot' dropdown
	And User enters '0' text to 'Capacity' textbox
	And User clicks 'CREATE' button 
	And User clicks 'CREATE OVERRIDE DATE' button 
	And User enters '17 Oct 2018' text to 'Override Start Date' datepicker
	And User enters '17 Oct 2018' text to 'Override End Date' datepicker
	And User selects 'SlotDAS13780_2' in the 'Slot' dropdown
	And User enters '0' text to 'Capacity' textbox
	And User clicks 'CREATE' button 
	And User clicks 'CREATE OVERRIDE DATE' button 
	And User enters '17 Oct 2018' text to 'Override Start Date' datepicker
	And User enters '17 Oct 2018' text to 'Override End Date' datepicker
	And User selects 'All' in the 'Slot' dropdown
	And User clicks 'CREATE' button 
	Then Error message with "An override already exists for this date" text is displayed
	And "2" rows label displays in Action panel
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Units @DAS13789 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateCapacityUnitOrSlotUsingTheSameNameWithDifferentCase
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13789 | All Devices | None            | Standalone Project |
	When User creates new Slot via Api
	| Project         | SlotName             | DisplayName  | SlotAvailableFrom | SlotAvailableTo |
	| ProjectDAS13789 | capacityslotDAS13789 | DAS13779slot | 28 Oct 2018       | 29 Oct 2018     |
	And User navigates to newly created Slot
	And User enters 'CAPACITYSLOTdas13789' text to 'Slot Name' textbox
	And User enters 'das13779SLOT' text to 'Display Name' textbox
	And User clicks 'UPDATE' button 
	Then Error message is not displayed on the Capacity Slots page
	And Success message is displayed and contains "The capacity slot details have been updated" text
	When User navigates to the 'Units' left menu item
	And User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	And User enters 'capacityunitDAS13789' text to 'Capacity Unit Name' textbox
	And User enters '13789' text to 'Description' textbox
	And User clicks 'CREATE' button 
	And User clicks newly created object link
	And User enters 'CAPACITYUINTdas13789' text to 'Capacity Unit Name' textbox
	And User clicks 'UPDATE' button 
	Then Error message is not displayed on the Capacity Slots page
	And Success message is displayed and contains "The capacity unit details have been updated" text
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13824 @DAS14250 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotAvailableFromAndSlotAvailableToCanBeClearedOnUpdateCapacitySlotPage
	When Project created via API and opened
	| ProjectName                | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacityDAS13824 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project                    | SlotName             | DisplayName | SlotAvailableFrom | SlotAvailableTo |
	| ProjectForCapacityDAS13824 | CapacitySlotDAS13824 | DAS13824    | 29 Oct 2018       | 30 Oct 2018     |
	And User navigates to newly created Slot
	And User enters "" value to "Slot Available From" date field on Capacity Slot form page
	And User enters "" value to "Slot Available To" date field on Capacity Slot form page
	And User clicks 'UPDATE' button 
	And User clicks content from "Capacity Slot" column
	Then User sees "" value in the "Slot Available From" date field on Capacity Slot form page
	And User sees "" value in the "Slot Available To" date field on Capacity Slot form page