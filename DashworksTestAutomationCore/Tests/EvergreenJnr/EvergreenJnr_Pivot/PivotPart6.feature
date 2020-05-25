Feature: PivotPart6
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426 @DAS14427 @DAS14423 @DAS15252 @DAS14377 @DAS13864
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForParticularExample
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
	Then data in the table is sorted by "<ColumnToCheck>" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

Examples:
	| List         | Row                 | Column                            | Value                 | ColumnToCheck       |
	| Mailboxes    | Language            | EmailMigra: Migration             | EmailMigra: Readiness | Language            |
	| Users        | Region              | EmailMigra: Migration             | Compliance            | Region              |
	| Devices      | Region              | Current                           | CPU Count             | Region              |
	| Applications | Import              | 2004: Target App Readiness        | Compliance            | Import              |
	| Users        | Organisational Unit | Windows7Mi: Application Readiness | Compliance            | Organizational Unit |
	| Applications | Import              | UserEvergr: Stage 3               | DeviceSche: Readiness | Import              |
	| Devices      | UseMeForAu: Ring    | City                              | Owner Cost Centre     | UseMeForAu: Ring    |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14428 @DAS13865 @DAS14429
Scenario Outline: EvergreenJnr_AllLists_CheckThatMailboxOwnerComplianceColumnsDisplayInTheCorrectOrder
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
	Then data in the table is sorted by "<ColumnToCheck>" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| IGNORE     |

Examples:
	| List         | Row    | Column           | Value                 | ColumnToCheck |
	| Mailboxes    | City   | Owner Compliance | EmailMigra: Readiness | City          |
	| Applications | Vendor | Compliance       | Import                | Vendor        |