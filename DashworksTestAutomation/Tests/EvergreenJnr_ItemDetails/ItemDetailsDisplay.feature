@retry:1
Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11531 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThat404ErrorIsNotDisplayedOccurringWhenViewingMailboxDetailsWhereThereIsNoMailboxOwner
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "alex.cristea@juriba.com"
	And User click content from "Email Address" column
	Then User sees loaded tab "Mailbox" on the Details page
	When User navigates to the "Mailbox Owner" sub-menu on the Details page
	Then "No mailbox owner found for this mailbox" text is displayed for opened tab

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

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235 @DAS13409 @DAS13657 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ItemName>" column
	And User navigates to the "<MainTabName>" main-menu on the Details page
	And User navigates to the "<SubTabName>" sub-menu on the Details page
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
	| PageName     | SearchTerm                                              | ItemName      | MainTabName  | SubTabName        | ColumnName  | CheckboxName        | NewColumnName       |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Summary | Application | Key                 | Key                 |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Projects     | Projects          | Project     | Object ID           | Object ID           |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Projects     | Projects          | Project     | Object Key          | Object Key          |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Users             | Domain      | Key                 | Key                 |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Users             | Domain      | Evergreen Object ID | Evergreen Object ID |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235 @DAS12799 @DAS13657
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumns
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	When User click content from "<ItemName>" column
	And User navigates to the "<MainTabName>" main-menu on the Details page
	And User navigates to the "<SubTabName>" sub-menu on the Details page
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
	| PageName     | SearchTerm                                              | ItemName      | MainTabName  | SubTabName          | ColumnName    | CheckboxName         | NewColumnName        |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Detail    | Application   | Application Key      | Application Key      |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Detail    | Application   | Advertisement Key    | Advertisement Key    |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Detail    | Application   | Group Key            | Group Key            |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Detail    | Application   | Collection Key       | Collection Key       |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Key                  | Key                  |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Application Key      | Application Key      |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Site Key             | Site Key             |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Collection Key       | Collection Key       |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Program Key          | Program Key          |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Collections         | Collection    | Key                  | Key                  |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Collections         | Collection    | Site Key             | Site Key             |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Advertisements      | Advertisement | Advertisement Key    | Advertisement Key    |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Advertisements      | Advertisement | Collection Key       | Collection Key       |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Programs            | Program       | Program Key          | Program Key          |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Devices             | Device        | Computer Key         | Computer Key         |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Devices             | Device        | Owner Object Key     | Owner Object Key     |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Groups              | Domain        | Key                  | Key                  |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Mailbox Permissions | Domain        | Key                  | Key                  |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Mailbox Permissions | Domain        | Via Group Object Key | Via Group Object Key |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Mailbox Permissions | Domain        | Access Category Key  | Access Category Key  |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsToTheTable
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "Microsoft Office Visio 2000 Solutions - Custom Patterns"
	When User click content from "Application" column
	And User navigates to the "<MainTabName>" main-menu on the Details page
	And User navigates to the "<SubTabName>" sub-menu on the Details page
	And User have opened Column Settings for "Device" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Device" checkbox on the Column Settings panel
	And User select "Installed" checkbox on the Column Settings panel
	And User select "Owner Display Name" checkbox on the Column Settings panel
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
	| MainTabName  | SubTabName | CheckboxName      | NewColumnName     |
	| Distribution | Devices    | User Key          | User Key          |
	| Distribution | Devices    | Advertisement Key | Advertisement Key |
	| Distribution | Devices    | Collection Key    | Collection Key    |
	| Distribution | Devices    | Program Key       | Program Key       |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12053 @DAS12235 @DAS13004 @DAS13657
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSections
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "<MainTabName>" main-menu on the Details page
	And User navigates to the "<SubTabName>" sub-menu on the Details page
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
	| MainTabName | SubTabName             | ColumnName  | CheckboxName     | NewColumnName    |
	| Compliance  | Application Issues     | Application | PackageKey       | PackageKey       |
	| Projects    | Projects Summary       | Project     | Object ID        | Object ID        |
	| Projects    | Projects Summary       | Project     | Key              | Key              |
	| Projects    | Owner Projects Summary | Username    | Object Key       | Object Key       |
	| Projects    | Owner Projects Summary | Username    | Key              | Key              |
	| Projects    | Owner Projects Summary | Username    | Request Type Key | Request Type Key |
	| Projects    | Owner Projects Summary | Username    | Category Key     | Category Key     |
	| Projects    | Owner Projects Summary | Username    | Status Key       | Status Key       |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11053 @DAS14923
Scenario: EvergreenJnr_UsersList_CheckThatTheTableColumnsAreNotDuplicatedOnTheDetailsPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "Administrator.Users.dwlabs.local"
	And User click content from "Username" column
	And User navigates to the "Devices" main-menu on the Details page
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11393 @DAS12765 @DAS13657
Scenario: EvergreenJnr_DevicesList_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTheDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "01WNOSNMP5QLXC"
	And User click content from "Hostname" column
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Projects Summary" sub-menu on the Details page
	And User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Key" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Key        |
	And ColumnName is displayed in following order on the Details page:
	| ColumnName   |
	| Key          |
	| Project      |
	| Project Type |
	| Bucket       |
	| Ring         |
	| Request Type |
	| Workflow     |
	| Category     |
	| Status       |
	| Date         |
	| Slot         |
	| Readiness    |
	And Checkboxes are checked on the Column Settings panel for "Key" Column Settings panel:
	| Checkbox     |
	| Key          |
	| Project      |
	| Project Type |
	| Bucket       |
	| Ring         |
	| Request Type |
	| Workflow     |
	| Category     |
	| Status       |
	| Date         |
	| Slot         |
	| Readiness    |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091 @DAS14923 @DAS16564
