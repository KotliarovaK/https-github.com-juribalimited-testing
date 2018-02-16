@retry:1
Feature: AdminPage
	Runs Admin Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11747
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreateTeamWithTheAlreadyExistName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	When User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text on the Admin page
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	When User clicks Create Team button on the Create Team page
	Then Error message with "A team already exists with this name" text is displayed on the Admin page
	Then There are no errors in the browser console
	Then Delete "TestTeam" Team in the Administration

	@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11747
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreateBucketWithTheAlreadyExistName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Create Bucket button
	Then Create Bucket page should be displayed to the user
	And User enters " " in the Team Name field
	And User enters " " in the Team Description field
	When User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text on the Admin page
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	When User clicks Create Team button on the Create Team page
	Then Error message with "A team already exists with this name" text is displayed on the Admin page
	Then There are no errors in the browser console
	Then Delete " " Project in the Administration
	Then Delete " " Bucket in the Administration