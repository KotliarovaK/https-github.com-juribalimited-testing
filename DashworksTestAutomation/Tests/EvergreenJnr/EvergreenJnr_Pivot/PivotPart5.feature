Feature: PivotPart5
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_UsersLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForUsers
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| City      |
	And User selects the following Columns on Pivot:
	| Columns                                                           |
	| Windows7Mi: Communication \ Group User Radiobutton Readiness Only |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "City" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| NOT APPLICABLE |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForDevices
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns                                                  |
	| UserEvergr: Stage 1 \ Dropdown Readiness Date (Computer) |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then Empty value is not displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| NOT APPLICABLE |
	| STARTED        |
	| FAILED         |
	| COMPLETE       |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14423 @DAS15252
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForUsers
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups           |
	| Organisational Unit |
	And User selects the following Columns on Pivot:
	| Columns                           |
	| Windows7Mi: Application Readiness |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "Organizational Unit" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14423 @DAS15252
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForDevices
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns                           |
	| Windows7Mi: Application Readiness |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then Empty value is not displayed on the first place for the Pivot
	And Empty value is displayed on the first place for the Pivot column header
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14424 @DAS13865 @DAS15252 @DAS13786 @DAS13823 @DAS16244
Scenario: EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups                                                          |
	| Barry'sUse: Audit & Configuration \ Validate User Device Ownership |
	And User selects the following Columns on Pivot:
	| Columns                                                            |
	| Barry'sUse: Audit & Configuration \ Validate User Device Ownership |
	And User selects the following Values on Pivot:
	| Values                      |
	| 2004: Application Readiness |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| NOT APPLICABLE |
	| AUDIT FAILED   |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426
Scenario: EvergreenJnr_ApplicationsLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForApplications
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns             |
	| UserEvergr: Stage 3 |
	And User selects the following Values on Pivot:
	| Values                |
	| DeviceSche: Readiness |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot