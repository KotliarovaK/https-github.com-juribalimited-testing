Feature: PivotPart10
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14375
Scenario: EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsColumn
	When User clicks 'Users' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	When User selects the following Columns on Pivot:
	| Columns |
	| City    |
	When User selects the following Values on Pivot:
	| Values |
	| Region |
	When User clicks 'RUN PIVOT' button 
	When User closes the Pivot panel
	Then Empty value is displayed on the first place for the Pivot
	Then Empty value is displayed on the first place for the Pivot column header
	Then Pivot column headers is displayed in following order:
	| ColumnName  |
	| Empty       |
	| Belfast     |
	| Calgary     |
	| Cardiff     |
	| Edinburgh   |
	| Jersey City |
	| London      |
	| Los Angeles |
	| Melbourne   |
	| New York    |
	| San Diego   |

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14375
Scenario: EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsColumn
	When User clicks 'Mailboxes' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	When User selects the following Columns on Pivot:
	| Columns            |
	| EmailMigra: Status |
	When User selects the following Values on Pivot:
	| Values |
	| Region |
	When User clicks 'RUN PIVOT' button 
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName    |
	| Not Onboarded |
	| Onboarded     |
	| Forecast      |
	| Targeted      |
	| Scheduled     |
	| Migrated      |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15758 @DAS15328 @DAS14246
Scenario Outline: EvergreenJnr_Lists_CheckThatColumnsForAggregateFunctionsAreCapitalised_StingValues
	When User clicks '<List>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	When User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	Then "General information field 1" is displayed at the top left corner on Pivot

Examples:
	| List         | AddValues   | CountAggregateFunctions |
	| Devices      | Owner City  | Count(Owner City)       |
	| Users        | Building    | Count(Building)         |
	| Applications | Application | Count(Application)      |
	| Mailboxes    | Building    | Count(Building)         |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15758 @DAS15328
Scenario Outline: EvergreenJnr_Lists_CheckThatColumnsForAggregateFunctionsAreCapitalised_DateValues
	When User clicks '<List>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	When User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "First" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<FirstAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Last" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then "<LastAggregateFunctions>" is displayed in the columns for aggregate functions

Examples:
	| List         | AddValues                                                    | CountAggregateFunctions                                             | FirstAggregateFunctions                                             | LastAggregateFunctions                                             |
	| Devices      | Build Date                                                   | Count(Build Date)                                                   | First(Build Date)                                                   | Last(Build Date)                                                   |
	| Users        | Last Logon Date                                              | Count(Last Logon Date)                                              | First(Last Logon Date)                                              | Last(Last Logon Date)                                              |
	| Applications | Windows7Mi: Application Information \ Technical Task3 (Date) | Count(Windows7Mi: Application Information \ Technical Task3 (Date)) | First(Windows7Mi: Application Information \ Technical Task3 (Date)) | Last(Windows7Mi: Application Information \ Technical Task3 (Date)) |
	| Mailboxes    | Created Date                                                 | Count(Created Date)                                                 | First(Created Date)                                                 | Last(Created Date)                                                 |