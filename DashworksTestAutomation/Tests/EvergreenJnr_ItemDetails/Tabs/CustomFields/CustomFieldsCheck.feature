Feature: CustomFieldsCheck
	Custom Fields Check

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17323
Scenario: EvergreenJnr_DevicesList_CheckThatContextMenuCopyСellForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	And User navigates to the "Custom Fields" sub-menu on the Details page
	And User performs right-click on "ComputerCustomField" cell in the grid
	And User selects 'Copy cell' option in context menu
	Then Next data 'ComputerCustomField' is copied

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17323
Scenario: EvergreenJnr_DevicesList_CheckThatContextMenuCopyRowForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	And User navigates to the "Custom Fields" sub-menu on the Details page
	And User performs right-click on "ComputerCustomField" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data 'ComputerCustomField      0.665371384' is copied

@Evergreen @AllLists @EvergreenJnr_ItemDetails @CustomFields @DAS17909 @DAS17959
Scenario Outline: EvergreenJnr_AllLists_CheckThatContextMenuCopyRowForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User navigates to the '<ItemType>' details page for '<ItemName>' item
	And User navigates to the "Custom Fields" sub-menu on the Details page
	And User have opened Column Settings for "Custom Field" column in the Details Page table
	Then User sees the following Column Settings
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
	When User navigates to the "Benutzerdefinierte Felder" sub-menu on the Details page
	And User have opened Column Settings for "Benutzerdefiniertes Feld" column in the Details Page table
	Then User sees the following Column Settings
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
	And User navigates to the "Custom Fields" sub-menu on the Details page
	And User have opened Column Settings for "Custom Field" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Value" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks Group By button on grid action bar
	Then following Group By values ​​are displayed for User on grid action bar
	| Values       |
	| Custom Field |

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17776 @DAS18363
Scenario: EvergreenJnr_DevicesList_CheckThatItsNotPossibleToUnselectTheLastColumnOnCustomFieldsTab
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	And User navigates to the "Custom Fields" sub-menu on the Details page
	And User have opened Column Settings for "Custom Field" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User clicks Select All checkbox on Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then ColumnName is displayed in following order on the Details page:
	| ColumnName   |
	| Custom Field |
	|              |

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS18155
Scenario: EvergreenJnr_DevicesList_CheckThatAllAgGridHeaderButtonsAreDisplayedForCustomFields
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	And User navigates to the "Custom Fields" sub-menu on the Details page
	Then Refresh button is displayed on the Item Details page
	And Group By button is displayed on the Item Details page
	And Reset Filters button is displayed on the Item Details page
	And Reset Filters button on the Item Details page is disable
	When User have opened column settings for "Custom Field" column
	When User have select "Pin left" option from column settings
	Then "Custom Field" column is "Left" Pinned
	When User clicks Group By button on the Details page and selects "Custom Field" value
	Then Grid is grouped
	#Ann.Ilchenko 8/10/19: This is a TEMPORARY step. 
	When User clicks Refresh button on grid action bar
	Then "Custom Field" column is "Left" Pinned
	Then Grid is grouped

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11483 @DAS17352 @DAS17281 @DAS17352
Scenario: EvergreenJnr_DevicesList_CheckThatDataOfColumnsIsDisplayedInTheCustomFieldSection
	When User navigates to the 'Device' details page for '54S1MGR8DYMYKH' item
	And User navigates to the "Custom Fields" sub-menu on the Details page
	Then "1" rows found label displays on Details Page
	Then Content is present in the column of the Details Page table
	| ColumnName   |
	| Custom Field |
	| Value        |
	And Custom fields agGrid columns are displayed fully

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18121
Scenario: EvergreenJnr_DashboardsPage_CheckThatCustomFieldOrderIsCorrectInGrid
	When User navigates to the 'device' details page for 'Z75ievru6r751l' item
	Then Details page for "Z75ievru6r751l" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	When User clicks 'ADD CUSTOM FIELD' button 
	When User selects 'Computer Warranty' option from 'Custom Field' autocomplete
	When User enters 'bbb' text to 'Value' textbox
	When User clicks Add button on Add Custom Field popup
	When User clicks 'ADD CUSTOM FIELD' button 
	When User selects 'Computer Warranty' option from 'Custom Field' autocomplete
	When User enters '001' text to 'Value' textbox
	When User clicks Add button on Add Custom Field popup
	When User clicks 'ADD CUSTOM FIELD' button 
	When User selects 'Computer Warranty' option from 'Custom Field' autocomplete
	When User enters 'aaa' text to 'Value' textbox
	When User clicks Add button on Add Custom Field popup
	When User clicks 'ADD CUSTOM FIELD' button 
	When User selects 'Computer Warranty' option from 'Custom Field' autocomplete
	When User enters '002' text to 'Value' textbox
	When User clicks Add button on Add Custom Field popup
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                 |
	| Computer Warranty |
	When User perform search by "Z75ievru6r751l"
	Then '001, 002, aaa, bbb' content is displayed in the 'Computer Warranty' column