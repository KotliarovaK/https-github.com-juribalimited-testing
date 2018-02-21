﻿@retry:1
Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS10438 @DAS11983
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
	#| Users        | ABW1509426                         | Username      |
	#| Devices      | 01BQIYGGUW5PRP6                    | Hostname      |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11531
Scenario: EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMailboxDetailsWhereThereIsNoMailboxOwner
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "alex.cristea@juriba.com"
	When User click content from "Email Address" column
	Then "No mailbox owner found for this mailbox" text is displayed for "Mailbox Owner" section

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS10438 @DAS11983 @API @Not_Run
Scenario Outline: EvergreenJnr_AllLists_AllEmptyFieldsInItemDetailsAreDisplayedAsUnknownOnAPI
	When I perform test request to the "<PageName>" API and get "<ItemName>" item summary for "<SectionName>" section
	Then "Unknown" text displayed for "<SectionName>" empty fields

Examples: 
	| PageName  | ItemName                           | SectionName             |
	| Mailboxes | azuresync3@juriba1.onmicrosoft.com | Department and Location |
	| Users     | 00B5CCB89AD0404B965                | Department and Location |
	| Devices   | 01BQIYGGUW5PRP6                    | Department and Location |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11478 @DAS11477 @DAS11476 @DAS11510 @API
Scenario Outline: EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI
	When I perform test request to the "<PageName>" API and get "<ItemName>" item summary for "<SectionName>" section
	Then "<FieldName>" field display state is "<DisplayState>" on Details tab API

Examples:
	| PageName  | ItemName                      | SectionName  | FieldName         | DisplayState |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox      | Mailbox Database  | True         |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox      | Cloud Mail Server | False        |
	| Mailboxes | alex.cristea@juriba.com       | Mailbox      | Mail Server       | False        |
	| Devices   | 001BAQXT6JWFPI                | Device Owner | Last Logoff Date  | False        |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11721
Scenario: EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForGroupDetailsPage
	When User type "NL00G001" in Global Search Field
	Then User clicks on "NL00G001" search result
	Then Group Icon for Group Details page is displayed

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
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumns
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
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Application Key   | Application Key   |
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Advertisement Key | Advertisement Key |
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Group Key         | Group Key         |
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Collection Key    | Collection Key    |
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | User Key          | User Key          |
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
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSections
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

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11053
Scenario: EvergreenJnr_UsersLists_CheckThatTheTableColumnsAreNotDuplicatedOnTheDetailsPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "Administrator.Users.dwlabs.local"
	When User click content from "Username" column
	And User navigates to the "Devices" tab
	Then ColumnName is displayed in following order on the Details page:
	| ColumnName     |
	| Hostname       |
	| OS Full Name   |
	| Type           |
	| Source Type    |
	| Source         |
	| Inventory Site |
	| IP Address     |
	| Compliance     |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11393
Scenario: EvergreenJnr_DevicesLists_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTheDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Projects" tab
	When User open "Device Projects" section
	When User have opened Column Settings for "Project" column in the Details Page table
	When User click Column button on the Column Settings panel
	When User select "Key" checkbox on the Column Settings panel
	When User click Column button on the Column Settings panel
	Then ColumnName is added to the list in the Details Page table
	| ColumnName |
	| Key        |
	Then ColumnName is displayed in following order on the Details page:
	| ColumnName   |
	| Project      |
	| Project Type |
	| Request Type |
	| Workflow     |
	| Category     |
	| Status       |
	| Date         |
	| Readiness    |
	| Key          |
	Then Checkboxes are checked on the Column Settings panel for "Key" Column Settings panel:
	| Checkbox     |
	| Key          |
	| Project      |
	| Project Type |
	| Request Type |
	| Workflow     |
	| Category     |
	| Status       |
	| Date         |
	| Readiness    |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091
Scenario Outline: EvergreenJnr_AllLists_CheckRenamedColumnForApplicationSummarySectionOnTheDetailsPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "Applications" tab
	Then "Manufacturer" column is not displayed to the user
	Then ColumnName is added to the list in the Details Page table
	| ColumnName |
	| Vendor     |

Examples:
	| PageName | SelectedName   | ColumnName |
	| Devices  | 001BAQXT6JWFPI | Hostname   |
	| Users    | ZZZ588323      | Username   |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091
Scenario Outline: EvergreenJnr_AllLists_CheckRenamedColumnForApplicationDetailSectionOnTheDetailsPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "Applications" tab
	Then User closes "Application Summary" section on the Details Page
	When User open "Application Detail" section
	Then "Manufacturer" column is not displayed to the user
	And ColumnName is added to the list in the Details Page table
	| ColumnName |
	| Vendor     |

Examples:
	| PageName | SelectedName   | ColumnName |
	| Devices  | 001BAQXT6JWFPI | Hostname   |
	| Users    | ZZZ588323      | Username   |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091
Scenario Outline: EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "Compliance" tab
	When User open "Software Compliance Issues" section
	Then "Manufacturer" column is not displayed to the user
	And ColumnName is added to the list in the Details Page table
	| ColumnName |
	| Vendor     |
	Then string filter is displayed for "Vendor" column on the Details Page

Examples:
	| PageName | SelectedName   | ColumnName |
	| Devices  | 001BAQXT6JWFPI | Hostname   |
	| Users    | ZZZ588323      | Username   |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11667
Scenario: EvergreenJnr_MailboxesLists_CheckThatNoConsoleErrorsWhenViewingMailboxDetails
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User click content from "Email Address" column
	Then Item content is displayed to the User
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11483
Scenario: EvergreenJnr_DevicesLists_CheckThatDataOfColumnsIsDisplayedInTheCustomFieldSection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "54S1MGR8DYMYKH"
	And User click content from "Hostname" column
	And User navigates to the "Details" tab
	Then User closes "Device" section on the Details Page
	When User open "Custom Fields" section
	Then Content is present in the column of the Details Page table
	| ColumnName |
	| Label      |
	| Value      |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11479 @Not_Run
Scenario: EvergreenJnr_MailboxesLists_CheckThatLinksAndImageItemAreDisplayedInTheNameAndDisplayNameColumns
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User click content from "Email Address" column
	And User navigates to the "Users" tab
	Then User closes "Users" section on the Details Page
	When User open "Mailbox Permissions" section
	Then Image item from "Name" column is displayed to the user
	Then Links from "Name" column is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11983
Scenario Outline: EvergreenJnr_AllLists_CheckThatRowsInTheTableAreEmptyIfTheDataIsUnknown
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "Details" tab
	Then User closes "<SectionName>" section on the Details Page
	When User open "Department and Location" section
	Then Empty rows are displayed if the data is unknown

Examples:
	| PageName  | SelectedName                     | ColumnName    | SectionName |
	| Devices   | 001BAQXT6JWFPI                   | Hostname      | Device      |
	| Users     | $231000-3AC04R8AR431             | Username      | AD Object   |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address | Mailbox     |