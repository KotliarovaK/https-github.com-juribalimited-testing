Feature: PivotPart15
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14373
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatOperatingSystemPivotValueIsDisplayInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	When User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	When User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	#Then color data in the left-pinned column is sorted in descending order for the Pivot

Examples:
	| RowGroups              | Columns               |
	| Application Compliance | Operating System      |
	| Application Compliance | Service Pack or Build |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13862 @DAS14372
Scenario: EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildRowGroupDisplayInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups             |
	| Operating System      |
	| Service Pack or Build |
	When User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	When User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	#Then data in left-pinned column is sorted in ascending order by default for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15758 @DAS15328
Scenario Outline: EvergreenJnr_Lists_CheckThatColumnsForAggregateFunctionsAreCapitalised_NumericValues
	When User clicks '<List>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	When User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Sum" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<SumAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Min" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<MinAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Max" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<MaxAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Avg" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<AvgAggregateFunctions>" is displayed in the columns for aggregate functions

Examples:
	| List         | AddValues                | CountAggregateFunctions         | SumAggregateFunctions         | MinAggregateFunctions         | MaxAggregateFunctions         | AvgAggregateFunctions         |
	| Devices      | HDD Count                | Count(HDD Count)                | Sum(HDD Count)                | Min(HDD Count)                | Max(HDD Count)                | Avg(HDD Count)                |
	| Users        | Device Count             | Count(Device Count)             | Sum(Device Count)             | Min(Device Count)             | Max(Device Count)             | Avg(Device Count)             |
	| Applications | 2004: Current User Count | Count(2004: Current User Count) | Sum(2004: Current User Count) | Min(2004: Current User Count) | Max(2004: Current User Count) | Avg(2004: Current User Count) |
	| Mailboxes    | Associated Item Count    | Count(Associated Item Count)    | Sum(Associated Item Count)    | Min(Associated Item Count)    | Max(Associated Item Count)    | Avg(Associated Item Count)    |

@Evergreen @DevicesLists @EvergreenJnr_Pivot @Pivot @DAS14263 @DAS16403 @DAS16407 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckAddTeamsPermissionsOnDetailsPanel
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
	When User creates Pivot list with "DAS14263_Pivot" name
	Then "DAS14263_Pivot" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'person_add' icon
	When User selects 'Administrator' option from 'User' autocomplete
	When User clicks 'CANCEL' button 
	When User clicks 'group_add' icon
	When User selects 'Team 1062' option from 'Team' autocomplete
	Then 'ADD TEAM' button is disabled
	When User selects 'Edit' in the 'Permission' dropdown
	Then 'ADD TEAM' button is not disabled
	When User clicks 'CANCEL' button 
	When User clicks 'group_add' icon
	When User selects 'Team 1062' option from 'Team' autocomplete
	When User selects 'Admin' in the 'Permission' dropdown
	When User clicks 'CANCEL' button 
	When User clicks 'group_add' icon
	When User selects 'Team 1062' option from 'Team' autocomplete
	When User selects 'Read' in the 'Permission' dropdown
	When User clicks 'CANCEL' button 
	When User navigates to the "DAS14263_Pivot" list
	Then User remove list with "DAS14263_Pivot" name on "Devices" page