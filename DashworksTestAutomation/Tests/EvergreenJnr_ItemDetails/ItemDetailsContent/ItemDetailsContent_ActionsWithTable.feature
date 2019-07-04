Feature: ItemDetailsContent_ActionsWithTable
	Runs Item Details Content Actions With Table related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12043 @DAS11531 @DAS12321 @DAS17279
Scenario Outline: EvergreenJnr_AllLists_CheckThatErrorsAreNotDisplayedWhenOpenedDetailsPageThatDoesNotContainOwnerInformation
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ObjectName>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<TabName>" sub-menu on the Details page
	Then "<MessageText>" message is displayed on the Details Page
	And There are no errors in the browser console

Examples:
	| PageName  | ObjectName              | ColumnName    | TabName       | MessageText                                       |
	| Devices   | 06Y8HSNCPVHENV          | Hostname      | Device Owner  | No device owner information found for this device |
	| Mailboxes | alex.cristea@juriba.com | Email Address | Mailbox Owner | No mailbox owner found for this mailbox           |
	| Devices   | 00BDM1JUR8IF419         | Hostname      | Custom Fields | No custom fields found for this device            |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12285
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectMessageIsDisplayedForDevicesSectionOnTheDistributionTab
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACT Data Collection Packages"
	And User click content from "Application" column
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Devices" sub-menu on the Details page
	Then "No devices found for this application" message is displayed on the Details Page

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
	#archived
	#| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Users             | Domain      | Key                 | Key                 |
	#| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Users             | Domain      | Evergreen Object ID | Evergreen Object ID |

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
	And User select "<NewColumnName>" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| MainTabName  | SubTabName | NewColumnName     |
	| Distribution | Devices    | Computer Key      |
	| Distribution | Devices    | Advertisement Key |
	| Distribution | Devices    | Collection Key    |
	| Distribution | Devices    | Program Key       |

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
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
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
	| Path         |
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
	| Path         |
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
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Project Type" checkbox on the Column Settings panel
	And User select "Slot" checkbox on the Column Settings panel
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