Feature: PivotPart2
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14224 @DAS14413 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChangesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	And User selects the following Columns on Pivot:
	| Columns |
	| City    |
	And User selects the following Values on Pivot:
	| Values      |
	| Cost Centre |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "Pivot_DAS_14224" name
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Pivot_Project_14224" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the "Device Scope" tab in the Scope section on the Project details page
	Then following Values are displayed in "Scope" drop-down on the Admin page:
	| Values                                |
	| All Devices                           |
	| 1803 Rollout                          |
	| Dependant List Filter - BROKEN LIST   |
	| Depot Capacity                        |
	| Device List (Complex)                 |
	| Device List (Complex) - BROKEN LIST   |
	| Device Readiness Columns & Filters    |
	| Migration Type Capacity               |
	| New York - Devices                    |
	| Using App Saved List Readiness Filter |
	When User navigates to the "User Scope" tab in the Scope section on the Project details page
	Then following Values are displayed in "User Scope" drop-down on the Admin page:
	| Values                             |
	| All Users                          |
	| Users List (Complex)               |
	| Users List (Complex) - BROKEN LIST |
	| Users Readiness Columns & Filters  |
	| Users with Device Count            |
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then following Values are displayed in "Application Scope" drop-down on the Admin page:
	| Values                                   |
	| All Applications                         |
	| 1803 Apps                                |
	| App Readiness Columns & Filters          |
	| Application List (Complex)               |
	| Application List (Complex) - BROKEN LIST |
	| Apps with a Vendor                       |
	And User remove list with "Pivot_DAS_14224" name on "Devices" page

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13765 @DAS13833 @DAS13855
Scenario: EvergreenJnr_DevicesList_ChecksThatPivotTableDisplayedCorrectlyAfterRemovingColumn
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	And User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	| Description |
	And User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User clicks the List Details button
	When User removes "Description" Column for Pivot
	Then Save button is inactive for Pivot list
	And No pivot generated message is displayed

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS14206 @DAS14413 @DAS14748 @DAS13786 @DAS13869
Scenario: EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnSelectedPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	Then reset button on main panel is displayed
	When User selects the following Values on Pivot:
	| Values   |
	| Building |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then data in the table is sorted by "Common Name" column in ascending order by default for the Pivot
	When User creates Pivot list with "Pivot_DAS_14206" name
	Then "Pivot_DAS_14206" list is displayed to user
	When User navigates to the "All Users" list
	And User navigates to Pivot
	Then "ADD ROW GROUP" Action button is active
	And "ADD COLUMN" Action button is active
	And "ADD VALUE" Action button is active
	And User remove list with "Pivot_DAS_14206" name on "Users" page

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS14206 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnCreatedList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "Dynamic_List_DAS14206" name on "Users" page
	Then "Dynamic_List_DAS14206" list is displayed to user
	When User navigates to the "All Users" list
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	And User selects the following Values on Pivot:
	| Values   |
	| Building |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS_14206" name
	Then "PivotList_DAS_14206" list is displayed to user
	When User navigates to the "Dynamic_List_DAS14206" list
	Then "Dynamic_List_DAS14206" list is displayed to user
	When User navigates to Pivot
	Then "ADD ROW GROUP" Action button is active
	And "ADD COLUMN" Action button is active
	And "ADD VALUE" Action button is active
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	And User selects the following Values on Pivot:
	| Values   |
	| Building |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User clicks the "SAVE" Action button
	And User selects 'Save as new pilot' option
	Then Pivot Name field is empty
	And User remove list with "Dynamic_List_DAS14206" name on "Users" page
	And User remove list with "PivotList_DAS_14206" name on "Users" page

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14413
Scenario: EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnResetButton
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
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
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User removes "City" Column for Pivot
	And User adds the following "Columns" on Pivot: 
	| Value      |
	| Owner City |
	And User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is active
	And "ADD COLUMN" Action button is active
	And "ADD VALUE" Action button is active

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14379 @DAS11291 @DAS14745 @DAS16399
Scenario: EvergreenJnr_DevicesList_ChecksTooltipsOnPivot
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User clicks the "ADD ROW GROUP" Action button
	When "Compliance" value is entered into the search box and the selection is clicked on Pivot
	Then "DONE" Action button have tooltip with "Confirm changes" text
	Then back button on Pivot panel have tooltip with "Close" text
	When User clicks the "DONE" Action button
	And User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	And User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then "Row Groups" plus button have tooltip with "Add row group" text
	And "Columns" plus button have tooltip with "Add column" text
	And "Values" plus button have tooltip with "Add value" text
	And close button for "Compliance" chip have tooltip with "Delete this item" text
	And "City" chip have tooltip with "" text