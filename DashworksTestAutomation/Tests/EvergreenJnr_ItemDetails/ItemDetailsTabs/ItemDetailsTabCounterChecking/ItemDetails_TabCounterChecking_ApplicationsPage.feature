Feature: ItemDetails_TabCounterChecking_ApplicationsPage
	Runs Item Details TabCounterChecking_ApplicationsPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Ann.Ilchenko 7/18/19: The navigation menu counters are ready in the 'Pulsar' release.
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS15345 @DAS16831 @DAS17142 @DAS17524 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInEvergreenMode
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	And User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	And User sees following main-tabs on left menu on the Details page:
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	#================ checks sub-menu for main Details tab ================#
	And "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName     |
	| Application    |
	| Advertisements |
	| Programs       |
	| Custom Fields  |
	#================ checks counters ================#
	And "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	And "Programs" tab is displayed on left menu on the Details page and contains count of items
	And "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	And "Application" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	And "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Details |
	| Projects          |
	And "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	And "Projects" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main MSI tab ================#
	And "MSI" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| MSI Files  |
	| AOK        |
	#================ checks counters ================#
	And "MSIFiles" tab is displayed on left menu on the Details page and NOT contains count of items
	And "AOK" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Distribution tab ================#
	And "Distribution" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| Users      |
	| Devices    |
	| Groups     |
	| AD         |
	#================ checks counters ================#
	And "Users" tab is displayed on left menu on the Details page and contains count of items
	And "Devices" tab is displayed on left menu on the Details page and contains count of items
	And "Groups" tab is displayed on left menu on the Details page and contains count of items
	And "AD" tab is displayed on left menu on the Details page and NOT contains count of items

	#Ann.Ilchenko 7/18/19: The navigation menu counters are ready in the 'Pulsar' release.
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16885 @DAS17213 @DAS16831 @DAS17142 @DAS17524 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInProjectMode
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	And User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User switches to the "Project K-Computer Scheduled Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	And "Distribution" main-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	And "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName     |
	| Application    |
	| Advertisements |
	| Programs       |
	| Custom Fields  |
	#================ checks counters ================#
	And "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	And "Programs" tab is displayed on left menu on the Details page and contains count of items
	And "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	And "Application" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	And "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Details |
	| Project Details   |
	| Projects          |
	#================ checks counters ================#
	And "Projects" tab is displayed on left menu on the Details page and contains count of items
	And "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	And "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main MSI tab ================#
	And "MSI" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| MSI Files  |
	| AOK        |
	#================ checks counters ================#
	And "MSIFiles" tab is displayed on left menu on the Details page and NOT contains count of items
	And "AOK" tab is displayed on left menu on the Details page and NOT contains count of items