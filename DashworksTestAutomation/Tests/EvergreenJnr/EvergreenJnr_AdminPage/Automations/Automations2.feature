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