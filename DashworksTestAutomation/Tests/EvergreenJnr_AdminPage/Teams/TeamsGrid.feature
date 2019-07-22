Feature: TeamsGrid
	Teams Grid

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Not_Run added 14 Jun 2019. remove after fix of DAS-17123
@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13000 @DAS13632 @DAS13602 @DAS17123 @Teams @Do_Not_Run_With_Teams @Save_Default_Team @Set_Default_Team @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatUserCantRemoveDefaultTeamOnAdminPage
	When User creates new Team via api
	| TeamName     | Description | IsDefault |
	| DASTeam13000 | 13000       | true      |
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "DASTeam13000" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "You cannot delete the default team" text is displayed on the Admin page
	When User close message on the Admin page
	When User creates new Team via api
	| TeamName      | Description | IsDefault |
	| DAS1Team13000 | 13000       | true      |
	And User clicks Refresh button on the Admin page
	And User enters "DASTeam13000" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected team has been deleted, and their buckets reassigned" text