Scenario: EvergreenJnr_DevicesList_CheckRenamedColumnForApplicationTabOnTheDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	And User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16564
Scenario: EvergreenJnr_UsersList_CheckRenamedColumnForApplicationTabOnTheDetailsPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "ZZZ588323"
	And User click content from "Username" column
	And User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user
	When User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Manufacturer" column is not displayed to the user
	Then "Vendor" column is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091 @DAS14923 @DAS16121
Scenario Outline: EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "Compliance" main-menu on the Details page
	And User navigates to the "Application Summary" sub-menu on the Details page
	Then Name of colors are displayed in following order on the Details Page:
	| ColumnHeader |
	| RED          |
	| AMBER        |
	| GREEN        |
	| UNKNOWN      |
	| N/A          |
	When User navigates to the "Application Issues" sub-menu on the Details page
	Then "<CountRows>" rows found label displays on Details Page
	And "Manufacturer" column is not displayed to the user
	And following columns added to the table:
	| ColumnName |
	| Vendor     |
	Then string filter is displayed for "Vendor" column on the Details Page

Examples:
	| PageName | SelectedName   | ColumnName | CountRows |
	| Devices  | 001BAQXT6JWFPI | Hostname   | 2         |
	| Users    | EKS951231      | Username   | 4         |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11667 @DAS12321 @DAS11921
Scenario: EvergreenJnr_MailboxesList_CheckThatNoConsoleErrorsWhenViewingMailboxDetails
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User click on 'Email Address' column header
	And User click on 'Email Address' column header
	And User click content from "Email Address" column
	Then User sees loaded tab "Mailbox" on the Details page
	Then Item content is displayed to the User
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11483
Scenario: EvergreenJnr_DevicesList_CheckThatDataOfColumnsIsDisplayedInTheCustomFieldSection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "Benjamin S. Vaughn"
	And User click content from "Hostname" column
	And User navigates to the "Details" main-menu on the Details page
	And User navigates to the "Custom Fields" sub-menu on the Details page
	Then "1" rows found label displays on Details Page
	And Content is present in the column of the Details Page table
	| ColumnName |
	| Label      |
	| Value      |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11479 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatLinksAndImageItemAreDisplayedInTheNameAndDisplayNameColumns
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00C8BC63E7424A6E862@bclabs.local"
	And User click content from "Email Address" column
	And User navigates to the "Users" main-menu on the Details page
	And User navigates to the "Mailbox Permissions" sub-menu on the Details page
	Then "100" rows found label displays on Details Page
	And Image item from "Name" column is displayed to the user
	And Links from "Name" column is displayed to the user on the Details Page
	And Links from "Display Name" column is displayed to the user on the Details Page

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11983 @DAS11926 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatRowsInTheTableAreEmptyIfTheDataIsUnknown
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "<MainTabName>" main-menu on the Details page
	And User navigates to the "<SubMenuName>" sub-menu on the Details page
	Then Empty rows are displayed if the data is unknown

Examples:
	| PageName  | SelectedName                     | ColumnName    | MainTabName | SubMenuName             |
	| Devices   | 00K4CEEQ737BA4L                  | Hostname      | Details     | Department and Location |
	| Users     | $231000-3AC04R8AR431             | Username      | Details     | Department and Location |
	| Mailboxes | aaron.u.flores@dwlabs.local      | Email Address | Details     | Department and Location |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address | Details     | Mailbox                 |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11762 @DAS12235 @DAS13813 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	When User click content from "<ColumnName>" column
	And User navigates to the "<TabName>" main-menu on the Details page
	And User have opened Column Settings for "<SelectedColumn>" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	When  User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console

Examples:
	| PageName     | SearchTerm                                              | ColumnName    | TabName      | SelectedColumn |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application    |
	#| Users        | svc_dashworks                                           | Username      | Groups       | Group          |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | MSI          | File Name      |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Username       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11628
Scenario: EvergreenJnr_DevicesList_CheckThatTheFilterDropddownIsDisplayedFullyWhenTheFilterResultNotContainsValues
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" main-menu on the Details page
	And User have opened Column Settings for "Installed" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	Then Filter panel has standard size
	Then User select "False" checkbox from filter on the Details Page
	Then Filter panel has standard size

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11647
Scenario Outline: EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "30BGMTLBM9PTW5"
	And User click content from "Hostname" column
	And User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "<SubMenuName>" sub-menu on the Details page
	Then "87" rows found label displays on Details Page
	When User have opened Column Settings for "Site" column in the Details Page table
	And User have select "Autosize This column" option from column settings on the Details Page
	Then Site column has standard size

Examples:
	| SubMenuName    |
	| Advertisements |
	| Collections    |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12043
Scenario: EvergreenJnr_DevicesList_CheckThatNoErrorsAreDisplayedWhenOpenedDeviceDetailsThatDoesNotContainOwnerInformation
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "06Y8HSNCPVHENV"
	And User click content from "Hostname" column
	When User navigates to the "Device Owner" sub-menu on the Details page
	Then "No device owner information found for this device" message is displayed on the Details Page
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12071
Scenario: EvergreenJnr_DevicesList_CheckThatOpenedSectionIsDisplayedCorrectlyOnTheDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" content is displayed in "Application" column
	And "Advert - A0129C4E" content is displayed in "Advertisement" column
	And "14" rows found label displays on Details Page
	And table content is present
	Then User sees loaded tab "Evergreen Detail" on the Details page
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then "Advert - A0121431" content is displayed in "Advertisement" column
	And "Hewlett-Packard" content is displayed in "Vendor" column
	And "7" rows found label displays on Details Page
	And table content is present
	Then User sees loaded tab "Advertisements" on the Details page
	When User navigates to the "Collections" sub-menu on the Details page
	Then "Collection A01131CA" content is displayed in "Collection" column
	And "A01 SMS (Spoof)" content is displayed in "Source" column
	And "7" rows found label displays on Details Page
	And table content is present
	And User sees loaded tab "Collections" on the Details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12253
