Feature: ItemDetails_TabCounterChecking_DevicesPage
	Runs Item Details TabCounterChecking_DevicesPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16379 @DAS16415 @DAS16500 @DAS16297 @DAS15583 @DAS15559 @DAS17553
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInEvergreenMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	And User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	And "Users" tab is displayed on left menu on the Details page and contains count of items
	And "Related" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	And "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	And "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Projects Summary       |
	| Owner Projects Summary |
	And "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	And "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	When User navigates to the 'Specification' left menu item
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification |
	| Network Cards |
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   |
	#================ checks counters ================#
	And "Network Cards" tab is displayed on left menu on the Details page and contains count of items
	And "CPUS" tab is displayed on left menu on the Details page and contains count of items
	And "Video Cards" tab is displayed on left menu on the Details page and contains count of items
	And "Monitors" tab is displayed on left menu on the Details page and contains count of items
	And "Sound Cards" tab is displayed on left menu on the Details page and contains count of items
	And "Specification" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	When User navigates to the 'Active Directory' left menu item
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	| Active Directory |
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
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	And "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	And "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	And "Collections" tab is displayed on left menu on the Details page and contains count of items
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS15560 @DAS17553
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInProjectMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	#wait until the menu loading process is complete
	When User waits for three seconds
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	And "Users" tab is displayed on left menu on the Details page and contains count of items
	And "Related" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Tasks Disabled in Evergreen" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Details tab ================#
	And "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	And "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	And "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Project Details        |
	| Projects Summary       |
	| Owner Projects Summary |
	#================ checks counters ================#
	And "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	When User navigates to the 'Specification' left menu item
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification |
	| Network Cards |
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   |
	#================ checks counters ================#
	And "Network Cards" tab is displayed on left menu on the Details page and contains count of items
	And "CPUS" tab is displayed on left menu on the Details page and contains count of items
	And "Video Cards" tab is displayed on left menu on the Details page and contains count of items
	And "Monitors" tab is displayed on left menu on the Details page and contains count of items
	And "Sound Cards" tab is displayed on left menu on the Details page and contains count of items
	And "Specification" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	When User navigates to the 'Active Directory' left menu item
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	| Active Directory |
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
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	And "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	And "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	And "Collections" tab is displayed on left menu on the Details page and contains count of items
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