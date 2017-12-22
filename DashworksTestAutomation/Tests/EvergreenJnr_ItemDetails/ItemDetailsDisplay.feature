@retry:1
Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS-10438
Scenario Outline: EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknown
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchCriteria>"
	And User click content from "<ColumnName>" column
	When User navigates to the "Details" tab
	Then Unknown text is displayed for empty fields for "Department and Location" section

Examples: 
	| PageName     | SearchCriteria                     | ColumnName    |
	| Mailboxes    | azuresync3@juriba1.onmicrosoft.com | Email Address |
	| Users        | ABW1509426                         | Username      |
	| Devices      | 01BQIYGGUW5PRP6                    | Hostname      |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS-11531
Scenario: EvergreenJnr_MailboxesLists_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMailboxDetailsWhereThereIsNoMailboxOwner
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "alex.cristea@juriba.com"
	When User click content from "Email Address" column
	Then "No mailbox owner found for this mailbox" text is displayed for "Mailbox Owner" section