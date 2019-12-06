Feature: TopBar
	Runs User Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_UsersList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnUsersPage
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems       |
	| Overall Compliance    |
	| User App Compliance   |
	| Hardware Compliance   |
	| Device App Compliance |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075
Scenario: EvergreenJnr_UsersList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnUsersPage
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17355 @DAS17075
Scenario: EvergreenJnr_UsersList_CheckThaWorkflowTextAndValueArentDisplayedAtAllOnUsersPage
	When User navigates to the 'User' details page for 'AAC860150' item
	Then Details page for "AAC860150" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario: EvergreenJnr_UsersList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User navigates to the 'User' details page for 'ACG370114' item
	Then Details page for "ACG370114" item is displayed to the user
	Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857
Scenario: EvergreenJnr_UsersList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User navigates to the 'User' details page for 'ACG370114' item
	Then Details page for "ACG370114" item is displayed to the user
	When User navigates to the 'User' left submenu item
	Then following content is displayed on the Details Page
	| Title      | Value |
	| Compliance | RED   |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems    | ColorName |
	| Overall Compliance | RED       |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928 @DAS18405
Scenario: EvergreenJnr_UsersList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the 'User' details page for 'ACG370114' item
	Then Details page for "ACG370114" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title     | Value |
	| Readiness | GREY  |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | GREY      |