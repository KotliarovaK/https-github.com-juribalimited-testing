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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13955 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectlyLanguageIsDisplayedForSlotsAfterChangingOrRemovingLanguage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ChecksLanguage13955" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Details" tab
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "Dutch" language on the Project details page
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "ChecksLanguage" Name in the "Slot Name" field on the Project details page
	And User type "DAS13955" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Capacity" tab
	And User clicks "Details" tab
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	When User clicks "REMOVE" button in the warning message on Admin page
	When User clicks the "ADD LANGUAGE" Action button
	And User selects "German" language on the Project details page
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User enters "ChecksLanguage" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User clicks "See Translations" link on the Capacity Slot page
	Then "German" Language is displayed in Translations table on the Capacity Slot page
	When User clicks "Capacity" tab
	And User clicks "Details" tab
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	When User clicks "REMOVE" button in the warning message on Admin page
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "ChecksLanguage 2" Name in the "Slot Name" field on the Project details page
	And User type "DAS13955" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
	Then "See Translations" link on the Capacity Slot page is not displayed