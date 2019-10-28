Feature: ItemDetails_MultiselectFilterChecking_UsersPage
	Runs Multiselect Filter Checking for Users Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForActiveDirectoryTabGroupsOnUsersPage
	When User navigates to the 'User' details page for 'ZWS705179' item
	Then Details page for "ZWS705179 (Derick I. Thomas)" item is displayed to the user
	When User navigates to the 'Active Directory' left menu item
	Then 'US-W' content is displayed in the 'Domain' column
	Then 'Global Security Group' content is displayed in the 'Type' column
	When User navigates to the 'Groups' left submenu item
	And User have opened Column Settings for "Group" column
	And User clicks Column button on the Column Settings panel
	And User select "Directory Type" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| US-W   |
	When User closes Checkbox filter for "Domain" column
	And User clicks String Filter button for "Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values                |
	| Global Security Group |
	When User closes Checkbox filter for "Type" column
	And User clicks String Filter button for "Directory Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values           |
	| Active Directory |
	When User closes Checkbox filter for "Directory Type" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenSummaryOnUsersPage
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	Then 'JuribaDEV50' content is displayed in the 'Site' column
	And 'UNKNOWN' content is displayed in the 'Installed' column
	And 'UNKNOWN' content is displayed in the 'Used' column
	And 'TRUE' content is displayed in the 'Entitled' column
	And 'FALSE' content is displayed in the 'Entitled To Device' column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values  |
	| UNKNOWN |
	When User closes Checkbox filter for "Compliance" column
	And User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values      |
	| JuribaDEV50 |
	When User closes Checkbox filter for "Site" column
	And User clicks String Filter button for "Installed" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| Unknown |
	When User closes Checkbox filter for "Installed" column
	And User clicks String Filter button for "Used" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| Unknown |
	When User closes Checkbox filter for "Used" column
	And User clicks String Filter button for "Entitled" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Entitled" column
	And User clicks String Filter button for "Entitled To Device" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| False  |
	When User closes Checkbox filter for "Entitled To Device" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenDetailOnUsersPage
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Detail' left submenu item
	Then 'UNKNOWN' content is displayed in the 'Compliance' column
	And 'JuribaDEV50' content is displayed in the 'Site' column
	Then "Entitled" content is displayed in "Association Type" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values  |
	| UNKNOWN |
	When User closes Checkbox filter for "Compliance" column
	And User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values      |
	| JuribaDEV50 |
	When User closes Checkbox filter for "Site" column
	And User clicks String Filter button for "Association Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values   |
	| Entitled |
	When User closes Checkbox filter for "Association Type" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabAdvertisementsOnUsersPage
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Advertisements' left submenu item
	Then 'JuribaDEV50' content is displayed in the 'Site' column
	When User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values      |
	| JuribaDEV50 |
	When User closes Checkbox filter for "Site" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabCollectionsOnUsersPage
	When User navigates to the 'User' details page for 'allanj' item
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Collections' left submenu item
	Then 'SMS/SCCM 2007' content is displayed in the 'Source Type' column
	And 'DC1 SMS (DEV50)' content is displayed in the 'Source' column
	And 'JuribaDEV50' content is displayed in the 'Site' column
	When User clicks String Filter button for "Source Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values        |
	| SMS/SCCM 2007 |
	When User closes Checkbox filter for "Source Type" column
	And User clicks String Filter button for "Source" column
	Then following String Values are displayed in the filter on the Details Page
	| Values          |
	| DC1 SMS (DEV50) |
	When User closes Checkbox filter for "Source" column
	And User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values      |
	| JuribaDEV50 |
	When User closes Checkbox filter for "Site" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMailboxesTabOnUsersPage
	When User navigates to the 'User' details page for '02BE025D56CF4899889' item
	Then Details page for "02BE025D56CF4899889 (Wegemer, Susan)" item is displayed to the user
	When User navigates to the 'Mailboxes' left menu item
	And User navigates to the 'Mailboxes' left submenu item
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then 'TRUE' content is displayed in the 'Owner' column
	When User clicks String Filter button for "Owner" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Owner" column
	And User navigates to the 'Mailbox Permissions' left submenu item
	Then 'FullAccess' content is displayed in the 'Permission' column
	When User clicks String Filter button for "Permission" column
	Then following String Values are displayed in the filter on the Details Page
	| Values         |
	| FullAccess     |
	| ReadPermission |
	When User closes Checkbox filter for "Permission" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForComplianceTabOnUsersPage
	When User navigates to the 'User' details page for 'ZWS705179' item
	Then Details page for "ZWS705179 (Derick I. Thomas)" item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	And User navigates to the 'Hardware Rules' left submenu item
	Then 'AMBER' content is displayed in the 'Compliance' column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| AMBER  |
	When User closes Checkbox filter for "Compliance" column
	And User navigates to the 'Application Issues' left submenu item
	And User have opened Column Settings for "Type" column
	And User clicks Column button on the Column Settings panel
	And User select "Application" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then 'TierA Site01' content is displayed in the 'Site' column
	Then 'TRUE' content is displayed in the 'Installed' column
	Then 'RED' content is displayed in the 'Compliance' column
	When User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values       |
	| TierA Site01 |
	When User closes Checkbox filter for "Site" column
	When User clicks String Filter button for "Installed" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Installed" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| RED    |
	| AMBER  |
	When User closes Checkbox filter for "Compliance" column