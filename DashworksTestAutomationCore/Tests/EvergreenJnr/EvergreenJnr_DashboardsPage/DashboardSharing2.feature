Feature: DashboardSharing2
	Runs Dashboard sharing tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS14841 @DAS11120 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatListPermissionCanBeChangedForAdminSharedList
	When User create new User via API
	| Username   | Email | FullName | Password  | Roles                 |
	| DAS14841_1 | Value | Test1    | m!gration | Project Administrator |
	| DAS14841_2 | Value | Test2    | m!gration | Project Administrator |
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS14841_1 | m!gration |
	#create and share list
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	Then table content is present
	When User create dynamic list with "ADeviceListFor14841_Admin" name on "Devices" page
	Then "ADeviceListFor14841_Admin" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User adds user to list of shared person
	| User  | Permission |
	| Test2 | Admin      |
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS14841_2 | m!gration |
	#create dashboard
	When Dashboard with 'Dashboard for DAS14841_Admin' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title                   | List                      | SplitBy  | AggregateFunction | OrderBy    |
	| Table      | WidgetForDAS14841_Admin | ADeviceListFor14841_Admin | Hostname | Count             | Count DESC |
	Then 'WidgetForDAS14841_Admin' Widget is displayed to the user
	#display permission modal
	When User clicks the Dashboard Permissions button
	When User selects 'Everyone can see' in the 'Sharing' dropdown
	Then Review Widget List Permissions is displayed to the User
	Then Widget 'WidgetForDAS14841_Admin' displayed for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	Then User 'Test1' displayed for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	Then Current permission 'Specific users / teams' displayed for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	Then New Permission 'Do not change' displayed for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	When User selects 'Everyone can see' permission for 'ADeviceListFor14841_Admin' list on Permissions Pop-up
	When User clicks 'UPDATE & SHARE' button on popup
	Then Review Widget List Permissions is not displayed to the User
	Then 'Everyone can see' content is displayed in 'Sharing' dropdown
	#login as user1 and check if list permission changed
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS14841_1 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Manage' option in cogmenu for 'ADeviceListFor14841_Admin' list
	When User clicks the Permissions button
	Then 'Everyone can see' content is displayed in 'Sharing' dropdown

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15876 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckUserCanRemoveYourselfFromSharedDashboard
	When User create new User via API
	| Username   | Email | FullName  | Password  | Roles                 |
	| DAS15876_1 | Value | FN15876_1 | m!gration | Project Administrator |
	| DAS15876_2 | Value | FN15876_2 | m!gration | Project Administrator |
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS15876_1 | m!gration |
	#create dashboard and share it
	When Dashboard with 'Dashboard for DAS15876' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Manage' option in cogmenu for 'Dashboard for DAS15876' list
	When User clicks the Dashboard Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User adds user to list of shared person
	| User      | Permission |
	| FN15876_2 | Admin      |
	Then User 'DAS15876_2' was added to shared list with 'Admin' permission of Details panel
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS15876_2 | m!gration |
	#remove share
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Manage' option in cogmenu for 'Dashboard for DAS15876' list
	When User clicks the Dashboard Permissions button
	When User clicks 'Remove' option in Cog-menu for 'DAS15876_2' user on Details panel
	Then There is no user in shared list of Details panel
	Then User sees 'This dashboard does not exist or you do not have access to it' text in warning message on Dashboards submenu pane

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15550 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckUserCanEditWidgetFromSharedDashboard
	When User create new User via API
	| Username   | Email | FullName  | Password  | Roles                 |
	| DAS15550_1 | Value | FN15550_1 | m!gration | Project Administrator |
	| DAS15550_2 | Value | FN15550_2 | m!gration | Project Administrator |
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS15550_1 | m!gration |
	#create dashboard and share it
	When Dashboard with 'Dashboard for DAS15550' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetForDAS15550 | All Applications | Application | Application | Count distinct    | Application ASC | 10        |
	Then 'WidgetForDAS15550' Widget is displayed to the user
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Manage' option in cogmenu for 'Dashboard for DAS15550' list
	When User clicks the Dashboard Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User adds user to list of shared person
	| User      | Permission |
	| FN15550_2 | Edit       |
	Then User 'DAS15550_2' was added to shared list with 'Edit' permission of Details panel
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS15550_2 | m!gration |
	#edit widget
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Manage' option in cogmenu for 'Dashboard for DAS15550' list
	When User checks 'Edit mode' slide toggle
	When User clicks 'Edit' menu option for 'WidgetForDAS15550' widget
	When User updates Widget with following info:
	| WidgetType | Title                    | List             | SplitBy     | AggregateBy | AggregateFunction | OrderBy         | MaxValues |
	| Table      | WidgetForDAS15550_Edited | All Applications | Application | Application | Count distinct    | Application ASC | 5         |
	Then 'WidgetForDAS15550_Edited' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @DAS14915 @DAS12974 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserWithEditRightsCanChangeDashboardName
	When User create new User via API
	| Username   | Email | FullName  | Password  | Roles                 |
	| DAS14915_1 | Value | FN14915_1 | m!gration | Project Administrator |
	| DAS14915_2 | Value | FN14915_2 | m!gration | Project Administrator |
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS14915_1 | m!gration |
	#create dashboard and share it
	When Dashboard with 'Dashboard for DAS14915' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Manage' option in cogmenu for 'Dashboard for DAS14915' list
	When User clicks the Dashboard Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User adds user to list of shared person
	| User      | Permission |
	| FN14915_2 | Admin      |
	Then User 'DAS14915_2' was added to shared list with 'Admin' permission of Details panel
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS14915_2 | m!gration |
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Manage' option in cogmenu for 'Dashboard for DAS14915' list
	Then Details panel is displayed to the user
	When User changes dashboard name to 'DashboardUpdated'
	Then 'DashboardUpdated' list is displayed in the Lists panel
	#12974 favorite for shared
	When User selects state 'true' for 'Favourite Dashboard' checkbox
	Then Dashboard with name 'DashboardUpdated' marked as favorite
	When User selects state 'false' for 'Favourite Dashboard' checkbox
	Then Dashboard with name 'DashboardUpdated' not marked as favorite
	When User clicks 'Make favourite' option in cogmenu for 'DashboardUpdated' list
	Then Dashboard with name 'DashboardUpdated' marked as favorite
	When User clicks 'Unfavourite' option in cogmenu for 'DashboardUpdated' list
	Then Dashboard with name 'DashboardUpdated' not marked as favorite
	#12974 default for shared
	When Dashboard with 'NewDefaultDashboardForDAS12974' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Set default' option in cogmenu for 'NewDefaultDashboardForDAS12974' list
	Then Dashboard with name 'NewDefaultDashboardForDAS12974' marked as default
	Then Dashboard with name 'DashboardUpdated' not marked as default

