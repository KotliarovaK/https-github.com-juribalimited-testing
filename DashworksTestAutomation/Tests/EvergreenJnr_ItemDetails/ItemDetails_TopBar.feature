Feature: ItemDetails_TopBar
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
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
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
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems       |
	| Overall Compliance    |
	| User App Compliance   |
	| Hardware Compliance   |
	| Device App Compliance |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_ApplicationsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnApplicationsPage
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems    |
	| Overall Compliance |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_MailboxesList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
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
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
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
	
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075 @DAS17355
Scenario: EvergreenJnr_ApplicationsList_CheckThatTopBarInProjectModeIsDisplayedCorrectlyOnApplicationsPage
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
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
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| Task Readiness    |
	| Workflow          |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17166 @DAS17355
Scenario: EvergreenJnr_DevicesList_CheckThatValueForUseMeForAutomationProjectIsDisplayedCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
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
	When User navigates to the '<PageName>' details page for '<ItemName>' item
	Then Details page for "<ItemName>" item is displayed to the user
	Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order

Examples:
	| PageName    | ItemName                         | ProjectName                        |
	| Device      | 001BAQXT6JWFPI                   | Devices Evergreen Capacity Project |
	| User        | ACG370114                        | User Evergreen Capacity Project    |
	| Application | 7zip                             | Computer Scheduled Test (Jo)       |
	| Mailbox     | 000F977AC8824FE39B8@bclabs.local | Mailbox Evergreen Capacity Project |
	
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User navigates to the '<PageName>' details page for '<ItemName>' item
	Then Details page for "<ItemName>" item is displayed to the user
	When User navigates to the '<SubMenu>' left submenu item
	Then following content is displayed on the Details Page
	| Title      | Value   |
	| Compliance | <Value> |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems    | ColorName |
	| Overall Compliance | <Value>   |

Examples:
	| PageName    | ItemName       | SubMenu      | Value   |
	| Device      | 001BAQXT6JWFPI | Device Owner | RED     |
	| User        | ACG370114      | User         | RED     |
	| Application | 7zip           | Application  | UNKNOWN |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @DAS16928
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User navigates to the '<PageName>' details page for '<ItemName>' item
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item 
	Then following content is displayed on the Details Page
	| Title   | Value   |
	| <Title> | <Value> |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | <Value>   |

Examples:
	| PageName    | ItemName                         | Title     | Value | ProjectName                        |
	| Device      | 001BAQXT6JWFPI                   | Readiness | GREY  | Devices Evergreen Capacity Project |
	| User        | ACG370114                        | Readiness | GREY  | User Evergreen Capacity Project    |
	| Application | 7zip                             | Readiness | GREY  | Devices Evergreen Capacity Project |
	| Mailbox     | 000F977AC8824FE39B8@bclabs.local | Readiness | NONE  | Mailbox Evergreen Capacity Project |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17002
Scenario: EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavocBigDataProject
	When User navigates to the 'Application' details page for 'ACD Display 3.4' item
	Then Details page for "ACD Display 3.4" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title         | Value |
	| Readiness     | RED   |
	| App Readiness | RED   |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | RED       |
	| App Readiness     | RED       |

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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16959
Scenario: EvergreenJnr_Devices_CheckThatProjectsSwitcherDoesNotDuplicateItem
	When User navigates to the 'Device' details page for '00BDM1JUR8IF419' item
	Then Details page for "00BDM1JUR8IF419" item is displayed to the user
	Then Project Switcher in the Top bar on Item details page is closed
	When User clicks by Project Switcher in the Top bar on Item details page
	Then '*Project K-Computer Scheduled Project' project is displayed first in Project Switcher
	And 'Evergreen' project is not displayed in proposal list of in Project Switcher
	When User clicks refresh button in the browser
	And User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	Then Project Switcher in the Top bar on Item details page is closed
	When User clicks by Project Switcher in the Top bar on Item details page
	Then 'Evergreen' project is displayed first in Project Switcher