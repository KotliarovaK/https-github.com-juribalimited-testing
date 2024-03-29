﻿Feature: PivotPart7
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario Outline: EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForUsers
	When User clicks '<List>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| <Row>     |
	When User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	When User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| IGNORE     |

Examples:
	| List    | Row      | Column           | Value                 |
	| Users   | Domain   | Compliance       | UserEvergr: Readiness |

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS14430
Scenario Outline: EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDevice
	When User clicks '<List>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| <Row>     |
	When User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	When User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	#Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| Empty      |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| IGNORE     |

Examples:
	| List    | Row      | Column           | Value      |
	| Devices | Hostname | Owner Compliance | Owner City |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario: EvergreenJnr_DevicesLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDevices
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups      |
	| Inventory Site |
	When User selects the following Columns on Pivot:
	| Columns    |
	| Compliance |
	When User selects the following Values on Pivot:
	| Values          |
	| 2004: Readiness |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15139 @DAS13833 @DAS13843 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatThePivotPanelShowNoFiltersAppliedIfThatWereAppliedToTheCustomList
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Application Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Application Compliance" filter is added to the list
	When User create dynamic list with "TestListForDAS15139" name on "Devices" page
	Then "TestListForDAS15139" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	Then 'ADD ROW GROUP' button is displayed
	Then 'ADD COLUMN' button is displayed
	Then 'ADD VALUE' button is displayed
	When User clicks Close panel button
	Then Actions panel is not displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	Then 'ADD ROW GROUP' button is displayed
	Then 'ADD COLUMN' button is displayed
	Then 'ADD VALUE' button is displayed
	When User navigates to the "All Devices" list
	Then Actions panel is not displayed to the user