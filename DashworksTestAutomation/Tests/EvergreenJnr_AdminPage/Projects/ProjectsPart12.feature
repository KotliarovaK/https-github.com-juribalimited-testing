﻿Feature: ProjectsPart12
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Cleanup @Projects @TEST
Scenario Outline: EvergreenJnr_ChangingApplicationScopeListToAnotherListForMailboxProject
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "39" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList87" name on "Applications" page
	Then "DynamicList87" list is displayed to user
	When User create static list with "StaticList1529" name on "Applications" page with following items
	| ItemName             |
	| WMI Tools            |
	| Windows Live Toolbar |
	Then "StaticList1529" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "MailboxProject2" in the "Project Name" field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	When User selects "Include applications" checkbox on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList2>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ChangingToList1  | ChangingToList2 | ObjectsToAdd1                         | ObjectsToAdd2                         |
	| All Applications | StaticList1529  | Applications to add (0 of 0 selected) | Applications to add (0 of 0 selected) |
	| StaticList1529   | DynamicList87   | Applications to add (0 of 0 selected) | Applications to add (0 of 0 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects @TEST
Scenario: EvergreenJnr_AdminPage_AddingAndDeletingPermissionsForMailboxProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12581" in the "Project Name" field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestName12581" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14747 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User clicks "Other mailbox permissions" associated checkbox on the Project details page
	And User selects following Mailbox permissions
	| Permissions |
	| FullAccess  |
	| ChangeOwner |
	And User clicks "Mailbox folder permissions" associated checkbox on the Project details page
	And User selects following Mailbox folder permissions
	| Permissions      |
	| Author           |
	| AvailabilityOnly |
	Then following Mailbox permissions are displayed to the user
	| Permissions      |
	| FullAccess       |
	| ChangeOwner      |
	| Author           |
	| AvailabilityOnly |
	When User clicks "Delegated mailboxes" associated checkbox on the Project details page
	And User clicks "Owned mailboxes" associated checkbox on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	Then following Mailbox permissions are displayed to the user
	| Permissions      |
	| FullAccess       |
	| ChangeOwner      |
	| Author           |
	| AvailabilityOnly |
	And following checkboxes are checked in the Scope section
	| Checkboxes          |
	| Owned mailboxes     |
	| Delegated mailboxes |
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14753 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User removes following Mailbox permissions
	| Permissions |
	| FullAccess  |
	| Author      |
	And User selects "Scope Changes" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	Then following Mailbox permissions are displayed to the user
	| Permissions      |
	| ChangeOwner      |
	| AvailabilityOnly |
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13205 @Cleanup @Projects @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatBannerDisplaysOnScopeDetailsPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "TestName13205" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	Then User sees banner at the top of work area

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12680 @DAS12108 @Cleanup @Projects @TEST
Scenario: EvergreenJnr_AdminPage_AddingRequestTypesAndCategories
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName18" in the "Project Name" field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "TestName18" Project
	Then Project with "TestName18" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name              | Description             | ObjectTypeString |
	| 18RequestTypeName | MailboxScheduledProject | Mailbox          |
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Create Category" button
	And User create Category
	| Name              | Description          | ObjectTypeString |
	| 18MailboxCategory | UserScheduledProject | Mailbox          |
	Then Success message is displayed with "Category successfully created." text
	When User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestName18" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestName18" is displayed to user
	When User changes Path to "18RequestTypeName"
	And User changes Category to "18MailboxCategory"
	And User selects "Scope Details" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	#Then "18RequestTypeName" Path is displayed to the user
	#Then "18MailboxCategory" Category is displayed to the user
	Then "Mailboxes to add (0 of 14784 selected)" is displayed to the user in the Project Scope Changes section
	And "Mailboxes to remove (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	And "Mailboxes 0/0" is displayed in the tab header on the Admin page
	When User expands the object to add
	And User selects following Objects
	| Objects                                            |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) |
	| 00DB4000EDD84951993@bclabs.local (CSC, SS)         |
	| 0E3406ED5D8349D0996@bclabs.local (Mickley, Leslie) |
	| 0E3406ED5D8349D0996@bclabs.local (Mickley, Leslie) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "2 mailboxes will be added" text is displayed on the Admin page
	And "Mailboxes 2/0" is displayed in the tab header on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	And "Mailboxes to add (0 of 14782 selected)" is displayed to the user in the Project Scope Changes section
	And "[Default (Mailbox)]" Path is displayed to the user
	And "[None]" Category is displayed to the user
	And Add Objects panel is collapsed
	When User expands the object to add
	Then no items are selected