Feature: Teams
	Runs Teams related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12375 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatPanelOfAvailableMemberslIsExpandedByDefault
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "K-Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "K-Team" team details is displayed to the user
	When User clicks Add Members button on the Teams page
	Then Panel of available members is displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforTeamsList
	When User clicks Admin on the left-hand menu
	And User clicks "Teams" link on the Admin page
	And User enters "K-Team" text in the Search field for "Team" column
	Then Counter shows "2" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @DAS12999 @DAS13199 @DAS12846 @DAS13602 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedTeamUsingTheSpaceAsAFirstSymbol
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "99770" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks the "CREATE TEAM" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	Then "99770" team details is displayed to the user
	When User clicks "Team Settings" tab
	And User clicks Default Team checkbox
	And User clicks the "UPDATE TEAM" Action button
	Then Success message is displayed and contains "The team was successfully updated" text
	When User clicks "Teams" navigation link on the Admin page
	When User enters "99770" text in the Search field for "Team" column
	When User clicks content from "Team" column
	When User clicks "Team Settings" tab
	Then Default Team checkbox is not active
	When User clicks "Teams" navigation link on the Admin page
	When User enters "99770" text in the Search field for "Team" column
	And User selects all rows on the grid
	When User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default team" text is displayed on the Admin page
	When User clicks Reset Filters button on the Admin page
	When User enters "My Team" text in the Search field for "Team" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Team" column
	And User clicks "Team Settings" tab
	And User clicks Default Team checkbox
	And User clicks the "UPDATE TEAM" Action button
	Then Success message is displayed and contains "The team was successfully updated" text
	When User clicks "Teams" navigation link on the Admin page
	When User enters "My Team" text in the Search field for "Team" column
	Then "TRUE" value is displayed for Default column
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters " 99770" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks the "CREATE TEAM" Action button
	Then Error message with "A team already exists with this name" text is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS13254 @DAS13172 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_AddingIndividualAndMembersFromAnotherTeam
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	Then Counter shows "2,794" found rows
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
	When User selects following Objects
	| Objects                |
	| Migration Phase 3 Team |
	| Retail Team            |
	And User clicks the "CREATE TEAM" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User enters "My Team" text in the Search field for "Team" column
	Then "TRUE" value is displayed for Default column
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
	And User clicks the "CREATE TEAM" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User enters "My Team" text in the Search field for "Team" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Team" column
	And User clicks "Team Settings" tab
	And User clicks Default Team checkbox
	And User clicks the "UPDATE TEAM" Action button
	Then Success message is displayed and contains "The team was successfully updated" text
	When User click on Back button
	When User enters "TestTeam8" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message is displayed and contains "The selected teams have been deleted, and their buckets reassigned" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13254 @DAS13421 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_AddingMembersToTheTeam
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam7" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks the "CREATE TEAM" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	When User selects "Team Members" tab on the Team details page
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
	Then Counter shows "3" found rows
	When User enters "automation_admin1" text in the Search field for "Username" column
	Then Counter shows "1" found rows
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
	When User click on Back button
	And User enters "TestTeam7" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11944 @Teams
