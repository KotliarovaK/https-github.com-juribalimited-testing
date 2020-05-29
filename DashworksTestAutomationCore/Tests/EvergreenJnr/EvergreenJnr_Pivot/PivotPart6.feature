Feature: PivotPart6
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14427 @DAS14423 @DAS15252 @DAS14426 @DAS14377 @DAS13864 @DAS17433 @DAS19348
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
	Then data in left-pinned column is sorted in ascending order by default for the Pivot

Examples:
	| List         | Row                 | Column                            | Value                 |
	| Mailboxes    | Language            | EmailMigra: Migration             | EmailMigra: Readiness |
	| Users        | Region              | EmailMigra: Migration             | Compliance            |
	| Devices      | Region              | Current                           | CPU Count             |
	| Applications | Import              | 2004: Target App Readiness        | Compliance            |
	| Users        | Organisational Unit | Windows7Mi: Application Readiness | Compliance            |
	| Applications | Import              | UserEvergr: Stage 3               | DeviceSche: Readiness |
	| Devices      | UseMeForAu: Ring    | City                              | Owner Cost Centre     |
	| Mailboxes    | EmailMigra: Name    | Mailbox Type                      | Owner Display Name    |
	| Mailboxes    | Recipient Type      | Mailbox Platform                  | Email Address         |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS21302
Scenario Outline: EvergreenJnr_AllLists_CheckThatPivotCanBeCreatedBasedOnParticularRow
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
	Then There are no errors in the browser console

Examples:
	| List    | Row                                       | Column      | Value        |
	| Devices | Windows7Mi: Pre-Migration \ VDI Only Task | Device Type | Boot Up Date |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14428
Scenario Outline: EvergreenJnr_Mailboxes_CheckThatMailboxOwnerComplianceColumnsDisplayInTheCorrectOrder
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
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| Empty      |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| IGNORE     |

Examples:
	| List         | Row    | Column           | Value                 |
	| Mailboxes    | City   | Owner Compliance | EmailMigra: Readiness |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario Outline: EvergreenJnr_Applications_CheckThatMailboxOwnerComplianceColumnsDisplayInTheCorrectOrder
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
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| UNKNOWN    |
	| RED        |
	| AMBER      |
	| GREEN      |
	| IGNORE     |

Examples:
	| List         | Row    | Column     | Value  |
	| Applications | Vendor | Compliance | Import |

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

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13862 @DAS14373
Scenario: EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDisplayInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	When User selects the following Columns on Pivot:
	| Columns               |
	| Operating System      |
	| Service Pack or Build |
	When User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	#Then color data in the left-pinned column is sorted in descending order for the Pivot

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
