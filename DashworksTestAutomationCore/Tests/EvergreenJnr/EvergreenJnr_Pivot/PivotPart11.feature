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

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS19348
Scenario: EvergreenJnr_Devices_CheckThatNoConsoleErrorDisplayedAfterRunninfPivotFromObjectOwnerFilter
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner" filter where type is "Equal" without added column and "AU\AAO798996 (Darren J. Walter)" Lookup option
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups      |
	| Device Type |
	When User selects the following Columns on Pivot:
	| Columns          |
	|Hostname |
	When User selects the following Values on Pivot:
	| Values        |
	| Operating System |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS21056
Scenario: EvergreenJnr_Devices_CheckThatEmptyRowVlueLeadsToCorrectFilteredPage
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Country   |
	When User selects the following Columns on Pivot:
	| Columns      |
	| Device Type  |
	| Manufacturer |
	When User selects the following Values on Pivot:
	| Values   |
	| Hostname |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User clicks value from 'Empty' row and 'Dell' column
	When User clicks the Filters button
	Then "Device Type is Data Centre" is displayed in added filter info
	Then "Manufacturer is Dell" is displayed in added filter info
	Then "Country is Empty" is displayed in added filter info

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS17433
Scenario: EvergreenJnr_Mailboxes_CheckThatNoConsoleErrorDisplayedAfterRunninfPivotFromProjectOwnerFilter
	When User clicks 'Mailboxes' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups        |
	| EmailMigra: Name |
	When User selects the following Columns on Pivot:
	| Columns      |
	| Mailbox Type |
	When User selects the following Values on Pivot:
	| Values             |
	| Owner Display Name |
	When User selects aggregate function "Count" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then There are no errors in the browser console