Scenario: EvergreenJnr_AdminPage_CheckSelectedRowsCountDisplayingOnTeamsGrids
	When User clicks Admin on the left-hand menu
	And User clicks "Teams" link on the Admin page
	And User selects all rows on the grid
	Then User sees "2794" of "2794" rows selected label
	When User enters "IB Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User selects all rows on the grid
	Then User sees "2" of "2" rows selected label
	When User clicks "Buckets" tab
	And User selects all rows on the grid
	Then User sees "6" of "6" rows selected label

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13421 @DAS12788 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_AddingBucketsToTheTeam
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam5" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks the "CREATE TEAM" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	When User selects "Buckets" tab on the Team details page
	When User clicks the "ADD BUCKETS" Action button
	Then Add Buckets page is displayed to the user
	When User expands "Email Migration" project to add bucket
	And User adds following Objects from list
	| Objects   |
	| Glasgow   |
	| Frankfurt |
	Then Success message is displayed and contains "The selected buckets have been added" text
	Then There are no errors in the browser console
	When User clicks the "ADD BUCKETS" Action button
	When User expands "Windows 7 Migration (Computer Scheduled Project)" project to add bucket
	And User adds following Objects from list
	| Objects     |
	| Nottingham  |
	| Southampton |
	Then Success message is displayed and contains "The selected buckets have been added" text
	Then There are no errors in the browser console
	When User click on "Bucket" column header on the Admin page
	Then data in table is sorted by "Bucket" column in ascending order on the Admin page
	When User click on "Bucket" column header on the Admin page
	Then data in table is sorted by "Bucket" column in descending order on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in ascending order on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in descending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in ascending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Users" column in descending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Mailboxes" column in ascending order on the Admin page
	When User click on "Mailboxes" column header on the Admin page
	Then numeric data in table is sorted by "Mailboxes" column in descending order on the Admin page
	When User click on "Mailboxes" column header on the Admin page
	Then numeric data in table is sorted by "Mailboxes" column in ascending order on the Admin page
	#When User have opened Column Settings for "Default" column
	#And User clicks Filter button in the Column Settings panel on the Teams Page
	When User clicks String Filter button for "Default" column on the Admin page
	When User clicks "False" checkbox from boolean filter on the Admin page
	Then Counter shows "0" found rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Email Migration" checkbox from String Filter with item list on the Admin page
	Then Counter shows "2" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Glasgow" text in the Search field for "Bucket" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "20" text in the Search field for "Devices" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters ">20" text in the Search field for "Users" column
	Then Counter shows "2" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "100" text in the Search field for "Mailboxes" column
	Then Counter shows "0" found rows
	When User clicks Reset Filters button on the Admin page
	Then There are no errors in the browser console
	When User enters "Nottingham" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Change Team" in the Actions
	And User clicks the "CONTINUE" Action button
	Then Change Team page is displayed to the user
	When User selects "Team 10" in the Team dropdown
	And User clicks the "CHANGE" Action button
	Then Success message is displayed and contains "The selected bucket has been reassigned to the selected team" text
	Then There are no errors in the browser console
	When User click on Back button
	When User enters "TestTeam5" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks the "DELETE" Action button
	Then Reassign Buckets page is displayed to the user
	When User selects "Team 0" in the Select a team dropdown
	And User clicks the "DELETE TEAM" Action button
	Then Success message is displayed and contains "The selected team has been deleted, and their buckets reassigned" text
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11761 @DAS12999 @DAS13199 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterUpdatingTeamDescriptionField
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam9" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks the "CREATE TEAM" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	Then "TestTeam9" team details is displayed to the user
	When User clicks "Team Settings" tab
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
	Then Delete "NewTeamName" Team in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11763 @DAS12742 @DAS12760 @DAS11912 @DAS12772 @Buckets @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeletingBucketFromBucketsSection
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User have opened Column Settings for "Members" column
	And User clicks Filter button on the Column Settings panel
	When User clicks the  filter type dropdown on the Column Settings panel
	Then following Values are displayed in the filter type dropdown
	| Values                |
	| Equals                |
	| Not Equal             |
	| Less than or equal    |
	| Less than             |
	| Greater than          |
	| Greater than or equal |
	When User enters "IB Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "IB Team" team details is displayed to the user
	When User clicks "Buckets" tab
	And User enters "Group IB Team" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009 @DAS12999 @DAS13471 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForTeams
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User have opened Column Settings for "Team" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User enters "Administrative Team" text in the Search field for "Team" column
	Then Counter shows "1" found rows
	When User clicks content from "Team" column
	Then "Administrative Team" team details is displayed to the user
	When User have opened Column Settings for "Username" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User click on Back button
	#And User have opened Column Settings for "Default" column
	#And User clicks Filter button in the Column Settings panel on the Teams Page
	When User clicks String Filter button for "Default" column on the Admin page
	When User clicks "True" checkbox from boolean filter on the Admin page
	Then Counter shows "2,793" found rows
	Then There are no errors in the browser console
	When User clicks Reset Filters button on the Admin page
	Then Content is present in the table on the Admin page
	When User enters "Team 10" text in the Search field for "Description" column
	Then Counter shows "111" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "0" text in the Search field for "Evergreen Buckets" column
	Then Counter shows "0" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "5" text in the Search field for "Project Buckets" column
	Then Counter shows "2" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "2" text in the Search field for "Members" column
	Then Counter shows "5" found rows
	When User clicks Reset Filters button on the Admin page
	And User click on "Team" column header on the Admin page
	#Remove hash after fix sort order
	#Then data in table is sorted by "Team" column in ascending order on the Admin page
	When User click on "Team" column header on the Admin page
	Then data in table is sorted by "Team" column in descending order on the Admin page
	When User click on "Description" column header on the Admin page
	Then data in table is sorted by "Description" column in ascending order on the Admin page
	When User click on "Description" column header on the Admin page
	Then data in table is sorted by "Description" column in descending order on the Admin page
	When User click on "Members" column header on the Admin page
	Then numeric data in table is sorted by "Members" column in descending order on the Admin page
	When User click on "Members" column header on the Admin page
	Then numeric data in table is sorted by "Members" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in descending order on the Admin page
	When User click on "Evergreen Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Evergreen Buckets" column in descending order on the Admin page
	When User click on "Evergreen Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Evergreen Buckets" column in ascending order on the Admin page
	When User click on "Project Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Project Buckets" column in descending order on the Admin page
	When User click on "Project Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Project Buckets" column in ascending order on the Admin page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS11747 @DAS13471 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyTeamName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters " " in the "Team Name" field
	And User enters "test" in the Team Description field
	Then Create Team button is disabled
	When User enters "TestTeam" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks the "CREATE TEAM" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam" in the "Team Name" field
	And User enters "test" in the Team Description field
	And User clicks the "CREATE TEAM" Action button
	Then Error message with "A team already exists with this name" text is displayed
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13000 @DAS13632 @DAS13602 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_ChecksThatUserCantRemoveDefaultTeamOnAdminPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "000Team13000" in the "Team Name" field
	And User enters "13000" in the Team Description field
	And User clicks Default Team checkbox
	And User clicks the "CREATE TEAM" Action button
	And User enters "000Team13000" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "You cannot delete the default team" text is displayed on the Admin page
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "001Team13000" in the "Team Name" field
	And User enters "13000" in the Team Description field
	And User clicks Default Team checkbox
	And User clicks the "CREATE TEAM" Action button
	And User enters "000Team13000" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected team has been deleted, and their buckets reassigned" text
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User clicks "Team Settings" tab
	And User clicks Default Team checkbox
	And User clicks the "UPDATE TEAM" Action button
	Then Success message is displayed and contains "The team was successfully updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12326 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_ChecksThatSelectANewTeamDropdownAreWorkingCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "DAS12326" in the "Team Name" field
	And User enters "12326" in the Team Description field
	And User clicks the "CREATE TEAM" Action button
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	And User selects "Team Members" tab on the Team details page
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
	When User type "M" search criteria in Select a new Team field
	Then following Team are displayed in Select a new Team drop-down:
	| Options                |
	| Migration Phase 2      |
	| Migration Phase 3 Team |
	| My Team                |
	When User click on Back button
	When User enters "DAS12326" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message is displayed and contains "The selected team has been deleted, and their buckets reassigned" text