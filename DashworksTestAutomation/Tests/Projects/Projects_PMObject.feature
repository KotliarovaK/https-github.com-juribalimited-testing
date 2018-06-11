Feature: Projects_PMObject
	Runs Projects Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Projects @Projects_Dashboards @Dashboards @DAS12695
Scenario: Projects_CheckThatErrorIsNotDisplayedWhenUsedDDLForApplicationsTabOnPMObjectPage
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigates to the PMObject page
	Then "Project Object" page is displayed to the user
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
