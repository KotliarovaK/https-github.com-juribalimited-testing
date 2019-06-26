Feature: UpdateTeam
	Update Team

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11761 @DAS12999 @DAS13199 @Teams @Delete_Newly_Created_Team
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterUpdatingTeamDescriptionField
	When User creates new Team via api
	| TeamName  | Description | IsDefault |
	| TestTeam9 | test        | false     |
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "TestTeam9" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User clicks "Team Settings" tab
	And User enters "" in the Team Description field
	Then Update Team button is disabled
	When User enters " " in the Team Description field
	Then Update Team button is disabled
	When User enters "testTeamtest" in the Team Description field
	And User clicks Update Team button
	Then Success message is displayed and contains "The team was successfully updated" text
	And There are no errors in the browser console
	When User clicks refresh button in the browser
	When User enters "" in the "Team Name" field
	Then Update Team button is disabled
	When User enters " " in the "Team Name" field
	Then Update Team button is disabled
	When User enters "NewTeamName" in the "Team Name" field
	And User clicks Update Team button
	Then Success message is displayed and contains "The team was successfully updated" text
	And There are no errors in the browser console