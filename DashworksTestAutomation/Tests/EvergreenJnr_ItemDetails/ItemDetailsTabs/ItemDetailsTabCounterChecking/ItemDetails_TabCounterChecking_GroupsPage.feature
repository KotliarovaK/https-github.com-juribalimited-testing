Feature: ItemDetails_TabCounterChecking_GroupsPage
	Runs Item Details TabCounterChecking_GroupsPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Ann.Ilchenko 7/18/19: The navigation menu counters are ready in the 'Pulsar' release.
@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16833 @DAS17415 @Not_Ready
Scenario: EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForGroupsPage
	When User type "Allowed RODC Password Replication Group" in Global Search Field
	Then User clicks on "Allowed RODC Password Replication Group" search result
	And Details page for "Allowed RODC Password Replication Group" item is displayed to the user
	And User sees following main-tabs on left menu on the Details page:
	| TabName      |
	| Applications |
	| Members      |
	And "Group" tab is displayed on left menu on the Details page and NOT contains count of items
	And "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	And "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName   |
	| Applications |
	| Collections  |
	#================ checks counters ================#
	And "Applications" tab is displayed on left menu on the Details page and contains count of items
	And "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Members tab ================#
	Then "Members" main-menu on the Details page contains following sub-menu:
	| SubTabName     |
	| User Members   |
	| Device Members |
	| Member Of      |
	#================ checks counters ================#
	And "User Members" tab is displayed on left menu on the Details page and contains count of items
	And "Device Members" tab is displayed on left menu on the Details page and contains count of items
	And "Member Of" tab is displayed on left menu on the Details page and contains count of items