Scenario: EvergreenJnr_DevicesList_CheckThePossibilityToRecheckingTheWorkflowColumnBlanksFilterAfterUncheckingIt
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects Summary" sub-menu on the Details page
	And User clicks String Filter button for "Workflow" column
	When User selects "(Blanks)" checkbox from String Filter on the Details Page
	And User clicks String Filter button for "Workflow" column
	When User selects "(Blanks)" checkbox from String Filter on the Details Page
	And User clicks String Filter button for "Workflow" column
	Then "(Blanks)" checkbox is checked on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14941 @DAS12963
Scenario: EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSetting
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Projects" main-menu on the Details page
	And User clicks content of Evergreen Ring in Project Summary section on the Details Page
	And User clicks New Ring ddl in popup of Project Summary section on the Details Page
	Then Rings ddl contains data on Project Summary section of the Details Page
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12283
Scenario: EvergreenJnr_DevicesList_CheckThatOneUnknownFilterValueIsShownInGroupDetailsAndFilterWorkingCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User type "Denied RODC Password Replication Group" in Global Search Field
	Then User clicks on "Denied RODC Password Replication Group" search result
	When User navigates to the "Members" main-menu on the Details page
	And User clicks String Filter button for "Enabled" column
	Then following Values are displayed in the filter on the Details Page
	| Values  |
	| True    |
	| False   |
	| Unknown |
	When User clicks "True" checkbox from String Filter on the Details Page
	Then Content is present in the table on the Details Page
	When User clicks Reset Filters button on the Details Page
	And User enters "wheelern" text in the Search field for "Username" column on the Details Page
	Then Rows counter shows "1" of "7" rows
	When User clicks Reset Filters button on the Details Page
	And User enters "Administrator" text in the Search field for "Display Name" column on the Details Page
	Then Rows counter shows "1" of "7" rows
	When User clicks Reset Filters button on the Details Page
	And User clicks String Filter button for "Domain" column
	When User selects "DWLABS" checkbox from String Filter on the Details Page
	Then Rows counter shows "0" of "7" rows

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12245 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayed
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "julia.bell@juriba.com"
	And User click content from "Email Address" column
	When User navigates to the "Trend" main-menu on the Details page
	Then Highcharts graphic is displayed on the Details Page
	And There are no errors in the browser console
	When User navigates to the "Details" main-menu on the Details page
	Then There are no errors in the browser console
	When User navigates to the "Trend" main-menu on the Details page
	Then There are no errors in the browser console
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12239
Scenario: EvergreenJnr_DevicesList_CheckThatAllTextIsDisplayedAfterClearingFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001PSUMZYOW581"
	When User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	Then All text is displayed for "Compliance" column in the String Filter
	When User clicks String Filter button for "Compliance" column
	And User clicks "Red" checkbox from String Filter on the Details Page
	Then All text is not displayed for "Compliance" column in the String Filter
	When User clicks Reset Filters button on the Details Page
	Then All text is displayed for "Compliance" column in the String Filter
	When User enters "ea" text in the Search field for "Application" column on the Details Page
	Then Rows counter contains "3" found row of all rows
	When User clicks Reset Filters button on the Details Page
	When User enters "3.0.0" text in the Search field for "Version" column on the Details Page
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Details Page
	And User clicks String Filter button for "Used" column
	When User clicks "Unknown" checkbox from String Filter on the Details Page
	Then Rows counter contains "0" found row of all rows
	When User clicks Reset Filters button on the Details Page
	And User clicks String Filter button for "Entitled" column
	When User clicks "True" checkbox from String Filter on the Details Page
	Then Rows counter contains "0" found row of all rows
	When User clicks Reset Filters button on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12088 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatMailboxPermissionsAndFolderPermissionsDataAreDisplayedCorrectly
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "abraham.f.wong@dwlabs.local"
	And User click content from "Email Address" column
	When User navigates to the "Users" main-menu on the Details page
	When User navigates to the "Mailbox Permissions" sub-menu on the Details page
	Then Content is present in the table on the Details Page
	And "68" rows found label displays on Details Page
	When User navigates to the "Folder Permissions" sub-menu on the Details page
	Then Content is present in the table on the Details Page
	And "14" rows found label displays on Details Page 

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS13409
Scenario Outline: EvergreenJnr_AllLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectlyForCollapsedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<MainTabName>" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	Then "<CountRows>" rows found label displays on Details Page
	When User clicks String Filter button for "Project" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Workflow" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Status" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Request Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Project Type" checkbox on the Column Settings panel
	And User select "Request Type" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks String Filter button for "Readiness" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

Examples:
	| PageName | SearchTerm                                      | ColumnName | MainTabName | SubTabName              | CountRows |
	| Users    | Loya\, Dan.Employees.Birmingham.UK.bclabs.local | Username   | Projects    | Mailbox Project Summary | 1         |
	| Devices  | 001BAQXT6JWFPI                                  | Hostname   | Projects    | Projects Summary        | 8         |
	| Devices  | 001BAQXT6JWFPI                                  | Hostname   | Projects    | Owner Projects Summary  | 7         |
	| Users    | Loya\, Dan.Employees.Birmingham.UK.bclabs.local | Username   | Projects    | User Projects           | 2         |
	

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS13409
Scenario Outline: EvergreenJnr_AllLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectlyForExpandedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<MainTabName>" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Request Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

Examples:
	| PageName     | SearchTerm                              | ColumnName    | MainTabName | SubTabName       |
	| Applications | 0036 - Microsoft Access 97 SR-2 English | Application   | Projects    | Projects         |
	| Mailboxes    | 040698EE82354C17B60@bclabs.local        | Email Address | Projects    | Mailbox Projects |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS12765 @DAS12321 @DAS13409
