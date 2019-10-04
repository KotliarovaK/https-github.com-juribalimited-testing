Feature: Relink_MailboxesPage
	Runs Relink related tests on Mailboxes Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112
Scenario: EvergreenJnr_MailboxesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then User verifies data in the fields on details page
	| Field         | Data                             |
	| Name          | 000F977AC8824FE39B8@bclabs.local |
	| Mailbox Owner | Spruill, Shea                    |
	When User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	And 'Resync owner and users' checkbox is checked
	And 'Resync name' checkbox is checked
	When User enters 'gdf' in the 'Mailbox' autocomplete field and selects 'GDF237451@bclabs.local' value
	Then User selects state 'true' for 'Resync owner and users' checkbox
	And User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Mailbox successfully relinked" text
	And Details page for "GDF237451@bclabs.loca" item is displayed to the user
	And User verifies data in the fields on details page
	| Field         | Data                             |
	| Name          | 000F977AC8824FE39B8@bclabs.local |
	| Mailbox Owner | Spruill, Shea                    |
	When User clicks 'RESYNC ' button 
	And User clicks 'RESYNC' button in Dialog Pop-up
	Then Success message is displayed and contains "Mailbox successfully resynced" text
	And User verifies data in the fields on details page
	| Field         | Data                   |
	| Name          | GDF237451@bclabs.local |
	| Mailbox Owner | Albert,Martinez        |
	When User navigates to the 'Users' left menu item
	And User navigates to the "Users" sub-menu on the Details page
	Then "7" rows found label displays on Details Page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'RELINK' button 
	And User enters '000F977AC8824FE39B8@bclabs.local' in the 'Mailbox' autocomplete field and selects '000F977AC8824FE39B8@bclabs.local' value
	And User clicks 'RELINK' button in Dialog Pop-up
	And User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Mailbox successfully relinked" text