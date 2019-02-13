﻿Feature: Capacity
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13720 @DAS13431 @DAS13162 @DAS14037 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13720" in the "Project Name" field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13720" is displayed to user
	When User clicks "Capacity" tab
	Then "Capacity Units" text value is displayed in the "Capacity Mode" dropdown
	When User selects "Units" tab on the Project details page
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then Counter shows "1" found rows
	When User clicks content from "Capacity Unit" column
	And User changes Name to "Default Capacity Unit" in the "Capacity Unit Name" field on the Project details page 
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	And Columns on Admin page is displayed in following order:
	| ColumnName    |
	|               |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Devices       |
	| Users         |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13431 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnits
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "13431DevicesProject" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "13431DevicesProject" is displayed to user
	When User clicks "Capacity" tab
	When User selects "Units" tab on the Project details page
	Then Columns on Admin page is displayed in following order:
	| ColumnName    |
	|               |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Devices       |
	| Users         |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13431 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckDefaultColumnsForMailboxesProjectCapacityUnits
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "13431MailboxesProject" in the "Project Name" field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "13431MailboxesProject" is displayed to user
	When User clicks "Capacity" tab
	When User selects "Units" tab on the Project details page
	Then Columns on Admin page is displayed in following order:
	| ColumnName    |
	|               |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Users         |
	| Mailboxes     |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @Projects @DAS13723 @DAS13370 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumn
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13723" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13723" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Override Dates" tab on the Project details page
	When User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters "5 Jan 2019" date in the "Override Start Date" field
	And User enters "" date in the "Override End Date" field
	Then Filling field error with "An override end date must be entered" text is displayed
	When User enters "4 Oct 2018" date in the "Override End Date" field
	Then "CREATE" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some settings are not valid" text
	When User enters "" date in the "Override Start Date" field
	Then Filling field error with "An override start date must be entered" text is displayed
	When User enters "4 Oct 2018" date in the "Override Start Date" field
	And User enters "7 Oct 2018" date in the "Override End Date" field
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your override date has been created" text
	And "Unlimited" content is displayed in "Capacity" column
	When User enters ">1" text in the Search field for "Capacity" column
	Then Counter shows "1" found rows
	When User clicks content from "Start Date" column
	And User enters "3 Oct 2018" date in the "Override End Date" field
	Then "UPDATE" Action button is disabled
	Then "UPDATE" Action button have tooltip with "Some settings are not valid" text
	When User enters "" date in the "Override Start Date" field
	And User enters "" date in the "Override End Date" field
	Then Filling field error with "An override start date must be entered" text is displayed
	And Filling field error with "An override end date must be entered" text is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13171 @DAS13432 @DAS13430 @DAS13412 @DAS13493 @DAS13375 @DAS13711 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13171" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13171" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User clicks on the Unlimited field on the Capacity Slots page
	Then Unlimited text disappears from column
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "CapacitySlot1" Name in the "Slot Name" field on the Project details page
	And User type "DAS13432" Name in the "Display Name" field on the Project details page
	When User selects "Capacity Units" in the "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	Then "All Capacity Units" content is displayed in "Capacity Units" column
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "CapacitySlot1" Name in the "Slot Name" field on the Project details page
	And User type "DAS13432" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity slot already exists with this name" text is displayed
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "UniqueNameSlot" Name in the "Slot Name" field on the Project details page
	And User type "DAS13432" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks newly created object link
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
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "CapacitySlot2" Name in the "Slot Name" field on the Project details page
	And User type "DAS13432" Name in the "Display Name" field on the Project details page
	When User selects "Teams and Request Types" in the "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter on the Admin page
	Then "No units" is displayed in the dropdown filter for "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @Projects @DAS13790 @DAS13528 @DAS13165 @DAS13164 @DAS13154 @DAS14037 @DAS14236 @DAS13157 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectLinkIsDisplayedInTheGreenBannerForCreatedUnit
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13790" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13790" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit13790" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13720" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit13790 capacity unit" link
	When User enters "13720" text in the Search field for "Description" column
	Then Counter shows "1" found rows
	When User clicks newly created object link
	Then URL contains "evergreen/#/admin/project/"
	When User updates the "Default unit" checkbox state
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	#Remove # after DAS-14037 fixed
	#Then Success message is displayed correctly
	When User enters "13720" text in the Search field for "Description" column
	And User click content from "Capacity Unit" column
	Then "Default unit" checkbox is checked and cannot be unchecked
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " CapacityUnit13790 " Name in the "Capacity Unit Name" field on the Project details page
	And User type "DAS13528" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity unit already exists with this name" text is displayed
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit2" Name in the "Capacity Unit Name" field on the Project details page
	And User type "DAS13528" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User selects "Details" tab on the Project details page
	And User selects "Clone evergreen capacity units to project capacity units" in the "Capacity Units" dropdown
	And User clicks the "UPDATE" Action button
	#Remove # after DAS-14037 fixed
	#Then Success message is displayed correctly
	Then Success message is displayed and contains "The project capacity details have been updated" text
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @Projects @DAS12672 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatOneDefaultCapacityUnitCanBeCreated
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForCapacity12672" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	Then Project "ProjectForCapacity12672" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	Then User sees next Units on the Capacity Units page:
	| units             |
	| Unassigned        |
	And "TRUE" content is displayed in "Default" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName |
	| Unassigned       |
	And User clicks on Actions button
	And User clicks Delete button in Actions
	And User clicks Delete button
	Then Warning message with "You cannot delete the default unit" text is displayed on the Admin page
	When User close message on the Admin page
	Then "Unassigned" text is displayed in the table content
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit12672" Name in the "Capacity Unit Name" field on the Project details page
	And User type "12672" Name in the "Description" field on the Project details page
	And User updates the "Default unit" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit12672 capacity unit" link
	When User clicks newly created object link
	Then URL contains "capacity/units/unit/"
	And "Default unit" checkbox is checked and cannot be unchecked
	# commented until DAS-13151
	# And "UPDATE" Action button is disabled 
	# And "CANCEL" Action button is disabled
	When User selects "Units" tab on the Project details page
	And User enters "CapacityUnit12672" text in the Search field for "Capacity Unit" column
	Then "TRUE" content is displayed in "Default" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "FALSE" content is displayed in "Default" column
	When User clicks content from "Capacity Unit" column
	And User updates the "Default unit" checkbox state
	And User clicks the "UPDATE" Action button
	And User selects "Units" tab on the Project details page
	And User enters "CapacityUnit12672" text in the Search field for "Capacity Unit" column
	Then "FALSE" content is displayed in "Default" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "TRUE" content is displayed in "Default" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14240
