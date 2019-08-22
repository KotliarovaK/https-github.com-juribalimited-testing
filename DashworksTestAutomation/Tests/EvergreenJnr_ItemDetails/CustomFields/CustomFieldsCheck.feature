Feature: CustomFieldsCheck
	Custom Fields Check

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ann.Ilchenko 8/21/19: ready on 'quasar'
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

	#Ann.Ilchenko 8/21/19: ready on 'quasar'
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