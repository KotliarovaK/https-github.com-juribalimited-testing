Feature: ItemDetailsContent_ActionsWithTable
	Runs Item Details Content Actions With Table related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11091 @DAS14923 @DAS16121 @DAS17305
Scenario Outline: EvergreenJnr_AllLists_CheckRenamedColumnAndStringFilterForSoftwareComplianceIssuesSectionOnTheDetailsPage
	When User navigates to the '<PageName>' details page for '<SelectedName>' item
	Then Details page for "<SelectedName>" item is displayed to the user
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

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11667 @DAS12321 @DAS11921
Scenario: EvergreenJnr_MailboxesList_CheckThatNoConsoleErrorsWhenViewingMailboxDetails
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks on 'Email Address' column header
	And User clicks on 'Email Address' column header
	And User click content from "Email Address" column
	Then User sees loaded tab "Mailbox" on the Details page
	Then Item content is displayed to the User
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11762 @DAS12235 @DAS13813 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextField
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for "<SearchTerm>" item is displayed to the user
	When User navigates to the '<TabName>' left menu item
	And User have opened Column Settings for "<SelectedColumn>" column
	And User clicks Filter button on the Column Settings panel
	When  User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console

Examples:
	| PageName    | SearchTerm                                              | TabName      | SelectedColumn |
	| Device      | 30BGMTLBM9PTW5                                          | Applications | Application    |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | MSI          | File Name      |
	| Mailbox     | aaron.u.flores@dwlabs.local                             | Users        | Username       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11647
Scenario Outline: EvergreenJnr_DevicesList_CheckThatAutosizeOptionWorksCorrectlyForSiteColumn
	When User navigates to the 'Device' details page for '30BGMTLBM9PTW5' item
	Then Details page for "30BGMTLBM9PTW5" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the '<SubMenuName>' left submenu item
	Then "87" rows found label displays on Details Page
	When User have opened Column Settings for "Site" column
	And User have select "Autosize this column" option from column settings
	Then Site column has standard size

Examples:
	| SubMenuName    |
	| Advertisements |
	| Collections    |

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12491 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatSingularFoundItemLabelDisplaysOnDetailsPages
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for "<SearchTerm>" item is displayed to the user
	When User navigates to the '<MainTab>' left menu item
	And User navigates to the '<SubTab>' left submenu item
	Then "1" rows found label displays on Details Page

Examples:
	| PageName    | SearchTerm          | MainTab   | SubTab    |
	| Application | IEWatch 2.1         | MSI       | MSI Files |
	| User        | 01A921EFD05545818AA | Mailboxes | Mailboxes |
	
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12805
Scenario: EvergreenJnr_ApplicationsList_CheckThatUsersAndDevicesDistributionListsDoNotIncludeUnknownValues
	When User navigates to the 'Application' details page for 'Microsoft DirectX 5 DDK' item
	Then Details page for "Microsoft DirectX 5 DDK" item is displayed to the user
	When User navigates to the 'Distribution' left menu item
	When User navigates to the 'Users' left submenu item
	When User clicks 'False' checkbox from String Filter in the filter dropdown for the 'Used' column
	And User have opened Column Settings for "User" column
	And User have select "Sort descending" option from column settings
	Then Content is present in the table on the Details Page
	And Rows do not have unknown values
	When User navigates to the 'Devices' left submenu item
	When User clicks 'False' checkbox from String Filter in the filter dropdown for the 'Used' column
	And User have opened Column Settings for "Device" column
	And User have select "Sort descending" option from column settings
	Then Content is present in the table on the Details Page
	And Rows do not have unknown values

@Evergreen @UsersLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15522
Scenario: EvergreenJnr_UsersList_ChecksThatNoErrorsAreDisplayedAfterClickingThroughTheProjectNameFromObjectDetails
	When User navigates to the 'User' details page for 'TON2490708' item
	Then Details page for "TON2490708" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Device Project Summary' left submenu item
	When User enters "K-group" text in the Search field for "Bucket" column
	And User clicks "00BDM1JUR8IF419" link on the Details Page
	Then "Project Object" page is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16009 @DAS15951
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
	When User have opened Column Settings for "Vendor" column
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16117 @DAS16222 @DAS16309
Scenario: EvergreenJnr_DevicesList_CheckThatReadinessValuesInDdlOnProjectsTabAreDisplayedCorrectly
	When User navigates to the 'Device' details page for '0G0WTR5KN85N2X' item
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects Summary' left submenu item
	And User have opened Column Settings for "Project" column
	And User clicks Column button on the Column Settings panel
	And User select "Project Type" checkbox on the Column Settings panel
	And User select "Path" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in descending order
	When User clicks on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in ascending order
	Then All text is not displayed for "Readiness" column in the String Filter

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16719
Scenario: EvergreenJnr_UsersList_CheckThatDataIsDisplayedInHardwareSummaryTabForUserObjectDetailsPage
	When User navigates to the 'User' details page for 'AAD1011948' item
	Then Details page for "AAD1011948" item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	When User navigates to the 'Hardware Summary' left submenu item
	Then element table is displayed on the Details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15913
Scenario: EvergreenJnr_DevicesList_CheckThatUnknownValuesAreNotDisplayedOnLevelOfGroupedRows
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	And User clicks Group By button on the Details page and selects "Vendor" value
	Then "UNKNOWN" content is not displayed in the grid on the Item details page

	#Ann.Ilchenko 7/19/19: will be fully available for the "pulsar" release.
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17159 @DAS17161 @DAS17162 @DAS17228 @DAS17229 @DAS17265 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatAgGridActionsWorksCorrectlyForDetailsPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Details' left menu item
	And User navigates to the 'Custom Fields' left submenu item
		#cannot be checked because there is only one item in the table (need to wait for new data in GD?)
	#When User clicks on 'Custom Field' column header
	#Then date in table is sorted by 'Custom Field' column in ascending order
	#When User clicks on 'Custom Field' column header
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
	Then Reset Filters button is displayed on the Item Details page
	Then Refresh button is displayed on the Item Details page
	Then Export button is displayed on the Item Details page
	Then Group By button is displayed on the Item Details page
	Then Reset Filters button on the Item Details page is disable
	When User enters "com" text in the Search field for "Custom Field" column
	Then Reset Filters button on the Item Details page is enabled
	Then Rows counter shows "1" of "1" rows
	When User clicks Reset Filters button on the Item Details page
	Then Reset Filters button on the Item Details page is disable
		#need to add static data for gold data to enable this check.
	#When User clicks Group By button on the Details page and selects "Value" value
	#Then "" content is not displayed in the grid on the Item details page