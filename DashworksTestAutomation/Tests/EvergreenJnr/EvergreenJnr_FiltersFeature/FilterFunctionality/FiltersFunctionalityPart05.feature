Feature: FiltersFunctionalityPart05
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12537 @DAS12579
Scenario Outline: EvergreenJnr_AllLists_CheckThatContentIsDisplayedInTheAddedColumnAfterApplyingIsNotNoneOperator
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	Then Content is present in the newly added column
	| ColumnName         |
	| <NewlyAddedColumn> |

Examples:
	| ListName  | FilterName           | NewlyAddedColumn     |
	| Mailboxes | EmailMigra: Category | EmailMigra: Category |
	| Devices   | Windows7Mi: Category | Windows7Mi: Category |

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12636 @DAS12481
Scenario Outline: EvergreenJnr_AllLists_CheckThatLocationFilterIsEditedCorrectly
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Postal Code" filter
	And User select "Not empty" Operator value
	And User adds column for the selected filter
	And User clicks Save filter button
	Then Content is present in the newly added column
	| ColumnName  |
	| Postal Code |
	When User Add And "State/County" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <FilterValue>  |
	Then '<FilterValue>' content is displayed in the 'State/County' column
	When User click Edit button for "State/County" filter
	And User deletes the selected lookup filter "<FilterValue>" value
	And User have created "Equals" Lookup filter with column and "Empty" option
	Then "State/County is Empty" is displayed in added filter info
	And Content is empty in the column
	| ColumnName   |
	| State/County |

Examples:
	| ListName  | FilterValue |
	| Devices   | NY          |
	| Users     | NY          |
	| Mailboxes | VIC         |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedAfterApplyingAStaticListWithApplicationSavedListFilter
	When User add following columns using URL to the "Applications" page:
	| ColumnName              |
	| Device Count (Entitled) |
	Then Content is present in the newly added column
	| ColumnName              |
	| Device Count (Entitled) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                     |
	| Exemples de conception de bases de données |
	When User clicks on 'Device Count (Entitled)' column header
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList6581" name
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| StaticList6581 | Entitled to device |
	Then "38" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingAStaticListAsTheFilteredApplicationSavedList
	When User add following columns using URL to the "Applications" page:
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	Then Content is present in the newly added column
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                    |
	| MKS Source Integrity 7.3d |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList6778" name
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| StaticList6778 | Entitled to device |
	Then "123" rows are displayed in the agGrid