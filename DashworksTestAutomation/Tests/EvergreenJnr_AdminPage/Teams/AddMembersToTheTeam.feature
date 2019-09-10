Feature: AddMembersToTheTeam
	Add Members To The Team

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user
	
@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS13254 @DAS13172 @Cleanup @Teams @Do_Not_Run_With_Teams
Scenario: EvergreenJnr_AdminPage_AddingIndividualAndMembersFromAnotherTeam
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	#Then Counter shows "2,794" found rows
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User clicks the "CANCEL" Action button
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam8" in the "Team Name" field
	And User enters "test" in the Team Description field
	When User selects "Add members from another team" in the Add Members dropdown
	Then There are no errors in the browser console
	When User selects following Objects to the Project
	| Objects                |
	| Migration Phase 3 Team |
	| Retail Team            |
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User enters "My Team" text in the Search field for "Team" column
	Then 'TRUE' content is displayed in the 'Default' column
	When User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default team" text is displayed on the Admin page
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam88" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks Default Team checkbox
	When User selects "Add individual members" in the Add Members dropdown
	And User selects following Objects
	| Objects           |
	| automation_admin1 |
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User enters "My Team" text in the Search field for "Team" column
	Then 'FALSE' content is displayed in the 'Default' column
	When User clicks content from "Team" column
	And User navigates to the 'Team Settings' left menu item
	And User clicks Default Team checkbox
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The team was successfully updated" text
	When User click on Back button
	When User enters "TestTeam88" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message is displayed and contains "The selected team has been deleted, and their buckets reassigned" text
	When User enters "TestTeam8" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message is displayed and contains "The selected team has been deleted, and their buckets reassigned" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13254 @DAS13421 @Teams @Cleanup
Scenario: EvergreenJnr_AdminPage_AddingMembersToTheTeam
	When User creates new Team via api
	| TeamName  | Description | IsDefault |
	| TestTeam7 | test        | false     |
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "TestTeam7" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User navigates to the 'Team Members' left menu item
	When User clicks the "ADD MEMBERS" Action button
	And User adds following Objects from list
	| Objects           |
	| automation_admin1 |
	| automation_admin2 |
	| automation_admin3 |
	| eugene            |
	Then Success message is displayed and contains "The selected users have been added" text
	When User click on "Username" column header on the Admin page
	Then data in table is sorted by "Username" column in ascending order on the Admin page
	When User click on "Username" column header on the Admin page
	Then data in table is sorted by "Username" column in descending order on the Admin page
	When User click on "Full Name" column header on the Admin page
	Then data in table is sorted by "Full Name" column in ascending order on the Admin page
	When User click on "Full Name" column header on the Admin page
	Then data in table is sorted by "Full Name" column in descending order on the Admin page
	When User enters "Admin" text in the Search field for "Full Name" column
	Then Rows counter shows "3" of "4" rows
	When User enters "automation_admin1" text in the Search field for "Username" column
	Then Rows counter shows "1" of "4" rows
	When User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User removes selected members
	Then Success message is displayed and contains "The selected user has been removed" text
	When User enters "automation_admin2" text in the Search field for "Username" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Add to another team" in the Actions
	And User clicks the "CONTINUE" Action button
	And User selects "Team 1" team to add
	And User clicks the "ADD USERS" Action button
	Then Success message is displayed and contains "The selected user was added to team Team 1" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12326 @DAS16130 @Teams @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatSelectANewTeamDropdownAreWorkingCorrectly
	When User creates new Team via api
	| TeamName | Description | IsDefault |
	| DAS12326 | 12326       | false     |
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "DAS12326" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User navigates to the 'Team Members' left menu item
	And User clicks the "ADD MEMBERS" Action button
	And User adds following Objects from list
	| Objects           |
	| automation_admin1 |
	| automation_admin2 |
	| automation_admin3 |
	Then Success message is displayed and contains "The selected users have been added" text
	When User enters "admin1" text in the Search field for "Username" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Add to another team" in the Actions
	And User clicks the "CONTINUE" Action button
	And User type "M" search criteria in Select a new Team field
	Then following Team are displayed in Select a new Team drop-down:
	| Options                |
	| Migration Phase 2      |
	| Migration Phase 3 Team |
	| My Team                |