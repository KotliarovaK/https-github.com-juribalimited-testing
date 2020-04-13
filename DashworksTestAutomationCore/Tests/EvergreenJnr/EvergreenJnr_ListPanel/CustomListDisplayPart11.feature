Feature: CustomListDisplayPart11
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13640 @DAS13643 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatLayoutFilterForCreatedListsIsWorkedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User create static list with "StaticFilterList_2" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "StaticFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	When User clicks on 'Hostname' column header
	When User create dynamic list with "DynamicFilterList_2" name on "Devices" page
	Then "DynamicFilterList_2" list is displayed to user
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
	When User creates Pivot list with "PivotDynamicFilterList_2" name
	Then "PivotDynamicFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	And User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Build Date |
	And User selects the following Columns on Pivot:
	| Columns                |
	| Application Compliance | 
	And User selects the following Values on Pivot:
	| Values                            |
	| Owner General information field 1 |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "PivotFilterList_2" name
	Then "PivotFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	When User apply "Standard" filter to lists panel
	Then 'DynamicFilterList_2' list is displayed in the Lists panel
	Then 'StaticFilterList_2' list is displayed in the Lists panel
	Then 'PivotDynamicFilterList_2' list is not displayed in the Lists panel
	Then 'PivotFilterList_2' list is not displayed in the Lists panel
	When User enters "2" text in Search field at List Panel
	Then 'DynamicFilterList_2' list is displayed in the Lists panel
	Then 'StaticFilterList_2' list is displayed in the Lists panel
	Then 'PivotDynamicFilterList_2' list is not displayed in the Lists panel
	Then 'PivotFilterList_2' list is not displayed in the Lists panel
	When User apply "Pivot" filter to lists panel
	Then 'DynamicFilterList_2' list is not displayed in the Lists panel
	Then 'StaticFilterList_2' list is not displayed in the Lists panel
	Then 'PivotDynamicFilterList_2' list is displayed in the Lists panel
	Then 'PivotFilterList_2' list is displayed in the Lists panel
	When User enters "2" text in Search field at List Panel
	Then 'DynamicFilterList_2' list is not displayed in the Lists panel
	Then 'StaticFilterList_2' list is not displayed in the Lists panel
	Then 'PivotDynamicFilterList_2' list is displayed in the Lists panel
	Then 'PivotFilterList_2' list is displayed in the Lists panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13643
Scenario: EvergreenJnr_DevicesList_CheckThatFavouriteFilterForListsIsWorkedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User apply "Not favourite" filter to lists panel
	Then '2004 Rollout' list is displayed in the Lists panel
	When User apply "Favourite" filter to lists panel
	Then '2004 Rollout' list is not displayed in the Lists panel
	When User enters "2004" text in Search field at List Panel
	Then '2004 Rollout' list is not displayed in the Lists panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13643
Scenario: EvergreenJnr_DevicesList_CheckThatSharingiteFilterForListsIsWorkedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User apply "Shared with me " filter to lists panel
	Then '2004 Rollout' list is displayed in the Lists panel
	When User apply "Owned by me " filter to lists panel
	Then '2004 Rollout' list is not displayed in the Lists panel
	When User enters "2004" text in Search field at List Panel
	Then '2004 Rollout' list is not displayed in the Lists panel