Feature: CapacityPart1
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13720 @DAS13431 @DAS13162 @DAS14037 @DAS15823 @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrors
	When Project created via API and opened
	| ProjectName             | Scope     | ProjectTemplate | Mode               |
	| ProjectForCapacity13720 | All Users | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	Then 'Capacity Units' content is displayed in 'Capacity Mode' dropdown
	When User selects "Units" tab on the Project details page
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then Counter shows "1" found rows
	When User clicks content from "Capacity Unit" column
	And User enters 'Default Capacity Unit' text to 'Capacity Unit Name' textbox
	And User clicks 'UPDATE' button 
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13431 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnits
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| 13431DevicesProject | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User selects "Units" tab on the Project details page
	Then Columns on Admin page is displayed in following order:
	| ColumnName    |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Devices       |
	| Users         |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13431 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckDefaultColumnsForMailboxesProjectCapacityUnits
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| 13431MailboxesProject | All Mailboxes | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User selects "Units" tab on the Project details page
	Then Columns on Admin page is displayed in following order:
	| ColumnName    |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Users         |
	| Mailboxes     |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13723 @DAS13370 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumn
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacity13723 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User selects "Override Dates" tab on the Project details page
	When User clicks 'CREATE OVERRIDE DATE' button 
	And User enters '5 Jan 2019' text to 'Override Start Date' datepicker
	And User enters '' text to 'Override End Date' datepicker
	Then 'An override end date must be entered' error message is displayed for 'Override End Date' field
	When User enters '4 Oct 2018' text to 'Override End Date' datepicker
	Then "CREATE" Action button is disabled
	Then 'CREATE' Action button has tooltip with 'Some settings are not valid' text
	When User enters '' text to 'Override Start Date' datepicker
	Then 'An override start date must be entered' error message is displayed for 'Override Start Date' field
	When User enters '4 Oct 2018' text to 'Override Start Date' datepicker
	And User enters '7 Oct 2018' text to 'Override End Date' datepicker
	And User clicks 'CREATE' button 
	Then Success message is displayed and contains "Your override date has been created" text
	And "Unlimited" content is displayed in "Capacity" column
	When User enters ">1" text in the Search field for "Capacity" column
	Then Rows counter shows "1" of "1" rows
	When User clicks content from "Start Date" column
	And User enters '3 Oct 2018' text to 'Override End Date' datepicker
	Then "UPDATE" Action button is disabled
	Then 'UPDATE' Action button has tooltip with 'No changes made' text
	When User enters '' text to 'Override Start Date' datepicker
	And User enters '' text to 'Override End Date' datepicker
	Then 'An override end date must be entered' error message is displayed for 'Override End Date' field
	And 'An override start date must be entered' error message is displayed for 'Override Start Date' field
