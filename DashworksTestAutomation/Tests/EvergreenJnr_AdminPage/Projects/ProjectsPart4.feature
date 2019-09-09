Feature: ProjectsPart4
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11700 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatTheProjectIdColumnIsAddedAndDisplayedCorrectlyToTheAdminProjectGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject11700" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks the "CREATE" Action button
	When User have opened Column Settings for "Project" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Project ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Project ID |
	And content is present in the following newly added columns:
	| ColumnName |
	| Project ID |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11985 @DAS12857 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatProjectNameIsDisplayedCorrectlyWhenSpecialSymbolsAreUsedInTheProjectName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "<TestProject11985>" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "<TestProject11985>" name is displayed correctly

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12364 @DAS12999 @DAS13199 @DAS13297 @DAS12485 @DAS12108 @DAS12645 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatTheProjectIsUpdatedWithoutErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12364" in the "Project Name" field
	And User selects 'All Users' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "TestProject12364" name is displayed correctly
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	Then Project "TestProject12364" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then "Users to add (0 of 41339 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters "child" in the Search Object field
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters "" in the Search Object field
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects                               |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	| 01FF97A1FFAC48A1803 (Aultman, Chanel) |
	When User navigates to the 'Devices' left menu item
	Then "Devices to add (0 of 16765 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters "wpq" in the Search Object field
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters "" in the Search Object field
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects        |
	| 0SH2BQ3EPXTEWN |
	| 30LA8G32UF7HQC |
	| 174HB6RFAHA5CT |
	| 174HB6RFAHA5CT |
	When User navigates to the 'Applications' left menu item
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters "office 1" in the Search Object field
	Then Objects are displayed in alphabetical order on the Admin page
	When User enters "" in the Search Object field
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects                                          |
	| ACDSee 4.0.2 PowerPack Trial Version (4.00.0002) |
	| Backburner (2.1.2.0)                             |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "6 objects queued for onboarding, 0 objects offboarded" text
	Then "Applications to add (0 of 2079 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Devices' left menu item
	Then "Devices to add (0 of 16763 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' left menu item
	Then "Users to add (0 of 41337 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Applications' left menu item
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11729 @DAS13199 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedIfTryToRemoveCreatedListThatUsedInAnyProject
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "TestDynamicList11729" name on "Devices" page
	Then "TestDynamicList11729" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName11729" in the "Project Name" field
	And User selects 'TestDynamicList11729' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then created Project with "TestName11729" name is displayed correctly
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks Settings button for "TestDynamicList11729" list
	And User clicks Delete button for custom list
	Then "TestDynamicList11729" list "list is used by 1 project, do you wish to proceed?" message is displayed in the list panel
	And User clicks Delete button on the warning message in the lists panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestName11729" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestName11729" is displayed to user
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Admin page
	And There are no errors in the browser console