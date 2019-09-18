Feature: DashboardSharing2
	Runs Dashboard sharing tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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
	When User clicks on 'Hostname' column header
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
	When User clicks on 'Hostname' column header
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


	#Sergiy: DAS14263 create test and recomment issue
	#When User clicks Dashboards Details icon on Dashboards page
	#Then Permission panel is displayed to the user
	#When User changes sharing type from "Private" to "Specific users / teams"
	#When User clicks the "ADD TEAM" Action button
	#When User selects the "Team 1061" team for sharing
	#And User select "Admin" in Select Access dropdown
	#When User clicks the "CANCEL" button on Dashboard Details
	#Then Team/User section in not displayed on Dashboard Details
