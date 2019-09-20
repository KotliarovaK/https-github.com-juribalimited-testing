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
	When User clicks the "RELINK" Action button
	Then Dialog Pop-up is displayed for User
	Then 'Resync owner and users' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User clicks the "RELINK" Action button
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks the "RELINK" Action button
	Then Success message is displayed and contains "000F977AC8824FE39B8@bclabs.local successfully relinked" text