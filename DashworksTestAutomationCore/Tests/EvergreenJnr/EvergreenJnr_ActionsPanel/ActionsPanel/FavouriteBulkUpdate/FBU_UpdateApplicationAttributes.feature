Feature: FBU_UpdateApplicationAttributes
	Runs Favourite Bulk Update Update Application Attributes related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21005 @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckFavouriteBulkUpdateUpdateApplicationAttributesValidationsForEvergreen
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	Then 'star' mat-icon is disabled
	Then 'star' mat-icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat-icon is not disabled
	Then 'star' mat-icon has tooltip with 'Save as Favourite Bulk Update' text
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'In Catalog' dropdown
	Then 'No change' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Hide From End Users' dropdown
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	Then 'UPDATE' button is not disabled
	Then 'star' mat-icon has tooltip with 'Save as Favourite Bulk Update' text

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21005 @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckFavouriteBulkUpdateUpdateApplicationAttributesValidationsForProject
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' in the 'Bulk Update Type' dropdown
	Then 'star' mat-icon is disabled
	Then 'star' mat-icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat-icon is not disabled
	Then 'star' mat-icon has tooltip with 'Save as Favourite Bulk Update' text
	When User selects 'Core' in the 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Hide From End Users' dropdown
	Then 'UPDATE' button is not disabled
	Then 'star' mat-icon has tooltip with 'Save as Favourite Bulk Update' text