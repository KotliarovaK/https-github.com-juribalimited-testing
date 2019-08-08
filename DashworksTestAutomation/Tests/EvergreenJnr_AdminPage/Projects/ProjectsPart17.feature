﻿Feature: ProjectsPart17
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12154 @DAS12742 @DAS12872 @Cleanup @Project_Creation_and_Scope @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsNotDisplayedWhenDeletingListUsingInTheProjectThatWasDeleted
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "TestList0A78U9" name on "Devices" page
	Then "TestList0A78U9" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject6" in the "Project Name" field
	And User selects "TestList0A78U9" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then "Projects" page should be displayed to the user
	Then Success message is displayed and contains "The project has been created" text
	And There are no errors in the browser console
	When User enters "TestProject6" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList0A78U9" list
	And User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "list will be permanently deleted" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	And no Warning message is displayed in the lists panel

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12182 @DAS12999 @DAS13199 @DAS13297 @DAS12485 @DAS13803 @DAS13930 @Cleanup @Project_Creation_and_Scope @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatNumberOfApplicationsInProjectScopeIsCorrectlyUpdated
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject5" in the "Project Name" field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject5" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Devices" tab in the Project Scope Changes section
	Then "Devices to add (0 of 16819 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then All Associations are selected by default
	When User navigates to the "Device Scope" tab in the Scope section on the Project details page
	And User selects "Do not include owned devices" checkbox on the Project details page
	Then Scope List dropdown is disabled
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then following associations are disabled:
	| AssociationName                         |
	| Entitled to a device owned by the user  |
	| Installed on a device owned by the user |
	| Used on an owned device by any user     |
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 247 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Devices" tab in the Project Scope Changes section
	Then "Devices to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Details" tab
	And User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then There are no errors in the browser console
	When User clicks "Scope" tab
	And User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown

@Evergreen @AllLists @EvergreenJnr_AdminPage @AdminPage @Projects @DAS11886 @DAS12613 @DAS13199 @Cleanup @Project_Creation_and_Scope @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedAfterDeletingUsedForProjectLists 
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	And User create dynamic list with "ListForProject" name on "Users" page
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject1" in the "Project Name" field
	And User selects "ListForProject" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to the "ListForProject" list
	Then "ListForProject" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "list is used by 1 project, do you wish to proceed?" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject1" record in the grid
	Then Project "TestProject1" is displayed to user
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Admin page
	And Update Project buttons is disabled
	When User selects "Scope Details" tab on the Project details page
	When User selects "All Users" in the Scope Project details
	When User selects "Scope Changes" tab on the Project details page
	Then Warning message is not displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11977 @DAS11959 @DAS12553 @DAS11744 @DAS12742 @DAS12999 @DAS13199 @DAS13254 @DAS13323 @DAS13393 @DAS13803 @DAS13973 @Cleanup @Project_Creation_and_Scope @Projects @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatAfterApplyingDoNotIncludeDeviceOwnersListHas0ItemsInTheUsersTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject1" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject1" is displayed to user
	When User clicks "Details" tab
	And User changes Project Name to "NewProjectName"
	And User changes Project Short Name to "NewShort4875"
	And User changes Project Description to "45978DescriptionText"
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "Dutch" language on the Project details page
	And User opens menu for selected language
	Then User selects "Set as default" option for selected language
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then There are no errors in the browser console
	When User click on Back button
	And User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User clicks Actions button on the Projects page
	And User clicks Delete Project button
	And User clicks Delete button
	Then Delete button is displayed to the User on the Projects page
	When User cancels the selection of all rows on the Projects page
	Then Delete button is not displayed to the User on the Projects page
	When User enters "NewProjectName" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Do not include device owners" checkbox on the Project details page
	Then Scope List dropdown is disabled
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then following associations are disabled:
	| AssociationName                        |
	| Entitled to the device owner           |
	| Used by the device owner on any device |
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section 
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Include device owners" checkbox on the Project details page
	Then Scope List dropdown is active
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then All Associations are available
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section 
	Then "Users to add (0 of 14629 selected)" is displayed to the user in the Project Scope Changes section
	When User click on Back button
	And User enters "NewProjectName" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject1" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject1" is displayed to user
	When User clicks "Details" tab
	And User changes Project Name to "NewProjectName"
	And User changes Project Short Name to "NewShort4875"
#"UPDATE" Action button has been removed
	#And User clicks the "UPDATE" Action button
	#Then Success message is displayed and contains "The project details have been updated" text
	When User click on Back button
	And User enters "NewProjectName" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item