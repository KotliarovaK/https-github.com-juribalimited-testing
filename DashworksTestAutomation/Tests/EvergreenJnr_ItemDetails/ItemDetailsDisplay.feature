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

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11478 @DAS11477 @DAS11476
Scenario Outline: EvergreenJnr_MailboxesList_CheckStateOfSelectedFieldOnDetailsTab
	When I perform test request to the "<PageName>" API and get "<ColumnName>" item summary
	Then "<FieldName>" field display state is "<DisplayState>" on Details tab API

Examples:
	| PageName  | ColumnName                    | FieldName         | DisplayState |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox Database  | True         |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Cloud Mail Server | False        |
	| Mailboxes | alex.cristea@juriba.com       | Mail Server       | False        |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11510
Scenario: EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwnerBlockOfDeviceDetails
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Details" tab
	And User open "Device Owner" section
	Then "Last Logoff Date" field display state is "false" on Details tab
	
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

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	When User have opened Column Settings for "<ColumnName>" column in the Details Page table
	When User click Column button on the Column Settings panel
	When User select "<CheckboxName>" checkbox on the Column Settings panel
	When User click Column button on the Column Settings panel
	Then ColumnName is added to the list in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	And Content is present in the newly added column in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| PageName     | ItemName      | TabName      | ColumnName  | CheckboxName      | NewColumnName     |
	| Devices      | Hostname      | Applications | Application | Key               | Key               |
	| Users        | Username      | Groups       | Group       | Key               | Key               |
	| Applications | Application   | Projects     | Project     | Object ID         | Object ID         |
	| Applications | Application   | Projects     | Project     | Object Key        | Object Key        |
	| Mailboxes    | Email Address | Users        | Domain      | Key               | Key               |
	| Mailboxes    | Email Address | Users        | Domain      | EvergreenObjectId | EvergreenObjectId |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732
Scenario Outline: EvergreenJnr_AllLists_CtheckThatDataIsDisplayedAfterAddingColumns
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	Then User closes "<ExpandedSectionName>" section on the Details Page
	When User open "<SectionName>" section
	When User have opened Column Settings for "<ColumnName>" column in the Details Page table
	When User click Column button on the Column Settings panel
	When User select "<CheckboxName>" checkbox on the Column Settings panel
	When User click Column button on the Column Settings panel
	Then ColumnName is added to the list in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	And Content is present in the newly added column in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| PageName     | ItemName      | TabName      | ExpandedSectionName | SectionName         | ColumnName    | CheckboxName      | NewColumnName     |
	#| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Application Key   | Application Key   |
	#| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Advertisement Key | Advertisement Key |
	#| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Group Key         | Group Key         |
	#| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Collection Key    | Collection Key    |
	#| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | User Key          | User Key          |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Key               | Key               |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Application Key   | Application Key   |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | SiteKey           | SiteKey           |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Collection Key    | Collection Key    |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Program Key       | Program Key       |
	| Devices      | Hostname      | Applications | Application Summary | Collections         | Collection    | Key               | Key               |
	| Devices      | Hostname      | Applications | Application Summary | Collections         | Collection    | SiteKey           | SiteKey           |
	| Applications | Application   | Details      | Application         | Advertisements      | Advertisement | Advertisement Key | Advertisement Key |
	| Applications | Application   | Details      | Application         | Advertisements      | Advertisement | Collection Key    | Collection Key    |
	| Applications | Application   | Details      | Application         | Programs            | Program       | Program Key       | Program Key       |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Computer Key      | Computer Key      |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Owner Object Key  | Owner Object Key  |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | User Key          | User Key          |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Advertisement Key | Advertisement Key |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Collection Key    | Collection Key    |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Program Key       | Program Key       |
	| Mailboxes    | Email Address | Users        | Users               | Groups              | Domain        | Key               | Key               |
	| Mailboxes    | Email Address | Users        | Users               | Mailbox Permissions | Domain        | Key               | Key               |
	| Mailboxes    | Email Address | Users        | Users               | Mailbox Permissions | Domain        | ViaGroupObjectKey | ViaGroupObjectKey |
	| Mailboxes    | Email Address | Users        | Users               | Mailbox Permissions | Domain        | AccessCategoryKey | AccessCategoryKey |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732
Scenario Outline: EvergreenJnr_AllLists_CtheckThatDataIsDisplayedAfterAddingColumnsForClosedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	When User open "<SectionName>" section
	When User have opened Column Settings for "<ColumnName>" column in the Details Page table
	When User click Column button on the Column Settings panel
	When User select "<CheckboxName>" checkbox on the Column Settings panel
	When User click Column button on the Column Settings panel
	Then ColumnName is added to the list in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	And Content is present in the newly added column in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| PageName | ItemName | TabName    | SectionName                | ColumnName  | CheckboxName     | NewColumnName    |
	| Devices  | Hostname | Compliance | Software Compliance Issues | Application | PackageKey       | PackageKey       |
	| Devices  | Hostname | Projects   | Device Projects            | Project     | Object ID        | Object ID        |
	| Devices  | Hostname | Projects   | Device Projects            | Project     | Key              | Key              |
	| Devices  | Hostname | Projects   | Device Owner Projects      | Username    | ObjecyKey        | ObjecyKey        |
	| Devices  | Hostname | Projects   | Device Owner Projects      | Username    | Object ID        | Object ID        |
	| Devices  | Hostname | Projects   | Device Owner Projects      | Username    | Key              | Key              |
	| Devices  | Hostname | Projects   | Device Owner Projects      | Username    | Request Type Key | Request Type Key |
	| Devices  | Hostname | Projects   | Device Owner Projects      | Username    | Category Key     | Category Key     |
	| Devices  | Hostname | Projects   | Device Owner Projects      | Username    | Status Key       | Status Key       |
	| Users  | Username   | Projects   | Device Owner Projects      | Username    | Status Key       | Status Key       |