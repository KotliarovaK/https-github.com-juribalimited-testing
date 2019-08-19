Feature: AutomationsLog1Page
	Runs Automation Log Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17430 @DAS17518 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckUpdateValueDateForUpdateTaskValueActionDAS17430
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User creates new Automation via API
	| AutomationName   | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 17430_Automation | 17430       | true   | false              | All Users | Manual |
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User enters "17430_Automation" text in the Search field for "Automation" column
	And User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	When User clicks "Actions" tab
	#Create Action
	When User clicks the "CREATE ACTION" Action button
	And User type "17430_Action" Name in the "Action Name" field on the Automation details page
	And User selects "Update task value" in the "Action Type" dropdown
	When User selects "USE ME FOR AUTOMATION(USR SCHDLD)" in the Project dropdown
	When User selects "Stage 1" in the "Stage" dropdown for Actions
	When User selects "Radiobutton Readiness Date Owner Task (User)" in the "Task" dropdown for Actions
	And User selects "Update" Update Value on Action panel
	And User selects "Started" Value on Action panel
	And User selects "Update" Update Date on Action panel
	And User selects "19 Nov 2019" Date on Action panel
	And User selects "Update" Update Owner on Action panel
	And User selects "Admin IT" Team on Action panel
	When User selects "Akhila Varghese" Owner on Action panel
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User enters "17430_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "17430_Automation" item on Admin page
	When User selects "Automation Log" tab on the Project details page
	When User enters "17430_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                                         |
	| USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User) |
	Then "STARTED" content is displayed in "USEMEFORA2: Stage 1 \ Radiobutton Readiness Date Owner Task (User)" column