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