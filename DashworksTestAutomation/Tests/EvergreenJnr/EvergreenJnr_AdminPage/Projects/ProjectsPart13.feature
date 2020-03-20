Feature: ProjectsPart13
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12892 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyFilteredListObjectsAreUsedAsAScopeOfProject
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Operating System" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Windows Vista  |
	When User Add And "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Desktop        |
	Then "57" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList4811" name on "Devices" page
	Then "DynamicList4811" list is displayed to user
	When Project created via API and opened
	| ProjectName        | Scope           | ProjectTemplate | Mode               |
	| DevicesProject1982 | DynamicList4811 | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 57 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @UpdatingName @DAS13096 @DAS15994 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChecksThatProjectNameEditedInSeniorIsUpdatedInAdminTab
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| 10_Project13096 | All Devices | None            | Standalone Project |
	Then Page with '10_Project13096' header is displayed to user
	When User click on Back button
	When User enters "10_Project13096" text in the Search field for "Project" column
	Then '10_Project13096' content is displayed in the 'Project' column
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "10_Project13096" Project
	Then Project with "10_Project13096" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User updates Project Name to "1_Project13096 upd on Senior" on Senior
	When User clicks "Update" button
	Then Success message is displayed with "Project was successfully updated" text
	When User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "1_Project13096 upd on Senior" text in the Search field for "Project" column
	Then '1_Project13096 upd on Senior' content is displayed in the 'Project' column
	When User selects all rows on the grid
	And User removes selected item
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12776 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateForDynamicList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	And User create dynamic list with "DynamicList5588" name on "Devices" page
	Then "DynamicList5588" list is displayed to user
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| TestProject12776 | All Devices | None            | Standalone Project |
	Then Page with 'TestProject12776' header is displayed to user
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects        |
	| SZ46M6IS71DPZ1 |
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects                          |
	| ACD252468 (Nicolas O. Mc Millan) |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '1 device will be added, 1 user will be added' text is displayed on inline tip banner
	Then multiselect is disabled
	When User navigates to the 'Devices' tab on Project Scope Changes page
	Then multiselect is disabled
	When User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	Then 'UPDATE ALL CHANGES' button is disabled
	And "Devices to add (0 of 17278 selected)" is displayed to the user in the Project Scope Changes section
	Then multiselect is not disabled
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14628 selected)" is displayed to the user in the Project Scope Changes section
	Then multiselect is not disabled
	When User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects                    |
	| AAK881049 (Miguel W. Owen) |
	Then 'UPDATE ALL CHANGES' button is not disabled
	When User navigates to the 'Devices' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects        |
	| 00SH8162NAS524 |
	Then 'UPDATE ALL CHANGES' button is not disabled
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12776 @DAS13973 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateForStaticList
	When User create static list with "StaticList12776" name on "Users" page with following items
	| ItemName            |
	| 00CFE13AAE104724AF5 |
	| 00BDBAEA57334C7C8F4 |
	| 000F977AC8824FE39B8 |
	Then "StaticList12776" list is displayed to user
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode                            |
	| TestProject12777 | All Users | None            | Clone from Evergreen to Project |
	Then Page with 'TestProject12777' header is displayed to user
	Then 'Clone Evergreen buckets to project buckets' content is displayed in 'Buckets' dropdown
	When User navigates to the 'Capacity' left menu item
	Then 'Clone Evergreen capacity units to project capacity units' content is displayed in 'Capacity Units' dropdown
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects                                |
	| 00BDBAEA57334C7C8F4 (Basa, Rogelio)    |
	| 00CFE13AAE104724AF5 (Hardieway, Linda) |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '2 users will be added' text is displayed on inline tip banner
	Then multiselect is disabled
	When User navigates to the 'Devices' tab on Project Scope Changes page
	Then multiselect is disabled
	When User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	Then 'UPDATE ALL CHANGES' button is disabled
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 41337 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Devices' tab on Project Scope Changes page
	Then multiselect is not disabled
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then multiselect is not disabled
	When User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects                             |
	| 000F977AC8824FE39B8 (Spruill, Shea) |
	Then 'UPDATE ALL CHANGES' button is not disabled
	And There are no errors in the browser console