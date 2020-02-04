Feature: FiltersFunctionalityPart02
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @Evergreen_FiltersFeature @FilterFunctionality @DAS10977 @DAS12351
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserBackButtonForLookupFilters
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	When User have created "Equals" Lookup filter with column and "<FilterValue>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User perform search by "<ObjectName>"
	And User click content from "<ColumnName>" column
	Then User click back button in the browser
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "<Text>" is displayed in added filter info

Examples: 
	| ListName     | FilterName                                   | FilterValue            | RowsCount | ColumnName    | ObjectName              | Text                                                        |
	| Applications | Barry'sUse: Target App                       | Python 2.2a4 (SMS_GEN) | 1         | Application   | Python 2.2a4            | Barry'sUse: Target App is Python 2.2a4 (SMS_GEN)            |
	| Mailboxes    | EmailMigra: Migration \ BT/QMM Switch Status | Not Started            | 729       | Email Address | alex.cristea@juriba.com | EmailMigra: Migration \ BT/QMM Switch Status is Not Started |


@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS11560
Scenario: EvergreenJnr_DevicesList_CheckNumericFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "App Count (Installed)" filter where type is "Less than" without added column and following value:
	| Values |
	| 1      |
	Then "App Count (Installed) is less than 1" is displayed in added filter info
	Then "5,195" rows are displayed in the agGrid
