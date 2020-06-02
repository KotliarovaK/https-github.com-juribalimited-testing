Feature: PivotPart4
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForApplications
	When User clicks 'Applications' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Vendor      |
	| Application |
	When User selects the following Columns on Pivot:
	| Columns        |
	| Inventory Site |
	When User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks the Filters button
	When User add "Vendor" filter where type is "Equals" without added column and following value:
	| Values |
	| Altera |
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	When User clicks 'RUN PIVOT' button 
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
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Import      |
	| Email Count |
	When User selects the following Columns on Pivot:
	| Columns |
	| City    |
	When User selects the following Values on Pivot:
	| Values           |
	| Owner Compliance |
	When User selects aggregate function "Severity" on Pivot
	When User clicks 'RUN PIVOT' button 
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
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	| Floor     |
	When User selects the following Columns on Pivot:
	| Columns |
	| Country |
	When User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks the Filters button
	When User add "Country" filter where type is "Equals" without added column and "Scotland" Lookup option
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "Exchange Tower" left-pinned value on Pivot
	Then following values are displayed for "Scotland" column on Pivot
	| Value1         | Value2  |
	| Exchange Tower | UNKNOWN |
	| 2              | RED     |
	| 3              | RED     |
	| 4              | UNKNOWN |