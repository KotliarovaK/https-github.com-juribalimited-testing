Feature: CustomFieldsCheck
	Custom Fields Check

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17323
Scenario: EvergreenJnr_DevicesList_CheckThatContextMenuCopyСellForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	And User navigates to the 'Custom Fields' left submenu item
	When User right clicks on 'ComputerCustomField' cell from 'Custom Field' column
	And User selects 'Copy cell' option in context menu
	Then Next data 'ComputerCustomField' is copied

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17323
Scenario: EvergreenJnr_DevicesList_CheckThatContextMenuCopyRowForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	And User navigates to the 'Custom Fields' left submenu item
	When User right clicks on 'ComputerCustomField' cell from 'Custom Field' column
	And User selects 'Copy row' option in context menu
	Then Next data 'ComputerCustomField      0.665371384' is copied

@Evergreen @AllLists @EvergreenJnr_ItemDetails @CustomFields @DAS17909 @DAS17959 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatContextMenuCopyRowForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User navigates to the '<ItemType>' details page for '<ItemName>' item
	And User navigates to the 'Custom Fields' left submenu item
	Then User sees following options for 'Custom Field' column settings
	| ColumnSettings        |
	| Pin left              |
	| Pin right             |
	| No pin                |
	| Autosize this column  |
	| Autosize all columns  |
	| Group by Custom Field |
	| Sort ascending        |
	| Sort descending       |
	| No sort               |

Examples: 
	| ItemType    | ItemName                                 |
	| Device      | 001BAQXT6JWFPI                           |
	| User        | ACG370114                                |
	| Application | Adobe Download Manager 2.0 (Remove Only) |
	| Mailbox     | 000F977AC8824FE39B8@bclabs.local         |

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17908
Scenario: EvergreenJnr_DevicesList_CheckThatColumnSettingsOnCustomFieldsAreTranslatedAccordingToAccountLanguage
	When User language is changed to "Deutsch" via API
	And User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	When User navigates to the 'Benutzerdefinierte Felder' left submenu item
	Then User sees following options for 'Benutzerdefiniertes Feld' column settings
	| ColumnSettings                            |
	| Links fixieren                            |
	| Rechts fixieren                           |
	| Nicht fixiert                             |
	| Größe dieser Spalte automatisch festlegen |
	| Größe aller Spalten automatisch festlegen |
	| Gruppieren nach Benutzerdefiniertes Feld  |
	| Aufsteigend sortieren                     |
	| Absteigend sortieren                      |
	| Nicht sortieren                           |
	
@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17907 @DAS17960
Scenario: EvergreenJnr_DevicesList_CheckThatCustomFieldsTheGroupByElementContainOnlyVisibleColumns
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	And User navigates to the 'Custom Fields' left submenu item
	And User opens 'Custom Field' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Value" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following Group By values ​​are displayed for User on menu panel
	| Values       |
	| Custom Field |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @CustomFields @DAS17776 @DAS18363 @DAS18502 @DAS18436 @Zion_NewGrid 
Scenario Outline: EvergreenJnr_AllLists_CheckThatItsNotPossibleToUnselectTheLastColumnOnCustomFieldsTab
	When User navigates to the '<ItemType>' details page for '<ItemName>' item
	And User navigates to the 'Custom Fields' left submenu item
	When User clicks on 'Custom Field' column header
	Then data in table is sorted by 'Custom Field' column in ascending order
	When User opens 'Value' column settings
	When User clicks Column button on the Column Settings panel
	And User clicks Select All checkbox on Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then ColumnName is displayed in following order on the Details page:
	| ColumnName   |
	|              |
	When User clicks button with 'reload' aria label
	Then ColumnName is displayed in following order on the Details page:
	| ColumnName   |
	| Custom Field |
	|              |
	| Value        |
	Then data in table is sorted by 'Custom Field' column in ascending order

Examples: 
	| ItemType    | ItemName                                 |
	| Device      | 001BAQXT6JWFPI                           |
	| User        | ACG370114                                |
	| Application | Adobe Download Manager 2.0 (Remove Only) |
	| Mailbox     | 000F977AC8824FE39B8@bclabs.local         |

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS18155
Scenario: EvergreenJnr_DevicesList_CheckThatAllAgGridHeaderButtonsAreDisplayedForCustomFields
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	And User navigates to the 'Custom Fields' left submenu item
	Then 'reload' button with aria label is displayed
	Then 'GroupBy' button with aria label is displayed
	Then 'ResetFilters' button with aria label is displayed
	Then 'ResetFilters' button with aria label is disabled
	When User opens 'Custom Field' column settings
	When User selects 'Pin left' option from column settings
	Then 'Custom Field' column is 'Left' Pinned
	When User clicks Group By button and set checkboxes state
	| Checkboxes   | State |
	| Custom Field | true  |
	Then Grid is grouped
	When User clicks button with 'reload' aria label
	Then 'Custom Field' column is 'Left' Pinned
	Then Grid is grouped

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18121 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCustomFieldOrderIsCorrectInGrid
	When User creates Custom Field via API
	| ObjectType | ObjectId | FieldName        | Value | FieldIndex |
	| device     | 5539     | ComputerWarranty | bbb   | 0          |
	| device     | 5539     | ComputerWarranty | 001   | 0          |
	| device     | 5539     | ComputerWarranty | aaa   | 0          |
	| device     | 5539     | ComputerWarranty | 002   | 0          |
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName        |
	| Computer Warranty |
	When User perform search by "Z75ievru6r751l"
	Then '001, 002, aaa, bbb' content is displayed in the 'Computer Warranty' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17159 @DAS17161 @DAS17162 @DAS17228 @DAS17229 @DAS17265
Scenario: EvergreenJnr_DevicesList_CheckThatAgGridActionsWorksCorrectlyForDetailsPage
	When User navigates to the 'Device' details page for '04R5RM0R0MVFCM' item
	Then Details page for '04R5RM0R0MVFCM' item is displayed to the user
	When User navigates to the 'Details' left menu item
	And User navigates to the 'Custom Fields' left submenu item
	When User clicks on 'Custom Field' column header
	Then data in table is sorted by 'Custom Field' column in ascending order
	When User clicks on 'Custom Field' column header
	Then data in table is sorted by 'Custom Field' column in descending order
	Then ColumnName is displayed in following order on the Details page:
	| ColumnName   |
	| Custom Field |
	|              |
	| Value        |
	Then User sees "2" rows in grid
	Then 'ResetFilters' button with aria label is disabled
	Then 'reload' button with aria label is displayed
	Then 'Export' button with aria label is displayed
	Then 'GroupBy' button with aria label is displayed
	When User enters "com" text in the Search field for "Custom Field" column
	Then 'ResetFilters' button with aria label is not disabled
	Then Rows counter shows "1" of "2" rows
	When User clicks button with 'ResetFilters' aria label
	Then 'ResetFilters' button with aria label is disabled
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Value      | true  |
	Then Grid is grouped

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17906
Scenario: EvergreenJnr_DevicesList_CheckThatTheGroupingIsDoneAfterTheFirstClickOnTheGroupByAction
	When User navigates to the 'Device' details page for '04R5RM0R0MVFCM' item
	Then Details page for '04R5RM0R0MVFCM' item is displayed to the user
	When User navigates to the 'Details' left menu item
	And User navigates to the 'Custom Fields' left submenu item
	When User clicks following checkboxes from Column Settings panel for the 'Custom Field' column:
	| checkboxes |
	| Value      |
	When User clicks Group By button and set checkboxes state
	| Checkboxes   | State |
	| Custom Field | true  |
	Then Grid is grouped