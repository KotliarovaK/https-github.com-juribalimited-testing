@retry:1
Feature: BaseDashboardPage
	Runs Base Dashboard Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11656
Scenario Outline: EvergreenJnr_AllList_CheckThatColumnHeaderFontWidthConformsToDesign
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	And Appropriate header font weight is displayed
	Then "v5.2.3.0" Application version is displayed

Examples: 
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11618
Scenario Outline: EvergreenJnr_AllList_CheckDefaultSortOrderOnTheLists
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	Then data in the table is sorted by "<ColumnName>" column in ascending order by default

Examples: 
	| ListName     | ColumnName    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11988
Scenario Outline: EvergreenJnr_AllList_CheckThatSaveListFunctionIsAvailableAfterSortingAColumn
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	Then Save to New Custom List element is displayed

Examples: 
	| ListName     | ColumnName    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11895
Scenario: EvergreenJnr_AllList_CheckThatNoConsoleErrorsAreDisplayedAfterQuicklyNavigateBetweenMainTabs
	When User quickly navigate to "Devices" on the left-hand menu
	And User quickly navigate to "Users" on the left-hand menu
	And User quickly navigate to "Applications" on the left-hand menu
	And User quickly navigate to "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS12174
Scenario: EvergreenJnr_DevicesList_CheckThatURLsAreUpdatedAfterAddingSortingAndColumns
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	Then Ascending order sorted on "Hostname" column is displayed in URL
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName            |
	| Owner Cost Centre     |
	| ComputerSc: In Scope  |
	| Windows7Mi: Object ID |
	Then "Cost Centre" column is added to URL on "Devices" page
	And "ComputerSc: In Scope" column is added to URL on "Devices" page
	And "Windows7Mi: Object ID" column is added to URL on "Devices" page
	When User navigates to the "All Devices" list
	Then default URL is displayed on "Devices" page

@Evergreen @Users @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS12174 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatURLsAreUpdatedAfterAddingSortingAndFilters
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" column is added to URL on "Users" page
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	Then Appropriate filter is added to URL
	When User navigates to the "All Users" list
	Then default URL is displayed on "Users" page
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Babel(Engl: Readiness" filter where type is "Equals" with added column and "Blue" Lookup option
	Then Appropriate filter is added to URL