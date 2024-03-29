﻿Feature: PivotPart5
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_UsersLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForUsers
	When User clicks 'Users' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| City      |
	When User selects the following Columns on Pivot:
	| Columns                                                           |
	| Windows7Mi: Communication \ Group User Radiobutton Readiness Only |
	When User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Empty          |
	| NOT APPLICABLE |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForDevices
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	When User selects the following Columns on Pivot:
	| Columns                                                  |
	| UserEvergr: Stage 1 \ Dropdown Readiness Date (Computer) |
	When User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Empty value is not displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Empty          |
	| NOT APPLICABLE |
	| STARTED        |
	| FAILED         |
	| COMPLETE       |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14423 @DAS15252
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForDevices
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	When User selects the following Columns on Pivot:
	| Columns                           |
	| Windows7Mi: Application Readiness |
	When User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Empty value is not displayed on the first place for the Pivot
	Then Empty value is displayed on the first place for the Pivot column header
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14424 @DAS13865 @DAS15252 @DAS13786 @DAS13823 @DAS16244
Scenario: EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups                                                          |
	| Barry'sUse: Audit & Configuration \ Validate User Device Ownership |
	When User selects the following Columns on Pivot:
	| Columns                                                            |
	| Barry'sUse: Audit & Configuration \ Validate User Device Ownership |
	When User selects the following Values on Pivot:
	| Values                      |
	| 2004: Application Readiness |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	#Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Empty          |
	| NOT APPLICABLE |
	| AUDIT FAILED   |

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_MailboxesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForMailboxes
	When User clicks 'Mailboxes' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups        |
	| Evergreen Bucket |
	When User selects the following Columns on Pivot:
	| Columns                                              |
	| EmailMigra: Pre-Migration \ Infrastructure Readiness |
	When User selects the following Values on Pivot:
	| Values           |
	| Owner Compliance |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Empty value is not displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName           |
	| Empty                |
	| INFRASTRUCTURE READY |