@retry:1
Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS10438
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

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11531
Scenario: EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMailboxDetailsWhereThereIsNoMailboxOwner
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "alex.cristea@juriba.com"
	When User click content from "Email Address" column
	Then "No mailbox owner found for this mailbox" text is displayed for "Mailbox Owner" section

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11478 @DAS11477 @DAS11476 @DAS11510
Scenario Outline: EvergreenJnr_MailboxesList_CheckStateOfSelectedFieldOnDetailsTabOnAPI
	When I perform test request to the "<PageName>" API and get "<ItemName>" item summary for "<SectionName>" section
	Then "<FieldName>" field display state is "<DisplayState>" on Details tab API

Examples:
	| PageName  | ItemName                      | SectionName  | FieldName         | DisplayState |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox      | Mailbox Database  | True         |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox      | Cloud Mail Server | False        |
	| Mailboxes | alex.cristea@juriba.com       | Mailbox      | Mail Server       | False        |
	| Devices   | 001BAQXT6JWFPI                | Device Owner | Last Logoff Date  | False        |
	
@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11721
Scenario Outline: EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForAllPages
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ObjectName>"
	When User click content from "<ColumnName>" column
	Then Group Icon for "<PageName>" page is displayed 
	
Examples: 
	| PageName     | ObjectName                       | ColumnName    |
	| Devices      | 001BAQXT6JWFPI                   | Hostname      |
	| Users        | 002B5DC7D4D34D5C895              | Username      |
	| Applications | Acrobat Reader 4                 | Application   |
	| Mailboxes    | 00BDBAEA57334C7C8F4@bclabs.local | Email Address |
