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
	When User selects 'Update capacity unit' in the 'Bulk Update Type' dropdown
	Then Star button is disabled
	Then Star button has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'CANCEL' button is not disabled
	When User selects '<Project>' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button is disabled
	Then Star button is not disabled
	Then Star button has tooltip with 'Save as Favourite Bulk Update Type' text
	When User selects '<CapacityUnit>' option from 'Capacity Unit' autocomplete
	Then 'UPDATE' button is not disabled
	Then Star button is not disabled
	Then Star button has tooltip with 'Save as Favourite Bulk Update Type' text

	Examples: 
	| PageName     | ColumnHeader  | RowName                          | Project              | CapacityUnit  |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  | Evergreen            | London - City |
	| Users        | Username      | 002B5DC7D4D34D5C895              | 2004 Rollout         | Birmingham    |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Evergreen            | Unassigned    |
	| Applications | Application   | 20040610sqlserverck              | Barry's User Project | Unassigned    |