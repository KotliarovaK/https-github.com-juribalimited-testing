Feature: PivotPart14
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS19348
Scenario: EvergreenJnr_Devices_CheckThatNoConsoleErrorDisplayedAfterRunninfPivotFromObjectOwnerFilter
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner" filter where type is "Equal" without added column and "AU\AAO798996 (Darren J. Walter)" Lookup option
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups      |
	| Device Type |
	When User selects the following Columns on Pivot:
	| Columns          |
	|Hostname |
	When User selects the following Values on Pivot:
	| Values        |
	| Operating System |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13862 @DAS14373
Scenario: EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDisplayInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	When User selects the following Columns on Pivot:
	| Columns               |
	| Operating System      |
	| Service Pack or Build |
	When User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	#Then color data in the left-pinned column is sorted in descending order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS21056
Scenario: EvergreenJnr_Devices_CheckThatEmptyRowVlueLeadsToCorrectFilteredPage
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Country   |
	When User selects the following Columns on Pivot:
	| Columns      |
	| Device Type  |
	| Manufacturer |
	When User selects the following Values on Pivot:
	| Values   |
	| Hostname |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User clicks value from 'Empty' row and 'Dell' column
	When User clicks the Filters button
	Then "Device Type is Data Centre" is displayed in added filter info
	Then "Manufacturer is Dell" is displayed in added filter info
	Then "Country is Empty" is displayed in added filter info
		
@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13833 @DAS13842 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnManagerButton
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	Then "Pivot" panel is displayed to the user
	When User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	When User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	When User selects the following Values on Pivot:
	| Values               |
	| App Count (Entitled) |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS13842" name
	Then "PivotList_DAS13842" list is displayed to user
	When User navigates to the "All Devices" list
	When User navigates to the "PivotList_DAS13842" list
	Then "PivotList_DAS13842" list is displayed to user
	When User clicks 'Manage' option in cogmenu for 'PivotList_DAS13842' list
	Then "Dynamic Pivot Details" panel is displayed to the user

	
@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS11103 @DAS13819 @DAS13818 @DAS13817 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatAggregateFunctionContainsCorrectValues
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Values on Pivot:
	| Values     |
	| HDD Count  |
	Then following aggregate function are available in dropdown:
	| Option |
	| Count  |
	| Sum    |
	| Min    |
	| Max    |
	| Avg    |
	When User clicks close button for "HDD Count" chip
	When User selects the following Values on Pivot:
	| Values     |
	| Build Date |
	Then following aggregate function are available in dropdown:
	| Option |
	| Count  |
	| First  |
	| Last   |
	When User clicks close button for "Build Date" chip
	When User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	Then following aggregate function are available in dropdown:
	| Option |
	| Count  |
	When User clicks close button for "Owner City" chip