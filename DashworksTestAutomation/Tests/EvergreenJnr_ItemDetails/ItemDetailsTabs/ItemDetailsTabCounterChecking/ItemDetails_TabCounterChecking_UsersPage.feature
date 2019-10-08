Feature: ItemDetails_TabCounterChecking_UsersPage
	Runs Item Details TabCounterChecking_UsersPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16418 @DAS16415 @DAS15583 @DAS15348 @DAS17141 @DAS16830 @DAS18198
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenMode
	When User navigates to the 'User' details page for '0072B088173449E3A93' item 
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	And User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	And "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	And "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	And "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	And "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	And "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	And "User Projects" tab is displayed on left menu on the Details page and contains count of items
	And "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	When User navigates to the 'Active Directory' left menu item
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	#| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	And "Groups" tab is displayed on left menu on the Details page and contains count of items
	And "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	And "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	When User navigates to the 'Applications' left menu item
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Evergreen Owned   |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	And "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Owned" tab is displayed on left menu on the Details page and contains count of items
	And "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	And "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	When User navigates to the 'Mailboxes' left menu item
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	And "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	When User navigates to the 'Compliance' left menu item
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	And "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	And "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Hardware Rules" tab is displayed on left menu on the Details page and contains count of items
	And "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16884
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInProjectMode
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	And "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	And "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	And "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	And "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| Project Details         |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	#================ checks counters ================#
	And "User Projects" tab is displayed on left menu on the Details page and contains count of items
	And "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	When User navigates to the 'Active Directory' left menu item
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	And "Groups" tab is displayed on left menu on the Details page and contains count of items
	And "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	When User navigates to the 'Applications' left menu item
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	And "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	And "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	And "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	When User navigates to the 'Mailboxes' left menu item
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	And "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	When User navigates to the 'Compliance' left menu item
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	And "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	And "Hardware Rules" tab is displayed on left menu on the Details page and contains count of items
	And "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16830
Scenario: EvergreenJnr_UsersList_ChecksThatTheNumberOfCountersInTheTabIsEqualToTheNumberOfFieldsInTheTable
	When User navigates to the 'User' details page for 'ACG370114' item
	Then Details page for "ACG370114" item is displayed to the user
	And 'Custom Fields' tab is displayed on left menu on the Details page and contains '2' count of items
	When User navigates to the "Custom Fields" sub-menu on the Details page
	Then "2" rows found label displays on Details Page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "User Projects" sub-menu on the Details page
	Then 'User Projects' tab is displayed on left menu on the Details page and contains '8' count of items
	And "8" rows found label displays on Details Page
	When User navigates to the "Device Project Summary" sub-menu on the Details page
	Then 'Device Project Summary' tab is displayed on left menu on the Details page and contains '15' count of items
	And "15" rows found label displays on Details Page
	When User navigates to the 'Devices' left menu item
	Then 'Devices' tab is displayed on left menu on the Details page and contains '2' count of items
	And "2" rows found label displays on Details Page
	When User navigates to the 'Applications' left menu item
	And User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then 'Evergreen Summary' tab is displayed on left menu on the Details page and contains '7' count of items
	And "7" rows found label displays on Details Page
	When User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then 'Evergreen Detail' tab is displayed on left menu on the Details page and contains '16' count of items
	And "16" rows found label displays on Details Page
	When User navigates to the 'Compliance' left menu item
	And User navigates to the "Hardware Rules" sub-menu on the Details page
	Then 'Hardware Rules' tab is displayed on left menu on the Details page and contains '2' count of items
	And "2" rows found label displays on Details Page
	When User navigates to the "Application Issues" sub-menu on the Details page
	Then 'Application Issues' tab is displayed on left menu on the Details page and contains '2' count of items
	And "2" rows found label displays on Details Page
	When User type "0137C8E69921432992B" in Global Search Field
	Then User clicks on "0137C8E69921432992B (Jackson, Veronica)" search result
	And Details page for "0137C8E69921432992B" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Mailbox Project Summary" sub-menu on the Details page
	Then 'Mailbox Project Summary' tab is displayed on left menu on the Details page and contains '3' count of items
	And "3" rows found label displays on Details Page
	When User navigates to the 'Active Directory' left menu item
	And User navigates to the "Groups" sub-menu on the Details page
	Then 'Groups' tab is displayed on left menu on the Details page and contains '1' count of items
	And "1" rows found label displays on Details Page
	When User navigates to the 'Mailboxes' left menu item
	And User navigates to the "Mailboxes" sub-menu on the Details page
	Then 'Mailboxes' tab is displayed on left menu on the Details page and contains '1' count of items
	And "1" rows found label displays on Details Page
	When User type "allanj" in Global Search Field
	Then User clicks on "allanj (Jo Allan)" search result
	And Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the "Advertisements" sub-menu on the Details page
	Then 'Advertisements' tab is displayed on left menu on the Details page and contains '5' count of items
	And "5" rows found label displays on Details Page
	When User navigates to the "Collections" sub-menu on the Details page
	Then 'Collections' tab is displayed on left menu on the Details page and contains '9' count of items
	And "9" rows found label displays on Details Page
	
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17769
Scenario: EvergreenJnr_UsersList_CheckThatCollectionsSubMenuCounterMatchTheNumberOfCollectionsForThisUser
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the "Collections" sub-menu on the Details page
	Then "9" rows found label displays on Details Page
	And 'Collections' tab is displayed on left menu on the Details page and contains '9' count of items