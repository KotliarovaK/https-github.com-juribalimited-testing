Feature: Relink_MailboxesPage
	Runs Relink related tests on Mailboxes Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title         | Value                            |
	| Name          | 000F977AC8824FE39B8@bclabs.local |
	| Mailbox Owner | Spruill, Shea                    |
	When User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	Then 'Resync owner and users' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User enters 'gdf' in the 'Mailbox' autocomplete field and selects 'GDF237451@bclabs.local' value
	Then User selects state 'true' for 'Resync owner and users' checkbox
	Then User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Mailbox successfully relinked" text
	Then Details page for "GDF237451@bclabs.loca" item is displayed to the user
	Then following content is displayed on the Details Page
	| Title         | Value                            |
	| Name          | 000F977AC8824FE39B8@bclabs.local |
	| Mailbox Owner | Spruill, Shea                    |
	When User clicks 'RESYNC' button 
	When User clicks 'RESYNC' button in Dialog Pop-up
	Then Success message is displayed and contains "Mailbox successfully resynced" text
	Then following content is displayed on the Details Page
	| Title        | Value                  |
	| Name         | GDF237451@bclabs.local |
	| Device Owner |                        |
	When User navigates to the 'Users' left menu item
	And User navigates to the "Users" sub-menu on the Details page
	Then "1" rows found label displays on Details Page 