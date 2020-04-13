Feature: ItemDetails_TabCounterChecking_UsersPage
	Runs Item Details TabCounterChecking_UsersPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16418 @DAS16415 @DAS15583 @DAS15348 @DAS17141 @DAS16830 @DAS18198
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenMode
	When User navigates to the 'User' details page for '0072B088173449E3A93' item 
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	And User sees following parent left menu items
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	And 'Devices' left submenu item with some count is displayed
	#================ checks sub-menu for main Details tab ================#
	And 'Details' left menu have following submenu items:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And 'Custom Fields' left submenu item with some count is displayed
	And 'Department and Location' left submenu item is displayed without count
	And 'User' left submenu item is displayed without count
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then 'Projects' left menu have following submenu items:
	| SubTabName              |
	| Evergreen Details       |
	| Project Details         |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	#================ checks counters ================#
	And 'User Projects' left submenu item with some count is displayed
	And 'Device Project Summary' left submenu item with some count is displayed
	And 'Mailbox Project Summary' left submenu item with some count is displayed
	And 'Evergreen Details' left submenu item is displayed without count
	And 'Project Details' left submenu item is displayed without count
	#================ checks sub-menu for main Active Directory tab ================#
	When User navigates to the 'Active Directory' left menu item
	Then 'Active Directory' left menu have following submenu items:
	| SubTabName       |
	#| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	And 'Groups' left submenu item with some count is displayed
	#And 'Active Directory' left submenu item is displayed without count
	And 'LDAP' left submenu item is displayed without count
	#================ checks sub-menu for main Applications tab ================#
	When User navigates to the 'Applications' left menu item
	Then 'Applications' left menu have following submenu items:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Evergreen Owned   |
	| Project Owned     |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	And 'Evergreen Summary' left submenu item with some count is displayed
	And 'Evergreen Detail' left submenu item with some count is displayed
	And 'Evergreen Owned' left submenu item with some count is displayed
	And 'Advertisements' left submenu item with some count is displayed
	And 'Collections' left submenu item with some count is displayed
	#================ checks sub-menu for main Mailboxes tab ================#
	When User navigates to the 'Mailboxes' left menu item
	Then 'Mailboxes' left menu have following submenu items:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	And 'Mailboxes' left submenu item with some count is displayed
	And 'Mailbox Permissions' left submenu item is displayed without count
	#================ checks sub-menu for main Compliance tab ================#
	When User navigates to the 'Compliance' left menu item
	Then 'Compliance' left menu have following submenu items:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	And 'Application Issues' left submenu item with some count is displayed
	And 'Overview' left submenu item is displayed without count
	And 'Hardware Summary' left submenu item is displayed without count
	And 'Hardware Rules' left submenu item with some count is displayed
	And 'Application Summary' left submenu item is displayed without count

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16884
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInProjectMode
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	Then User sees following parent left menu items
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	And 'Devices' left submenu item with some count is displayed
	#================ checks sub-menu for main Details tab ================#
	And 'Details' left menu have following submenu items:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And 'Custom Fields' left submenu item with some count is displayed
	And 'Department and Location' left submenu item is displayed without count
	And 'User' left submenu item is displayed without count
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then 'Projects' left menu have following submenu items:
	| SubTabName              |
	| Evergreen Details       |
	| Project Details         |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	#================ checks counters ================#
	And 'User Projects' left submenu item with some count is displayed
	And 'Device Project Summary' left submenu item with some count is displayed
	And 'Mailbox Project Summary' left submenu item with some count is displayed
	And 'Evergreen Details' left submenu item is displayed without count
	And 'Project Details' left submenu item is displayed without count
	#================ checks sub-menu for main Active Directory tab ================#
	When User navigates to the 'Active Directory' left menu item
	Then 'Active Directory' left menu have following submenu items:
	| SubTabName       |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	And 'Groups' left submenu item with some count is displayed
	And 'LDAP' left submenu item is displayed without count
	#================ checks sub-menu for main Applications tab ================#
	When User navigates to the 'Applications' left menu item
	Then 'Applications' left menu have following submenu items:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Evergreen Owned   |
	| Project Owned     |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	And 'Evergreen Summary' left submenu item with some count is displayed
	And 'Evergreen Detail' left submenu item with some count is displayed
	And 'Advertisements' left submenu item with some count is displayed
	And 'Collections' left submenu item with some count is displayed
	#================ checks sub-menu for main Mailboxes tab ================#
	When User navigates to the 'Mailboxes' left menu item
	Then 'Mailboxes' left menu have following submenu items:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	And 'Mailboxes' left submenu item with some count is displayed
	And 'Mailbox Permissions' left submenu item is displayed without count
	#================ checks sub-menu for main Compliance tab ================#
	When User navigates to the 'Compliance' left menu item
	Then 'Compliance' left menu have following submenu items:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	And 'Application Issues' left submenu item with some count is displayed
	And 'Hardware Rules' left submenu item with some count is displayed
	And 'Overview' left submenu item is displayed without count
	And 'Hardware Summary' left submenu item is displayed without count
	And 'Application Summary' left submenu item is displayed without count

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16830 @Do_Not_Run_With_Projects
Scenario: EvergreenJnr_UsersList_ChecksThatTheNumberOfCountersInTheTabIsEqualToTheNumberOfFieldsInTheTable
	When User navigates to the 'User' details page for 'ACG370114' item
	Then Details page for 'ACG370114' item is displayed to the user
	And 'Custom Fields' left submenu item with '3' count is displayed
	When User navigates to the 'Custom Fields' left submenu item
	Then "3" rows found label displays on Details Page
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'User Projects' left submenu item
	Then 'User Projects' left submenu item with '8' count is displayed
	And "8" rows found label displays on Details Page
	When User navigates to the 'Device Project Summary' left submenu item
	Then 'Device Project Summary' left submenu item with '15' count is displayed
	And "15" rows found label displays on Details Page
	When User navigates to the 'Devices' left menu item
	Then 'Devices' left submenu item with '2' count is displayed
	And "2" rows found label displays on Details Page
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	Then 'Evergreen Summary' left submenu item with '7' count is displayed
	And "7" rows found label displays on Details Page
	When User navigates to the 'Evergreen Detail' left submenu item
	Then 'Evergreen Detail' left submenu item with '16' count is displayed
	And "16" rows found label displays on Details Page
	When User navigates to the 'Compliance' left menu item
	And User navigates to the 'Hardware Rules' left submenu item
	Then 'Hardware Rules' left submenu item with '2' count is displayed
	And "2" rows found label displays on Details Page
	When User navigates to the 'Application Issues' left submenu item
	Then 'Application Issues' left submenu item with '2' count is displayed
	And "2" rows found label displays on Details Page
	When User navigates to the 'User' details page for '0137C8E69921432992B' item
	Then Details page for '0137C8E69921432992B' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Mailbox Project Summary' left submenu item
	Then 'Mailbox Project Summary' left submenu item with '2' count is displayed
	And "2" rows found label displays on Details Page
	When User navigates to the 'Active Directory' left menu item
	And User navigates to the 'Groups' left submenu item
	Then 'Groups' left submenu item with '1' count is displayed
	And "1" rows found label displays on Details Page
	When User navigates to the 'Mailboxes' left menu item
	And User navigates to the 'Mailboxes' left submenu item
	Then 'Mailboxes' left submenu item with '1' count is displayed
	And "1" rows found label displays on Details Page
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for 'allanj' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Advertisements' left submenu item
	Then 'Advertisements' left submenu item with '5' count is displayed
	And "5" rows found label displays on Details Page
	When User navigates to the 'Collections' left submenu item
	Then 'Collections' left submenu item with '9' count is displayed
	And "9" rows found label displays on Details Page
	
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17769
Scenario: EvergreenJnr_UsersList_CheckThatCollectionsSubMenuCounterMatchTheNumberOfCollectionsForThisUser
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for 'allanj (Jo Allan)' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Collections' left submenu item
	Then "9" rows found label displays on Details Page
	And 'Collections' left submenu item with '9' count is displayed