Scenario: EvergreenJnr_AdminPage_CheckThatCapacityUnitsGridUpdatedAfterUnitUpdatingOrCreation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	And User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit14240" Name in the "Capacity Unit Name" field on the Project details page
	And User type "14240" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And User sees next Units on the Capacity Units page:
	| units             |
	| Unassigned        |
	| CapacityUnit14240 |
	When User enters "CapacityUnit14240" text in the Search field for "Capacity Unit" column
	And User click content from "Capacity Unit" column
	And User type "CapacityUnit14240NameUpdated" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	And User sees next Units on the Capacity Units page:
	| units                        |
	| Unassigned                   |
	| CapacityUnit14240NameUpdated |
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName  |
	| CapacityUnit14240NameUpdated |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected unit has been deleted" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @Projects @DAS13780 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsUnableToCreateMoreThanOneOverrideDateForSameSlotWithSameDate
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectDAS13780" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "SlotDAS13780_1" Name in the "Slot Name" field on the Project details page
	And User type "13780_1" Name in the "Display Name" field on the Project details page
	And User enters "17 Oct 2018" value to "Slot Available From" date field on Capacity Slot form page
	And User enters "18 Oct 2018" value to "Slot Available To" date field on Capacity Slot form page
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "SlotDAS13780_2" Name in the "Slot Name" field on the Project details page
	And User type "13780_2" Name in the "Display Name" field on the Project details page
	And User enters "17 Oct 2018" value to "Slot Available From" date field on Capacity Slot form page
	And User enters "18 Oct 2018" value to "Slot Available To" date field on Capacity Slot form page
	And User clicks the "CREATE" Action button
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Units @Projects @DAS13789 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateCapacityUnitOrSlotUsingTheSameNameWithDifferentCase
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectDAS13789" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "capacityslotDAS13789" Name in the "Slot Name" field on the Project details page
	And User type "DAS13779slot" Name in the "Display Name" field on the Project details page
	And User enters "28 Oct 2018" value to "Slot Available From" date field on Capacity Slot form page
	And User enters "29 Oct 2018" value to "Slot Available To" date field on Capacity Slot form page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @Projects @DAS13945 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitWithEmptyName
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13945" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " " Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945" Name in the "Description" field on the Project details page
	Then Create Capacity Unit button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @Projects @DAS13166 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDifferentProject
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13945" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	#next capacity name used in "1803 Rollout" project
	And User type "Manchester" Name in the "Capacity Unit Name" field on the Project details page 
	And User type "Manchester Operations" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Counter shows "2" found rows
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13945 @DAS12672 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpace
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13945" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " test1" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message is not displayed on the Capacity Units page
	And User sees next Units on the Capacity Units page:
	| units      |
	| Unassigned |
	| test1      |
	When User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " test1" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945_2" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity unit already exists with this name" text is displayed
	And User sees next Units on the Capacity Units page:
	| units      |
	| Unassigned |
	| test1      |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13824 @DAS14250 @Delete_Newly_Created_Project
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13441
Scenario: EvergreenJnr_AdminPage_CheckThatCapacitySlotClearedWhenObjectTypeIsChangedOnCapacitySlotForm
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "User Scheduled Project in Italian & Japanese (Jo)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "CapacitySlotDAS13441" Name in the "Slot Name" field on the Project details page
	And User type "DAS13441" Name in the "Display Name" field on the Project details page
	And User selects "Device" in the "Object Type" dropdown
	And User selects next items in the "Tasks" dropdown:
	| Items                            |
	| DDL Task for a Computer          |
	| Date Task for a Computer Italian |
	And User clicks on "Request Types" dropdown on the Capacity Slots page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
	Then User sees following tiles selected in the "Tasks" field:
	| Items                            |
	| DDL Task for a Computer          |
	| Date Task for a Computer Italian |
	When User selects "User" in the "Object Type" dropdown
	Then User sees following tiles selected in the "Tasks" field:
	| Items                            |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13866
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticularProject
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Project K-Computer Scheduled Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "CapacitySlot13866" Name in the "Slot Name" field on the Project details page
	And User type "DAS13866" Name in the "Display Name" field on the Project details page
	When User clicks the "CREATE" Action button
	Then Success message with "Your capacity slot has been created" text is displayed on the Projects page
	#Remove refresh after fixed
	When User clicks refresh button in the browser
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName  |
	| CapacitySlot13866 |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected slot has been deleted" text
	Then There are no errors in the browser console
	#When User selects "Units" tab on the Project details page
	#And User selects "Slots" tab on the Project details page
	#Then "No slots found" message is displayed on the Admin Page

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS12921
Scenario: EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInCapacitySlotsDeletionMessages
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "User Evergreen Capacity Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13835
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsLinkFromUnitGridLeadsToCorrectFilteredPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "User Scheduled Project in Italian & Japanese (Jo)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	#prepare data
	And User selects "Details" tab on the Project details page
	Then User selects "Capacity Units" option in "Capacity Mode" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User selects "Units" tab on the Project details page
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "Capacity Unit 1" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "Capacity Unit 2" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Unit 1" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot3" Name in the "Slot Name" field on the Project details page
	And User type "Slot 3" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Unit 2" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot4" Name in the "Slot Name" field on the Project details page
	And User type "Slot 4" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	#act1
	When User clicks "Units" tab
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And "1" rows are displayed in the agGrid on Capacity Slots page
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	#act2
	When User clicks "Units" tab
	And User enters "Capacity Unit 1" text in the Search field for "Capacity Unit" column
	Then "2" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "Capacity Unit 1,All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And "2" rows are displayed in the agGrid on Capacity Slots page
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	| Slot2 |
	#act3
	When User clicks "Units" tab
	And User enters "Capacity Unit 2" text in the Search field for "Capacity Unit" column
	Then "2" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "Capacity Unit 2,All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And "2" rows are displayed in the agGrid on Capacity Slots page
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	| Slot3 |
	#remove tests data
	When User selects "Slots" tab on the Project details page
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
	When User selects "Details" tab on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Mode" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @Projects @DAS13779 @DAS14176 @DAS14177 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideDate
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectDAS13779" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "SlotDAS13779" Name in the "Slot Name" field on the Project details page
	And User type "13779" Name in the "Display Name" field on the Project details page
	And User enters "29 Oct 2018" value to "Slot Available From" date field on Capacity Slot form page
	And User enters "29 Oct 2018" value to "Slot Available To" date field on Capacity Slot form page
	And User clicks the "CREATE" Action button
	And User selects "Override Dates" tab on the Project details page
	And User clicks the "CREATE OVERRIDE DATE" Action button
	Then Create Override Date is displayed correctly
	Then "CREATE" Action button have tooltip with "Some settings are not valid" text
	And "CREATE" Action button is disabled
	When User enters "29 Oct 2018" date in the "Override Start Date" field
	Then "CREATE" Action button have tooltip with "Some settings are not valid" text
	Then "CREATE" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some settings are not valid" text
	When User enters "29 Oct 2018" date in the "Override End Date" field
	Then "CREATE" Action button is active
	When User selects "SlotDAS13779" in the "Slot" dropdown
	And User enters "0" value in the "Capacity" field
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters "29 Oct 2018" date in the "Override Start Date" field
	And User enters "29 Oct 2018" date in the "Override End Date" field
	And User selects "SlotDAS13779" in the "Slot" dropdown
	And User enters "0" value in the "Capacity" field
	And User clicks the "CREATE" Action button
	Then Error message with "An override already exists for this date" text is displayed
	And "1" rows label displays in Action panel
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Override_Dates @Projects @DAS13442 @DAS13440 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForOneSlot
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectDAS13442" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectDAS13442" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot13442" Name in the "Slot Name" field on the Project details page
	And User type "13442" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks newly created object link
	When User selects "Override Dates" tab on the Project details page
	And User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters "1 Sep 2018" date in the "Override Start Date" field
	And User enters "7 Sep 2018" date in the "Override End Date" field
	And User selects "Slot13442" in the "Slot" dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your override date has been created" text
	When User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters "5 Sep 2018" date in the "Override Start Date" field
	And User enters "10 Sep 2018" date in the "Override End Date" field
	And User selects "Slot13442" in the "Slot" dropdown
	And User clicks the "CREATE" Action button
	Then Error message with "An override already exists for this date" text is displayed
	And There are no errors in the browser console
	When User selects "Slots" tab on the Project details page
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| Slot13442        |
	When User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	Then Warning message with "1 slot and 1 related override date will be deleted, do you wish to proceed?" text is displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13490
