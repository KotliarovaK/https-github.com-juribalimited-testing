Feature: CreateAutomayions
	Create Automations

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15309 @DAS15626 @DAS16880 @DAS16931 @DAS17102 @DAS17630 @Remove_Profile_Changes @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckActionGridInAutomations
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	#When User creates new Automation via API
	#| AutomationName | Description | Active | StopOnFailedAction | Scope       | Run    |
	#| 15309_laptop   | 15309       | true   | false              | All Devices | Manual |
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User enters '15309_laptop' text to 'Automation Name' textbox
	When User enters '15309' text to 'Description' textbox
	Then Main lists are displayed correctly in the Scope dropdown
	| ListName         |
	| All Devices      |
	| All Device Types |
	| All Users        |
	| All Applications |
	| All Mailboxes    |
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Active" checkbox on the Automation Page
	When User selects "Stop on failed action" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects 'Manual' in the 'Run' dropdown
	And User clicks the "CREATE" Action button
	When User clicks "Actions" tab
	Then "No actions found" message is displayed on the Admin Page
	Then "CREATE ACTION" Action button is active

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16801 @DAS15764 @DAS15423 @DAS17134 @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckThatCreateAutomationFieldsIsNotPopulatedWithPreviouslyCreatedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	Then following Values are displayed in "Run" drop-down on the Admin page:
	| Values                     |
	| Manual                     |
	| After Transform            |
	| Scheduled: Dashworks Daily |
	When User enters 'DAS16801_Automation' text to 'Automation Name' textbox
	When User enters 'DAS16801' text to 'Description' textbox
	When User selects "1803 Rollout" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User clicks the "CREATE AUTOMATION" Action button
	Then "Description" field is empty on the Admin page
	Then "Automation Name" field is empty on the Admin page
	Then "Scope" field is empty on the Admin page
	Then "Active" checkbox is unchecked on the Admin page
	When User enters 'DAS16801_Automation_Second' text to 'Automation Name' textbox
	When User enters 'DAS16801' text to 'Description' textbox
	When User selects "1803 Rollout" in the Scope Automation dropdown
	When User selects 'Manual' in the 'Run' dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks newly created object link
	When User enters 'DAS16801_Automation' text to 'Automation Name' textbox
	Then 'An automation with this name already exists' error message is displayed for 'Automation Name' field

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16801 @DAS16805
Scenario: EvergreenJnr_AdminPage_CheckThatAdminTabIsHighlightedAfterClickingOnAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	Then "Admin" left-hand menu is highlighted