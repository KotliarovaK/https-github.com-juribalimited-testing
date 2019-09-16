Feature: ActionsWithGrid
	Runs test related to Grid functionality on history page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS17973 @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAndDataIsntMissingFromTheProjectScopeHistory
	When User navigates to "Email Migration" project details
	And User selects "Scope" tab on the Project details page
	And User selects "History" tab on the Project details page
	And User scrolls grid to the bottom
	Then There are no errors in the browser console