Scenario: EvergreenJnr_MailboxesList_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectly
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "040698EE82354C17B60@bclabs.local"
	And User click content from "Email Address" column
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Mailbox Projects" sub-menu on the Details page
	Then "Bucket" column is displayed to the user
	When User navigates to the "Mailbox User Projects" sub-menu on the Details page
	Then "Bucket" column is displayed to the user
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column 
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Request Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12285
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectMessageIsDisplayedForDevicesSectionOnTheDistributionTab
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACT Data Collection Packages"
	And User click content from "Application" column
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Devices" sub-menu on the Details page
	Then "No devices found for this application" message is displayed on the Details Page

@Evergreen @ALlLists @Devices @Users @Applications @DAS12491
Scenario Outline: EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbar
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	Then "1" rows are displayed in the agGrid

Examples:
	| PageName     | SearchTerm                                |
	| Applications | ABBYY FineReader 8.0 Professional Edition |
	| Mailboxes    | 002B5DC7D4D34D5C895@bclabs.local          |
	| Devices      | 001BAQXT6JWFPI                            |
	| Users        | $231000-3AC04R8AR431                      |

@Evergreen @ALlLists @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12491 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<Column>" column
	When User navigates to the "<MainTab>" main-menu on the Details page
	When User navigates to the "<SubTab>" sub-menu on the Details page
	Then "1" rows found label displays on Details Page

Examples:
	| PageName     | SearchTerm          | Column      | MainTab   | SubTab    |
	| Applications | IEWatch 2.1         | Application | MSI       | MSIFiles  |
	| Users        | 01A921EFD05545818AA | Username    | Mailboxes | Mailboxes |
	
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690 @DAS14923
Scenario: EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001PSUMZYOW581"
	And User click content from "Hostname" column
	When User navigates to the "Details" main-menu on the Details page
	When User navigates to the "Device Owner" sub-menu on the Details page
	And User clicks "Tricia G. Huang" link on the Details Page
	Then Details page for "LFA418191 (Tricia G. Huang)" item is displayed to the user

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<MainTabName>" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User selects "<KeyToBeSelected>" text from key value grid on the Details Page
	Then "<KeyToBeSelected>" text selected from key value grid on the Details Page
	When User selects "<ValueToBeSelected>" text from key value grid on the Details Page
	Then "<ValueToBeSelected>" text selected from key value grid on the Details Page

Examples:
	| PageName     | SearchTerm                       | ColumnName    | MainTabName   | SubTabName    | KeyToBeSelected | ValueToBeSelected   |
	| Devices      | 02C80G8RFTPA9E                   | Hostname      | Specification | Specification | Manufacturer    | FES0798481167       |
	| Devices      | 05PFM2OWVCSCZ1                   | Hostname      | Details       | Device        | Hostname        | 05PFM2OWVCSCZ1      |
	| Users        | 03714167684E45F7A8F              | Username      | Details       | User          | Username        | 03714167684E45F7A8F |
	| Applications | Adobe Acrobat Reader 5.0         | Application   | Details       | Application   | Vendor          | Adobe               |
	| Mailboxes    | 06D7AE4F161F4A3AA7F@bclabs.local | Email Address | Details       | Mailbox       | Alias           | 06D7AE4F161F4A3AA7F |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @archived
Scenario: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnGroupDetailsPage
	When User type "NL00G001" in Global Search Field
	Then User clicks on "NL00G001" search result
	When User selects "Description" text from key value grid on the Details Page
	Then "Description" text selected from key value grid on the Details Page
	When User selects "Unknown" text from key value grid on the Details Page
	Then "Unknown" text selected from key value grid on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690 @DAS12321 @DAS14923
Scenario: EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "Joel T. Hartman"
	And User click content from "Email Address" column
	When User navigates to the "Details" main-menu on the Details page
	When User navigates to the "Mailbox Owner" sub-menu on the Details page
	And User clicks "hartmajt" link on the Details Page
	Then Details object page is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13849
Scenario: EvergreenJnr_DevicesList_CheckThatNoDuplicatedRowsDisplayInDeviceProjectsGridOnProjectsTabOfParticularDevice
	When User clicks "Devices" on the left-hand menu
	And User perform search by "00BDM1JUR8IF419"
	And User click content from "Hostname" column
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects Summary" sub-menu on the Details page
	Then All data is unique in the 'Project' column

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12765 @DAS12860
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketColumnIsDisplayedOnDetailsProjectsPages
	When User clicks "<PageName>" on the left-hand menu
	And User perform search by "<SearchTerm>"
	And User click content from "<Column>" column
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	Then "Bucket" column is displayed to the user

Examples:
	| PageName  | SearchTerm                       | Column        | SubTabName              |
	| Devices   | 001BAQXT6JWFPI                   | Hostname      | Owner Projects Summary  |
	| Users     | hurstbl                          | Username      | User Projects           |
	| Users     | hurstbl                          | Username      | Mailbox Project Summary |
	| Users     | ZZZ588323                        | Username      | Device Project Summary  |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address | Mailbox User Projects   |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12292
