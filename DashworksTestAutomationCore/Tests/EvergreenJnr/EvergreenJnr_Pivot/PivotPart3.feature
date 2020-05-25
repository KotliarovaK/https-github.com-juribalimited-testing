Feature: PivotPart3
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14378 @DAS13864 @DAS13786 @DAS13867 @DAS15376
Scenario: EvergreenJnr_DevicesList_CheckThatTaskValuesAsPivotColumnsAreDisplayedInTheCorrectOrder
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns                                 |
	| Windows7Mi: Pre-Migration \ Target Date |
	And User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	And User clicks 'RUN PIVOT' button 
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
	Then 'All Mailboxes' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups             |
	| MailboxEve: In Scope  |
	| MailboxEve: Readiness |
	And User selects the following Columns on Pivot:
	| Columns |
	| City    |
	And User selects the following Values on Pivot:
	| Values                |
	| MailboxEve: Readiness |
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "TRUE" left-pinned value on Pivot
	Then following values are displayed for "London" column on Pivot
	| Value1       | Value2       |
	| TRUE         | OUT OF SCOPE |
	| OUT OF SCOPE | OUT OF SCOPE |
	| PURPLE       | PURPLE       |
	| NONE         | NONE         |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Last Logon Date" filter where type is "Between" without added column and Date options
	| StartDateInclusive | EndDateInclusive |
	| 25 Apr 2018        | 02 May 2018      |
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555 @DAS13786 @DAS13771 @DAS15376 @DAS17669
Scenario: EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForApplications
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
	| Values                           |
	| ComputerSc: Target App Readiness |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Vendor" filter
	When User select "Equals" Operator value
	When User enters "Microsoft" text in Search field at selected Filter
	When User clicks Save filter button
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
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

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555
Scenario: EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForUsers
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
	| Values                            |
	| ComputerSc: Application Readiness |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Country" filter
	When User select "Equals" Operator value
	When User enters "USA" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User clicks Save filter button
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "101 Hudson Street" left-pinned value on Pivot
	Then following values are displayed for "USA" column on Pivot
	| Value1            | Value2 |
	| 101 Hudson Street | GREEN  |
	| 20                | GREEN  |
	| 21                | GREEN  |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555 @DAS17669
Scenario: EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForDevices
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Country   |
	| City      |
	And User selects the following Columns on Pivot:
	| Columns      |
	| Manufacturer |
	And User selects the following Values on Pivot:
	| Values          |
	| 2004: Readiness |
	When User selects aggregate function "Severity" on Pivot
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User expanded "USA" left-pinned value on Pivot
	Then following values are displayed for "Asus" column on Pivot
	| Value1      | Value2	|
	| USA         | BLOCKED |
	| Los Angeles | GREEN	|
	| San Diego   | BLOCKED |