Feature: ItemDetailsContent_ActionsWithTable
	Runs Item Details Content Actions With Table related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12043 @DAS11531 @DAS12321 @DAS17279 @DAS16678
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
	#Added new check for DAS17279
	| Devices   | 00BDM1JUR8IF419         | Hostname      | Custom Fields | No custom fields found for this device            |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12285 @DAS16678
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectMessageIsDisplayedForDevicesSectionOnTheDistributionTab
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACT Data Collection Packages"
	And User click content from "Application" column
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Devices" sub-menu on the Details page
	Then "No devices found for this application" message is displayed on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17278
Scenario: EvergreenJnr_DevicesList_CheckThatCorrectMessageIsDisplayedForDevicesSectionIfTheOwnerEqualUnknownForDeviceObjectInEvergreen
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "06Y8HSNCPVHENV"
	And User click content from "Hostname" column
	When User navigates to the "Users" main-menu on the Details page
	Then "No users found for this device" message is displayed on the Details Page

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

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091 @DAS14923 @DAS16121 @DAS17305
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
	| NONE         |
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11483 @DAS17352 @DAS17281 @DAS17352
Scenario: EvergreenJnr_DevicesList_CheckThatDataOfColumnsIsDisplayedInTheCustomFieldSection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "Benjamin S. Vaughn"
	And User click content from "Hostname" column
	And User navigates to the "Details" main-menu on the Details page
	And User navigates to the "Custom Fields" sub-menu on the Details page
	Then "1" rows found label displays on Details Page
	And Content is present in the column of the Details Page table
	| ColumnName   |
	| Custom Field |
	| Value        |
	And Custom fields agGrid columns are displayed fully 

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
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| True    |
	| False   |
	| Unknown |
	When User clicks "True" checkbox from String Filter on the Details Page
	Then Content is present in the table on the Details Page
	When User clicks Reset Filters button on the Item Details page
	And User enters "wheelern" text in the Search field for "Username" column on the Details Page
	Then Rows counter shows "1" of "7" rows
	When User clicks Reset Filters button on the Item Details page
	And User enters "Administrator" text in the Search field for "Display Name" column on the Details Page
	Then Rows counter shows "1" of "7" rows
	When User clicks Reset Filters button on the Item Details page
	And User clicks String Filter button for "Domain" column
	When User selects "DWLABS" checkbox from String Filter on the Details Page
	Then Rows counter shows "0" of "7" rows

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12239
Scenario: EvergreenJnr_DevicesList_CheckThatAllTextIsDisplayedAfterClearingFilters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001PSUMZYOW581"
	And User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	Then All text is displayed for "Compliance" column in the String Filter
	When User clicks String Filter button for "Compliance" column
	And User clicks "Red" checkbox from String Filter on the Details Page
	Then All text is not displayed for "Compliance" column in the String Filter
	When User clicks Reset Filters button on the Item Details page
	Then All text is displayed for "Compliance" column in the String Filter
	When User enters "ea" text in the Search field for "Application" column on the Details Page
	Then Rows counter contains "3" found row of all rows
	When User clicks Reset Filters button on the Item Details page
	And User enters "3.0.0" text in the Search field for "Version" column on the Details Page
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Item Details page
	And User clicks String Filter button for "Used" column
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	Then Rows counter contains "0" found row of all rows
	When User clicks Reset Filters button on the Item Details page
	And User clicks String Filter button for "Entitled" column
	When User clicks "True" checkbox from String Filter on the Details Page
	Then Rows counter contains "0" found row of all rows
	When User clicks Reset Filters button on the Item Details page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12088 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatMailboxPermissionsAndFolderPermissionsDataAreDisplayedCorrectly
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "abraham.f.wong@dwlabs.local"
	And User click content from "Email Address" column
	And User navigates to the "Users" main-menu on the Details page
	And User navigates to the "Mailbox Permissions" sub-menu on the Details page
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
	And User navigates to the "<SubTabName>" sub-menu on the Details page
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
	And User clicks String Filter button for "Readiness" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

