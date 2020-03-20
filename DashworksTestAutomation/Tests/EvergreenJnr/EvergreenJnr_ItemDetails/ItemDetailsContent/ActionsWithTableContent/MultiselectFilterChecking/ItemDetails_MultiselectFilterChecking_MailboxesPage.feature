Feature: ItemDetails_MultiselectFilterChecking_MailboxesPage
	Runs Multiselect Filter Checking for Mailboxes Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '002B5DC7D4D34D5C895@bclabs.local' item
	Then Details page for '002B5DC7D4D34D5C895@bclabs.local' item is displayed to the user
	When User navigates to the 'Email Addresses' left submenu item
	Then 'SMTP' content is displayed in the 'Type' column
	Then 'TRUE' content is displayed in the 'Reply To' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Type' column:
	| Values |
	| SMTP   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Reply To' column:
	| Values |
	| True   |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '002B5DC7D4D34D5C895@bclabs.local' item
	Then Details page for '002B5DC7D4D34D5C895@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Users' left menu item
	When User navigates to the 'Users' left submenu item
	Then 'TRUE' content is displayed in the 'Owner' column
	Then '' content is displayed in the 'Domain' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Owner' column:
	| Values |
	| True   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Domain' column:
	| Values |
	| Empty  |
	When User navigates to the 'Groups' left submenu item
	Then 'BCLABS' content is displayed in the 'Domain' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Domain' column:
	| Values |
	| BCLABS |
	When User navigates to the 'Mailbox Permissions' left submenu item
	Then 'BCLABS' content is displayed in the 'Domain' column
	Then 'FullAccess' content is displayed in the 'Permission' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Domain' column:
	| Values |
	| BCLABS |
	#Order of the options in the 'Permission' dropdown is the same as on Senior
	Then following checkboxes are contained in the filter dropdown menu for the 'Permission' column:
	| Values           |
	| ReadPermission   |
	| FullAccess       |
	| DeleteItem       |
	| ChangePermission |
	| ChangeOwner      |