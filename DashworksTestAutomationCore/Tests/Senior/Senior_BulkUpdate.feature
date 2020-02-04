Feature: Projects_BulkUpdate
	Runs Projects Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Senior @Senior_Projects @BulkUpdate @Actions_tab @DAS15050
Scenario: Projects_CheckThatMoveRingOptionIsAvailableForUserProject
	When User clicks 'Projects' on the left-hand menu
	And User navigates to "Bulk Update" page on Senior
	And User selects "User Evergreen Capacity Project" project for Bulk Update
	And User selects "User" object type for Bulk Update
	Then Bulk Update Type dropdown has "Move Ring" option