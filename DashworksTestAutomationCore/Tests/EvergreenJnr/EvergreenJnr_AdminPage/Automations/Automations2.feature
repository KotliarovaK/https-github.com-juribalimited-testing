Feature: AutomationsPage2
	Runs Automations Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS19946 @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckValidingForScopeLists
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "Mailboxes_Scope" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then 'Edit Automation' page subheader is displayed to user
	When User selects 'Mailbox List (Complex) - BROKEN LIST' option from 'Scope' autocomplete
	When User waits for info message disappears under 'Scope' field
	When User navigates to the 'Actions' left menu item
	Then 'You have unsaved changes. Are you sure you want to leave the page?' text is displayed on popup

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS21048 @Cleanup @X_Ray
Scenario: EvergreenJnr_AdminPage_CheckValidationMessagesForScopeDropdownWhenListDeleted
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00YWR8TJU4ZF8V   |
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "AutoTestList21048" name
	Then "AutoTestList21048" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope             | Run    |
	| 21048_Automation | 21048       | true     | false              | AutoTestList21048 | Manual |
	Then Automation page is displayed correctly
	Then 'AutoTestList21048' content is displayed in 'Scope' textbox
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "AutoTestList21048" list
	Then "AutoTestList21048" list is displayed to user
	When User clicks 'Delete' option in cogmenu for 'AutoTestList21048' list
	When User confirms list removing
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "21048_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then 'The selected list cannot be found' error message is displayed for 'Scope' field
	Then '[List not found]' content is displayed in 'Scope' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	Then 'List validated' success message for 'Scope' field
	When User clicks 'Automations' header breadcrumb
	When User clicks 'YES' button on popup
	When User enters "21048_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then 'The selected list cannot be found' error message is displayed for 'Scope' field
	Then '[List not found]' content is displayed in 'Scope' textbox
	When User selects 'All Mailboxes' option from 'Scope' autocomplete
	Then 'List validated' success message for 'Scope' field