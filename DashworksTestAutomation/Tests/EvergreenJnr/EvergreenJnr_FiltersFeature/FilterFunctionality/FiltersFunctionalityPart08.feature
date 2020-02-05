Feature: FiltersFunctionalityPart08
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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