Scenario: EvergreenJnr_AdminPage_CheckThat0ValuesAreCorrectlyShownOnTheCapacitySlotsScreen
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "User Scheduled Test (Jo)" text in the Search field for "Project" column
	When User clicks content from "Project" column
	Then Project "User Scheduled Test (Jo)" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	Then "40" content is displayed in "MO" column
	When User clicks content from "Capacity Slot" column
	And User changes value to "0" for "Monday" column
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	And "0" content is displayed in "MO" column
	When User clicks content from "Capacity Slot" column
	And User changes value to "40" for "Monday" column
	And User clicks the "UPDATE" Action button

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13608 @DAS13472
Scenario: EvergreenJnr_AdminPage_CheckRequestTypesDisplayedForEachObjectType
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Email Migration" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User clicks content from "Capacity Slot" column
	Then "Scheduled date" value is displayed in the "Tasks" dropdown
	When User clicks on "Request Types" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                  |
	| Personal Mailbox       |
	| Public Folder          |
	| Shared Mailbox         |
	| Personal Mailbox - VIP |
	| Personal Mailbox - EA  |
	When User selects "User" in the "Object Type" dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Request Types" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items         |
	| Standard User |
	| VIP User      |
	When User selects "Application" in the "Object Type" dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Request Types" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                  |
	| Public Folder          |
	| Sharepoint Application |
	When User clicks "Projects" navigation link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Windows 7 Migration (Computer Scheduled Project)" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks content from "Capacity Slot" column
	Then "Scheduled Date" value is displayed in the "Tasks" dropdown
	When User clicks on "Request Types" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                                            |
	| [This is the Default Request Type for Computer)] |
	| Computer: PC Rebuild                             |
	| Computer: Workstation Replacement                |
	| Computer: Laptop Replacement                     |
	| Computer: Virtual Machine                        |
	When User selects "User" in the "Object Type" dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Request Types" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items            |
	| [Default (User)] |
	| User: No Agent   |
	| User: VIP        |
	| User; Maternity  |
	When User selects "Application" in the "Object Type" dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Request Types" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                       |
	| [Default (Application)]     |
	| Application: Request Type A |
	| Application: Request Type B |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @Projects @DAS13159 @DAS13754 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckingSortOrderForCapacityUnits
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "13159ProjectForCapacity" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "13159ProjectForCapacity" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit13790" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "NewUnit" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "13159" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "A13159Unit" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And column content is displayed in the following order:
	| Items             |
	| Unassigned        |
	| 13159             |
	| A13159Unit        |
	| CapacityUnit13790 |
	| NewUnit           |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13382 @DAS13149 @DAS13147 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatNewSlotIsSuccessfullyCreatedUsingExistingDisplayName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "13382ProjectForCapacity" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "13382ProjectForCapacity" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Name1" Name in the "Slot Name" field on the Project details page
	And User type "Name1" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And There are no errors in the browser console
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "NewName" Name in the "Slot Name" field on the Project details page
	And User type "Name1" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And There are no errors in the browser console
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot13147" Name in the "Slot Name" field on the Project details page
	And User type "Name13147" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Capacity @Slots @Senior_Projects @Projects @DAS14029
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUnits
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName      | ShortName | Description | Type |
	| Project14029 Snr | 13498     |             |      |
	And User navigate to Evergreen link
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project14029 Snr" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Details" tab on the Project details page
	Then Capacity Units value is displayed for Capacity Mode field
	When User click on Back button
	And User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project14029" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks the "CREATE PROJECT" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Details" tab on the Project details page
	Then Capacity Units value is displayed for Capacity Mode field
	When User click on Back button
	And User select "Project" rows in the grid
	| SelectedRowsName |
	| Project14029     |
	| Project14029 Snr |
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13955 @DAS13681 @DAS14208 @Delete_Newly_Created_Project
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
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "German" language on the Project details page
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User enters "ChecksLanguage" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User clicks "See Translations" link on the Capacity Slot page
	Then "German" Language is displayed in Translations table on the Capacity Slot page
	When User types "CheckName" in Display Name field for "German" Language in Translations table on the Capacity Slot page
	And User clicks the "UPDATE" Action button
	And User enters "ChecksLanguage" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User clicks "See Translations" link on the Capacity Slot page
	Then "CheckName" is displayed in Display Name field for "German" Language in Translations table on the Capacity Slot page
	When User clicks "Capacity" tab
	And User clicks "Details" tab
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	Then Warning message with "Removing German will delete all translations for this language in this project" text is displayed on the Project Details Page
	When User clicks "CANCEL" button in the warning message on Admin page
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	When User clicks "REMOVE" button in the warning message on Admin page
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "ChecksLanguage 2" Name in the "Slot Name" field on the Project details page
	And User type "DAS13955" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
	Then See Translations link on the Capacity Slot page is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @DAS13928 @DAS14614 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectlMessageAppearsWhenDefaultLanguageDoesNotHaveTranslations
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ChecksDefaultLanguage13928" in the "Project Name" field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	And User expands the object to add
	And User selects following Objects
	| Objects                                |
	| 1A701E05916148A6A3F (Fairlchild, Sara) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "1 object queued for onboarding, 0 objects offboarded" text
	When User clicks "Details" tab
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "Brazilian" language on the Project details page
	And User opens menu for selected language
	Then User selects "Set as default" option for selected language
	And Error message with "You cannot update the default language to Brazilian because there are items in the project which have not been translated into this language." text is displayed
	When User clicks "Scope" tab
	And User selects "Queue" tab on the Project details page
	Then Counter shows "1" found rows
	#When User selects "History" tab on the Project details page
	#And User enters "1A701E05916148A6A3F" text in the Search field for "Item" column
	#Then User clicks on "1A701E05916148A6A3F" search result
	#When User navigates to the "Projects" tab

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13422
Scenario: EvergreenJnr_AdminPage_CheckingPercentageCapacityToReachBeforeShowingAmberField
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Email Migration" is displayed to user
	When User clicks "Capacity" tab
	And User changes Percentage to reach before showing amber to "101"
	Then "UPDATE" Action button is disabled
	When User changes Percentage to reach before showing amber to "100"
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS14103 @DAS14172 @Delete_Newly_Created_Project @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatCloningOfEvergreenCapacityUnitsToProjectCapacityUnitsIsWorkedCorrectlyIfTheCapacityModeEqualsCapacityUnits
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS14103" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	Then User selects "Teams and Request Types" option in "Capacity Mode" dropdown
	And User selects "Clone evergreen capacity units to project capacity units" option in "Capacity Units" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User click on Back button
	And User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE UNIT" Action button
	And User type "Capacity Unit For DAS14103" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks newly created object link
	And User selects "Devices" tab on the Capacity Units page
	Then "Devices" tab is selected on the Admin page
	When User clicks the "ADD DEVICE" Action button
	And User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	And User clicks the "ADD DEVICES" Action button
	Then Success message is displayed and contains "The selected device has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User selects "Users" tab on the Capacity Units page
	Then "Users" tab is selected on the Admin page
	When User clicks the "ADD USER" Action button
	And User selects following Objects
	| Objects   |
	| AAC860150 |
	And User clicks the "ADD USERS" Action button
	Then Success message is displayed and contains "The selected user has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User selects "Applications" tab on the Capacity Units page
	Then "Applications" tab is selected on the Admin page
	When User clicks the "ADD APPLICATION" Action button
	And User selects following Objects
	| Objects                                                         |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                      |
	And User clicks the "ADD APPLICATIONS" Action button
	Then Success message is displayed and contains "The selected application has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User clicks "Administration" navigation link on the Admin page
	And User enters "ProjectForDAS14103" text in the Search field for "Project" column
	And User click content from "Project" column
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 001BAQXT6JWFPI |
	And User clicks "Users" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	And User clicks "Applications" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects                                    |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                                      |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| 001BAQXT6JWFPI                             |
	| AAC860150                                  |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User enters "AAC860150" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User enters "0004 - Adobe Acrobat Reader 5.0.5 Francais" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items                                      |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| 001BAQXT6JWFPI                             |
	| AAC860150                                  |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User enters "AAC860150" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User enters "0004 - Adobe Acrobat Reader 5.0.5 Francais" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User enters "Capacity Unit For DAS14103" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Devices" column
	And "1" content is displayed in "Users" column
	And "1" content is displayed in "Applications" column
	When User clicks "Administration" navigation link on the Admin page
	And User clicks "Capacity Units" link on the Admin page
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName           |
	| Capacity Unit For DAS14103 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13661 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatCreatedSlotWithSelectedTypeTeamsAndRequestTypesIsDisplayedWithCorrectlyValue
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS14103" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "capacity type = Teams and Request types" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Teams and Request types" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And "" content is displayed in "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13417 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatNoUnitsOptionsWasAddedToCapacityUnitsFilter
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13417" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "capacity type = Teams and Request types" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Teams and Request types" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "capacity type = Capacity Units" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Capacity Units" Name in the "Display Name" field on the Project details page
	Then User selects "Capacity Units" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	And User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	Then Counter shows "1" found rows
	And "" content is displayed in "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13792 @DAS13788 @DAS14241 @Delete_Newly_Created_Project @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatNewSlotAppearsAfterDuplicateActionWithCorrectNameAndSameContent
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13979" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 13979" Name in the "Slot Name" field on the Project details page
	And User type "13979" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
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
	| column         | duplicatedValue   | duplicateCount |
	| MO             | 0                 | 2              |
	| TU             | 1                 | 2              |
	| WE             | 2                 | 2              |
	| TH             | 3                 | 2              |
	| FR             | 4                 | 2              |
	| SA             | 5                 | 2              |
	| SU             | 6                 | 2              |
	| Request Types  | All Request Types | 2              |
	| Teams          | All Teams         | 2              |
	| Capacity Units |                   | 2              |
	When User opens settings for "Slot 13979 (copy)" row
	And User selects "Duplicate" option from settings menu
	Then Success message is displayed and contains "Your capacity slot has been created, click here to view the Slot 13979 (copy) (copy) slot" text
	And User sees following duplicates counts for columns:
	| column         | duplicatedValue   | duplicateCount |
	| MO             | 0                 | 3              |
	| TU             | 1                 | 3              |
	| WE             | 2                 | 3              |
	| TH             | 3                 | 3              |
	| FR             | 4                 | 3              |
	| SA             | 5                 | 3              |
	| SU             | 6                 | 3              |
	| Request Types  | All Request Types | 3              |
	| Teams          | All Teams         | 3              |
	| Capacity Units |                   | 3              |
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
	When User refreshes agGrid
	Then Counter shows "1" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS14478 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatCopySuffixDisplayingForNames
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS14478" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 14478" Name in the "Slot Name" field on the Project details page
	And User type "14478" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User opens settings for "Slot 14478" row
	And User selects "Duplicate" option from settings menu
	Then Success message is displayed and contains "Your capacity slot has been created, click here to view the Slot 14478 (copy) slot" text
	When User clicks newly created object link
	Then "Slot 14478 (copy)" content is displayed in "Slot Name" field
	And "14478" content is displayed in "Display Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13980 @DAS13981
