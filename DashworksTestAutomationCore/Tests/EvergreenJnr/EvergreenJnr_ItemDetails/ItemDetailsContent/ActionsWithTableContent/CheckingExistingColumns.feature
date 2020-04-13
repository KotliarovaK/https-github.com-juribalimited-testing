Feature: CheckingExistingColumns
	Runs Item Details Checking Existing Columns related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091 @DAS14923 @DAS16564 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckRenamedColumnForApplicationTabOnTheDetailsPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Evergreen Summary' left submenu item
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the 'Evergreen Detail' left submenu item
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the 'Advertisements' left submenu item
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16564 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckRenamedColumnForApplicationTabOnTheDetailsPage
	When User navigates to the 'User' details page for 'ZZZ588323' item
	Then Details page for 'ZZZ588323' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Evergreen Summary' left submenu item
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the 'Evergreen Detail' left submenu item
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12088 @DAS12321 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatMailboxPermissionsAndFolderPermissionsDataAreDisplayedCorrectly
	When User navigates to the 'Mailbox' details page for 'abraham.f.wong@dwlabs.local' item
	Then Details page for 'abraham.f.wong@dwlabs.local' item is displayed to the user
	When User navigates to the 'Users' left menu item
	And User navigates to the 'Mailbox Permissions' left submenu item
	Then Content is present in the table on the Details Page
	And "68" rows found label displays on Details Page
	When User navigates to the 'Folder Permissions' left submenu item
	Then Content is present in the table on the Details Page
	And "14" rows found label displays on Details Page

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12765 @DAS12860 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketColumnIsDisplayedOnDetailsProjectsPages
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the '<SubTabName>' left submenu item
	Then "Bucket" column is displayed to the user

Examples:
	| PageName | SearchTerm                       | SubTabName              |
	| Device   | 001BAQXT6JWFPI                   | Owner Projects Summary  |
	| User     | hurstbl                          | User Projects           |
	| User     | hurstbl                          | Mailbox Project Summary |
	| User     | ZZZ588323                        | Device Project Summary  |
	| Mailbox  | 000F977AC8824FE39B8@bclabs.local | Mailbox User Projects   |