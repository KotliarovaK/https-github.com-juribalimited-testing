Feature: DashboardSharing
	Runs Dashboard sharing tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @DAS14911 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatOwnerCanBeAddedToSharedUsersAsSpecificUserWithDifferentPermissions
	When Dashboard with "Dashboard for DAS14911" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for DAS14911" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User changes sharing type from "Private" to "Specific users"
	And User adds user to list of shared person
	| User          | Permission |
	| Administrator | Admin      |
	Then User "Admin" was added to shared list with "Admin" permission
	And There are no errors in the browser console
	When User clicks Settings button for "Admin" shared user
	And User selects "Remove" option from Settings
	Then There is no user in shared list
	And There are no errors in the browser console
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Edit       |
	Then User "Admin" was added to shared list with "Edit" permission
	And There are no errors in the browser console
	When User clicks Settings button for "Admin" shared user
	And User selects "Remove" option from Settings
	Then There is no user in shared list
	And There are no errors in the browser console
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Read       |
	Then User "Admin" was added to shared list with "Read Only" permission
	And There are no errors in the browser console
	When User clicks Settings button for "Admin" shared user
	And User selects "Remove" option from Settings
	Then There is no user in shared list
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16380 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckWarningMessageUsingPrivateListForPublicDashboard
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Build Date |
	And User create dynamic list with "First_List_DAS16380" name on "Devices" page
	And User navigates to the "All Devices" list
	And User click on 'Hostname' column header
	And User create dynamic list with "Second_List_DAS16380" name on "Devices" page
	Then "Second_List_DAS16380" list is displayed to user
	When Dashboard with "Dashboard for DAS16380" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List                | MaxRows | MaxColumns |
	| List       | Widget_For_DAS16380 | First_List_DAS16380 | 10      | 10         |
	Then "Widget_For_DAS16380" Widget is displayed to the user
	#change permission to Everyone can see
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	When User selects "Everyone can see" permission for "First_List_DAS16380" list on Permissions Pop-up
	And User clicks the "UPDATE & SHARE" Action button
	And User clicks the "ADD WIDGET" Action button
	When User selects "List" in the "Widget Type" Widget dropdown
	And User enters "Widget_For_DAS16380_1" as Widget Title
	And User selects "Second_List_DAS16380" as Widget List
	Then User sees "You have chosen a restricted list for a shared dashboard, some users may not be able to see this widget" warning text below Lists field
	#change permission to Everyone can edit
	When User clicks the "CREATE" Action button
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can edit" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	When User clicks the "IGNORE & SHARE" Action button
	And User clicks the "ADD WIDGET" Action button
	When User selects "List" in the "Widget Type" Widget dropdown
	And User enters "Widget_For_DAS16380_2" as Widget Title
	And User selects "Second_List_DAS16380" as Widget List
	Then User sees "You have chosen a restricted list for a shared dashboard, some users may not be able to see this widget" warning text below Lists field
	#change permission to Everyone can edit
	When User clicks the "CREATE" Action button
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Specific users / teams" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	When User clicks the "IGNORE & SHARE" Action button
	And User clicks the "ADD WIDGET" Action button
	When User selects "List" in the "Widget Type" Widget dropdown
	And User enters "Widget_For_DAS16380_3" as Widget Title
	And User selects "Second_List_DAS16380" as Widget List
	Then User sees "You have chosen a restricted list for a shared dashboard, some users may not be able to see this widget" warning text below Lists field

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWarningPopUpDisplayedWhenChangingDashboardPermisson
	#create private list
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841" name on "Devices" page
	#create dashboard
	When Dashboard with "Dashboard for DAS14841" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	#add widget
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List               | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841 | DeviceListFor14841 | Hostname | Count             | Count DESC |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	#check row data
	And Widget "WidgetForDAS14841" displayed for "DeviceListFor14841" list on Permissions Pop-up
	And Current user displayed for "DeviceListFor14841" list on Permissions Pop-up
	And Current permission "Private" displayed for "DeviceListFor14841" list on Permissions Pop-up
	And New Permission "Do not change" displayed for "DeviceListFor14841" list on Permissions Pop-up
	#the new permissions options
	Then User sees next options of New Permission field for "DeviceListFor14841" list on Permissions Pop-up
	| Options           |
	| Do not change     |
	| Everyone can see  |
	| Everyone can edit |
	#state
	Then Button "UPDATE & SHARE" has enabled property "false" on Permissions Pop-up
	And Button "IGNORE & SHARE" has enabled property "true" on Permissions Pop-up
	And Button "CANCEL" has enabled property "true" on Permissions Pop-up
	#tooltips
	And Button "UPDATE & SHARE" has "Amend widget permissions above" tooltip on Permissions Pop-up
	And Button "IGNORE & SHARE" has "Do not change widget list permissions and share dashboard" tooltip on Permissions Pop-up
	And Button "CANCEL" has "Do not change widget list permissions and do not share dashboard" tooltip on Permissions Pop-up
	#mix
	When User selects "Everyone can see" permission for "DeviceListFor14841" list on Permissions Pop-up
	Then Button "UPDATE & SHARE" has enabled property "true" on Permissions Pop-up
	And Button "UPDATE & SHARE" has "Change widget list permissions and share dashboard" tooltip on Permissions Pop-up
	When User clicks the "CANCEL" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Private" displayed in Dashboard Details
	
