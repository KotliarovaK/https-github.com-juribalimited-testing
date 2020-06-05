Feature: FBU_UpdateCustomField
	Runs Favourite Bulk Update Update Custom Field related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20848 @Yellow_Dwarf
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateValidationsUpdateUpdateCustomFieldForAllListsType
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	Then 'star' mat icon is disabled
	Then 'star' mat icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'CANCEL' button is not disabled
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text

	Examples: 
	| PageName     | ColumnHeader  | RowName                          |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  |
	| Users        | Username      | 002B5DC7D4D34D5C895              |
	| Applications | Application   | 20040610sqlserverck              |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local |

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20850 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdateUpdateCustomFieldLoadingAndRestoringValues
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds 'test' value from 'Value' textbox
	Then 'UPDATE' button is not disabled
	When User clicks 'star' mat icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This Favourite Bulk Update will be created with the following parameters:' text is displayed on popup
	Then following data is displayed in the '0' column of the table
	| Fields           |
	| Bulk Update Type |
	| Custom Field     |
	| Update Values    |
	| Value            |
	Then User compares data in the fields from the table:
	| Field            | Data                   |
	| Bulk Update Type | Update custom field    |
	| Custom Field     | Phoenix Field          |
	| Update Values    | Remove specific values |
	| Value            | test                   |
	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '20853_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User clicks 'star' mat icon
	When User enters '20853_TestFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update with this name already exists' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20853 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckValueAndIconsForUpdateCustomFieldFavouriteBulkUpdateItems
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Add to existing values' in the 'Update Values' dropdown
	When User adds 'test' value from 'Value' textbox
	When User clicks 'star' mat icon
	When User enters 'DAS20853_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters '1DAS20853_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'testFBU_2085' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'abc_22085' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	Then following items have 'star' icon in the 'Bulk Update Type' dropdown:
	| Items             |
	| DAS20853_TestFBU  |
	| 1DAS20853_TestFBU |
	| testFBU_2085      |
	| abc_22085         |
	Then items with 'star' icon for 'Bulk Update Type' dropdown are displayed in ascending order

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20853 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllDevices_CheckSelectedValueForCreatedFavouriteBulkUpdateUpdateCustomFieldType
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects 'Phoenix Field' option from 'Custom Field' autocomplete
	When User selects 'Replace single value' in the 'Update Values' dropdown
	When User enters '0' text to 'Find Value' textbox
	When User enters '1' text to 'Replace Value' textbox
	Then 'UPDATE' button is not disabled
	When User clicks 'star' mat icon
	When User enters '208535_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '208535_TestFBU' in the 'Bulk Update Type' dropdown
	Then 'Phoenix Field' content is displayed in 'Custom Field' autocomplete
	Then 'Replace single value' content is displayed in 'Update Values' dropdown
	Then '0' content is displayed in 'Find Value' textbox
	Then '1' content is displayed in 'Replace Value' textbox
	Then 'UPDATE' button is not disabled
	Then 'CANCEL' button is not disabled
	Then 'star' mat icon is not disabled

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20853 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckErrorMessageForCreatedFavouriteBulkUpdateWithoutCustomField
	When User creates new Custom Field via API
	| FieldName | FieldLabel | AllowExternalUpdate | Enabled | Application |
	| DAS20853  | 20853      | true                | true    | true        |
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName  |
	| 7-Zip 16.02 (x64) |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update custom field' in the 'Bulk Update Type' dropdown
	When User selects '20853' option from 'Custom Field' autocomplete
	When User selects 'Remove specific values' in the 'Update Values' dropdown
	When User adds '12' value from 'Value' textbox
	When User clicks 'star' mat icon
	When User enters '208535_TestFBU_CF' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User removes Custom Field with '20853' label
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName  |
	| 7-Zip 16.02 (x64) |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '208535_TestFBU_CF' in the 'Bulk Update Type' dropdown
	Then 'This Favourite Bulk Update is invalid' text is displayed on inline error banner
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is disabled

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20853 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdatesPopupForUpdateCustomFieldType
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User clicks 'star' mat icon
	When User enters '207741_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects 'Email Migration' option from 'Project' autocomplete
	When User clicks 'star' mat icon
	When User enters '207742_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '207742_TestFBU' in the 'Bulk Update Type' dropdown
	When User selects 'Manage favourites' in the 'Bulk Update Type' dropdown
	Then popup with 'Favourite Bulk Updates' title is displayed
	Then 'star207742_TestFBU' content is displayed in 'Bulk Update Type' dropdown
	When User clicks Group By button and set checkboxes state
	| Checkboxes  | State |
	| Object Type | true  |
	Then Cog menu is not displayed on the Admin page
	And Grid is grouped
	When User expands 'Devices' row in the groped grid
	Then "207741_TestFBU" content is displayed for "Name" column