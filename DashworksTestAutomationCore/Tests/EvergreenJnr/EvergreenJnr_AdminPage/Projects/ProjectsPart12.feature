Feature: ProjectsPart12
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Cleanup @Projects
Scenario Outline: EvergreenJnr_ChangingApplicationScopeListToAnotherListForMailboxProject
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "39" rows are displayed in the agGrid
	When User create dynamic list with "<FirstListName>" name on "Applications" page
	Then "<FirstListName>" list is displayed to user
	When User create static list with "<SecondListName>" name on "Applications" page with following items
	| ItemName             |
	| WMI Tools            |
	| Windows Live Toolbar |
	Then "<SecondListName>" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| <ProjectName> | All Mailboxes | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects "Include applications" checkbox on the Project details page
	And User selects '<ChangingToList1>' in the 'Application Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User selects '<ChangingToList2>' in the 'Application Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| FirstListName    | SecondListName    | ProjectName    | ChangingToList1   | ChangingToList2   | ObjectsToAdd1                          | ObjectsToAdd2                         |
	| FirstList12999_1 | SecondList12999_1 | Project12999_1 | All Applications  | SecondList12999_1 | Applications to add (0 of 37 selected) | Applications to add (0 of 0 selected) |
	| FirstList12999_2 | SecondList12999_2 | Project12999_2 | SecondList12999_2 | FirstList12999_2  | Applications to add (0 of 0 selected)  | Applications to add (0 of 0 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS18369 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_AddingAndDeletingPermissionsForMailboxProject
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| TestName12581 | All Mailboxes | None            | Standalone Project |
	Then Page with 'TestName12581' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14757 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	And User checks 'Other mailbox permissions' checkbox
	And User selects following Mailbox permissions
	| Permissions |
	| FullAccess  |
	| ChangeOwner |
	And User checks 'Mailbox folder permissions' checkbox
	And User selects following Mailbox folder permissions
	| Permissions      |
	| Author           |
	| AvailabilityOnly |
	When User checks 'Delegated mailboxes' checkbox
	And User checks 'Owned mailboxes' checkbox
	And User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	Then following chips of 'ADD PERMISSION' button are displayed
	| Chips       |
	| FullAccess  |
	| ChangeOwner |
	Then following chips of 'ADD PERMISSION' button with '1' index are displayed
	| Chips            |
	| Author           |
	| AvailabilityOnly |
	Then 'Owned mailboxes' checkbox is checked
	Then 'Delegated mailboxes' checkbox is checked
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14767 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	When User removes following chips of 'ADD PERMISSION' button
	| Chips      |
	| FullAccess |
	When User removes following chips of 'ADD PERMISSION' button with '1' index
	| Chips      |
	| Author     |
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	Then following chips of 'ADD PERMISSION' button are displayed
	| Chips       |
	| ChangeOwner |
	Then following chips of 'ADD PERMISSION' button with '1' index are displayed
	| Chips            |
	| AvailabilityOnly |
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13205 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatBannerDisplaysOnScopeDetailsPage
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User clicks 'CREATE PROJECT' button 
	And User enters 'TestName13205' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	And User clicks newly created object link
	Then User sees banner at the top of work area

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12680 @DAS12108 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_AddingRequestTypesAndCategories
	When Project created via API and opened
	| ProjectName | Scope         | ProjectTemplate | Mode               |
	| TestName18  | All Mailboxes | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
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
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "TestName18" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Page with 'TestName18' header is displayed to user
	When User changes Path to "18RequestTypeName"
	And User changes Category to "18MailboxCategory"
	And User navigates to the 'Scope Details' left menu item
	And User navigates to the 'Scope Changes' left menu item
	#Then "18RequestTypeName" Path is displayed to the user
	#Then "18MailboxCategory" Category is displayed to the user
	Then "Mailboxes to add (0 of 14884 selected)" is displayed to the user in the Project Scope Changes section
	And "Mailboxes to remove (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	And 'Mailboxes 0/0' tab is displayed on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects                                            |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) |
	| 00DB4000EDD84951993@bclabs.local (CSC, SS)         |
	| 0E3406ED5D8349D0996@bclabs.local (Mickley, Leslie) |
	| 0E3406ED5D8349D0996@bclabs.local (Mickley, Leslie) |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '2 mailboxes will be added' text is displayed on inline tip banner
	And 'Mailboxes 2/0' tab is displayed on Project Scope Changes page
	When User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	And "Mailboxes to add (0 of 14882 selected)" is displayed to the user in the Project Scope Changes section
	And "[Default (Mailbox)]" Path is displayed to the user
	And "[None]" Category is displayed to the user
	And Add Objects panel is collapsed
	When User expands multiselect to add objects
	Then no items are selected