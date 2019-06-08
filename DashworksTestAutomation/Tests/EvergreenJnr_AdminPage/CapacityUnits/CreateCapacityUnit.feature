﻿Feature: CreateCapacityUnit
	Create Capacity Unit

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12632 @DAS13626 @DAS14236 @Delete_Newly_Created_Capacity_Unit
Scenario: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCreatedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE EVERGREEN CAPACITY UNIT" Action button
	And User type "NotDefaultCapacityUnit13720" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13720" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the NotDefaultCapacityUnit13720 capacity unit" link
	Then There are no errors in the browser console
	And "NotDefaultCapacityUnit13720" text is displayed in the table content
	When User enters "NotDefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	Then "FALSE" value is displayed for Default column
	And "0" content is displayed in "Devices" column
	And "0" content is displayed in "Users" column
	And "0" content is displayed in "Mailboxes" column
	And "0" content is displayed in "Applications" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName            |
	| NotDefaultCapacityUnit13720 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "This unit will be permanently deleted and any objects within it reassigned to the default unit" text is displayed on the Admin page
	Then Delete and Cancel buttons are available in the warning message
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected unit has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12632 @Delete_Newly_Created_Capacity_Unit @Do_Not_Run_With_CapacityUnits @Save_Default_Capacity_Unit @Set_Default_Capacity_Unit
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitsCreatedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Capacity Unit via api
	| Name                     | Description | IsDefault |
	| DefaultCapacityUnit13720 | 13720       | true      |
	And User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	Then "DefaultCapacityUnit13720" text is displayed in the table content
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	Then "TRUE" value is displayed for Default column
	And "0" content is displayed in "Devices" column
	And "0" content is displayed in "Users" column
	And "0" content is displayed in "Mailboxes" column
	And "0" content is displayed in "Applications" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "FALSE" value is displayed for Default column
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName         |
	| DefaultCapacityUnit13720 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "You cannot delete the default unit" text is displayed on the Admin page
	When User close message on the Admin page
	Then "DefaultCapacityUnit13720" text is displayed in the table content
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	Then "Default Unit" checkbox is checked and cannot be unchecked

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS13013 @DAS12926 @Delete_Newly_Created_Capacity_Unit
Scenario: EvergreenJnr_AdminPage_ChecksThatMessageAppearsWhenUserCreatesUnitWithTheSameNameInDifferentCase
	When User clicks Admin on the left-hand menu
	And User creates new Capacity Unit via api
	| Name                  | Description           | IsDefault |
	| SameNameCaseSensative | SameNameCaseSensative | false     |
	And User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	When User clicks the "CREATE EVERGREEN CAPACITY UNIT" Action button
	And User type "samenamecaseSensative" Name in the "Capacity Unit Name" field on the Project details page
	And User type "SameNameCaseSensative" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity unit already exists with this name" text is displayed
	And There are no errors in the browser console