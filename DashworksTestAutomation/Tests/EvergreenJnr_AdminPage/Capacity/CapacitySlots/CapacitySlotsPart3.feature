Feature: CapacitySlotsPart3
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13779 @DAS14176 @DAS14177 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideDate
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13779 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project         | SlotName     | DisplayName | SlotAvailableFrom | SlotAvailableTo |
	| ProjectDAS13779 | SlotDAS13779 | 13779       | 29 Oct 2018       | 29 Oct 2018     |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User selects "Override Dates" tab on the Project details page
	And User clicks the "CREATE OVERRIDE DATE" Action button
	Then Create Override Date is displayed correctly
	Then "CREATE" Action button have tooltip with "Some settings are not valid" text
	And "CREATE" Action button is disabled
	When User enters '29 Oct 2018' text to 'Override Start Date' datepicker
	Then "CREATE" Action button have tooltip with "Some settings are not valid" text
	Then "CREATE" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some settings are not valid" text
	When User enters '29 Oct 2018' text to 'Override End Date' datepicker
	Then "CREATE" Action button is active
	When User selects 'SlotDAS13779' in the 'Slot' dropdown
	And User enters "0" value in the "Capacity" field
	And User clicks the "CREATE" Action button
	And User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters '29 Oct 2018' text to 'Override Start Date' datepicker
	And User enters '29 Oct 2018' text to 'Override End Date' datepicker
	And User selects 'SlotDAS13779' in the 'Slot' dropdown
	And User enters "0" value in the "Capacity" field
	And User clicks the "CREATE" Action button
	Then Error message with "An override already exists for this date" text is displayed
	And "1" rows label displays in Action panel
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Override_Dates @DAS13442 @DAS13440 @DAS17418 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForOneSlot
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13442 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project         | SlotName  | DisplayName |
	| ProjectDAS13442 | Slot13442 | 13442       |
	And User navigates to newly created Slot
	And User clicks "Capacity" tab
	And User selects "Override Dates" tab on the Project details page
	And User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters '1 Sep 2018' text to 'Override Start Date' datepicker
	And User enters '7 Sep 2018' text to 'Override End Date' datepicker
	And User selects 'Slot13442' in the 'Slot' dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your override date has been created" text
	When User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters '5 Sep 2018' text to 'Override Start Date' datepicker
	And User enters '10 Sep 2018' text to 'Override End Date' datepicker
	And User selects 'Slot13442' in the 'Slot' dropdown
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
	Then 'Pre-Migration \ Scheduled date' value is displayed in the 'Tasks' dropdown
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                  |
	| Personal Mailbox       |
	| Public Folder          |
	| Shared Mailbox         |
	| Personal Mailbox - VIP |
	| Personal Mailbox - EA  |
	When User selects 'User' in the 'Object Type' dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items         |
	| Standard User |
	| VIP User      |
	When User selects 'Application' in the 'Object Type' dropdown
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
	Then 'Pre-Migration \ Scheduled Date' value is displayed in the 'Tasks' dropdown
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                                            |
	| [This is the Default Request Type for Computer)] |
	| Computer: PC Rebuild                             |
	| Computer: Workstation Replacement                |
	| Computer: Laptop Replacement                     |
	| Computer: Virtual Machine                        |
	When User selects 'User' in the 'Object Type' dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items            |
	| [Default (User)] |
	| User: No Agent   |
	| User: VIP        |
	| User; Maternity  |
	When User selects 'Application' in the 'Object Type' dropdown
	Then "" content is displayed in "Tasks" field
	When User clicks on "Paths" dropdown on the Capacity Slots page
	Then following items are displayed in the dropdown:
	| Items                       |
	| [Default (Application)]     |
	| Application: Request Type A |
	| Application: Request Type B |