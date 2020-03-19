Feature: PivotPart6
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426
Scenario: EvergreenJnr_MailboxesLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForMailboxes
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Language  |
	And User selects the following Columns on Pivot:
	| Columns               |
	| EmailMigra: Migration |
	And User selects the following Values on Pivot:
	| Values                |
	| EmailMigra: Readiness |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in the table is sorted by "Language" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426
Scenario: EvergreenJnr_UsersLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForUsers
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Region    |
	And User selects the following Columns on Pivot:
	| Columns               |
	| EmailMigra: Migration |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in the table is sorted by "Region" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForDevices
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Region    |
	And User selects the following Columns on Pivot:
	| Columns |
	| Current |
	And User selects the following Values on Pivot:
	| Values    |
	| CPU Count |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in the table is sorted by "Region" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14427
Scenario: EvergreenJnr_ApplicationsList_CheckThatApplicationTargetAppReadinessColumnsDisplayInTheCorrectOrder
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns                    |
	| 2004: Target App Readiness |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS14428 @DAS13865
Scenario: EvergreenJnr_MailboxesList_CheckThatMailboxOwnerComplianceColumnsDisplayInTheCorrectOrder
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| City      |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values                |
	| EmailMigra: Readiness |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "City" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| IGNORE     |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario: EvergreenJnr_ApplicationsLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForApplications
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Vendor    |
	And User selects the following Columns on Pivot:
	| Columns    |
	| Compliance |
	And User selects the following Values on Pivot:
	| Values |
	| Import |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "<SortedColumn>" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| IGNORE     |