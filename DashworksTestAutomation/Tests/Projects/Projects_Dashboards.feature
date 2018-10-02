Feature: Projects_Dashboards
	Runs Projects Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Projects @Projects_Dashboards @Dashboards @DAS12651
Scenario Outline: Projects_CheckThatDataInGroupWithApostrophesOnDashboardsPageIsDisplayedCorectly
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigates to the "<PageName>" page on Dashboards tab
	Then "<PageName>" page is displayed to the user
	When User select "Barry's User Project" Project on toolbar
	When User navigate to "Barry's Pilot Group 1" group
	Then content for the "Barry's Pilot Group 1" group is displayed correctly

Examples:
	| PageName           |
	| User Dashboard     |
	| Computer Dashboard |

@Evergreen @Projects @Projects_Dashboards @Dashboards @DAS13000 @Teams
Scenario: Projects_ChecksThatUserCantRemoveDefaultTeamOnSeniorPage
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Computer Scheduled Test (Jo)" Project
	And User navigate to "Teams" tab
	Then "My Team" Team have a default value 
	When User navigates to "My Team" Team
	And User navigate to "Details" page
	Then Default Team checkbox is checked and cannot be unchecked
	When User clicks "Cancel" button
	And User navigates to "Admin IT" Team
	And User navigate to "Details" page
	And User makes selected Team by default
	And User clicks "Update" button
	Then information message is displayed with "Team was successfully updated." text
	And Default Team checkbox is checked and cannot be unchecked
	When User clicks "Cancel" button
	And User navigates to "My Team" Team
	And User navigate to "Details" page
	And User makes selected Team by default
	And User clicks "Update" button
	Then information message is displayed with "Team was successfully updated." text
	And Default Team checkbox is checked and cannot be unchecked