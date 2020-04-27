Feature: CheckingFiltersForColumns
	Runs Item Details Checking Filters For Columns related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12283 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatOneUnknownFilterValueIsShownInGroupDetailsAndFilterWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User type "Denied RODC Password Replication Group" in Global Search Field
	Then User clicks on "Denied RODC Password Replication Group" search result
	When User navigates to the 'Members' left menu item
	Then following checkboxes are displayed in the filter dropdown menu for the 'Enabled' column:
	| Values  |
	| True    |
	| False   |
	When User unchecks following checkboxes in the filter dropdown menu for the 'Enabled' column:
	| checkboxes |
	| True       |
	Then Content is present in the table on the Details Page
	When User clicks button with 'ResetFilters' aria label
	And User enters "wheelern" text in the Search field for "Username" column
	Then Rows counter shows "1" of "7" rows
	When User clicks button with 'ResetFilters' aria label
	And User enters "Administrator" text in the Search field for "Display Name" column
	Then Rows counter shows "1" of "7" rows
	When User clicks button with 'ResetFilters' aria label
	When User unchecks following checkboxes in the filter dropdown menu for the 'Domain' column:
	| checkboxes |
	| DWLABS     |
	Then Rows counter shows "0" of "7" rows

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12239 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatAllTextIsDisplayedAfterClearingFilters
	When User navigates to the 'Device' details page for '001PSUMZYOW581' item
	Then Details page for '001PSUMZYOW581' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	Then 'All' text is displayed in the filter dropdown for the 'Compliance' column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Compliance' column:
	| checkboxes |
	| RED        |
	#TODO upd!!!
	Then All text is not displayed for "Compliance" column in the String Filter
	When User clicks button with 'ResetFilters' aria label
	Then 'All' text is displayed in the filter dropdown for the 'Compliance' column
	When User enters "ea" text in the Search field for "Application" column
	Then Rows counter contains "3" found row of all rows
	When User clicks button with 'ResetFilters' aria label
	And User enters "3.0.0" text in the Search field for "Version" column
	Then Rows counter contains "1" found row of all rows
	When User clicks button with 'ResetFilters' aria label
	When User unchecks following checkboxes in the filter dropdown menu for the 'Used' column:
	| checkboxes |
	| Unknown    |
	Then Rows counter contains "0" found row of all rows
	When User clicks button with 'ResetFilters' aria label
	When User unchecks following checkboxes in the filter dropdown menu for the 'Entitled' column:
	| checkboxes |
	| True       |
	Then Rows counter contains "0" found row of all rows
	When User clicks button with 'ResetFilters' aria label

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS13409 @DAS16565 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatFiltersDropdownListsOnProjectsSummaryTabAreDisplayedCorrectly
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects Summary' left submenu item
	When User clicks String Filter button for "Project" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Workflow" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks following checkboxes from Column Settings panel for the 'Project' column:
	| checkboxes   |
	| Project      |
	| Project Type |
	| Slot         |
	When User clicks String Filter button for "Category" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Status" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	#4/24/20: The 'Readiness' filter is disabled. Ask Lana for more details.
	#Then string filter is displayed for 'Readiness' column
	#When User clicks String Filter button for "Readiness" column
	#Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS13409 @DAS16565 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatFiltersDropdownListsOnOwnerProjectsSummaryTabAreDisplayedCorrectly
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Owner Projects Summary' left submenu item
	When User clicks String Filter button for "Username" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Display Name" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Project" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Workflow" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks following checkboxes from Column Settings panel for the 'Project' column:
	| checkboxes   |
	| Username     |
	| Display Name |
	| Project      |
	| Project Type |
	| Slot         |
	When User clicks String Filter button for "Category" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Status" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	#4/24/20: The 'Readiness' filter is disabled. Ask Lana for more details.
	#Then string filter is displayed for 'Readiness' column
	#When User clicks String Filter button for "Readiness" column
	#Then Dropdown List is displayed correctly in the Filter on the Details Page
	
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS13409 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectlyForExpandedSections
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the '<MainTabName>' left menu item
	And User navigates to the '<SubTabName>' left submenu item
	And User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

Examples:
	| PageName    | SearchTerm                              | MainTabName | SubTabName       |
	| Application | 0036 - Microsoft Access 97 SR-2 English | Projects    | Projects         |
	| Mailbox     | 040698EE82354C17B60@bclabs.local        | Projects    | Mailbox Projects |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS12765 @DAS12321 @DAS13409 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectly
	When User navigates to the 'Mailbox' details page for '040698EE82354C17B60@bclabs.local' item
	Then Details page for '040698EE82354C17B60@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Mailbox Projects' left submenu item
	Then "Bucket" column is displayed to the user
	When User navigates to the 'Mailbox User Projects' left submenu item
	Then "Bucket" column is displayed to the user
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column 
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForDevicesObjectsOnUsersTabInEvergreenMode
	When User navigates to the 'Device' details page for '00HA7MKAVVFDAV' item
	Then Details page for '00HA7MKAVVFDAV' item is displayed to the user
	When User navigates to the 'Users' left menu item
	And User clicks String Filter button for "Domain" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForUsersObjectsOnUsersTabInEvergreenMode
	When User navigates to the 'User' details page for '01C44C91EB7E4BE88F6' item
	Then Details page for '01C44C91EB7E4BE88F6' item is displayed to the user
	When User navigates to the 'Active Directory' left menu item
	And User navigates to the 'Groups' left submenu item
	And User clicks String Filter button for "Domain" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForMailboxesObjectsOnUsersTabInEvergreenMode
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User navigates to the 'Users' left menu item
	Then string filter is displayed for 'Domain' column
	When User navigates to the 'Groups' left submenu item
	Then string filter is displayed for 'Domain' column
	When User navigates to the 'Mailbox Permissions' left submenu item
	Then string filter is displayed for 'Domain' column

