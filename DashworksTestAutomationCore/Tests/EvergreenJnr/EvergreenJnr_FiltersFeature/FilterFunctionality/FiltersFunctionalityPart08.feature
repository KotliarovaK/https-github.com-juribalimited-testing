Feature: FiltersFunctionalityPart08
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12058 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectGroupTargetStateFiltersInTheApplicationListWorksCorrectly
	When User add following columns using URL to the "Applications" page:
	| ColumnName                              |
	| Windows7Mi: Application Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Group (Target State)" filter where type is "Equal" without added column and "Parkfield Office" Lookup option
	And User click Edit button for "Windows7Mi: Group (Target State)" filter
	And User enters "Administration" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then "29" rows are displayed in the agGrid
	When User create dynamic list with "Project Group (Target State)" name on "Applications" page
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| KEEP               |
	Then "9" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| UNCATEGORISED      |
	Then "20" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| RETIRE			 |
	Then message 'No applications found' is displayed to the user
	When User have removed "Windows7Mi: Application Rationalisation" filter
	And User Add And "Windows7Mi: Application Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FORWARD PATH		 |
	Then message 'No applications found' is displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12200
Scenario: EvergreenJnr_ApplicationsList_CheckThatAdvancedUserFilterReturnsCorrectResults
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association  |
	| FR\APB5713645  | Has used app |
	Then "1" rows are displayed in the agGrid
	When User click Edit button for "User" filter
	When User is deselect "Has used app" Association for Application filter with Lookup value
	When User select "Has not used app" Association for Application filter with Lookup value
	And User clicks Save filter button
	Then "2,222" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_DevicesList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName                                                      | SelectedCheckboxes   | Rows   |
	| Windows7Mi: Category                                            | None                 | 17,248 |
	| Windows7Mi: Migration \ Values but no RAG                       | Three                | 1      |
	| Windows7Mi: Portal Self Service \ SS Application List Completed | Not Applicable       | 5,159  |
	| MigrationP: Category                                            | None                 | 17,274 |
	| Babel(Engl: Path                                                | Machines             | 62     |
	| ComputerSc: Path                                                | Request Type A       | 132    |
	| MigrationP: Path                                                | [Default (Computer)] | 41     |
	| UserSchedu: Path                                                | Request Type A       | 60     |
	
@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12351
Scenario Outline: EvergreenJnr_UsersList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid

Examples: 
	| FilterName                                                       | SelectedCheckboxes | Rows   |
	| Windows7Mi: Category                                             | Terminated         | 1      |
	| Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page | Not Applicable     | 4,642  |
	| Barry'sUse: Category                                             | None               | 41,339 |
	| Havoc(BigD: Path                                                 | [Default (User)]   | 7,578  |
	| UserSchedu: Group Stage \ Group User Default Request Type        | Not Applicable     | 679    |
	| ComputerSc: Group Stage \ Group User Default Request Type        | Not Applicable     | 1,809  |