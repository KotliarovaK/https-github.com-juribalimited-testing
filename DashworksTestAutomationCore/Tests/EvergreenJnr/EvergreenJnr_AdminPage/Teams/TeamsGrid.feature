Feature: TeamsGrid
	Teams Grid

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13000 @DAS13632 @DAS13602 @DAS17123 @Teams @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckMessageWhenDeletingTeam
	When User creates new Team via api
	| TeamName     | Description | IsDefault |
	| NewTeam_Test | 12894587454 | false     |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "NewTeam_Test" text in the Search field for "Team" column
	When User selects all rows on the grid
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then 'The selected team will be permanently deleted, users which are members of this team will not be deleted, do you want to proceed?' text is displayed on inline tip banner
	When User clicks 'DELETE' button on inline tip banner
	Then 'The selected team has been deleted, and their buckets reassigned' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13000 @DAS13632 @DAS13602 @DAS17123 @Teams @Do_Not_Run_With_Teams @Set_Default_Team @Do_Not_Run_With_Buckets @Do_Not_Run_With_Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultTeamUpdatesToFalseAfterCreatingNewDefaultTeam
	When User creates new Team via api
	| TeamName             | Description | IsDefault |
	| das13000test_default | test_team   | true      |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "das13000test_default" text in the Search field for "Team" column
	Then 'TRUE' content is displayed in the 'Default' column
	When User creates new Team via api
	| TeamName              | Description | IsDefault |
	| das15000test_default2 | 12894587454 | true      |
	When User clicks Refresh button on the Admin page
	When User enters "das13000test_default" text in the Search field for "Team" column
	Then 'FALSE' content is displayed in the 'Default' column