Scenario: EvergreenJnr_DevicesList_CheckingThatInRangeOperatorWorkingCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User type "001PSUMZYOW581" in Global Search Field
	Then User clicks on "001PSUMZYOW581" search result
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects Summary" sub-menu on the Details page
	And User have opened Column Settings for "Date" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	And User select In Range value with following date:
	| DateFrom    | DateTo      |
	| 22 May 2014 | 22 May 2018 |
	Then Rows counter contains "2" found row of all rows

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13335 @DAS14923 @DAS12963 @DAS16233 @Delete_Newly_Created_Bucket
Scenario: EvergreenJnr_DevicesList_CheckUpdatingDeviceBucketViaRelatedUserProjectSummaryWhenMailboxesSectionIsExpanded
	When User clicks Admin on the left-hand menu
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	And User clicks the "CREATE EVERGREEN BUCKET" Action button
	And User enters "AutoTestBucket_DAS_13335" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	And User clicks "Users" on the left-hand menu
	And User perform search by "AAG081456"
	And User click content from "Username" column
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Bucket field
	And User clicks on "New Bucket" dropdown
	And User select "AutoTestBucket_DAS_13335" value on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Devices"
	And User opens "Related Mailboxes" section on the Details Page
	And User clicks the "UPDATE" Action button
	And User clicks "Devices" on the left-hand menu
	And User perform search by "I55HL8MSBYK0VG"
	And User click content from "Hostname" column
	When User navigates to the "Projects" main-menu on the Details page
	Then User sees "AutoTestBucket_DAS_13335" Evergreen Bucket in Project Summary section on the Details Page
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12386 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatHyperlinkForKeyColumnsIsRedirectedToTheRelevantDetailsPage
	When User add following columns using URL to the "<PageName>" page:
	| ColumnName |
	| <Column>   |
	Then Content is present in the newly added column
	| ColumnName |
	| <Column>   |
	When User perform search by "<ItemName>"
	When User click content from "<Column>" column
	Then Details page for "<ItemName>" item is displayed to the user
	And URL is "<URLpart>"

Examples:
	| PageName     | Column          | ItemName                         | URLpart                                         |
	| Devices      | Device Key      | 00KLL9S8NRF0X6                   | evergreen/#/device/8892/details/device          |
	| Users        | User Key        | 0072B088173449E3A93              | evergreen/#/user/85167/details/user             |
	| Applications | Application Key | ACDSee for Windows 95            | evergreen/#/application/312/details/application |
	| Mailboxes    | Mailbox Key     | 01BC4B0500344065B61@bclabs.local | evergreen/#/mailbox/45374/details/mailbox       |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12805
Scenario: EvergreenJnr_ApplicationsList_CheckThatUsersAndDevicesDistributionListsDoNotIncludeUnknownValues
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "Microsoft DirectX 5 DDK"
	And User click content from "Application" column
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Users" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	And User closes Checkbox filter for "Used" column
	And User have opened Column Settings for "Username" column in the Details Page table
	And User have select "Sort descending" option from column settings on the Details Page
	Then Content is present in the table on the Details Page
	And Rows do not have unknown values
	When User navigates to the "Devices" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	And User closes Checkbox filter for "Used" column
	And User have opened Column Settings for "Device" column in the Details Page table
	And User have select "Sort descending" option from column settings on the Details Page
	Then Content is present in the table on the Details Page
	And Rows do not have unknown values

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12883 @DAS13208 @DAS13478 @DAS13971 @DAS13892 @DAS16824 @Delete_Newly_Created_Bucket
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenBucketFieldInTheProjectsResumeWorksCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters "Bucket12883" in the "Bucket Name" field
	And User selects "My Team" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	#============================================================================#
		#go to Devices page
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "01ERDGD48UDQKE"
	And User click content from "Hostname" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	When User opens "Related Users" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Users"
	When User clicks the "UPDATE" Action button
	Then "Bucket12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "00DBB114BE1B41B0A38"
	And User click content from "Username" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Bucket12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console
	#============================================================================#
	#unavailable for 'nova' now
		#go to Mailboxes page
	#When User clicks "Mailboxes" on the left-hand menu
	#Then "Mailboxes" list should be displayed to the user
	#When User perform search by "0845467C65E5438D83E@bclabs.local"
	#And User click content from "Email Address" column
	#Then Details object page is displayed to the user
	#When User navigates to the "Projects" main-menu on the Details page
	#When User clicks on "Unassigned" link for Evergreen Bucket field
	#Then popup changes window opened
	#When User opens "Related Users" section on the Details Page
	#When User selects all rows on the grid on the Details Page for "Related Users"
	#Then User clicks on "New Bucket" dropdown
	#When User select "Bucket12883" value on the Details Page
	#When User clicks the "UPDATE" Action button
	#Then "Bucket12883" link is displayed on the Details Page
	#Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	#When User clicks on "Bucket12883" link on the Details Page
	#Then popup changes window opened
	#When User selects all rows on the grid on the Details Page for "Related Users"
	#Then User clicks on "New Bucket" dropdown
	#When User select "[Unassigned]" value on the Details Page
	#When User clicks the "UPDATE" Action button
	#Then "Unassigned" link is displayed on the Details Page
	#Then There are no errors in the browser console
	
@Evergreen @AllLists @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13208 @DAS13971 @DAS13892 @DAS13892 @Delete_Newly_Created_Capacity_Unit
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenCapacityUnitFieldInTheProjectsResumeWorksCorrectly
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault |
	| CapacityUnit12883 | Devices     | false     |
	#============================================================================#
		#go to Devices page
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "ZYKEGN8CRK0NR4"
	And User click content from "Hostname" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Evergreen Capacity Unit 3" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	When User clicks the "UPDATE" Action button
    When User clicks refresh button in the browser after waiting
	When User navigates to the "Projects" main-menu on the Details page
	Then "CapacityUnit12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "Evergreen Capacity Unit 3" value on the Details Page
	When User clicks the "UPDATE" Action button
    When User clicks refresh button in the browser after waiting
	When User navigates to the "Projects" main-menu on the Details page
	Then "Evergreen Capacity Unit 3" link is displayed on the Details Page
	Then There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "00DBB114BE1B41B0A38"
	And User click content from "Username" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	When User clicks the "UPDATE" Action button
    When User clicks refresh button in the browser after waiting
	When User navigates to the "Projects" main-menu on the Details page
	Then "CapacityUnit12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	When User clicks refresh button in the browser after waiting
	When User navigates to the "Projects" main-menu on the Details page
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "0845467C65E5438D83E@bclabs.local"
	And User click content from "Email Address" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	When User clicks the "UPDATE" Action button
	When User clicks refresh button in the browser after waiting
	When User navigates to the "Projects" main-menu on the Details page
	Then "CapacityUnit12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	When User clicks refresh button in the browser after waiting
	When User navigates to the "Projects" main-menu on the Details page
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console

