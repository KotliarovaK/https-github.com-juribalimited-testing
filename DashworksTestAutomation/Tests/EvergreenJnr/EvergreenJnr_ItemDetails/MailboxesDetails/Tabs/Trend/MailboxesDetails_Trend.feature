Feature: MailboxesDetails_Trend
	Runs related tests for Trend tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12245 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayed
	When User navigates to the 'Mailbox' details page for 'julia.bell@juriba.com' item
	When User navigates to the 'Trend' left menu item
	Then Highcharts graphic is displayed on the Details Page
	And There are no errors in the browser console
	When User navigates to the 'Details' left menu item
	Then There are no errors in the browser console
	When User navigates to the 'Trend' left menu item
	Then There are no errors in the browser console
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	And There are no errors in the browser console
