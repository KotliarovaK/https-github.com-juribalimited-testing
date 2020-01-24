Feature: Relink_MailboxPage
	Runs Relink related tests on Mailboxes Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailbox @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19323
Scenario: EvergreenJnr_MailboxList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringPartOfObjectKeyToAutocomplete
	When User navigates to the 'Mailbox' details page for '0072B088173449E3A93@bclabs.local' item
	Then Details page for '0072B088173449E3A93@bclabs.local' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then only options having search term '993' are displayed in 'Mailbox' autocomplete
