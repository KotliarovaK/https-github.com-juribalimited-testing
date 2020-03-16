Feature: Ring_MailboxesPage
	Runs related tests for Ring field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS17144 @DAS17164 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatValueForRingIsChangingSuccessfully
	When User creates new Ring via api
	| Name           | Description | IsDefault | Project                              |
	| RingDAS17144_1 | DAS17144    | false     | zMailbox Sch for Automations Feature |
	| RingDAS17144_2 | DAS17144    | false     | zMailbox Sch for Automations Feature |
	When User navigates to the 'Mailbox' details page for '05E1205F294549EC822@bclabs.local' item
	Then Details page for '05E1205F294549EC822@bclabs.local' item is displayed to the user
	When User selects 'zMailbox Sch for Automations Feature' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User selects 'RingDAS17144_1' in the dropdown for the 'Ring' field
	Then 'Mailbox successfully moved to RingDAS17144_1' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title | Value          |
	| Ring  | RingDAS17144_1 |
	When User navigates to 'evergreen/#/admin/project/77/rings' URL in a new tab
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| RingDAS17144_2   |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected ring has been deleted' text is displayed on inline success banner
	When User switches to previous tab
	When User selects 'RingDAS17144_2' in the dropdown for the 'Ring' field
	Then 'Ring does not exist' text is displayed on inline error banner

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS19948
Scenario: EvergreenJnr_MailboxesList_CheckThatRingFieldIsDisplayedDependingOnTheProjectScopeForMailboxesPage
	When User navigates to the 'Mailbox' details page for the item with '43917' ID
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title | Value      |
	| Ring  | Unassigned |