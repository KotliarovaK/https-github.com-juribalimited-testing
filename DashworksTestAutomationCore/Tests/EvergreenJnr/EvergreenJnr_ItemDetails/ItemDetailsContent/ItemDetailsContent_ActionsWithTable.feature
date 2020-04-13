Feature: ItemDetailsContent_ActionsWithTable
	Runs Item Details Content Actions With Table related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091 @DAS14923 @DAS16121 @DAS17305 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage
	When User navigates to the '<PageName>' details page for '<SelectedName>' item
	Then Details page for '<SelectedName>' item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	And User navigates to the 'Application Summary' left submenu item
	Then Name of colors are displayed in following order on the Details Page:
	| ColumnHeader |
	| RED          |
	| AMBER        |
	| GREEN        |
	| UNKNOWN      |
	| IGNORE       |
	When User navigates to the 'Application Issues' left submenu item
	Then "<CountRows>" rows found label displays on Details Page
	And "Manufacturer" column is not displayed to the user
	And following columns added to the table:
	| ColumnName |
	| Vendor     |
	Then string filter is displayed for 'Vendor' column

Examples:
	| PageName | SelectedName   | CountRows |
	| Device   | 001BAQXT6JWFPI | 2         |
	| User     | EKS951231      | 4         |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11762 @DAS12235 @DAS13813 @DAS14923 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the '<TabName>' left menu item
	And User opens '<SelectedColumn>' column settings
	And User clicks Filter button on the Column Settings panel
	When  User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console

Examples:
	| PageName    | SearchTerm                                              | TabName      | SelectedColumn |
	| Device      | 30BGMTLBM9PTW5                                          | Applications | Application    |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | MSI          | File Name      |
	| Mailbox     | aaron.u.flores@dwlabs.local                             | Users        | Username       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11647 @Zion_NewGrid
Scenario Outline: EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn
	When User navigates to the 'Device' details page for '30BGMTLBM9PTW5' item
	Then Details page for '30BGMTLBM9PTW5' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the '<SubMenuName>' left submenu item
	Then "87" rows found label displays on Details Page
	When User opens 'Site' column settings
	And User selects 'Autosize this column' option from column settings
	Then Site column has standard size

Examples:
	| SubMenuName    |
	| Advertisements |
	| Collections    |

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12491 @DAS14923 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the '<MainTab>' left menu item
	And User navigates to the '<SubTab>' left submenu item
	Then "1" rows found label displays on Details Page

Examples:
	| PageName    | SearchTerm          | MainTab   | SubTab    |
	| Application | IEWatch 2.1         | MSI       | MSI Files |
	| User        | 01A921EFD05545818AA | Mailboxes | Mailboxes |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16009 @DAS15951 @DAS20748 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsSummarySection
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	When User navigates to the 'Applications' left menu item
	Then following columns are displayed on the Item details page:
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |
	| Compliance  |
	| Installed   |
	| Used        |
	| Entitled    |
	When User navigates to the 'Evergreen Detail' left submenu item
	Then "Application" column is displayed to the user
	When User opens 'Vendor' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Application" checkbox on the Column Settings panel
	And User select "Vendor" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName           |
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

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16719 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatDataIsDisplayedInHardwareSummaryTabForUserObjectDetailsPage
	When User navigates to the 'User' details page for 'AAD1011948' item
	Then Details page for 'AAD1011948' item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	When User navigates to the 'Hardware Summary' left submenu item
	Then table is displayed