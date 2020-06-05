Feature: ProjectsPart5
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11881 @DAS12999 @DAS13297 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatEmptyGreenAlertLineIsNotDisplayedOnProjectScopeChangesPageAfterMakingSomeChangesOnScopePage
	When Project created via API and opened
	| ProjectName   | Scope     | ProjectTemplate | Mode               |
	| TestName11881 | All Users | None            | Standalone Project |
	Then Page with 'TestName11881' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects "Do not include applications" checkbox on the Project details page
	Then Scope List dropdown is disabled
	Then 'Entitled to the user' checkbox is disabled
	Then 'Entitled to a device owned by the user' checkbox is disabled
	Then 'Installed on a device owned by the user' checkbox is disabled
	Then 'Used by the user on any device' checkbox is disabled
	Then 'Used by the user on a device they own' checkbox is disabled
	Then 'Used on an owned device by any user' checkbox is disabled
	When User navigates to the 'Scope Changes' left menu item
	Then inline info banner is not displayed
	Then inline success banner is not displayed
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects "Include applications" checkbox on the Project details page
	Then 'Entitled to the user' checkbox is checked
	Then 'Entitled to a device owned by the user' checkbox is checked
	Then 'Installed on a device owned by the user' checkbox is checked
	Then 'Used by the user on any device' checkbox is checked
	Then 'Used by the user on a device they own' checkbox is checked
	Then 'Used on an owned device by any user' checkbox is checked
	Then Scope List dropdown is active
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12155 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatScopePanelHaveCorrectlySizeWhenUsedListWithLongName
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	And User create dynamic list with "VERYLONGLOOOOOOOOOOOOOOOOOOOOOOOOONGNAME" name on "Devices" page
	Then "VERYLONGLOOOOOOOOOOOOOOOOOOOOOOOOONGNAME" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User clicks in the Scope field on the Admin page
	Then Scope DDL have the "508" Width

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12349 @DAS12364 @DAS13199 @DAS15685 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThat500ISEInvalidColumnNameIsNotDisplayedWhenUsedAppSavedListForFilteringDeviceList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" without added column and following value:
	| Values |
	| 8      |
	And User create dynamic list with "ListName12349" name on "Applications" page
	Then "ListName12349" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList  | Association    |
	| ListName12349 | Used on device |
	Then "Any Application" filter is added to the list
	And "94" rows are displayed in the agGrid
	And "Any Application in list ListName12349 used on device" is displayed in added filter info
	And "(Application (Saved List) = ListName12349 ASSOCIATION = ("used on device"))" text is displayed in filter container
	When User create dynamic list with "SavedList12349" name on "Devices" page
	Then "SavedList12349" list is displayed to user
	When Project created via API and opened
	| ProjectName      | Scope          | ProjectTemplate | Mode               |
	| TestProject12349 | SavedList12349 | None            | Standalone Project |
	Then Page with 'TestProject12349' header is displayed to user
	And There are no errors in the browser console
	Then Error message is not displayed
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User expands multiselect to add objects 
	And User expands multiselect and selects following Objects
	| Objects         |
	| 0QLZFK7RHMWJLQM |
	| 0RGBQGA7XOOPJSW |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	Then There are no errors in the browser console
	Then Error message is not displayed
	When User navigates to the 'Scope Details' left menu item
	Then There are no errors in the browser console
	Then Error message is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12777 @DAS13973 @DAS13530 @Project_Creation_and_Scope @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreatingProjectWithCloneEvergreenBucketsToProjectBuckets
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'TestProject22' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	And There are no errors in the browser console
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "TestProject22" checkbox from String Filter with item list on the Admin page
	And User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then 'Unassigned' content is displayed in the 'Maps to Evergreen' column
	When User navigates to the 'Capacity Units' left menu item
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "TestProject22" checkbox from String Filter with item list on the Admin page
	And User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then 'Unassigned' content is displayed in the 'Maps to Evergreen' column
	When User navigates to the 'Projects' left menu item
	When User enters "TestProject22" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item