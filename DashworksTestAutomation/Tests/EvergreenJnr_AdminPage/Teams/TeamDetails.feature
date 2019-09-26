Feature: TeamDetails
	Team Details

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11944 @Teams
Scenario: EvergreenJnr_AdminPage_CheckSelectedRowsCountDisplayingOnTeamsGrids
	When User clicks 'Admin' on the left-hand menu
	And User clicks "Teams" link on the Admin page
	And User selects all rows on the grid
	Then Rows counter shows more than "2794" found rows of all rows
	When User enters "IB Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User selects all rows on the grid
	Then User sees "8" of "8" rows selected label
	When User navigates to the 'Buckets' left menu item
	And User selects all rows on the grid
	Then User sees "7" of "7" rows selected label

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12375 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatPanelOfAvailableMemberslIsExpandedByDefault
	When User clicks 'Admin' on the left-hand menu
	Then "Admin" list should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "K-Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "K-Team" team details is displayed to the user
	When User clicks Add Members button on the Teams page
	Then Panel of available members is displayed to the user