Feature: CustomListDisplayPart11
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13640 @DAS13643 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatLayoutFilterForCreatedListsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User create static list with "StaticFilterList_2" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "StaticFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	When User click on 'Hostname' column header
	When User create dynamic list with "DynamicFilterList_2" name on "Devices" page
	Then "DynamicFilterList_2" list is displayed to user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values               |
	| App Count (Entitled) |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotDynamicFilterList_2" name
	Then "PivotDynamicFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	And User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Build Date |
	And User selects the following Columns on Pivot:
	| Columns                |
	| Application Compliance | 
	And User selects the following Values on Pivot:
	| Values                            |
	| Owner General information field 1 |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotFilterList_2" name
	Then "PivotFilterList_2" list is displayed to user
	When User navigates to the "All Devices" list
	When User apply "Standard" filter to lists panel
	Then "DynamicFilterList_2" list is displayed in the bottom section of the List Panel
	And "StaticFilterList_2" list is displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_2" list is not displayed in the bottom section of the List Panel
	And "PivotFilterList_2" list is not displayed in the bottom section of the List Panel
	When User enters "2" text in Search field at List Panel
	Then "DynamicFilterList_2" list is displayed in the bottom section of the List Panel
	And "StaticFilterList_2" list is displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_2" list is not displayed in the bottom section of the List Panel
	And "PivotFilterList_2" list is not displayed in the bottom section of the List Panel
	When User apply "Pivot" filter to lists panel
	Then "DynamicFilterList_2" list is not displayed in the bottom section of the List Panel
	And "StaticFilterList_2" list is not displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_2" list is displayed in the bottom section of the List Panel
	And "PivotFilterList_2" list is displayed in the bottom section of the List Panel
	When User enters "2" text in Search field at List Panel
	Then "DynamicFilterList_2" list is not displayed in the bottom section of the List Panel
	And "StaticFilterList_2" list is not displayed in the bottom section of the List Panel	
	And "PivotDynamicFilterList_2" list is displayed in the bottom section of the List Panel
	And "PivotFilterList_2" list is displayed in the bottom section of the List Panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13643
Scenario: EvergreenJnr_DevicesList_CheckThatFavouriteFilterForListsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User apply "Not favourite" filter to lists panel
	Then "1803 Rollout" list is displayed in the bottom section of the List Panel
	When User apply "Favourite" filter to lists panel
	Then "1803 Rollout" list is not displayed in the bottom section of the List Panel
	When User enters "1803" text in Search field at List Panel
	Then "1803 Rollout" list is not displayed in the bottom section of the List Panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13643
Scenario: EvergreenJnr_DevicesList_CheckThatSharingiteFilterForListsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User apply "Shared with me " filter to lists panel
	Then "1803 Rollout" list is displayed in the bottom section of the List Panel
	When User apply "Owned by me " filter to lists panel
	Then "1803 Rollout" list is not displayed in the bottom section of the List Panel
	When User enters "1803" text in Search field at List Panel
	Then "1803 Rollout" list is not displayed in the bottom section of the List Panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS17627 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettings
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User create static list with "StaticFilterList_1" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "StaticFilterList_1" list is displayed to user
	When User navigates to the "All Devices" list
	When User click on 'Hostname' column header
	When User create dynamic list with "DynamicFilterList_1" name on "Devices" page
	Then "DynamicFilterList_1" list is displayed to user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns  |
	| Hostname |
	And User selects the following Values on Pivot:
	| Values   |
	| Hostname |
	When User clicks the "RUN PIVOT" Action button
	And User removes "Hostname" Column for Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Floor     |
	When User clicks the "RUN PIVOT" Action button
	Then There are no errors in the browser console
	#Just to check that application is still responding
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user