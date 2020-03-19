Feature: TeamDetails
	Team Details

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11944 @Teams @Do_Not_Run_With_Projects @Do_Not_Run_With_Teams
Scenario: EvergreenJnr_AdminPage_CheckSelectedRowsCountDisplayingOnTeamsGrids
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Teams' left menu item
	And User selects all rows on the grid
	Then Rows counter shows more than "2794" found rows of all rows
	When User enters "IB Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User selects all rows on the grid
	Then User sees "7" of "7" rows selected label
	When User navigates to the 'Buckets' left menu item
	When User enters "Evergreen Bucket" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	Then User sees "3" rows in grid

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12375 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatPanelOfAvailableMemberslIsExpandedByDefault
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "K-Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then Page with 'K-Team' header is displayed to user
	When User clicks 'ADD MEMBERS' button
	Then Panel of available members is displayed to the user