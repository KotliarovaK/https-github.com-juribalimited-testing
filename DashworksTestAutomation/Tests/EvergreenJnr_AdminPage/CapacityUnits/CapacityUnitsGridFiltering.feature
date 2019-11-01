﻿Feature: CapacityUnitsGridFiltering
	Capacity Units Grid Filtering

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS13017
Scenario: EvergreenJnr_AdminPage_CheckThatListCanBeFilteredSortedByDefaultColumn
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	When User clicks String Filter button for "Default" column on the Admin page
	And User clicks "True" checkbox from boolean filter on the Admin page
	Then 'FALSE' content is displayed in the 'Default' column
	When User clicks Refresh button on the Admin page
	Then Page with 'Capacity Units' header is displayed to user
	When User clicks String Filter button for "Default" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	Then 'TRUE' content is displayed in the 'Default' column
	When User clicks Refresh button on the Admin page
	Then Page with 'Capacity Units' header is displayed to user
	When User clicks on 'Default' column header
	Then Boolean data in table is sorted by "Default" column in ascending order on the Admin page
	When User clicks on 'Default' column header
	Then Boolean data in table is sorted by "Default" column in descending order on the Admin page