Scenario: EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValueEnteredInSlotMoveToPositionDialog
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User opens settings for "User Slot" row
	And User selects "Move to position" option from settings menu
	And User remembers the Move to position dialog size
	And User enters "1.2" value in Move to position dialog
	Then User checks that Move to position dialog has the same size
	And Button "Move" in Move to position dialog is displayed disabled
	And Alert message is displayed and contains "Enter integer value between 1 and 32767" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13791 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatSlotIsMovedToLastPositionIfValueEnteredInMoveToPositionIsGreaterThanTotalresocordsNumber
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13791" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 10001" Name in the "Slot Name" field on the Project details page
	And User type "10001" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 10002" Name in the "Slot Name" field on the Project details page
	And User type "10002" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 10003" Name in the "Slot Name" field on the Project details page
	And User type "10003" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then User sees next Slots on the Capacity Slots page:
	| slots      |
	| Slot 10001 |
	| Slot 10002 |
	| Slot 10003 |
	When User opens settings for "Slot 10001" row
	And User selects "Move to position" option from settings menu
	And User enters "32767" value in Move to position dialog
	And User clicks "Move" bth in Move to position dialog
	Then User sees next Slots on the Capacity Slots page:
	| slots      |
	| Slot 10002 |
	| Slot 10003 |
	| Slot 10001 |
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13792 @DAS13788 @DAS14241 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatSortingWorkCorrectlyForRequestTypeTeamsCapacityUnitsColumnsOnSlotsPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13792" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Request Types" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 3" Name in the "Slot Name" field on the Project details page
	And User type "Slot 3" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User click on 'Capacity Units' column header
	Then data in table is sorted by "Capacity Units" column in ascending order on the Admin page
	When User click on 'Capacity Units' column header
	Then data in table is sorted by "Capacity Units" column in descending order on the Admin page
	And There are no errors in the browser console
	When User click on 'Teams' column header
	Then data in table is sorted by "Teams" column in ascending order on the Admin page
	When User click on 'Teams' column header
	Then data in table is sorted by "Teams" column in descending order on the Admin page
	And There are no errors in the browser console
	When User click on 'Request Types' column header
	Then data in table is sorted by "Request Types" column in ascending order on the Admin page
	When User click on 'Request Types' column header
	Then data in table is sorted by "Request Types" column in descending order on the Admin page
	And There are no errors in the browser console
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	Then "No units,Unassigned" is displayed in the dropdown filter for "Capacity Units" column
	And There are no errors in the browser console
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "Unassigned" checkbox from String Filter on the Admin page
	Then "All Capacity Units,No units" is displayed in the dropdown filter for "Capacity Units" column
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @Projects @DAS13961 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatOriginalCapacityUnitStoredAndDisplayedIfCapacityUnitForOnboardedObjectsWasChanged
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13961" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 001BAQXT6JWFPI |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items          |
	| 001BAQXT6JWFPI |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Unassigned" content is displayed in "Capacity Unit" column
	When User open "Capacity" sub menu on Admin page
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit13961" Name in the "Capacity Unit Name" field on the Project details page
	And User updates the "Default unit" checkbox state
	And User clicks the "CREATE" Action button
	And User open "Scope" sub menu on Admin page
	And User selects "History" tab on the Project details page
	And User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Unassigned" content is displayed in "Capacity Unit" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13811
