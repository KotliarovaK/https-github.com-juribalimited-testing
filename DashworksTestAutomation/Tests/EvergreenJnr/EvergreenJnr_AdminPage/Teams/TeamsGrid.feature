Feature: TeamsGrid
	Teams Grid

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13000 @DAS13632 @DAS13602 @DAS17123 @Teams @Do_Not_Run_With_Teams @Set_Default_Team @Do_Not_Run_With_Buckets @Cleanup
#Temporary commented this tags just to fin out the reason of fail
#@Do_Not_Run_With_Buckets @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatUserCantRemoveDefaultTeamOnAdminPage
	When User creates new Team via api
	| TeamName            | Description | IsDefault |
	| testDASTeam_default | test_team   | true      |
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "testDASTeam_default" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then 'You cannot delete the default team' text is displayed on inline tip banner
	When User close message on the Admin page
	When User creates new Team via api
	| TeamName           | Description | IsDefault |
	| NewDefaulTeam_Test | 12894587454 | true      |
	And User clicks Refresh button on the Admin page
	And User enters "testDASTeam_default" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	When User clicks 'DELETE' button on inline tip banner
	Then 'The selected team has been deleted, and their buckets reassigned' text is displayed on inline success banner