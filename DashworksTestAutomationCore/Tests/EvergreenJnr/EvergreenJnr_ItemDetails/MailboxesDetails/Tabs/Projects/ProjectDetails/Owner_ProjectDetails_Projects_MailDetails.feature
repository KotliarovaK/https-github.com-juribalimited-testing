Feature: Owner_ProjectDetails_Projects_MailDetails
	Runs tests for Owner field on Project Details tab for Mail Details Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#AnnI 2/21/20: need to add 'Cleanup' for Owner field;
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20214 @Cleanup
Scenario: EvergreenJnr_MailboxesList_ChecksthatThePermissionForProjectMailboxObjectEditorRoleIsWorkingCorrectlyForTheOwnerField
	When User create new User via API
	| Username       | Email | FullName | Password  | Roles                         |
	| UserDAS20214_2 | Value | DAS20214 | m!gration | Project Mailbox Object Editor |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User navigates to the 'Team Members' left menu item
	When User clicks 'ADD MEMBERS' button
	When User selects following Objects from the expandable multiselect
	| Objects        |
	| UserDAS20214_2 |
	And User clicks 'ADD USERS' button
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username       | Password  |
 	| UserDAS20214_2 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
		#Devices
	When User navigates to the 'Device' details page for the item with '1703' ID
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Device Owner' field is not displayed
		#Applications
	When User navigates to the 'Application' details page for the item with '966' ID
	Then Details page for 'ActiveCGM Browser Netscape Plugin V6P07' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then button for editing the 'App Owner' field is not displayed
		#Mailboxes
	When User navigates to the 'Mailbox' details page for the item with '44237' ID
	Then Details page for '02BE025D56CF4899889@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Mailbox Owner' field

	#AnnI 5/20/20: This functionality ready only for 'Yellow_Dwarf'
	#AnnI 2/21/20: need to add 'Cleanup' for Owner field;
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20257 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_MailboxesList_CheckThatTheRadioButtonForRemovingOwnerIsWorkingCorrectly
	#with owner
	When User navigates to the 'Mailbox' details page for the item with '44638' ID
	Then Details page for '44D4F9493D6E452DB12@bclabs.local' item is displayed to the user
	When User selects 'Email Migration' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Mailbox Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this mailbox' checkbox is disabled
	When User enters '111' in the 'User' autocomplete field and selects 'BCLABS\065A1846F11140798A8 (88763) - Siddu, Arjun' value
	Then 'BCLABS\065A1846F11140798A8 (88763) - Siddu, Arjun' content is displayed in 'User' autocomplete
	Then 'UPDATE' button is not disabled on popup
	When User checks 'Remove owner' radio button
	Then '' content is displayed in 'User' autocomplete
	Then 'UPDATE' button is not disabled on popup
	Then 'Retain the existing owner as a user of this mailbox' checkbox is enabled
	#without owner
	When User navigates to the 'Mailbox' details page for the item with '40152' ID
	Then Details page for 'alex.cristea@juriba.com' item is displayed to the user
	When User selects 'Email Migration' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Mailbox Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this mailbox' checkbox is disabled
	Then 'Remove owner' radio button is disabled

	#AnnI 5/20/20: This functionality ready only for 'Yellow_Dwarf'
	#AnnI 2/21/20: need to add 'Cleanup' for Owner field;
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20257 @Yellow_Dwarf @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatRemovingOwnerIsWorkingCorrectlyOnMailboxesDetailsPage
	When User navigates to the 'Mailbox' details page for the item with '40929' ID
	Then Details page for 'Iabdulle@bclabs.local' item is displayed to the user
	When User selects 'Email Migration' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
		#S1
	Then following content is displayed on the Details Page
	| Title         | Value           |
	| Mailbox Owner | Abdulle, Ismail |
	When User clicks on edit button for 'Mailbox Owner' field
	When User checks 'Remove owner' radio button
	When User clicks 'UPDATE' button on popup
	Then 'Mailbox Owner will be removed' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Mailbox Owner successfully removed' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title         | Value |
	| Mailbox Owner |       |
	When User navigates to the 'Users' left menu item
	When User navigates to the 'Users' left submenu item
	When User enters "Iabdulle" text in the Search field for "Username" column
	Then "Iabdulle" content is displayed for "Username" column
	Then "FALSE" content is displayed for "Owner" column
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button
	When User clicks 'RESYNC' button on popup
		#S2
	Then following content is displayed on the Details Page
	| Title         | Value           |
	| Mailbox Owner | Abdulle, Ismail |
	When User clicks on edit button for 'Mailbox Owner' field
	When User checks 'Remove owner' radio button
	When User unchecks 'Retain the existing owner as a user of this mailbox' checkbox
	When User clicks 'UPDATE' button on popup
	Then 'Mailbox Owner will be removed' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Mailbox Owner successfully removed' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title         | Value |
	| Mailbox Owner |       |
	When User navigates to the 'Users' left menu item
	When User navigates to the 'Users' left submenu item
	When User enters "Iabdulle" text in the Search field for "Username" column
	Then Rows counter shows "0" of "7" rows
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button
	When User clicks 'RESYNC' button on popup