Scenario: EvergreenJnr_AdminPage_CheckThatListOfSelectedItemsIsTruncatedForRequestTypeTeamsAndCapacityUnitsColumnOnCapacitySlotsGrid
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "DAS_13811_1" Name in the "Slot Name" field on the Project details page
	And User type "13811_1" Name in the "Display Name" field on the Project details page
	And User selects following items in "Request Types" dropdown:
	| items                             |
	| Computer: PC Rebuild              |
	| Computer: Workstation Replacement |
	And User selects following items in "Teams" dropdown:
	| items               |
	| Administrative Team |
	| Admin IT            |
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "DAS_13811_2" Name in the "Slot Name" field on the Project details page
	And User type "13811_2" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	And User selects following items in "Capacity Units" dropdown:
	| items           |
	| Unassigned      |
	| Capacity Unit 1 |
	| Capacity Unit 2 |
	And User clicks the "CREATE" Action button
	Then User sees following text in cell truncated with ellipsis:
	| cellText                                               |
	| Computer: PC Rebuild,Computer: Workstation Replacement |
	| Admin IT,Administrative Team                           |
	| Capacity Unit 1,Capacity Unit 2,Unassigned             |
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| DAS_13811_1      |
	| DAS_13811_2      |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @Projects @DAS13956 @DAS14068 @DAS14218 @Delete_Newly_Created_Project @Do_Not_Run_With_CapacityUnits
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitInAProjectMappedToEvergreenDefaultCapacityUnit
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User selects "Unit Settings" tab on the Capacity Units page
	And User type "New Name" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "UPDATE" Action button
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13956" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User open "Capacity" sub menu on Admin page
	Then User selects "Clone evergreen capacity units to project capacity units" option in "Capacity Units" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User selects "Units" tab on the Project details page
	Then Counter shows "1" found rows
	And "Unassigned" content is displayed for "Capacity Unit" column
	And "New Name" content is displayed for "Maps to Evergreen" column
	When User clicks "Administration" navigation link on the Admin page
	And User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User enters "New Name" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User selects "Unit Settings" tab on the Capacity Units page
	And User type "Unassigned" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "UPDATE" Action button

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Projects @DAS13526 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatInSlotsColumnOnCapacityUnitsPageTheCorrectDataIsDisplayed
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13526" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	And User open "Capacity" sub menu on Admin page
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "Unit 1" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "Unit 2" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	When User clicks the "CREATE" Action button
	And User selects "Units" tab on the Project details page
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User enters "Unit 1" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User enters "Unit 2" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User selects "Slots" tab on the Project details page
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	When User clicks the "CREATE" Action button
	And User selects "Units" tab on the Project details page
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "2" content is displayed in "Slots" column
	When User enters "Unit 1" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User enters "Unit 2" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13812 @DAS13676 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateButtonIsDisplayedCorrectlyOnTheEditCapacitySlotScreenIfAnAllocatedTaskHasSinceBeenChanged
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName        | ShortName | Description | Type |
	| ProjectForDAS13812 | 13812     |             |      |
	And User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName  |
	| Stage13812 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate | 
	| 1Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate | 
	| 2Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate | 
	| 3Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "ProjectForDAS13812" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User open "Capacity" sub menu on Admin page
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "1Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "2Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "3Task13812" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS13812" Project
	And User navigate to "Tasks" tab
	And User navigate to "1Task13812" Task
	And User unpublishes the task
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "ProjectForDAS13812" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User open "Capacity" sub menu on Admin page
	And User selects "Slots" tab on the Project details page
	And User clicks content from "Capacity Slot" column
	And User changes value to "1" for "Tuesday" day column
	Then "UPDATE" Action button is disabled
	And "UPDATE" Action button have tooltip with "This slot cannot be saved because it is associated to at least 1 unpublished task (1Task13812)" text
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	And User selects "2Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "3Task13812" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS13812" Project
	And User navigate to "Tasks" tab
	And User removes "2Task13812" Task
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "ProjectForDAS13812" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User open "Capacity" sub menu on Admin page
	And User selects "Slots" tab on the Project details page
	And User enters "Slot 2" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User changes value to "1" for "Tuesday" day column
	Then "UPDATE" Action button is active
	When User clicks "Administration" navigation link on the Admin page
	And User enters "ProjectForDAS13812" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @Projects @DAS13593 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyDateTasksCanBeAvailableForSelectionInCreateSlotPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectDAS13593 " in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Projects" on the left-hand menu
	And User navigate to "ProjectDAS13593" Project
	And User navigate to "Stages" tab
	And User clicks "Create Stage" button
	And User create Stage
	| StageName  |
	| Stage13593 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate |
	| 1Task13593 | 13593 | Stage13593 | Normal   | Date      | Computer   |                    | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType  | TaskValuesTemplate |
	| 2Task13593 | 13593 | Stage13593 | Normal   | Date      | Application |                    | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate |
	| 3Task13593 | 13593 | Stage13593 | Normal   | Date      | User       |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType    | ObjectType | TaskValuesTemplate              |
	| 4Task13593 | 13593 | Stage13593 | Normal   | DropDownList | Computer   | Readiness (NNSFC) with due date |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType   | ObjectType | TaskValuesTemplate              |
	| 5Task13593 | 13593 | Stage13593 | Normal   | Radiobutton | User       | Readiness (NNSFC) with due date |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType   | ObjectType  | TaskValuesTemplate              |
	| 6Task13593 | 13593 | Stage13593 | Normal   | DropDownList | Application | Readiness (NNSFC) with due date |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType    | ObjectType | TaskValuesTemplate |
	| 7Task13593 | 13593 | Stage13593 | Normal   | DropDownList | Computer   |                    | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType  | TaskValuesTemplate |
	| 8Task13593 | 13593 | Stage13593 | Normal   | Text      | Application |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType   | ObjectType | TaskValuesTemplate |
	| 9Task13593 | 13593 | Stage13593 | Normal   | Radiobutton | User       |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "ProjectDAS13593" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User open "Capacity" sub menu on Admin page
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User selects "Device" in the "Object Type" dropdown
	And User clicks on "Tasks" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items      |
	| 1Task13593 |
	| 4Task13593 |
	When User selects "User" in the "Object Type" dropdown
	And User clicks on "Tasks" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items      |
	| 3Task13593 |
	| 5Task13593 |
	When User selects "Application" in the "Object Type" dropdown
	And User clicks on "Tasks" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items      |
	| 2Task13593 |
	| 6Task13593 |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14218
