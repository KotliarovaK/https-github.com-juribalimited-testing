Feature: CapacityPart1
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13720 @DAS13431 @DAS13162 @DAS14037 @DAS15823 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrors
	When Project created via API and opened
	| ProjectName             | Scope     | ProjectTemplate | Mode               |
	| ProjectForCapacity13720 | All Users | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	Then 'Capacity Units' content is displayed in 'Capacity Mode' dropdown
	When User navigates to the 'Units' left menu item
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then Rows counter shows "1" of "1" rows
	When User clicks content from "Capacity Unit" column
	And User enters 'Default Capacity Unit' text to 'Capacity Unit Name' textbox
	And User clicks 'UPDATE' button 
	Then 'The capacity unit details have been updated' text is displayed on inline success banner
	And grid headers are displayed in the following order
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
Scenario: EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnits
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| 13431DevicesProject | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	Then grid headers are displayed in the following order
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
	And User navigates to the 'Units' left menu item
	Then grid headers are displayed in the following order
	| ColumnName    |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Users         |
	| Mailboxes     |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13723 @DAS13370 @DAS18646 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumn
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacity13723 | All Devices | None            | Standalone Project |
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Override Dates' left menu item
	When User clicks 'CREATE OVERRIDE DATE' button 
	When User enters '5 Jan 2019' text to 'Override Start Date' datepicker
	When User clears 'Override End Date' textbox with backspaces
	Then 'An override end date must be entered' error message is displayed for 'Override End Date' field
	When User enters '4 Oct 2018' text to 'Override End Date' datepicker
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some settings are not valid' text
	When User clears 'Override Start Date' textbox with backspaces
	Then 'An override start date must be entered' error message is displayed for 'Override Start Date' field
	When User enters '4 Oct 2018' text to 'Override Start Date' datepicker
	When User enters '7 Oct 2018' text to 'Override End Date' datepicker
	When User selects 'All' in the 'Slot' dropdown
	When User clicks 'CREATE' button
	Then 'Your override date has been created' text is displayed on inline success banner
	Then 'Unlimited' content is displayed in the 'Capacity' column
	When User enters ">1" text in the Search field for "Capacity" column
	Then Rows counter shows "1" of "1" rows
	When User clicks content from "Start Date" column
	When User enters '3 Oct 2018' text to 'Override End Date' datepicker
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters '' text to 'Override Start Date' datepicker
	When User enters '' text to 'Override End Date' datepicker
	Then 'An override end date must be entered' error message is displayed for 'Override End Date' field
	Then 'An override start date must be entered' error message is displayed for 'Override Start Date' field
	When User enters '5 Oct 2019' text to 'Override Start Date' datepicker
	When User enters '5 Oct 2019' text to 'Override End Date' datepicker
	When User clicks 'UPDATE' button
	Then 'The override date details have been updated' text is displayed on inline success banner