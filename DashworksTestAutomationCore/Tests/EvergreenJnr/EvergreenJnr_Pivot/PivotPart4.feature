Feature: PivotPart4
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForApplications
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Vendor      |
	| Application |
	And User selects the following Columns on Pivot:
	| Columns        |
	| Inventory Site |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Vendor" filter
	When User select "Equals" Operator value
	When User enters "Altera" text in Search field at selected Filter
	When User clicks Save filter button
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "Altera" left-pinned value on Pivot
	Then following values are displayed for "SMS_GEN" column on Pivot
	| Value1                          | Value2 |
	| Altera                          | AMBER  |
	| Quartus II 2.0 Web Edition Full | GREEN  |
	| Quartus II 5.0                  | GREEN  |
	| Quartus II 5.0 SP2              | AMBER  |
	| Quartus II Programmer 4.0       | AMBER  |

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForMailboxes
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Import      |
	| Email Count |
	And User selects the following Columns on Pivot:
	| Columns |
	| City    |
	And User selects the following Values on Pivot:
	| Values           |
	| Owner Compliance |
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "BCLABS-2007" left-pinned value on Pivot
	Then following values are displayed for "Empty" column on Pivot
	| Value1      | Value2 |
	| BCLABS-2007 | GREEN  |
	| 87          | GREEN  |
	| 86          | GREEN  |
	| 20          | GREEN  |
	| 9           | IGNORE |
	| 3           | GREEN  |
	| 2           | GREEN  |
	| 0           | GREEN  |

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForUsers
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	| Floor     |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Country" filter
	When User select "Equals" Operator value
	When User enters "Scotland" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User clicks Save filter button
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "Exchange Tower" left-pinned value on Pivot
	Then following values are displayed for "Scotland" column on Pivot
	| Value1         | Value2  |
	| Exchange Tower | UNKNOWN |
	| 2              | RED     |
	| 3              | RED     |
	| 4              | UNKNOWN |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForDevices
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Country   |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns |
	| Import  |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "Empty" left-pinned value on Pivot
	Then following values are displayed for "A01 SMS (Spoof)" column on Pivot
	| Value1          | Value2 |
	| Empty           | AMBER  |
	| A01 SMS (Spoof) | AMBER  |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_ApplicationsLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForApplications
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Vendor    |
	And User selects the following Columns on Pivot:
	| Columns                                                              |
	| UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Empty          |
	| NOT APPLICABLE |
	| STARTED        |

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_MailboxesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForMailboxes
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups        |
	| Evergreen Bucket |
	And User selects the following Columns on Pivot:
	| Columns                                              |
	| EmailMigra: Pre-Migration \ Infrastructure Readiness |
	And User selects the following Values on Pivot:
	| Values           |
	| Owner Compliance |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	And data in left-pinned column is sorted in ascending order by default for the Pivot
	Then Empty value is not displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName           |
	| Empty                |
	| INFRASTRUCTURE READY |