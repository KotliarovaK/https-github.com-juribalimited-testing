Feature: FiltersFunctionalityPart14
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersFunctionality @DAS14524
Scenario Outline: EvergreenJnr_AllLists_CheckRowsCountedForOrganizationalUnitFilterWithSelectedValue
	When User clicks '<Page>' on the left-hand menu
	Then 'All <Page>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "<Type>" with added column and following value:
	| Values  |
	| <Value> |
	Then "<FilterName>" filter is added to the list
	And "<Rows>" rows are displayed in the agGrid

Examples:
	| Page         | FilterName                | Type        | Value                  | Rows   |
	| Devices      | Owner Organizational Unit | Equals      | Users.Cardiff.UK.local | 1,458  |
	| Devices      | Owner Organizational Unit | Contains    | Users                  | 11,665 |
	| Users        | Organizational Unit       | Begins with | Users                  | 23,728 |
	| Mailboxes    | Owner Organizational Unit | Not Empty   |                        | 14,747 |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersFunctionality @DAS14524 @DAS15223
Scenario: EvergreenJnr_ApplicationsList_CheckRowsCountedForOwnerOrganizationalUnitFilterWithEmptyValue
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Organizational Unit" filter where type is "Empty" with following Value and Association:
	| Values | Association                             |
	|        | Has used app                            |
	|        | Entitled to app                         |
	|        | Owns a device which app was used on     |
	|        | Owns a device which app is entitled to  |
	|        | Owns a device which app is installed on |
	Then "User whose Organizational Unit" filter is added to the list
	And "215" rows are displayed in the agGrid

@Evergreen @Users @Evergreen_FiltersFeature @FilterFunctionality @DAS15246 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUrlOfSavedListHasNoEmptyParameters
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And user select "Windows7Mi: Communication \ Send Applications List - User Object Task (Team)" filter
	And User clicks in search field in the Filter block
	And User enters "Unassigned" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	When User create dynamic list with "TestList15246" name on "Users" page
	Then "TestList15246" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User navigates to the "TestList15246" list
	Then "TestList15246" list is displayed to user
	And URL contains 'evergreen/#/users?$listid='
	And URL contains only "listid" filter

@Evergreen @Users @Evergreen_FiltersFeature @FilterFunctionality @DAS15291
Scenario: EvergreenJnr_UsersList_CheckSlotsSortOrderForUsersList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	When User Add And "Domain" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| BCLABS         |
	When User clicks on 'UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)' column is equal to
	| Content     |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 2 |
	| User Slot 2 |
	When User clicks on 'UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 2 \ Dropdown Non RAG Date (User) (Slot)' column is equal to
	| Content     |
	| User Slot 2 |
	| User Slot 2 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |
	| User Slot 1 |