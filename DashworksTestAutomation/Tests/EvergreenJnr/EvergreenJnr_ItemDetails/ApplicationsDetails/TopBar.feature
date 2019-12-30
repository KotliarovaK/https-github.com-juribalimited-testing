Feature: TopBar
	Runs Application Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnApplicationsPage
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for 'ABBYY FineReader 8.0 Professional Edition' item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems    |
	| Overall Compliance |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075 @DAS17355
Scenario: EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnApplicationsPage
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for 'ABBYY FineReader 8.0 Professional Edition' item is displayed to the user
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17002
Scenario: EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavocBigDataProject
	When User navigates to the 'Application' details page for 'ACD Display 3.4' item
	Then Details page for 'ACD Display 3.4' item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title         | Value |
	| Readiness     | RED   |
	| App Readiness | RED   |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | RED       |
	| App Readiness     | RED       |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User navigates to the 'Application' details page for '7zip' item
	Then Details page for '7zip' item is displayed to the user
	Then dropdown is not opened
	Then projects on the Project Switcher panel are displayed in alphabetical order
	When User switches to the "Computer Scheduled Test (Jo)" project in the Top bar on Item details page
	Then dropdown is not opened
	Then projects on the Project Switcher panel are displayed in alphabetical order

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857
Scenario: EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User navigates to the 'Application' details page for '7zip' item
	Then Details page for '7zip' item is displayed to the user
	When User navigates to the 'Application' left submenu item
	Then following content is displayed on the Details Page
	| Title      | Value   |
	| Compliance | UNKNOWN |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems    | ColorName |
	| Overall Compliance | UNKNOWN   |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928 @DAS18405
Scenario: EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the 'Application' details page for '7zip' item
	Then Details page for '7zip' item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title     | Value |
	| Readiness | GREY  |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | GREY      |