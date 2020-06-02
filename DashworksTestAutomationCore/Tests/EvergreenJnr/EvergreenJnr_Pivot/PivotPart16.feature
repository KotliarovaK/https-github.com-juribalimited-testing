Feature: PivotPart16
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @DevicesLists @EvergreenJnr_Pivot @Pivot @DAS16815 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckArchivedItemIncludingInPivot
	When User clicks 'Devices' on the left-hand menu
	When User sets includes archived devices in 'true'
	When User clicks the Filters button
	When User add "2004: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups        |
	| Operating System |
	When User selects the following Values on Pivot:
	| Values      |
	| Device Type |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "DAS16815_Pivot" name
	Then "DAS16815_Pivot" list is displayed to user
	When User sets includes archived devices in 'false'
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User updates existing pivot
	Then "DAS16815_Pivot" list is displayed to user
	When User sets includes archived devices in 'true'
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "DAS16815_Pivot_Updated" name
	Then "DAS16815_Pivot_Updated" list is displayed to user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13833 @DAS13844 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckResetButtonOnPivot
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	When User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	When User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS_13844" name
	Then "PivotList_DAS_13844" list is displayed to user
	When User clicks the Pivot button
	#Then reset button on main panel is not displayed
	When User adds the following "Columns" on Pivot: 
	| Value      |
	| Owner City |
	Then reset button on main panel is displayed
	When User clicks reset button on main panel
	Then 'ADD ROW GROUP' button is displayed
	Then 'ADD COLUMN' button is displayed
	Then 'ADD VALUE' button is displayed
	#2
	When User navigates to the "All Devices" list
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	When User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	When User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	#aggregate function?
	Then 'RUN PIVOT' button is not disabled
	Then 'SAVE' button is disabled
	When User clicks reset button on main panel
	Then 'ADD ROW GROUP' button is displayed
	Then 'ADD COLUMN' button is displayed
	Then 'ADD VALUE' button is displayed
	#And "SAVE" Action button is not displayed
	#3
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	When User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	When User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	#aggregate function?
	Then 'RUN PIVOT' button is not disabled
	Then 'SAVE' button is disabled
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then 'SAVE' button is not disabled
	When User clicks reset button on main panel
	Then 'ADD ROW GROUP' button is displayed
	Then 'ADD COLUMN' button is displayed
	Then 'ADD VALUE' button is displayed
	#And "SAVE" Action button is not displayed
	#4
	When User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	When User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	When User selects the following Values on Pivot:
	| Values                            |
	| Owner General information field 1 |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS_13844_1" name
	Then "PivotList_DAS_13844_1" list is displayed to user
	When User clicks the Pivot button
	When User clicks reset button on main panel
	Then 'ADD ROW GROUP' button is displayed
	Then 'ADD COLUMN' button is displayed
	Then 'ADD VALUE' button is displayed
	Then 'SAVE' button is disabled
	Then 'RUN PIVOT' button is disabled