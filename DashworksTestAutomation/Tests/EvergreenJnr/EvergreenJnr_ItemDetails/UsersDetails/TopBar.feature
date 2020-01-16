Feature: TopBar
	Runs User Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_UsersList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnUsersPage
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	And following items are displayed in the top bar:
	| ComplianceItems       |
	| Overall Compliance    |
	| User App Compliance   |
	| Hardware Compliance   |
	| Device App Compliance |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075
Scenario: EvergreenJnr_UsersList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnUsersPage
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following items are displayed in the top bar:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following items are displayed in the top bar:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17355 @DAS17075
Scenario: EvergreenJnr_UsersList_CheckThaWorkflowTextAndValueArentDisplayedAtAllOnUsersPage
	When User navigates to the 'User' details page for 'AAC860150' item
	Then Details page for 'AAC860150' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following items are displayed in the top bar:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario: EvergreenJnr_UsersList_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User navigates to the 'User' details page for 'ACG370114' item
	Then Details page for 'ACG370114' item is displayed to the user
	Then dropdown is not opened
	Then options are sorted in alphabetical order in the 'Item Details Project' dropdown on item details page
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	Then dropdown is not opened
	Then options are sorted in alphabetical order in the 'Item Details Project' dropdown on item details page

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS19241
Scenario Outline: EvergreenJnr_UsersList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User navigates to the '<PageName>' details page for '<ItemName>' item
	Then Details page for '<ItemName>' item is displayed to the user
	When User navigates to the '<SubMenu>' left submenu item
	Then following content is displayed on the Details Page
	| Title      | Value   |
	| Compliance | <Value> |
	Then following items and colors are displayed in the top bar:
	| ComplianceItems    | ColorName |
	| Overall Compliance | <Value>   |

	Examples:
	| PageName    | ItemName       | SubMenu      | Value   |
	| User        | ACG370114      | User         | RED     |
	#DAS19241
	| User        | allanj         | User         | UNKNOWN |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928 @DAS18405
Scenario: EvergreenJnr_UsersList_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the 'User' details page for 'ACG370114' item
	Then Details page for 'ACG370114' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title     | Value |
	| Readiness | GREY  |
	Then following items and colors are displayed in the top bar:
	| ComplianceItems   | ColorName |
	| Overall Readiness | GREY      |