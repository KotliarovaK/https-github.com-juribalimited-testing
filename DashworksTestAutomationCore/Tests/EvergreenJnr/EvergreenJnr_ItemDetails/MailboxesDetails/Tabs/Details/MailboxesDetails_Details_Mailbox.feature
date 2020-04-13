Feature: MailboxesDetails_Details_Mailbox
	Runs related tests for Details > Mailbox

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11667 @DAS12321 @DAS11921
Scenario: EvergreenJnr_MailboxesList_CheckThatNoConsoleErrorsWhenViewingMailboxDetails
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks on 'Email Address' column header
	And User clicks on 'Email Address' column header
	And User click content from "Email Address" column
	Then 'Mailbox' left submenu item is displayed
	Then Item content is displayed to the User
	And There are no errors in the browser console