Feature: ItemDetails_MultiselectFilterChecking_ApplicationsPage
	Runs Multiselect Filter Checking for Applications Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPage
	When User navigates to the 'Application' details page for 'Accessible FormNet Fill 2.2' item
	Then Details page for 'Accessible FormNet Fill 2.2' item is displayed to the user
	When User navigates to the 'Advertisements' left submenu item
	Then 'TRUE' content is displayed in the 'Active' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Active' column:
	| Values |
	| True   |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMsiTabOnApplicationsPage
	When User navigates to the 'Application' details page for 'Accessible FormNet Fill 2.2' item
	Then Details page for 'Accessible FormNet Fill 2.2' item is displayed to the user
	When User navigates to the 'MSI' left menu item
	When User navigates to the 'MSI Files' left submenu item
	And User opens 'File Name' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Product Code" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then 'AOK Import' content is displayed in the 'Source' column
	Then 'ChangeBASE AOK' content is displayed in the 'Source Type' column
	Then 'GREEN' content is displayed in the 'Compliance' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Source' column:
	| Values     |
	| AOK Import |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Source Type' column:
	| Values         |
	| ChangeBASE AOK |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values |
	| GREEN  |
	When User navigates to the 'AOK' left submenu item
	Then 'AOK Import' content is displayed in the 'Source' column
	Then 'Windows 7' content is displayed in the 'AOK Report' column
	Then 'GREEN' content is displayed in the 'Compatibility' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Source' column:
	| Values     |
	| AOK Import |
	Then following checkboxes are displayed in the filter dropdown menu for the 'AOK Report' column:
	| Values    |
	| Windows 7 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compatibility' column:
	| Values |
	| GREEN  |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDistributionTabOnApplicationsPage
	When User navigates to the 'Application' details page for 'Accessible FormNet Fill 2.2' item
	Then Details page for 'Accessible FormNet Fill 2.2' item is displayed to the user
	When User navigates to the 'Distribution' left menu item
	When User navigates to the 'Devices' left submenu item
	Then 'TRUE' content is displayed in the 'Installed' column
	Then 'UNKNOWN' content is displayed in the 'Used' column
	Then 'TRUE' content is displayed in the 'Entitled' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Installed' column:
	| Values |
	| True   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Used' column:
	| Values  |
	| Unknown |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Entitled' column:
	| Values |
	| True   |
	When User navigates to the 'AD' left submenu item
	Then 'UK' content is displayed in the 'Domain' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Domain' column:
	| Values |
	| AU     |
	| CA     |
	| UK     |
	| US-E   |
	| US-W   |