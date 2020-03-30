Feature: ItemDetails_MultiselectFilterChecking_GroupsPage
	Runs Multiselect Filter Checking for Groups Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @DAS20491 @Zion_NewGrid
Scenario: EvergreenJnr_GroupsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMembersTabOnGroupsPage
	When User type "Schema Admins" in Global Search Field
	Then User clicks on "Schema Admins" search result
	And Details page for 'Schema Admins' item is displayed to the user
	When User navigates to the 'Members' left menu item
	When User navigates to the 'User Members' left submenu item
	Then 'DEV50' content is displayed in the 'Domain' column
	Then 'TRUE' content is displayed in the 'Enabled' column
	When User opens 'Username' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Username" checkbox on the Column Settings panel
	And User select "Directory Type" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following checkboxes are displayed in the filter dropdown menu for the 'Domain' column:
	| Values |
	| DEV50  |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Enabled' column:
	| Values |
	| True   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Directory Type' column:
	| Values           |
	| Active Directory |

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20490 @Zion_NewGrid
Scenario: EvergreenJnr_GroupsList_CheckThatGridIsDisplayedCorrectlyOnApplicationTabCollectionsSubTabForGroupPage
	When User type "Schema Admins" in Global Search Field
	Then User clicks on "Schema Admins" search result
	And Details page for 'Schema Admins' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Collections' left submenu item
	Then Content in the 'Collection' column is equal to
	| Content                              |
	| All Active Directory Security Groups |
	| All User Groups                      |
	Then Content in the 'Site' column is equal to
	| Content     |
	| JuribaDEV50 |
	| JuribaDEV50 |
	Then Content in the 'Import Type' column is equal to
	| Content       |
	| SMS/SCCM 2007 |
	| SMS/SCCM 2007 |
	Then Content in the 'Import' column is equal to
	| Content         |
	| DC1 SMS (DEV50) |
	| DC1 SMS (DEV50) |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Collection' column:
	| Values                               |
	| All Active Directory Security Groups |
	| All User Groups                      |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values      |
	| JuribaDEV50 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Import Type' column:
	| Values       |
	| SMS/SCCM 2007|
	Then following checkboxes are displayed in the filter dropdown menu for the 'Import' column:
	| Values          |
	| DC1 SMS (DEV50) |