@Evergreen @Applications @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13180
Scenario: EvergreenJnr_ApplicationsList_ChecksThatDevicesUsersUsedQuantityMatchEachOtherOnApplicationTabAndApplicationDistributionTab
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Device Count (Used) |
	| User Count (Used)   |
	Then ColumnName is added to the list
	| ColumnName          |
	| Device Count (Used) |
	| User Count (Used)   |
	When User perform search by "Microsoft DirectX 5 DDK"
	Then "99" content is displayed in "Device Count (Used)" column
	And "98" content is displayed in "User Count (Used)" column
	When User click content from "Application" column
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Users" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	And User closes Checkbox filter for "Used" column
	Then Rows counter shows "98" of "194" rows
	When User navigates to the "Devices" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	Then Rows counter shows "99" of "173" rows

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13679 @DAS14216 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectSummarySectionIsDisplayedSuccessfully
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User perform search by "<SearchText>"
	When User clicks content from "<ColumnName>" column
	Then Details page for "<PegeItemName>" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Evergreen Details" sub-menu on the Details page
	Then field with "Project Count" text is displayed in expanded tab on the Details Page
	Then field with "Evergreen Bucket" text is displayed in expanded tab on the Details Page
	Then field with "Evergreen Capacity Unit" text is displayed in expanded tab on the Details Page
	Then field with "Evergreen Ring" text is displayed in expanded tab on the Details Page
	And There are no errors in the browser console

Examples:
	| ListName  | SearchText                       | ColumnName    | PegeItemName                     |
	| Devices   | 00HA7MKAVVFDAV                   | Hostname      | 00HA7MKAVVFDAV                   |
	| Users     | 0072B088173449E3A93              | Username      | 0072B088173449E3A93              |
	| Mailboxes | 00C8BC63E7424A6E862@bclabs.local | Email Address | 00C8BC63E7424A6E862@bclabs.local |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14431
Scenario: EvergreenJnr_ApplicationsList_ChecksThatNoConsoleErrorDisplayedAndMenuPositionStaysTheSameWhenSettingDeliveryDate
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by ""WPF/E" (codename) Community Technology Preview (Feb 2007)"
	And User click content from "Application" column
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects" sub-menu on the Details page
	And User have opened Column Settings for "Delivery Date" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	And User remembers the date input position
	And User select criteria with following date:
	| Criteria  | Date     |
	| Not Equal | 23032018 |
	Then User checks that date input has same position
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyCellWorksInItemDetails
	When User clicks "<PageName>" on the left-hand menu
	And User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<MainTabName>" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy cell' option in context menu
	Then Next data '<TargetCell>' is copied

Examples:
	| PageName     | SearchTerm                                              | ColumnName    | MainTabName      | SubTabName        | SelectedColumn | TargetCell    |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications     | Evergreen Summary | Application    | Access 95     |
	| Users        | svc_dashworks                                           | Username      | Active Directory | Groups            | Group          | Domain Admins |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | MSI              | MSIFiles          | File Name      | setup_x86.msi |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users            | Users             | Username       | floresau      |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968 @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyRowWorksInItemDetails
	When User clicks "<PageName>" on the left-hand menu
	And User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<TabName>" main-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy cell' option in context menu
	Then Next data '<ExpectedData>' is copied
	
Examples:
	| PageName     | SearchTerm                                              | ColumnName    | TabName      | SelectedColumn | TargetCell    | ExpectedData          |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application    | Access 95     | !should be scpecified |
	| Users        | svc_dashworks                                           | Username      | Groups       | Group          | Domain Admins | !should be scpecified |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | MSI          | File Name      | setup_x86.msi | !should be scpecified |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Username       | floresau      | !should be scpecified |

@Evergreen @UsersLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15522
Scenario: EvergreenJnr_UsersList_ChecksThatNoErrorsAreDisplayedAfterClickingThroughTheProjectNameFromObjectDetails
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "TON2490708"
	And User click content from "Username" column
	Then Details page for "TON2490708" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Device Project Summary" sub-menu on the Details page
	When User clicks content from "Project" column
	Then "Project Object" page is displayed to the user

@Evergreen @DevicesLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14973
Scenario: EvergreenJnr_DevicesList_CheckDeviceTabUIOnTheDeviceDetails
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Details" main-menu on the Details page
	Then "Key" title matches the "9141" value
	Then following content is displayed on the Details Page
	| Title                     | Value           |
	| Hostname                  | 001BAQXT6JWFPI  |
	| Source                    | A01 SMS (Spoof) |
	| Source Type               | SMS/SCCM 2007   |
	| Inventory Site            | A01             |
	Then empty value is displayed for "Dashworks First Seen Date" field on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15889 @DAS16378
