Feature: Pivot
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS14224
Scenario: EvergreenJnr_ApplicationsList_ChecksThatPivotsAreNotShownInTheListToSelectAsAnAdvancedFilter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to Pivot
	And User adds the following Row Groups:
	| RowGroups  |
	| Compliance |
	And User adds the following Columns:
	| Columns     |
	| Application |
	And User adds the following Values:
	| Values |
	| Vendor |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "Pivot_Saved_List_14224" name
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	When user select "Application (Saved List)" filter
	Then "Pivot_Saved_List_14224" list is not displayed for Saved List filter
	Then User remove list with "Pivot_Saved_List_14224" name on "Applications" page

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS14224
Scenario: EvergreenJnr_ApplicationsList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChangesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User adds the following Row Groups:
	| RowGroups  |
	| Compliance |
	And User adds the following Columns:
	| Columns     |
	| Application |
	And User adds the following Values:
	| Values |
	| Vendor |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "Pivot_DAS_14224" name