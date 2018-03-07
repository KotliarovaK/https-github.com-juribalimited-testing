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