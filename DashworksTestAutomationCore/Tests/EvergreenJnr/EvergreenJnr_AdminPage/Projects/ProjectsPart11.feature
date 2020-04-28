Feature: ProjectsPart11
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects
Scenario Outline: EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Mailbox Platform" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Exchange 2003      |
	Then "6" rows are displayed in the agGrid
	When User create dynamic list with "<FirstListName>" name on "Mailboxes" page
	Then "<FirstListName>" list is displayed to user
	When User create static list with "<SecondListName>" name on "Mailboxes" page with following items
	| ItemName                |
	| ZVF5144799@bclabs.local |
	| zunigamn@bclabs.local   |
	Then "<SecondListName>" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| <ProjectName> | All Mailboxes | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	Then "Mailboxes to add (0 of 14884 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User selects '<ChangingToList1>' in the 'Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User selects '<ChangingToList2>' in the 'Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	#Then There are no errors in the browser console

Examples:
	| FirstListName     | SecondListName     | ProjectName     | ChangingToList1    | ChangingToList2    | ObjectsToAdd1                          | ObjectsToAdd2                      |
	| FirstList12999_11 | SecondList12999_11 | Project12999_11 | All Mailboxes      | SecondList12999_11 | Mailboxes to add (0 of 14884 selected) | Mailboxes to add (0 of 2 selected) |
	| FirstList12999_22 | SecondList12999_22 | Project12999_22 | SecondList12999_22 | FirstList12999_22  | Mailboxes to add (0 of 2 selected)     | Mailboxes to add (0 of 6 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingUserScopePermissionsForMailboxProject
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| TestName11881 | All Mailboxes | None            | Standalone Project |
	Then Page with 'TestName11881' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	And User selects "Do not include users" checkbox on the Project details page
	Then Scope List dropdown is disabled
	Then User Scope checkboxes are disabled
	Then Application Scope tab is hidden
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	And User selects "Include users associated to mailboxes" checkbox on the Project details page
	Then Scope List dropdown is active
	Then User Scope checkboxes are active
	Then Application Scope tab is displayed
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14757 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingApplicationScopePermissionsForMailboxProject
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| TestName12881 | All Mailboxes | None            | Standalone Project |
	Then Page with 'TestName12881' header is displayed to user
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Details' left menu item
	And User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User selects "Include applications" checkbox on the Project details page
	Then Scope List dropdown is active
	Then Application Scope checkboxes are active
	When User selects "Do not include applications" checkbox on the Project details page
	Then Scope List dropdown is disabled
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_OnboardingMailboxesUsersApplicationsObjectsUsingUpdateAllChangesButton
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'TestProject65' text to 'Project Name' textbox
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	Then Page with 'TestProject65' header is displayed to user
	When User navigates to the 'Scope Changes' left menu item
	Then "Mailboxes to add (0 of 14884 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect and selects following Objects
	| Objects                                            |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) |
	| 00DB4000EDD84951993@bclabs.local (CSC, SS)         |
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14757 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect and selects following Objects
	| Objects                            |
	| 02E0346DF7804F25835 (Gill, Donna)  |
	| 037AF4CF47C1452D8A4 (Vanetti, Joe) |
	#When User navigates to the 'Applications' tab on Project Scope Changes page
	#Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	#When User expands multiselect to add objects 
	#And User selects following Objects
	#| Objects                                          |
	#| ACDSee 4.0.2 PowerPack Trial Version (4.00.0002) |
	#| Backburner (2.1.2.0)                             |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '4 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	#Then "Applications to add (0 of 2079 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Mailboxes' tab on Project Scope Changes page
	Then "Mailboxes to add (0 of 14882 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14755 selected)" is displayed to the user in the Project Scope Changes section