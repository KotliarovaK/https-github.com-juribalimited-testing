Feature: UsersDetails_Projects_DeviceProjectSummary
	Runs related tests for Projects > Device Project Summary tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ProjectsTab @DAS15522
Scenario: EvergreenJnr_UsersList_ChecksThatNoErrorsAreDisplayedAfterClickingThroughTheProjectNameFromObjectDetails
	When User navigates to the 'User' details page for 'TON2490708' item
	Then Details page for 'TON2490708' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Device Project Summary' left submenu item
	When User enters "K-group" text in the Search field for "Bucket" column
	And User clicks "00BDM1JUR8IF419" link on the Details Page
	Then "Project Object" page is displayed to the user

	#AnnI 5/28/20: Fixed only on 'Yellow_Dwarf'
@Evergreen @Users @EvergreenJnr_ItemDetails @ProjectsTab @DAS21260 @Yellow_Dwarf
Scenario: EvergreenJnr_UsersList_CheckThatTheFilterItemsInHeaderAreDisplayedAccordingToItsItemsInCellsAndFiltersDdlForTheColumnsWithStringAndExternalLinkTypes
	When User navigates to the 'User' details page for 'XIV480469' item
	Then Details page for 'XIV480469' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Device Project Summary' left submenu item
	When User clicks following checkboxes from Column Settings panel for the 'Project' column:
	| checkboxes |
	| Device     |
	| Bucket     |
	| Ring       |
	When User checks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes                      |
	| Select All                      |
	| User Evergreen Capacity Project |
	Then 'User Evergreen Capacity Project' text is displayed in the filter dropdown for the 'Project' column
	When User clicks button with 'ResetFilters' aria label
	When User unchecks following checkboxes in the filter dropdown menu for the 'Project Type' column:
	| checkboxes                 |
	| Computer Scheduled Project |
	Then 'Device scoped,User scoped' text is displayed in the filter dropdown for the 'Project Type' column
	When User clicks button with 'ResetFilters' aria label
	When User unchecks following checkboxes in the filter dropdown menu for the 'Path' column:
	| checkboxes                   |
	| R.requestTypeComp            |
	| Computer Request Type A      |
	| Computer: Laptop Replacement |
	Then '[Default (Computer)]' text is displayed in the filter dropdown for the 'Path' column
	When User clicks button with 'ResetFilters' aria label
	When User unchecks following checkboxes in the filter dropdown menu for the 'Category' column:
	| checkboxes           |
	| Empty                |
	| comp category K      |
	| Poland               |
	| R.testCategoriesComp |
	Then 'Category Computer' text is displayed in the filter dropdown for the 'Category' column