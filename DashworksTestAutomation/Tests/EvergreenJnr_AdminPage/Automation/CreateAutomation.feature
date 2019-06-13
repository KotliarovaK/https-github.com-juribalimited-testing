﻿Feature: CreateAutomayions
	Create Automations

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15309 @DAS15626 @DAS16880 @DAS16931 @Remove_Profile_Changes @Not_Ready
Scenario: EvergreenJnr_AdminPage_CheckActionGridInAutomations
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Automations" link on the Admin page
	Then "Automations" page should be displayed to the user
	When User clicks the "CREATE AUTOMATION" Action button
	Then Create Automation page is displayed to the User
	When User type "15309_laptop" Name in the "Automation Name" field on the Automation details page
	When User type "15309" Name in the "Description" field on the Automation details page
	Then Main lists are displayed correctly in the Scope dropdown
	| Section          | ListName         |
	| Devices (1)      | All Devices      |
	| Users (1)        | All Users        |
	| Mailboxes (1)    | All Mailboxes    |
	| Applications (1) | All Applications |
	When User selects "All Devices" in the Scope Automation dropdown
	When User selects "Active" checkbox on the Automation Page
	When User selects "Stop on failed action" checkbox on the Automation Page
	Then "CREATE" Action button is disabled
	When User selects "Manual" in the "Run" dropdown
	And User clicks the "CREATE" Action button
	When User clicks "Actions" tab
	Then "No Actions Found" message is displayed on the Admin Page
	Then "CREATE ACTION" Action button is active
	#When User clicks Profile in Account Dropdown
	#Then Profile page is displayed to user
	#When User navigates to the "Preferences" page on Account details
	#And User changes language to "Deutsch"
	#And User clicks Update button on Preferences page
	#When Evergreen QueryStringURL is entered for Complex QueryType	
	#| QueryType   | QueryStringURL                 |
	#| Automations | evergreen/#/admin/automations/ |
	#Then "15309_laptop" content is displayed in "Automation Name" field
	#When User enters "15309_laptop" text in the Search field for "Automation" column
	#When User clicks content from "Automation" column
	#Then "15309_laptop" content is displayed in "Automation Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16801 @DAS15764 @DAS15423 @Not_Ready
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
	When User type "DAS16801_Automation_Second" Name in the "Automation Name" field on the Automation details page
	When User type "DAS16801" Name in the "Description" field on the Automation details page
	When User selects "1803 Rollout" in the Scope Automation dropdown
	When User selects "Manual" in the "Run" dropdown
	When User selects "Active" checkbox on the Automation Page
	And User clicks the "CREATE" Action button
	When User clicks newly created object link
	When User type "DAS16801_Automation" Name in the "Automation Name" field on the Automation details page
	Then Filling field error with "An automation with this name already exists" text is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16801 @DAS16805 @Not_Ready
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