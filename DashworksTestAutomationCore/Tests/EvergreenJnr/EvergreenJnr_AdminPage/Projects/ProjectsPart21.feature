Feature: ProjectsPart21
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS13498 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatChangingTheProjectNameOrShortNameInSeniorIsReflectedInEvergreen
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName     | ShortName | Description | Type |
	| SnrProject13498 | 13498Pr   |             |      |
	And User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "SnrProject13498" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then "SnrProject13498" content is displayed in "Project Name" field
	And "13498Pr" content is displayed in "Project Short Name" field
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "SnrProject13498" Project
	Then Project with "SnrProject13498" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User updates Project Name to "13498NewProjectName" on Senior
	And User updates Project Short Name to "13498ShN" on Senior
	When User clicks "Update" button
	And User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "13498NewProjectName" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then "13498NewProjectName" content is displayed in "Project Name" field
	And "13498ShN" content is displayed in "Project Short Name" field
	When User clicks 'Projects' header breadcrumb
	And User enters "13498NewProjectName" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @UpdatingName @Senior_Projects @DAS13501 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatNameForProjectThatCreatedInSeniorWasUpdatedCorrectlyInAdminPage
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName     | ShortName | Description | Type |
	| ProjectDAS13501 | 13501     |             |      |
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "ProjectDAS13501" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User enters 'ProjectDAS13501 upd' text to 'Project Name' textbox
	Then There are no errors in the browser console
	When User click on Back button
	And User enters "ProjectDAS13501 upd" text in the Search field for "Project" column
	Then "ProjectDAS13501 upd" content is displayed for "Project" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @DAS13424
Scenario: EvergreenJnr_AdminPage_CheckTheCapacitySlotsLinkRedirectsToTheCorrectScreen
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Windows 7 Migration (Computer Scheduled Project)" Project
	Then Project with "Windows 7 Migration (Computer Scheduled Project)" name is displayed correctly
	When User navigate to "Capacity" tab
	And User clicks the Use Dashworks Evergreen to configure capacity link
	Then "Slots" tab in Project selected on the Admin page

	#required functionality (Project Mode) was temporarily hidden, 05/29/19
@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @DAS13510 @DAS13511 @Project_Creation_and_Scope @Projects @Cleanup @archived
Scenario: EvergreenJnr_AdminPage_CheckThatProjectWithUseEvergreenCapacityUnitsIsNotDisplayedOnTheCapacityUnitsTab
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '13510TestProject' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks 'CREATE PROJECT' button 
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with '13510TestProject' header is displayed to user
	When User navigates to the 'Capacity' left menu item
	And User selects 'Use project capacity units' in the 'Capacity Units' dropdown
	And User clicks 'UPDATE' button 
	Then 'The project capacity details have been updated' text is displayed on inline success banner
	When User navigates to the 'Units' left menu item
	Then Blue banner with "This project uses evergreen capacity units" text is displayed
	Then 'CREATE PROJECT CAPACITY UNIT' button is not displayed
	Then 'Actions' dropdown is not displayed
	Then Cog menu is not displayed on the Admin page
	When User clicks 'Administration' header breadcrumb
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	When User clicks String Filter button for "Project" column
	Then "13510TestProject" is not displayed in the filter dropdown
