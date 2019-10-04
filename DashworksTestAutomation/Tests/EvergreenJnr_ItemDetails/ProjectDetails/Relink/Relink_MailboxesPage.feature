Feature: Relink_MailboxesPage
	Runs Relink related tests on Mailboxes Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS18284
Scenario: EvergreenJnr_MailboxesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '01A921EFD05545818AA@bclabs.local' item
	Then Details page for "01A921EFD05545818AA@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then User verifies data in the fields on details page
	| Field         | Data                             |
	| Name          | 01A921EFD05545818AA@bclabs.local |
	| Mailbox Owner | Leon, Nacoma                     |
	When User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	And 'Resync owner and users' checkbox is checked
	And 'Resync name' checkbox is checked
	When User enters '04D158C83A0142F3B79' in the 'Mailbox' autocomplete field and selects '04D158C83A0142F3B79@bclabs.local' value
	Then User selects state 'true' for 'Resync owner and users' checkbox
	And User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "Mailbox successfully relinked" text
	And Details page for "04D158C83A0142F3B79@bclabs.local" item is displayed to the user
	And User verifies data in the fields on details page
	| Field         | Data                             |
	| Name          | 01A921EFD05545818AA@bclabs.local |
	| Mailbox Owner | Leon, Nacoma                     |
	#Andrew will remove space in button name
	When User clicks 'RESYNC ' button 
	And User clicks 'RESYNC' button in Dialog Pop-up
	Then Success message is displayed and contains "The Evergreen owner of this Mailbox has been queued for onboarding into this project, the change in ownership for this Mailbox will show once this is complete" text
	When User waits for three seconds
	Then User verifies data in the fields on details page
	| Field         | Data                             |
	| Name          | 04D158C83A0142F3B79@bclabs.local |
	| Mailbox Owner | Jin, Jh                          |
	When User clicks 'RELINK' button 
	And User enters '01A921EFD05545818AA' in the 'Mailbox' autocomplete field and selects '01A921EFD05545818AA@bclabs.local' value
	And User clicks 'RELINK' button in Dialog Pop-up
	And User clicks 'RELINK' button in Dialog Pop-up
	#Andrew will check the delay time for message
	#Then Success message is displayed and contains "Mailbox successfully relinked" text
	When User waits for three seconds
	When User navigates to the 'User' details page for '04D158C83A0142F3B79' item
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	When User clicks 'OFFBOARD' button in Dialog Pop-up
	And User clicks 'OFFBOARD' button in Dialog Pop-up