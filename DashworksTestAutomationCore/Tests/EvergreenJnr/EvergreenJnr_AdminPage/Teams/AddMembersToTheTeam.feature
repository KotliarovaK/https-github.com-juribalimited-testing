Feature: AddMembersToTheTeam
	Add Members To The Team

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user
	
@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS13254 @DAS13172 @Cleanup @Teams @Do_Not_Run_With_Teams @Do_Not_Run_With_Buckets @Set_Default_Team
Scenario: EvergreenJnr_AdminPage_AddingIndividualAndMembersFromAnotherTeam
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User clicks 'CREATE TEAM' button
	Then Page with 'Create Team' subheader is displayed to user
	When User clicks 'CANCEL' button
	Then Page with 'Teams' header is displayed to user
	When User clicks 'CREATE TEAM' button
	Then Page with 'Create Team' subheader is displayed to user
	When User enters 'TestTeam8' text to 'Team Name' textbox
	And User enters "test" in the Team Description field
	When User selects 'Add members from another team' in the 'Add Members (Optional)' dropdown
	Then There are no errors in the browser console
	When User selects following Objects from the expandable multiselect
	| Objects                |
	| Migration Phase 3 Team |
	| Retail Team            |
	And User clicks 'CREATE' button 
	Then 'The team has been created' text is displayed on inline success banner
	When User enters "My Team" text in the Search field for "Team" column
	Then 'TRUE' content is displayed in the 'Default' column
	When User selects all rows on the grid
	Then 'Actions' dropdown is displayed
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then 'You cannot delete the default team' text is displayed on inline tip banner
	When User clicks 'CREATE TEAM' button 
	Then Page with 'Create Team' subheader is displayed to user
	When User enters 'TestTeam88' text to 'Team Name' textbox
	And User enters "test" in the Team Description field
	And User clicks Default Team checkbox
	When User selects 'Add individual members' in the 'Add Members (Optional)' dropdown
	And User selects following Objects from the expandable multiselect
	| Objects           |
	| automation_admin1 |
	And User clicks 'CREATE' button 
	Then 'The team has been created' text is displayed on inline success banner
	When User enters "My Team" text in the Search field for "Team" column
	Then 'FALSE' content is displayed in the 'Default' column
	When User clicks content from "Team" column
	And User navigates to the 'Team Settings' left menu item
	And User clicks Default Team checkbox
	And User clicks 'UPDATE' button 
	Then 'The team was successfully updated' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13254 @DAS13421 @Teams @Cleanup
Scenario: EvergreenJnr_AdminPage_AddingMembersToTheTeam
	When User creates new Team via api
	| TeamName  | Description | IsDefault |
	| TestTeam7 | test        | false     |
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "TestTeam7" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User navigates to the 'Team Members' left menu item
	When User clicks 'ADD MEMBERS' button 
	And User selects following Objects from the expandable multiselect
	| Objects           |
	| automation_admin1 |
	| automation_admin2 |
	| automation_admin3 |
	| eugene            |
	And User clicks 'ADD USERS' button 
	Then 'The selected users have been added' text is displayed on inline success banner
	When User click on "Username" column header on the Admin page
	Then data in table is sorted by 'Username' column in ascending order
	When User click on "Username" column header on the Admin page
	Then data in table is sorted by 'Username' column in descending order
	When User click on "Full Name" column header on the Admin page
	Then data in table is sorted by 'Full Name' column in ascending order
	When User click on "Full Name" column header on the Admin page
	Then data in table is sorted by 'Full Name' column in descending order
	When User enters "Admin" text in the Search field for "Full Name" column
	Then Rows counter shows "3" of "4" rows
	When User enters "automation_admin1" text in the Search field for "Username" column
	Then Rows counter shows "1" of "4" rows
	When User selects all rows on the grid
	Then 'Actions' dropdown is displayed
	When User selects 'Remove Members' in the 'Actions' dropdown
	When User clicks 'REMOVE' button
	Then inline warning banner is displayed
	When User clicks 'REMOVE' button on inline tip banner
	Then 'The selected user has been removed' text is displayed on inline success banner
	When User enters "automation_admin2" text in the Search field for "Username" column
	And User selects all rows on the grid
	And User selects 'Add to another team' in the 'Actions' dropdown
	And User clicks 'CONTINUE' button 
	When User selects 'Team 1' option from 'Select a new team' autocomplete without search
	And User clicks 'ADD USERS' button 
	Then 'The selected user was added to team Team 1' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12326 @DAS16130 @Teams @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatSelectANewTeamDropdownAreWorkingCorrectly
	When User creates new Team via api
	| TeamName | Description | IsDefault |
	| DAS12326 | 12326       | false     |
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "DAS12326" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User navigates to the 'Team Members' left menu item
	And User clicks 'ADD MEMBERS' button 
	And User selects following Objects from the expandable multiselect
	| Objects           |
	| automation_admin1 |
	| automation_admin2 |
	| automation_admin3 |
	And User clicks 'ADD USERS' button 
	Then 'The selected users have been added' text is displayed on inline success banner
	When User enters "admin1" text in the Search field for "Username" column
	And User selects all rows on the grid
	And User selects 'Add to another team' in the 'Actions' dropdown
	And User clicks 'CONTINUE' button 
	Then only below options are displayed in 'Select a new team' autocomplete after search by 'M' text
	| Options                |
	| Migration Phase 2      |
	| Migration Phase 3 Team |
	| My Team                |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS18614 @Cleanup @Teams @Do_Not_Run_With_Teams
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorAppearsAfterCreatingTeamHavingChosenMembersInNotSelectedAddMembersOption
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User clicks 'CREATE TEAM' button 
	Then Page with 'Create Team' subheader is displayed to user
	When User enters 'TestTeam18614' text to 'Team Name' textbox
	When User enters "test" in the Team Description field
	When User selects 'Add members from another team' in the 'Add Members (Optional)' dropdown
	Then There are no errors in the browser console
	When User selects following Objects from the expandable multiselect
	| Objects   |
	| 2004 Team |
	When User selects 'Add individual members' in the 'Add Members (Optional)' dropdown
	Then There are no errors in the browser console
	Then Chips for 'Search' field are not displayed
	When User clicks 'CREATE' button 
	Then There are no errors in the browser console
	Then 'The team has been created' text is displayed on inline success banner