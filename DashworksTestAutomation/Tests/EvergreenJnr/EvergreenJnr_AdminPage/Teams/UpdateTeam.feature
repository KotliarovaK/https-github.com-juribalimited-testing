Feature: UpdateTeam
	Update Team

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11761 @DAS12999 @DAS13199 @Teams @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterUpdatingTeamDescriptionField
	When User creates new Team via api
	| TeamName  | Description | IsDefault |
	| TestTeam9 | test        | false     |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "TestTeam9" text in the Search field for "Team" column
	When User clicks content from "Team" column
	When User navigates to the 'Team Settings' left menu item
	When User enters '' text to 'Team Name' textbox
	When User enters 'TestTeam9' text to 'Team Name' textbox
	Then No error message is displayed for 'Team Name' field
	Then 'UPDATE' button is disabled
	When User enters " " in the Team Description field
	Then 'UPDATE' button is disabled
	When User enters "testTeamtest" in the Team Description field
	When User clicks 'UPDATE' button
	Then 'The team was successfully updated' text is displayed on inline success banner
	Then There are no errors in the browser console
	When User clicks refresh button in the browser
	When User enters '' text to 'Team Name' textbox
	Then 'UPDATE' button is disabled
	When User enters ' ' text to 'Team Name' textbox
	Then 'UPDATE' button is disabled
	When User enters 'NewTeamName' text to 'Team Name' textbox
	When User clicks 'UPDATE' button
	Then 'The team was successfully updated' text is displayed on inline success banner
	Then There are no errors in the browser console