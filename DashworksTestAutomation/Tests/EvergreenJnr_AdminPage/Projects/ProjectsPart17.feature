﻿Feature: ProjectsPart17
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12154 @DAS12742 @DAS12872 @Cleanup @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsNotDisplayedWhenDeletingListUsingInTheProjectThatWasDeleted
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "TestList0A78U9" name on "Devices" page
	Then "TestList0A78U9" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters "TestProject6" in the "Project Name" field
	And User selects 'TestList0A78U9' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Page with 'Projects' header is displayed to user
	Then Success message is displayed and contains "The project has been created" text
	And There are no errors in the browser console
	When User enters "TestProject6" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "TestList0A78U9" list
	When User clicks Settings button for "TestList0A78U9" list
	Then Cog menu is displayed to the user
	When User clicks 'Delete' option in opened Cog-menu
	Then "TestList0A78U9 list will be permanently deleted" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	And no Warning message is displayed in the lists panel

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12182 @DAS12999 @DAS13199 @DAS13297 @DAS12485 @DAS13803 @DAS13930 @Cleanup @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckThatNumberOfApplicationsInProjectScopeIsCorrectlyUpdated
	When Project created via API and opened
	| ProjectName  | Scope     | ProjectTemplate | Mode               |
	| TestProject5 | All Users | None            | Standalone Project |
	Then Page with 'TestProject5' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Devices' tab on Project Scope Changes page
	Then "Devices to add (0 of 16819 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	Then All Associations are selected by default
	When User navigates to the 'Device Scope' tab on Project Scope Changes page
	And User selects "Do not include owned devices" checkbox on the Project details page
	Then Scope List dropdown is disabled
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	Then following associations are disabled:
	| AssociationName                         |
	| Entitled to a device owned by the user  |
	| Installed on a device owned by the user |
	| Used on an owned device by any user     |
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 247 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Devices' tab on Project Scope Changes page
	Then "Devices to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Details' left menu item
	And User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then There are no errors in the browser console
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown

@Evergreen @AllLists @EvergreenJnr_AdminPage @AdminPage @Projects @DAS11886 @DAS12613 @DAS13199 @Cleanup @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedAfterDeletingUsedForProjectLists 
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks on 'Username' column header
	And User create dynamic list with "ListForProject" name on "Users" page
	When Project created via API and opened
	| ProjectName  | Scope          | ProjectTemplate | Mode               |
	| TestProject1 | ListForProject | None            | Standalone Project |
	And User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User navigates to the "ListForProject" list
	Then "ListForProject" list is displayed to user
	When User clicks Settings button for "ListForProject" list
	Then Cog menu is displayed to the user
	When User clicks 'Delete' option in opened Cog-menu
	Then "list is used by 1 project, do you wish to proceed?" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks on 'TestProject1' cell from 'Project' column
	Then Page with 'TestProject1' header is displayed to user
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Admin page
	Then 'UPDATE ALL CHANGES' button is disabled
	When User navigates to the 'Scope Details' left menu item
	And User selects 'All Users' in the 'Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	Then Warning message is not displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11977 @DAS11959 @DAS12553 @DAS11744 @DAS12742 @DAS12999 @DAS13199 @DAS13254 @DAS13323 @DAS13393 @DAS13803 @DAS13973 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatAfterApplyingDoNotIncludeDeviceOwnersListHas0ItemsInTheUsersTab
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| TestProjectDAS11977 | All Devices | None            | Standalone Project |
	Then Page with 'TestProjectDAS11977' header is displayed to user
	When User navigates to the 'Details' left menu item
	And User changes Project Name to "NewProjectName"
	And User changes Project Short Name to "NewShort4875"
	And User changes Project Description to "45978DescriptionText"
	And User clicks 'ADD LANGUAGE' button 
	And User selects "Dutch" language on the Project details page
	And User opens menu for selected language
	Then User selects "Set as default" option for selected language
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then There are no errors in the browser console
	When User click on Back button
	And User selects all rows on the grid
	Then 'Actions' dropdown is displayed
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then Delete buttons are displayed to the User in Actions and Banner on the Projects page
	When User cancels the selection of all rows on the Projects page
	Then 'Actions' dropdown is not displayed
	Then 'DELETE' button is not displayed
	When User enters "NewProjectName" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	When User selects "Do not include device owners" checkbox on the Project details page
	Then Scope List dropdown is disabled
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	Then following associations are disabled:
	| AssociationName                        |
	| Entitled to the device owner           |
	| Used by the device owner on any device |
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Users' tab on Project Scope Changes page 
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	When User selects "Include device owners" checkbox on the Project details page
	Then Scope List dropdown is active
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	Then All Associations are available
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Users' tab on Project Scope Changes page 
	Then "Users to add (0 of 14629 selected)" is displayed to the user in the Project Scope Changes section
	When User click on Back button
	And User enters "NewProjectName" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| TestProjectDAS11977 | All Devices | None            | Standalone Project |
	Then Page with 'TestProjectDAS11977' header is displayed to user
	When User navigates to the 'Details' left menu item
	And User changes Project Name to "NewProjectName"
	And User changes Project Short Name to "NewShort4875"
#"UPDATE" Action button has been removed
	#And User clicks 'UPDATE' button 
	#Then Success message is displayed and contains "The project details have been updated" text
	When User click on Back button
	And User enters "NewProjectName" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item