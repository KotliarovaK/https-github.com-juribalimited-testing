Feature: CreateAutomayions
	Create Automations

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15309 @DAS15626 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckActionGridInAutomations
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "15309_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "15309" Name in the "Description" field on the Automation details page
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks "Actions" tab
	Then message 'No users found' is displayed to the user
	Then "No Actions Found" message is displayed on the Admin Page
	Then "CREATE ACTION" Action button is active
	Then Columns on Admin page is displayed in following order:
	| ColumnName    |
	|               |
	| Action        |
	|               |
	| Type          |
	| Project       |
	| Task or Field |
	| Value         |
	|               |