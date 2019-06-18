Feature: AutomationsLogPage
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Update tests with new gold data
@Evergreen @EvergreenJnr_AdminPage @AutomationLog @DAS16890 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckAutomationsLogGridForRunningAutomationWithDeletedProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	And User enters "16890Project" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Automations" link on the Admin page
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "16890_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "16890" Name in the "Description" field on the Automation details page
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Active" checkbox on the Automation Page
	When User selects "Stop on failed action" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects "Manual" in the "Run" dropdown
	And User clicks the "CREATE" Action button
	When User type "16890_Action" Name in the "Action Name" field on the Automation details page
	When User selects "Update path" in the "Action Type" dropdown
	When User selects "1803 Rollout" in the Project dropdown
	When User selects "Undetermined" in the Path dropdown
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User clicks "Projects" link on the Admin page
	And User enters "16890Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "Automations" link on the Admin page
	When User clicks "Run now" option in Cog-menu for "16890" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "16890_Action" checkbox from String Filter with item list on the Admin page
	Then "PROJECT DOES NOT EXIST" content is displayed for "Outcome" column