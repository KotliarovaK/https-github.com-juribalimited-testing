Feature: PivotPart7
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario: EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForUsers
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Domain    |
	And User selects the following Columns on Pivot:
	| Columns    |
	| Compliance |
	And User selects the following Values on Pivot:
	| Values                |
	| UserEvergr: Readiness |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "Domain" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| NONE       |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario: EvergreenJnr_DevicesLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDevices
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups      |
	| Inventory Site |
	And User selects the following Columns on Pivot:
	| Columns    |
	| Compliance |
	And User selects the following Values on Pivot:
	| Values          |
	| 1803: Readiness |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "Inventory Site" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14430
Scenario: EvergreenJnr_DevicesList_CheckThatDeviceOwnerComplianceColumnsDisplayInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "Hostname" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| NONE       |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15139 @DAS13833 @DAS13843 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatThePivotPanelShowNoFiltersAppliedIfThatWereAppliedToTheCustomList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Application Compliance" filter is added to the list
	When User create dynamic list with "TestListForDAS15139" name on "Devices" page
	Then "TestListForDAS15139" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	When User clicks Close panel button
	Then Actions panel is not displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	When User navigates to the "All Devices" list
	Then Actions panel is not displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13833 @DAS13844
Scenario: EvergreenJnr_DevicesList_CheckResetButtonOnPivot
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS_13844" name
	Then "PivotList_DAS_13844" list is displayed to user
	When User clicks the Pivot button
	#Then reset button on main panel is not displayed
	And User adds the following "Columns" on Pivot: 
	| Value      |
	| Owner City |
	Then reset button on main panel is displayed
	When User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	#2
	When User navigates to the "All Devices" list
	And User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	#aggregate function?
	Then "RUN PIVOT" Action button is active
	And "SAVE" Action button is disabled
	When User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	#And "SAVE" Action button is not displayed
	#3
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	#aggregate function?
	Then "RUN PIVOT" Action button is active
	And "SAVE" Action button is disabled
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And "SAVE" Action button is active
	When User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	#And "SAVE" Action button is not displayed
	#4
	When User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values                            |
	| Owner General information field 1 |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS_13844_1" name
	Then "PivotList_DAS_13844_1" list is displayed to user
	When User clicks the Pivot button
	And User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	And "SAVE" Action button is disabled
	And "RUN PIVOT" Action button is disabled
	And User remove list with "PivotList_DAS_13844" name on "Devices" page
	And User remove list with "PivotList_DAS_13844_1" name on "Devices" page

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13833 @DAS13842 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnManagerButton
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	Then "Pivot" panel is displayed to the user
	When User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values               |
	| App Count (Entitled) |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS13842" name
	Then "PivotList_DAS13842" list is displayed to user
	When User navigates to the "All Devices" list
	And User navigates to the "PivotList_DAS13842" list
	Then "PivotList_DAS13842" list is displayed to user
	When User opens manage pane for list with "PivotList_DAS13842" name
	Then "Dynamic Pivot Details" panel is displayed to the user
	And User remove list with "PivotList_DAS13842" name on "Devices" page