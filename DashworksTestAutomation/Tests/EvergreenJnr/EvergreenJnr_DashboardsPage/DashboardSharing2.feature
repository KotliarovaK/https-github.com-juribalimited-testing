Feature: DashboardSharing2
	Runs Dashboard sharing tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @DAS11120 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatListPermissionCanBeChangedForAdminSharedList
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username          | Password  |
	| automation_admin1 | m!gration |
	#create and share list
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	Then table content is present
	When User create custom list with "ADeviceListFor14841_Admin" name
	Then "ADeviceListFor14841_Admin" list is displayed to user
	When User clicks the List Details button
	When User select "Specific users / teams" sharing option
	When User clicks 'ADD USER' button 
	When User selects the "Automation Admin 10" user for sharing
	When User select "Admin" in Select Access dropdown
	When User clicks 'ADD USER' button 
	When User clicks 'ADD USER' button 
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password  |
	| automation_admin10 | m!gration |
	#create dashboard
	When Dashboard with 'Dashboard for DAS14841_Admin' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title                   | List                      | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841_Admin | ADeviceListFor14841_Admin | Hostname | Count             | Count DESC |
	Then 'WidgetForDAS14841_Admin' Widget is displayed to the user
	#display permission modal
	When User clicks Dashboards Details icon on Dashboards page
	Then User sees Dashboards context menu on Dashboards page
	When User select "Everyone can see" sharing option
	Then Review Widget List Permissions is displayed to the User
	Then Widget 'WidgetForDAS14841_Admin' displayed for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	Then User 'Automation Admin 1' displayed for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	Then Current permission 'Specific users / teams' displayed for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	Then New Permission 'Do not change' displayed for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	When User selects 'Everyone can see' permission for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	When User clicks the 'UPDATE & SHARE' button on Permissions Pop-up
	Then Review Widget List Permissions is not displayed to the User
	Then "Everyone can see" sharing option is selected
	#login as user1 and check if list permission changed
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username          | Password  |
	| automation_admin1 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks Settings button for "ADeviceListFor14841_Admin" list
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	Then "Everyone can see" sharing option is selected

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15876 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckUserCanRemoveYourselfFromSharedDashboard
	#create dashboard and share it
	When Dashboard with 'Dashboard for DAS15876' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for DAS15876' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User select "Specific users" sharing option
	When User adds user to list of shared person
	| User                | Permission |
	| Automation Admin 10 | Admin      |
	Then User 'automation_admin10' was added to shared list with 'Admin' permission of Details panel
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password  |
	| automation_admin10 | m!gration |
	#remove share
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for DAS15876' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User clicks 'Remove' option in Cog-menu for 'automation_admin10' user on Details panel
	Then There is no user in shared list of Details panel
	Then User sees 'This dashboard does not exist or you do not have access to it' text in warning message on Dashboards submenu pane

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15550 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckUserCanEditWidgetFromSharedDashboard
	#create dashboard and share it
	When Dashboard with 'Dashboard for DAS15550' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetForDAS15550 | All Applications | Application | Application | Count distinct    | Application ASC | 10        |
	Then 'WidgetForDAS15550' Widget is displayed to the user
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for DAS15550' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User select "Specific users" sharing option
	When User adds user to list of shared person
	| User                | Permission |
	| Automation Admin 10 | Edit       |
	Then User 'automation_admin10' was added to shared list with 'Edit' permission of Details panel
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password  |
	| automation_admin10 | m!gration |
	#edit widget
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for DAS15550' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	When User clicks Edit mode trigger on Dashboards page
	When User clicks Ellipsis menu for 'WidgetForDAS15550' Widget on Dashboards page
	When User clicks 'Edit' item from Ellipsis menu on Dashboards page
	When User updates Widget with following info:
	| WidgetType | Title                    | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetForDAS15550_Edited | All Applications | Application | Application | Count distinct    | Application ASC | 5         |
	Then 'WidgetForDAS15550_Edited' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @DAS14915 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserWithEditRightsCanChangeDashboardName
	#create dashboard and share it
	When Dashboard with 'Dashboard for DAS14915' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for DAS14915' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User select "Specific users" sharing option
	When User adds user to list of shared person
	| User                | Permission |
	| Automation Admin 10 | Admin      |
	Then User 'automation_admin10' was added to shared list with 'Admin' permission of Details panel
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password  |
	| automation_admin10 | m!gration |
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for DAS14915' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User changes dashboard name to 'DashboardUpdated'
	Then Dashboard with 'DashboardUpdated' title displayed in All Dashboards

