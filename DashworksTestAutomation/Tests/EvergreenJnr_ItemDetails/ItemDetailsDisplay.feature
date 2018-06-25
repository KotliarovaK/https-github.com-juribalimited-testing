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
	And User click content from "Email Address" column
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
	And Group Icon for Group Details page is displayed

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	And User have opened Column Settings for "<ColumnName>" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "<CheckboxName>" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
	| ColumnName      |
	| <NewColumnName> |
	And There are no errors in the browser console

Examples: 
	| PageName     | SearchTerm                                              | ItemName      | TabName      | ColumnName  | CheckboxName        | NewColumnName       |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application | Key                 | Key                 |
	| Users        | svc_dashworks                                           | Username      | Groups       | Group       | Key                 | Key                 |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Projects     | Project     | Object ID           | Object ID           |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Projects     | Project     | Object Key          | Object Key          |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Domain      | Key                 | Key                 |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Domain      | Evergreen Object ID | Evergreen Object ID |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumns
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	And User closes "<ExpandedSectionName>" section on the Details Page
	And User opens "<SectionName>" section on the Details Page
	And User have opened Column Settings for "<ColumnName>" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "<CheckboxName>" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| PageName     | SearchTerm                                              | ItemName      | TabName      | ExpandedSectionName | SectionName         | ColumnName    | CheckboxName         | NewColumnName        |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Application Detail  | Application   | Application Key      | Application Key      |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Application Detail  | Application   | Advertisement Key    | Advertisement Key    |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Application Detail  | Application   | Group Key            | Group Key            |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Application Detail  | Application   | Collection Key       | Collection Key       |
	#| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Application Detail  | Application   | User Key             | User Key             |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Advertisements      | Application   | Key                  | Key                  |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Advertisements      | Application   | Application Key      | Application Key      |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Advertisements      | Application   | Site Key             | Site Key             |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Advertisements      | Application   | Collection Key       | Collection Key       |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Advertisements      | Application   | Program Key          | Program Key          |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Collections         | Collection    | Key                  | Key                  |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application Summary | Collections         | Collection    | Site Key             | Site Key             |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Application         | Advertisements      | Advertisement | Advertisement Key    | Advertisement Key    |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Application         | Advertisements      | Advertisement | Collection Key       | Collection Key       |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Application         | Programs            | Program       | Program Key          | Program Key          |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Users               | Devices             | Device        | Computer Key         | Computer Key         |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Users               | Devices             | Device        | Owner Object Key     | Owner Object Key     |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Users               | Groups              | Domain        | Key                  | Key                  |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Users               | Mailbox Permissions | Domain        | Key                  | Key                  |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Users               | Mailbox Permissions | Domain        | Via Group Object Key | Via Group Object Key |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Users               | Mailbox Permissions | Domain        | Access Category Key  | Access Category Key  |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsToTheTable
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	And User closes "<ExpandedSectionName>" section on the Details Page
	And User opens "<SectionName>" section on the Details Page
	And User have opened Column Settings for "<ColumnName>" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Device" checkbox on the Column Settings panel
	And User select "Installed" checkbox on the Column Settings panel
	And User select "<CheckboxName>" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| PageName     | SearchTerm                                              | ItemName      | TabName      | ExpandedSectionName | SectionName         | ColumnName    | CheckboxName         | NewColumnName        |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Users               | Devices             | Device        | User Key             | User Key             |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Users               | Devices             | Device        | Advertisement Key    | Advertisement Key    |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Users               | Devices             | Device        | Collection Key       | Collection Key       |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Users               | Devices             | Device        | Program Key          | Program Key          |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12053 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click content from "<ItemName>" column
	And User navigates to the "<TabName>" tab
	When User opens "<SectionName>" section on the Details Page
	And User have opened Column Settings for "<ColumnName>" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "<CheckboxName>" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
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
	And User click content from "Username" column
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11393 @DAS12765
Scenario: EvergreenJnr_DevicesLists_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTheDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Projects" tab
	And User opens "Device Projects" section on the Details Page
	And User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Key" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Key        |
	And ColumnName is displayed in following order on the Details page:
	| ColumnName   |
	| Project      |
	| Project Type |
	| Bucket       |
	| Request Type |
	| Workflow     |
	| Category     |
	| Status       |
	| Date         |
	| Readiness    |
	| Key          |
	And Checkboxes are checked on the Column Settings panel for "Key" Column Settings panel:
	| Checkbox     |
	| Key          |
	| Project      |
	| Project Type |
	| Bucket       |
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
	And following columns added to the table:
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
	When User closes "Application Summary" section on the Details Page
	And User opens "Application Detail" section on the Details Page
	Then "Manufacturer" column is not displayed to the user
	And following columns added to the table:
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
	Then "<CountRows>" rows found label displays on Details Page
	And "Manufacturer" column is not displayed to the user
	And following columns added to the table:
	| ColumnName |
	| Vendor     |
	Then string filter is displayed for "Vendor" column on the Details Page

