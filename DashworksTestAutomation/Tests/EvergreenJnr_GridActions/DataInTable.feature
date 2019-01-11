@retry:1
Feature: DataInTable
	Check that data is not duplicated in the tables. This test will check just
	first 2000 records. No need to check more as this very time consiming process
	And original bug was reproducible after firs 1000 results

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_GridActions @BaseDashboardPage @DAS10871
Scenario Outline: EvergreenJnr_AllLists_CheckDataIsNotDuplicatedInTableDuringScrolling
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When '<ColumnName>' Column Name is entered into the search box and the selection is clicked
	Then All data is unique in the '<ColumnName>' column

	Examples:
	| ListName     | ColumnName      |
	| Applications | Application Key |
	| Mailboxes    | Mailbox Key     |
	| Devices      | Device Key      |
	#| Users        | User Key        |