Feature: EvergreenIncomingApps
	Runs related tests for Evergreen Incoming Apps tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19242
Scenario: EvergreenJnr_ApplicationsList_CheckThatTableOnEvergreenIncomingAppsTabIsDisplayedCorrectly
	When User navigates to the 'Application' details page for the item with '563' ID
	Then Details page for 'Total Access Memo 2003 Runtime' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Evergreen Incoming Apps' left submenu item
	Then 'Evergreen Incoming Apps' left submenu item with '1' count is displayed
	Then Counter shows "1" found rows
	Then following columns are displayed on the Item details page:
	| ColumnName          |
	| Application         |
	| Vendor              |
	| Version             |
	| Compliance          |
	| In Catalog          |
	| Criticality         |
	| Hide From End Users |