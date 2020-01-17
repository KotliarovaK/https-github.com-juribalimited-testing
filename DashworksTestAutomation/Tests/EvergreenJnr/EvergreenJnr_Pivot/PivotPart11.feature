Feature: PivotPart11
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS19348
Scenario: EvergreenJnr_Mailboxes_CheckThatRecipientTypeColumnCanBeUsedInPivot
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups      |
	| Recipient Type |
	When User selects the following Columns on Pivot:
	| Columns          |
	| Mailbox Platform |
	When User selects the following Values on Pivot:
	| Values        |
	| Email Address |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in the table is sorted by "Recipient Type" column in ascending order by default for the Pivot