Feature: ItemDetailsDisplay_Api
	Runs Item Details Display API related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11478 @DAS11477 @DAS11476 @API
Scenario Outline: EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI
	When I perform test request to the "<PageName>" API and get "<ItemName>" item summary for "<SectionName>" section
	Then "<FieldName>" field display state is "<DisplayState>" on Details tab API

Examples:
	| PageName  | ItemName                      | SectionName  | FieldName         | DisplayState |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox      | Mailbox Database  | True         |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox      | Cloud Mail Server | False        |
	| Mailboxes | alex.cristea@juriba.com       | Mailbox      | Mail Server       | False        |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17274 @API
Scenario: EvergreenJnr_UserList_CheckThatDataDepartmentAndLocationTabIsDisplayedCorrectly
	When I perform test request to the "Users" API and get "002B5DC7D4D34D5C895" item summary for "Department and Location" section
	Then following fields are displayed with next state on Details tab API
	| FieldName            | DisplayState |
	| Department Name      | True         |
	| Department Full Path | True         |
	| Department Code      | True         |
	| Cost Centre          | True         |
	| Location Name        | True         |
	| Region               | True         |
	| Country              | True         |
	| City                 | True         |
	| Building Name        | True         |
	| Floor                | True         |
	| Address 1            | True         |
	| Address 2            | True         |
	| Address 3            | True         |
	| Address 4            | True         |
	| State/County         | True         |
	| Postal Code          | True         |