Examples:
	| PageName | SearchTerm                                      | ColumnName | MainTabName | SubTabName              | CountRows |
	| Users    | Loya\, Dan.Employees.Birmingham.UK.bclabs.local | Username   | Projects    | Mailbox Project Summary | 1         |
	| Devices  | 001BAQXT6JWFPI                                  | Hostname   | Projects    | Projects Summary        | 10        |
	| Devices  | 001BAQXT6JWFPI                                  | Hostname   | Projects    | Owner Projects Summary  | 7         |
	| Users    | Loya\, Dan.Employees.Birmingham.UK.bclabs.local | Username   | Projects    | User Projects           | 2         |
	

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS13409
Scenario Outline: EvergreenJnr_AllLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectlyForExpandedSections
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<MainTabName>" main-menu on the Details page
	And User navigates to the "<SubTabName>" sub-menu on the Details page
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
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Mailbox Projects" sub-menu on the Details page
	Then "Bucket" column is displayed to the user
	When User navigates to the "Mailbox User Projects" sub-menu on the Details page
	Then "Bucket" column is displayed to the user
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column 
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12491 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<Column>" column
	When User navigates to the "<MainTab>" main-menu on the Details page
	And User navigates to the "<SubTab>" sub-menu on the Details page
	Then "1" rows found label displays on Details Page

Examples:
	| PageName     | SearchTerm          | Column      | MainTab   | SubTab    |
	| Applications | IEWatch 2.1         | Application | MSI       | MSIFiles  |
	| Users        | 01A921EFD05545818AA | Username    | Mailboxes | Mailboxes |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17094
