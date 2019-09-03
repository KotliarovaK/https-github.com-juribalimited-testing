Feature: ItemDetails_MultiselectFilterChecking_MailboxesPage
	Runs Multiselect Filter Checking for Mailboxes Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User perform search by "002B5DC7D4D34D5C895"
	And User click content from "Email Address" column
	Then Details page for "002B5DC7D4D34D5C895@bclabs.local" item is displayed to the user
	When User navigates to the "Email Addresses" sub-menu on the Details page
	Then "SMTP" content is displayed in the "Type" column
	Then "TRUE" content is displayed in the "Reply To" column
	When User clicks String Filter button for "Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| SMTP   |
	When User closes Checkbox filter for "Type" column
	When User clicks String Filter button for "Reply To" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Reply To" column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User perform search by "002B5DC7D4D34D5C895"
	And User click content from "Email Address" column
	Then Details page for "002B5DC7D4D34D5C895@bclabs.local" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	When User navigates to the "Users" sub-menu on the Details page
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then "TRUE" content is displayed in the "Owner" column
	Then "" content is displayed in the "Domain" column
	When User clicks String Filter button for "Owner" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Owner" column
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| Empty  |
	When User closes Checkbox filter for "Domain" column
	When User navigates to the "Groups" sub-menu on the Details page
	Then "BCLABS" content is displayed in the "Domain" column
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| BCLABS |
	When User closes Checkbox filter for "Domain" column
	When User navigates to the "Mailbox Permissions" sub-menu on the Details page
	Then "BCLABS" content is displayed in the "Domain" column
	Then "FullAccess" content is displayed in the "Permission" column
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| BCLABS |
	When User closes Checkbox filter for "Domain" column
	When User clicks String Filter button for "Permission" column
	Then following String Values are displayed in the filter on the Details Page
	| Values           |
	| FullAccess       |
	| ReadPermission   |
	| DeleteItem       |
	| ChangeOwner      |
	| ChangePermission |
	When User closes Checkbox filter for "Permission" column