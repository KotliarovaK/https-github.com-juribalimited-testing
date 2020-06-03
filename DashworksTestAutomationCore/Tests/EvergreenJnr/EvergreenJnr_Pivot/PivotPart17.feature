Feature: PivotPart17
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS20971
Scenario: EvergreenJnr_Devices_CheckThatArchivedItemsAreCountedInPivot
	When User navigates to 'devices?$filter=(hostname%20EQUALS%20('04LFYDVZDRRIU5U'%2C'04R5RM0R0MVFCM'%2C'04WJ5P9DN0VEEW'%2C'051FUN5GXT21SF'%2C'05HCVHCGC3Y4Z15'%2C'05LG3HCJLEDEMTR'%2C'05NITEIIH3CGB55'))&$archiveditems=true' url via address line
	Then User sees "7" rows in grid
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Device Type |
	When User selects the following Columns on Pivot:
	| Columns            |
	| Owner Display Name |
	When User selects the following Values on Pivot:
	| Values   |
	| Hostname |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then '2' value is displayed for 'Unknown' row and 'Empty' column

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS21220
Scenario: EvergreenJnr_Devices_CheckThatFilterPanelDisplayingAfterClickingThroughPivotValueHavingEmptyAndArchivedItems
	When User navigates to 'devices?$rowgroups=ownerDisplayName&$columns=ownerHomeDrive&$values=oSCategory%20count' url via address line
	Then Pivot run was completed
	When User clicks value from 'Empty' row and 'Empty' column
	When User clicks the Filters button
	Then "Owner Home Drive is Empty" is displayed in added filter info
	Then "Owner Display Name is empty" is displayed in added filter info

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DA21349
Scenario: EvergreenJnr_Devices_CheckThatSumAggregateFunctionWorks
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups        |
	| Operating System |
	When User selects the following Columns on Pivot:
	| Columns     |
	| Device Type |
	When User selects the following Values on Pivot:
	| Values            |
	| App Count (Total) |
	When User selects aggregate function "Sum" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then table content is present
	