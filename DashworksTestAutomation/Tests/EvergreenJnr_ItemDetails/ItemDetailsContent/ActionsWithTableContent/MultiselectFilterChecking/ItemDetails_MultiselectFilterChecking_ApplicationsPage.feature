Feature: ItemDetails_MultiselectFilterChecking_ApplicationsPage
	Runs Multiselect Filter Checking for Applications Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPage
	When User navigates to the 'Application' details page for 'Accessible FormNet Fill 2.2' item
	Then Details page for "Accessible FormNet Fill 2.2" item is displayed to the user
	When User navigates to the 'Advertisements' left submenu item
	Then 'TRUE' content is displayed in the 'Active' column
	When User clicks String Filter button for "Active" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Active" column

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMsiTabOnApplicationsPage
	When User navigates to the 'Application' details page for 'Accessible FormNet Fill 2.2' item
	Then Details page for "Accessible FormNet Fill 2.2" item is displayed to the user
	When User navigates to the 'MSI' left menu item
	When User navigates to the 'MSI Files' left submenu item
	And User have opened Column Settings for "File Name" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Product Code" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then 'AOK Import' content is displayed in the 'Source' column
	Then 'ChangeBASE AOK' content is displayed in the 'Source Type' column
	Then 'GREEN' content is displayed in the 'Compliance' column
	When User clicks String Filter button for "Source" column
	Then following String Values are displayed in the filter on the Details Page
	| Values     |
	| AOK Import |
	When User closes Checkbox filter for "Source" column
	When User clicks String Filter button for "Source Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values         |
	| ChangeBASE AOK |
	When User closes Checkbox filter for "Source Type" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREEN  |
	When User closes Checkbox filter for "Compliance" column
	When User navigates to the 'AOK' left submenu item
	Then 'AOK Import' content is displayed in the 'Source' column
	Then 'Windows 7' content is displayed in the 'AOK Report' column
	Then 'GREEN' content is displayed in the 'Compatibility' column
	When User clicks String Filter button for "Source" column
	Then following String Values are displayed in the filter on the Details Page
	| Values     |
	| AOK Import |
	When User closes Checkbox filter for "Source" column
	When User clicks String Filter button for "AOK Report" column
	Then following String Values are displayed in the filter on the Details Page
	| Values    |
	| Windows 7 |
	When User closes Checkbox filter for "AOK Report" column
	When User clicks String Filter button for "Compatibility" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREEN  |
	When User closes Checkbox filter for "Compatibility" column

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDistributionTabOnApplicationsPage
	When User navigates to the 'Application' details page for 'Accessible FormNet Fill 2.2' item
	Then Details page for "Accessible FormNet Fill 2.2" item is displayed to the user
	When User navigates to the 'Distribution' left menu item
	When User navigates to the 'Devices' left submenu item
	Then 'TRUE' content is displayed in the 'Installed' column
	Then 'UNKNOWN' content is displayed in the 'Used' column
	Then 'TRUE' content is displayed in the 'Entitled' column
	When User clicks String Filter button for "Installed" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Installed" column
	When User clicks String Filter button for "Used" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| Unknown |
	When User closes Checkbox filter for "Used" column
	When User clicks String Filter button for "Entitled" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Entitled" column
	When User navigates to the 'AD' left submenu item
	Then 'UK' content is displayed in the 'Domain' column
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| AU     |
	| CA     |
	| UK     |
	| US-E   |
	| US-W   |
	When User closes Checkbox filter for "Domain" column