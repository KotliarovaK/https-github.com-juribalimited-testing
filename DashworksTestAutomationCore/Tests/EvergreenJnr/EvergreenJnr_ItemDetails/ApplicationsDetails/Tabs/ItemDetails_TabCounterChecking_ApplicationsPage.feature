Feature: ItemDetails_TabCounterChecking_ApplicationsPage
	Runs Item Details TabCounterChecking_ApplicationsPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS15345 @DAS16831 @DAS17142 @DAS17524
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInEvergreenMode
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for 'ABBYY FineReader 8.0 Professional Edition' item is displayed to the user
	Then User sees following parent left menu items
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	#================ checks sub-menu for main Details tab ================#
	And 'Details' left menu have following submenu items:
	| SubTabName        |
	| Application       |
	| Application Owner |
	| Advertisements    |
	| Programs          |
	| Custom Fields     |
	#================ checks counters ================#
	And 'Advertisements' left submenu item with some count is displayed
	And 'Programs' left submenu item with some count is displayed
	And 'Custom Fields' left submenu item with some count is displayed
	And 'Application' left submenu item is displayed without count
	And 'Application Owner' left submenu item is displayed without count
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then 'Projects' left menu have following submenu items:
	| SubTabName              |
	| Evergreen Details       |
	| Evergreen Incoming Apps |
	| Project Details         |
	| Project Incoming Apps   |
	| Projects                |
	#================ checks counters ================#
	And 'Projects' left submenu item with some count is displayed
	And 'Evergreen Incoming Apps' left submenu item with some count is displayed
	And 'Project Incoming Apps' left submenu item with some count is displayed
	And 'Evergreen Details' left submenu item is displayed without count
	And 'Project Details' left submenu item is displayed without count
	#================ checks sub-menu for main MSI tab ================#
	When User navigates to the 'MSI' left menu item
	Then 'MSI' left menu have following submenu items:
	| SubTabName |
	| MSI Files  |
	| AOK        |
	#================ checks counters ================#
	And 'MSI Files' left submenu item is displayed without count
	And 'AOK' left submenu item is displayed without count
	#================ checks sub-menu for main Distribution tab ================#
	When User navigates to the 'Distribution' left menu item
	Then 'Distribution' left menu have following submenu items:
	| SubTabName |
	| Users      |
	| Devices    |
	| Groups     |
	| AD         |
	#================ checks counters ================#
	And 'Users' left submenu item with some count is displayed
	And 'Devices' left submenu item with some count is displayed
	And 'Groups' left submenu item with some count is displayed
	And 'AD' left submenu item is displayed without count

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16885 @DAS17213 @DAS16831 @DAS17142 @DAS17524
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInProjectMode
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for 'ABBYY FineReader 8.0 Professional Edition' item is displayed to the user
	When User selects '*Project K-Computer Scheduled Project' in the 'Item Details Project' dropdown with wait
	Then User sees following parent left menu items
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	#================ checks sub-menu for main Details tab ================#
	And 'Details' left menu have following submenu items:
	| SubTabName        |
	| Application       |
	| Application Owner |
	| Advertisements    |
	| Programs          |
	| Custom Fields     |
	#================ checks counters ================#
	And 'Advertisements' left submenu item with some count is displayed
	And 'Programs' left submenu item with some count is displayed
	And 'Custom Fields' left submenu item with some count is displayed
	And 'Application' left submenu item is displayed without count
	#================ checks sub-menu for main Projects tab ================#
	When User navigates to the 'Projects' left menu item
	Then 'Projects' left menu have following submenu items:
	| SubTabName              |
	| Evergreen Details       |
	| Evergreen Incoming Apps |
	| Project Details         |
	| Project Incoming Apps   |
	| Projects                |
	#================ checks counters ================#
	And 'Projects' left submenu item with some count is displayed
	And 'Evergreen Incoming Apps' left submenu item with some count is displayed
	And 'Project Incoming Apps' left submenu item with some count is displayed
	And 'Evergreen Details' left submenu item is displayed without count
	And 'Project Details' left submenu item is displayed without count
	#================ checks sub-menu for main MSI tab ================#
	When User navigates to the 'MSI' left menu item
	Then 'MSI' left menu have following submenu items:
	| SubTabName |
	| MSI Files  |
	| AOK        |
	#================ checks counters ================#
	And 'MSI Files' left submenu item is displayed without count
	And 'AOK' left submenu item is displayed without count