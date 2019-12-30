Feature: TopBar
	Runs Devices Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_DevicesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems     |
	| Overall Compliance  |
	| App Compliance      |
	| Hardware Compliance |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075
Scenario: EvergreenJnr_DevicesList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17166 @DAS17355
Scenario: EvergreenJnr_DevicesList_CheckThatValueForUseMeForAutomationProjectIsDisplayedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | RED       |
	| App Readiness     | BLUE      |
	| Task Readiness    | PURPLE    |
	| Workflow          | Failed    |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16959
Scenario: EvergreenJnr_Devices_CheckThatProjectsSwitcherDoesNotDuplicateItem
	When User navigates to the 'Device' details page for '00BDM1JUR8IF419' item
	Then Details page for '00BDM1JUR8IF419' item is displayed to the user
	Then dropdown is not opened
	When User clicks by Project Switcher in the Top bar on Item details page
	Then '*Project K-Computer Scheduled Project' project is displayed first in Project Switcher
	And 'Evergreen' project is not displayed in proposal list of in Project Switcher
	When User clicks refresh button in the browser
	And User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	Then dropdown is not opened
	When User clicks by Project Switcher in the Top bar on Item details page
	Then 'Evergreen' project is displayed first in Project Switcher

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario: EvergreenJnr_DevicesList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	Then dropdown is not opened
	Then projects on the Project Switcher panel are displayed in alphabetical order
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	Then dropdown is not opened
	Then projects on the Project Switcher panel are displayed in alphabetical order

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857
Scenario: EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Device Owner' left submenu item
	Then following content is displayed on the Details Page
	| Title      | Value |
	| Compliance | RED   |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems    | ColorName |
	| Overall Compliance | RED       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928 @DAS18405
Scenario: EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title     | Value |
	| Readiness | GREY  |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | GREY      |