Feature: ItemDetails_TabCounterChecking_UsersPage
	Runs Item Details TabCounterChecking_UsersPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16418 @DAS16415 @DAS15583 @DAS15348 @DAS17141 @DAS16830
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
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
	And "Projects" main-menu on the Details page contains following sub-menu:
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
	And "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	#| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	And "Groups" tab is displayed on left menu on the Details page and contains count of items
	And "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	And "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	And "Applications" main-menu on the Details page contains following sub-menu:
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
	And "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	And "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	And "Compliance" main-menu on the Details page contains following sub-menu:
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
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
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
	And "Projects" main-menu on the Details page contains following sub-menu:
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
	And "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	And "Groups" tab is displayed on left menu on the Details page and contains count of items
	And "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	And "Applications" main-menu on the Details page contains following sub-menu:
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
	And "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	And "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	And "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	And "Compliance" main-menu on the Details page contains following sub-menu:
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