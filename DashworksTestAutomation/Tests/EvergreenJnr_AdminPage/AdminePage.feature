@retry:1
Feature: AdminPage
	Runs Admin Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11747 @Not_Run
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
	Then Success message is displayed and contains "The team has been created" text on the Teams page
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	When User clicks Create Team button on the Create Team page
	Then Error message with "A team already exists with this name" text is displayed on the Teams page
	And There are no errors in the browser console
	And Delete "TestTeam" Team in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11747 @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreateBucketWithTheAlreadyExistName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Create Bucket button
	Then Create Bucket page should be displayed to the user
	And User enters "TestBucket" in the Bucket Name field
	And User select "Admin IT" team in the Select a team dropdown
	When User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text on the Buckets page
	When User clicks Create Bucket button
	Then Create Bucket page should be displayed to the user
	And User enters "TestBucket" in the Bucket Name field
	And User select "Admin IT" team in the Select a team dropdown
	When User clicks Create button on the Create Bucket page
	Then Error message with "A bucket already exists with this name" text is displayed on the Buckets page
	And There are no errors in the browser console
	#Then Delete " " Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyProjectName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters " " in the Project Name field
	#And User select "All Devices" in the Scope Project dropdown
	And Create Project button is disabled