Scenario: EvergreenJnr_AdminPage_CheckingMapsToEvergreenColumnDisplayedForDifferentProjectTypes
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "User Evergreen Capacity Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "User Evergreen Capacity Project" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User enters "1" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 1" content is displayed for "Maps to Evergreen" column
	When User enters "2" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 2" content is displayed for "Maps to Evergreen" column
	When User enters "3" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 3" content is displayed for "Maps to Evergreen" column
	When User clicks "Projects" navigation link on the Admin page
	When User enters "Devices Evergreen Capacity Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Devices Evergreen Capacity Project" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User have opened Column Settings for "Capacity Unit" column
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User enters "1" text in the Search field for "Capacity Unit" column
	Then "" content is displayed for "Maps to Evergreen" column
	When User enters "2" text in the Search field for "Capacity Unit" column
	Then "" content is displayed for "Maps to Evergreen" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13500 @DAS13636 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots @Do_Not_Run_With_Senior @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatTasksAreUnpublishedAfterBeingAssociatedToACapacitySlot
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "Scheduled Date" checkbox in the "Tasks" field on the Project details page
	And User selects "Forecast Date" checkbox in the "Tasks" field on the Project details page
	And User selects "Group Computer Rag Radio Date Owner" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	And User navigate to "Tasks" tab
	And User navigate to "Forecast Date" Task
	And User unpublishes the task
	And User navigate to "Tasks" tab
	And User navigate to "Group Computer Rag Radio Date Owner" Task
	And User unpublishes the task
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User open "Capacity" sub menu on Admin page
	And User selects "Slots" tab on the Project details page
	And User enters "Slot 1" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	Then Next values are selected for the "Tasks" field:
	| Value                               |
	| Forecast Date                       |
	| Group Computer Rag Radio Date Owner |
	| Scheduled Date                      |
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	Then Next checkboxes in the "Tasks" dropdown are not available to select:
	| Value                               |
	| Forecast Date                       |
	| Group Computer Rag Radio Date Owner |
	And "Scheduled Date" checkbox in the "Tasks" field are available to select
	When User clicks the "CANCEL" Action button
	And User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| Slot 1           |
	And User removes selected item
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	And User navigate to "Tasks" tab
	And User navigate to "Forecast Date" Task
	And User publishes the task
	And User navigate to "Tasks" tab
	And User navigate to "Group Computer Rag Radio Date Owner" Task
	And User publishes the task

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13500 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots @Do_Not_Run_With_Senior
Scenario: EvergreenJnr_AdminPage_ChecksThatTasksAreDeletedAfterBeingAssociatedToACapacitySlot
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName                                      | TaskType | ValueType | ObjectType | TaskValuesTemplate |
	| 1Task13500 | 13500 | Computer Information ---- Text fill; Text fill; | Normal   | Date      | Computer   |                    | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName                                      | TaskType | ValueType | ObjectType | TaskValuesTemplate |
	| 2Task13500 | 13500 | Computer Information ---- Text fill; Text fill; | Group    | Date      | Computer   |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User open "Capacity" sub menu on Admin page
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "1Task13500" checkbox in the "Tasks" field on the Project details page
	And User selects "2Task13500" checkbox in the "Tasks" field on the Project details page
	And User selects "Scheduled Date" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User removes "1Task13500" Task
	And User removes "2Task13500" Task
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User open "Capacity" sub menu on Admin page
	And User selects "Slots" tab on the Project details page
	And User enters "Slot 1" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	Then Next values are selected for the "Tasks" field:
	| Value          |
	| Scheduled Date |
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	Then Next checkboxes in the "Tasks" dropdown are not available to select:
	| Value          |
	| 1Task13500     |
	| 2Task13500     |
	And "Scheduled Date" checkbox in the "Tasks" field are available to select

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13152 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForCapacityUnitsType
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName        | ShortName | Description | Type |
	| ProjectForDAS13152 | 13152     |             |      |
	And User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName  |
	| Stage13152 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates new Task on Senior
	| Name      | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| Task13152 | 13152 | Stage13152 | Normal   | Date      | Computer   |                    | true               |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "ProjectForDAS13152" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot13152" Name in the "Slot Name" field on the Project details page
	And User type "13152" Name in the "Display Name" field on the Project details page
	And User selects "Task13152" checkbox in the "Tasks" field on the Project details page
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks content from "Capacity Slot" column
	Then "Task13152" value is displayed in the "Tasks" dropdown
	And "Unassigned" value is displayed in the "Capacity Units" dropdown
	And "Device" text value is displayed in the "Object Type" dropdown
	When User selects "Application" in the "Object Type" dropdown
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	When User clicks content from "Capacity Slot" column
	Then "" content is displayed in "Tasks" field
	Then "All Capacity Units" content is displayed in "Capacity Units" field
	And "Application" text value is displayed in the "Object Type" dropdown
	When User clicks "Administration" navigation link on the Admin page
	And User enters "ProjectForDAS13152" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13152 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndRequestTypes
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName         | ShortName | Description | Type |
	| ProjectForDAS131522 | 131522    |             |      |
	And User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| Stage131522 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help   | StagesName  | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| Task131522 | 131522 | Stage131522 | Normal   | Date      | Computer   |                    | true               |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "ProjectForDAS13152" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot131522" Name in the "Slot Name" field on the Project details page
	And User type "131522" Name in the "Display Name" field on the Project details page
	And User selects "Teams and Request Types" in the "Capacity Type" dropdown
	And User selects "Task131522" checkbox in the "Tasks" field on the Project details page
	And User selects "Admin IT" checkbox in the "Teams" field on the Project details page
	And User selects "[Default (Computer)]" checkbox in the "Request Types" field on the Project details page
	When User selects "Device" in the "Object Type" dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	#Check data in the slot after creation
	When User clicks content from "Capacity Slot" column
	Then "Teams and Request Types" value is displayed in the "Capacity Type" dropdown
	And "Task131522" value is displayed in the "Tasks" dropdown
	And "Device" text value is displayed in the "Object Type" dropdown
	And "[Default (Computer)]" value is displayed in the "Request Types" dropdown
	And "Admin IT" value is displayed in the "Teams" dropdown
	#Change data in the slot
	When User selects "Application" in the "Object Type" dropdown
	And User selects "Admin IT" checkbox in the "Teams" field on the Project details page
	And User selects "1803 Team" checkbox in the "Teams" field on the Project details page
	And User selects "[Default (Application)]" checkbox in the "Request Types" field on the Project details page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	#Check updated data in the slot and change Capacity Type
	When User clicks content from "Capacity Slot" column
	Then "Teams and Request Types" text value is displayed in the "Capacity Type" dropdown
	And "Application" text value is displayed in the "Object Type" dropdown
	And "[Default (Application)]" value is displayed in the "Request Types" dropdown
	And "1803 Team" value is displayed in the "Teams" dropdown
	When User selects "Capacity Units" in the "Capacity Type" dropdown
	And User clicks the "UPDATE" Action button
	#Check updated Capacity Type value
	When User clicks content from "Capacity Slot" column
	Then "Capacity Units" text value is displayed in the "Capacity Type" dropdown
	When User clicks "Administration" navigation link on the Admin page
	And User enters "ProjectForDAS131522" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13156
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedApplicationsAreDisplayedCapacityUnits
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Email Migration" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " 1Test" Name in the "Capacity Unit Name" field on the Project details page
	And User type "DAS13156" Name in the "Description" field on the Project details page
	And User updates the "Default unit" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName         |
	| 7-Zip 16.04 (x64)        |
	| 7-Zip 9.20 (x64 edition) |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "1Test" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "2 of 2 objects were in the selected project and have been queued" text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Capacity Units" link on the Admin page
	Then "Capacity Units" page should be displayed to the user
	When User clicks String Filter button for "Project" column
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column
	When User selects "Email Migration" checkbox from String Filter with item list on the Admin page
	Then "2" content is displayed in "Applications" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User click content from "Capacity Unit" column
	And User updates the "Default unit" checkbox state
	And User clicks the "UPDATE" Action button
	When User clicks Reset Filters button on the Admin page
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName |
	| 1Test            |
	And User removes selected item