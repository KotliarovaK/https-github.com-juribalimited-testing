﻿Feature: CheckingFiltersForColumns
	Runs Item Details Checking Filters For Columns related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12283
Scenario: EvergreenJnr_DevicesList_CheckThatOneUnknownFilterValueIsShownInGroupDetailsAndFilterWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User type "Denied RODC Password Replication Group" in Global Search Field
	Then User clicks on "Denied RODC Password Replication Group" search result
	When User navigates to the 'Members' left menu item
	And User clicks String Filter button for "Enabled" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| True    |
	| False   |
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
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "001PSUMZYOW581"
	And User click content from "Hostname" column
	When User navigates to the 'Applications' left menu item
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

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS13409
Scenario Outline: EvergreenJnr_AllLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectlyForCollapsedSections
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the '<MainTabName>' left menu item
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
	| Users    | Loya\, Dan.Employees.Birmingham.UK.bclabs.local | Username   | Projects    | Mailbox Project Summary | 2         |
	| Devices  | 001BAQXT6JWFPI                                  | Hostname   | Projects    | Projects Summary        | 10        |
	| Devices  | 001BAQXT6JWFPI                                  | Hostname   | Projects    | Owner Projects Summary  | 7         |
	| Users    | Loya\, Dan.Employees.Birmingham.UK.bclabs.local | Username   | Projects    | User Projects           | 3         |
	
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12210 @DAS12738 @DAS12371 @DAS13409
Scenario Outline: EvergreenJnr_AllLists_CheckThatDropdownListsInTheProjectDetailsFiltersAreDisplayedCorrectlyForExpandedSections
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the '<MainTabName>' left menu item
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
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User perform search by "040698EE82354C17B60@bclabs.local"
	And User click content from "Email Address" column
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Mailbox Projects" sub-menu on the Details page
	Then "Bucket" column is displayed to the user
	When User navigates to the "Mailbox User Projects" sub-menu on the Details page
	Then "Bucket" column is displayed to the user
	When User clicks String Filter button for "Project Type" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page
	When User clicks String Filter button for "Category" column 
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113
Scenario: EvergreenJnr_DevicesList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForDevicesObjectsOnUsersTabInEvergreenMode
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "00HA7MKAVVFDAV"
	And User click content from "Hostname" column
	Then Details page for "00HA7MKAVVFDAV" item is displayed to the user
	When User navigates to the 'Users' left menu item
	When User clicks String Filter button for "Domain" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

	@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113
Scenario: EvergreenJnr_UsersList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForUsersObjectsOnUsersTabInEvergreenMode
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User perform search by "01C44C91EB7E4BE88F6"
	And User click content from "Username" column
	Then Details page for "01C44C91EB7E4BE88F6" item is displayed to the user
	When User navigates to the 'Active Directory' left menu item
	When User navigates to the "Groups" sub-menu on the Details page
	When User clicks String Filter button for "Domain" column
	Then Dropdown List is displayed correctly in the Filter on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17113
Scenario: EvergreenJnr_MailboxesList_ChecksThatMultiselectFilterIsAppliedForDomainColumnForMailboxesObjectsOnUsersTabInEvergreenMode
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User perform search by "000F977AC8824FE39B8@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User navigates to the 'Users' left menu item
	When User clicks String Filter button for "Domain" column
	And User closes Checkbox filter for "Domain" column
	When User navigates to the "Groups" sub-menu on the Details page
	When User clicks String Filter button for "Domain" column
	And User closes Checkbox filter for "Domain" column
	When User navigates to the "Mailbox Permissions" sub-menu on the Details page
	When User clicks String Filter button for "Domain" column
	And User closes Checkbox filter for "Domain" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12292
Scenario: EvergreenJnr_DevicesList_CheckingThatInRangeOperatorWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User type "001PSUMZYOW581" in Global Search Field
	Then User clicks on "001PSUMZYOW581" search result
	When User navigates to the 'Projects' left menu item
	When User navigates to the "Projects Summary" sub-menu on the Details page
	And User have opened Column Settings for "Date" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	And User select In Range value with following date:
	| DateFrom    | DateTo      |
	| 22 May 2014 | 22 May 2018 |
	Then Rows counter contains "2" found row of all rows

@Evergreen @Applications @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13180
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
	Then "94" content is displayed in "Device Count (Used)" column
	And "98" content is displayed in "User Count (Used)" column
	When User click content from "Application" column
	When User navigates to the 'Distribution' left menu item
	When User navigates to the "Users" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User closes Checkbox filter for "Used" column
	Then Rows counter shows "98" of "194" rows
	When User navigates to the "Devices" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User closes Checkbox filter for "Used" column
	Then Rows counter shows "94" of "168" rows

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14431
Scenario: EvergreenJnr_ApplicationsList_ChecksThatNoConsoleErrorDisplayedAndMenuPositionStaysTheSameWhenSettingDeliveryDate
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User perform search by ""WPF/E" (codename) Community Technology Preview (Feb 2007)"
	And User click content from "Application" column
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the "Projects" sub-menu on the Details page
	And User have opened Column Settings for "Delivery Date" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	And User remembers the date input position
	And User select criteria with following date:
	| Criteria  | Date     |
	| Not Equal | 23032018 |
	Then User checks that date input has same position
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16817 @DAS17726
Scenario: EvergreenJnr_DevicesList_CheckThatBlanksValueChangedToEmptyValueOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Projects' left menu item
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
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User perform search by "ZXJ550185"
	And User click content from "Username" column
	Then Details page for "ZXJ550185" item is displayed to the user
	When User navigates to the 'Projects' left menu item
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
	When User navigates to the 'Projects' left menu item
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
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User perform search by "ACDSee 5.0.1 PowerPack"
	And User click content from "Application" column
	Then Details page for "ACDSee 5.0.1 PowerPack" item is displayed to the user
	When User navigates to the 'Projects' left menu item
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
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User perform search by "06C02CDC00044A7DB59"
	And User click content from "Email Address" column
	Then Details page for "06C02CDC00044A7DB59" item is displayed to the user
	When User navigates to the 'Projects' left menu item
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