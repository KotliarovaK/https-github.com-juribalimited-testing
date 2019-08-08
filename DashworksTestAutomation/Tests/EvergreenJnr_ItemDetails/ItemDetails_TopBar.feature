﻿Feature: ItemDetails_TopBar
	Runs Item Details Top Bar related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11721
Scenario: EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForGroupDetailsPage
	When User type "NL00G001" in Global Search Field
	Then User clicks on "NL00G001" search result
	And Group Icon for Group Details page is displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_DevicesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems     |
	| Overall Compliance  |
	| App Compliance      |
	| Hardware Compliance |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_UsersList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems       |
	| Overall Compliance    |
	| User App Compliance   |
	| Hardware Compliance   |
	| Device App Compliance |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	And User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems    |
	| Overall Compliance |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_MailboxesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	And No one Compliance items are displayed for the User in Top bar on the Item details page

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16743
Scenario: EvergreenJnr_GroupsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnGroupsPage
	When User type "Allowed RODC Password Replication Group" in Global Search Field
	Then User clicks on "Allowed RODC Password Replication Group" search result
	Then Details page for "Allowed RODC Password Replication Group" item is displayed to the user
	And Top bar on the Item details page is not displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075
Scenario: EvergreenJnr_DevicesList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
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

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075
Scenario: EvergreenJnr_UsersList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
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
	
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075 @DAS17355
Scenario: EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	And User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
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

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075 @DAS17355
Scenario: EvergreenJnr_MailboxesList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| Task Readiness    |
	| Workflow          |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17166 @DAS17355
Scenario: EvergreenJnr_DevicesList_CheckThatValueForUseMeForAutomationProjectIsDisplayedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | RED       |
	| App Readiness     | RED       |
	| Task Readiness    | PURPLE    |
	| Workflow          | Failed    |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857 @DAS17005
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order

Examples:
	| PageName     | ColumnName    | ItemName                         | ProjectName                        |
	| Devices      | Hostname      | 001BAQXT6JWFPI                   | Devices Evergreen Capacity Project |
	| Users        | Username      | ACG370114                        | User Evergreen Capacity Project    |
	| Applications | Application   | 7zip                             | Computer Scheduled Test (Jo)       |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local | Mailbox Evergreen Capacity Project |
	
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User navigates to the "<SubMenu>" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title      | Value   |
	| Compliance | <Value> |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems    | ColorName |
	| Overall Compliance | <Value>   |

Examples:
	| PageName     | ColumnName  | ItemName       | SubMenu      | Value   |
	| Devices      | Hostname    | 001BAQXT6JWFPI | Device Owner | RED     |
	| Users        | Username    | ACG370114      | User         | RED     |
	| Applications | Application | 7zip           | Application  | UNKNOWN |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title   | Value   |
	| <Title> | <Value> |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | <Value>   |

Examples:
	| PageName     | ColumnName    | ItemName                         | Title             | Value | ProjectName                        |
	| Devices      | Hostname      | 001BAQXT6JWFPI                   | Overall Readiness | GREY  | Devices Evergreen Capacity Project |
	| Users        | Username      | ACG370114                        | Readiness         | GREY  | User Evergreen Capacity Project    |
	| Applications | Application   | 7zip                             | Overall Readiness | GREY  | Devices Evergreen Capacity Project |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local | Overall Readiness | NONE  | Mailbox Evergreen Capacity Project |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17002
Scenario: EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavocBigDataProject
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACD Display 3.4"
	And User click content from "Application" column
	Then Details page for "ACD Display 3.4" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title             | Value |
	| Overall Readiness | RED   |
	| App Readiness     | RED   |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | RED       |
	| App Readiness     | RED       |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17355 @DAS17075
Scenario: EvergreenJnr_UsersList_CheckThaWorkflowTextAndValueArentDisplayedAtAllOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "AAC860150"
	And User click content from "Username" column
	Then Details page for "AAC860150" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |