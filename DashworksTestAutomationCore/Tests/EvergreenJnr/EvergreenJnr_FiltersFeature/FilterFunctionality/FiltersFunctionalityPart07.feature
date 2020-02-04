Feature: FiltersFunctionalityPart07
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12181 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorIsDisplayedAfterAddingFewAdvancedFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Does not equal" with following Lookup Value and Association:
	| SelectedValues              | Association  |
	| DWLABS\$231000-3AC04R8AR431 | Has used app |
	When User add "User Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values     | Association     |
	| 1 Feb 2018 | Entitled to app |
	When User add "User SID" filter where type is "Begins with" with following Value and Association:
	| Values | Association                         |
	| 555    | Owns a device which app was used on |
	Then "247" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12181 @DAS11561 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorIsDisplayedAfterAddingFewAdvancedFiltersAndFewStandardFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Compliance" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association  |
	| Red                | Has used app |
	When User add "User Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association     |
	| TRUE               | Entitled to app |
	When User Add And "User Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values      | Association     |
	| 15 Feb 2016 | Entitled to app |
	When User add "Application" filter where type is "Contains" with added column and following value:
	| Values |
	| Office |
	When User add "Vendor" filter where type is "Contains" with added column and following value:
	| Values    |
	| Microsoft |
	Then "1,514" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12827 @DAS12812
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserLastLogonDateFilterWorksCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Equals" with following Data and Association:
	| Values      | Association  |
	| 30 Apr 2018 | Has used app |
	Then message 'No applications found' is displayed to the user
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12058 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectGroupCurrentStateFiltersInTheApplicationListWorksCorrectly
	When User add following columns using URL to the "Applications" page:
	| ColumnName                              |
	| Windows7Mi: Application Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Group (Current State)" filter where type is "Equal" without added column and "Parkfield Office" Lookup option
	And User click Edit button for "Windows7Mi: Group (Current State)" filter
	And User enters "Administration" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then "34" rows are displayed in the agGrid
	When User create dynamic list with "Project Group (Current State)" name on "Applications" page
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FORWARD PATH       |
	Then "1" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| RETIRE             |
	Then "4" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| KEEP               |
	Then "8" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| UNCATEGORISED      |
	Then "21" rows are displayed in the agGrid
