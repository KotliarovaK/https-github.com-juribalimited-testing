Feature: CreateTeam
	Create Team

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS11747 @DAS13471 @Cleanup @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyTeamName
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User clicks 'CREATE TEAM' button 
	Then Page with 'Create Team' subheader is displayed to user
	When User enters " " in the "Team Name" field
	And User enters "test" in the Team Description field
	Then Create Team button is disabled
	When User enters "TestTeam" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks 'CREATE' button 
	Then Success message is displayed and contains "The team has been created" text
	When User clicks 'CREATE TEAM' button 
	Then Page with 'Create Team' subheader is displayed to user
	When User enters "TestTeam" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks 'CREATE' button 
	Then Error message with "A team already exists with this name" text is displayed
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @DAS12999 @DAS13199 @DAS12846 @DAS13602 @Teams @Do_Not_Run_With_Teams @Save_Default_Team @Set_Default_Team @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedTeamUsingTheSpaceAsAFirstSymbol
	When User creates new Team via api
	| TeamName | Description | IsDefault |
	| 99770    | test        | false     |
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "99770" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "99770" team details is displayed to the user
	When User navigates to the 'Team Settings' left menu item
	And User clicks Default Team checkbox
	And User clicks 'UPDATE' button 
	Then Success message is displayed and contains "The team was successfully updated" text
	When User clicks "Teams" navigation link on the Admin page
	When User enters "99770" text in the Search field for "Team" column
	When User clicks content from "Team" column
	When User navigates to the 'Team Settings' left menu item
	Then Default Team checkbox is not active
	When User clicks "Teams" navigation link on the Admin page
	When User enters "99770" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then Warning message with "You cannot delete the default team" text is displayed on the Admin page
	When User clicks Reset Filters button on the Admin page
	When User enters "My Team" text in the Search field for "Team" column
	Then 'FALSE' content is displayed in the 'Default' column
	When User clicks content from "Team" column
	And User navigates to the 'Team Settings' left menu item
	And User clicks Default Team checkbox
	And User clicks 'UPDATE' button 
	Then Success message is displayed and contains "The team was successfully updated" text
	When User clicks "Teams" navigation link on the Admin page
	When User enters "My Team" text in the Search field for "Team" column
	Then 'TRUE' content is displayed in the 'Default' column
	When User clicks 'CREATE TEAM' button 
	Then Page with 'Create Team' subheader is displayed to user
	When User enters " 99770" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks 'CREATE' button 
	Then Error message with "A team already exists with this name" text is displayed
	When User enters "99770" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button