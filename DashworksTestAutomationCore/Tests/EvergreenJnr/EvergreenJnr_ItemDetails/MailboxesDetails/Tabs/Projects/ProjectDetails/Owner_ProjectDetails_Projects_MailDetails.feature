Feature: Owner_ProjectDetails_Projects_MailDetails
	Runs tests for Owner field on Project Details tab for Mail Details Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 5/20/20: This functionality ready only for 'Yellow_Dwarf'
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20214 @Yellow_Dwarf
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
	Then "Retain the existing owner as a user of this mailbox" checkbox is checked
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
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20214 @Yellow_Dwarf @Cleanup
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
	Then "Retain the existing owner as a user of this mailbox" checkbox is checked
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
	Then "Iabdulle" content is displayed for "User" column
	Then "FALSE" content is displayed for "Owner" column
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button
	When User clicks 'RESYNC' button on popup
	When User clicks 'RESYNC' button on popup
		#S2
	Then following content is displayed on the Details Page
	| Title         | Value           |
	| Mailbox Owner | Abdulle, Ismail |
	When User clicks on edit button for 'Mailbox Owner' field
	When User checks 'Remove owner' radio button
	When User unchecks 'Retain the existing owner as a user of this mailbox' checkbox
	Then 'UPDATE' button is disabled on popup
	Then 'Mailbox Owner will be removed' text is displayed on inline tip banner
	Then 'UPDATE' button is disabled on popup
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
	When User clicks 'RESYNC' button on popup