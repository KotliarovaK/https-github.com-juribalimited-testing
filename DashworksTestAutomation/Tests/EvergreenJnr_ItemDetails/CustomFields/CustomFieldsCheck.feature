Feature: CustomFieldsCheck
	Custom Fields Check

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ann.Ilchenko 8/21/19: ready on 'quasar';
	#Need to update the data when Ilya adds them to the GoldData;
@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17323 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatContextMenuCopyСellForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User performs right-click on "ComputerCustomField" cell in the grid
	And User selects 'Copy cell' option in context menu
	Then Next data 'ComputerCustomField' is copied

	#Ann.Ilchenko 8/21/19: ready on 'quasar';
	#Need to update the data when Ilya adds them to the GoldData;
@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17323 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatContextMenuCopyRowForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User performs right-click on "ComputerCustomField" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data 'ComputerCustomField      0.665371384' is copied

@Evergreen @AllLists @EvergreenJnr_ItemDetails @CustomFields @DAS17909
Scenario Outline: EvergreenJnr_AllLists_CheckThatContextMenuCopyRowForTheRowActionsIsDisplayedAndWorkedCorrectlyForCustomFields
	When User clicks "<PageName>" on the left-hand menu
	Then "<OpenPageName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User have opened Column Settings for "Custom Field" column in the Details Page table
	Then User sees the following Column Settings
	| ColumnSettings        |
	| Pin Left              |
	| Pin Right             |
	| No Pin                |
	| Autosize This column  |
	| Autosize All Columns  |
	| Group By Custom Field |
	| Sort ascending        |
	| Sort descending       |
	| No sort               |

Examples: 
	| PageName     | OpenPageName     | ItemName                   | ColumnName    |
	| Devices      | All Devices      | 001BAQXT6JWFPI             | Hostname      |
	| Users        | All Users        | ACG370114                  | Username      |
	| Applications | All Applications | Adobe Download Manager 2.0 | Application   |
	| Mailboxes    | All Mailboxes    | 000F977AC8824FE39B8        | Email Address |

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17908
Scenario: EvergreenJnr_DevicesList_CheckThatColumnSettingsOnCustomFieldsAreTranslatedAccordingToAccountLanguage
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	When User language is changed to "Deutsch" via API
	When User clicks refresh button in the browser
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
	
@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17907
Scenario: EvergreenJnr_DevicesList_CheckThatCustomFieldsTheGroupByElementContainOnlyVisibleColumns
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User have opened Column Settings for "Custom Field" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Value" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks Group By button on grid action bar
	Then following Group By values ​​are displayed for User on grid action bar
	| Values       |
	| Custom Field |