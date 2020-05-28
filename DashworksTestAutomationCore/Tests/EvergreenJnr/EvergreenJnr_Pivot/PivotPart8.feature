Feature: PivotPart8
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13833 @DAS13846 @DAS16994
Scenario: EvergreenJnr_DevicesList_CheckThatAddingColumnOnPivotIsWorksCorrectlyForFilteredList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Key" filter where type is "Equals" with added column and following value:
	| Values |
	| 4553   |
	Then "Device Key" filter is added to the list
	When User selects 'Pivot' in the 'Create' dropdown
	And User clicks 'ADD COLUMN' button 
	Then "5" subcategories is displayed for "Suggested" category
	And "Device Key" subcategory is selected in Column panel
	When User adds the "Device Key" category on Pivot
	Then "Selected Filters" section is not displayed in the Columns panel
	And "Device Key" subcategory is selected in Column panel

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13119 @DAS13652 @DAS13637 @DAS17421 @DAS13649 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatPivotSubmenuIsDisplayedCorrectlyAfterClosingListsPanel
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
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
	When User creates Pivot list with "PivotList_DAS13652" name
	Then "PivotList_DAS13652" list is displayed to user
	When User closed list panel
	Then Lists panel is hidden
	And "PivotList_DAS13652" list name is displayed correctly on top tools panel
	And 'RUN PIVOT' button is displayed
	And Export button is displayed in panel

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS11103 @DAS11264 @DAS11360 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatRemovingValueThroughTheChipsWorksCorrectly
	When User clicks '<PageName>' on the left-hand menu
	Then '<PageLabel>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <ValuesForFilter>  |
	Then "<FilterName>" filter is added to the list
	When User create dynamic list with "<ListName>" name on "<PageName>" page
	Then "<ListName>" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	And User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	And User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	When User clicks 'RUN PIVOT' button 
	And User adds the following "Values" on Pivot: 
	| Value             |
	| <AdditionalValue> |
	Then "<Value>" chip for Value is displayed
	Then "<AdditionalValue>" chip for Value is displayed
	When User clicks close button for "<AdditionalValue>" chip
	Then "<AdditionalValue>" chip for Value is not displayed
	When User clicks Plus button for "Values" Pivot value
	When User enters "<AdditionalValue>" text in Search field at Columns Panel
	When User collapses 'Selected Columns' category
	When User collapses 'Suggested' category
	Then "<AdditionalValue>" subcategory is displayed for "<CategoryName>" category

Examples:
	| PageName     | PageLabel        | RowGroup    | Column                      | Value          | AdditionalValue      | ListName                | FilterName             | ValuesForFilter | CategoryName     |
	| Devices      | All Devices      | Compliance  | 2004: Application Readiness | Last Seen Date | OS Branch            | Devices_List_11103      | Application Compliance | Red             | Operating System |
	| Users        | All Users        | Compliance  | App Count (Entitled)        | Domain         | Dashworks First Seen | Users_List_11103        | Compliance             | Red             | User             |
	| Mailboxes    | All Mailboxes    | Import      | Owner City                  | Created Date   | Alias                | Mailboxes_List_11103    | Enabled                | TRUE            | Mailbox          |
	| Applications | All Applications | Application | Evergreen Capacity Unit     | Vendor         | Application Owner    | Applications_List_11103 | Compliance             | Red             | Custom Fields    |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS11103 @DAS13819 @DAS13818 @DAS13817 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatAggregateFunctionContainsCorrectValues
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Values on Pivot:
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
	And User selects the following Values on Pivot:
	| Values     |
	| Build Date |
	Then following aggregate function are available in dropdown:
	| Option |
	| Count  |
	| First  |
	| Last   |
	When User clicks close button for "Build Date" chip
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	Then following aggregate function are available in dropdown:
	| Option |
	| Count  |
	When User clicks close button for "Owner City" chip

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13862 @DAS14372 @DAS14373
Scenario Outline: EvergreenJnr_DevicesList_CheckThatOperatingSystemPivotValueIsDisplayInTheCorrectOrder
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
	Then data in left-pinned column is sorted in ascending order by default for the Pivot

Examples:
	| RowGroups              | Columns               |
	| Operating System       | Owner Compliance      |
	| Service Pack or Build  | Owner Compliance      |
	| Application Compliance | Operating System      |
	| Application Compliance | Service Pack or Build |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13862 @DAS14372
Scenario: EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildRowGroupDisplayInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups             |
	| Operating System      |
	| Service Pack or Build |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in left-pinned column is sorted in ascending order by default for the Pivot