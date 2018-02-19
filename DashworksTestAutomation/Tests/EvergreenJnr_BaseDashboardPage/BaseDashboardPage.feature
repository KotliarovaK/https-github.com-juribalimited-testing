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
	Then Appropriate header font weight is displayed

Examples: 
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11951
Scenario Outline: EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order

	Examples: 
	| ListName     | ColumnName         |
	| Devices      | Hostname           |
	| Users        | Domain             |
	| Applications | Version            |
	| Mailboxes    | Owner Display Name |