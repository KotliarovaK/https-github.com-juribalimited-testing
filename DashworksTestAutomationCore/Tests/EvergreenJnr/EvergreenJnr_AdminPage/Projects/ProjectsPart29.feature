Feature: ProjectsPart29
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Project_Creation_and_Scope @Projects @DAS20759 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatProjectCanBeCreatedWithUnknownName
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Projects' left menu item
	When User clicks 'CREATE PROJECT' button 
	When User enters 'Unknown' text to 'Project Name' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "Unknown" text in the Search field for "Project" column
	Then 'Unknown' content is displayed in the 'Project' column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Project_Creation_and_Scope @Projects @DAS20759 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatReadinessWithUnknownTooltipDisplayedCorrectly
	When Project created via API and opened
	| ProjectName          | Scope       | ProjectTemplate | Mode               |
	| DevicesProject_20759 | All Devices | None            | Standalone Project |
	When User navigates to the 'Readiness' left menu item
	When User enters "Unknown" text in the Search field for "Tooltip" column
	Then 'Unknown' content is displayed in the 'Tooltip' column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Project_Creation_and_Scope @Projects @DAS17433 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatProjectCanBeCreatedFromMailboxesListHavingProjectNameFiltered
	When User clicks 'Mailboxes' on the left-hand menu
	When User navigates to 'mailboxes?$filter=(project_48_shortName%20EQUALS%20('hamiltkz%40rdlabs.local'))' url via address line
	Then table content is present
	When User create dynamic list with "List_17433" name on "Mailboxes" page
	When Project created via API and opened
	| ProjectName            | Scope      | ProjectTemplate | Mode               |
	| MailboxesProject_17433 | List_17433 | None            | Standalone Project |
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'List_17433' content is displayed in 'Scope' dropdown