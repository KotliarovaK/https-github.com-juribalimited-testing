Feature: PivotPart9
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13786 @DAS13868
Scenario: EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder
	When User clicks 'Users' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	When User selects the following Columns on Pivot:
	| Columns     |
	| Group Count |
	When User selects the following Values on Pivot:
	| Values       |
	| Device Count |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then numeric data in column headers is sorted in descending order by default for the Pivot

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14374
Scenario: EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup
	When User clicks 'Mailboxes' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups          |
	| EmailMigra: Status |
	When User selects the following Columns on Pivot:
	| Columns |
	| Country |
	When User selects the following Values on Pivot:
	| Values |
	| City   |
	When User clicks 'RUN PIVOT' button 
	Then Pivot left-pinned column content is displayed in following order:
	| ColumnName    |
	| Not Onboarded |
	| Onboarded     |
	| Forecast      |
	| Targeted      |
	| Scheduled     |
	| Migrated      |

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14374 @DAS15376
Scenario: EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroup
	When User clicks 'Users' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups    |
	| 2004: Status |
	When User selects the following Columns on Pivot:
	| Columns |
	| Country |
	When User selects the following Values on Pivot:
	| Values |
	| City   |
	When User clicks 'RUN PIVOT' button 
	Then Pivot left-pinned column content is displayed in following order:
	| ColumnName    |
	| Not Onboarded |
	| Onboarded     |
	When User clicks the Filters button
	When User add "Last Logon Date" filter where type is "Between" without added column and Date options
	| StartDateInclusive | EndDateInclusive |
	| 25 Apr 2018        | 02 May 2018      |
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13863
Scenario Outline: EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup1
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
	Then Pivot left-pinned column content is displayed in following order:
	| ColumnName    |
	| Not Onboarded |
	| Onboarded     |
	| Forecast      |
	| Scheduled     |
	| Migrated      |
	| Complete      |

Examples:
	| List    | Row                | Column  | Value |
	| Devices | ComputerSc: Status | Country | City  |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14374
Scenario Outline: EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup2
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
	#Then data in left-pinned column is sorted in ascending order by default for the Pivot

Examples:
	| List    | Row      | Column             | Value  |
	| Devices | Building | ComputerSc: Status | Region |