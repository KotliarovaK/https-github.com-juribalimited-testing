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