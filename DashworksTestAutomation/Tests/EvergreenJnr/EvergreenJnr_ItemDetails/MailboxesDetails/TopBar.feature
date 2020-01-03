Feature: TopBar
	Runs Mailboxes Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_MailboxesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for '00B5CCB89AD0404B965@bclabs.local' item is displayed to the user
	Then there are no displayed items in the top bar

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075 @DAS17355
Scenario: EvergreenJnr_MailboxesList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for '00B5CCB89AD0404B965@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following items are displayed in the top bar:
	| ComplianceItems   |
	| Overall Readiness |
	| Task Readiness    |
	| Workflow          |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario: EvergreenJnr_MailboxesList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	Then dropdown is not opened
	Then options are sorted in alphabetical order in the 'Item Details Project' dropdown
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	Then dropdown is not opened
	Then options are sorted in alphabetical order in the 'Item Details Project' dropdown

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928 @DAS18405
Scenario: EvergreenJnr_MailboxesList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title     | Value  |
	| Readiness | IGNORE |
	Then following items and colors are displayed in the top bar:
	| ComplianceItems   | ColorName |
	| Overall Readiness | IGNORE    |