@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatIgnoreAndShareWorksProperlyInWarningPermissionPoup
	#create private list
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841_1" name on "Devices" page
	#create dashboard
	When Dashboard with "Dashboard for DAS14841_1" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	#add widget
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_1 | Hostname | Count             | Count DESC |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	#act	
	When User selects "Everyone can see" permission for "DeviceListFor14841_1" list on Permissions Pop-up
	And User clicks the "IGNORE & SHARE" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Everyone can see" displayed in Dashboard Details
	#teardown
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_1" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Private" sharing option is selected

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUpdateAndShareWorksProperlyInWarningPermissionPopup
	#create private list
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841_2" name on "Devices" page
	#create dashboard
	When Dashboard with "Dashboard for DAS14841_2" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	#add widget
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_2 | Hostname | Count             | Count DESC |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	#act
	When User selects "Everyone can see" permission for "DeviceListFor14841_2" list on Permissions Pop-up
	And User clicks the "UPDATE & SHARE" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Everyone can see" displayed in Dashboard Details
	#teardown
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_2" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Everyone can see" sharing option is selected

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUpdateAndShareWorksOnlyForParticularRow
	#create private list#1
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Service Pack or Build |
	And User create dynamic list with "DeviceListFor14841_3" name on "Devices" page
	#create private list#2
	When User clicks "Devices" on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| OS Architecture |
	And User create dynamic list with "DeviceListFor14841_4" name on "Devices" page
	Then "DeviceListFor14841_4" list is displayed to user
	#create dashboard
	When Dashboard with "Dashboard for DAS14841_3" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	#add widget#1
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_3 | Hostname | Count             | Count DESC |
	#add widget#2
	When User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List                 | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841 | DeviceListFor14841_4 | Hostname | Count             | Count DESC |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	#act
	When User selects "Everyone can edit" permission for "DeviceListFor14841_3" list on Permissions Pop-up
	Then Button "UPDATE & SHARE" has enabled property "true" on Permissions Pop-up
	And Button "UPDATE & SHARE" has "Change widget list permissions and share dashboard" tooltip on Permissions Pop-up
	When User clicks the "UPDATE & SHARE" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Everyone can see" displayed in Dashboard Details
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_3" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Everyone can edit" sharing option is selected
	When User clicks Settings button for "DeviceListFor14841_4" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Private" sharing option is selected

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @DAS14393 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatListPermissionCantBeChangedForReadOnlySharedList
	When User clicks the Logout button
	When User clicks the Switch to Evergreen link
	And User clicks on the Login link
	And User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create custom list with "DeviceListFor14841_Read" name
	Then "DeviceListFor14841_Read" list is displayed to user
	When User clicks the List Details button
	And User select "Specific users / teams" sharing option
	And User clicks the "ADD USER" Action button
	And User selects the "Automation Admin 10" user for sharing
	And User select "Read" in Select Access dropdown
	And User clicks the "ADD USER" Action button
	And User clicks the "ADD USER" Action button
	And User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	When User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	When User clicks the Switch to Evergreen link
	#create dashboard
	When Dashboard with "Dashboard for DAS14841_Read" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List                    | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841_Read | DeviceListFor14841_Read | Hostname | Count             | Count DESC |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can edit" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	And Widget "WidgetForDAS14841_Read" displayed for "DeviceListFor14841_Read" list on Permissions Pop-up
	And User "Automation Admin 1" displayed for "DeviceListFor14841_Read" list on Permissions Pop-up
	And Current permission "Specific users / teams" displayed for "DeviceListFor14841_Read" list on Permissions Pop-up
	And New Permission "Do not change" displayed for "DeviceListFor14841_Read" list on Permissions Pop-up
	And New Permission dropdown has disabled property "true" for "DeviceListFor14841_Read" list on Permissions Pop-up
	And New Permission dropdown has "You cannot change the permission for this list" tooltip for "DeviceListFor14841_Read" list on Permissions Pop-up

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @DAS14282 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatListPermissionCanBeChangedForEditSharedList
	When User clicks the Logout button
	When User clicks the Switch to Evergreen link
	And User clicks on the Login link
	And User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create custom list with "DeviceListFor14841_Edit" name
	Then "DeviceListFor14841_Edit" list is displayed to user
	When User clicks the List Details button
	And User select "Specific users / teams" sharing option
	And User clicks the "ADD USER" Action button
	And User selects the "Automation Admin 10" user for sharing
	And User select "Edit" in Select Access dropdown
	And User clicks the "ADD USER" Action button
	And User clicks the "ADD USER" Action button
	And User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	When User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	#create dashboard
	When Dashboard with "Dashboard for DAS14841_Edit" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                  | List                    | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841_Edit | DeviceListFor14841_Edit | Hostname | Count             | Count DESC |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can edit" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	And Widget "WidgetForDAS14841_Edit" displayed for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And User "Automation Admin 1" displayed for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And Current permission "Specific users / teams" displayed for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And New Permission "Do not change" displayed for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And New Permission dropdown has disabled property "true" for "DeviceListFor14841_Edit" list on Permissions Pop-up
	And New Permission dropdown has "You cannot change the permission for this list" tooltip for "DeviceListFor14841_Edit" list on Permissions Pop-up

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @DAS11120 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatListPermissionCanBeChangedForAdminSharedList
	When User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	When User clicks on the Login link
	And User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	When User clicks the Switch to Evergreen link
	
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create custom list with "DeviceListFor14841_Admin" name
	Then "DeviceListFor14841_Admin" list is displayed to user
	
	When User clicks the List Details button
	And User select "Specific users / teams" sharing option
	And User clicks the "ADD USER" Action button
	And User selects the "Automation Admin 10" user for sharing
	And User select "Admin" in Select Access dropdown
	And User clicks the "ADD USER" Action button
	And User clicks the "ADD USER" Action button
	
	When User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	When User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	When User clicks the Switch to Evergreen link
	#create dashboard
	When Dashboard with "Dashboard for DAS14841_Admin" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title                   | List                     | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841_Admin | DeviceListFor14841_Admin | Hostname | Count             | Count DESC |
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option on the Dashboards page
	Then Review Widget List Permissions is displayed to the User
	And Widget "WidgetForDAS14841_Admin" displayed for "DeviceListFor14841_Admin" list on Permissions Pop-up
	And User "Automation Admin 1" displayed for "DeviceListFor14841_Admin" list on Permissions Pop-up
	And Current permission "Specific users / teams" displayed for "DeviceListFor14841_Admin" list on Permissions Pop-up
	And New Permission "Do not change" displayed for "DeviceListFor14841_Admin" list on Permissions Pop-up
	When User selects "Everyone can see" permission for "DeviceListFor14841_Admin" list on Permissions Pop-up
	And User clicks the "UPDATE & SHARE" button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	And Permission "Everyone can see" displayed in Dashboard Details
	#login as user1 and check if list permission changed
	When User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	When User clicks on the Login link
	And User login with following credentials:
	| Username          | Password  |
	| automation_admin1 | m!gration |
	When User clicks the Switch to Evergreen link
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks Settings button for "DeviceListFor14841_Admin" list
	And User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And "Everyone can see" sharing option is selected

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15876 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckUserCanRemoveYourselfFromSharedDashboard
	#create dashboard and share it
	When Dashboard with "Dashboard for DAS15876" name created via API and opened
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for DAS15876" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User changes sharing type from "Private" to "Specific users"
	And User adds user to list of shared person
	| User                | Permission |
	| Automation Admin 10 | Admin      |
	Then User "automation_admin10" was added to shared list with "Admin" permission
	#login as user2
	When User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	And User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	And User clicks the Switch to Evergreen link
	#remove share
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for DAS15876" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User clicks Settings button for "automation_admin10" shared user
	And User selects "Remove" option from Settings
	Then There is no user in shared list
	And User sees "This dashboard does not exist or you do not have access to it" text in warning message on Dashboards submenu pane

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15550 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckUserCanEditWidgetFromSharedDashboard
	#create dashboard and share it
	When Dashboard with "Dashboard for DAS15550" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetForDAS15550 | All Applications | Application | Application | Count distinct    | Application ASC | 10        |
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for DAS15550" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User changes sharing type from "Private" to "Specific users"
	And User adds user to list of shared person
	| User                | Permission |
	| Automation Admin 10 | Edit       |
	Then User "automation_admin10" was added to shared list with "Edit" permission
	#login as user2
	When User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	And User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	And User clicks the Switch to Evergreen link
	#edit widget
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for DAS15550" dashboard
	And User clicks Manage in the list panel
	And User clicks Edit mode trigger on Dashboards page
	And User clicks Ellipsis menu for "WidgetForDAS15550" Widget on Dashboards page
	And User clicks "Edit" item from Ellipsis menu on Dashboards page
	And User updates Widget with following info:
	| WidgetType | Title                    | List | SplitBy | AggregateBy |
	|            | WidgetForDAS15550_Edited |      | Version | Application |
	Then User sees widget with the next name "WidgetForDAS15550_Edited" on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @DAS14915 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserWithEditRightsCanChangeDashboardName
	#create dashboard and share it
	When Dashboard with "Dashboard for DAS14915" name created via API and opened
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for DAS14915" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User changes sharing type from "Private" to "Specific users"
	And User adds user to list of shared person
	| User                | Permission |
	| Automation Admin 10 | Admin      |
	Then User "automation_admin10" was added to shared list with "Admin" permission
	#login as user2
	When User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	And User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	And User clicks the Switch to Evergreen link
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for DAS14915" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User changes dashboard name to "DashboardUpdated"
	Then Dashboard with "DashboardUpdated" title displayed in All Dashboards

@Evergreen @EvergreenJnr_DashboardsPage @DAS14915 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserWithAdminRightsCanAddUserInSharedSection
	#create dashboard and share it
	When Dashboard with "Dashboard for Share" name created via API and opened
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for Share" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User changes sharing type from "Private" to "Specific users"
	And User adds user to list of shared person
	| User                | Permission |
	| Automation Admin 10 | Admin      |
	Then User "automation_admin10" was added to shared list with "Admin" permission
	#login as user2
	When User clicks the Logout button
	Then User is logged out
	When User clicks the Switch to Evergreen link
	And User clicks on the Login link
	And User login with following credentials:
	| Username           | Password  |
	| automation_admin10 | m!gration |
	And User clicks the Switch to Evergreen link
	And User clicks Show Dashboards panel icon on Dashboards page
	And User clicks Settings button for "Dashboard for Share" dashboard
	And User clicks Manage in the list panel
	Then Permission panel is displayed to the user
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Edit       |
	Then User "Admin" was added to shared list with "Edit" permission
	When User clicks Settings button for "Admin" shared user
	And User selects "Remove" option from Settings
	And User adds user to list of shared person
	| User          | Permission |
	| Administrator | Read       |
	Then User "Admin" was added to shared list with "Read Only" permission