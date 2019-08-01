Feature: ProjectsPart13
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12892 @Cleanup @Cleanup @Projects @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyFilteredListObjectsAreUsedAsAScopeOfProject
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Operating System" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Windows Vista  |
	When User Add And "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Desktop        |
	Then "222" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList4811" name on "Devices" page
	Then "DynamicList4811" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject1982" in the "Project Name" field
	And User selects "DynamicList4811" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	When User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 222 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @UpdatingName @DAS13096 @DAS15994 @Cleanup @Projects @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatProjectNameEditedInSeniorIsUpdatedInAdminTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project13096" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "Project13096" is displayed to user
	When User click on Back button
	Then created Project with "Project13096" name is displayed correctly
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Project13096" Project
	Then Project with "Project13096" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User updates Project Name to "Project13096 upd on Senior" on Senior
	When User clicks "Update" button
	Then Success message is displayed with "Project was successfully updated" text
	When User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	And created Project with "Project13096 upd on Senior" name is displayed correctly
	When User enters "Project13096 upd on Senior" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12776 @Cleanup @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateForDynamicList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "DynamicList5588" name on "Devices" page
	Then "DynamicList5588" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks the "CREATE" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12776" in the "Project Name" field
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject12776" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| SZ46M6IS71DPZ1 |
	And User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                          |
	| ACD252468 (Nicolas O. Mc Millan) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "1 device will be added, 1 user will be added" text is displayed on the Admin page
	Then Objects to add panel is disabled
	When User clicks "Devices" tab in the Project Scope Changes section
	Then Objects to add panel is disabled
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then "UPDATE ALL CHANGES" Action button is disabled
	And "Devices to add (0 of 17278 selected)" is displayed to the user in the Project Scope Changes section
	Then Objects to add panel is active
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14628 selected)" is displayed to the user in the Project Scope Changes section
	Then Objects to add panel is active
	When User expands the object to add 
	And User selects following Objects
	| Objects                    |
	| AAK881049 (Miguel W. Owen) |
	Then "UPDATE ALL CHANGES" Action button is active
	When User clicks "Devices" tab in the Project Scope Changes section
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 00SH8162NAS524 |
	Then "UPDATE ALL CHANGES" Action button is active
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12776 @DAS13973 @Cleanup @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateForStaticList
	When User create static list with "StaticList12776" name on "Users" page with following items
	| ItemName            |
	| 00CFE13AAE104724AF5 |
	| 00BDBAEA57334C7C8F4 |
	| 000F977AC8824FE39B8 |
	Then "StaticList12776" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks the "CREATE" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12777" in the "Project Name" field
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject12777" is displayed to user
	When User clicks "Details" tab
	Then "Clone evergreen buckets to project buckets" content is displayed in "Buckets" dropdown
	When User clicks "Capacity" tab
	Then "Clone evergreen capacity units to project capacity units" content is displayed in "Capacity Units" dropdown
	When User clicks "Scope" tab
	When User selects "Scope Changes" tab on the Project details page
	And User expands the object to add 
	And User selects following Objects
	| Objects                                |
	| 00BDBAEA57334C7C8F4 (Basa, Rogelio)    |
	| 00CFE13AAE104724AF5 (Hardieway, Linda) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "2 users will be added" text is displayed on the Admin page
	Then Objects to add panel is disabled
	When User clicks "Devices" tab in the Project Scope Changes section
	Then Objects to add panel is disabled
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then "UPDATE ALL CHANGES" Action button is disabled
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 1 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Devices" tab in the Project Scope Changes section
	Then Objects to add panel is active
	When User clicks "Users" tab in the Project Scope Changes section
	Then Objects to add panel is active
	When User expands the object to add 
	And User selects following Objects
	| Objects                             |
	| 000F977AC8824FE39B8 (Spruill, Shea) |
	Then "UPDATE ALL CHANGES" Action button is active
	And There are no errors in the browser console