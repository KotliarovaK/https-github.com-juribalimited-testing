Feature: Offboard_MailboxesPage
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
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Dialog Pop-up is displayed for User
	Then following text 'Offboarding mailbox 01DEAC5F18B34084B04@bclabs.local. Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up
	Then 'Offboard all associated users' checkbox is checked
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	And User selects state 'true' for 'Offboard all associated users' checkbox
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 01DEAC5F18B34084B04 |
	Then "BCLABS\01DEAC5F18B34084B04 (Owner)" chip have tooltip with "BCLABS\01DEAC5F18B34084B04 (Owner)" text
	When User clicks the "OFFBOARD" Action button
	When User clicks the "OFFBOARD" Action button
	#going to check the object state
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "USE ME FOR AUTOMATION(MAIL SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	Then '01DEAC5F18B34084B04@bclabs.local' content is displayed in the 'Item' column
	Then '01DEAC5F18B34084B04' content is displayed in the 'Item' column
	Then 'svc_dashworks' content is not displayed in the 'Item' column

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnPageMailboxes
	When User navigates to the 'Mailbox' details page for '01DEAC5F18B34084B04@bclabs.local' item
	Then Details page for "01DEAC5F18B34084B04@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Dialog Pop-up is displayed for User
	Then following text 'Offboarding mailbox 01DEAC5F18B34084B04@bclabs.local. Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up
	Then 'Offboard all associated users' checkbox is checked
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User clicks the "OFFBOARD" Action button
	When User clicks the "OFFBOARD" Action button
	#going to check the object state
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "USE ME FOR AUTOMATION(MAIL SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	Then '01DEAC5F18B34084B04@bclabs.local' content is displayed in the 'Item' column
	Then '01DEAC5F18B34084B04' content is displayed in the 'Item' column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000
Scenario: EvergreenJnr_MailboxesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User perform search by "alex.cristea@juriba.com"
	And User click content from "Email Address" column
	Then Details page for "alex.cristea@juriba.com" item is displayed to the user
	When User switches to the "Email Migration" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Dialog Pop-up is displayed for User
	Then following text 'Offboarding mailbox alex.cristea@juriba.com (Alex Cristea). Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up