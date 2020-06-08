Feature: FBU_UpdateCapacityUnit
	Runs Favourite Bulk Update Update Capacity Unit related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20992 @Yellow_Dwarf
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateValidationsUpdateCapacityUnitForAllListsType
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update capacity unit' option from 'Bulk Update Type' autocomplete
	Then 'star' mat icon is disabled
	Then 'star' mat icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'CANCEL' button is not disabled
	When User selects '<Project>' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text
	When User selects '<CapacityUnit>' option from 'Capacity Unit' autocomplete
	Then 'UPDATE' button is not disabled
	Then 'star' mat icon is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text

	Examples: 
	| PageName     | ColumnHeader  | RowName                          | Project              | CapacityUnit  |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  | Evergreen            | London - City |
	| Users        | Username      | 002B5DC7D4D34D5C895              | 2004 Rollout         | Birmingham    |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Evergreen            | Unassigned    |
	| Applications | Application   | 20040610sqlserverck              | Barry's User Project | Unassigned    |

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21000 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdatePopupWindowForUpdateCapacityUnit
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update capacity unit' option from 'Bulk Update Type' autocomplete
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	When User clicks 'star' mat icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This Favourite Bulk Update will be created with the following parameters:' text is displayed on popup
	Then following data is displayed in the '0' column of the table
	| Fields               |
	| Bulk Update Type     |
	| Project or Evergreen |
	| Capacity Unit        |
	| Also Move Devices    |
	| Also Move Mailboxes  |
	Then User sees table with the following data
	| Field                | Data                 |
	| Bulk Update Type     | Update capacity unit |
	| Project or Evergreen | Evergreen            |
	| Capacity Unit        | Unassigned           |
	| Also Move Devices    | None                 |
	| Also Move Mailboxes  | None                 |
	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '21000_CapacityUnitFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters '21000_CapacityUnitFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update with this name already exists' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllMailboxes @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21002 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllMailboxes_CheckValueAndIconsForFavouriteBulkUpdateItemsCapacityUnit
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update capacity unit' option from 'Bulk Update Type' autocomplete
	When User selects 'Email Migration' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Capacity Unit' autocomplete
	When User clicks 'star' mat icon
	Then following data is displayed in the '0' column of the table
	| Fields               |
	| Bulk Update Type     |
	| Project or Evergreen |
	| Capacity Unit        |
	| Also Move Users      |
	Then User sees table with the following data
	| Field                | Data                 |
	| Bulk Update Type     | Update capacity unit |
	| Project or Evergreen | Email Migration      |
	| Capacity Unit        | Unassigned           |
	| Also Move Users      | None                 |
	When User enters '21002_CapacityUnitFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'Test21002_CapacityUnitFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'test21002_CapacityUnitFBU1' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'abc_21002_CapacityUnitFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	Then following items have 'star' mat icon from 'Bulk Update Type' autocomplete
	| Items                      |
	| 21002_CapacityUnitFBU      |
	| abc_21002_CapacityUnitFBU  |
	| Test21002_CapacityUnitFBU  |
	| test21002_CapacityUnitFBU1 |
	Then items with 'star' mat icon for 'Bulk Update Type' autocomplete are displayed in ascending order

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21002 @Cleanup
Scenario: EvergreenJnr_AllDevices_CheckSelectedValueForUpdateCapacityUnitFbuForDeletedCapacityUnit
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| 210022_CUProject | All Devices | None            | Standalone Project |
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Devices' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects        |
	| 00KLL9S8NRF0X6 |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Units' left menu item
	When User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	And User enters 'CapacityUnit210022' text to 'Capacity Unit Name' textbox
	And User enters '210022' text to 'Description' textbox
	And User clicks 'CREATE' button 
	Then 'The capacity unit has been created' text is displayed on inline success banner
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update capacity unit' option from 'Bulk Update Type' autocomplete
	When User selects '210022_CUProject' option from 'Project or Evergreen' autocomplete
	When User selects 'CapacityUnit210022' option from 'Capacity Unit' autocomplete
	When User clicks 'star' mat icon
	When User enters '21002_FBU_CapacityUnit' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	#Delete Capacity Unit
	When User clicks 'Admin' on the left-hand menu
	When User enters "210022_CUProject" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Units' left menu item
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName   |
	| CapacityUnit210022 |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected unit has been deleted' text is displayed on inline success banner
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '21002_FBU_CapacityUnit' option from 'Bulk Update Type' autocomplete
	Then 'The configuration for this Favourite Bulk Update is no longer valid' text is displayed on inline error banner
	Then '' content is displayed in 'Project or Evergreen' autocomplete