Examples:
	| PageName | SelectedName   | ColumnName | CountRows |
	| Devices  | 001BAQXT6JWFPI | Hostname   | 2         |
	| Users    | ZZZ588323      | Username   | 1         |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11667
Scenario: EvergreenJnr_MailboxesLists_CheckThatNoConsoleErrorsWhenViewingMailboxDetails
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User click on 'Email Address' column header
	And User click on 'Email Address' column header
	And User click content from "Email Address" column
	Then Item content is displayed to the User
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11483
Scenario: EvergreenJnr_DevicesLists_CheckThatDataOfColumnsIsDisplayedInTheCustomFieldSection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "Benjamin S. Vaughn"
	And User click content from "Hostname" column
	And User navigates to the "Details" tab
	When User closes "Device" section on the Details Page
	And User opens "Custom Fields" section on the Details Page
	Then "1" rows found label displays on Details Page
	And Content is present in the column of the Details Page table
	| ColumnName |
	| Label      |
	| Value      |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11479
Scenario: EvergreenJnr_MailboxesLists_CheckThatLinksAndImageItemAreDisplayedInTheNameAndDisplayNameColumns
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00C8BC63E7424A6E862@bclabs.local"
	And User click content from "Email Address" column
	And User navigates to the "Users" tab
	When User closes "Users" section on the Details Page
	And User opens "Mailbox Permissions" section on the Details Page
	Then "100" rows found label displays on Details Page
	And Image item from "Name" column is displayed to the user
	And Links from "Name" column is displayed to the user on the Details Page
	And Links from "Display Name" column is displayed to the user on the Details Page

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11983 @DAS11926
Scenario Outline: EvergreenJnr_AllLists_CheckThatRowsInTheTableAreEmptyIfTheDataIsUnknown
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "<TabName>" tab
	And User closes "<ClosesSectionName>" section on the Details Page
	And User opens "<OpensSectionName>" section on the Details Page
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
	When User perform search by "<SearchTerm>"
	When User click content from "<ColumnName>" column
	And User navigates to the "<TabName>" tab
	And User have opened Column Settings for "<SelectedColumn>" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	When  User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console

Examples:
	| PageName     | SearchTerm                                              | ColumnName    | TabName      | SelectedColumn |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application    |
	| Users        | svc_dashworks                                           | Username      | Groups       | Group          |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | MSI          | File Name      |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Username       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11628
Scenario: EvergreenJnr_DevicesLists_CheckThatTheFilterDropddownIsDisplayedFullyWhenTheFilterResultNotContainsValues
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" tab
	And User have opened Column Settings for "Installed" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	Then Filter panel has standard size
	Then User select "False" checkbox from filter on the Details Page
	Then Filter panel has standard size

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11647
Scenario Outline: EvergreenJnr_DevicesLists_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "30BGMTLBM9PTW5"
	And User click content from "Hostname" column
	And User navigates to the "Applications" tab
	And User closes "Application Summary" section on the Details Page
	And User opens "<SectionName>" section on the Details Page
	Then "87" rows found label displays on Details Page
	When User have opened Column Settings for "Site" column in the Details Page table
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
	When User closes "Application Summary" section on the Details Page
	And User opens "Application Detail" section on the Details Page
	Then "14" rows found label displays on Details Page
	And section is loaded correctly
	When User closes "Application Detail" section on the Details Page
	And User opens "Advertisements" section on the Details Page
	Then "7" rows found label displays on Details Page
	And section is loaded correctly
	When User closes "Advertisements" section on the Details Page
	And User opens "Collections" section on the Details Page
	Then "7" rows found label displays on Details Page
	And section is loaded correctly

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12253
Scenario: EvergreenJnr_DevicesLists_CheckThePossibilityToRecheckingTheWorkflowColumnBlanksFilterAfterUncheckingIt
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Projects" tab
	And User opens "Device Projects" section on the Details Page
	And User clicks String Filter button for "Workflow" column
	And User clicks "(Blanks)" checkbox from String Filter on the Details Page
	And User clicks "(Blanks)" checkbox from String Filter on the Details Page
	Then "(Blanks)" checkbox is checked on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12283