@Evergreen @EvergreenJnr_DashboardsPage @DAS14915 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserWithAdminRightsCanAddUserInSharedSection
	When User create new User via API
	| Username   | Email | FullName  | Password  | Roles                 |
	| DAS14915_3 | Value | FN14915_3 | m!gration | Project Administrator |
	| DAS14915_4 | Value | FN14915_4 | m!gration | Project Administrator |
	| DAS14915_5 | Value | FN14915_5 | m!gration | Project Administrator |
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS14915_3 | m!gration |
	#create dashboard and share it
	When Dashboard with 'Dashboard for Share' name created via API and opened
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Manage' option in cogmenu for 'Dashboard for Share' list
	When User clicks the Dashboard Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User adds user to list of shared person
	| User      | Permission |
	| FN14915_4 | Admin      |
	Then User 'DAS14915_4' was added to shared list with 'Admin' permission of Details panel
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS14915_4 | m!gration |
	When User clicks Show Dashboards panel icon on Dashboards page
	When User clicks 'Manage' option in cogmenu for 'Dashboard for Share' list
	When User clicks the Dashboard Permissions button
	When User adds user to list of shared person
	| User      | Permission |
	| FN14915_5 | Edit       |
	Then User 'DAS14915_5' was added to shared list with 'Edit' permission of Details panel
	When User clicks 'Remove' option in Cog-menu for 'DAS14915_5' user on Details panel
	When User adds user to list of shared person
	| User      | Permission |
	| FN14915_5 | Read       |
	Then User 'DAS14915_5' was added to shared list with 'Read Only' permission of Details panel

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17592 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDashboardHasTranslatedWidgetRefferedToUnavailableList
	When User create new User via API
	| Username   | Email | FullName  | Password  | Roles                 |
	| DAS17592_1 | Value | FN17592_1 | m!gration | Project Administrator |
	| DAS17592_2 | Value | FN17592_2 | m!gration | Project Administrator |
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS17592_1 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Mobile         |
	Then table content is present
	When User create dynamic list with "ADevicesList17592" name on "Devices" page
	Then "ADevicesList17592" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User adds user to list of shared person
	| User      | Permission |
	| FN17592_2 | Read       |
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS17592_2 | m!gration |
	When Dashboard with 'Dashboard_DAS17592' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS17592 | ADevicesList17592 | 10      | 10         |
	Then 'Widget_For_DAS17592' Widget is displayed to the user
	When User language is changed to "Deutsch" via API
	When User clicks the Dashboard Details button
	When User expands the list of shared lists
	Then User sees table headers as 'Widget' and 'Liste'
	#login as user1
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS17592_1 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Manage' option in cogmenu for 'ADevicesList17592' list
	When User clicks the Permissions button
	When User clicks 'Remove' option in Cog-menu for 'DAS17592_2' user on Details panel
	Then There is no user in shared list of Details panel
	#login as user2
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS17592_2 | m!gration |
	When User language is changed to "Deutsch" via API
	When Dashboard with 'Dashboard_DAS17592' name is opened via API
	Then 'Widget_For_DAS17592' Widget is displayed to the user
	Then There are no errors in the browser console
	When User checks 'Modus bearbeiten' slide toggle
	Then User sees 'Dieses Widget bezieht sich auf eine nicht verfügbare Liste.' text in warning message of 'Widget_For_DAS17592' widget on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18880 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTaskMeOwnerValuesFiltersCanBeUsedInSharedWidgets
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password |
	| User(Me) | 111111   |
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "s.Me/MyPr: Stg1 \ S.task1 (Owner)" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Me             |
	Then table content is present
	When User create dynamic list with "aMyDeviceListForDAS18880" name on "Devices" page
	Then "aMyDeviceListForDAS18880" list is displayed to user
	When Dashboard with 'Dashboard#18880My' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title     | List                     | SplitBy                           | AggregateFunction | OrderBy                               | MaxValues |
	| Table      | DAS-18880 | aMyDeviceListForDAS18880 | s.Me/MyPr: Stg1 \ S.task1 (Owner) | Count             | s.Me/MyPr: Stg1 \ S.task1 (Owner) ASC | 10        |
	Then 'DAS-18880' Widget is displayed to the user
	Then '5' count is displayed for 'User(Me)' in the table Widget
	When User clicks the Dashboard Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	Then Review Widget List Permissions is displayed to the User
	When User selects 'Everyone can edit' permission for 'aMyDeviceListForDAS18880' list on Permissions Pop-up
	When User clicks 'UPDATE & SHARE' button 
	When User adds user to list of shared person
	| User      | Permission |
	| User(Me)2 | Admin      |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username  | Password |
	| User(Me)2 | 111111   |
	When User clicks Show Dashboards panel icon on Dashboards page
	When User navigates to the "Dashboard#18880My" list
	Then 'This list does not contain any rows' message is displayed in 'DAS-18880' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18880 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatTaskTeamOwnerValuesFiltersCanBeUsedInSharedWidgets
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password |
	| User(Me) | 111111   |
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "s.Me/MyPr: Stg1 \ S.task1 (Team)" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| My Team        |
	Then table content is present
	When User create dynamic list with "aTeamDeviceListForDAS18880" name on "Devices" page
	Then "aTeamDeviceListForDAS18880" list is displayed to user
	When Dashboard with 'Dashboard#18880Team' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title     | List                       | SplitBy                          | AggregateFunction | OrderBy                              | MaxValues |
	| Table      | DAS-18880 | aTeamDeviceListForDAS18880 | s.Me/MyPr: Stg1 \ S.task1 (Team) | Count             | s.Me/MyPr: Stg1 \ S.task1 (Team) ASC | 10        |
	Then 'DAS-18880' Widget is displayed to the user
	Then '8' count is displayed for 's.TeamMe/My' in the table Widget
	When User clicks the Dashboard Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	Then Review Widget List Permissions is displayed to the User
	When User selects 'Everyone can edit' permission for 'aTeamDeviceListForDAS18880' list on Permissions Pop-up
	When User clicks 'UPDATE & SHARE' button 
	When User adds user to list of shared person
	| User      | Permission |
	| User(Me)2 | Admin      |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username  | Password |
	| User(Me)2 | 111111   |
	When User clicks Show Dashboards panel icon on Dashboards page
	When User navigates to the "Dashboard#18880Team" list
	Then 'This list does not contain any rows' message is displayed in 'DAS-18880' widget