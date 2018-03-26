@retry:1
Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11531
Scenario: EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMailboxDetailsWhereThereIsNoMailboxOwner
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "alex.cristea@juriba.com"
	When User click content from "Email Address" column
	Then "No mailbox owner found for this mailbox" text is displayed for "Mailbox Owner" section

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

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	When User have opened Column Settings for "<ColumnName>" column in the Details Page table
	When User clicks Column button on the Column Settings panel
	When User select "<CheckboxName>" checkbox on the Column Settings panel
	When User clicks Column button on the Column Settings panel
	Then ColumnName is added to the list in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	And Content is present in the newly added column in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| PageName     | ItemName      | TabName      | ColumnName  | CheckboxName        | NewColumnName       |
	| Devices      | Hostname      | Applications | Application | Key                 | Key                 |
	| Users        | Username      | Groups       | Group       | Key                 | Key                 |
	| Applications | Application   | Projects     | Project     | Object ID           | Object ID           |
	| Applications | Application   | Projects     | Project     | Object Key          | Object Key          |
	| Mailboxes    | Email Address | Users        | Domain      | Key                 | Key                 |
	| Mailboxes    | Email Address | Users        | Domain      | Evergreen Object ID | Evergreen Object ID |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumns
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	Then User closes "<ExpandedSectionName>" section on the Details Page
	When User opens "<SectionName>" section on the Details Page
	When User have opened Column Settings for "<ColumnName>" column in the Details Page table
	When User clicks Column button on the Column Settings panel
	When User select "<CheckboxName>" checkbox on the Column Settings panel
	When User clicks Column button on the Column Settings panel
	Then ColumnName is added to the list in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	And Content is present in the newly added column in the Details Page table
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| PageName     | ItemName      | TabName      | ExpandedSectionName | SectionName         | ColumnName    | CheckboxName         | NewColumnName        |
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Application Key      | Application Key      |
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Advertisement Key    | Advertisement Key    |
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Group Key            | Group Key            |
	| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | Collection Key       | Collection Key       |
	#| Devices      | Hostname      | Applications | Application Summary | Application Detail  | Application   | User Key             | User Key             |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Key                  | Key                  |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Application Key      | Application Key      |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Site Key              | Site Key              |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Collection Key       | Collection Key       |
	| Devices      | Hostname      | Applications | Application Summary | Advertisements      | Application   | Program Key          | Program Key          |
	| Devices      | Hostname      | Applications | Application Summary | Collections         | Collection    | Key                  | Key                  |
	| Devices      | Hostname      | Applications | Application Summary | Collections         | Collection    | Site Key             | Site Key             |
	| Applications | Application   | Details      | Application         | Advertisements      | Advertisement | Advertisement Key    | Advertisement Key    |
	| Applications | Application   | Details      | Application         | Advertisements      | Advertisement | Collection Key       | Collection Key       |
	| Applications | Application   | Details      | Application         | Programs            | Program       | Program Key          | Program Key          |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Computer Key         | Computer Key         |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Owner Object Key     | Owner Object Key     |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | User Key             | User Key             |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Advertisement Key    | Advertisement Key    |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Collection Key       | Collection Key       |
	| Applications | Application   | Distribution | Users               | Devices             | Device        | Program Key          | Program Key          |
	| Mailboxes    | Email Address | Users        | Users               | Groups              | Domain        | Key                  | Key                  |
	| Mailboxes    | Email Address | Users        | Users               | Mailbox Permissions | Domain        | Key                  | Key                  |
	| Mailboxes    | Email Address | Users        | Users               | Mailbox Permissions | Domain        | Via Group Object Key | Via Group Object Key |
	| Mailboxes    | Email Address | Users        | Users               | Mailbox Permissions | Domain        | Access Category Key  | Access Category Key  |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12053 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	When User opens "<SectionName>" section on the Details Page
	When User have opened Column Settings for "<ColumnName>" column in the Details Page table
	When User clicks Column button on the Column Settings panel
	When User select "<CheckboxName>" checkbox on the Column Settings panel
	When User clicks Column button on the Column Settings panel
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
	| Devices  | Hostname | Projects   | Device Owner Projects      | Username    | Object Key       | Object Key       |
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
	When User opens "Device Projects" section on the Details Page
	When User have opened Column Settings for "Project" column in the Details Page table
	When User clicks Column button on the Column Settings panel
	When User select "Key" checkbox on the Column Settings panel
	When User clicks Column button on the Column Settings panel
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
	When User opens "Application Detail" section on the Details Page
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
	When User opens "Software Compliance Issues" section on the Details Page
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
	When User opens "Custom Fields" section on the Details Page
	Then Content is present in the column of the Details Page table
	| ColumnName |
	| Label      |
	| Value      |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11479
