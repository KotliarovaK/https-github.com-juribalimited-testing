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

	#Ann.Ilchenko 8/28/19: ready on 'quasar';
@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS17907 @Not_Ready
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
	When User clicks Group By button on the Item Details page
	Then following Group By values ​​are displayed for User
	| Values       |
	| Custom Field |