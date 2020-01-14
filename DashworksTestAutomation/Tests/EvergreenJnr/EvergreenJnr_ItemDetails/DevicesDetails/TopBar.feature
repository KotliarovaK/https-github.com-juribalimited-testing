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
	And following items are displayed in the top bar:
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
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following items are displayed in the top bar:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following items are displayed in the top bar:
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
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following items and colors are displayed in the top bar:
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
	Then following Values are not displayed in the 'Item Details Project' dropdown:
	| Options   |
	| Evergreen |
	When User clicks refresh button in the browser
	And User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	Then dropdown is not opened
	Then 'Evergreen' option is first in the 'Item Details Project' dropdown

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario: EvergreenJnr_DevicesList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	Then dropdown is not opened
	Then options are sorted in alphabetical order in the 'Item Details Project' dropdown on item details page
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	Then dropdown is not opened
	Then options are sorted in alphabetical order in the 'Item Details Project' dropdown on item details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857
Scenario: EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Device Owner' left submenu item
	Then following content is displayed on the Details Page
	| Title      | Value |
	| Compliance | RED   |
	Then following items and colors are displayed in the top bar:
	| ComplianceItems    | ColorName |
	| Overall Compliance | RED       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928 @DAS18405
Scenario: EvergreenJnr_DevicesList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title     | Value |
	| Readiness | GREY  |
	Then following items and colors are displayed in the top bar:
	| ComplianceItems   | ColorName |
	| Overall Readiness | GREY      |