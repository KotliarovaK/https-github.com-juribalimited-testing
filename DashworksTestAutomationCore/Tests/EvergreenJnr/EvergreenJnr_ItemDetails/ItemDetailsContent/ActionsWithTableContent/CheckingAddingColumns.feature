Feature: CheckingAddingColumns
	Runs Item Details Checking Adding Columns related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235 @DAS13409 @DAS13657 @DAS14923 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForExpandedSections
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the '<MainTabName>' left menu item
	When User navigates to the '<SubTabName>' left submenu item
	When User clicks following checkboxes from Column Settings panel for the '<ColumnName>' column:
	| checkboxes     |
	| <CheckboxName> |
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
	| ColumnName      |
	| <NewColumnName> |
	And There are no errors in the browser console

Examples: 
	| PageName    | SearchTerm                                              | MainTabName  | SubTabName        | ColumnName  | CheckboxName | NewColumnName |
	| Device      | 30BGMTLBM9PTW5                                          | Applications | Evergreen Summary | Application | Key          | Key           |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | Projects     | Projects          | Project     | Object ID    | Object ID     |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | Projects     | Projects          | Project     | Object Key   | Object Key    |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12053 @DAS12235 @DAS13004 @DAS13657 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForClosedSections
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the '<MainTabName>' left menu item
	And User navigates to the '<SubTabName>' left submenu item
	When User clicks following checkboxes from Column Settings panel for the '<ColumnName>' column:
	| checkboxes     |
	| <CheckboxName> |
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples:
	| MainTabName | SubTabName             | ColumnName  | CheckboxName     | NewColumnName    |
	| Compliance  | Application Issues     | Application | Package Key      | Package Key      |
	| Projects    | Projects Summary       | Project     | Object ID        | Object ID        |
	| Projects    | Projects Summary       | Project     | Key              | Key              |
	| Projects    | Owner Projects Summary | Username    | Object Key       | Object Key       |
	| Projects    | Owner Projects Summary | Username    | Key              | Key              |
	| Projects    | Owner Projects Summary | Username    | Request Type Key | Request Type Key |
	| Projects    | Owner Projects Summary | Username    | Category Key     | Category Key     |
	| Projects    | Owner Projects Summary | Username    | Status Key       | Status Key       |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235 @DAS12799 @DAS13657 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumns
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the '<MainTabName>' left menu item
	And User navigates to the '<SubTabName>' left submenu item
	When User clicks following checkboxes from Column Settings panel for the '<ColumnName>' column:
	| checkboxes     |
	| <CheckboxName> |
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples: 
	| PageName    | SearchTerm                                              | ItemName      | MainTabName  | SubTabName          | ColumnName    | CheckboxName         | NewColumnName        |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Detail    | Application   | Application Key      | Application Key      |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Detail    | Application   | Advertisement Key    | Advertisement Key    |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Detail    | Application   | Group Key            | Group Key            |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Evergreen Detail    | Application   | Collection Key       | Collection Key       |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Key                  | Key                  |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Application Key      | Application Key      |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Site Key             | Site Key             |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Collection Key       | Collection Key       |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Advertisements      | Application   | Program Key          | Program Key          |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Collections         | Collection    | Key                  | Key                  |
	| Device      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Collections         | Collection    | Site Key             | Site Key             |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Devices             | Device        | Computer Key         | Computer Key         |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Distribution | Devices             | Device        | Owner Object Key     | Owner Object Key     |
	| Mailbox     | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Groups              | Domain        | Key                  | Key                  |
	| Mailbox     | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Mailbox Permissions | Domain        | Key                  | Key                  |
	| Mailbox     | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Mailbox Permissions | Domain        | Via Group Object Key | Via Group Object Key |
	| Mailbox     | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Mailbox Permissions | Domain        | Access Category Key  | Access Category Key  |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235 @DAS12799 @DAS13657 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsForDetailsTab
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the '<SubTabName>' left submenu item
	When User clicks following checkboxes from Column Settings panel for the '<ColumnName>' column:
	| checkboxes     |
	| <CheckboxName> |
	Then following columns added to the table:
	| ColumnName      |
	| <NewColumnName> |
	And content is present in the following newly added columns:
	| ColumnName      |
	| <NewColumnName> |
	Then There are no errors in the browser console

Examples:
	| PageName    | SearchTerm                                              | ItemName      | MainTabName  | SubTabName          | ColumnName    | CheckboxName         | NewColumnName        |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Advertisements      | Advertisement | Advertisement Key    | Advertisement Key    |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Advertisements      | Advertisement | Collection Key       | Collection Key       |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | Details      | Programs            | Program       | Program Key          | Program Key          |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11732 @DAS12235 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatDataIsDisplayedAfterAddingColumnsToTheTable
	When User navigates to the 'Application' details page for 'Microsoft Office Visio 2000 Solutions - Custom Patterns' item
	Then Details page for 'Microsoft Office Visio 2000 Solutions - Custom Patterns' item is displayed to the user
	When User navigates to the '<MainTabName>' left menu item
	And User navigates to the '<SubTabName>' left submenu item
	And User opens 'Device' column settings
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11393 @DAS12765 @DAS13657
Scenario: EvergreenJnr_DevicesList_CheckThatSelectedCheckboxesMatchTheColumnsInTheTableOnTheDetailsPage
	When User navigates to the 'Device' details page for '01WNOSNMP5QLXC' item
	Then Details page for '01WNOSNMP5QLXC' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects Summary' left submenu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes   |
	| Project      |
	| Project Type |
	| Category     |
	| Key          |
	| Object ID    |
	Then following columns added to the table:
	| ColumnName |
	| Key        |
	| Object ID  |
	Then following columns are displayed on the Item details page:
	| ColumnName |
	| Key        |
	| Object ID  |
	| Bucket     |
	| Ring       |
	| Path       |
	| Workflow   |
	| Status     |
	| Date       |
	| Slot       |
	| Readiness  |
	And Checkboxes are checked on the Column Settings panel for "Key" Column Settings panel:
	| Checkbox  |
	| Key       |
	| Object ID |
	| Bucket    |
	| Ring      |
	| Path      |
	| Workflow  |
	| Status    |
	| Date      |
	| Slot      |
	| Readiness |