Scenario: EvergreenJnr_MailboxesLists_CheckThatLinksAndImageItemAreDisplayedInTheNameAndDisplayNameColumns
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User click content from "Email Address" column
	And User navigates to the "Users" tab
	Then User closes "Users" section on the Details Page
	When User opens "Mailbox Permissions" section on the Details Page
	Then Image item from "Name" column is displayed to the user
	Then Links from "Name" column is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11983 @DAS11926
Scenario Outline: EvergreenJnr_AllLists_CheckThatRowsInTheTableAreEmptyIfTheDataIsUnknown
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "<TabName>" tab
	Then User closes "<ClosesSectionName>" section on the Details Page
	When User opens "<OpensSectionName>" section on the Details Page
	Then Empty rows are displayed if the data is unknown

Examples:
	| PageName  | SelectedName                     | ColumnName    | TabName | ClosesSectionName | OpensSectionName        |
	| Devices   | 00K4CEEQ737BA4L                  | Hostname      | Details | Device            | Department and Location |
	| Users     | $231000-3AC04R8AR431             | Username      | Details | AD Object         | Department and Location |
	| Mailboxes | aaron.u.flores@dwlabs.local      | Email Address | Details | Mailbox           | Department and Location |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address | Details | Mailbox           | Mailbox                 |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11762 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click content from "<ColumnName>" column
	And User navigates to the "<TabName>" tab
	And User have opened Column Settings for "<SelectedColumn>" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	Then User enters "12345" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console

Examples:
	| PageName     | ColumnName    | TabName      | SelectedColumn |
	| Devices      | Hostname      | Applications | Application    |
	| Users        | Username      | Groups       | Group          |
	| Applications | Application   | MSI          | File Name      |
	| Mailboxes    | Email Address | Users        | Username       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11628
Scenario: EvergreenJnr_DevicesLists_CheckThatTheFilterDropddownIsDisplayedFullyWhenTheFilterResultNotContainsValues
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" tab
	And User have opened Column Settings for "Installed" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	Then Filter panel has standard size
	Then User select "FALSE" checkbox from filter on the Details Page
	Then Filter panel has standard size

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11647
Scenario Outline: EvergreenJnr_DevicesLists_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" tab
	Then User closes "Application Summary" section on the Details Page
	When User opens "<SectionName>" section on the Details Page
	And User have opened Column Settings for "Site" column in the Details Page table
	And User have select "Autosize This column" option from column settings on the Details Page
	Then Site column has standard size

	Examples:
	| SectionName    |
	| Advertisements |
	| Collections    |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12043
Scenario: EvergreenJnr_DevicesLists_CheckThatNoErrorsAreDisplayedWhenOpenedDeviceDetailsThatDoesNotContainOwnerInformation
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "06Y8HSNCPVHENV"
	And User click content from "Hostname" column
	And User navigates to the "Details" tab
	And User opens "Device Owner" section on the Details Page
	Then "No device owner information found for this device" message is displayed on the Details Page
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12071
Scenario: EvergreenJnr_DevicesLists_CheckThatOpenedSectionIsDisplayedCorrectlyOnTheDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" tab
	Then User closes "Application Summary" section on the Details Page
	When User opens "Application Detail" section on the Details Page
	Then opened section is displayed correctly
	And User closes "Application Detail" section on the Details Page
	When User opens "Advertisements" section on the Details Page
	Then opened section is displayed correctly
	And User closes "Advertisements" section on the Details Page
	When User opens "Collections" section on the Details Page
	Then opened section is displayed correctly

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12253
Scenario: EvergreenJnr_DevicesLists_CheckThePossibilityToRecheckingTheWorkflowColumnBlanksFilterAfterUncheckingIt
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Projects" tab
	And User opens "Device Projects" section on the Details Page
	And User clicks Filter button under "Workflow" column
	And User clicks "(Blanks)" checkbox from string filter on the Details Page
	And User clicks "(Blanks)" checkbox from string filter on the Details Page
	Then "(Blanks)" checkbox is checked on the Details Page