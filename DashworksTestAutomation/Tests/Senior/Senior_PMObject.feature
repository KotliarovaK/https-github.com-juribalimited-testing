Feature: Projects_PMObject
	Runs Projects Page related tests

Background: Pre-Conditions
	Given User is logged in to the Projects
	Then "Projects Home" page is displayed to the user

@ProjectsOnSenior @PMObject @Applications_tab @DAS12695 @DAS14003 @DAS14912 @Not_Run
Scenario: Projects_CheckThatErrorIsNotDisplayedWhenUsedDDLForApplicationsTabOnPMObjectPage
	When User navigates to "61085" Object on PMObject page
	Then "Project Object" page is displayed to the user
	And "Change Capacity Unit" button is displayed
	When User navigate to "Applications" tab on PMObject page
	Then Application tab content is displayed correctly
	When User select "Current State" View State on Applications tab
	Then Application tab content is displayed correctly
	When User select "Target State" View State on Applications tab
	Then Application tab content is displayed correctly
	When User select "Alphabetical" View Type on Applications tab
	Then Application tab content is displayed correctly
	When User select "Consolidated" View Type on Applications tab
	Then Application tab content is displayed correctly
	When User select "Readiness" View Type on Applications tab
	Then Application tab content is displayed correctly