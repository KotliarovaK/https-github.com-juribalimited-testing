Feature: ItemDetails_MultiselectFilterChecking_UsersPage
	Runs Multiselect Filter Checking for Users Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForActiveDirectoryTabGroupsOnUsersPage
	When User navigates to the 'User' details page for 'ZWS705179' item
	Then Details page for 'ZWS705179 (Derick I. Thomas)' item is displayed to the user
	When User navigates to the 'Active Directory' left menu item
	Then 'US-W' content is displayed in the 'Domain' column
	Then 'Global Security Group' content is displayed in the 'Type' column
	When User navigates to the 'Groups' left submenu item
	And User opens 'Group' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Directory Type" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following checkboxes are displayed in the filter dropdown menu for the 'Domain' column:
	| Values |
	| US-W   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Type' column:
	| Values                |
	| Global Security Group |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Directory Type' column:
	| Values           |
	| Active Directory |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenSummaryOnUsersPage
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for 'allanj (Jo Allan)' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	Then 'JuribaDEV50' content is displayed in the 'Site' column
	And 'UNKNOWN' content is displayed in the 'Installed' column
	And 'UNKNOWN' content is displayed in the 'Used' column
	And 'TRUE' content is displayed in the 'Entitled' column
	And 'FALSE' content is displayed in the 'Entitled To Device' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values  |
	| UNKNOWN |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values      |
	| JuribaDEV50 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Installed' column:
	| Values  |
	| Unknown |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Used' column:
	| Values  |
	| Unknown |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Entitled' column:
	| Values |
	| True   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Entitled To Device' column:
	| Values |
	| False  |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenDetailOnUsersPage
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for 'allanj (Jo Allan)' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Detail' left submenu item
	Then 'UNKNOWN' content is displayed in the 'Compliance' column
	And 'JuribaDEV50' content is displayed in the 'Site' column
	Then 'Entitled' content is displayed in the 'Association Type' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values  |
	| UNKNOWN |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values      |
	| JuribaDEV50 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Association Type' column:
	| Values   |
	| Entitled |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabAdvertisementsOnUsersPage
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for 'allanj (Jo Allan)' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Advertisements' left submenu item
	Then 'JuribaDEV50' content is displayed in the 'Site' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values      |
	| JuribaDEV50 |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabCollectionsOnUsersPage
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for 'allanj (Jo Allan)' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Collections' left submenu item
	Then 'SMS/SCCM 2007' content is displayed in the 'Source Type' column
	And 'DC1 SMS (DEV50)' content is displayed in the 'Source' column
	And 'JuribaDEV50' content is displayed in the 'Site' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Source Type' column:
	| Values        |
	| SMS/SCCM 2007 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Source' column:
	| Values          |
	| DC1 SMS (DEV50) |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values      |
	| JuribaDEV50 |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMailboxesTabOnUsersPage
	When User navigates to the 'User' details page for '02BE025D56CF4899889' item
	Then Details page for '02BE025D56CF4899889 (Wegemer, Susan)' item is displayed to the user
	When User navigates to the 'Mailboxes' left menu item
	And User navigates to the 'Mailboxes' left submenu item
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then 'TRUE' content is displayed in the 'Owner' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Owner' column:
	| Values |
	| True   |
	When User navigates to the 'Mailbox Permissions' left submenu item
	Then 'FullAccess' content is displayed in the 'Permission' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Permission' column:
	| Values         |
	| FullAccess     |
	| ReadPermission |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForComplianceTabOnUsersPage
	When User navigates to the 'User' details page for 'ZWS705179' item
	Then Details page for 'ZWS705179 (Derick I. Thomas)' item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	And User navigates to the 'Hardware Rules' left submenu item
	Then 'AMBER' content is displayed in the 'Compliance' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values |
	| AMBER  |
	When User navigates to the 'Application Issues' left submenu item
	And User opens 'Type' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Application" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then 'TierA Site01' content is displayed in the 'Site' column
	Then 'TRUE' content is displayed in the 'Installed' column
	Then 'RED' content is displayed in the 'Compliance' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values       |
	| TierA Site01 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Installed' column:
	| Values |
	| True   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values |
	| RED    |
	| AMBER  |