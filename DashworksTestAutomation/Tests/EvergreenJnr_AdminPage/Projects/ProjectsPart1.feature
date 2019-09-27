Feature: ProjectsPart1
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11697 @DAS12744 @DAS12999 @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckThatCancelButtonOnTheCreateProjectPageRedirectsToTheLastPage
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks the "CANCEL" Action button
	Then 'All <ListName>' list should be displayed to the user

Examples:
	| ListName  |
	| Devices   |
	| Users     |
	| Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11982 @DAS12773 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatAllAssociationsAreSelectedByDefaultInTheProjectApplicationsScope
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject7" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject7" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	Then All Associations are selected by default
	When User selects "Do not include applications" checkbox on the Project details page
	Then All Associations are disabled
	When User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects "Include applications" checkbox on the Project details page
	Then All Associations are selected by default

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS14283 @DAS17167 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatExistingProjectNameCantBeRemoved
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	And User enters "TestProject14283" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject14283" is displayed to user
	When User selects 'Dependant List Filter - BROKEN LIST' in the 'Scope' dropdown
	Then 'This list has errors' error message is displayed for 'Scope' dropdown
	When User navigates to the 'Details' left menu item
	And User enters "" in the "Project Name" field
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then created Project with "TestProject14283" name is displayed correctly

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12189 @DAS12523 @DAS12521 @DAS12744 @DAS12162 @DAS12532 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorsAreDisplayedInTheProjectScopeChangesSectionAfterUsingSavedDevicesList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "Vendor" filter is added to the list
	When User create dynamic list with "Vendor is adobe" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList    | Association         |
	| Vendor is adobe | Used on device      |
	| Vendor is adobe | Entitled to device  |
	| Vendor is adobe | Installed on device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "DevicesList1584" name on "Devices" page
	Then "DevicesList1584" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject9" in the "Project Name" field
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject9" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User navigates to the 'Applications' tab on Project Scope Changes page
	Then There are no errors in the browser console
	