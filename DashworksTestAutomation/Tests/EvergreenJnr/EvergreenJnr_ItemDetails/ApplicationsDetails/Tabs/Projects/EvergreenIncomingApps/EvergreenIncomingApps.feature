﻿Feature: EvergreenIncomingApps
	Runs related tests for Evergreen Incoming Apps tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI. 2/14/20: need to wait for gold data in March
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19242 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatTableOnEvergreenIncomingAppsTabIsDisplayedCorrectly
	When User navigates to the 'Application' details page for the item with '1' ID
	Then Details page for 'Python 2.2a4' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Evergreen Incoming Apps' left submenu item
	Then 'Evergreen Incoming Apps' left submenu item with '4' count is displayed
	Then Counter shows "4" found rows
	Then following columns are displayed on the Item details page:
	| ColumnName          |
	| Application         |
	| Vendor              |
	| Version             |
	| Compliance          |
	| In Catalog          |
	| Criticality         |
	| Hide From End Users |