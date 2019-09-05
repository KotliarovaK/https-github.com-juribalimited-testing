Feature: ItemDetails_MultiselectFilterChecking_GroupsPage
	Runs Multiselect Filter Checking for Groups Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_GroupsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMembersTabOnGroupsPage
	When User type "Schema Admins" in Global Search Field
	Then User clicks on "Schema Admins" search result
	And Details page for "Schema Admins" item is displayed to the user
	When User navigates to the "Members" main-menu on the Details page
	When User navigates to the "User Members" sub-menu on the Details page
	Then 'DEV50' content is displayed in the 'Domain' column
	Then 'TRUE' content is displayed in the 'Enabled' column
	When User have opened Column Settings for "Username" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Username" checkbox on the Column Settings panel
	And User select "Directory Type" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| DEV50  |
	When User closes Checkbox filter for "Domain" column
	And User clicks String Filter button for "Enabled" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Enabled" column
	And User clicks String Filter button for "Directory Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values           |
	| Active Directory |
	When User closes Checkbox filter for "Directory Type" column