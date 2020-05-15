Feature: Relink_MailboxesPage
	Runs Relink related tests on Mailboxes Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#need to add cleanup
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS18284 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '01A921EFD05545818AA@bclabs.local' item
	Then Details page for '01A921EFD05545818AA@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then User verifies data in the fields on details page
	| Field         | Data                             |
	| Name          | 01A921EFD05545818AA@bclabs.local |
	| Mailbox Owner | Leon, Nacoma                     |
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	And 'Resync owner and users' checkbox is checked
	And 'Resync name' checkbox is checked
	When User enters '04D158C83A0142F3B79' in the 'Mailbox' autocomplete field and selects '04D158C83A0142F3B79@bclabs.local' value
	When User selects state 'true' for 'Resync owner and users' checkbox
	When User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button on popup
	Then 'This object will be relinked to the selected Evergreen object in this project' text is displayed on inline tip banner
	When User clicks 'RELINK' button on popup
	Then 'Mailbox successfully relinked' text is displayed on inline success banner
	#waiting for the RELINK process to be completed
	When User waits for '3' seconds
	Then Details page for '04D158C83A0142F3B79@bclabs.local' item is displayed to the user
	And User verifies data in the fields on details page
	| Field         | Data                             |
	| Name          | 01A921EFD05545818AA@bclabs.local |
	| Mailbox Owner | Leon, Nacoma                     |
	When User clicks 'RESYNC' button 
	And User clicks 'RESYNC' button on popup
	Then 'The Evergreen owner of this Mailbox has been queued for onboarding into this project, the change in ownership for this Mailbox will show once this is complete' text is displayed on inline success banner
	#waiting for the RESYNC process to be completed
	When User waits for '3' seconds
	Then User verifies data in the fields on details page
	| Field         | Data                             |
	| Name          | 04D158C83A0142F3B79@bclabs.local |
	| Mailbox Owner | Jin, Jh                          |
	When User clicks 'RELINK' button 
	And User enters '01A921EFD05545818AA' in the 'Mailbox' autocomplete field and selects '01A921EFD05545818AA@bclabs.local' value
	And User clicks 'RELINK' button on popup
	And User clicks 'RELINK' button on popup
	Then 'Mailbox successfully relinked' text is displayed on inline success banner
	#waiting for the RELINK process to be completed
	When User waits for '3' seconds
	When User navigates to the 'User' details page for '04D158C83A0142F3B79' item
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	When User clicks 'OFFBOARD' button on popup
	And User clicks 'OFFBOARD' button on popup

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19335
Scenario: EvergreenJnr_MailboxesList_CheckThatTooltipForDisabledRelinkButtonIsDisplayed
	When User navigates to the 'Mailbox' details page for '00DB4000EDD84951993@bclabs.local' item
	Then Details page for '00DB4000EDD84951993@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then popup is displayed to User
	Then Button 'RELINK' has 'Select a mailbox' tooltip on popup

@Evergreen @Mailbox @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19323 @Universe
Scenario: EvergreenJnr_MailboxList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringPartOfObjectKeyToAutocomplete
	When User navigates to the 'Mailbox' details page for '0072B088173449E3A93@bclabs.local' item
	Then Details page for '0072B088173449E3A93@bclabs.local' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then only options having search term '993' are displayed in 'Mailbox' autocomplete

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS21175 @Yellow_Dwarf
Scenario: EvergreenJnr_MailboxList_CheckTheMailboxDataInProjectModeIsUpdatedAccordingToTheEvergreenDataAfterRelinkingResyncingTheMailboxToAnotherOne
	When User navigates to the 'Mailbox' details page for '02171CE96D0244BBB80@bclabs.local' item
	Then Details page for '02171CE96D0244BBB80@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	When User enters '40153' in the 'Mailbox' autocomplete field and selects 'alex.melnychuk@juriba.com (40153) - Alex Melnychuk' value
	When User clicks 'RELINK' button on popup
	Then 'Mailbox successfully relinked' text is displayed on inline success banner
	When User navigates to the 'Details' left menu item
	When User navigates to the 'Mailbox Owner' left submenu item
	Then 'No mailbox owner found for this mailbox' message is displayed on empty greed