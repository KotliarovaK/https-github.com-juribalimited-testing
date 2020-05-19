Feature: FBU_UpdateRing
	Runs Favourite Bulk Update Update Capacity Unit related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20992 @Yellow_Dwarf
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateValidationsUpdateRingForAllListsType
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update ring' in the 'Bulk Update Type' dropdown
	Then 'star' mat-icon is disabled
	Then 'star' mat-icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'CANCEL' button is not disabled
	When User selects '<Project>' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat-icon is not disabled
	Then 'star' mat-icon is not disabled
	Then 'star' mat-icon has tooltip with 'Save as Favourite Bulk Update' text
	When User selects '<RingName>' option from 'Ring' autocomplete
	Then 'UPDATE' button is not disabled
	Then 'star' mat-icon is not disabled
	Then 'star' mat-icon has tooltip with 'Save as Favourite Bulk Update' text

	Examples: 
	| PageName     | ColumnHeader  | RowName                          | Project              | RingName         |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  | Evergreen            | Evergreen Ring 1 |
	| Users        | Username      | 002B5DC7D4D34D5C895              | Barry's User Project | Unassigned       |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Evergreen            | Unassigned       |

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21000 @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdatePopupWindowForUpdateRing
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update ring' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	When User selects 'Owned devices only' in the 'Also Move Devices' dropdown
	When User selects 'All linked mailboxes' in the 'Also Move Mailboxes' dropdown
	When User clicks 'star' mat-icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This favourite bulk update will be created with the following parameters:' text is displayed on popup
	Then following fields are displayed in the popup:
	| Fields               |
	| Bulk Update Type     |
	| Project or Evergreen |
	| Ring                 |
	| Also Move Devices    |
	| Also Move Mailboxes  |
	Then User compares data in the fields in the popup:
	| Field                | Data                 |
	| Bulk Update Type     | Update ring          |
	| Project or Evergreen | Evergreen            |
	| Ring                 | Unassigned           |
	| Also Move Devices    | Owned devices only   |
	| Also Move Mailboxes  | All linked mailboxes |
	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'Favourite bulk update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '21000_RingFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat-icon
	When User enters '21000_RingFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'Favourite Bulk Update Name should be unique' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllMailboxes @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21002 @Yellow_Dwarf
Scenario: EvergreenJnr_AllMailboxes_CheckValueAndIconsForFavouriteBulkUpdateItemsRings
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update ring' in the 'Bulk Update Type' dropdown
	When User selects 'Email Migration' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	When User clicks 'star' mat-icon
	Then following fields are displayed in the popup:
	| Fields               |
	| Bulk Update Type     |
	| Project or Evergreen |
	| Ring                 |
	Then User compares data in the fields in the popup:
	| Field                | Data                 |
	| Bulk Update Type     | Update ring          |
	| Project or Evergreen | Evergreen            |
	| Ring                 | Unassigned           |
	When User enters '21002_RingFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat-icon
	When User enters 'Test21002_RingFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat-icon
	When User enters 'test21002_RingFBU1' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat-icon
	When User enters 'abc_21002_RingFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	Then following items have 'star' icon in the 'Bulk Update Type' dropdown:
	| Items              |
	| 21002_RingFBU      |
	| abc_21002_RingFBU  |
	| Test21002_RingFBU  |
	| test21002_RingFBU1 |
	Then created items for 'Bulk Update Type' dropdown are displayed in ascending order

@Evergreen @AllMailboxes @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21002 @Yellow_Dwarf
Scenario: EvergreenJnr_AllMailboxes_CheckValueInActionPanelForFavouriteBulkUpdateItemsRings
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update ring' in the 'Bulk Update Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete

	When User clicks 'star' mat-icon
	When User enters '21002_RingFBU1' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	#Check Action panel values
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '21002_RingFBU1' in the 'Bulk Update Type' dropdown
	Then '19083_Project' content is displayed in 'Project or Evergreen' autocomplete

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21002 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllDevices_CheckSelectedValueForUpdateRingFbuForDeletedRing
	When Project created via API and opened
	| ProjectName       | Scope       | ProjectTemplate | Mode               |
	| 21002_RingProject | All Devices | None            | Standalone Project |
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
	When User navigates to the 'Rings' left menu item
	When User clicks 'CREATE PROJECT RING' button 
	When User enters '21002_Ring' text to 'Ring name' textbox
	When User clicks 'CREATE' button
	Then 'The ring has been created' text is displayed on inline success banner
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update ring' in the 'Bulk Update Type' dropdown
	When User selects '21002_RingProject' option from 'Project or Evergreen' autocomplete
	When User selects '21002_Ring' option from 'Ring' autocomplete
	When User clicks 'star' mat-icon
	When User enters '21002_FBU_Ring' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	#Delete Ring
	When User clicks 'Admin' on the left-hand menu
	When User enters "21002_RingProject" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| 21002_Ring       |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected ring has been deleted' text is displayed on inline success banner
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '21002_FBU_Ring' in the 'Bulk Update Type' dropdown
	Then '21002_RingProject' content is displayed in 'Project or Evergreen' autocomplete
	Then '[Ring not found]' content is displayed in 'Ring' autocomplete
	Then 'The selected ring cannot be found' error message is displayed for 'Ring' field
	When User clicks 'star' mat-icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then User compares data in the fields in the popup:
	| Field | Data             |
	| Ring  | [Ring not found] |