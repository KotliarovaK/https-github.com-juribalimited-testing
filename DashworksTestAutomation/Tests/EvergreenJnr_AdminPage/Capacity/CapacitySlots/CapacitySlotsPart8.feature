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
	And User creates Task
	| Name      | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| Task13152 | 13152 | Stage13152       | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "ProjectForDAS13152" project details
	And User creates new Slot via Api
	| Project            | SlotName  | DisplayName | CapacityType   | Tasks                  | CapacityUnits |
	| ProjectForDAS13152 | Slot13152 | 13152       | Capacity Units | Stage13152 \ Task13152 | Unassigned    |
	And User navigates to the 'Capacity' left menu item
	And User selects "Slots" tab on the Project details page
	When User clicks content from "Capacity Slot" column
	Then 'Stage13152 \ Task13152' value is displayed in the 'Tasks' dropdown
	And 'Unassigned' value is displayed in the 'Capacity Units' dropdown
	And 'Device' content is displayed in 'Object Type' dropdown
	When User selects 'Application' in the 'Object Type' dropdown
	And User selects "Unassigned" checkbox in the "Capacity Units" field on the Project details page
	And User clicks 'UPDATE' button 
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	When User clicks content from "Capacity Slot" column
	Then "" content is displayed in "Tasks" field
	Then "All Capacity Units" content is displayed in "Capacity Units" field
	And 'Application' content is displayed in 'Object Type' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @Senior_Projects @DAS13152 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSlotsValueAreChangedAfterUpdatingForTeamsAndRequestTypes
	When User clicks 'Projects' on the left-hand menu
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
	And User creates Task
	| Name      | Help       | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Task13152 | 13152 Date | Stage13152       | Normal         | Date            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "ProjectForDAS13152" project details
	And User navigates to the 'Capacity' left menu item
	And User selects "Slots" tab on the Project details page
	And User clicks 'CREATE SLOT' button 
	And User enters 'Slot13152' text to 'Slot Name' textbox
	And User enters '13152' text to 'Display Name' textbox
	And User selects 'Teams and Paths' in the 'Capacity Type' dropdown
	And User selects "Stage13152 \ Task13152" checkbox in the "Tasks" field on the Project details page
	And User selects "Admin IT" checkbox in the "Teams" field on the Project details page
	And User selects "[Default (Computer)]" checkbox in the "Paths" field on the Project details page
	When User selects 'Device' in the 'Object Type' dropdown
	And User clicks 'CREATE' button 
	Then Success message is displayed and contains "Your capacity slot has been created" text
	#Check data in the slot after creation
	When User clicks content from "Capacity Slot" column
	Then 'Teams and Paths' value is displayed in the 'Capacity Type' dropdown
	And 'Stage13152 \ Task13152' value is displayed in the 'Tasks' dropdown
	And 'Device' content is displayed in 'Object Type' dropdown
	And '[Default (Computer)]' value is displayed in the 'Paths' dropdown
	And 'Admin IT' value is displayed in the 'Teams' dropdown
	#Change data in the slot
	When User selects 'Application' in the 'Object Type' dropdown
	And User selects "Admin IT" checkbox in the "Teams" field on the Project details page
	And User selects "1803 Team" checkbox in the "Teams" field on the Project details page
	And User selects "[Default (Application)]" checkbox in the "Paths" field on the Project details page
	And User clicks 'UPDATE' button 
	Then Success message is displayed and contains "The capacity slot details have been updated" text
	#Check updated data in the slot and change Capacity Type
	When User clicks content from "Capacity Slot" column
	Then 'Teams and Paths' content is displayed in 'Capacity Type' dropdown
	And 'Application' content is displayed in 'Object Type' dropdown
	And '[Default (Application)]' value is displayed in the 'Paths' dropdown
	And '1803 Team' value is displayed in the 'Teams' dropdown
	When User selects 'Capacity Units' in the 'Capacity Type' dropdown
	And User clicks 'UPDATE' button 
	#Check updated Capacity Type value
	When User clicks content from "Capacity Slot" column
	Then 'Capacity Units' content is displayed in 'Capacity Type' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967 @DAS15291
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfUserProjectLeadToCorrectFilteredLists
	When User navigates to "User Evergreen Capacity Project" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967 @DAS15291
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfMailProjectLeadToCorrectFilteredLists
	When User navigates to "Mailbox Evergreen Capacity Project" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
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