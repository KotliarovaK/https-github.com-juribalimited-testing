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

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS11144 @DAS12351
Scenario: EvergreenJnr_UsersList_CheckThatChildrenOfTreeBasedFiltersAreIncludedInTheListResultsOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department" filter where type is "Does not equal" with added column and "Support" Tree List option
	Then "Department" filter is added to the list
	And "35,082" rows are displayed in the agGrid

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

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12908
Scenario: EvergreenJnr_ApplicationsList_ChecksThatAdvancedFilterOfUserWhoseFilterNameIsEmptyIsWorkingCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Empty" with following Value and Association:
		| Values | Association     |
		|        | Entitled to app |
	Then "113" rows are displayed in the agGrid
	Then table content is present
	When User have reset all filters
	Then "2,223" rows are displayed in the agGrid
	When User add "User Building" filter where type is "Equals" with following Lookup Value and Association:
		| SelectedValues | Association     |
		| Empty          | Entitled to app |
	Then "245" rows are displayed in the agGrid
	And table content is present

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS14629 @DAS14664 @DAS14665 @DAS14667
Scenario Outline: EvergreenJnr_UsersList_CheckThatPrimaryDeviceOperatorsShowTextBoxCorrectly
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Primary Device" filter
	When User select "<OperatorValue>" Operator value
	Then User Description field is not displayed
	When User clicks 'CANCEL' button
	When user select "Primary Device" filter
	When User select "<OperatorValue>" Operator value
	Then User Description field is not displayed
	When User adds column for the selected filter
	When User clicks Save filter button
	Then ColumnName is added to the list
		| ColumnName     |
		| Primary Device |
	Then "<RowsCount>" rows are displayed in the agGrid

	Examples:
		| OperatorValue | RowsCount |
		| Empty         | 28,117    |
		| Not empty     | 13,222    |