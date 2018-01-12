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

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11478 @DAS11477 @DAS11476
Scenario Outline: EvergreenJnr_MailboxesList_CheckThatSelectedFieldStateOnDetailsTab
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "<EmailAddress>"
	And User click content from "Email Address" column
	Then "<FieldName>" field display state is "<DisplayState>" on Details tab

Examples:
	| EmailAddress                  | FieldName         | DisplayState |
	| alfredo.m.daniel@dwlabs.local | Mailbox Database  | true         |
	| alfredo.m.daniel@dwlabs.local | Cloud Mail Server | false        |
	| alex.cristea@juriba.com       | Mail Server       | false        |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11510
Scenario: EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwnerBlockOfDeviceDetails
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Details" tab
	And User navigates to the "Device Owner" section
	Then "Last Logoff Date" field display state is "false" on Details tab