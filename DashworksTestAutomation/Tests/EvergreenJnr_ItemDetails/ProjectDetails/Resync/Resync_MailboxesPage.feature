Feature: Resync_MailboxesPage
	Runs Resync related tests on Mailboxes Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Resync @DAS18035 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '016E1B57C2DD4FCC986@bclabs.local' item
	Then Details page for "016E1B57C2DD4FCC986@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "RESYNC" Action button
	Then Dialog Pop-up is displayed for User
	Then 'Resync owner and users' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User clicks the "RESYNC" Action button
	Then Success message is displayed and contains "Mailbox successfully resynced" text