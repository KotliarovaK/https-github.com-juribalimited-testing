Feature: CustomListDisplayPart12
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

<<<<<<<< HEAD:DashworksTestAutomation/Tests/EvergreenJnr/EvergreenJnr_ListPanel/CustomListDisplayPart11.feature
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
========
@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS17627 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatDashworkWorksAfterChangingPivotSettings
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User create static list with "StaticFilterList_1" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "StaticFilterList_1" list is displayed to user
	When User navigates to the "All Devices" list
	When User clicks on 'Hostname' column header
	When User create dynamic list with "DynamicFilterList_1" name on "Devices" page
	Then "DynamicFilterList_1" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns  |
	| Hostname |
	And User selects the following Values on Pivot:
	| Values   |
	| Hostname |
	When User clicks 'RUN PIVOT' button 
	And User removes "Hostname" Column for Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Floor     |
	When User clicks 'RUN PIVOT' button 
	Then There are no errors in the browser console
	#Just to check that application is still responding
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS17421 @DAS17014 @DAS17014
Scenario: EvergreenJnr_DevicesList_CheckThatGridHeaderIsDisplayedCorrectlyAfterClosingListsPanel
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User closed list panel
	Then Lists panel is hidden
	Then User sees correct tooltip for Show Lists panel

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS15785
Scenario Outline: EvergreenJnr_DevicesList_CheckThatFilterCategoryNamingIsCorrect
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListTitle>' list should be displayed to the user
	And List filter DDL displays the next options
	| filterItem     |
	| All            |
	| Favourite      |
	| Not favourite  |
	| All            |
	| Owned by me    |
	| Shared with me |
	| All            |
	| Static         |
	| Dynamic        |
	| All            |
	| Standard       |
	| Pivot          |

Examples:
	| ListType     | ListTitle        |
	| Devices      | All Devices      |
	| Users        | All Users        |
	| Applications | All Applications |
	| Mailboxes    | All Mailboxes    |

@Evergreen @Applications @CustomListDisplay @EvergreenJnr_ListPanel @DAS17472 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThat500ErrorIsNotDisplayedAfterSavingListWithDeviceOwnerSavedListFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Owner (Saved List)" filter where type is "In list" with selected Expanded Checkboxes and following Association:
	| SelectedCheckboxes      | Association    |
	| Users with Device Count | Used on device |
	Then "100" rows are displayed in the agGrid
	When User creates 'Test_Application_List_DAS_17472' dynamic list
	Then "Test_Application_List_DAS_17472" list is displayed to user
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS18483
Scenario: EvergreenJnr_DevicesList_CheckThatListCanBeFoundUsingAnyCapsOrSmallLetters
	When User clicks 'Devices' on the left-hand menu
	When User enters "new" text in Search field at List Panel
	Then 'New York - Devices' list is displayed in the Lists panel
	When User enters "New" text in Search field at List Panel
	Then 'New York - Devices' list is displayed in the Lists panel

@Evergreen @AllLists @EvergreenJnr_ListPanel @DAS15785
Scenario Outline: EvergreenJnr_AllLists_CheckThatNumberOfRequestsToListsDontExceedAllowedCount
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListTitle>' list should be displayed to the user
	Then Number of requests to '<url>' is not greater than '<requests>'

Examples:
	| ListType     | ListTitle        | url           | requests |
	| Devices      | All Devices      | /devices      | 23       |
	| Users        | All Users        | /users        | 11       |
	| Applications | All Applications | /applications | 11       |
	| Mailboxes    | All Mailboxes    | /mailboxes    | 11       |
>>>>>>>> NetCore:DashworksTestAutomationCore/Tests/EvergreenJnr/EvergreenJnr_ListPanel/CustomListDisplayPart12.feature
