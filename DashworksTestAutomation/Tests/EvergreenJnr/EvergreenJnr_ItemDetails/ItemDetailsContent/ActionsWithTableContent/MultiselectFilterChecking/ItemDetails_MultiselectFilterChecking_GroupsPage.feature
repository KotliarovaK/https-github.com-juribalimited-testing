Feature: ItemDetails_MultiselectFilterChecking_GroupsPage
	Runs Multiselect Filter Checking for Groups Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
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