#Ann.Ilchenko 3/24/20: this functionality is broken.
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12292 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckingThatInRangeOperatorWorkingCorrectly
	When User navigates to the 'Device' details page for '001PSUMZYOW581' item
	Then Details page for '001PSUMZYOW581' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Projects Summary' left submenu item
	And User opens 'Date' column settings
	And User clicks Filter button on the Column Settings panel
	And User select In Range value with following date:
	| DateFrom    | DateTo      |
	| 22 May 2014 | 22 May 2018 |
	Then Rows counter contains "2" found row of all rows

@Evergreen @Applications @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13180 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_ChecksThatDevicesUsersUsedQuantityMatchEachOtherOnApplicationTabAndApplicationDistributionTab
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
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
	Then '94' content is displayed in the 'Device Count (Used)' column
	And '98' content is displayed in the 'User Count (Used)' column
	When User click content from "Application" column
	When User navigates to the 'Distribution' left menu item
	When User navigates to the 'Users' left submenu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Used' column:
	| checkboxes |
	| False      |
	Then Rows counter shows "98" of "194" rows
	When User navigates to the 'Devices' left submenu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Used' column:
	| checkboxes |
	| False      |
	Then Rows counter shows "94" of "168" rows

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14431 @DAS19243 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_ChecksThatNoConsoleErrorDisplayedAndMenuPositionStaysTheSameWhenSettingDeliveryDate
	When User navigates to the 'Application' details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item
	Then Details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Projects' left submenu item
	And User opens 'Delivery Date' column settings
	And User clicks Filter button on the Column Settings panel
	And User remembers the date input position
	And User select criteria with following date:
	| Criteria  | Date     |
	| Not Equal | 23032018 |
	Then User checks that date input has same position
	Then Rows counter contains "1" found row of all rows
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817 @DAS17726 @DAS20761 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatBlanksValueChangedToEmptyValueOnDevicesPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects Summary' left submenu item
	Then following checkboxes are contained in the filter dropdown menu for the 'Workflow' column:
	| Values         |
	| Empty          |
	Then following checkboxes are contained in the filter dropdown menu for the 'Category' column:
	| Values            |
	| Empty             |
	Then following checkboxes are contained in the filter dropdown menu for the 'Status' column:
	| Values |
	| None   |
	When User closes Checkbox filter
	When User navigates to the 'Owner Projects Summary' left submenu item
	Then following checkboxes are contained in the filter dropdown menu for the 'Workflow' column:
	| Values         |
	| Empty          |
	Then following checkboxes are contained in the filter dropdown menu for the 'Category' column:
	| Values            |
	| Empty             |
	Then following checkboxes are contained in the filter dropdown menu for the 'Status' column:
	| Values |
	| None   |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817 @DAS17726 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatBlanksValueChangedToEmptyValueOnUsersPage
	When User navigates to the 'User' details page for 'ZXJ550185' item
	Then Details page for 'ZXJ550185' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'User Projects' left submenu item
	Then following checkboxes are contained in the filter dropdown menu for the 'Workflow' column:
	| Values         |
	| Empty          |
	Then following checkboxes are contained in the filter dropdown menu for the 'Category' column:
	| Values            |
	| Empty             |
	Then following checkboxes are contained in the filter dropdown menu for the 'Status' column:
	| Values |
	| None   |
	When User navigates to the 'Device Project Summary' left submenu item
	Then following checkboxes are contained in the filter dropdown menu for the 'Workflow' column:
	| Values         |
	| Empty          |
	Then following checkboxes are contained in the filter dropdown menu for the 'Category' column:
	| Values            |
	| Empty             |
	Then following checkboxes are contained in the filter dropdown menu for the 'Status' column:
	| Values |
	| None   |
	When User navigates to the 'User' details page for '0137C8E69921432992B' item
	Then Details page for '0137C8E69921432992B' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Mailbox Project Summary' left submenu item
	Then following checkboxes are contained in the filter dropdown menu for the 'Workflow' column:
	| Values         |
	| Empty          |
	Then following checkboxes are contained in the filter dropdown menu for the 'Category' column:
	| Values            |
	| Empty             |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_CheckThatBlanksValueChangedToEmptyValueOnApplicationsPage
	When User navigates to the 'Application' details page for 'ACDSee 5.0.1 PowerPack' item
	Then Details page for 'ACDSee 5.0.1 PowerPack' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects' left submenu item
	Then following checkboxes are contained in the filter dropdown menu for the 'Workflow' column:
	| Values         |
	| Empty          |
	Then following checkboxes are contained in the filter dropdown menu for the 'Category' column:
	| Values            |
	| Empty             |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817 @DAS17726 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatBlanksValueChangedToEmptyValueOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '06C02CDC00044A7DB59@bclabs.local' item
	Then Details page for '06C02CDC00044A7DB59@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Mailbox Projects' left submenu item
	Then following checkboxes are contained in the filter dropdown menu for the 'Workflow' column:
	| Values         |
	| Empty          |
	Then following checkboxes are contained in the filter dropdown menu for the 'Category' column:
	| Values            |
	| Empty             |
	When User navigates to the 'Mailbox User Projects' left submenu item
	Then following checkboxes are contained in the filter dropdown menu for the 'Workflow' column:
	| Values         |
	| Empty          |
	Then following checkboxes are contained in the filter dropdown menu for the 'Category' column:
	| Values            |
	| Empty             |
	Then following checkboxes are contained in the filter dropdown menu for the 'Status' column:
	| Values |
	| None   |