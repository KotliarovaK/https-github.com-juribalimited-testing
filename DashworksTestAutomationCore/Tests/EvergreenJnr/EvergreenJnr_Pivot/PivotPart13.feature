Feature: PivotPart13
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555
Scenario: EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForUsers
	When User clicks 'Users' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	| Floor     |
	When User selects the following Columns on Pivot:
	| Columns |
	| Country |
	When User selects the following Values on Pivot:
	| Values                            |
	| ComputerSc: Application Readiness |
	When User clicks the Filters button
	When User add "Country" filter where type is "Equals" without added column and "USA" Lookup option
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "101 Hudson Street" left-pinned value on Pivot
	Then following values are displayed for "USA" column on Pivot
	| Value1            | Value2 |
	| 101 Hudson Street | GREEN  |
	| 20                | GREEN  |
	| 21                | GREEN  |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555 @DAS17669
Scenario: EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForDevices
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Country   |
	| City      |
	When User selects the following Columns on Pivot:
	| Columns      |
	| Manufacturer |
	When User selects the following Values on Pivot:
	| Values          |
	| 2004: Readiness |
	When User selects aggregate function "Severity" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "USA" left-pinned value on Pivot
	Then following values are displayed for "Asus" column on Pivot
	| Value1      | Value2	|
	| USA         | BLOCKED |
	| Los Angeles | GREEN	|
	| San Diego   | BLOCKED |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForDevices
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Country   |
	| Import    |
	When User selects the following Columns on Pivot:
	| Columns |
	| Import  |
	When User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User selects aggregate function "Severity" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "Empty" left-pinned value on Pivot
	Then following values are displayed for "A01 SMS (Spoof)" column on Pivot
	| Value1          | Value2 |
	| Empty           | AMBER  |
	| A01 SMS (Spoof) | AMBER  |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_ApplicationsLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForApplications
	When User clicks 'Applications' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Vendor    |
	When User selects the following Columns on Pivot:
	| Columns                                                              |
	| UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) |
	When User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Empty          |
	| NOT APPLICABLE |
	| STARTED        |