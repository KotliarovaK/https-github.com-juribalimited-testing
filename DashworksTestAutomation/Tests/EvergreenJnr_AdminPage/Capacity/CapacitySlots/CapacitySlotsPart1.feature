Feature: CapacitySlotsPart1
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13171 @DAS13432 @DAS13430 @DAS13412 @DAS13493 @DAS13375 @DAS13711 @DAS17271 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacity13171 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User clicks on the Unlimited field on the Capacity Slots page
	Then Unlimited text disappears from column
	When User clicks the "CANCEL" Action button
	And User creates new Slot
	| SlotName      | DisplayName | CapacityType   | CapacityUnits      |
	| CapacitySlot1 | DAS13432    | Capacity Units | All Capacity Units |
	Then Success message is displayed and contains "Your capacity slot has been created" text
	Then "All Capacity Units" content is displayed in "Capacity Units" column
	When User creates new Slot
	| SlotName      | DisplayName | CapacityType   |
	| CapacitySlot1 | DAS13432    | Capacity Units |
	Then Error message with "A capacity slot already exists with this name" text is displayed
	When User creates new Slot via Api
	| Project                 | SlotName       | DisplayName |
	| ProjectForCapacity13171 | UniqueNameSlot | DAS13432    |
	And User navigates to newly created Slot
	And User type "NewSlotName" Name in the "Slot Name" field on the Project details page
	And User type "NewDisplayName" Name in the "Display Name" field on the Project details page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	And "NewSlotName" text is displayed in the table content
	When User click on 'Capacity Slot' column header
	Then data in table is sorted by "Capacity Slot" column in ascending order on the Admin page
	When User click on 'Capacity Slot' column header
	Then data in table is sorted by "Capacity Slot" column in descending order on the Admin page
	And There are no errors in the browser console
	When User creates new Slot
	| SlotName      | DisplayName | CapacityType    |
	| CapacitySlot2 | DAS13432    | Teams and Paths |
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter on the Admin page
	Then "No units" is displayed in the dropdown filter for "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13780 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsUnableToCreateMoreThanOneOverrideDateForSameSlotWithSameDate
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13780 | All Devices | None            | Standalone Project |
	When User creates new Slot via Api
	| Project         | SlotName       | DisplayName | SlotAvailableFrom | SlotAvailableTo |
	| ProjectDAS13780 | SlotDAS13780_1 | 13780_1     | 17 Oct 2018       | 18 Oct 2018     |
	| ProjectDAS13780 | SlotDAS13780_2 | 13780_2     | 17 Oct 2018       | 18 Oct 2018     |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User selects "Override Dates" tab on the Project details page
	And User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters "17 Oct 2018" date in the "Override Start Date" field
	And User enters "17 Oct 2018" date in the "Override End Date" field
	And User selects "SlotDAS13780_1" in the "Slot" dropdown
	And User enters "0" value in the "Capacity" field
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters "17 Oct 2018" date in the "Override Start Date" field
	And User enters "17 Oct 2018" date in the "Override End Date" field
	And User selects "SlotDAS13780_2" in the "Slot" dropdown
	And User enters "0" value in the "Capacity" field
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters "17 Oct 2018" date in the "Override Start Date" field
	And User enters "17 Oct 2018" date in the "Override End Date" field
	And User selects "All" in the "Slot" dropdown
	And User clicks the "CREATE" Action button
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
	And User type "CAPACITYSLOTdas13789" Name in the "Slot Name" field on the Project details page
	And User type "das13779SLOT" Name in the "Display Name" field on the Project details page
	And User clicks the "UPDATE" Action button
	Then Error message is not displayed on the Capacity Slots page
	And Success message is displayed and contains "The capacity slot details have been updated" text
	When User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "capacityunitDAS13789" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13789" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
	And User type "CAPACITYUINTdas13789" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "UPDATE" Action button
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
	And User clicks the "UPDATE" Action button
	And User clicks content from "Capacity Slot" column
	Then User sees "" value in the "Slot Available From" date field on Capacity Slot form page
	And User sees "" value in the "Slot Available To" date field on Capacity Slot form page