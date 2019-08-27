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
	Then "Devices" list should be displayed to the user
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
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User performs right-click on "ComputerCustomField" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data 'ComputerCustomField      0.665371384' is copied

	#Ann.Ilchenko 8/27/19: ready on 'quasar';
@Evergreen @AllLists @EvergreenJnr_ItemDetails @CustomFields @DAS17909 @Not_Ready
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