Feature: TopBar
	Runs Application Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnApplicationsPage
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for 'ABBYY FineReader 8.0 Professional Edition' item is displayed to the user
	Then following items are displayed in the top bar:
	| items              |
	| Overall Compliance |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075 @DAS17355
Scenario: EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnApplicationsPage
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for 'ABBYY FineReader 8.0 Professional Edition' item is displayed to the user
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	Then following items are displayed in the top bar:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following items are displayed in the top bar:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17002
Scenario: EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavocBigDataProject
	When User navigates to the 'Application' details page for 'ACD Display 3.4' item
	Then Details page for 'ACD Display 3.4' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title         | Value |
	| Readiness     | RED   |
	| App Readiness | RED   |
	Then following items and colors are displayed in the top bar:
	| ComplianceItems   | ColorName |
	| Overall Readiness | RED       |
	| App Readiness     | RED       |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User navigates to the 'Application' details page for '7zip' item
	Then Details page for '7zip' item is displayed to the user
	Then dropdown is not opened
	Then options are sorted in alphabetical order in the 'Item Details Project' dropdown on item details page
	When User selects 'Computer Scheduled Test (Jo)' in the 'Item Details Project' dropdown with wait
	Then dropdown is not opened
	Then options are sorted in alphabetical order in the 'Item Details Project' dropdown on item details page

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857
Scenario: EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User navigates to the 'Application' details page for '7zip' item
	Then Details page for '7zip' item is displayed to the user
	When User navigates to the 'Application' left submenu item
	Then following content is displayed on the Details Page
	| Title      | Value   |
	| Compliance | UNKNOWN |
	Then following items and colors are displayed in the top bar:
	| ComplianceItems    | ColorName |
	| Overall Compliance | UNKNOWN   |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928 @DAS18405
Scenario: EvergreenJnr_ApplicationsList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the 'Application' details page for '7zip' item
	Then Details page for '7zip' item is displayed to the user
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title     | Value |
	| Readiness | GREY  |
	Then following items and colors are displayed in the top bar:
	| ComplianceItems   | ColorName |
	| Overall Readiness | GREY      |