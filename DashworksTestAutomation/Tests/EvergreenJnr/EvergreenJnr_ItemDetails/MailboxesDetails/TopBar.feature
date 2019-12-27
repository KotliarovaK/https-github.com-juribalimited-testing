Feature: TopBar
	Runs Mailboxes Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_MailboxesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for '00B5CCB89AD0404B965@bclabs.local' item is displayed to the user
	And No one Compliance items are displayed for the User in Top bar on the Item details page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075 @DAS17355
Scenario: EvergreenJnr_MailboxesList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for '00B5CCB89AD0404B965@bclabs.local' item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| Task Readiness    |
	| Workflow          |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario: EvergreenJnr_MailboxesList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928 @DAS18405
Scenario: EvergreenJnr_MailboxesList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title     | Value  |
	| Readiness | IGNORE |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | IGNORE    |