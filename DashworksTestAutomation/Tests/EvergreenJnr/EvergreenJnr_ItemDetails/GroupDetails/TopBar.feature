Feature: TopBar
	Runs Group Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11721
Scenario: EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForGroupDetailsPage
	When User type "NL00G001" in Global Search Field
	Then User clicks on "NL00G001" search result
	And Group Icon for Group Details page is displayed

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16743
Scenario: EvergreenJnr_GroupsList_CheckThatTopBarInEvergreenModeIsDisplayedCorrectlyOnGroupsPage
	When User type "Allowed RODC Password Replication Group" in Global Search Field
	Then User clicks on "Allowed RODC Password Replication Group" search result
	Then Details page for 'Allowed RODC Password Replication Group' item is displayed to the user
	Then top bar is not displayed