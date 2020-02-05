Feature: FiltersFunctionalityPart25
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11575
Scenario: EvergreenJnr_DevicesList_CheckThatFilterLogicForBooleanFieldsIsWorkedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Secure Boot Enabled" filter where type is "Does not equal" with added column and following checkboxes:
		| SelectedCheckboxes |
		| FALSE              |
		| Empty              |
	Then "Secure Boot Enabled" filter is added to the list
	Then table data in column is filtered correctly

   @Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11144 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatChildrenOfTreeBasedFiltersAreIncludedInTheListResultsOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Equals" with added column and "Sales" Tree List option
	Then "Department" filter is added to the list
	And "3,295" rows are displayed in the agGrid


@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS13024
Scenario: EvergreenJnr_DevicesList_ChecksThatGridIsDisplayedCorrectlyAfterAddingDeviceOwnerLdapAndComputerAdObjectLdapAttributeFilterToTheDevicesList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner accountexpires" filter where type is "Empty" without added column and following value:
		| Values |
		| 123    |
	When User add "admincount" filter where type is "Empty" without added column and following value:
		| Values |
		| 123    |
	Then "17,279" rows are displayed in the agGrid
	And full list content is displayed to the user
	And There are no errors in the browser console
	And table content is present