Scenario: EvergreenJnr_DevicesList_CheckThatCommonNameFieldIsDisplayedInTheComputerAdObjectSection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00OMQQXWA1DRI6"
	And User click content from "Hostname" column
	Then Details page for "00OMQQXWA1DRI6" item is displayed to the user
	When User navigates to the "Active Directory" main-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields                          |
	| Directory Type                  |
	| Domain                          |
	| Fully Distinguished Object Name |
	| Common Name                     |
	| Display Name                    |
	| Description                     |
	Then "00OMQQXWA1DRI6" content is displayed in "Common Name" field on Item Details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16009
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsSummarySection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |
	| Compliance  |
	| Installed   |
	| Used        |
	| Entitled    |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15951
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsDetailSection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Application" column is displayed to the user
	When User have opened Column Settings for "Vendor" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Application" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName           |
	| Vendor               |
	| Version              |
	| Compliance           |
	| Association          |
	| Advertisement        |
	| Collection           |
	| Program              |
	| Installed Date       |
	| Used By              |
	| Used Date            |
	| Used Duration (Mins) |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16067
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsInTheApplicationColumnAreLinksAndAfterClickingUserIsRedirectedCorrectApplication
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then table content is present
	When User clicks "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" link on the Details Page
	Then Details page for "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" item is displayed correctly

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16117 @DAS16222 @DAS16309
Scenario: EvergreenJnr_DevicesList_CheckThatReadinessValuesInDdlOnProjectsTabAreDisplayedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "0G0WTR5KN85N2X"
	And User click content from "Hostname" column
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Projects Summary" sub-menu on the Details page
	And User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Project Type" checkbox on the Column Settings panel
	And User select "Request Type" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User click on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in descending order
	When User click on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in ascending order
	Then All text is not displayed for "Readiness" column in the String Filter

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16366 @DAS16246
Scenario: EvergreenJnr_DevicesList_CheckThatVerticalMenuIsUnfoldedCorrectlyOnMenuSubItems
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then "Details" tab-menu on the Details page is expanded
	Then "Projects" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Active Directory" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects Summary" sub-menu on the Details page
	Then "Projects" tab-menu on the Details page is expanded
	Then "Details" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Active Directory" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded
	When User navigates to the "Active Directory" main-menu on the Details page
	When User navigates to the "Active Directory" sub-menu on the Details page
	Then "Active Directory" tab-menu on the Details page is expanded
	Then "Details" tab-menu on the Details page is not expanded
	Then "Projects" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16379 @DAS16415 @DAS16500 @DAS16297 @DAS15583 @DAS15559 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInEvergreenMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Related" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Projects Details       |
	| Projects Summary       |
	| Owner Projects Summary |
	#================ checks counters ================#
	Then "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification | 
	| Network Cards | 
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   | 
	#================ checks counters ================#
	Then "Specification" tab is displayed on left menu on the Details page and contains count of items
	Then "Network Cards" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "CPUS" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Video Cards" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Monitors" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Sound Cards" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       | 
	| Active Directory |  
	| Groups           |
	| LDAP             | 
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary | 
	| Evergreen Detail  |
	| Advertisements    | 
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          | 
	| Overview            |          
	| Hardware Summary    |            
	| Hardware Rules      |           
	| Application Summary |            
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS15560 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInProjectMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	#When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Related" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Projects Details       |
	| Projects Summary       |
	| Owner Projects Summary |
	#================ checks counters ================#
	Then "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification | 
	| Network Cards | 
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   | 
	#================ checks counters ================#
	Then "Specification" tab is displayed on left menu on the Details page and contains count of items
	Then "Network Cards" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "CPUS" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Video Cards" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Monitors" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Sound Cards" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       | 
	| Active Directory |  
	| Groups           |
	| LDAP             | 
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary | 
	| Evergreen Detail  |
	| Advertisements    | 
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          | 
	| Overview            |          
	| Hardware Summary    |            
	| Hardware Rules      |           
	| Application Summary |            
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16418 @DAS16415 @DAS15583 @DAS15348 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| Project Details         |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	#================ checks counters ================#
	Then "User Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	Then "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS15345 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInEvergreenMode
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName     |
	| Application    |
	| Advertisements |
	| Programs       |
	| Custom Fields  |
	#================ checks counters ================#
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Programs" tab is displayed on left menu on the Details page and contains count of items
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Application" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Details |
	| Project Details   |
	| Projects          |
	#================ checks counters ================#
	Then "Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main MSI tab ================#
	Then "MSI" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| MSIFiles   |
	| AOK        |
	#================ checks counters ================#
	Then "MSIFiles" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "AOK" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Distribution tab ================#
	Then "Distribution" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| Users      |
	| Devices    |
	| Groups     |
	| AD         |
	#================ checks counters ================#
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "AD" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS16905 @DAS15583 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Mailbox" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Email Addresses" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Custom Fields" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName            |
	| Evergreen Details     |
	| Project Details       |
	| Mailbox Projects      |
	| Mailbox User Projects |
	#================ checks counters ================#
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox User Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Users tab ================#
	Then "Users" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	Then "Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Groups" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Unresolved Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Folder Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Trend tab ================#
	Then "Trend" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Email Count            |
	| Mailbox Size (MB)      |
	| Associated Item Count  |
	| Deleted Item Count     |
	| Deleted Item Size (MB) |
	#================ checks counters ================#
	Then "Email Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Associated Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15133 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsSummaryRowCanBeCopied
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00BDM1JUR8IF419"
	And User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	When User performs right-click on "Advantage Data Architect" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data 'Advantage Data Architect\tUnknown\tExtended Systems\tGreen\tSMS_GEN\tUnknown\tTrue\tFalse\t\t\t5200\t75518\t10 Jan 2018' is copied

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16322 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatActionPanelImplementedForItemDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	Then "ADD USERS" Action button is displayed
	Then Actions drop-down is displayed on the Item Details page
	When User clicks Actions button on the Item Details page
	When User clicks "Remove" button in Actions drop-down on the Item Details page
	Then "REMOVE" Action button is displayed 

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16338
Scenario: EvergreenJnr_DevicesList_CheckThatCrumbTrailElementInTheHeaderOfThePageIsDisplayed
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User clicks on "Devices" navigation link
	Then "Devices" list should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User clicks on "Users" navigation link
	Then "Users" list should be displayed to the user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User clicks on "Applications" navigation link
	Then "Applications" list should be displayed to the user
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User clicks on "Mailboxes" navigation link
	Then "Mailboxes" list should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16719
Scenario: EvergreenJnr_UsersList_CheckThatDataIsDisplayedInHardwareSummaryTabForUserObjectDetailsPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "AAD1011948"
	When User click content from "Username" column
	Then Details page for "AAD1011948" item is displayed to the user
	When User navigates to the "Compliance" main-menu on the Details page
	When User navigates to the "Hardware Summary" sub-menu on the Details page
	Then element table is displayed on the Details page