@Evergreen @EvergreenJnr_DashboardsPage @DAS14915 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserWithAdminRightsCanAddUserInSharedSection
	#create dashboard and share it
	When Dashboard with 'Dashboard for Share' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for Share' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User select "Specific users" sharing option
	When User adds user to list of shared person
	| User                | Permission |
	| Automation Admin 10 | Admin      |
	Then User 'automation_admin10' was added to shared list with 'Admin' permission of Details panel
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password  |
	| automation_admin10 | m!gration |
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks Settings button for 'Dashboard for Share' dashboard
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Edit       |
	Then User 'Admin' was added to shared list with 'Edit' permission of Details panel
	When User clicks 'Remove' option in Cog-menu for 'Admin' user on Details panel
	When User adds user to list of shared person
	| User          | Permission |
	| Administrator | Read       |
	Then User 'Admin' was added to shared list with 'Read Only' permission of Details panel

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17592 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardHasTranslatedWidgetRefferedToUnavailableList
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password  |
	| automation_admin10 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Mobile         |
	When User waits for three seconds
	When User create dynamic list with "ADevicesList17592" name on "Devices" page
	Then "ADevicesList17592" list is displayed to user
	When User clicks the List Details button
	When User select "Specific users / teams" sharing option
	When User clicks 'ADD USER' button 
	When User selects the "Automation Admin 1" user for sharing
	When User select "Read" in Select Access dropdown
	When User clicks 'ADD USER' button 
	When User clicks 'ADD USER' button 
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username          | Password  |
	| automation_admin1 | m!gration |
	When Dashboard with 'Dashboard_DAS17592' name created via API and opened
	When User clicks Edit mode trigger on Dashboards page
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS17592 | ADevicesList17592 | 10      | 10         |
	Then 'Widget_For_DAS17592' Widget is displayed to the user
	When User language is changed to "Deutsch" via API
	When User clicks Dashboards Details icon on Dashboards page
	When User expands the list of shared lists
	Then User sees table headers as 'Widget' and 'Liste'
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password  |
	| automation_admin10 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks Settings button for "ADevicesList17592" list
	When User clicks 'Manage' option in opened Cog-menu
	Then Details panel is displayed to the user
	When User clicks 'Remove' option in Cog-menu for 'automation_admin1' user on Details panel
	Then There is no user in shared list of Details panel
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username          | Password  |
	| automation_admin1 | m!gration |
	When User language is changed to "Deutsch" via API
	When Dashboard with 'Dashboard_DAS17592' name is opened via API
	Then 'Widget_For_DAS17592' Widget is displayed to the user
	Then There are no errors in the browser console
	When User clicks Edit mode trigger on Dashboards page
	Then User sees 'Dieses Widget bezieht sich auf eine nicht verfügbare Liste.' text in '2' warning messages on Dashboards page


	#Sergiy: DAS14263 create test and recomment issue
	#When User clicks Dashboards Details icon on Dashboards page
	#Then Permission panel is displayed to the user
	#When User changes sharing type from "Private" to "Specific users / teams"
	#When User clicks 'ADD TEAM' button 
	#When User selects the "Team 1061" team for sharing
	#And User select "Admin" in Select Access dropdown
	#When User clicks the "CANCEL" button on Dashboard Details
	#Then Team/User section in not displayed on Dashboard Details