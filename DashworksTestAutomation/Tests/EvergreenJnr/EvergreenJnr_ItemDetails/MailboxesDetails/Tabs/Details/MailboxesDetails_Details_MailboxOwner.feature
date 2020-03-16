Feature: MailboxesDetails_Details_MailboxOwner
	Runs related tests for Details > Mailbox Owner tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690 @DAS12321 @DAS14923
Scenario: EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User navigates to the 'Mailbox' details page for 'hartmajt@bclabs.local' item
	Then Details page for 'hartmajt@bclabs.local' item is displayed to the user
	When User navigates to the 'Mailbox Owner' left submenu item
	And User clicks "hartmajt" link on the Details Page
	Then Details object page is displayed to the user