Scenario: EvergreenJnr_DevicesLists_CheckThatOneUnknownFilterValueIsShownInGroupDetailsAndFilterWorkingCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User type "Denied RODC Password Replication Group" in Global Search Field
	Then User clicks on "Denied RODC Password Replication Group" search result
	When User navigates to the "Members" tab
	And User clicks String Filter button for "Enabled" column
	Then following Values are displayed in the filter on the Details Page
	| Values  |
	| True    |
	| False   |
	| Unknown |
	When User clicks "True" checkbox from String Filter on the Details Page
	Then Content is present in the table on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12245
Scenario: EvergreenJnr_MailboxesLists_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayed
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "julia.bell@juriba.com"
	And User click content from "Email Address" column
	When User navigates to the "Trend" tab
	Then Highcharts graphic is displayed on the Details Page
	And There are no errors in the browser console
	When User navigates to the "Details" tab
	Then There are no errors in the browser console
	When User navigates to the "Trend" tab
	Then There are no errors in the browser console
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12239
Scenario: EvergreenJnr_DevicesLists_CheckThatAllTextIsDisplayedAfterClearingFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" tab
	Then All text is displayed for "Compliance" column in the String Filter
	When  User clicks String Filter button for "Compliance" column
	And User clicks "Red" checkbox from String Filter on the Details Page
	Then All text is not displayed for "Compliance" column in the String Filter
	When User clicks Reset Filters button on the Details Page
	Then All text is displayed for "Compliance" column in the String Filter

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12088
Scenario: EvergreenJnr_MailboxesLists_CheckThatMailboxPermissionsAndFolderPermissionsDataAreDisplayedCorrectly
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "abraham.f.wong@dwlabs.local"
	And User click content from "Email Address" column
	And User navigates to the "Users" tab
	When User closes "Users" section on the Details Page
	And User opens "Mailbox Permissions" section on the Details Page
	Then Content is present in the table on the Details Page
	And "68" rows found label displays on Details Page
	When User closes "Mailbox Permissions" section on the Details Page
	And User opens "Folder Permissions" section on the Details Page
	Then Content is present in the table on the Details Page
	And "14" rows found label displays on Details Page 

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371
Scenario Outline: EvergreenJnr_AllLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectlyForCollapsedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	And User navigates to the "<TabName>" tab
	And User opens "<SectionName>" section on the Details Page
	Then "<CountRows>" rows found label displays on Details Page
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Request Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

Examples:
	| PageName | SearchTerm                                      | ColumnName | TabName  | SectionName           | CountRows |
	| Devices  | 001BAQXT6JWFPI                                  | Hostname   | Projects | Device Projects       | 4         |
	| Devices  | 001BAQXT6JWFPI                                  | Hostname   | Projects | Device Owner Projects | 4         |
	| Users    | Loya\, Dan.Employees.Birmingham.UK.bclabs.local | Username   | Projects | User Projects         | 1         |
	| Users    | Loya\, Dan.Employees.Birmingham.UK.bclabs.local | Username   | Projects | Mailbox Projects      | 1         |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371
Scenario Outline: EvergreenJnr_AllLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectlyForExpandedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	And User navigates to the "<TabName>" tab
	And User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Request Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

Examples:
	| PageName     | SearchTerm                                                 | ColumnName    | TabName  |
	| Applications | "WPF/E" (codename) Community Technology Preview (Feb 2007) | Application   | Projects |
	| Mailboxes    | 040698EE82354C17B60@bclabs.local                           | Email Address | Projects |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS12765
