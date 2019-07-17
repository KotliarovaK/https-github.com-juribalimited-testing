Feature: CapacitySlots
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13171 @DAS13432 @DAS13430 @DAS13412 @DAS13493 @DAS13375 @DAS13711 @DAS17271 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| ProjectForCapacity13171 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User clicks on the Unlimited field on the Capacity Slots page
	Then Unlimited text disappears from column
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE SLOT" Action button
	And User type "CapacitySlot1" Name in the "Slot Name" field on the Project details page
	And User type "DAS13432" Name in the "Display Name" field on the Project details page
	Then "All Capacity Units" content is displayed in "Capacity Units" field
	When User selects "Capacity Units" in the "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	Then "All Capacity Units" content is displayed in "Capacity Units" column
	When User clicks the "CREATE SLOT" Action button
	And User type "CapacitySlot1" Name in the "Slot Name" field on the Project details page
	And User type "DAS13432" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity slot already exists with this name" text is displayed
	When User clicks the "CREATE SLOT" Action button
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
	When User clicks the "CREATE SLOT" Action button
	And User type "CapacitySlot2" Name in the "Slot Name" field on the Project details page
	And User type "DAS13432" Name in the "Display Name" field on the Project details page
	When User selects "Teams and Paths" in the "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	When User selects "All Capacity Units" checkbox from String Filter on the Admin page
	Then "No units" is displayed in the dropdown filter for "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13780 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsUnableToCreateMoreThanOneOverrideDateForSameSlotWithSameDate
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13780 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "SlotDAS13780_1" Name in the "Slot Name" field on the Project details page
	And User type "13780_1" Name in the "Display Name" field on the Project details page
	And User enters "17 Oct 2018" value to "Slot Available From" date field on Capacity Slot form page
	And User enters "18 Oct 2018" value to "Slot Available To" date field on Capacity Slot form page
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE SLOT" Action button
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Units @DAS13789 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateCapacityUnitOrSlotUsingTheSameNameWithDifferentCase
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13789 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
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
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13824 @DAS14250 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatSlotAvailableFromAndSlotAvailableToCanBeClearedOnUpdateCapacitySlotPage
	When Project created via API and opened
	| ProjectName                | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacityDAS13824 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
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
	When User navigates to "User Scheduled Project in Italian & Japanese (Jo)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "CapacitySlotDAS13441" Name in the "Slot Name" field on the Project details page
	And User type "DAS13441" Name in the "Display Name" field on the Project details page
	And User selects "Device" in the "Object Type" dropdown
	And User selects next items in the "Tasks" dropdown:
	| Items                                      |
	| Stage 1 \ DDL Task for a Computer          |
	| Stage 1 \ Date Task for a Computer Italian |
	And User clicks on "Teams" dropdown on the Capacity Slots page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
	Then User sees following tiles selected in the "Tasks" field:
	| Items                                      |
	| Stage 1 \ DDL Task for a Computer          |
	| Stage 1 \ Date Task for a Computer Italian |
	When User selects "User" in the "Object Type" dropdown
	Then User sees following tiles selected in the "Tasks" field:
	| Items                            |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13866
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteParticularCapacitySlotOfParticularProject
	When User navigates to "Project K-Computer Scheduled Project" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
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
	When User navigates to "User Evergreen Capacity Project" project details
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
	When User navigates to "User Scheduled Project in Italian & Japanese (Jo)" project details
	And User clicks "Capacity" tab
	#prepare data
	And User selects "Capacity Details" tab on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Mode" dropdown
	When User clicks the "UPDATE" Action button
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
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Unit 1" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot3" Name in the "Slot Name" field on the Project details page
	And User type "Slot 3" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Unit 2" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot4" Name in the "Slot Name" field on the Project details page
	And User type "Slot 4" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	#act1
	When User clicks "Capacity" tab
	When User clicks "Units" tab
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And Rows counter contains "1" found row of all rows
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	#act2
	When User clicks "Capacity" tab
	And User clicks "Units" tab
	And User enters "Capacity Unit 1" text in the Search field for "Capacity Unit" column
	Then "2" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "Capacity Unit 1,All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And Rows counter contains "2" found row of all rows
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	| Slot2 |
	#act3
	When User clicks "Capacity" tab
	And User clicks "Units" tab
	And User enters "Capacity Unit 2" text in the Search field for "Capacity Unit" column
	Then "2" content is displayed in "Slots" column
	When User clicks content from "Slots" column
	Then "Capacity Unit 2,All Capacity Units" is displayed in the dropdown filter for "Capacity Units" column
	And Rows counter contains "2" found row of all rows
	And User sees next Slots on the Capacity Slots page:
	| slots |
	| Slot1 |
	| Slot3 |
	#remove tests data
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
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
	When User selects "Capacity Details" tab on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Mode" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13779 @DAS14176 @DAS14177 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideDate
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13779 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Override_Dates @DAS13442 @DAS13440 @DAS17418 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForOneSlot
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13442 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot13442" Name in the "Slot Name" field on the Project details page
	And User type "13442" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks newly created object link
	And User clicks "Capacity" tab
	And User selects "Override Dates" tab on the Project details page
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
	When User navigates to "User Scheduled Test (Jo)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	Then "40" content is displayed in "Monday" column
	When User clicks content from "Capacity Slot" column
	And User changes value to "0" for "Monday" column
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	And "0" content is displayed in "Monday" column
	When User clicks content from "Capacity Slot" column
	And User changes value to "40" for "Monday" column
	And User clicks the "UPDATE" Action button

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13608 @DAS13472
Scenario: EvergreenJnr_AdminPage_CheckRequestTypesDisplayedForEachObjectType
	When User navigates to "Email Migration" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User clicks content from "Capacity Slot" column
	Then "Pre-Migration \ Scheduled date" value is displayed in the "Tasks" dropdown
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                  |
	| Personal Mailbox       |
	| Public Folder          |
	| Shared Mailbox         |
	| Personal Mailbox - VIP |
	| Personal Mailbox - EA  |
	When User selects "User" in the "Object Type" dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items         |
	| Standard User |
	| VIP User      |
	When User selects "Application" in the "Object Type" dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                  |
	| Public Folder          |
	| Sharepoint Application |
	When User clicks "Projects" navigation link on the Admin page
	And User clicks Yes button in Leave Page Warning
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks content from "Capacity Slot" column
	Then "Pre-Migration \ Scheduled Date" value is displayed in the "Tasks" dropdown
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                                            |
	| [This is the Default Request Type for Computer)] |
	| Computer: PC Rebuild                             |
	| Computer: Workstation Replacement                |
	| Computer: Laptop Replacement                     |
	| Computer: Virtual Machine                        |
	When User selects "User" in the "Object Type" dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items            |
	| [Default (User)] |
	| User: No Agent   |
	| User: VIP        |
	| User; Maternity  |
	When User selects "Application" in the "Object Type" dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                       |
	| [Default (Application)]     |
	| Application: Request Type A |
	| Application: Request Type B |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13382 @DAS13149 @DAS13147 @DAS15827 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatNewSlotIsSuccessfullyCreatedUsingExistingDisplayName
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| 13382ProjectForCapacity | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot13147" Name in the "Slot Name" field on the Project details page
	And User type "Name13147" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And There are no errors in the browser console
	When User clicks the "CREATE SLOT" Action button
	And User type "NewName" Name in the "Slot Name" field on the Project details page
	And User type "Name1" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And There are no errors in the browser console
	When User clicks the "CREATE SLOT" Action button
	And User type "Name1" Name in the "Slot Name" field on the Project details page
	And User type "Name1" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	When User have opened Column Settings for "Capacity Slot" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Display Order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Display Order" column is sorted in ascending order by default on the Admin page
	Then "Capacity Slot" column content is displayed in the following order:
	| Items     |
	| Slot13147 |
	| NewName   |
	| Name1     |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13955 @DAS13681 @DAS14208 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectlyLanguageIsDisplayedForSlotsAfterChangingOrRemovingLanguage
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| ChecksLanguage13955 | All Devices | None            | Standalone Project |
	And User clicks "Details" tab
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "Dutch" language on the Project details page
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
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
	#You have unsaved changes. Are you sure you want to leave the page?
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
	And User clicks the "CREATE SLOT" Action button
	And User type "ChecksLanguage 2" Name in the "Slot Name" field on the Project details page
	And User type "DAS13955" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
	Then See Translations link on the Capacity Slot page is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13661 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatCreatedSlotWithSelectedTypeTeamsAndRequestTypesIsDisplayedWithCorrectlyValue
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS14103 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "capacity type = Teams and Paths" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Teams and Paths" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And "" content is displayed in "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13417 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatNoUnitsOptionsWasAddedToCapacityUnitsFilter
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13417 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "capacity type = Teams and Paths" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Teams and Paths" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
	And User type "capacity type = Capacity Units" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Capacity Units" Name in the "Display Name" field on the Project details page
	Then User selects "Capacity Units" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	And User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "1" of "2" rows
	And "" content is displayed in "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13792 @DAS13788 @DAS14241 @Delete_Newly_Created_Project @Not_Run
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS14478 @Delete_Newly_Created_Project
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13980 @DAS13981
Scenario: EvergreenJnr_AdminPage_CheckThatMessageDisplayedAndMoveBtnDisabledWhenInvalidValueEnteredInSlotMoveToPositionDialog
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13791 @Delete_Newly_Created_Project
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13792 @DAS13788 @DAS14241 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatSortingWorkCorrectlyForRequestTypeTeamsCapacityUnitsColumnsOnSlotsPage
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13792 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
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
	When User click on 'Paths' column header
	Then data in table is sorted by "Paths" column in ascending order on the Admin page
	When User click on 'Paths' column header
	Then data in table is sorted by "Paths" column in descending order on the Admin page
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13811
Scenario: EvergreenJnr_AdminPage_CheckThatListOfSelectedItemsIsTruncatedForRequestTypeTeamsAndCapacityUnitsColumnOnCapacitySlotsGrid
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "DAS_13811_1" Name in the "Slot Name" field on the Project details page
	And User type "13811_1" Name in the "Display Name" field on the Project details page
	And User selects following items in "Paths" dropdown:
	| items                             |
	| Computer: PC Rebuild              |
	| Computer: Workstation Replacement |
	And User selects following items in "Teams" dropdown:
	| items               |
	| Administrative Team |
	| Admin IT            |
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE SLOT" Action button
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
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13526 @DAS17419 @Delete_Newly_Created_Projec
Scenario: EvergreenJnr_AdminPage_ChecksThatInSlotsColumnOnCapacityUnitsPageTheCorrectDataIsDisplayed
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13526 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "Unit 1" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "Unit 2" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE SLOT" Action button
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
	When User clicks the "CREATE SLOT" Action button
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
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| 1Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 2Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 3Task13812 | 13812 | Stage13812 | Normal   | Date      | Computer   |                    |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	When User navigates to "ProjectForDAS13812" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "Stage13812 \ 1Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "Stage13812 \ 2Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "Stage13812 \ 3Task13812" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS13812" Project
	And User navigate to "Tasks" tab
	And User navigate to "1Task13812" Task
	And User unpublishes the task
	And User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "ProjectForDAS13812" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks content from "Capacity Slot" column
	And User changes value to "1" for "Tuesday" day column
	Then "UPDATE" Action button is disabled
	And "UPDATE" Action button have tooltip with "This slot cannot be saved because it is associated to at least 1 unpublished task (Stage13812 \ 1Task13812)" text
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	And User selects "Stage13812 \ 2Task13812" checkbox in the "Tasks" field on the Project details page
	And User selects "Stage13812 \ 3Task13812" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "ProjectForDAS13812" Project
	And User navigate to "Tasks" tab
	And User removes "2Task13812" Task
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	
	When User navigates to "ProjectForDAS13812" project details
	Then Project "ProjectForDAS13812" is displayed to user
	When User clicks "Capacity" tab
	
	And User selects "Slots" tab on the Project details page
	And User enters "Slot 2" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User changes value to "1" for "Tuesday" day column
	Then "UPDATE" Action button is active

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13593 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyDateTasksCanBeAvailableForSelectionInCreateSlotPage
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13593 | All Devices | None            | Standalone Project |
	And User clicks "Projects" on the left-hand menu
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
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 1Task13593 | 13593 | Stage13593 | Normal   | Date      | Computer   |                    |                     | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType  | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 2Task13593 | 13593 | Stage13593 | Normal   | Date      | Application |                    |                     | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 3Task13593 | 13593 | Stage13593 | Normal   | Date      | User       |                    |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType    | ObjectType | TaskValuesTemplate              |  ApplyToAllCheckbox |
	| 4Task13593 | 13593 | Stage13593 | Normal   | DropDownList | Computer   | Readiness (NNSFC) with due date |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType   | ObjectType | TaskValuesTemplate              |  ApplyToAllCheckbox |
	| 5Task13593 | 13593 | Stage13593 | Normal   | Radiobutton | User       | Readiness (NNSFC) with due date |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType    | ObjectType  | TaskValuesTemplate              | ApplyToAllCheckbox |
	| 6Task13593 | 13593 | Stage13593 | Normal   | DropDownList | Application | Readiness (NNSFC) with due date |                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType    | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 7Task13593 | 13593 | Stage13593 | Normal   | DropDownList | Computer   |                    |                     | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType | ObjectType  | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 8Task13593 | 13593 | Stage13593 | Normal   | Text      | Application |                    |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName | TaskType | ValueType   | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 9Task13593 | 13593 | Stage13593 | Normal   | Radiobutton | User       |                    |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "ProjectDAS13593" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13500 @DAS13636 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots @Do_Not_Run_With_Senior @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatTasksAreUnpublishedAfterBeingAssociatedToACapacitySlot
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "Pre-Migration \ Scheduled Date" checkbox in the "Tasks" field on the Project details page
	And User selects "Pre-Migration \ Forecast Date" checkbox in the "Tasks" field on the Project details page
	And User selects "Computer Information ---- Text fill; Text fill; \ Group Computer Rag Radio Date Owner" checkbox in the "Tasks" field on the Project details page
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
	And User clicks "Admin" on the left-hand menu
	And User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User open "Capacity" sub menu on Admin page
	And User selects "Slots" tab on the Project details page
	And User enters "Slot 1" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	Then Next values are selected for the "Tasks" field:
	| Value                                                                                 |
	| Pre-Migration \ Forecast Date                                                         |
	| Computer Information ---- Text fill; Text fill; \ Group Computer Rag Radio Date Owner |
	| Pre-Migration \ Scheduled Date                                                        |
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE NEW SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	Then Next checkboxes in the "Tasks" dropdown are not available to select:
	| Value                                                                                 |
	| Pre-Migration \ Forecast Date                                                         |
	| Computer Information ---- Text fill; Text fill; \ Group Computer Rag Radio Date Owner |
	And "Pre-Migration \ Scheduled Date" checkbox in the "Tasks" field are available to select
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13502 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots @Do_Not_Run_With_Senior
Scenario: EvergreenJnr_AdminPage_ChecksThatCapacityEnabledFlagUpdatesAfterAddingRemovingTaskFromCapacitySlot
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name      | Help  | StagesName                                      | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| Task13502 | 13502 | Computer Information ---- Text fill; Text fill; | Normal   | Date      | Computer   |                    |                     | 
	Then Success message is displayed with "Task successfully created" text
	When Task Id is stored in memory
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "SlotTask13502" Name in the "Slot Name" field on the Project details page
	And User type "Slot Task13502" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	And User selects "Computer Information ---- Text fill; Text fill; \ Task13502" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks newly created object link
	Then CapacityEnabled flag is equal to "True"
	When User removes "Computer Information ---- Text fill; Text fill; \ Task13502" on the Project details page
	And User clicks the "UPDATE" Action button
	Then CapacityEnabled flag is equal to "False"

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13500 @Do_Not_Run_With_Capacity @Do_Not_Run_With_Slots @Do_Not_Run_With_Senior
Scenario: EvergreenJnr_AdminPage_ChecksThatTasksAreDeletedAfterBeingAssociatedToACapacitySlot
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName                                      | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 1Task13500 | 13500 | Computer Information ---- Text fill; Text fill; | Normal   | Date      | Computer   |                    |                     | 
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Tasks" tab
	And User clicks "Create Task" button
	And User creates new Task on Senior
	| Name       | Help  | StagesName                                      | TaskType | ValueType | ObjectType | TaskValuesTemplate |  ApplyToAllCheckbox |
	| 2Task13500 | 13500 | Computer Information ---- Text fill; Text fill; | Group    | Date      | Computer   |                    |                     |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 1" Name in the "Slot Name" field on the Project details page
	And User type "Slot 1" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	And User selects "Computer Information ---- Text fill; Text fill; \ 1Task13500" checkbox in the "Tasks" field on the Project details page
	And User selects "Computer Information ---- Text fill; Text fill; \ 2Task13500" checkbox in the "Tasks" field on the Project details page
	And User selects "Pre-Migration \ Scheduled Date" checkbox in the "Tasks" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Tasks" tab
	And User removes "1Task13500" Task
	And User removes "2Task13500" Task
	And User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User enters "Slot 1" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	Then Next values are selected for the "Tasks" field:
	| Value                          |
	| Pre-Migration \ Scheduled Date |
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot 2" Name in the "Slot Name" field on the Project details page
	And User type "Slot 2" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	Then Next checkboxes in the "Tasks" dropdown are not available to select:
	| Value                                                        |
	| Computer Information ---- Text fill; Text fill; \ 1Task13500 |
	| Computer Information ---- Text fill; Text fill; \ 2Task13500 |
	And "Pre-Migration \ Scheduled Date" checkbox in the "Tasks" field are available to select

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
	And User clicks "Admin" on the left-hand menu
	And User navigates to "ProjectForDAS13152" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot13152" Name in the "Slot Name" field on the Project details page
	And User type "13152" Name in the "Display Name" field on the Project details page
	And User selects "Capacity Units" in the "Capacity Type" dropdown
	And User selects "Stage13152 \ Task13152" checkbox in the "Tasks" field on the Project details page
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks content from "Capacity Slot" column
	Then "Stage13152 \ Task13152" value is displayed in the "Tasks" dropdown
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13152 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndRequestTypes
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
	| Name      | Help       | StagesName | TaskType | ValueType | ObjectType | TaskValuesTemplate | ApplyToAllCheckbox |
	| Task13152 | 13152 Date | Stage13152 | Normal   | Date      | Computer   |                    | true               |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "ProjectForDAS13152" project details
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "Slot13152" Name in the "Slot Name" field on the Project details page
	And User type "13152" Name in the "Display Name" field on the Project details page
	And User selects "Teams and Paths" in the "Capacity Type" dropdown
	And User selects "Stage13152 \ Task13152" checkbox in the "Tasks" field on the Project details page
	And User selects "Admin IT" checkbox in the "Teams" field on the Project details page
	And User selects "[Default (Computer)]" checkbox in the "Paths" field on the Project details page
	When User selects "Device" in the "Object Type" dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	#Check data in the slot after creation
	When User clicks content from "Capacity Slot" column
	Then "Teams and Paths" value is displayed in the "Capacity Type" dropdown
	And "Stage13152 \ Task13152" value is displayed in the "Tasks" dropdown
	And "Device" text value is displayed in the "Object Type" dropdown
	And "[Default (Computer)]" value is displayed in the "Paths" dropdown
	And "Admin IT" value is displayed in the "Teams" dropdown
	#Change data in the slot
	When User selects "Application" in the "Object Type" dropdown
	And User selects "Admin IT" checkbox in the "Teams" field on the Project details page
	And User selects "1803 Team" checkbox in the "Teams" field on the Project details page
	And User selects "[Default (Application)]" checkbox in the "Paths" field on the Project details page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	#Check updated data in the slot and change Capacity Type
	When User clicks content from "Capacity Slot" column
	Then "Teams and Paths" text value is displayed in the "Capacity Type" dropdown
	And "Application" text value is displayed in the "Object Type" dropdown
	And "[Default (Application)]" value is displayed in the "Paths" dropdown
	And "1803 Team" value is displayed in the "Teams" dropdown
	When User selects "Capacity Units" in the "Capacity Type" dropdown
	And User clicks the "UPDATE" Action button
	#Check updated Capacity Type value
	When User clicks content from "Capacity Slot" column
	Then "Capacity Units" text value is displayed in the "Capacity Type" dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967 @DAS15291
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfUserProjectLeadToCorrectFilteredLists
	When User navigates to "User Evergreen Capacity Project" project details
	And User clicks "Capacity" tab
	And User clicks "Slots" tab
	Then "Capacity Slot" column content is displayed in the following order:
	| Items              |
	| User Slot 1        |
	| User Slot 2        |
	| Device Slot 1      |
	| Device Slot 2      |
	| Application Slot 1 |
	| Application Slot 2 |
	When User selects "Units" tab on the Project details page
	And User enters "Evergreen Capacity Unit 3" text in the Search field for "Capacity Unit" column
	And User remembers value in "<ListName>" column
	And User clicks content from "<ListName>" column
	Then "<ListName>" list should be displayed to the user
	And Rows counter number equals to remembered value
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "UserEvergr: Capacity Unit" filter is added to the list
	And Values is displayed in added filter info
	| Values                    |
	| Evergreen Capacity Unit 3 |
	| Offboarded                |
	And Options is displayed in added filter info
	| Values |
	| is     |
	| is not |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967 @DAS15291
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfMailProjectLeadToCorrectFilteredLists
	When User navigates to "Mailbox Evergreen Capacity Project" project details
	And User clicks "Capacity" tab
	And User clicks "Slots" tab
	Then "Capacity Slot" column content is displayed in the following order:
	| Items                                              |
	| CA -Mailbox-Nov 1, 2018-Nov 10, 2018               |
	| CA -Mailbox-Nov 11, 2018-Nov 30, 2018              |
	| TRT-Mailbox-Nov 11, 2018-Nov 24, 2018\RT=A\T=Admin |
	| TRT-Dec 1, 2018-Dec 31, 2018 - Unlimited           |
	| CA-Mailbox-Jan 1, 2018-Oct 31, 2018                |
	When User selects "Units" tab on the Project details page
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User remembers value in "<ListName>" column
	And User clicks content from "<ListName>" column
	Then "<ListName>" list should be displayed to the user
	And Rows counter number equals to remembered value
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "MailboxEve: Capacity Unit" filter is added to the list
	And Values is displayed in added filter info
	| Values     |
	| Unassigned |
	| Offboarded |
	And Options is displayed in added filter info
	| Values |
	| is     |
	| is not |

Examples:
	| ListName  |
	| Users     |
	| Mailboxes |
	
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
