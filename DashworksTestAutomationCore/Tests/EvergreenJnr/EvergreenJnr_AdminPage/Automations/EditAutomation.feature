Feature: EditAutomations
	Edit Automations

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS20795 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckScopeListsForDifferentScopeAutomations
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	#Devices scope Automation
	When User enters "Devices_Scope" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Page with 'Devices_Scope' header is displayed to user
	When User selects 'Win7 Devices' option from 'Scope' autocomplete
	When User selects 'Bulk Update Roles' option from 'Scope' autocomplete
	Then 'Users with Device Count' content is not displayed in 'Scope' autocomplete after search
	Then 'Mailbox List (Complex)' content is not displayed in 'Scope' autocomplete after search
	When User clicks 'Automations' header breadcrumb
	When User clicks 'YES' button on popup
	#Users scope Automation
	When User enters "Users_Scope" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Page with 'Users_Scope' header is displayed to user
	When User selects '2004 User Rings' option from 'Scope' autocomplete
	When User selects 'Users List (Complex)' option from 'Scope' autocomplete
	Then 'Win7 Devices' content is not displayed in 'Scope' autocomplete after search
	Then 'All Mailboxes' content is not displayed in 'Scope' autocomplete after search
	When User clicks 'Automations' header breadcrumb
	When User clicks 'YES' button on popup
	#Mailboxes scope Automation
	When User enters "Mailboxes_Scope" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Page with 'Mailboxes_Scope' header is displayed to user
	When User selects 'Mailbox List (Complex)' option from 'Scope' autocomplete
	When User selects 'Mailbox List (Complex) - BROKEN LIST' option from 'Scope' autocomplete
	Then 'Win7 Devices' content is not displayed in 'Scope' autocomplete after search
	Then 'Users List (Complex)' content is not displayed in 'Scope' autocomplete after search
	When User clicks 'Automations' header breadcrumb
	When User clicks 'YES' button on popup
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS20798 @DAS20240 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateButtonStateWhileChangingScopeLists
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope     | Run    |
	| 20798_Automation | 20798       | true     | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User selects '(broken) Missing Column' option from 'Scope' autocomplete
	Then 'This list has errors' error message is displayed for 'Scope' field
	Then 'UPDATE' button is disabled
	When User selects 'Mailbox List (Complex)' option from 'Scope' autocomplete
	Then 'List validated' success message for 'Scope' field
	Then 'UPDATE' button is not disabled
	When User selects 'All Device Types' option from 'Scope' autocomplete
	Then 'List validated' success message for 'Scope' field
	Then 'UPDATE' button is not disabled