Feature: ItemDetails_TabCounterChecking_DevicesPage
	Runs Item Details TabCounterChecking_DevicesPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16379 @DAS16415 @DAS16500 @DAS16297 @DAS15583 @DAS15559 @DAS17553
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInEvergreenMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Related" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Projects Summary       |
	| Owner Projects Summary |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	Then "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification | 
	| Network Cards | 
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   | 
	#================ checks counters ================#
	Then "Network Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "CPUS" tab is displayed on left menu on the Details page and contains count of items
	Then "Video Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Monitors" tab is displayed on left menu on the Details page and contains count of items
	Then "Sound Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Specification" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       | 
	| Active Directory |  
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
		#Ann.Ilchenko 7/24/19 : Remove 'NOT' for checking 'Hardware Rules' tab, when 'pulsar' will be on 'automation' server --> DAS17553
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS15560 @DAS17553
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInProjectMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Related" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Tasks Disabled in Evergreen" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Project Details        |
	| Projects Summary       |
	| Owner Projects Summary |
	#================ checks counters ================#
	Then "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification | 
	| Network Cards | 
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   | 
	#================ checks counters ================#
	Then "Network Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "CPUS" tab is displayed on left menu on the Details page and contains count of items
	Then "Video Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Monitors" tab is displayed on left menu on the Details page and contains count of items
	Then "Sound Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Specification" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       | 
	| Active Directory |  
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
		#Ann.Ilchenko 7/24/19 : Remove 'NOT' for checking 'Hardware Rules' tab, when 'pulsar' will be on 'automation' server --> DAS17553
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items