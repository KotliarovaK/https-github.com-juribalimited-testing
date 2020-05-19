Feature: ProjectsPart28
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS20115 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatCorrectTooltipIsDisplayedForProjectButtonWhenListContainsMeOrMyTeamFilters
	When User clicks '<List>' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "<Filter>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <Value>        |
	When User clicks Save button on the list panel
	When User create dynamic list with "<List>List_20115" name on "<List>" page
	Then "<List>List_20115" list is displayed to user
	When User clicks 'Create' dropdown
	Then tooltip is displayed with "<Tooltip>" text for Create Project button
	Then Create Project button is disabled on the Base Dashboard Page

Examples:
	| List    | Filter                                                                                                        | Value   | Tooltip                                                                                                   |
	| Devices | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Computer Read Only Task in Self Service (Owner) | Me      | This list uses, or refers to a list that uses, a value of "Me" which is not valid as a project scope      |
	| Users   | Windows7Mi: Communication \ Send Applications List - User Object Task (Team)                                  | My Team | This list uses, or refers to a list that uses, a value of "My Team" which is not valid as a project scope |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS20115 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectTooltipIsDisplayedForProjectDetailsWhenListContainsMeFilters
	When User clicks 'Devices' on the left-hand menu
	When User clicks on 'Hostname' column header
	When User create dynamic list with "DeviceListForProject_20115" name on "Devices" page
	Then "DeviceListForProject_20115" list is displayed to user
	When Project created via API
	| ProjectName   | Scope                      | ProjectTemplate | Mode               |
	| Project_20115 | DeviceListForProject_20115 | None            | Standalone Project |
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "DeviceListForProject_20115" list
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Computer Read Only Task in Self Service (Owner)" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Me             |
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When User navigates to "Project_20115" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'This list uses, or refers to a list that uses, a value of "Me" which is not valid as a project scope' error message is displayed for 'Scope' dropdown
	When User navigates to the 'Scope Changes' left submenu item
	Then 'This list uses, or refers to a list that uses, a value of 'Me' or 'My Team' which is not valid as a project scope, this must be updated before proceeding' text is displayed on inline tip banner
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "DeviceListForProject_20115" list
	When User clicks the Filters button
	When User have removed "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Computer Read Only Task in Self Service (Owner)" filter
	When User clicks Add New button on the Filter panel
	When User add "2004: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When User navigates to "Project_20115" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'This list uses, or refers to a list that uses, an In Scope filter which is not valid as a project scope' error message is displayed for 'Scope' dropdown
	When User navigates to the 'Scope Changes' left submenu item
	Then 'This list uses an In Scope filter or refers to a list that uses an In Scope filter, this must be updated before proceeding' text is displayed on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS20115 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectTooltipIsDisplayedForProjectDetailsWhenListContainsMyTeamFilters
	When User clicks 'Users' on the left-hand menu
	When User clicks on 'Username' column header
	When User create dynamic list with "UsersListForProject_20115" name on "Users" page
	Then "UsersListForProject_20115" list is displayed to user
	When Project created via API
	| ProjectName        | Scope                     | ProjectTemplate | Mode               |
	| ProjectUsers_20115 | UsersListForProject_20115 | None            | Standalone Project |
	When User clicks 'Users' on the left-hand menu
	When User navigates to the "UsersListForProject_20115" list
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "Windows7Mi: Communication \ Send Applications List - User Object Task (Team)" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| My Team        |
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When User navigates to "ProjectUsers_20115" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'This list uses, or refers to a list that uses, a value of "My Team" which is not valid as a project scope' error message is displayed for 'Scope' dropdown
	When User navigates to the 'Scope Changes' left submenu item
	Then 'This list uses, or refers to a list that uses, a value of 'Me' or 'My Team' which is not valid as a project scope, this must be updated before proceeding' text is displayed on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS20928 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatValidationErrorAppearsAfterUsingBrokenListForApplicationScope
	When User creates broken list with 'UsersBroken_20928' name on 'Users' page
	When Project created via API and opened
	| ProjectName  | Scope     | ProjectTemplate | Mode               |
	| Projec_20928 | All Users | None            | Standalone Project |
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'List validated' success message for 'App Owner Scope' dropdown
	When User selects 'UsersBroken_20928' in the 'App Owner Scope' dropdown
	Then 'This list has errors' error message is displayed for 'App Owner Scope' dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS20877 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectValidationMessageAppearsForScopeFieldIfListHasArhivedDevices
	When User clicks 'Devices' on the left-hand menu
	When User clicks on 'Hostname' column header
	When User create dynamic list with "DeviceList_20877" name on "Devices" page
	Then "DeviceList_20877" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	When User sets includes archived devices in 'true'
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "Device (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList     | Association |
	| DeviceList_20877 |             |
	When User create dynamic list with "DeviceListForProject_20877" name on "Devices" page
	Then "DeviceListForProject_20877" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Projects' left menu item
	When User clicks 'CREATE PROJECT' button 
	When User enters 'Project_20877' text to 'Project Name' textbox
	When User selects 'DeviceListForProject_20877' option from 'Scope' autocomplete
	Then 'This list may contain archived devices which will not be onboarded' message is displayed for 'Scope' field
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with 'Project_20877' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'This list may contain archived devices which will not be onboarded' error message is displayed for 'Scope' dropdown
	When User clicks 'Devices' on the left-hand menu
	When User clicks 'Delete' option in cogmenu for 'DeviceList_20877' list
	When User confirms list removing
	When User navigates to "Project_20877" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'This list has errors' error message is displayed for 'Scope' dropdown
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "DeviceListForProject_20877" list
	When User clicks the Filters button
	When User have removed " Device" filter
	When User sets includes archived devices in 'false'
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When User navigates to "Project_20877" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'This is a private list owned by you, others will not be able to onboard into this project' error message is displayed for 'Scope' dropdown
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "DeviceListForProject_20877" list
	When User clicks the Permissions button
	When User selects 'Everyone can edit' in the 'Sharing' dropdown
	When User navigates to "Project_20877" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'List validated' success message for 'Scope' dropdown
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "DeviceListForProject_20877" list
	When User sets includes archived devices in 'true'
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When Project created via API and opened
	| ProjectName       | Scope     | ProjectTemplate | Mode               |
	| UserProject_20877 | All Users | None            | Standalone Project |
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	When User navigates to the 'Device Scope' tab on Project Scope Changes page
	When User selects 'DeviceListForProject_20877' in the 'Device Scope' dropdown
	Then 'List validated' success message for 'Device Scope' dropdown