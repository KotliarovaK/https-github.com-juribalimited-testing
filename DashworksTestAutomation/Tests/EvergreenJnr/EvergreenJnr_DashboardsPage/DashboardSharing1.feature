﻿Feature: DashboardSharing1
	Runs Dashboard sharing tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @DAS14911 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOwnerCanBeAddedToSharedUsersAsSpecificUserWithDifferentPermissions
	When Dashboard with 'Dashboard for DAS14911' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for DAS14911' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User select "Specific users" sharing option
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Admin      |
	Then User 'Admin' was added to shared list with 'Admin' permission of Details panel
	Then There are no errors in the browser console
	When User clicks 'Remove' option in Cog-menu for 'Admin' user on Details panel
	Then There is no user in shared list of Details panel
	Then There are no errors in the browser console
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Edit       |
	Then User 'Admin' was added to shared list with 'Edit' permission of Details panel
	Then There are no errors in the browser console
	When User clicks 'Remove' option in Cog-menu for 'Admin' user on Details panel
	Then There is no user in shared list of Details panel
	Then There are no errors in the browser console
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Read       |
	Then User 'Admin' was added to shared list with 'Read Only' permission of Details panel
	Then There are no errors in the browser console
	When User clicks 'Remove' option in Cog-menu for 'Admin' user on Details panel
	Then There is no user in shared list of Details panel
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16380 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckWarningMessageUsingPrivateListForPublicDashboard
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Build Date |
	When User create dynamic list with "First_List_DAS16380" name on "Devices" page
	When User navigates to the "All Devices" list
	When User clicks on 'Hostname' column header
	When User create dynamic list with "Second_List_DAS16380" name on "Devices" page
	Then "Second_List_DAS16380" list is displayed to user
	When Dashboard with 'Dashboard for DAS16380' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List                | MaxRows | MaxColumns |
	| List       | Widget_For_DAS16380 | First_List_DAS16380 | 10      | 10         |
	Then 'Widget_For_DAS16380' Widget is displayed to the user
	#change permission to Everyone can see
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option
	Then Review Widget List Permissions is displayed to the User
	When User selects 'Everyone can see' permission for 'First_List_DAS16380' list on Permissions Pop-up
	When User clicks 'UPDATE & SHARE' button 
	When User clicks 'ADD WIDGET' button 
	When User selects 'List' in the 'WidgetType' dropdown
	When User enters 'Widget_For_DAS16380_1' as Widget Title
	When User selects 'Second_List_DAS16380' as Widget List
	Then User sees 'You have chosen a restricted list for a shared dashboard, some users may not be able to see this widget' warning text below Lists field
	#change permission to Everyone can edit
	When User clicks 'CREATE' button 
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can edit" sharing option
	Then Review Widget List Permissions is displayed to the User
	When User clicks 'IGNORE & SHARE' button 
	When User clicks 'ADD WIDGET' button 
	When User selects 'List' in the 'WidgetType' dropdown
	When User enters 'Widget_For_DAS16380_2' as Widget Title
	When User selects 'Second_List_DAS16380' as Widget List
	Then User sees 'You have chosen a restricted list for a shared dashboard, some users may not be able to see this widget' warning text below Lists field
	#change permission to Everyone can edit
	When User clicks 'CREATE' button 
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Specific users / teams" sharing option
	Then Review Widget List Permissions is displayed to the User
	When User clicks 'IGNORE & SHARE' button 
	When User clicks 'ADD WIDGET' button 
	When User selects 'List' in the 'WidgetType' dropdown
	When User enters 'Widget_For_DAS16380_3' as Widget Title
	When User selects 'Second_List_DAS16380' as Widget List
	Then User sees 'You have chosen a restricted list for a shared dashboard, some users may not be able to see this widget' warning text below Lists field

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWarningPopUpDisplayedWhenChangingDashboardPermisson
	#create private list
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Service Pack or Build |
	When User create dynamic list with "DeviceListFor14841" name on "Devices" page
	#create dashboard
	When Dashboard with 'Dashboard for DAS14841' name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	#add widget
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List               | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841 | DeviceListFor14841 | Hostname | Count             | Count DESC |
	Then 'WidgetForDAS14841' Widget is displayed to the user
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option
	Then Review Widget List Permissions is displayed to the User
	#check row data
	Then Widget 'WidgetForDAS14841' displayed for 'DeviceListFor14841' list on Permissions Pop-up
	Then Current user displayed for 'DeviceListFor14841' list on Permissions Pop-up
	Then Current permission 'Private' displayed for 'DeviceListFor14841' list on Permissions Pop-up
	Then New Permission 'Do not change' displayed for 'DeviceListFor14841' list on Permissions Pop-up
	#the new permissions options
	Then User sees next options of New Permission field for 'DeviceListFor14841' list on Permissions Pop-up
	| Options           |
	| Do not change     |
	| Everyone can see  |
	| Everyone can edit |
	#state
	Then Button 'UPDATE & SHARE' has enabled property 'false' on Permissions Pop-up
	Then Button 'IGNORE & SHARE' has enabled property 'true' on Permissions Pop-up
	Then Button 'CANCEL' has enabled property 'true' on Permissions Pop-up
	#tooltips
	Then Button 'UPDATE & SHARE' has 'Amend widget permissions above' tooltip on Permissions Pop-up
	Then Button 'IGNORE & SHARE' has 'Do not change widget list permissions and share dashboard' tooltip on Permissions Pop-up
	Then Button 'CANCEL' has 'Do not change widget list permissions and do not share dashboard' tooltip on Permissions Pop-up
	#mix
	When User selects 'Everyone can see' permission for 'DeviceListFor14841' list on Permissions Pop-up
	Then Button 'UPDATE & SHARE' has enabled property 'true' on Permissions Pop-up
	Then Button 'UPDATE & SHARE' has 'Change widget list permissions and share dashboard' tooltip on Permissions Pop-up
	When User clicks the 'CANCEL' button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	Then "Private" sharing option is selected
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatIgnoreAndShareWorksProperlyInWarningPermissionPoup
	#create private list
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Service Pack or Build |
	When User create dynamic list with "DeviceListFor14841_1" name on "Devices" page
	#create dashboard
	When Dashboard with 'Dashboard for DAS14841_1' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	#add widget
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_1 | Hostname | Count             | Count DESC |
	Then 'WidgetForDAS14841' Widget is displayed to the user
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option
	Then Review Widget List Permissions is displayed to the User
	#act	
	When User selects 'Everyone can see' permission for 'DeviceListFor14841_1' list on Permissions Pop-up
	When User clicks the 'IGNORE & SHARE' button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	Then "Everyone can see" sharing option is selected
	#teardown
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_1" list
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	Then "Private" sharing option is selected

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUpdateAndShareWorksProperlyInWarningPermissionPopup
	#create private list
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841_2" name on "Devices" page
	#create dashboard
	When Dashboard with 'Dashboard for DAS14841_2' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	#add widget
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_2 | Hostname | Count             | Count DESC |
	Then 'WidgetForDAS14841' Widget is displayed to the user
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option
	Then Review Widget List Permissions is displayed to the User
	#act
	When User selects 'Everyone can see' permission for 'DeviceListFor14841_2' list on Permissions Pop-up
	When User clicks the 'UPDATE & SHARE' button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	Then "Everyone can see" sharing option is selected
	#teardown
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_2" list
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	Then "Everyone can see" sharing option is selected

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUpdateAndShareWorksOnlyForParticularRow
	#create private list#1
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Service Pack or Build |
	When User create dynamic list with "DeviceListFor14841_3" name on "Devices" page
	#create private list#2
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| OS Architecture |
	When User create dynamic list with "DeviceListFor14841_4" name on "Devices" page
	Then "DeviceListFor14841_4" list is displayed to user
	#create dashboard
	When Dashboard with 'Dashboard for DAS14841_3' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	#add widget#1
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List                 | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841_1 | DeviceListFor14841_3 | Hostname | Count             | Count DESC |
	Then 'WidgetForDAS14841_1' Widget is displayed to the user
	#add widget#2
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List                 | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841_2 | DeviceListFor14841_4 | Hostname | Count             | Count DESC |
	Then 'WidgetForDAS14841_2' Widget is displayed to the user
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option
	Then Review Widget List Permissions is displayed to the User
	#act
	When User selects 'Everyone can edit' permission for 'DeviceListFor14841_3' list on Permissions Pop-up
	Then Button 'UPDATE & SHARE' has enabled property 'true' on Permissions Pop-up
	Then Button 'UPDATE & SHARE' has 'Change widget list permissions and share dashboard' tooltip on Permissions Pop-up
	When User clicks the 'UPDATE & SHARE' button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	Then "Everyone can see" sharing option is selected
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_3" list
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	And "Everyone can edit" sharing option is selected
	When User clicks Settings button for "DeviceListFor14841_4" list
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	Then "Private" sharing option is selected

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @DAS14393 @Cleanup
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatListPermissionCantBeChangedForReadOnlySharedList
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username          | Password  |
	| automation_admin1 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	Then table content is present
	And User create custom list with "<listName>" name
	Then "<listName>" list is displayed to user
	When User clicks the List Details button
	When User select "Specific users / teams" sharing option
	When User clicks 'ADD USER' button 
	When User selects the "Automation Admin 10" user for sharing
	When User select "<shareType>" in Select Access dropdown
	When User clicks 'ADD USER' button 
	When User clicks 'ADD USER' button 
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password  |
	| automation_admin10 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	#create dashboard
	When Dashboard with '<dashboardName>' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title        | List       | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | <widgetName> | <listName> | Hostname | Count             | Count DESC |
	Then '<widgetName>' Widget is displayed to the user
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can edit" sharing option
	Then Review Widget List Permissions is displayed to the User
	Then Widget '<widgetName>' displayed for '<listName>' list on Permissions Pop-up
	Then User 'Automation Admin 1' displayed for '<listName>' list on Permissions Pop-up
	Then Current permission 'Specific users / teams' displayed for '<listName>' list on Permissions Pop-up
	Then New Permission 'Do not change' displayed for '<listName>' list on Permissions Pop-up
	Then New Permission dropdown has disabled property 'true' for '<listName>' list on Permissions Pop-up
	Then New Permission dropdown has 'You cannot change the permission for this list' tooltip for '<listName>' list on Permissions Pop-up

Examples:
| listName                | shareType | dashboardName                        | widgetName             |
| DeviceListFor14841_Read | Read      | Dashboard for DAS14841_Read          | WidgetForDAS14841_Read |
| DeviceListFor14841_Edit | Edit      | Dashboard for WidgetForDAS14841_Edit | WidgetForDAS14841_Edit |