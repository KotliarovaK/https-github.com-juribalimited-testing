Feature: CapacitySlotsPart8
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13152 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForCapacityUnitsType
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName          | ShortName | Description | Type |
	| ProjectForDAS13152_2 | 13152_2   |             |      |
	And User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName    |
	| Stage13152_2 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name        | Help    | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| Task13152_2 | 13152_2 | Stage13152_2     | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "ProjectForDAS13152_2" project details
	And User creates new Slot via Api
	| Project              | SlotName    | DisplayName   | CapacityType   | Tasks                      | CapacityUnits |
	| ProjectForDAS13152_2 | Slot13152_2 | 13152_2       | Capacity Units | Stage13152_2 \ Task13152_2 | Unassigned    |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User clicks content from "Capacity Slot" column
	Then only below options are selected in the 'Tasks' autocomplete
	| Options                    |
	| Stage13152_2 \ Task13152_2 |
	Then only below options are selected in the 'Capacity Units' autocomplete
	| Options    |
	| Unassigned |
	And 'Device' content is displayed in 'Object Type' dropdown
	When User selects 'Application' in the 'Object Type' dropdown
	And User checks 'Unassigned' option after search from 'Capacity Units' autocomplete
	And User clicks 'UPDATE' button
	Then 'The capacity slot details have been updated' text is displayed on inline success banner
	When User clicks content from "Capacity Slot" column
	Then "" content is displayed in "Tasks" field
	Then only below options are selected in the 'Capacity Units' autocomplete
	| Options    |
	| Unassigned |
	And 'Application' content is displayed in 'Object Type' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13152 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndRequestTypes
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName          | ShortName | Description | Type |
	| ProjectForDAS13152_1 | 13152_1   |             |      |
	And User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName    |
	| Stage13152_1 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name        | Help         | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Task13152_1 | 13152_1 Date | Stage13152_1     | Normal         | Date            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "ProjectForDAS13152_1" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User clicks 'CREATE SLOT' button 
	And User enters 'Slot13152_1' text to 'Slot Name' textbox
	And User enters '13152_1' text to 'Display Name' textbox
	And User selects 'Teams and Paths' in the 'Capacity Type' dropdown
	When User checks 'Stage13152_1 \ Task13152_1' option after search from 'Tasks' autocomplete
	And User checks 'Admin IT' option after search from 'Teams' autocomplete
	And User checks '[Default (Computer)]' option after search from 'Paths' autocomplete
	When User selects 'Device' in the 'Object Type' dropdown
	And User clicks 'CREATE' button 
	Then 'Your capacity slot has been created' text is displayed on inline success banner
	#Check data in the slot after creation
	When User clicks content from "Capacity Slot" column
	Then 'Teams and Paths' value is displayed in the 'Capacity Type' dropdown
	Then only below options are selected in the 'Tasks' autocomplete
	| Options                    |
	| Stage13152_1 \ Task13152_1 |
	And 'Device' content is displayed in 'Object Type' dropdown
	Then only below options are selected in the 'Paths' autocomplete
	| Options              |
	| [Default (Computer)] |
	Then only below options are selected in the 'Teams' autocomplete
	| Options  |
	| Admin IT |
	#Change data in the slot
	When User selects 'Application' in the 'Object Type' dropdown
	And User checks 'Admin IT' option after search from 'Teams' autocomplete
	And User checks '2004 Team' option after search from 'Teams' autocomplete
	And User checks '[Default (Application)]' option after search from 'Paths' autocomplete
	And User clicks 'UPDATE' button 
	Then 'The capacity slot details have been updated' text is displayed on inline success banner
	#Check updated data in the slot and change Capacity Type
	When User clicks content from "Capacity Slot" column
	Then 'Teams and Paths' content is displayed in 'Capacity Type' dropdown
	And 'Application' content is displayed in 'Object Type' dropdown
	Then only below options are selected in the 'Paths' autocomplete
	| Options                 |
	| [Default (Application)] |
	| [Default (Computer)]    |
	Then only below options are selected in the 'Teams' autocomplete
	| Options   |
	| 2004 Team |
	| Admin IT  |
	When User selects 'Capacity Units' in the 'Capacity Type' dropdown
	And User clicks 'UPDATE' button 
	#Check updated Capacity Type value
	When User clicks content from "Capacity Slot" column
	Then 'Capacity Units' content is displayed in 'Capacity Type' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967 @DAS15291 @DAS18538 @DAS14967
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfUserProjectLeadToCorrectFilteredLists
	When User navigates to "User Evergreen Capacity Project" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	Then Content in the 'Capacity Slot' column is equal to
	| Content            |
	| User Slot 1        |
	| User Slot 2        |
	| Device Slot 1      |
	| Device Slot 2      |
	| Application Slot 1 |
	| Application Slot 2 |
	When User navigates to the 'Units' left menu item
	And User enters "Evergreen Capacity Unit 3" text in the Search field for "Capacity Unit" column
	And User remembers value in "<ListName>" column
	And User clicks content from "<ListName>" column
	Then 'All <ListName>' list should be displayed to the user
	And Rows counter number equals to remembered value
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "UserEvergr: Capacity Unit" filter is added to the list
	And Values is displayed in added filter info
	| Values                    |
	| Evergreen Capacity Unit 3 |
	And Options is displayed in added filter info
	| Values |
	| is     |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967 @DAS15291 @DAS18538 @DAS14967
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfMailProjectLeadToCorrectFilteredLists
	When User navigates to "Mailbox Evergreen Capacity Project" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	Then Content in the 'Capacity Slot' column is equal to
	| Content                                            |
	| CA -Mailbox-Nov 1, 2018-Nov 10, 2018               |
	| CA -Mailbox-Nov 11, 2018-Nov 30, 2018              |
	| TRT-Mailbox-Nov 11, 2018-Nov 24, 2018\RT=A\T=Admin |
	| TRT-Dec 1, 2018-Dec 31, 2018 - Unlimited           |
	| CA-Mailbox-Jan 1, 2018-Oct 31, 2018                |
	When User navigates to the 'Units' left menu item
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User remembers value in "<ListName>" column
	And User clicks content from "<ListName>" column
	Then 'All <ListName>' list should be displayed to the user
	And Rows counter number equals to remembered value
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "MailboxEve: Capacity Unit" filter is added to the list
	And Values is displayed in added filter info
	| Values     |
	| Unassigned |
	And Options is displayed in added filter info
	| Values |
	| is     |

Examples:
	| ListName  |
	| Users     |
	| Mailboxes |