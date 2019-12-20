Feature: ItemDetails_TabCounterChecking_DevicesPage
	Runs Item Details TabCounterChecking_DevicesPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16379 @DAS16415 @DAS16500 @DAS16297 @DAS15583 @DAS15559 @DAS17553
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInEvergreenMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	And User sees following parent left menu items
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	And 'Users' left submenu item with some count is displayed
	And 'Related' left submenu item is disabled
	#================ checks sub-menu for main Details tab ================#
	And 'Details' left menu have following submenu items:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And 'Custom Fields' left submenu item with some count is displayed
	And 'Device' left submenu item is displayed without count
	And 'Device Owner' left submenu item is displayed without count
	And 'Department and Location' left submenu item is displayed without count
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then 'Projects' left menu have following submenu items:
	| SubTabName             |
	| Evergreen Details      |
	| Projects Summary       |
	| Owner Projects Summary |
	And 'Project Details' left submenu item is disabled
	#================ checks counters ================#
	And 'Projects Summary' left submenu item with some count is displayed
	And 'Owner Projects Summary' left submenu item with some count is displayed
	And 'Evergreen Details' left submenu item is displayed without count
	And 'Project Details' left submenu item is displayed without count
	#================ checks sub-menu for main Specification tab ================#
	When User navigates to the 'Specification' left menu item
	Then 'Specification' left menu have following submenu items:
	| SubTabName    |
	| Specification |
	| Network Cards |
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   |
	#================ checks counters ================#
	And 'Network Cards' left submenu item with some count is displayed
	And 'CPUS' left submenu item with some count is displayed
	And 'Video Cards' left submenu item with some count is displayed
	And 'Monitors' left submenu item with some count is displayed
	And 'Sound Cards' left submenu item with some count is displayed
	And 'Specification' left submenu item is displayed without count
	#================ checks sub-menu for main Active Directory tab ================#
	When User navigates to the 'Active Directory' left menu item
	Then 'Active Directory' left menu have following submenu items:
	| SubTabName       |
	| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	And 'Groups' left submenu item with some count is displayed
	And 'Active Directory' left submenu item is displayed without count
	And 'LDAP' left submenu item is displayed without count
	#================ checks sub-menu for main Applications tab ================#
	When User navigates to the 'Applications' left menu item
	Then 'Applications' left menu have following submenu items:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	And 'Evergreen Summary' left submenu item with some count is displayed
	And 'Evergreen Detail' left submenu item with some count is displayed
	And 'Advertisements' left submenu item with some count is displayed
	And 'Collections' left submenu item with some count is displayed
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS15560 @DAS17553
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInProjectMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	Then User sees following parent left menu items
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	And 'Users' left submenu item with some count is displayed
	And 'Related' left submenu item is displayed without count
	And 'Tasks Disabled in Evergreen' left submenu item is displayed without count
	#================ checks sub-menu for main Details tab ================#
	And 'Details' left menu have following submenu items:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And 'Custom Fields' left submenu item with some count is displayed
	And 'Device' left submenu item is displayed without count
	And 'Device Owner' left submenu item is displayed without count
	And 'Department and Location' left submenu item is displayed without count
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then 'Projects' left menu have following submenu items:
	| SubTabName             |
	| Evergreen Details      |
	| Project Details        |
	| Projects Summary       |
	| Owner Projects Summary |
	#================ checks counters ================#
	And 'Projects Summary' left submenu item with some count is displayed
	And 'Owner Projects Summary' left submenu item with some count is displayed
	And 'Evergreen Details' left submenu item is displayed without count
	And 'Project Details' left submenu item is displayed without count
	#================ checks sub-menu for main Specification tab ================#
	When User navigates to the 'Specification' left menu item
	Then 'Specification' left menu have following submenu items:
	| SubTabName    |
	| Specification |
	| Network Cards |
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   |
	#================ checks counters ================#
	And 'Network Cards' left submenu item with some count is displayed
	And 'CPUS' left submenu item with some count is displayed
	And 'Video Cards' left submenu item with some count is displayed
	And 'Monitors' left submenu item with some count is displayed
	And 'Sound Cards' left submenu item with some count is displayed
	And 'Specification' left submenu item is displayed without count
	#================ checks sub-menu for main Active Directory tab ================#
	When User navigates to the 'Active Directory' left menu item
	Then 'Active Directory' left menu have following submenu items:
	| SubTabName       |
	| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	And 'Groups' left submenu item with some count is displayed
	And 'Active Directory' left submenu item is displayed without count
	And 'LDAP' left submenu item is displayed without count
	#================ checks sub-menu for main Applications tab ================#
	When User navigates to the 'Applications' left menu item
	Then 'Applications' left menu have following submenu items:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	And 'Evergreen Summary' left submenu item with some count is displayed
	And 'Evergreen Detail' left submenu item with some count is displayed
	And 'Advertisements' left submenu item with some count is displayed
	And 'Collections' left submenu item with some count is displayed
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
