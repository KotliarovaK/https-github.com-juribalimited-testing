Feature: FBU_UpdateTaskValue
	Runs Favourite Bulk Update Update Task Value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20848 @X_Ray
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateUpdateTaskValueType
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid

	Examples: 
	| PageName     | ColumnHeader  | RowName                          |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  |
	| Users        | Username      | 002B5DC7D4D34D5C895              |
	| Applications | Application   | 20040610sqlserverck              |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local |