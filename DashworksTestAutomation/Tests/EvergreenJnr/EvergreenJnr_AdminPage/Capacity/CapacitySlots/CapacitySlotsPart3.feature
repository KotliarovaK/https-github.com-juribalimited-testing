Feature: CapacitySlotsPart3
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13779 @DAS14176 @DAS14177 @DAS18894 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatErrorMessageAppearsWhenCreatingDuplicateOverrideDate
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13779 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project         | SlotName     | DisplayName | SlotAvailableFrom | SlotAvailableTo |
	| ProjectDAS13779 | SlotDAS13779 | 13779       | 29 Oct 2018       | 29 Oct 2018     |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Override Dates' left menu item
	And User clicks 'CREATE OVERRIDE DATE' button 
	Then Create Override Date is displayed correctly
	Then 'CREATE' button has tooltip with 'Some settings are not valid' text
	And 'CREATE' button is disabled
	When User enters '29 Oct 2018' text to 'Override Start Date' datepicker
	Then 'CREATE' button has tooltip with 'Some settings are not valid' text
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some settings are not valid' text
	When User enters '29 Oct 2018' text to 'Override End Date' datepicker
	Then 'CREATE' button is disabled
	When User selects 'SlotDAS13779' in the 'Slot' dropdown
	And User enters '0' text to 'Capacity' textbox
	And User clicks 'CREATE' button 
	And User clicks 'CREATE OVERRIDE DATE' button 
	And User enters '29 Oct 2018' text to 'Override Start Date' datepicker
	And User enters '29 Oct 2018' text to 'Override End Date' datepicker
	And User selects 'SlotDAS13779' in the 'Slot' dropdown
	And User enters '0' text to 'Capacity' textbox
	Then 'CREATE' button is disabled
	Then 'An override date already exists with this date range' error message is displayed for 'Override Start Date' field
	Then 'An override date already exists with this date range' error message is displayed for 'Override End Date' field
	And There are no errors in the browser console
	When User clicks 'CANCEL' button
	Then User sees "1" rows in grid
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Override_Dates @DAS13442 @DAS13440 @DAS17418 @DAS18894 @DAS19265 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorInConsoleAfterSettingSameOverrideDatesForOneSlot
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| ProjectDAS13442 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project         | SlotName  | DisplayName |
	| ProjectDAS13442 | Slot13442 | 13442       |
	And User navigates to newly created Slot
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Override Dates' left menu item
	And User clicks 'CREATE OVERRIDE DATE' button 
	And User enters '1 Sep 2018' text to 'Override Start Date' datepicker
	And User enters '7 Sep 2018' text to 'Override End Date' datepicker
	Then 'CREATE' button is disabled
	When User selects 'Slot13442' in the 'Slot' dropdown
	And User clicks 'CREATE' button 
	Then 'Your override date has been created' text is displayed on inline success banner
	When User clicks 'CREATE OVERRIDE DATE' button 
	And User enters '5 Sep 2018' text to 'Override Start Date' datepicker
	And User enters '10 Sep 2018' text to 'Override End Date' datepicker
	And User selects 'Slot13442' in the 'Slot' dropdown
	Then 'CREATE' button is disabled
	Then 'An override date already exists with this date range' error message is displayed for 'Override Start Date' field
	Then 'An override date already exists with this date range' error message is displayed for 'Override End Date' field
	And There are no errors in the browser console
	When User clicks 'CANCEL' button
	Then There are no errors in the browser console
	When User navigates to the 'Slots' left menu item
	When User select "Capacity Slot" rows in the grid
	| SelectedRowsName |
	| Slot13442        |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then '1 slot and 1 related override date will be deleted, do you wish to proceed?' text is displayed on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13490
Scenario: EvergreenJnr_AdminPage_CheckThat0ValuesAreCorrectlyShownOnTheCapacitySlotsScreen
	When User navigates to "User Scheduled Test (Jo)" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	Then '40' content is displayed in the 'Monday' column
	When User clicks content from "Capacity Slot" column
	And User changes value to "0" for "Monday" column
	And User clicks 'UPDATE' button 
	Then 'The capacity slot details have been updated' text is displayed on inline success banner
	And '0' content is displayed in the 'Monday' column
	When User clicks content from "Capacity Slot" column
	And User changes value to "40" for "Monday" column
	And User clicks 'UPDATE' button 

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13608 @DAS13472
Scenario: EvergreenJnr_AdminPage_CheckRequestTypesDisplayedForEachObjectType
	When User navigates to "Email Migration" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User clicks content from "Capacity Slot" column
	Then only below options are selected in the 'Tasks' autocomplete
	| Options                        |
	| Pre-Migration \ Scheduled date |
	Then 'Paths' autocomplete have following checkbox options
	| options                |
	| Personal Mailbox       |
	| Public Folder          |
	| Shared Mailbox         |
	| Personal Mailbox - VIP |
	| Personal Mailbox - EA  |
	When User selects 'User' in the 'Object Type' dropdown
	Then "" content is displayed in "Tasks" field
	Then 'Paths' autocomplete have following checkbox options
	| Items         |
	| Standard User |
	| VIP User      |
	When User selects 'Application' in the 'Object Type' dropdown
	Then "" content is displayed in "Tasks" field
	Then 'Paths' autocomplete have following checkbox options
	| Items                  |
	| Public Folder          |
	| Sharepoint Application |
	When User clicks 'Projects' header breadcrumb
	When User clicks 'YES' button on popup
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User clicks content from "Capacity Slot" column
	Then only below options are selected in the 'Tasks' autocomplete
	| Options                        |
	| Pre-Migration \ Scheduled Date |
	Then 'Paths' autocomplete have following checkbox options
	| Items                                            |
	| [This is the Default Request Type for Computer)] |
	| Computer: PC Rebuild                             |
	| Computer: Workstation Replacement                |
	| Computer: Laptop Replacement                     |
	| Computer: Virtual Machine                        |
	When User selects 'User' in the 'Object Type' dropdown
	Then "" content is displayed in "Tasks" field
	Then 'Paths' autocomplete have following checkbox options
	| Items            |
	| [Default (User)] |
	| User: No Agent   |
	| User: VIP        |
	| User; Maternity  |
	When User selects 'Application' in the 'Object Type' dropdown
	Then "" content is displayed in "Tasks" field
	Then 'Paths' autocomplete have following checkbox options
	| Items                       |
	| [Default (Application)]     |
	| Application: Request Type A |
	| Application: Request Type B |