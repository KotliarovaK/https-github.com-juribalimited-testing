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
	| Autosize all Columns  |
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