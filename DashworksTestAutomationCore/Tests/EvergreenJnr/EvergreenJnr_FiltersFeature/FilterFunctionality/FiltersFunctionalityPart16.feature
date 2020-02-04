Feature: FiltersFunctionalityPart16
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS16394 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatCreateButtonIsNotEnabledAfterClickingEditFilterForTheListBasedOnSavedListWithErrors
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList                        | Association |
	| Device List (Complex) - BROKEN LIST |             |
	When User creates 'List_DAS16394' dynamic list
	Then "List_DAS16394" list is displayed to user
	Then Create button is disabled on the Base Dashboard Page
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for " Device" filter
	Then Create button is disabled on the Base Dashboard Page

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15807
Scenario: EvergreenJnr_UsersList_CheckThatLanguageFilterIsDisplayedOnTheUserList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Language" filter where type is "Equals" with added column and Lookup option
	| SelectedValues  |
	| English         |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS16071
Scenario Outline: EvergreenJnr_DevicesList_CheckThatNotAndOffBoarderValuesIncludedToStatusFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues       |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName         | SelectedCheckboxes | Rows   |
	| Windows7Mi: Status | Not Onboarded      | 12,100 |
	| Windows7Mi: Status | Offboarded         | 20     |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17411 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatProjectNameCategoryAppearsForList
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Windows7Mi: Name |
	Then ColumnName is added to the list
	| ColumnName       |
	| Windows7Mi: Name |
	When User clicks the Filters button
	And User add "Windows7Mi: Name" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	And User Add And "Windows7Mi: Name" filter where type is "Contains" with added column and following value:
    | Values |
    | 00     |
	And User Add And "Windows7Mi: Name" filter where type is "Does not contain" with added column and following value:
    | Values |
    | fpi    |
	And User Add And "Windows7Mi: Name" filter where type is "Begins with" with added column and following value:
    | Values |
    | 2      |
	Then "4" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS16178
Scenario: EvergreenJnr_DevicesList_CheckProjectOwnerItemsCounter
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Windows7Mi: Owner Username" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	And User Add And "Windows7Mi: Owner Display Name" filter where type is "Does not begin with" with added column and following value:
    | Values |
    | to     |
	And User Add And "Windows7Mi: Owner Username" filter where type is "Contains" with added column and following value:
    | Values |
    | 1    |
	And User Add And "Windows7Mi: Owner Display Name" filter where type is "Does not end with" with added column and following value:
    | Values |
    | 9      |
	Then "2,471" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17004
Scenario: EvergreenJnr_DevicesList_CheckDepartmentLevelFilterItems
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Department Level 1" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Support            |
	| Technology         |
	And User Add And "Department Level 2" filter where type is "Equals" with added column and Lookup option
	| SelectedValues          |
	| Facilities              |
	| Application Development |
	And User Add And "Department Level 3" filter where type is "Does not equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Admin              |
	| Support            |
	| Helpdesk           |
	Then "1,699" rows are displayed in the agGrid