Scenario: EvergreenJnr_MailboxesLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectly
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "040698EE82354C17B60@bclabs.local"
	And User click content from "Email Address" column
	And User navigates to the "Projects" tab
	Then "Bucket" column is displayed to the user
	When User closes "Mailbox Projects" section on the Details Page
	And User opens "Mailbox User Projects" section on the Details Page
	Then "Bucket" column is displayed to the user
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column 
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Request Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12285
Scenario: EvergreenJnr_MailboxesLists_CheckThatCorrectMessageIsDisplayedForDevicesSectionOnTheDistributionTab
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACT Data Collection Packages"
	And User click content from "Application" column
	And User navigates to the "Distribution" tab
	And User closes "Users" section on the Details Page
	And User opens "Devices" section on the Details Page
	Then "No devices found for this application" message is displayed on the Details Page

@Evergreen @ALlLists @Devices @Users @Applications @DAS12491
Scenario Outline: EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbar
	When User clicks "<PageName>" on the left-hand menu
	And User perform search by "<SearchTerm>"
	Then "1" rows are displayed in the agGrid

Examples:
	| PageName     | SearchTerm                                |
	| Applications | ABBYY FineReader 8.0 Professional Edition |
	| Mailboxes    | 002B5DC7D4D34D5C895@bclabs.local          |
	| Devices      | 001BAQXT6JWFPI                            |
	| Users        | $231000-3AC04R8AR431                      |

@Evergreen @ALlLists @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12491
Scenario Outline: EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages
	When User clicks "<PageName>" on the left-hand menu
	And User perform search by "<SearchTerm>"
	And User click content from "<Column>" column
	And User navigates to the "<Tab>" tab
	Then "1" rows found label displays on Details Page

Examples:
	| PageName     | SearchTerm          | Column      | Tab       |
	| Applications | IEWatch 2.1         | Application | MSI       |
	| Users        | 01A921EFD05545818AA | Username    | Mailboxes |
	
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690
Scenario: EvergreenJnr_DevicesLists_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001PSUMZYOW581"
	And User click content from "Hostname" column
	And User navigates to the "Details" tab
	And User closes "Device" section on the Details Page
	And User opens "Device Owner" section on the Details Page
	And User clicks "Tricia G. Huang" link on the Details Page
	Then Details object page is displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690
Scenario: EvergreenJnr_MailboxesLists_CheckThatLinksInMailboxDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "Joel T. Hartman"
	And User click content from "Email Address" column
	And User closes "Mailbox" section on the Details Page
	And User opens "Mailbox Owner" section on the Details Page
	And User clicks "hartmajt" link on the Details Page
	Then Details object page is displayed to the user

@Evergreen @ALlLists @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12765
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketColumnIsDisplayedOnDetailsProjectsPages
	When User clicks "<PageName>" on the left-hand menu
	And User perform search by "<SearchTerm>"
	And User click content from "<Column>" column
	And User navigates to the "<Tab>" tab
	And User closes "<SectionClose>" section on the Details Page
	And User opens "<SectionOpen>" section on the Details Page
	Then "Bucket" column is displayed to the user

Examples:
	| PageName | SearchTerm     | Column   | Tab      | SectionClose      | SectionOpen           |
	| Devices  | 001BAQXT6JWFPI | Hostname | Projects | Evergreen Buckets | Device Owner Projects |
	| Users    | hurstbl        | Username | Projects | Evergreen Buckets | User Projects         |
	| Users    | hurstbl        | Username | Projects | Evergreen Buckets | Mailbox Projects      |
	| Users    | ZZZ588323      | Username | Projects | Evergreen Buckets | Device Projects       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12292
Scenario: EvergreenJnr_DevicesLists_CheckingThatInRangeOperatorWorkingCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User type "001PSUMZYOW581" in Global Search Field
	Then User clicks on "001PSUMZYOW581" search result
	When User navigates to the "Projects" tab
	And User opens "Device Projects" section on the Details Page
	And User have opened Column Settings for "Date" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	And User select In Range value with following date:
	| DateFrom | DateTo  |
	| 5222014  | 5202018 |
	Then "2" rows found label displays on Details Page