Scenario: EvergreenJnr_AllLists_CheckThatDataAboutUsersDevicesOnUsersMailboxObjectsWithSnrMatch
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "AAD1011948"
	And User click content from "Username" column
	Then Details page for "AAD1011948" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	When User navigates to the "Devices" main-menu on the Details page
	Then "001BAQXT6JWFPI" content is displayed in "Hostname" column
	#=====================================================================================#
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00A5B910A1004CF5AC4@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00A5B910A1004CF5AC4@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	When User navigates to the "Users" main-menu on the Details page
	Then "00A5B910A1004CF5AC4" content is displayed in "Username" column
	
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16860
Scenario: EvergreenJnr_DevicesList_ChecksThatLinksFromTheDeviceColumnInDeviceProjectSummaryOnDevicesPageGoingToSenior
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Projects Summary" sub-menu on the Details page
	And User clicks "Computer Scheduled Test (Jo)" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Computer: 001BAQXT6JWFPI" object is displayed to the user
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "33819" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Computer: 001BAQXT6JWFPI" object is displayed to the user
	And User click back button in the browser
	#=====================================================================================#
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Owner Projects Summary" sub-menu on the Details page
	And User clicks "Computer Scheduled Test (Jo)" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: QLL295118 (Nicole P. Braun)" object is displayed to the user
	And User click back button in the browser
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "34305" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: QLL295118 (Nicole P. Braun)" object is displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16860
Scenario: EvergreenJnr_UsersList_ChecksThatLinksFromTheDeviceColumnInDeviceProjectSummaryOnUsersPageGoingToSenior
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "000F977AC8824FE39B8"
	And User click content from "Username" column
	Then Details page for "000F977AC8824FE39B8" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "User Projects" sub-menu on the Details page
	And User clicks "Project K-Computer Scheduled Project" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: 000F977AC8824FE39B8 (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	And Details page for "000F977AC8824FE39B8" item is displayed to the user
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "61097" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: 000F977AC8824FE39B8 (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	#=====================================================================================#
	And Details page for "000F977AC8824FE39B8" item is displayed to the user
	When User navigates to the "Mailbox Project Summary" sub-menu on the Details page
	And User clicks "Mailbox Evergreen Capacity Project" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Mailbox: 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	And Details page for "000F977AC8824FE39B8" item is displayed to the user
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "66461" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Mailbox: 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	#=====================================================================================#
	When User clicks on "Users" navigation link
	Then "Users" list should be displayed to the user
	When User perform search by "QLL295118"
	And User click content from "Username" column
	Then Details page for "QLL295118" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Device Project Summary" sub-menu on the Details page
	And User clicks "Windows 7 Migration (Computer Scheduled Project)" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Computer: 001BAQXT6JWFPI" object is displayed to the user
	And User click back button in the browser
	And Details page for "QLL295118" item is displayed to the user
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "11176" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Computer: 001BAQXT6JWFPI" object is displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16860
Scenario: EvergreenJnr_ApplicationsList_ChecksThatLinksFromTheDeviceColumnInDeviceProjectSummaryOnApplicationsPageGoingToSenior
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by ""WPF/E" (codename) Community Technology Preview (Feb 2007)"
	And User click content from "Application" column
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Projects" sub-menu on the Details page
	And User clicks "Windows 7 Migration (Computer Scheduled Project)" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Application: "WPF/E" (codename) Community Technology Preview (Feb 2007) (A01)" object is displayed to the user
	And User click back button in the browser
	And Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "17622" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Application: "WPF/E" (codename) Community Technology Preview (Feb 2007) (A01)" object is displayed to the user
	
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16860
Scenario: EvergreenJnr_MailboxesList_ChecksThatLinksFromTheDeviceColumnInDeviceProjectSummaryOnMailboxesPageGoingToSenior
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "000F977AC8824FE39B8@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Mailbox Projects" sub-menu on the Details page
	And User clicks "Mailbox Evergreen Capacity Project" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Mailbox: 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	And Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "66461" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Mailbox: 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	#=====================================================================================#
	And Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User navigates to the "Mailbox User Projects" sub-menu on the Details page
	And User clicks "Project K-Computer Scheduled Project" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: 000F977AC8824FE39B8 (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	And Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "61097" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: 000F977AC8824FE39B8 (Spruill, Shea)" object is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113
Scenario: EvergreenJnr_DevicesList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForDevicesObjectsOnUsersTabInEvergreenMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00HA7MKAVVFDAV"
	And User click content from "Hostname" column
	Then Details page for "00HA7MKAVVFDAV" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	When User clicks String Filter button for "Domain" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113
Scenario: EvergreenJnr_UsersList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForUsersObjectsOnUsersTabInEvergreenMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "01C44C91EB7E4BE88F6"
	And User click content from "Username" column
	Then Details page for "01C44C91EB7E4BE88F6" item is displayed to the user
	When User navigates to the "Active Directory" main-menu on the Details page
	When User navigates to the "Groups" sub-menu on the Details page
	When User clicks String Filter button for "Domain" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113
Scenario: EvergreenJnr_MailboxesList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForMailboxesObjectsOnUsersTabInEvergreenMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "000F977AC8824FE39B8@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	When User clicks String Filter button for "Domain" column
	And User closes Checkbox filter for "Domain" column
	When User navigates to the "Groups" sub-menu on the Details page
	When User clicks String Filter button for "Domain" column
	And User closes Checkbox filter for "Domain" column
	When User navigates to the "Mailbox Permissions" sub-menu on the Details page
	When User clicks String Filter button for "Domain" column
	And User closes Checkbox filter for "Domain" column

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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13335 @DAS14923 @DAS12963 @DAS16233 @Cleanup
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
	And User have opened Column Settings for "User" column in the Details Page table
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
	Then "94" content is displayed in "Device Count (Used)" column
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
	And User closes Checkbox filter for "Used" column
	Then Rows counter shows "94" of "168" rows

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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16009 @DAS15951
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsSummarySection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |
	| Compliance  |
	| Installed   |
	| Used        |
	| Entitled    |
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
	And User select "Path" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User click on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in descending order
	When User click on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in ascending order
	Then All text is not displayed for "Readiness" column in the String Filter

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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16472 @DAS16469 @DAS15039
Scenario: EvergreenJnr_DevicesList_CheckThatIconsForReadinessDdlOnRelatedTabAreDisplayed
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
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

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17182 @DAS17219 @DAS17254 @DAS17255
Scenario: EvergreenJnr_MailboxesList_CheckThatUsersTabIsDisplayedWithCorrectColumnsOnMailboxesDetailsPageForProjectMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "000F977AC8824FE39B8@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Username              |
	| Display Name          |
	| Readiness             |
	| Owner                 |
	| Domain                |
	| Path                  |
	| Category              |
	| Application Readiness |
	| Stage 1               |
	| Stage 2               |
	| Stage 3               |
	| Stage Z               |
	And "AMBER" content is displayed for "Stage 1" column
	And "RED" content is displayed for "Stage 2" column
	And "GREEN" content is displayed for "Stage 3" column
	And "BLUE" content is displayed for "Stage Z" column
	Then "1" rows found label displays on Details Page
	When User clicks String Filter button for "Path" column
	Then "[Default (User)]" checkbox is checked on the Details Page
	
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17182 @DAS17218 @DAS11053 @DAS14923
Scenario: EvergreenJnr_UsersList_CheckThatDevicesTabIsDisplayedWithCorrectColumnsOnUsersDetailsPageForProjectMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "ZZP911429"
	And User click content from "Username" column
	Then Details page for "ZZP911429" item is displayed to the user
	When User navigates to the "Devices" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Owner Display Name |
	| Operating System   |
	| Compliance         |
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Hostname              |
	| Device Type           |
	| Owner                 |
	| Owner Display Name    |
	| Operating System      |
	| Readiness             |
	| Path                  |
	| Category              |
	| Application Readiness |
	| Stage 1               |

	#Ann.Ilchenko upd 7/11/19: ready for "pulsar" release
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15039 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatTheRelatedTabIsDisplayedCorrectlyWithTheCorrectElementsAndColumns
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the "Related" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Devices               |
	| Owner                 |
	| Owner Display Name    |
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
	
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15913
Scenario: EvergreenJnr_DevicesList_CheckThatUnknownValuesAreNotDisplayedOnLevelOfGroupedRows
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Evergreen Summary" sub-menu on the Details page
	And User clicks Group By button on the Details page and selects "Vendor" value
	Then "UNKNOWN" content is not displayed in the grid on the Item details page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17087
Scenario: EvergreenJnr_MailboxesList_ChecksThatUsersAreReloadedAfterSelectingAProjectOnTheMailboxDetailsPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "abel.y.hanson@dwlabs.local"
	And User click content from "Email Address" column
	Then Details page for "abel.y.hanson@dwlabs.local" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	Then "7" rows found label displays on Details Page
	And "Administrator" content is displayed in "Username" column
	When User switches to the "Email Migration" project in the Top bar on Item details page
	Then "1" rows found label displays on Details Page
	And "hansonay" content is displayed in "Username" column

	#Ann.Ilchenko 7/19/19: will be fully available for the "pulsar" release.
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17159 @DAS17161 @DAS17162 @DAS17228 @DAS17229 @DAS17265 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatAgGridActionsWorksCorrectlyForDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Details" main-menu on the Details page
	And User navigates to the "Custom Fields" sub-menu on the Details page
		#cannot be checked because there is only one item in the table (need to wait for new data in GD?)
	#When User click on 'Custom Field' column header
	#Then date in table is sorted by 'Custom Field' column in ascending order
	#When User click on 'Custom Field' column header
	#Then date in table is sorted by 'Custom Field' column in descending order
	Then ColumnName is displayed in following order on the Details page:
	| ColumnName   |
	| Custom Field |
	| Value        |
		#need to ask Lana about the number of columns for 'pulsar'
	#When User move 'Value' column to 'Custom Field' column
	#Then ColumnName is displayed in following order on the Details page:
	#| ColumnName   |
	#| Value        |
	#| Custom Field |
	Then 'Reset Filters' button is displayed on the Item Details page
	When User change text in '(.*)' cell from '(.*)' column to 'SOME' text
	Then 'Refresh' button is displayed on the Item Details page
	Then 'Export' button is displayed on the Item Details page
	Then 'Group By' button is displayed on the Item Details page
	Then Reset Filters button on the Item Details page is disable
	When User enters "com" text in the Search field for "Custom Field" column on the Details Page
	Then Reset Filters button on the Item Details page is enabled
	Then Rows counter shows "1" of "1" rows
	When User clicks Reset Filters button on the Item Details page
	Then Reset Filters button on the Item Details page is disable
		#need to add static data for gold data to enable this check.
	#When User clicks Group By button on the Details page and selects "Value" value
	#Then "" content is not displayed in the grid on the Item details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817 @DAS17726
Scenario: EvergreenJnr_DevicesList_CheckThatBlanksValueChangedToEmptyValueOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Projects Summary" sub-menu on the Details page
	And User clicks String Filter button for "Workflow" column
	Then following String Values are contained in the filter on the Details Page
	| Values         |
	| Empty          |
	When User clicks String Filter button for "Category" column
	Then following String Values are contained in the filter on the Details Page
	| Values            |
	| Empty             |
	When User clicks String Filter button for "Status" column
	Then following String Values are contained in the filter on the Details Page
	| Values |
	| None   |
	When User closes Checkbox filter for "Status" column
	When User navigates to the "Owner Projects Summary" sub-menu on the Details page
	When User clicks String Filter button for "Workflow" column
	Then following String Values are contained in the filter on the Details Page
	| Values         |
	| Empty          |
	When User clicks String Filter button for "Category" column
	Then following String Values are contained in the filter on the Details Page
	| Values            |
	| Empty             |
	When User clicks String Filter button for "Status" column
	Then following String Values are contained in the filter on the Details Page
	| Values |
	| None   |
	When User closes Checkbox filter for "Status" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817 @DAS17726
Scenario: EvergreenJnr_UsersList_CheckThatBlanksValueChangedToEmptyValueOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "ZXJ550185"
	And User click content from "Username" column
	Then Details page for "ZXJ550185" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "User Projects" sub-menu on the Details page
	And User clicks String Filter button for "Workflow" column
	Then following String Values are contained in the filter on the Details Page
	| Values         |
	| Empty          |
	When User clicks String Filter button for "Category" column
	Then following String Values are contained in the filter on the Details Page
	| Values            |
	| Empty             |
	When User clicks String Filter button for "Status" column
	Then following String Values are contained in the filter on the Details Page
	| Values |
	| None   |
	When User closes Checkbox filter for "Status" column
	When User navigates to the "Device Project Summary" sub-menu on the Details page
	And User clicks String Filter button for "Workflow" column
	Then following String Values are contained in the filter on the Details Page
	| Values         |
	| Empty          |
	When User clicks String Filter button for "Category" column
	Then following String Values are contained in the filter on the Details Page
	| Values            |
	| Empty             |
	When User clicks String Filter button for "Status" column
	Then following String Values are contained in the filter on the Details Page
	| Values |
	| None   |
	When User closes Checkbox filter for "Status" column
	When User type "0137C8E69921432992B" in Global Search Field
	Then User clicks on "0137C8E69921432992B (Jackson, Veronica)" search result
	And Details page for "0137C8E69921432992B" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Mailbox Project Summary" sub-menu on the Details page
	And User clicks String Filter button for "Workflow" column
	Then following String Values are contained in the filter on the Details Page
	| Values         |
	| Empty          |
	When User clicks String Filter button for "Category" column
	Then following String Values are contained in the filter on the Details Page
	| Values            |
	| Empty             |
	When User closes Checkbox filter for "Category" column

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817
Scenario: EvergreenJnr_ApplicationsList_CheckThatBlanksValueChangedToEmptyValueOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACDSee 5.0.1 PowerPack"
	And User click content from "Application" column
	Then Details page for "ACDSee 5.0.1 PowerPack" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Projects" sub-menu on the Details page
	And User clicks String Filter button for "Workflow" column
	Then following String Values are contained in the filter on the Details Page
	| Values         |
	| Empty          |
	When User clicks String Filter button for "Category" column
	Then following String Values are contained in the filter on the Details Page
	| Values            |
	| Empty             |
	When User closes Checkbox filter for "Category" column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817 @DAS17726
Scenario: EvergreenJnr_MailboxesList_CheckThatBlanksValueChangedToEmptyValueOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "06C02CDC00044A7DB59"
	And User click content from "Email Address" column
	Then Details page for "06C02CDC00044A7DB59" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Mailbox Projects" sub-menu on the Details page
	And User clicks String Filter button for "Workflow" column
	Then following String Values are contained in the filter on the Details Page
	| Values         |
	| Empty          |
	When User clicks String Filter button for "Category" column
	Then following String Values are contained in the filter on the Details Page
	| Values            |
	| Empty             |
	When User closes Checkbox filter for "Category" column
	And User navigates to the "Mailbox User Projects" sub-menu on the Details page
	And User clicks String Filter button for "Workflow" column
	Then following String Values are contained in the filter on the Details Page
	| Values         |
	| Empty          |
	When User clicks String Filter button for "Category" column
	Then following String Values are contained in the filter on the Details Page
	| Values            |
	| Empty             |
	When User clicks String Filter button for "Status" column
	Then following String Values are contained in the filter on the Details Page
	| Values |
	| None   |
	When User closes Checkbox filter for "Status" column

@Evergreen @Device @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17734
Scenario: EvergreenJnr_DeviceList_CheckThatUsersTabIsDisplayedWithCorrectStagesOnDevicesDetailsPageForProjectMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| User                  |
	| Readiness             |
	| Display Name          |
	| Domain                |
	| Owner                 |
	| Path                  |
	| Category              |
	| Application Readiness |
	| Stage A               |
	| Stage C               |
	| Stage D               |
	When User enters "AAC860150" text in the Search field for "User" column on the Details Page
	Then "GREEN" content is displayed for "Stage A" column
	And "RED" content is displayed for "Stage C" column
	And "AMBER" content is displayed for "Stage D" column