Feature: PivotPart12
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS14206 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnCreatedList
	When User clicks 'Users' on the left-hand menu
	When User clicks on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "Dynamic_List_DAS14206" name on "Users" page
	Then "Dynamic_List_DAS14206" list is displayed to user
	When User navigates to the "All Users" list
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	When User selects the following Values on Pivot:
	| Values   |
	| Building |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS_14206" name
	Then "PivotList_DAS_14206" list is displayed to user
	When User navigates to the "Dynamic_List_DAS14206" list
	Then "Dynamic_List_DAS14206" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	Then 'ADD ROW GROUP' button is not disabled
	Then 'ADD COLUMN' button is not disabled
	Then 'ADD VALUE' button is not disabled
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	When User selects the following Values on Pivot:
	| Values   |
	| Building |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User clicks 'SAVE' button and select 'SAVE AS NEW PIVOT' menu button
	Then Pivot Name field is empty

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14413
Scenario: EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnResetButton
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	Then reset button on main panel is displayed
	When User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	| Description |
	Then reset button on main panel is displayed
	When User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	Then reset button on main panel is displayed
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User removes "City" Column for Pivot
	When User adds the following "Columns" on Pivot: 
	| Value      |
	| Owner City |
	When User clicks reset button on main panel
	Then 'ADD ROW GROUP' button is not disabled
	Then 'ADD COLUMN' button is not disabled
	Then 'ADD VALUE' button is not disabled

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14379 @DAS11291 @DAS14745 @DAS16399 @DAS18912
Scenario: EvergreenJnr_DevicesList_ChecksTooltipsOnPivot
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User clicks 'ADD ROW GROUP' button 
	When "Compliance" value is entered into the search box and the selection is clicked on Pivot
	Then 'DONE' button has tooltip with 'Confirm changes' text
	Then back button on Pivot panel have tooltip with "Close" text
	When User clicks 'DONE' button 
	When User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	When User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then "Row Groups" plus button have tooltip with "Add row group" text
	Then "Columns" plus button have tooltip with "Add column" text
	Then "Values" plus button have tooltip with "Add value" text
	Then close button for "Compliance" chip have tooltip with "Delete this item" text
	Then "City" chip have tooltip with "" text