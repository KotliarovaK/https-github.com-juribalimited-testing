Feature: CapacitySlotsPart1
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13171 @DAS13432 @DAS13430 @DAS13412 @DAS13493 @DAS13375 @DAS13711 @DAS17271 @DAS18918 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacity13171 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User clicks 'CREATE SLOT' button 
	When User clicks on 'Unlimited' textbox
	Then 'Unlimited' textbox is focused
	Then '' content is displayed in 'Unlimited' textbox
	Then "All Capacity Units" content is displayed in "Capacity Units" field
	When User clicks 'CANCEL' button 
	And User creates new Slot
	| SlotName      | DisplayName | CapacityType   |
	| CapacitySlot1 | DAS13432    | Capacity Units |
	Then 'Your capacity slot has been created' text is displayed on inline success banner
	When User clicks following checkboxes from Column Settings panel for the 'Capacity Slot' column:
	| checkboxes |
	| Monday     |
	| Tuesday    |
	Then 'All Capacity Units' content is displayed in the 'Capacity Units' column
	When User clicks 'CREATE SLOT' button
	And User enters 'CapacitySlot1' text to 'Slot Name' textbox
	Then 'A slot already exists with this name' error message is displayed for 'Slot Name' field
	When User clicks 'CANCEL' button 
	When User creates new Slot via Api
	| Project                 | SlotName       | DisplayName |
	| ProjectForCapacity13171 | UniqueNameSlot | DAS13432    |
	And User navigates to newly created Slot
	And User enters 'NewSlotName' text to 'Slot Name' textbox
	Then There are no errors in the browser console
	When User enters 'NewDisplayName' text to 'Display Name' textbox
	Then tooltip is not displayed for 'UPDATE' button
	When User clicks 'UPDATE' button 
	Then 'The capacity slot details have been updated' text is displayed on inline success banner
	And 'NewSlotName' content is displayed in the 'Capacity Slot' column
	When User clicks on 'Capacity Slot' column header
	Then data in table is sorted by 'Capacity Slot' column in ascending order
	When User clicks on 'Capacity Slot' column header
	Then data in table is sorted by 'Capacity Slot' column in descending order
	And There are no errors in the browser console
	When User creates new Slot
	| SlotName      | DisplayName | CapacityType    |
	| CapacitySlot2 | DAS13432    | Teams and Paths |
	Then 'Your capacity slot has been created' text is displayed on inline success banner
	When User clicks following checkboxes from Column Settings panel for the 'Capacity Slot' column:
	| checkboxes |
	| Monday     |
	| Tuesday    |
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter on the Admin page
	Then 'No units' text is displayed in the filter dropdown for the 'Capacity Units' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13780 @Cleanup
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
	Then 'CREATE' button is disabled
	Then 'An override date already exists with this date range' error message is displayed for 'Override Start Date' field
	Then 'An override date already exists with this date range' error message is displayed for 'Override End Date' field
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
	Then 'The capacity slot details have been updated' text is displayed on inline success banner
	When User navigates to the 'Units' left menu item
	And User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	And User enters 'capacityunitDAS13789' text to 'Capacity Unit Name' textbox
	And User enters '13789' text to 'Description' textbox
	And User clicks 'CREATE' button 
	And User clicks newly created object link
	And User enters 'CAPACITYUINTdas13789' text to 'Capacity Unit Name' textbox
	And User clicks 'UPDATE' button
	Then 'The capacity unit details have been updated' text is displayed on inline success banner
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13824 @DAS14250 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotAvailableFromAndSlotAvailableToCanBeClearedOnUpdateCapacitySlotPage
	When Project created via API and opened
	| ProjectName                | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacityDAS13824 | All Devices | None            | Standalone Project |
	When User creates new Slot via Api
	| Project                    | SlotName             | DisplayName | SlotAvailableFrom | SlotAvailableTo |
	| ProjectForCapacityDAS13824 | CapacitySlotDAS13824 | DAS13824    | 29 Oct 2018       | 30 Oct 2018     |
	And User navigates to newly created Slot
	When User clears 'Slot Available From' textbox with backspaces
	When User clears 'Slot Available To' textbox with backspaces
	When User clicks 'UPDATE' button 
	When User clicks content from "Capacity Slot" column
	Then '' content is displayed in 'Slot Available From' textbox
	Then '' content is displayed in 'Slot Available To' textbox

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS19328 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotAvailableFromAndSlotAvailableToCanBeValidated
	When Project created via API and opened
	| ProjectName                | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacityDAS19328 | All Devices | None            | Standalone Project |
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Slots' left menu item
	When User clicks 'CREATE SLOT' button 
	When User enters 'Slot19328' text to 'Slot Name' textbox
	When User enters 'NewSlotName' text to 'Display Name' textbox
	When User enters 'Dec 31, 1899' text to 'Slot Available From' textbox
	Then 'Please enter a valid date' error message is displayed for 'Slot Available From' field
	When User enters 'Jun 7, 2079' text to 'Slot Available To' textbox
	Then 'Please enter a valid date' error message is displayed for 'Slot Available To' field
	When User enters 'Jan 1, 1900' text to 'Slot Available From' textbox
	When User enters 'Jun 6, 2079' text to 'Slot Available To' textbox
	When User clicks 'CREATE' button 
	Then 'Your capacity slot has been created' text is displayed on inline success banner