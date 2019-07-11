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

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921 @DAS16743
Scenario: EvergreenJnr_AllLists_CheckThatTopBarInEvergreenModeIsDisplayedCorrectly
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
	#=====================================================================================#
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
	#=====================================================================================#
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	And User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems    |
	| Overall Compliance |
	#=====================================================================================#
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	And No one Compliance items are displayed for the User in Top bar on the Item details page
	#=====================================================================================#
	When User type "Allowed RODC Password Replication Group" in Global Search Field
	Then User clicks on "Allowed RODC Password Replication Group" search result
	Then Details page for "Allowed RODC Password Replication Group" item is displayed to the user
	And Top bar on the Item details page is not displayed

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166 @DAS17075
Scenario: EvergreenJnr_AllLists_CheckThatTopBarInProjectModeIsDisplayedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	When User switches to the "Project K-Computer Scheduled Project" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	#=====================================================================================#
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	When User switches to the "Project K-Computer Scheduled Project" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	#=====================================================================================#
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	And User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User switches to the "1803 Rollout" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	When User switches to the "Computer Scheduled Test (Jo)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	#=====================================================================================#
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| Task Readiness    |
	| Workflow          |

	#Delete the tag "not ready" when new gold date will be on automation server
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17166 @Not_Ready
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