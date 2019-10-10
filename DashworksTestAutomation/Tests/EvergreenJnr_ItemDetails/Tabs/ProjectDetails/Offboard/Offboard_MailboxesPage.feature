﻿Feature: Offboard_MailboxesPage
	Runs Offboard Mailboxes Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '01DEAC5F18B34084B04@bclabs.local' item
	Then Details page for "01DEAC5F18B34084B04@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And 'Offboard all associated users' checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	And User selects state 'true' for 'Offboard all associated users' checkbox
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 01DEAC5F18B34084B04 |
	Then " BCLABS\01DEAC5F18B34084B04 (Owner)" chip have tooltip with "BCLABS\01DEAC5F18B34084B04 (Owner)" text
	When User clicks 'OFFBOARD' button in Dialog Pop-up
	And User clicks 'OFFBOARD' button in Dialog Pop-up
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(MAIL SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	Then '01DEAC5F18B34084B04@bclabs.local' content is displayed in the 'Item' column
	And '01DEAC5F18B34084B04' content is displayed in the 'Item' column
	And 'svc_dashworks' content is not displayed in the 'Item' column

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @DAS18067 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnPageMailboxes
	When User navigates to the 'Mailbox' details page for '01DEAC5F18B34084B04@bclabs.local' item
	Then Details page for "01DEAC5F18B34084B04@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And 'Offboard all associated users' checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User clicks 'OFFBOARD' button in Dialog Pop-up
	And User clicks 'OFFBOARD' button in Dialog Pop-up
	Then Success message is displayed and contains "The selected objects were successfully queued for offboarding from USE ME FOR AUTOMATION(MAIL SCHDLD)" text
	#going to check the object state
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(MAIL SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	Then '01DEAC5F18B34084B04@bclabs.local' content is displayed in the 'Item' column
	And '01DEAC5F18B34084B04' content is displayed in the 'Item' column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000
Scenario: EvergreenJnr_MailboxesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnMailboxesPage
	When User navigates to the 'Mailbox' details page for 'alex.cristea@juriba.com' item
	Then Details page for "alex.cristea@juriba.com" item is displayed to the user
	When User switches to the "Email Migration" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	Then following text 'Offboarding mailbox alex.cristea@juriba.com (Alex Cristea). Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up