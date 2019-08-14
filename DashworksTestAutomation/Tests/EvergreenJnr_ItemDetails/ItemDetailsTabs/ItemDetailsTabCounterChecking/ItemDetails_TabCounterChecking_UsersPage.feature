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
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	Then "User Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	#| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	Then "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16884
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInProjectMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
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
	Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| Project Details         |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	#================ checks counters ================#
	Then "User Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	Then "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16830
Scenario: EvergreenJnr_UsersList_ChecksThatTheNumberOfCountersInTheTabIsEqualToTheNumberOfFieldsInTheTable
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "ACG370114"
	When User click content from "Username" column
	Then Details page for "ACG370114" item is displayed to the user
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '2' count of items
	#Ann.Ilchenko 8/14/19: Remove the hash when the row counter will be implemented in the top bar.
	#Then "2" rows found label displays on Details Page
	When User navigates to the "Projects" main-menu on the Details page
    When User navigates to the "User Projects" sub-menu on the Details page
	Then "User Projects" tab is displayed on left menu on the Details page and contains '8' count of items
	Then "8" rows found label displays on Details Page
	When User navigates to the "Device Project Summary" sub-menu on the Details page
	Then "Device Project Summary" tab is displayed on left menu on the Details page and contains '15' count of items
	Then "15" rows found label displays on Details Page
	When User navigates to the "Devices" main-menu on the Details page
	Then "Devices" tab is displayed on left menu on the Details page and contains '2' count of items
	Then "2" rows found label displays on Details Page
	When User navigates to the "Applications" main-menu on the Details page
    When User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains '7' count of items
	Then "7" rows found label displays on Details Page
	When User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains '16' count of items
	Then "16" rows found label displays on Details Page
	When User navigates to the "Compliance" main-menu on the Details page
    When User navigates to the "Hardware Rules" sub-menu on the Details page
	Then "Hardware Rules" tab is displayed on left menu on the Details page and contains '2' count of items
	Then "2" rows found label displays on Details Page
	When User navigates to the "Application Issues" sub-menu on the Details page
	Then "Application Issues" tab is displayed on left menu on the Details page and contains '2' count of items
	Then "2" rows found label displays on Details Page
	When User type "0137C8E69921432992B" in Global Search Field
    Then User clicks on "0137C8E69921432992B (Jackson, Veronica)" search result
    And Details page for "0137C8E69921432992B" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Mailbox Project Summary" sub-menu on the Details page
	Then "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains '3' count of items
	Then "3" rows found label displays on Details Page
	When User navigates to the "Active Directory" main-menu on the Details page
	When User navigates to the "Groups" sub-menu on the Details page
	Then "Groups" tab is displayed on left menu on the Details page and contains '1' count of items
	Then "1" rows found label displays on Details Page
	When User navigates to the "Mailboxes" main-menu on the Details page
	When User navigates to the "Mailboxes" sub-menu on the Details page
	Then "Mailboxes" tab is displayed on left menu on the Details page and contains '1' count of items
	Then "1" rows found label displays on Details Page
	When User type "allanj" in Global Search Field
    Then User clicks on "allanj (Jo Allan)" search result
    And Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then "Advertisements" tab is displayed on left menu on the Details page and contains '5' count of items
	Then "5" rows found label displays on Details Page
	When User navigates to the "Collections" sub-menu on the Details page
	Then "Collections" tab is displayed on left menu on the Details page and contains '9' count of items
	Then "9" rows found label displays on Details Page