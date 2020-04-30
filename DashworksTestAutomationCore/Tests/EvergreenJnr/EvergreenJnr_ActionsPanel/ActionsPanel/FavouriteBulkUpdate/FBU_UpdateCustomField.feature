Feature: FBU_UpdateCustomField
	Runs Favourite Bulk Update Update Custom Field related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS20771 @X_Ray
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateUpdateUpdateCustomFieldForAllListsType
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	Then Star button is disabled
	Then Star button has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	When User selects '<ProjectName>' option from 'Project' autocomplete
	Then 'UPDATE' button is disabled
	Then Star button is not disabled
	Then Star button has tooltip with 'Save as Favourite Bulk Update Type' text
	When User selects '<PathName>' option from 'Path' autocomplete
	Then 'UPDATE' button is not disabled
	Then Star button has tooltip with 'Save as Favourite Bulk Update Type' text

	Examples: 
	| PageName     | ColumnHeader  | RowName                          | ProjectName     | PathName                |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  | 2004 Rollout    | Zero Touch              |
	| Users        | Username      | 002B5DC7D4D34D5C895              | 2004 Rollout    | VIP User                |
	| Applications | Application   | 20040610sqlserverck              | 2004 Rollout    | [Default (Application)] |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Email Migration | Public Folder           |
