Feature: PivotPart2
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14224 @DAS14413 @DAS19157 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChangesPage
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	When User selects the following Columns on Pivot:
	| Columns |
	| City    |
	When User selects the following Values on Pivot:
	| Values      |
	| Cost Centre |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "Pivot_DAS_14224" name
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| Pivot_Project_14224 | All Devices | None            | Standalone Project |
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Device Scope' tab on Project Scope Changes page
	Then User sees that 'Scope' dropdown contains following options:
	| Values                                |
	| All Devices                           |
	| 2004 Rollout                          |
	| Auto: X-Proj Paths Scope              |
	| Dependant List Filter - BROKEN LIST   |
	| Depot Capacity                        |
	| Migration Type Capacity               |
	| New York - Devices                    |
	| Using App Saved List Readiness Filter |
	When User navigates to the 'User Scope' tab on Project Scope Changes page
	Then User sees that 'User Scope' dropdown contains following options:
	| Values                             |
	| All Users                          |
	| Users with Device Count            |
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	Then User sees that 'Application Scope' dropdown contains following options:
	| Values                                   |
	| All Applications                         |
	| Apps with a Vendor                       |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13765 @DAS13833 @DAS13855
Scenario: EvergreenJnr_DevicesList_ChecksThatPivotTableDisplayedCorrectlyAfterRemovingColumn
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	When User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	| Description |
	When User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User clicks the List Details button
	When User removes "Description" Column for Pivot
	Then Save button is inactive for Pivot list
	Then No pivot generated message is displayed

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS14206 @DAS14413 @DAS14748 @DAS13786 @DAS13869 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnSelectedPage
	When User clicks 'Users' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	Then reset button on main panel is displayed
	When User selects the following Values on Pivot:
	| Values   |
	| Building |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	#Then data in left-pinned column is sorted in ascending order by default for the Pivot
	When User creates Pivot list with "Pivot_DAS_14206" name
	Then "Pivot_DAS_14206" list is displayed to user
	When User navigates to the "All Users" list
	When User selects 'Pivot' in the 'Create' dropdown
	Then 'ADD ROW GROUP' button is not disabled
	Then 'ADD COLUMN' button is not disabled
	Then 'ADD VALUE' button is not disabled