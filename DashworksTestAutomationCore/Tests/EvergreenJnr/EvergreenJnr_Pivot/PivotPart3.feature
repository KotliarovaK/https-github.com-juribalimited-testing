Feature: PivotPart3
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14378 @DAS13864 @DAS13786 @DAS13867 @DAS15376
Scenario: EvergreenJnr_DevicesList_CheckThatTaskValuesAsPivotColumnsAreDisplayedInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	When User selects the following Columns on Pivot:
	| Columns                                 |
	| Windows7Mi: Pre-Migration \ Target Date |
	When User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then date in the column headers is sorted in correct order for the Pivot
	Then data in left-pinned column is sorted in ascending order by default for the Pivot
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Last Logon Date" filter where type is "Between" without added column and Date options
	| StartDateInclusive | EndDateInclusive |
	| 25 Apr 2018        | 02 May 2018      |
	#DAS-15376
	#Then "(Owner Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555 @DAS15376
Scenario: EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForMailboxes
	When User clicks 'Mailboxes' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups             |
	| MailboxEve: In Scope  |
	| MailboxEve: Readiness |
	When User selects the following Columns on Pivot:
	| Columns |
	| City    |
	When User selects the following Values on Pivot:
	| Values                |
	| MailboxEve: Readiness |
	When User selects aggregate function "Severity" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "TRUE" left-pinned value on Pivot
	Then following values are displayed for "London" column on Pivot
	| Value1       | Value2       |
	| TRUE         | OUT OF SCOPE |
	| OUT OF SCOPE | OUT OF SCOPE |
	| PURPLE       | PURPLE       |
	| NONE         | NONE         |
	When User clicks the Filters button
	When User add "Last Logon Date" filter where type is "Between" without added column and Date options
	| StartDateInclusive | EndDateInclusive |
	| 25 Apr 2018        | 02 May 2018      |
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555 @DAS13786 @DAS13771 @DAS15376 @DAS17669
Scenario: EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForApplications
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
	| Values                           |
	| ComputerSc: Target App Readiness |
	When User clicks the Filters button
	When User add "Vendor" filter where type is "Equals" without added column and following value:
	| Values    |
	| Microsoft |
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "Microsoft" left-pinned value on Pivot
	Then following values are displayed for "TierA Site01" column on Pivot
	| Value1                                                     | Value2     |
	| Microsoft                                                  | BLUE       |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) | GREEN      |
	| 0036 - Microsoft Access 97 SR-2 English                    | LIGHT BLUE |
	| 0047 - Microsoft Access 97 SR-2 Francais                   | GREEN      |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Between" with following Date options and Associations:
	| StartDateInclusive | EndDateInclusive | Association                             |
	| 25 Apr 2018        | 02 May 2018      | Has used app                            |
	#DAS-15376
	#Then "(Vendor = Microsoft AND User Last Logon Date between (2018-04-25, 2018-05-02) ASSOCIATION = (has used app))" text is displayed in filter container