#test for 'Nova'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16472 @DAS16469 @DAS15039 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatIconsForReadinessDdlOnRelatedTabAreDisplayed
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Related" main-menu on the Details page
	When User enters "03ME2G7TIR4GBN" text in the Search field for "Device" column on the Details Page
	Then "31 May 2019" content is displayed in the "Date" column
	When User clicks String Filter button for "Application Readiness" column
	Then appropriate colored filter icons are displayed for following colors:
	| Color                   |
	| OUT OF SCOPE            |
	| BLUE                    |
	| LIGHT BLUE              |
	| RED                     |
	| BROWN                   |
	| AMBER                   |
	| REALLY EXTREMELY ORANGE |
	| PURPLE                  |
	| GREEN                   |
	| GREY                    |
	| NONE                    |

#not fully ready on 'Nova'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15039 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatTheRelatedTabIsDisplayedCorrectlyWithTheCorrectElementsAndColumns
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Related" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Devices               |
	| Owner                 |
	| Owner Display         |
	| Linked By             |
	| Path                  |
	| Category              |
	| Status                |
	| Date                  |
	| Application Readiness |
	| Pre Migration         |
	| Post Migration        |
	| Migration             |
	| Email Controls        |
	| Communications        |
	And Links from "Device" column is displayed to the user on the Details Page
	And Links from "Owner" column is displayed to the user on the Details Page
	And Links from "Owner Display Name" column is displayed to the user on the Details Page
	And Links from "Linked By" column is displayed to the user on the Details Page
	And Links from "Path" column is NOT displayed to the user on the Details Page
	And Links from "Category" column is NOT displayed to the user on the Details Page
	And Links from "Status" column is NOT displayed to the user on the Details Page
	And Links from "Date" column is NOT displayed to the user on the Details Page
	When User enters "03ME2G7TIR4GBN" text in the Search field for "Device" column on the Details Page
	And User clicks "03ME2G7TIR4GBN" link on the Details Page
	Then Details page for "03ME2G7TIR4GBN" item is displayed correctly
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Related" main-menu on the Details page
	And User enters "ACG370114" text in the Search field for "Owner" column on the Details Page
	And User clicks "ACG370114" link on the Details Page
	Then Details page for "ACG370114 (James N. Snow)" item is displayed correctly
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Related" main-menu on the Details page
	And User enters "James N. Snow" text in the Search field for "Owner Display Name" column on the Details Page
	And User clicks "James N. Snow" link on the Details Page
	Then Details page for "ACG370114 (James N. Snow)" item is displayed correctly
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Related" main-menu on the Details page
	#Not ready for 'nova'
	#When User enters "ACG370114" text in the Search field for "Linked By" column on the Details Page
	#When User clicks "ACG370114" link on the Details Page
	#Then Details page for "ACG370114" item is displayed correctly

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921
Scenario: EvergreenJnr_AllLists_CheckThatTopBarInEvergreenModeIsDisplayedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems     |
	| Overall Compliance  |
	| App Compliance      |
	| Hardware Compliance |
	#=====================================================================================#
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems       |
	| Overall Compliance    |
	| User App Compliance   |
	| Hardware Compliance   |
	| Device App Compliance |
	#=====================================================================================#
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems    |
	| Overall Compliance |
	#=====================================================================================#
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	Then No one Compliance items are displayed for the User in Top bar on the Item details page
	
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15913
Scenario: EvergreenJnr_DevicesList_CheckThatUnknownValuesAreNotDisplayedOnLevelOfGroupedRows
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Evergreen Summary" sub-menu on the Details page
	When User clicks Group By button on the Details page and selects "Vendor" value
	Then "UNKNOWN" content is not displayed in the grid on the Item details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16859 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForDeviceObjects
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields            |
	| Object ID         |
	| Team              |
	| Capacity Unit     |
	| Bucket            |
	| Ring              |
	| Self Service URL  |
	| Overall Readiness |
	| Path              |
	| Category          |
	| Tags              |
	| Device Owner      |
	| Language          |
	Then "RED" content is displayed in "Overall Readiness" field on Item Details page
	#TODO step
	#And Link from "Device" field is displayed to the user on the Details Page

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16858 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForUserObjects
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields            |
	| Object ID         |
	| Team              |
	| Capacity Unit     |
	| Bucket            |
	| Ring              |
	| Self Service URL  |
	| Overall Readiness |
	| Path              |
	| Category          |
	| Tags              |
	| Primary Device    |
	| Language          |
	Then "RED" content is displayed in "Overall Readiness" field on Item Details page

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16861 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForApplicationObjects
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by ""WPF/E" (codename) Community Technology Preview (Feb 2007)"
	When User click content from "Application" column
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields              |
	| Object ID           |
	| Team                |
	| Capacity Unit       |
	| Ring                |
	| Overall Readiness   |
	| App Readiness       |
	| Primary App         |
	| App Rationalisation |
	| Target App          |
	| Hide From End Users |
	| Path                |
	| Category            |
	| Tags                |
	Then "GREEN" content is displayed in "Overall Readiness" field on Item Details page
	Then "GREEN" content is displayed in "App Readiness" field on Item Details page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16957 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForMailboxObjects
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00A5B910A1004CF5AC4@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00A5B910A1004CF5AC4@bclabs.local" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields            |
	| Object ID         |
	| Capacity Unit     |
	| Bucket            |
	| Ring              |
	| Self Service URL  |
	| Overall Readiness |
	| Path              |
	| Category          |
	| Tags              |
	| Mailbox Device    |
	| Language          |
	Then "NONE" content is displayed in "Overall Readiness" field on Item Details page