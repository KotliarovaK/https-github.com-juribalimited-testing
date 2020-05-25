Feature: PivotPart9
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13786 @DAS13868
Scenario: EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	And User selects the following Columns on Pivot:
	| Columns     |
	| Group Count |
	And User selects the following Values on Pivot:
	| Values       |
	| Device Count |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And numeric data in table is sorted by "Compliance" column in descending order for the Pivot

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14374
Scenario: EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups          |
	| EmailMigra: Status |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values |
	| City   |
	And User clicks 'RUN PIVOT' button 
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
	Then 'All Users' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups    |
	| 2004: Status |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values |
	| City   |
	And User clicks 'RUN PIVOT' button 
	Then Pivot left-pinned column content is displayed in following order:
	| ColumnName    |
	| Not Onboarded |
	| Onboarded     |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Last Logon Date" filter where type is "Between" without added column and Date options
	| StartDateInclusive | EndDateInclusive |
	| 25 Apr 2018        | 02 May 2018      |
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14374
Scenario: EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups          |
	| ComputerSc: Status |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values |
	| City   |
	And User clicks 'RUN PIVOT' button 
	Then Pivot left-pinned column content is displayed in following order:
	| ColumnName    |
	| Not Onboarded |
	| Onboarded     |
	| Forecast      |
	| Scheduled     |
	| Migrated      |
	| Complete      |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14375
Scenario: EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumn
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	And User selects the following Columns on Pivot:
	| Columns            |
	| ComputerSc: Status |
	And User selects the following Values on Pivot:
	| Values |
	| Region |
	And User clicks 'RUN PIVOT' button 
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName    |
	| Not Onboarded |
	| Onboarded     |
	| Forecast      |
	| Scheduled     |
	| Migrated      |
	| Complete      |