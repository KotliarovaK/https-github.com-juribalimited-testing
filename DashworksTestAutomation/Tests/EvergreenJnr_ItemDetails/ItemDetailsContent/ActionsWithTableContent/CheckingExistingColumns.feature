Feature: CheckingExistingColumns
	Runs Item Details Checking Existing Columns related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091 @DAS14923 @DAS16564
Scenario: EvergreenJnr_DevicesList_CheckRenamedColumnForApplicationTabOnTheDetailsPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	When User navigates to the 'Applications' left menu item
	When User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16564
Scenario: EvergreenJnr_UsersList_CheckRenamedColumnForApplicationTabOnTheDetailsPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User perform search by "ZZZ588323"
	And User click content from "Username" column
	When User navigates to the 'Applications' left menu item
	When User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12088 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatMailboxPermissionsAndFolderPermissionsDataAreDisplayedCorrectly
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User perform search by "abraham.f.wong@dwlabs.local"
	And User click content from "Email Address" column
	When User navigates to the 'Users' left menu item
	And User navigates to the "Mailbox Permissions" sub-menu on the Details page
	Then Content is present in the table on the Details Page
	And "68" rows found label displays on Details Page
	When User navigates to the "Folder Permissions" sub-menu on the Details page
	Then Content is present in the table on the Details Page
	And "14" rows found label displays on Details Page

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12765 @DAS12860
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketColumnIsDisplayedOnDetailsProjectsPages
	When User clicks '<PageName>' on the left-hand menu
	And User perform search by "<SearchTerm>"
	And User click content from "<Column>" column
	When User navigates to the 'Projects' left menu item
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	Then "Bucket" column is displayed to the user

Examples:
	| PageName  | SearchTerm                       | Column        | SubTabName              |
	| Devices   | 001BAQXT6JWFPI                   | Hostname      | Owner Projects Summary  |
	| Users     | hurstbl                          | Username      | User Projects           |
	| Users     | hurstbl                          | Username      | Mailbox Project Summary |
	| Users     | ZZZ588323                        | Username      | Device Project Summary  |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address | Mailbox User Projects   |