﻿Feature: ProjectsPart11
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects
Scenario Outline: EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Mailbox Platform" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Exchange 2003      |
	Then "6" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList77" name on "Mailboxes" page
	Then "DynamicList77" list is displayed to user
	When User create static list with "StaticList1429" name on "Mailboxes" page with following items
	| ItemName                |
	| ZVF5144799@bclabs.local |
	| zunigamn@bclabs.local   |
	Then "StaticList1429" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName       | Scope         | ProjectTemplate | Mode               |
	| MailboxesProject3 | All Mailboxes | None            | Standalone Project |
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	Then "Mailboxes to add (0 of 14784 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects '<ChangingToList1>' in the 'Scope' dropdown with wait
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects '<ChangingToList2>' in the 'Scope' dropdown with wait
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	#Then There are no errors in the browser console

Examples:
	| ChangingToList1 | ChangingToList2 | ObjectsToAdd1                          | ObjectsToAdd2                      |
	| All Mailboxes   | StaticList1429  | Mailboxes to add (0 of 14784 selected) | Mailboxes to add (0 of 2 selected) |
	| StaticList1429  | DynamicList77   | Mailboxes to add (0 of 2 selected)     | Mailboxes to add (0 of 6 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingUserScopePermissionsForMailboxProject
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| TestName11881 | All Mailboxes | None            | Standalone Project |
	Then Project "TestName11881" is displayed to user
	When User selects "Scope" tab on the Project details page
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	And User selects "Do not include users" checkbox on the Project details page
	Then Scope List dropdown is disabled
	Then User Scope checkboxes are disabled
	Then Application Scope tab is hidden
	When User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	And User selects "Include users associated to mailboxes" checkbox on the Project details page
	Then Scope List dropdown is active
	Then User Scope checkboxes are active
	Then Application Scope tab is displayed
	When User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14747 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingApplicationScopePermissionsForMailboxProject
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| TestName12881 | All Mailboxes | None            | Standalone Project |
	Then Project "TestName12881" is displayed to user
	When User selects "Scope" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User selects "Include applications" checkbox on the Project details page
	Then Scope List dropdown is active
	Then Application Scope checkboxes are active
	When User selects "Do not include applications" checkbox on the Project details page
	Then Scope List dropdown is disabled
	Then Application Scope checkboxes are disabled
	When User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_OnboardingMailboxesUsersApplicationsObjectsUsingUpdateAllChangesButton
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject65" in the "Project Name" field
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	Then Project "TestProject65" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then "Mailboxes to add (0 of 14784 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect and selects following Objects
	| Objects                                            |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) |
	| 00DB4000EDD84951993@bclabs.local (CSC, SS)         |
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14747 selected)" is displayed to the user in the Project Scope Changes section
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
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "4 objects queued for onboarding, 0 objects offboarded" text
	#Then "Applications to add (0 of 2079 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Mailboxes' tab on Project Scope Changes page
	Then "Mailboxes to add (0 of 14782 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14745 selected)" is displayed to the user in the Project Scope Changes section