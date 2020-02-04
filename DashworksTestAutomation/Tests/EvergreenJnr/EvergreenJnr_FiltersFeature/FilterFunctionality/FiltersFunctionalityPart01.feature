Feature: FiltersFunctionalityPart01
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @Evergreen_FiltersFeature @FiltersFunctionality @DAS10612
Scenario: EvergreenJnr_UsersList_CheckThat500ErrorIsNotReturnedForFilterWithSpecialCharecter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
	| Values               |
	| Jeremiah S. O'Connor |
	Then "Display Name" filter is added to the list
	And "2" rows are displayed in the agGrid

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersFunctionality @DAS10639 @DAS12207
Scenario: EvergreenJnr_ApplicationsList_Check500ErrorIsNotReturnedForBooleanFilterWithUnknownOption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| Empty              |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	| Empty              |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| Empty              |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "1,156" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11166 @DAS11665 @DAS13172 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredAfterGoingBackToTheListAgain
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                       |
	| Microsoft Office 97, Professional Edition    |
	| Microsoft Office 97, Developer Edition Tools |
	| Microsoft Office 97, Standard Edition        |
	Then "Application" filter is added to the list
	When User create dynamic list with "TestList5D30CF" name on "Applications" page
	Then "TestList5D30CF" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info
	When User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "TestList5D30CF" list
	Then "TestList5D30CF" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info

@Evergreen @AllLists @Evergreen_FiltersFeature @FilterFunctionality @DAS11042
Scenario Outline: EvergreenJnr_AllLists_CheckThatPrimaryColumnIsDisplayedAfterAddingAFilterWithColumn
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Contains" with added column and following value:
	| Values        |
	| <FilterValue> |
	Then "<FilterName>" filter is added to the list
	Then ColumnName is added to the list
	| ColumnName   |
	| <ColumnName> |

Examples: 
	| ListName     | FilterName              | FilterValue | ColumnName    |
	| Devices      | Hostname                | 00          | Hostname      |
	| Applications | Application             | adobe       | Application   |
	| Users        | Username                | aa          | Username      |
	| Mailboxes    | Email Address (Primary) | ale         | Email Address |