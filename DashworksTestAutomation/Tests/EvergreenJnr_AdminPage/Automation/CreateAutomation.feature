Feature: CreateAutomayions
	Create Automations

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15309 @DAS15626 @DAS16880
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
	When User selects "Active" checkbox on the Automation Page
	When User selects "Stop on failed action" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects "Manual" in the "Run" dropdown
	And User clicks the "CREATE" Action button
	When User clicks "Actions" tab
	Then "No Actions Found" message is displayed on the Admin Page
	Then "CREATE ACTION" Action button is active

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16801
Scenario: EvergreenJnr_AdminPage_CheckThatCreateAutomationFieldsIsNotPopulatedWithPreviouslyCreatedAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "DAS16801_Automation" Name in the "Automation Name" field on the Automation details page
	When User type "DAS16801" Name in the "Description" field on the Automation details page
	When User selects "1803 Rollout" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks "Automations" navigation link on the Admin page
	When User clicks the "CREATE AUTOMATION" Action button
	Then "Description" field is empty on the Admin page
	Then "Automation Name" field is empty on the Admin page
	Then "Scope" field is empty on the Admin page
	Then "Active" checkbox is unchecked on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16801 @DAS16805
Scenario: EvergreenJnr_AdminPage_CheckThatAdminTabIsHighlightedAfterClickingOnAutomation
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks content from "Automation" column
	Then Edit Automation page is displayed to the User
	Then "Admin" left-hand menu is highlighted
	When User creates new Capacity Unit via api
	| Name                     | Description | IsDefault |
	| DefaultCapacityUnit13720 | 13720       | true      |
	#When User creates new Automation Unit via API
	#| Name | Description | Scope |Run|Active|StopOnFailedAction|