Feature: PivotPart10
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14375
Scenario: EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsColumn
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	And User selects the following Columns on Pivot:
	| Columns |
	| City    |
	And User selects the following Values on Pivot:
	| Values |
	| Region |
	And User clicks 'RUN PIVOT' button 
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
	Then 'All Mailboxes' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	And User selects the following Columns on Pivot:
	| Columns            |
	| EmailMigra: Status |
	And User selects the following Values on Pivot:
	| Values |
	| Region |
	And User clicks 'RUN PIVOT' button 
	Then Empty value is displayed on the first place for the Pivot
	And Pivot column headers is displayed in following order:
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
	Then '<ListLabel>' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	And User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	Then "General information field 1" is displayed at the top left corner on Pivot

Examples:
	| List         | ListLabel        | AddValues   | CountAggregateFunctions |
	| Devices      | All Devices      | Owner City  | Count(Owner City)       |
	| Users        | All Users        | Building    | Count(Building)         |
	| Applications | All Applications | Application | Count(Application)      |
	| Mailboxes    | All Mailboxes    | Building    | Count(Building)         |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15758 @DAS15328
Scenario Outline: EvergreenJnr_Lists_CheckThatColumnsForAggregateFunctionsAreCapitalised_DateValues
	When User clicks '<List>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	And User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "First" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<FirstAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Last" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<LastAggregateFunctions>" is displayed in the columns for aggregate functions

Examples:
	| List         | ListLabel        | AddValues                                                    | CountAggregateFunctions                                             | FirstAggregateFunctions                                             | LastAggregateFunctions                                             |
	| Devices      | All Devices      | Build Date                                                   | Count(Build Date)                                                   | First(Build Date)                                                   | Last(Build Date)                                                   |
	| Users        | All Users        | Last Logon Date                                              | Count(Last Logon Date)                                              | First(Last Logon Date)                                              | Last(Last Logon Date)                                              |
	| Applications | All Applications | Windows7Mi: Application Information \ Technical Task3 (Date) | Count(Windows7Mi: Application Information \ Technical Task3 (Date)) | First(Windows7Mi: Application Information \ Technical Task3 (Date)) | Last(Windows7Mi: Application Information \ Technical Task3 (Date)) |
	| Mailboxes    | All Mailboxes    | Created Date                                                 | Count(Created Date)                                                 | First(Created Date)                                                 | Last(Created Date)                                                 |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15758 @DAS15328
Scenario Outline: EvergreenJnr_Lists_CheckThatColumnsForAggregateFunctionsAreCapitalised_NumericValues
	When User clicks '<List>' on the left-hand menu
	Then '<ListLabel>' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	And User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Sum" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<SumAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Min" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<MinAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Max" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<MaxAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Avg" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then "<AvgAggregateFunctions>" is displayed in the columns for aggregate functions

Examples:
	| List         | ListLabel        | AddValues                | CountAggregateFunctions         | SumAggregateFunctions         | MinAggregateFunctions         | MaxAggregateFunctions         | AvgAggregateFunctions         |
	| Devices      | All Devices      | HDD Count                | Count(HDD Count)                | Sum(HDD Count)                | Min(HDD Count)                | Max(HDD Count)                | Avg(HDD Count)                |
	| Users        | All Users        | Device Count             | Count(Device Count)             | Sum(Device Count)             | Min(Device Count)             | Max(Device Count)             | Avg(Device Count)             |
	| Applications | All Applications | 2004: Current User Count | Count(2004: Current User Count) | Sum(2004: Current User Count) | Min(2004: Current User Count) | Max(2004: Current User Count) | Avg(2004: Current User Count) |
	| Mailboxes    | All Mailboxes    | Associated Item Count    | Count(Associated Item Count)    | Sum(Associated Item Count)    | Min(Associated Item Count)    | Max(Associated Item Count)    | Avg(Associated Item Count)    |

@Evergreen @DevicesLists @EvergreenJnr_Pivot @Pivot @DAS14263 @DAS16403 @DAS16407 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckAddTeamsPermissionsOnDetailsPanel
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	And User selects the following Columns on Pivot:
	| Columns |
	| City    |
	And User selects the following Values on Pivot:
	| Values      |
	| Cost Centre |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "DAS14263_Pivot" name
	Then "DAS14263_Pivot" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'person_add' icon
	When User selects 'Administrator' option from 'User' autocomplete
	When User clicks 'CANCEL' button 
	When User clicks 'group_add' icon
	When User selects 'Team 1062' option from 'Team' autocomplete
	Then 'ADD TEAM' button is disabled
	When User selects 'Edit' in the 'Permission' dropdown
	Then 'ADD TEAM' button is not disabled
	When User clicks 'CANCEL' button 
	When User clicks 'group_add' icon
	When User selects 'Team 1062' option from 'Team' autocomplete
	When User selects 'Admin' in the 'Permission' dropdown
	When User clicks 'CANCEL' button 
	When User clicks 'group_add' icon
	When User selects 'Team 1062' option from 'Team' autocomplete
	When User selects 'Read' in the 'Permission' dropdown
	When User clicks 'CANCEL' button 
	When User navigates to the "DAS14263_Pivot" list
	Then User remove list with "DAS14263_Pivot" name on "Devices" page

@Evergreen @DevicesLists @EvergreenJnr_Pivot @Pivot @DAS16815 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckArchivedItemIncludingInPivot
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in 'true'
	And User clicks the Filters button
	And User add "2004: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	And User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups        |
	| Operating System |
	And User selects the following Values on Pivot:
	| Values      |
	| Device Type |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "DAS16815_Pivot" name
	Then "DAS16815_Pivot" list is displayed to user
	When User sets includes archived devices in 'false'
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User updates existing pivot
	Then "DAS16815_Pivot" list is displayed to user
	When User sets includes archived devices in 'true'
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "DAS16815_Pivot_Updated" name
	Then "DAS16815_Pivot_Updated" list is displayed to user