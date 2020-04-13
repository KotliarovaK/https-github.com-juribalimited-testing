Feature: Resync_MailboxesPage
	Runs Resync related tests on Mailboxes Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Resync @DAS18035
Scenario: EvergreenJnr_MailboxesList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '016E1B57C2DD4FCC986@bclabs.local' item
	Then Details page for '016E1B57C2DD4FCC986@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button 
	Then popup is displayed to User
	Then 'Resync owner and users' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User selects state 'false' for 'Resync owner and users' checkbox
	When User clicks 'RESYNC' button on popup
	Then 'Mailbox successfully resynced' text is displayed on inline success banner