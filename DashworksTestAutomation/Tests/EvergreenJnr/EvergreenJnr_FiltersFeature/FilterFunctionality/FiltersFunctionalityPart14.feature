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

