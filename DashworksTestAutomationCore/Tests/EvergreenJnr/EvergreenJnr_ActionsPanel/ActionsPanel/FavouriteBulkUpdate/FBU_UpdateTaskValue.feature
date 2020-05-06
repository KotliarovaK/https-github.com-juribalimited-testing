Feature: FBU_UpdateTaskValue
	Runs Favourite Bulk Update Update Task Value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20937 @X_Ray
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateUpdateTaskValueTypeValidations
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	Then Star button is disabled
	Then Star button has tooltip with 'Some values are missing or not valid' text
	When User selects '<ProjectName>' option from 'Project' autocomplete
	Then Star button is disabled
	Then Star button has tooltip with 'Some values are missing or not valid' text
	When User selects '<Task>' option from 'Task' autocomplete
	Then Star button is not disabled
	Then Star button has tooltip with 'Save as Favourite Bulk Update Type' text
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text

Examples: 
	| PageName     | ColumnHeader  | RowName                          | ProjectName     | Task                                  |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  | 2004 Rollout    | Pre-Migration \ Device Priority       |
	| Users        | Username      | 002B5DC7D4D34D5C895              | 2004 Rollout    | Pre-Migration \ User Workflow         |
	| Applications | Application   | 20040610sqlserverck              | 2004 Rollout    | Pre-Migration \ App Workflow          |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Email Migration | Mobile Devices \ Mobile Device Status |

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20940 @X_Ray
Scenario: EvergreenJnr_AllUsers_CheckCreateFavouriteBulkUpdatePopupWindowValidationsFotUsersList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 2 \ Weekdays Task' option from 'Task' autocomplete
	When User clicks Star button
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This favourite bulk update will be created with the following parameters:' text is displayed on popup
	Then following fields are displayed in the popup:
	| Fields           |
	| Bulk Update Type |
	| Project          |
	| Task             |
	Then User compares data in the fields in the popup:
	| Field            | Data                              |
	| Bulk Update Type | Update task value                 |
	| Project          | zUser Sch for Automations Feature |
	| Task             | Stage 2 \ Weekdays Task           |
	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'Favourite bulk update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '20940_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 2 \ Weekdays Task' option from 'Task' autocomplete
	When User clicks Star button
	When User enters '20940_TestFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'Favourite Bulk Update Name should be unique' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20950 @X_Ray
Scenario: EvergreenJnr_AllUsers_CheckValueAndIconsForFavouriteBulkUpdateItemsUpdateTaskValueType
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 1 \ Dropdown Task' option from 'Task' autocomplete
	When User clicks Star button
	When User enters '20950_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks Star button
	When User enters 'TestFBU_20950' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks Star button
	When User enters 'testFBU_209501' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks Star button
	When User enters 'abc_20950' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	Then following items have star icon in the 'Bulk Update Type' dropdown:
	| Items          |
	| 20950_TestFBU  |
	| TestFBU_20950  |
	| testFBU_209501 |
	| abc_20950      |
	Then Favourite Bulk Update items are displayed in ascending order