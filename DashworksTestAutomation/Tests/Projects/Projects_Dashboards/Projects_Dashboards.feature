Feature: Projects_Dashboards
	Runs Projects Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Projects @Projects_Dashboards @Dashboards @DAS12651
Scenario: Projects_CheckThatDataInGroupOnDashboardsPageIsDisplayedCorectly
	When User clicks "Projects" on the left-hand menu
	Then "Projects" page is displayed to the user
	When User navigates to the "Computer Dashboard" page on Dashboards tab
	Then "Computer Dashboard" page is displayed to the user
	When User select "Barry's User Project" Project on toolbar
	When User navigate to "Barry's Pilot Group 1" group
	Then content for the "Barry's Pilot Group 1" group is displayed correctly