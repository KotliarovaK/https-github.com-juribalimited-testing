Feature: CapacitySlots
	Runs Capacity Slots related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13824 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatSlotAvailableFromAndSlotAvailableToCanBeClearedOnUpdateCapacitySlotPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForCapacityDAS13824" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "CapacitySlotDAS13824" Name in the "Slot Name" field on the Project details page
	And User type "DAS13824" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	And User enters "29 Oct 2018" value to "Slot Available From" date field on Capacity Slot form page
	And User enters "30 Oct 2018" value to "Slot Available To" date field on Capacity Slot form page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
	And User enters "" value to "Slot Available From" date field on Capacity Slot form page
	And User enters "" value to "Slot Available To" date field on Capacity Slot form page
	And User clicks the "UPDATE" Action button
	And User clicks content from "Capacity Slot" column
	Then User sees "" value in the "Slot Available From" date field on Capacity Slot form page
	And User sees "" value in the "Slot Available To" date field on Capacity Slot form page